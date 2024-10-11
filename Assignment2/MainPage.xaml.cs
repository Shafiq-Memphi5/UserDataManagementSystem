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
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void PasteData(object sender, RoutedEventArgs e)
        {
            var mes = new MessageDialog("You've entered: " + txtName.Text);
            txtBlock.Text = txtName.Text;
            await mes.ShowAsync();
        }

        private async void SwitchToggle(object sender, RoutedEventArgs e)
        {
            if (switchTog.IsOn)
            {
                var mes = new MessageDialog("Power is now ON");
                await mes.ShowAsync();
            }
            else
            {
                var mes = new MessageDialog("Power is now OFF");
                await mes.ShowAsync();
            }
        }
    }
}
