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
    /// Interaction logic for CreateAccountPage.xaml
    /// </summary>
    public partial class CreateAccountPage : Page
    {
        //Creating BuissnessLayer object to get and set data 
        BusinessLayer.IDataAccessImplementation koko = new BusinessLayer.IDataAccessImplementation();

        public CreateAccountPage()
        {
            InitializeComponent();  //Load xml page
        }

        //Creating New User ID
        private void CreateNewAccount_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                uint id = Convert.ToUInt32(idUser.Text);
                uint acc = koko.CreateAccount(id);
                newAccount.Text = acc.ToString();
            }
            catch {
                MessageBox.Show("Please Enter Valid User ID");
            }
        }

    }
}
