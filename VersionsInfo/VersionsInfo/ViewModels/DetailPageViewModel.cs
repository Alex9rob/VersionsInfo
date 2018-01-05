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
	    private IService _service;
	    public DetailPageViewModel(INavigationService navigationService) : base(navigationService)
	    {
	        //_service = service;
	    }

	    private void Button_OnClicked(object sender, EventArgs e)
	    {

	        //throw new NotImplementedException();
	    }

        public override void OnNavigatedTo(NavigationParameters parameters)
	    {
	        if (parameters.ContainsKey("id"))
	        {
	            var param = (Version) parameters["id"];
	        }
	    }
	}
}
