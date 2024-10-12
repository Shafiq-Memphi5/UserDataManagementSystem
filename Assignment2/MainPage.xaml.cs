using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Popups;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Assignment2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public async void Mes(string message)
        {
            var mes = new ContentDialog()
            {
                Content = message,
                CloseButtonText = "OK"
            };
            await mes.ShowAsync();
        }
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void PasteData(object sender, RoutedEventArgs e)
        {
            Mes("You've entered: " + txtName.Text);
            txtBlock.Text = txtName.Text;
        }

        private void SwitchToggle(object sender, RoutedEventArgs e)
        {
            if (switchTog.IsOn)
            {
                Mes("Power is now ON");
            }
            else
            {
                Mes("Power is now OFF");
            }
        }

        private void Copy(object sender, RoutedEventArgs e)
        {
            Mes("Data Copied Successfully");
        }
        private void Paste(object sender, RoutedEventArgs e)
        {
            Mes("Data Pasted Successfully");
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(NextPage));
        }
    }
}
