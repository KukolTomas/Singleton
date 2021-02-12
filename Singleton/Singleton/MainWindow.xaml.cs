using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace Singleton
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string text = ROD.Text;
            SingletonTest singleton = SingletonTest.Instance;
            if (Jmeno.Text == "" || Prijmeni.Text == "" || !DateTime.TryParse(DOB.Text, out DateTime result) || !text.Contains("/") )
            {
                MessageBox.Show("Zadejte všechny parametry");
            }
            else
            {
                singleton.AddToList(Jmeno.Text, Prijmeni.Text, Convert.ToString(result),ROD.Text);
            }
        }
    }
}
