using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFMVVMNavigation.Models;

namespace WPFMVVMNavigation.Services
{
    public interface ICustomersService
    {
        IList<Customer> Get();
    }
}
