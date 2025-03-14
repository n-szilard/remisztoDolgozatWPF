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
using System.Windows.Shapes;

namespace scaryDolgozatNSZ
{
    /// <summary>
    /// Interaction logic for NameCardWindow.xaml
    /// </summary>
    public partial class NameCardWindow : Window
    {
        public NameCardWindow()
        {
            InitializeComponent();
        }

        public void open(string nev, string szul, string email, string telefon)
        {

            cardName.Text = nev;
            cardBirthDate.Text = szul;
            cardEmail.Text = email;
            cardPhoneNumber.Text = telefon;
            ShowDialog();
        }
    }
}
