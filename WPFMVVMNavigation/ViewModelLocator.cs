using WPFMVVMNavigation.Services;
using WPFMVVMNavigation.ViewModels;

namespace WPFMVVMNavigation
{
    public class ViewModelLocator
    {
        public FirstPageViewModel FirstPageViewModel => new FirstPageViewModel(App.Navigation, new MockCustomersService());
        public SecondPageViewModel SecondPageViewModel => new SecondPageViewModel(App.Navigation);
    }
}
