using System.Collections.ObjectModel;
using Prism.Commands;
using Prism.Navigation;

namespace VersionsInfo.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public DelegateCommand<Version> NavigateToDetailPageCommand { get; private set; }
        public ObservableCollection<Version> Versions
        {
            get { return _versions; }
            set { SetProperty(ref _versions, value); }
        }
        private ObservableCollection<Version> _versions;

        public MainPageViewModel(INavigationService navigationService, IService service) : base(navigationService)
        {
            Title = "Android Versions";
            NavigateToDetailPageCommand = new DelegateCommand<Version>(NavigateToDetailPage);
            Versions = new ObservableCollection<Version>(service.GetVersionsAndroid());
        }

        private void NavigateToDetailPage(Version version)
        {
            var p = new NavigationParameters
            {
                { "data", version }
            };
            NavigationService.NavigateAsync("DetailPage", p);
        }
    }
}
