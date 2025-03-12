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

namespace KolosCzlowiek;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    void RysujLinie(double x1, double y1, double x2, double y2)
    {
        var myLine = new Line();
        myLine.Stroke = Brushes.Black;
        myLine.X1 = x1;
        myLine.X2 = x2;
        myLine.Y1 = y1;
        myLine.Y2 = y2;

        cvRysunek.Children.Add(myLine);
    }
    void RysujElipse(int wysokosc, int szerokosc, int y)
    {
        Ellipse elips = new Ellipse();
        elips.Stroke = Brushes.Black;
        elips.Width = szerokosc;
        elips.Height = wysokosc;
     
        elips.Fill = Brushes.White;
        cvRysunek.Children.Add(elips);
        Canvas.SetLeft(elips, 175);
        Canvas.SetTop(elips, y);
    }
    void RysujTulow()
    {
        RysujElipse(120, 50, 100);
    }
    void RysujGlowe()
    {
         RysujElipse(50, 50, 50);
    }

    void RysujRece()
    {
        RysujLinie(175, 150, 100, 120);
        RysujLinie(225, 150, 300, 120);
    }

    void RysujNogi()
    {
        RysujLinie(190, 215, 165, 235);
        RysujLinie(210, 215, 235, 235);
    }
    void Czysc()
    {
        cvRysunek.Children.Clear();
    }
    private void Checked(object sender, RoutedEventArgs e)
    {
        Czysc();
        if(ckbGlowa.IsChecked == true)
        {
            RysujGlowe();
        }
        if(ckbTulow.IsChecked == true)
        {
            RysujTulow();
        }
        if(ckbNogi.IsChecked == true)
        {
            RysujNogi();
        }
        if(ckbRece.IsChecked == true)
        {
            RysujRece();
        }
    }
}



