using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFMVVMNavigation.Common
{
    public interface INavigationService
    {
        void GoForward();
        void GoBack();
        bool Navigate(string page, object parameter = null);
        bool Navigate<T>(object parameter = null);
    }
}
