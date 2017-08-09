using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPFMVVMNavigation.Common;
using WPFMVVMNavigation.Models;
using WPFMVVMNavigation.Views;

namespace WPFMVVMNavigation.ViewModels
{
    public class SecondPageViewModel : ViewModelBase
    {
        public Customer Customer { get; set; }

        public SecondPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            this.Customer = navigationService.Parameter as Customer;
        }

        public ICommand GoFirstPageCommand
        {
            get => new RelayCommand(p => navigationService.GoBack());
        }
    }
}
