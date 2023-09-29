using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace BlazorHybridTest
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        App()
        {
            AppDomain.CurrentDomain.UnhandledException += (sender, error) =>
            {
#if DEBUG
                MessageBox.Show(error.ExceptionObject.ToString(), caption: "Error");
#else
    MessageBox.Show(text: "An error has occurred.", caption: "Error");
#endif

                // Log the error information (error.ExceptionObject)
            };
        }
    }


}
