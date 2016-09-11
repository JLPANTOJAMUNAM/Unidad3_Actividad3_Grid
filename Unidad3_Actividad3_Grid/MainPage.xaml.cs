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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Unidad3_Actividad3_Grid
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

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (Cuenta.Text == "") return;
            if (Clientes.SelectedIndex.ToString() == "0") return;
            if (Propina.SelectedIndex.ToString() == "0") return;

            decimal vRes1 = 0;
            decimal vRes2 = 0;
            Decimal vCta = Convert.ToDecimal(Cuenta.Text);
            var vPer = (ComboBoxItem)Clientes.SelectedItem;
            var vPro = (ComboBoxItem)Propina.SelectedItem;

            vRes1 = 1 + (Convert.ToDecimal(vPro.Content) / 100);
            vRes2 = vCta * vRes1;
            vRes1 = vRes2 / Convert.ToInt32(vPer.Content);
            resultado1.Text = "Total: $" + vRes2.ToString("#,###.00");
            resultado2.Text = "Individual: $" + vRes1.ToString("#,###.00");
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Cuenta.Text = "";
            Clientes.SelectedIndex = 0;
            Propina.SelectedIndex = 0;
            resultado1.Text = "";
            resultado2.Text = "";
        }
    }
}
