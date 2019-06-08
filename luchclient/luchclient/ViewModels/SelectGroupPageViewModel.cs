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
    public class SelectGroupPageViewModel : ViewModelBase
    {
        public List<String> GroupLocations { get; } = new List<string>();
        public String SelectedLocation { get; set; }
        public ICommand NavigateSelectLocationCommand { get; }

        public SelectGroupPageViewModel(INavigationService navigationService)
                    : base(navigationService)
        {
            Title = "Select group";

            GroupLocations.Add("Kollegium1");
            GroupLocations.Add("Kollegium2");
            GroupLocations.Add("Kollegium3");
            GroupLocations.Add("Kollegium4");
            GroupLocations.Add("Kollegium5");
            GroupLocations.Add("Neues Kollegium");

            NavigateSelectLocationCommand = new DelegateCommand(NavigateToSelectLocation);
        }

        // Dictionary to get Color from color name.
        void NavigateToSelectLocation()
        {
            this.NavigationService.NavigateAsync(nameof(SelectLocationPage));
        }



    }
}