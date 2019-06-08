using luchclient.Views;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Refit;
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
        public ICommand NavigateSelectGroupCommand { get; }
        public ICommand NavigateViewVotesCommand { get; }
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";

            NavigateCreateGroupCommand = new DelegateCommand(NavigateToCreateGroup);
            NavigateSelectGroupCommand = new DelegateCommand(NavigateToSelectGroup);
            NavigateViewVotesCommand = new DelegateCommand(NavigateToViewVotes);
        }

        void NavigateToCreateGroup()
        { 
            this.NavigationService.NavigateAsync(nameof(CreateGroupPage));
        }
        void NavigateToSelectGroup()
        {
            this.NavigationService.NavigateAsync(nameof(SelectGroupPage));
        }
        void NavigateToViewVotes()
        {
            this.NavigationService.NavigateAsync(nameof(ViewVotesPage));
        }
    }
}
