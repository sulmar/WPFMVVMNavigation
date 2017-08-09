using System;
using System.Linq;
using System.Reflection;
using System.Windows.Controls;

namespace WPFMVVMNavigation.Common
{
    public class NavigationService : INavigationService
    {
        private readonly Frame frame;

        public object Parameter { get; private set; }

        public NavigationService(Frame frame)
        {
            this.frame = frame;

            this.frame.Navigated += Frame_Navigated;
        }



        private void Frame_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {
            //Parameter = e.ExtraData;
        }

        public void GoBack() =>  frame.GoBack();

        public void GoForward() => frame.GoForward();

        public bool Navigate<T>(object parameter = null)
        {
            var type = typeof(T);
            return Navigate(type, parameter);
        }

        public bool Navigate(string page, object parameter = null)
        {
            var type = Assembly.GetExecutingAssembly().GetTypes().SingleOrDefault(a => a.Name.Equals(page));
            if (type == null) return false;

            return Navigate(type, parameter);
        }

        public bool Navigate(Type source, object parameter = null)
        {
            Parameter = parameter;
            var src = Activator.CreateInstance(source);
            return frame.Navigate(src, parameter);
        }

        public T GetParameter<T>()
        {
            return (T)Parameter;
        }
    }
}
