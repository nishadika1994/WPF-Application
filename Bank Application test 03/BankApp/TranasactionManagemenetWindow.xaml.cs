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
    /// Interaction logic for TranasactionManagemenetWindow.xaml
    /// </summary>
    public partial class TranasactionManagemenetWindow : Window
    {
        public TranasactionManagemenetWindow()
        {
            InitializeComponent();
        }
        /*
         * Windows Open functions
         * 
         * */
        private void ButtonClickHome(object sender, RoutedEventArgs e)
        {
            MainWindow man = new MainWindow();
            man.Show();
        }
        /*
         * Page open functions
         * 
         * */
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

        private void CreateTransaction_buttonClick(object sender, RoutedEventArgs e)
        {
            TransactionFrame.Content = new TransactionCreation();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TransactionFrame.Content = new GetTransactionByID(); 
        }

        private void ListOFTransaction_Click(object sender, RoutedEventArgs e)
        {
            TransactionFrame.Content = new ListOfTransaction();
        }
    }
}
