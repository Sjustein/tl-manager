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

namespace tl_manager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Set up the event listeners
            IpTextBox.TextInput += IpTextBox_TextInput;
            IpTextBox.GotFocus += IpTextBox_GotFocus;
            IpTextBox.LostFocus += IpTextBox_LostFocus;
        }

        private void IpTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            // Check if the text should be "placeholderised"
            if (IpTextBox.Text == "")
                IpTextBox.Text = "Ip address of the server";
        }

        private void IpTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            // Check if the text should be "placeholderised"
            if (IpTextBox.Text == "Ip address of the server")
                IpTextBox.Text = "";
        }

        private void IpTextBox_TextInput(object sender, TextCompositionEventArgs e)
        {
            //if ()
        }
    }
}
