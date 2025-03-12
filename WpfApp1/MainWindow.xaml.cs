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

namespace WpfApp1;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    void RysujLinie()
    {
        int x1, y1, x2, y2;
        Random rnd = new Random();
        x1 = rnd.Next(0, 300);
        y1 = rnd.Next(0, 300);
        x2 = rnd.Next(0, 300);
        y2 = rnd.Next(0, 300);

        var myLine = new Line();
        myLine.Stroke = Brushes.Red;
        myLine.X1 = x1;
        myLine.X2 = x2;
        myLine.Y1 = y1;
        myLine.Y2 = y2;
        myLine.HorizontalAlignment = HorizontalAlignment.Left;
        myLine.VerticalAlignment = VerticalAlignment.Center;
        myLine.StrokeThickness = 2;
        cvRysunek.Children.Add(myLine);
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        int ilosc;
        try
        {
            ilosc = Convert.ToInt32(txtIlosc.Text);
            

            if (ilosc >= 0)
            {
                for(int i = 0; i < ilosc; i++)
                {
                    RysujLinie();
                }
            }
            else
            {
                throw new NotImplementedException("");
            }
        }
        catch
        {
            MessageBox.Show("NIEPOPRAWNA ILOSC");
        }

    }

    private void btnClear_Click(object sender, RoutedEventArgs e)
    {
        cvRysunek.Children.Clear(); // czyszczenie
    }
}