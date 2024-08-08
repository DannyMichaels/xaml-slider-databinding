using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFSliderApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private object txtSliderValue;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void slHome_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //if (txtSlHomeValue != null)
            //{
            //    txtSlHomeValue.Text = slHome.Value.ToString() + "%";
            //    txtSlHomeValue.FontSize = slHome.Value <= 0d ? 1 : slHome.Value;
            //}
        }
    }
}