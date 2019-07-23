using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
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
            // the sender object only shows the members of the object class

            //var button = (Button)sender;
            //button.Width = 200;
            //var x = 112;
            //button.Margin = new Thickness(x);

            string msg;

            // we can use downcasting to get all members of the button object
            var button = sender as Button;

            if (button != null)
                msg = "the sender is a button object";
            else
                msg = "the sender is not a button object";

            MessageBox.Show("Hello World\n" + msg);
        }
    }
}
