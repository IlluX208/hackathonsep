using luchclient.Views;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace luchclient.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public ICommand NavigateCreateGroupCommand { get; }

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";

            NavigateCreateGroupCommand = new DelegateCommand(NavigateToCreateGroup);
        }

        void NavigateToCreateGroup()
        {
            this.NavigationService.NavigateAsync(nameof(CreateGroupPage));
        }
    }
}
