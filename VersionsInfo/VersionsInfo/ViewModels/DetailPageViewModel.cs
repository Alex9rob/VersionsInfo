using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;

namespace VersionsInfo.ViewModels
{
	public class DetailPageViewModel : ViewModelBase
	{
	    private Version _version;
	    public Version Version
        {
	        get { return _version; }
	        set { SetProperty(ref _version, value); }
	    }
        public DetailPageViewModel(INavigationService navigationService) : base(navigationService)
	    {
           
	    }

        public override void OnNavigatedTo(NavigationParameters parameters)
	    {
	        if (parameters.ContainsKey("data"))
	        {
	            Version = (Version) parameters["data"];
	        }
	    }
	}
}
