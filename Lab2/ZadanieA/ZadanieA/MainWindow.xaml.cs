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

namespace ZadanieA
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        double Iloczyn(double a, double b)
        {
            return a * b;
        }

        double Kwadrat(double a)
        {
           return Iloczyn(a, a);
        }

        double PoleKola(double r)
        {
            return Math.PI * Kwadrat(r);
        }

        double ObjetoscWalca(double h, double r)
        {
            return PoleKola(r) * h;
        }
        double ObjetoscWalca(double h)
        {
            return (ObjetoscWalca(h, h) /2.0);
        }

        private void btnTest1_Click(object sender, RoutedEventArgs e)
        {
            lbWyniki.Items.Add($"Iloczyn 5 i 3: {Iloczyn(5, 3):F2}");
            lbWyniki.Items.Add($"Iloczyn 5 i 3: {Kwadrat(5):F2}");
            lbWyniki.Items.Add($"Pole koła r = 5: { PoleKola(5):F2} ");
            lbWyniki.Items.Add($"Objętość Walca h = 5, r = 2: {ObjetoscWalca(5, 2):F2}");
            lbWyniki.Items.Add($"Objętość Walca h = 5: {ObjetoscWalca(5):F2}");
        }

        private void btnCzysc_Click(object sender, RoutedEventArgs e)
        {
            lbWyniki.Items.Clear();
        }
    }
}