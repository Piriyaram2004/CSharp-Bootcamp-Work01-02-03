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

namespace Day1_Activity2_WPF
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string Firstname = firstname.Text;
            string Lastname = lastname.Text;
            string Favcolor = favcolor.Text;
            display.Text = $"FIRST NAME - { Firstname}" +
                $" LAST NAME - {Lastname}" +
                $" FAVCOLOR - {Favcolor}";

        }
    }
}