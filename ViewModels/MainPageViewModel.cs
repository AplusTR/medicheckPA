using System.Collections.ObjectModel;
using ThyUcusArama.Models.GetPortList;
using ThyUcusArama.Services;

namespace ThyUcusArama.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        private readonly ThysApi _thysApi;
        private readonly string _apiKey;
        public ObservableCollection<Port> Ports { get; set; } = new ObservableCollection<Port>();

        public MainPageViewModel()
        {
            _apiKey = "l7xx489657031af74a2b94722ab7f62fb04f";
            _thysApi = new ThysApi(_apiKey);

            LoadPortsAsync().ConfigureAwait(false);
        }

        private async Task LoadPortsAsync()
        {
            try
            {
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
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error loading ports: {ex.Message}");
                // TODO: Show error to user
            }
        }
    }
}