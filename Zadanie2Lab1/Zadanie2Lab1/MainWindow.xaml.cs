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

namespace Zadanie2Lab1
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

        void RysujLinie(int x1, int y1, int x2, int y2, int grubosc,Brush pedzel = null)
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

        void CzyscPlotno()
        {
            //cvRysunek.ClearValue();
        }

        void RysujKrzyz(int x, int y, int dlugosc, int grubosc)
        {
            Brush pedzel = Brushes.Red;
            
            RysujLinie(x - dlugosc, y, x + dlugosc, y, 2, pedzel);
            RysujLinie(x, y - dlugosc, x, y + dlugosc, 2, pedzel);
        }

        void RysujWypelnionaElipse(int x, int y, int wysokosc, int szerokosc, Brush pedzel)
        {

            Ellipse elips = new Ellipse();
            elips.Stroke = pedzel;
            elips.Width = szerokosc;
            elips.Height = wysokosc;
            cvRysunek.Children.Add(elips);
            Canvas.SetLeft(elips, 149);
            Canvas.SetTop(elips, 149);

            //for (int i = 0; i < 72; i++)
            //{
            //    Line line = new Line();
            //    line.Stroke = pedzel;
            //    line.X1 = x;
            //    line.Y1 = y;
            //    line.X2 = wysokosc;
            //    line.Y2 = szerokosc;

            //    line.RenderTransform = new RotateTransform(5 * i, 150, 150);
            //    cvRysunek.Children.Add(line);
            //}
        }
        private void btnRysuj_Click(object sender, RoutedEventArgs e)
        {
       
           RysujLinie(0, 149, 299, 149, 5,System.Windows.Media.Brushes.Red);
           RysujLinie(149, 149, 149, 299, 8,System.Windows.Media.Brushes.DarkGreen);
        }

        private void btnRysuj2_Click(object sender, RoutedEventArgs e)
        {
            RysujKrzyz(149, 149, 50, 2);
        }

        private void btnRysuj3_Click(object sender, RoutedEventArgs e)
        {
            RysujWypelnionaElipse(200, 100, 70,20,System.Windows.Media.Brushes.Green);
        }
     }
}