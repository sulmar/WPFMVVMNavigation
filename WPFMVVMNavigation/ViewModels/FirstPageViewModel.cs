using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPFMVVMNavigation.Common;

namespace WPFMVVMNavigation.ViewModels
{
    public class FirstPageViewModel : BaseViewModel
    {

        public FirstPageViewModel(INavigationService navigationService) : base(navigationService)
        {
        }


        public ICommand GoSecondsPageCommand
        {
            get => new RelayCommand(()=>navigationService.Navigate("SecondPageView", "Hello World!"));
        }
    }
}
