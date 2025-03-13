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

namespace ZadanieC
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

        void Prostokat(double a, double b, out double pole, out double obwod, out double przekotna)
        {
            pole = a * b;
            obwod = (2 * b) + (2 * a);
            przekotna = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        }

        private void btnTest3_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double a, b, pole, obwod, przekotna;
                a = Convert.ToDouble(txtA.Text);
                b = Convert.ToDouble(txtB.Text);
                Prostokat(a, b, out pole,out obwod,out przekotna);

                MessageBox.Show($"Pole: {pole:F2} \n" +
                    $"Obwod: {obwod:F2} \n" +
                    $"Przekotna: {przekotna:F2}");
            }
            catch
            {
                MessageBox.Show("Błędne dane");
            }
        }
    }
}