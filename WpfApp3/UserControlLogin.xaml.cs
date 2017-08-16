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

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for UserControlLogin.xaml
    /// </summary>
    public partial class UserControlLogin : UserControl
    {
        UserControlLoginPage frontpage;
        MainWindow main;
        UserControlSignup signup;
        public UserControlLogin()
        {
            InitializeComponent();
        }

        public void setMainWindow(MainWindow mainwin, UserControlLoginPage front)
        {
            main = mainwin;
            frontpage = front;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Grid res = main.center as Grid;
            res.Children.Clear();
            res.Children.Add(frontpage);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //wirte resetting forgot password
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //sign up for a new user
            signup = new UserControlSignup();
            signup.setMainParent(main, this);
            Grid res = main.center as Grid;
            res.Children.Clear();
            res.Children.Add(signup);
        }
    }
}
