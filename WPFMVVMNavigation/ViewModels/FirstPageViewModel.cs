using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPFMVVMNavigation.Common;
using WPFMVVMNavigation.Models;

namespace WPFMVVMNavigation.ViewModels
{
    public class FirstPageViewModel : BaseViewModel
    {
        public IList<Customer> Customers { get; set; }

        public FirstPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Customers = new List<Customer>
            {
                new Customer { CustomerId = 1, FirstName = "Marcin" },
                new Customer { CustomerId = 1, FirstName = "Kasia" },
                new Customer { CustomerId = 1, FirstName = "Bartek" },
            };
        }


        public ICommand GoSecondsPageCommand
        {
            get => new RelayCommand(()=>navigationService.Navigate("SecondPageView", Customers.First()));
        }
    }
}
