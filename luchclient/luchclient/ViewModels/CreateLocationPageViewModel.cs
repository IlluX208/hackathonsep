using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using luchclient.Views;
using Prism.Commands;

using Xamarin.Forms;

namespace luchclient.ViewModels
{
    public class CreateLocationPageViewModel : ViewModelBase
    {
        public string NewLocation { get; set; } = "Insert new location here!";
        public ICommand NavigateSelectLocationCommand { get; }
        public CreateLocationPageViewModel(INavigationService navigationService)
                    : base(navigationService)
        {
            Title = "Create location";

            NavigateSelectLocationCommand = new DelegateCommand(NavigateToSelectLocationPage);
        }
        void NavigateToSelectLocationPage()
        {
            this.NavigationService.NavigateAsync(nameof(SelectLocationPage));
        }
    }
}