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
    /// Interaction logic for AccountGetAccountByUserPage.xaml
    /// </summary>
    public partial class AccountProfilePage : Page
    {
        //Creting a object IDataAccessImplementation class , BusinessLayer project
        BusinessLayer.IDataAccessImplementation koko = new BusinessLayer.IDataAccessImplementation();

        public AccountProfilePage()
        {
            InitializeComponent();
        }

        private void SelectAccount_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                uint accId = Convert.ToUInt32(accountID.Text);

                koko.SelectAccount(accId);
                uint id = koko.GetOwner();
                userID.Text = id.ToString();
                uint balan = koko.GetBalance();
                balance.Text = balan.ToString();
            }
            catch {

                MessageBox.Show("Try again !!! Check the ID.");
            }

        }
        //Select account Id And Amount to deposit Money. Used to methods at the same time
        private void Deposite_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                uint accId2 = Convert.ToUInt32(accountID2.Text);
                uint depo = Convert.ToUInt32(deposit.Text);
                koko.SelectAccount(accId2);
                koko.Deposit(depo);
            }
            catch
            {
                MessageBox.Show("Not Succesfull !!!, Try again and Check the ID.");
            }

        }
        //Select account Id And Amount to withdraw Money.  Used to methods at the same time
        private void Withdraw_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                uint accId2 = Convert.ToUInt32(accountID2.Text);
                uint withd = Convert.ToUInt32(withdraw.Text);
                koko.SelectAccount(accId2);
                koko.Deposit(withd);
            }
            catch
            {
                MessageBox.Show("Not Succesfull !!!, Try again and Check the ID.");
            }

        }
    }
}
