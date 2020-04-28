using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPF_UI.ViewModels;

namespace WPF_UI
{
    public class Bootstrapper :BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();
        }
         
        protected override void OnStartup(object sender, StartupEventArgs e)
        {
           // Will launch "ShellViewModel" instead of default MainWindow.xaml
            DisplayRootViewFor<ShellViewModel>();
        }
    }
}
