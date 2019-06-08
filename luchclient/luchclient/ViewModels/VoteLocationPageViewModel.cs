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
    public class VoteLocationPageViewModel : ViewModelBase
    {

        public List<String> GroupLocations { get; } = new List<string>();
        public String SelectedLocation { get; set; }
        public ICommand NavigateGroupLocationPageCommand { get; }

        public VoteLocationPageViewModel(INavigationService navigationService)
                    : base(navigationService)
        {
            {
                Title = "Vote Location";

                GroupLocations.Add("Pizza1 (3 votes)");
                GroupLocations.Add("Pizza2 (3 votes)");
                GroupLocations.Add("Pizza3 (3 votes)");
                GroupLocations.Add("Pizza4 (3 votes)");
                GroupLocations.Add("Pizza5 (3 votes)");
                GroupLocations.Add("Sushi (0 votes)");

                NavigateGroupLocationPageCommand = new DelegateCommand(NavigateToMainPage);
            }

        }
        void NavigateToMainPage()
        {
            this.NavigationService.NavigateAsync(nameof(MainPage));
        }
    }
}