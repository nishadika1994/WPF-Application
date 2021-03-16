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
    /// Interaction logic for AccountSelectUserPage.xaml
    /// </summary>
    public partial class AccountSelectUserPage : Page
    {
        //Creting a object IDataAccessImplementation class , BusinessLayer project
        BusinessLayer.IDataAccessImplementation koko = new BusinessLayer.IDataAccessImplementation();

        public AccountSelectUserPage()
        {
            InitializeComponent();
        }

       

        private void GetAccountsByID(object sender, RoutedEventArgs e)
        {
            try
            {
                uint id = Convert.ToUInt32(userID.Text);
                List<uint> accounts = koko.GetAccountIDsByUser(id);
                foreach (uint i in accounts)
                {

                    String account = i.ToString();
                    ListView1.Items.Add(account);
                }
            }
            catch
            {
                MessageBox.Show("Try again");
            }

        }
    }
}
