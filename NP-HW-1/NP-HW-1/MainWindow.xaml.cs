using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NP_HW_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void SearchButton(object sender, RoutedEventArgs e)
        {
            var hostDomen = Dns.GetHostEntry(ipOrDomen.Text);
            result.Text = hostDomen.HostName;
            foreach (IPAddress ip in hostDomen.AddressList)
            {
                result.Text += $" \n{ip.ToString()}";
            }
        }
    }
}
