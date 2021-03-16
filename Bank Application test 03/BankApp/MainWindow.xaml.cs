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

namespace BankApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Creating business Layer IDataAccessImplementation object to send and get data.
        BusinessLayer.IDataAccessImplementation koko = new BusinessLayer.IDataAccessImplementation();
        public MainWindow()
        {
            InitializeComponent();
        }
        /*
         * windows open button click functions
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
            TranasactionManagemenetWindow trans = new TranasactionManagemenetWindow();
            trans.Show();
        }

        private void ButtonClickHome(object sender, RoutedEventArgs e)
        {
            MainWindow man = new MainWindow();
            man.Show();
        }
        
        //Exit and Process all transaction function.
        private void exitFunction(object sender, RoutedEventArgs e)
        {
            try
            {
                koko.ExitFunction();
                System.Windows.Application.Current.Shutdown();
            }
            catch { MessageBox.Show("Try again"); }
        }
    }
}
