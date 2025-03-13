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

namespace ZadanieD
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

        void RysujLinie(int x1, int y1, int x2, int y2, object pedzel = null)
        {
            if (pedzel == null) { pedzel = Brushes.Black; }
            var myLine = new Line();
            myLine.Stroke = (Brush)pedzel;
            myLine.X1 = x1;
            myLine.X2 = x2;
            myLine.Y1 = y1;
            myLine.Y2 = y2;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 5;
            cvRysunek.Children.Add(myLine);
        }
        private void btnTest4_Click(object sender, RoutedEventArgs e)
        {
            int[,] tab = new int[4, 4] { { 20, 20, 280, 20 }, { 20, 100, 280, 100 }, { 20, 20, 20, 200 }, { 280, 20, 280, 200 } };

            object[] kolory = new object[3] { Brushes.Black, Brushes.Red, Brushes.Green };

            int x1 = 0, y1 = 0, x2 = 0, y2 = 0;
            for(int i = 0; i < 4; i ++)
            {
                RysujLinie(tab[x1, y1], tab[x2, y2], tab[0, 2], tab[0, 3], kolory[0]);
            }

        }
    }
}