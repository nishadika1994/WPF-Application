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
    /// Interaction logic for SelectUser.xaml
    /// </summary>
    public partial class SelectUser : Page
    {

        //Creting a object IDataAccessImplementation class , BusinessLayer project
        BusinessLayer.IDataAccessImplementation koko = new BusinessLayer.IDataAccessImplementation();


        public SelectUser()
        {
            InitializeComponent();    //xml page loding


        }
        /*
         *  Requesting functions to get and set data from business layer.
         *   
         * */

        //Button Click function to direct user name  to  BusinessLayer to proccess data
        private void SaveUser(object sender, RoutedEventArgs e)
        {
            try
            {
                uint id = Convert.ToUInt32(userID.Text);
                koko.SelectUser(id);                              //Calling businessLayer functions
                koko.SetUserName(name1.Text, name2.Text);        //send data and get from the BusinessLayer
                MessageBox.Show("Data inserted successfully");

            }
            catch
            {
                MessageBox.Show("Try again");
            }
        }

        //Selected user name get function
        private void Get_Name__Click(object sender, RoutedEventArgs e)
        {
            try
            {
                uint id = Convert.ToUInt32(userID2.Text);
                koko.SelectUser(id);                                     //Calling businessLayer functions
                koko.GetUserName(out string fname, out string lname);  //send data and get from the BusinessLayer
                getname1.Text = fname.ToString();
                getname2.Text = lname.ToString();
            }
            catch
            {

                MessageBox.Show("Error Please Enter Valid ID!!!");
            }

        }
        }

       
      
}
