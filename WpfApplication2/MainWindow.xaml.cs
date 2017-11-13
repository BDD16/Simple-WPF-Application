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

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {   //establish global variables to handle microcontroller programs
        System.Diagnostics.Process Keil = null;
        System.Diagnostics.Process Eclipse = null;
        System.Diagnostics.Process NewUI = null;
        System.Diagnostics.Process Fuji = null;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You just clicked a button, well done!");

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (CheckPassword(sender, e))
            {
                //  Fuji = System.Diagnostics.Process.Start("C:/Users/Blake/Documents/Fiji.app"); //here insert application to run and change button names appropriately
                //  Fuji.WaitForInputIdle();
                MessageBox.Show("Currently Fuji isn't installed or used on your computer");
            }
            else
            {
                MessageBox.Show("Password is incorrect");
            }
        }

        private void Button1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

            // before opening a program, validate tha correct password has been entered in the password box
            if (CheckPassword(sender, e))
            {
                MessageBox.Show("Currently Keil isn't installed or used on your computer");
                // System.Diagnostics.Process.Start("notepad.exe");
                // Keil = System.Diagnostics.Process.Start("C:/Keil/UV4/UV4.exe"); //here insert application to run and change button names appropriately


                // Keil.WaitForInputIdle();
            }
            else
            {
                MessageBox.Show("password is incorrect, please type Hello");

            }


        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            if (CheckPassword(sender, e))
            {
                MessageBox.Show("Currently Keil isn't installed or used on your computer");
                // System.Diagnostics.Process.Start("notepad.exe");
                // Keil = System.Diagnostics.Process.Start("C:/Keil/UV4/UV4.exe"); //here insert application to run and change button names appropriately


                // Keil.WaitForInputIdle();
            }
            else
            {
                MessageBox.Show("password is incorrect, please type Hello");

            }
        }

        private bool CheckPassword(object sender, RoutedEventArgs e)
        {
            if (this.passwordBox.Password == "Hello")
            {//check password in a not so secure fashion
                return true;

            }

            return false;//password doesn't match "Hello" so return false
        }
    }
}
