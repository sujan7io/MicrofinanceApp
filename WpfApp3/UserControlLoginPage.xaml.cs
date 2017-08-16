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
    /// Interaction logic for UserControlLoginPage.xaml
    /// </summary>
    public partial class UserControlLoginPage : UserControl
    {
        MainWindow main;
        UserControlLogin login1, login2, login3, login4;
        public UserControlLoginPage()
        {
            InitializeComponent();
        }

        public void setMainWindow(MainWindow mainwin)
        {
            main = mainwin;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            login1 = new UserControlLogin();
            login1.setMainWindow(main, this);
            Grid res = main.center as Grid;
            res.Children.Clear();
            res.Children.Add(login1);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            login2 = new UserControlLogin();
            login2.setMainWindow(main, this);
            Grid res = main.center as Grid;
            res.Children.Clear();
            res.Children.Add(login2);

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            login3 = new UserControlLogin();
            login3.setMainWindow(main, this);
            Grid res = main.center as Grid;
            res.Children.Clear();
            res.Children.Add(login3);

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            login4 = new UserControlLogin();
            login4.setMainWindow(main, this);
            Grid res = main.center as Grid;
            res.Children.Clear();
            res.Children.Add(login4);

        }
    }
}
