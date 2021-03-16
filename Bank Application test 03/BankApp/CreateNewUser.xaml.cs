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
using BusinessLayer;


namespace BankApp
{
    /// <summary>
    /// Interaction logic for CreateNewUser.xaml
    /// </summary>
    public partial class CreateNewUser : Page
    {
        //Creating BuissnessLayer object to get and set data 
        BusinessLayer.IDataAccessImplementation koko = new BusinessLayer.IDataAccessImplementation();


        public CreateNewUser()
        {
            InitializeComponent();          //Load XML page

            
        }

        //Create new UserID 
        //Send requst to the BankDB class thought the BussinessLayet and the DataLayer 
       
        private void CreateNewUser_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                uint id = koko.CreateUser();
                userID.Text = id.ToString();
            }
            catch
            {

                MessageBox.Show("Try again");
            }
        }
    }
}
