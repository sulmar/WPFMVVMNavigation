using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFMVVMNavigation.Common;

namespace WPFMVVMNavigation.ViewModels
{
    public abstract class ViewModelBase
    {

        protected readonly INavigationService navigationService;

        public ViewModelBase(INavigationService navigationService)
        {
            this.navigationService = navigationService;
        }
    }
}
