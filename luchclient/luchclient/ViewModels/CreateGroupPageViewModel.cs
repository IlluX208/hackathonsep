using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace luchclient.ViewModels
{
    public class CreateGroupPageViewModel : ViewModelBase
    {
        public CreateGroupPageViewModel(INavigationService navigationService)
                    : base(navigationService)
        {
            Title = "Create group";
        }
    }
}
