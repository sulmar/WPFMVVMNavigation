using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPFMVVMNavigation.Common;
using WPFMVVMNavigation.Views;

namespace WPFMVVMNavigation.ViewModels
{
    public class SecondPageViewModel : BaseViewModel
    {
        public string Message { get; set; }

        public SecondPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            //this.Message = navigationService.GetParameter<string>();

            this.Message = (string) navigationService.Parameter;
        }

        public ICommand GoFirstPageCommand
        {
            get => new RelayCommand(() => navigationService.Navigate<FirstPageView>());
        }
    }
}
