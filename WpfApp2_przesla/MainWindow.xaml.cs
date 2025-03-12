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

namespace WpfApp2_przesla;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        cvRysunek.Children.Clear();
    }

    void RysujLinie(int x1, int y1, int x2, int y2)
    {
        var myLine = new Line();
        myLine.Stroke = Brushes.Black;
        myLine.X1 = x1;
        myLine.X2 = x2;
        myLine.Y1 = y1;
        myLine.Y2 = y2;
        myLine.HorizontalAlignment = HorizontalAlignment.Left;
        myLine.VerticalAlignment = VerticalAlignment.Center;
        myLine.StrokeThickness = 4;
        cvRysunek.Children.Add(myLine);
    }
    void RysujPrzesla()
    {
        int x1 = 0;
        int y1 = 0;
        int x2 = 0;
        int y2 = 190;
        for (int i = 0; i < 20; i++)
        {
            RysujLinie(x1, y1, x2, y2);
            x1 += 10;
            x2 += 10;
        }

    }

    void RysujSztachety()
    {
        RysujLinie(0, 39, 190, 39);
        RysujLinie(0, 139, 190, 139);
    }
    private void btnRysuj_Click(object sender, RoutedEventArgs e)
    {
    
        RysujPrzesla();
        RysujSztachety();

    }
}