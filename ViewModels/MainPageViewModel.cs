using System.Collections.ObjectModel;
using ThyUcusArama.Models.GetPortList;
using ThyUcusArama.Services;

namespace ThyUcusArama.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        private readonly ThysApi _thysApi;
        private string _apiKey;
        public ObservableCollection<Port> Ports { get; set; } = new ObservableCollection<Port>();

        public MainPageViewModel()
        {
            _apiKey = l7xx489657031af74a2b94722ab7f62fb04f;
            _thysApi = new ThysApi(_apiKey);

            LoadPorts();
        }

        private async void LoadPorts()
        {
            var request = new GetPortListRequest
            {
                RequestHeader = new RequestHeader()
            };

            var portListResponse = await _thysApi.GetPortListAsync(request);

            if (portListResponse.Status == "SUCCESS")
            {
                foreach (var port in portListResponse.Data.Port)
                {
                    Ports.Add(port);
                }
            }
        }
    }
}