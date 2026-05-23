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

namespace Day1_Activity4_WPF_
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

        private void SUBTRACT_Click(object sender, RoutedEventArgs e)
        {
            int num1 = int.Parse(NUM1.Text);
            int num2 = int.Parse(NUM2.Text);
            int total = num1 - num2;
            result.Text = total.ToString(); 
            
            
        }

        private void ADD_Click(object sender, RoutedEventArgs e)
        {
            int num1 = int.Parse(NUM1.Text);
            int num2 = int.Parse(NUM2.Text);
            int total = num1 +num2;
            result.Text = total.ToString();
        }

        private void DIVISION_Click(object sender, RoutedEventArgs e)
        {
            int num1 = int.Parse(NUM1.Text);
            int num2 = int.Parse(NUM2.Text);
            int total = num1 /num2;
            result.Text = total.ToString();
        }

        private void MULTIPLY_Click(object sender, RoutedEventArgs e)
        {
            int num1 = int.Parse(NUM1.Text);
            int num2 = int.Parse(NUM2.Text);
            int total = num1 *num2;
            result.Text = total.ToString();
        }
    }
}