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

namespace ZadanieB
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

        double Potega(double x, int wykladnik)
        {
            if(wykladnik < 0 )
            {
                throw new ArgumentException("ZŁY ARGUMENT");
            }
           // double wynik;

            if(wykladnik != 0)
            {
                return x * Potega(x, --wykladnik);
            }
            else
            {
                return 1;
            }

            //return wynik;
        }

        private void btnPotega_Click(object sender, RoutedEventArgs e)
        {
            

            try
            {
                double liczba = Convert.ToDouble(txtLiczba.Text);
                int wykladnik = Convert.ToInt32(txtWykladnik.Text);

                //Potega(liczba, wykladnik);
                lbWynik.Content = $"{Potega(liczba, wykladnik):F2}";
            }
            catch (ArgumentException)
            {
                MessageBox.Show("ZŁY ARGUMENT");
            }
            catch
            {
                MessageBox.Show("INTERUPTED!");
            }

        }
    }
}