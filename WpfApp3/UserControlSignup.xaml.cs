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
    /// Interaction logic for UserControlSignup.xaml
    /// </summary>
    public partial class UserControlSignup : UserControl
    {
        MainWindow main;
        UserControlLogin loginwnd;
        public UserControlSignup()
        {
            InitializeComponent();
        }

        public void setMainParent(MainWindow mainwin, UserControlLogin login)
        {
            main = mainwin;
            loginwnd = login;
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            //
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Grid res = main.center as Grid;
            res.Children.Clear();
            res.Children.Add(loginwnd);
        }
    }
}
