using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Wpf_Up_Down_Bar
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void pbStatus_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void downButton_Click(object sender, RoutedEventArgs e)
        {
            pbStatus.Value -= 5;
        }

        private void upButton_Click(object sender, RoutedEventArgs e)
        {
            pbStatus.Value += 5;
        }
    }
}
