using Prism.Commands;
using Prism.Navigation;

namespace VersionsInfo.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        //private INavigationService _navigationService;
        public DelegateCommand NavigateToDetailPageCommand { get; private set; }

        public MainPageViewModel(INavigationService navigationService) : base (navigationService)
        {
            Title = "Main Page";
           // _navigationService = navigationService;
           //NavigationService
            NavigateToDetailPageCommand = new DelegateCommand(NavigateToDetailPage);
        }

        private void NavigateToDetailPage()
        {
            var p = new NavigationParameters();
            var version = new Version("codeName", "versionNumber", "description");
            p.Add("id", version);
            NavigationService.NavigateAsync("DetailPage", p);
        }
    }
}
