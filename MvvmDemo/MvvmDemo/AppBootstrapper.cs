using System.Collections.Generic;
using System.Reflection;
using System.Windows;
using Caliburn.Micro;
using MvvmDemo.ViewModels;

namespace MvvmDemo
{
    public class AppBootstrapper : BootstrapperBase
    {
        public AppBootstrapper()
        {
            Initialize();
        }

        protected override IEnumerable<Assembly> SelectAssemblies()
        {
            return new[] {
                Assembly.GetExecutingAssembly()
            };
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<MyViewModel>();
        }
    }
}
