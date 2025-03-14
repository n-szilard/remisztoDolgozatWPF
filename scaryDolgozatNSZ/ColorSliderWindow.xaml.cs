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
    /// Interaction logic for ColorSliderWindow.xaml
    /// </summary>
    public partial class ColorSliderWindow : Window
    {
        public ColorSliderWindow()
        {
            InitializeComponent();
        }

        public void open()
        {
            ShowDialog();
        }

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            byte red = (byte)rSlider.Value;
            byte green = (byte)gSlider.Value;
            byte blue = (byte)bSlider.Value;

            PanelColorChange(red, green, blue);

        }

        private void PanelColorChange(byte red, byte green, byte blue)
        {
            byte red2 = (byte)(255-red);
            byte green2 = (byte)(255 - green);
            byte blue2 = (byte)(255 - blue);

            MainGrid.Background = new SolidColorBrush(Color.FromRgb(red, green, blue));
            caption.Foreground = new SolidColorBrush(Color.FromRgb(red2,green2,blue2));
        }
    }
}
