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
    /// Interaction logic for ListOfTransaction.xaml
    /// </summary>
    public partial class ListOfTransaction : Page
    {
        //Creating BuissnessLayer object to get and set data 
        BusinessLayer.IDataAccessImplementation koko = new BusinessLayer.IDataAccessImplementation();
        public ListOfTransaction()
        {
            InitializeComponent();
        }
        //Get the list of transactions send the request to bussiness layer
        private void GetAll_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                uint accID = Convert.ToUInt32(accountIDTrans.Text);
               
                List<uint> acc = koko.GetTransactions();
                foreach (uint i in acc)
                {
                   
                    String id = i.ToString();
                    ListView1.Items.Add(id);
                }
            }
            catch
            {
                MessageBox.Show("Try again");     //Error msg
            }
        }
    }
}
