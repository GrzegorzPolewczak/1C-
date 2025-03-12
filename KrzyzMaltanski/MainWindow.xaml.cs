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

namespace KrzyzMaltanski;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    void CzyscPlotno()
    {
        cvRysunek.Children.Clear();
    }
    void RysujLinie(double x1, double y1, double x2, double y2, double grubosc = 1, Brush pedzel = null)
    {
        if (pedzel == null) { pedzel = Brushes.Black; }
        var myLine = new Line();
        myLine.Stroke = pedzel;
        myLine.X1 = x1;
        myLine.X2 = x2;
        myLine.Y1 = y1;
        myLine.Y2 = y2;
        myLine.HorizontalAlignment = HorizontalAlignment.Left;
        myLine.VerticalAlignment = VerticalAlignment.Center;
        myLine.StrokeThickness = grubosc;
        cvRysunek.Children.Add(myLine);
    }

    void RysujKrzyz(double x, double y, double dlugosc, double grubosc)
    {
        Brush pedzel = Brushes.Red;

        RysujLinie(x - dlugosc, y, x + dlugosc, y, grubosc, pedzel);
        RysujLinie(x, y - dlugosc , x,y + dlugosc, grubosc, pedzel);
    }
    private void btnRysuj1_Click(object sender, RoutedEventArgs e)
    {
        CzyscPlotno();
        RysujLinie(0, 149, 299, 149, 5, System.Windows.Media.Brushes.Red);
        RysujLinie(149, 149, 149, 299, 8, System.Windows.Media.Brushes.DarkGreen);
    }

   
    private void btnRysuj2_Click(object sender, RoutedEventArgs e)
    {
        CzyscPlotno();

        double srodekX = cvRysunek.Width / 2;
        double srodekY = cvRysunek.Height / 2;
        double dlugosc = 40;
        double grubosc = 5;
        RysujKrzyz(srodekX, srodekY, dlugosc, grubosc);

        RysujLinie(srodekX + 40, srodekY + 10, srodekX + 40, srodekY - 10, grubosc, Brushes.Red);
        RysujLinie(srodekX - 40, srodekY + 10, srodekX - 40, srodekY - 10, grubosc, Brushes.Red);
        RysujLinie(srodekX + 10, srodekY + 40, srodekX - 10, srodekY + 40, grubosc, Brushes.Red);
        RysujLinie(srodekX - 10, srodekY - 40, srodekX + 10, srodekY - 40, grubosc, Brushes.Red);

        double polowadlugosci = dlugosc / 2;
        //RysujKrzyz(srodekX + polowadlugosci, srodekY + polowadlugosci, polowadlugosci / 2, grubosc);
        //RysujKrzyz(srodekX - polowadlugosci, srodekY + polowadlugosci, polowadlugosci / 2, grubosc);
        //RysujKrzyz(srodekX + polowadlugosci, srodekY - polowadlugosci, polowadlugosci / 2, grubosc);
        //RysujKrzyz(srodekX - polowadlugosci, srodekY - polowadlugosci, polowadlugosci / 2, grubosc);
        
        //wersja 2
        for (int dx = -1; dx <= 1; dx += 2)  // -1 i 1 (po lewej i po prawej)
        {
            for (int dy = -1; dy <= 1; dy += 2)  // -1 i 1 (na górze i na dole)
            {
                double x = srodekX + dx * polowadlugosci;
                double y = srodekY + dy * polowadlugosci;
                RysujKrzyz(x, y, polowadlugosci /2, grubosc);
            }
        }
    }


    void RysujWypelnionaElipse(int x, int y, int wysokosc, int szerokosc, Brush pedzel)
    {
        Ellipse elips = new Ellipse();
        elips.Stroke = pedzel;
        elips.Width = szerokosc;
        elips.Height = wysokosc;
        elips.Fill = pedzel;
        cvRysunek.Children.Add(elips);
        Canvas.SetRight(elips, x);
        Canvas.SetTop(elips, y);
    }

    void RysujWypelnioneKolo(int x, int y, int promien, Brush kolor)
    {
        //RysujWypelnionaElipse(x - (promien /2), y - (promien /2), promien, promien, kolor);
        RysujWypelnionaElipse(x, y, promien, promien, kolor);
    }
    private void btnRysuj3_Click(object sender, RoutedEventArgs e)
    {
        CzyscPlotno();
        //RysujWypelnionaElipse(50,50,100,50,Brushes.Green);

        //RysujWypelnioneKolo(150, 150, 30, Brushes.Black);
        RysujDrzewo(100,250,75,40);
        //RysujSzpalerDrzew(40, 250, 50, 4);
    }

    void RysujDrzewo(int x, int y, int dlugoscpnia, int promienkorony)
    {
        RysujLinie(x, y, x, y - dlugoscpnia, 8, Brushes.Brown);
        RysujWypelnioneKolo(x - (promienkorony /2), y - dlugoscpnia, promienkorony, Brushes.Green);
    }

    void RysujSzpalerDrzew(int x, int y, int odleglosc, int ilosc)
    {
        for(int i = 0; i < ilosc; i++)
        {
            RysujDrzewo(x, y, 30, 25);
            x += odleglosc;
        }
    }
}