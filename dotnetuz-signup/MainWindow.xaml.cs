using dotnetuz_signup.ServiceLayer.User;
using dotnetuz_signup.ServiceLayer.User.Concrete;
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

namespace dotnetuz_signup
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
        IUserService userService =new UserService();
        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }
        private async void Window_Loaded(object sender, RoutedEventArgs e) 
        {
            var users = await userService.GetAll();
            MessageBox.Show(users.Count().ToString());
        }
    }
}