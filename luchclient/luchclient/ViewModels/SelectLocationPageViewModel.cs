using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using luchclient.Views;
using Prism.Commands;
using Prism.Navigation;

using Xamarin.Forms;

namespace luchclient.ViewModels
{
    public class SelectLocationPageViewModel : ViewModelBase
    {
        public ICommand NavigateCreateLocationPageCommand { get; }
        public ICommand NavigateVoteLocationPageCommand { get; }
        public SelectLocationPageViewModel(INavigationService navigationService)
                    : base(navigationService)
        {
            Title = "Select location";
            NavigateCreateLocationPageCommand = new DelegateCommand(NavigateToCreateLocationPage);
            NavigateVoteLocationPageCommand = new DelegateCommand(NavigateToVoteLocationPage);
        }
        void NavigateToVoteLocationPage()
        {
            this.NavigationService.NavigateAsync(nameof(VoteLocationPage));
        }
        void NavigateToCreateLocationPage()
        {
            this.NavigationService.NavigateAsync(nameof(CreateLocationPage));
        }
    }
}