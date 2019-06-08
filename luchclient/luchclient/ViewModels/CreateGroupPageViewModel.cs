using luchclient.Views;
using Prism.Commands;
using Prism.Navigation;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace luchclient.ViewModels
{
   

    public class CreateGroupPageViewModel : ViewModelBase
    {
        public string NewGroup { get; set; } = "Insert new group name here!";
        public ICommand NavigateMainPageCommand { get; }

        public CreateGroupPageViewModel(INavigationService navigationService)
                    : base(navigationService)
        {
            Title = "Create group";
            
            NavigateMainPageCommand = new DelegateCommand(NavigateToMainPage);
        }

        void NavigateToMainPage()
        {
            this.NavigationService.NavigateAsync(nameof(MainPage));
        }
    }
}
