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

namespace scaryDolgozatNSZ
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {
            string Nev = nev.Text;
            string Szuldatum = szuldatum.Text;
            string Email = email.Text;
            string Telszam = telefonszam.Text;

            NameCardWindow nameCardWindow = new NameCardWindow();
            nameCardWindow.open(Nev, Szuldatum, Email, Telszam);
        }

        private void colors_Click(object sender, RoutedEventArgs e)
        {
            ColorSliderWindow colorSliderWindow = new ColorSliderWindow();
            colorSliderWindow.open();
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
