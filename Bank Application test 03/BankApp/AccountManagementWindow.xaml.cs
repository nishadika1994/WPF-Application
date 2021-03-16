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
    /// Interaction logic for AccountManagementWindow.xaml
    /// </summary>
    public partial class AccountManagementWindow : Window
    {
        public AccountManagementWindow()
        {
            InitializeComponent();
        }
        /*
         * 
         *  **** Open Windows and pages
         * 
         * 
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

        private void CreateNewAccount(object sender, RoutedEventArgs e)
        {
            AccountFrame.Content = new CreateAccountPage();
        }

        private void AccountProfileButtonClick(object sender, RoutedEventArgs e)
        {
            AccountFrame.Content = new AccountProfilePage();
        }

        private void Deposit_Button_Click_4(object sender, RoutedEventArgs e)
        {
            AccountFrame.Content = new AccountProfilePage();
        }

        private void Withdraw_Button_Click_3(object sender, RoutedEventArgs e)
        {
            AccountFrame.Content = new AccountProfilePage();
        }

        private void BalanceCheck_Button_Click_5(object sender, RoutedEventArgs e)
        {
            AccountFrame.Content = new AccountProfilePage();
        }

        private void AllUserAccount_Button_Click_6(object sender, RoutedEventArgs e)
        {
            AccountFrame.Content = new AccountSelectUserPage();
        }
    }
}
