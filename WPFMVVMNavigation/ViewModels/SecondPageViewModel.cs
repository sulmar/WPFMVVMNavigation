using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPFMVVMNavigation.Common;

namespace WPFMVVMNavigation.ViewModels
{
    public class SecondPageViewModel : BaseViewModel
    {
        public SecondPageViewModel(INavigationService navigationService) : base(navigationService)
        {
        }

        public ICommand GoFirstPageCommand
        {
            get => new RelayCommand(() => navigationService.Navigate("FirstPageView"));
        }
    }
}
