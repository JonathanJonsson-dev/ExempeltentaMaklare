using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Uppgift1
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

        public int PrisPerKvadrat(int slutpris)
        {
            int area = 57;
            return slutpris / area; 
        }

        public double CheckLength(string slutpris)
        {
            
            if (slutpris.Length == 7)
            {
                int area = 57;
                return int.Parse(slutpris) / area;
            }
            else if (slutpris.Length == 6)
            {
                double area = 5.7;
                return Math.Round(int.Parse(slutpris) / area, 0);
            }
            else if (slutpris.Length == 5)
            {
                double area = 0.57;
                return Math.Round(int.Parse(slutpris) / area, 0);
            }
            else if (slutpris.Length == 4)
            {
                double area = 0.057;
                return Math.Round(int.Parse(slutpris) / area, 0);
            }
            return 0;
        }

        public double AddZeros(string slutpris)
        {

            if (slutpris.Length == 7)
            {
                return int.Parse(slutpris);
            }
            else if (slutpris.Length == 6)
            {
                return int.Parse(slutpris) * 10;
            }
            else if (slutpris.Length == 5)
            {
                return int.Parse(slutpris) * 100;
            }
            else if (slutpris.Length == 4)
            {
                return int.Parse(slutpris) * 1000; 
            }
            return 0;
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            //int slutpris = int.Parse(txtBox.Text);
            //lbl.Content = $"{PrisPerKvadrat(slutpris)} kr/kvm";
            // Uppgift 2
            string slutpris = txtBox.Text;
            txtBox.Text = $"{AddZeros(slutpris):C0}";
            lbl.Content = $"{CheckLength(slutpris):C0} kr/kvm";
        }
    }
}
