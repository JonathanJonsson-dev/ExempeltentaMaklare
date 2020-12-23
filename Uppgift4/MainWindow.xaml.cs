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

namespace Uppgift4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Broker broker = new Broker();
        public MainWindow()
        {
            InitializeComponent();
        }

        public void UpdateListBox()
        {
            lstBox.ItemsSource = null;
            lstBox.ItemsSource = broker.RealEstates;
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            
            lstBox.ItemsSource = broker.SortBy(int.Parse(txtBoxMin.Text), int.Parse(txtBoxMax.Text));
            UpdateListBox();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            RealEstate realEstate = new RealEstate();
            realEstate.Address = txtboxAddress.Text;
            realEstate.Area = int.Parse(txtboxArea.Text);
            realEstate.Rooms = int.Parse(txtboxNumbersOfRooms.Text);
            broker.AddRealEstate(realEstate);


            UpdateListBox();
        }
    }
}
