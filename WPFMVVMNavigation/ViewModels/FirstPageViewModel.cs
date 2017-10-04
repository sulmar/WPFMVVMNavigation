using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPFMVVMNavigation.Common;
using WPFMVVMNavigation.Models;
using WPFMVVMNavigation.Services;
using WPFMVVMNavigation.Views;

namespace WPFMVVMNavigation.ViewModels
{
    public class FirstPageViewModel : ViewModelBase
    {
        public IList<Customer> Customers { get; set; }

        public Customer SelectedCustomer { get; set; }

        private readonly ICustomersService service;

        public FirstPageViewModel(INavigationService navigationService, ICustomersService service) : base(navigationService)
        {
            this.service = service;

            Load();
            
        }

        public void Load()
        {
            Customers = service.Get();
        }


        public ICommand GoSecondsPageCommand
        {
            get => new RelayCommand(p=>navigationService.Navigate<SecondPageView>(SelectedCustomer));
        }

        public ICommand AddCustomerCommand
        {
            get => new RelayCommand(p => AddCustomer());
        }


        private void AddCustomer()
        {
            var customer = new Customer();

            navigationService.Navigate<SecondPageView>(customer);

            Customers.Add(customer);
        }

    }
}
