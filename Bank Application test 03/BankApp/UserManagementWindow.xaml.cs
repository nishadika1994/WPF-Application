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
using System.Windows.Shapes;

namespace BankApp
{
    /// <summary>
    /// Interaction logic for UserManagementWindow.xaml
    /// </summary>
    public partial class UserManagementWindow : Window
    {
        public UserManagementWindow()
        {
            InitializeComponent();    //Load XMl page
        }
        /**
         * 
         * Windows open Functions
         * */
        private void ButtonClickHome(object sender, RoutedEventArgs e)
        {
            MainWindow man = new MainWindow();
            man.Show();
        }

        private void ButtonClickUserMange(object sender, RoutedEventArgs e)
        {
            UserManagementWindow user = new UserManagementWindow();
            user.Show();
        }

        private void ButtonClickAccount(object sender, RoutedEventArgs e)
        {
            AccountManagementWindow acc = new AccountManagementWindow();
            acc.Show();
        }

        private void ButtonClickTransaction(object sender, RoutedEventArgs e)
        {
            TranasactionManagemenetWindow trr = new TranasactionManagemenetWindow();
            trr.Show();
        }

        /*
         * Page open functions
         * 
         * */
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UserFrame.Content = new CreateNewUser();
        }

        private void SelectUser(object sender, RoutedEventArgs e)
        {
            UserFrame.Content = new SelectUser();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            UserFrame.Content = new AllUsers();
        }

        private void SelectUserName(object sender, RoutedEventArgs e)
        {
            UserFrame.Content = new SelectUser();
        }

        private void GetUserName(object sender, RoutedEventArgs e)
        {
            UserFrame.Content = new SelectUser();
        }
    }
}
