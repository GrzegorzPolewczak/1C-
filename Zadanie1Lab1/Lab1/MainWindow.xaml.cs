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

namespace Lab1
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

        private void btnOblicz_Click(object sender, RoutedEventArgs e)
        {
            double r, h, V = 0, pp = 0;
            
            try
            {
                r = Convert.ToDouble(txtPromien.Text);
                h = Convert.ToDouble(txtWysokosc.Text);
              

                if(r > 0 && h>0)
                {
                

                    switch(cbxRodzajBryly.SelectedIndex)
                    {
                        case 0:
                                if (chkObliczObjetosc.IsChecked == true)
                                    V = Math.PI * Math.Pow(r, 2) * h;

                                if (chkObliczPolePow.IsChecked == true)
                                    pp = (2 * Math.PI * Math.Pow(r, 2)) + (2 * Math.PI * r * h);
                            break;
                        case 1:
                                if (chkObliczObjetosc.IsChecked == true)
                                    V = 1.0 / 3.0 * Math.PI * Math.Pow(r, 2) * h;
                                if (chkObliczPolePow.IsChecked == true)
                                    pp = (Math.PI * Math.Pow(r, 2)) + (Math.PI * r * Math.Sqrt(Math.Pow(r, 2))) + Math.Pow(h, 2);
                            break;
                        case 2:
                                if (chkObliczObjetosc.IsChecked == true)
                                    V = 4.0 / 3.0 * Math.PI * Math.Pow(r, 3);
                                if (chkObliczPolePow.IsChecked == true)
                                    pp = 4.0 * Math.PI * Math.Pow(r, 2);
                            break;
                        default: throw new NotImplementedException();
                    }
                    
                    lbWynik.Content = $"Objętość wynosi {V:F2}.";

                 
                    lbPP.Content = $"Pole powierzchni wynosi {pp:F2}";
                }
            }
            catch
            {
                MessageBox.Show("Zły format danych");
            }
        

         
        }

        private void cbxRodzajBryly_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(cbxRodzajBryly.SelectedIndex == 1)
            {
                txtWysokosc.Visibility = Visibility.Collapsed;
            }
            else
            {
                txtWysokosc.Visibility = Visibility.Visible;

            }
        }

        private void btnZamknij_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Czy jesteś pewien?", "Zamykanie", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                this.Close();
        }
    }
}