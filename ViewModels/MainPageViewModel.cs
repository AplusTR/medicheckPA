using System.Collections.ObjectModel;
using Microsoft.Extensions.Configuration;
using ThyUcusArama.Models;
using ThyUcusArama.Services;

namespace ThyUcusArama.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        private readonly ThysApi _thysApi;
        private readonly IConfiguration _configuration;
        public ObservableCollection<Port> Ports { get; set; } = new ObservableCollection<Port>();
        private bool _isLoading;
        private string _errorMessage;

        public bool IsLoading
        {
            get => _isLoading;
            set => SetProperty(ref _isLoading, value);
        }

        public string ErrorMessage
        {
            get => _errorMessage;
            set => SetProperty(ref _errorMessage, value);
        }

        public MainPageViewModel(IConfiguration configuration)
        {
            _configuration = configuration;
            var apiKey = _configuration.GetSection("AppSettings:ApiKey").Value;
            _thysApi = new ThysApi(apiKey);

            LoadPortsAsync().ConfigureAwait(false);
        }

        private async Task LoadPortsAsync()
        {
            try
            {
                IsLoading = true;
                ErrorMessage = string.Empty;

                var request = new GetPortListRequest
                {
                    RequestHeader = new RequestHeader()
                };

                var portListResponse = await _thysApi.GetPortListAsync(request);

                if (portListResponse?.Status == "SUCCESS" && portListResponse.Data?.Port != null)
                {
                    MainThread.BeginInvokeOnMainThread(() =>
                    {
                        Ports.Clear();
                        foreach (var port in portListResponse.Data.Port)
                        {
                            Ports.Add(port);
                        }
                    });
                }
                else
                {
                    ErrorMessage = "Havalimanı listesi alınamadı. Lütfen daha sonra tekrar deneyin.";
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = "Bir hata oluştu: " + ex.Message;
                System.Diagnostics.Debug.WriteLine($"Error loading ports: {ex.Message}");
            }
            finally
            {
                IsLoading = false;
            }
        }
    }
}