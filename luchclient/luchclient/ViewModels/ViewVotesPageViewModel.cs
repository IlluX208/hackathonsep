using luchclient.Views;
using Prism.Commands;
using Prism.Navigation;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

using Xamarin.Forms;

namespace luchclient.ViewModels
{
    public class ViewVotesPageViewModel : ViewModelBase
    {
        public ViewVotesPageViewModel(INavigationService navigationService)
                    : base(navigationService)
        {
            Title = "View votes";
        }
    }
}