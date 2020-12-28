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

namespace Uppgift9
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

        public bool CheckPassword(string password)
        {
            if (CheckUpper(password) == true & CheckLower(password) == true & CheckSpecial(password) == true)
            {
                return true;
            }
            return false;
        }

        public bool CheckUpper(string password)
        {
            int numberOfUpperLetters = 0; 

            foreach (char letterPassword in password)
            {
                if (char.IsUpper(letterPassword) == true)
                {
                    numberOfUpperLetters++;
                }
            }

            if (numberOfUpperLetters >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckLower(string password)
        {
            int numberOfLowerLetters = 0;

            foreach (char letterPassword in password)
            {
                if (char.IsLower(letterPassword) == true)
                {
                    numberOfLowerLetters++;
                }
            }

            if (numberOfLowerLetters >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckSpecial(string password)
        {
            int numberOfSpecialLetters = 0;

            foreach (char letterPassword in password)
            {
                if (letterPassword == '!' | letterPassword == '&' | letterPassword == '%')
                {
                    numberOfSpecialLetters++;
                }
            }

            if (numberOfSpecialLetters >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            string password = "TestPassword%";
            bool result = CheckPassword(password);

        }
    }
}
