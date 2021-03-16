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
    /// Interaction logic for GetTransactionByID.xaml
    /// </summary>
    public partial class GetTransactionByID : Page
    {
        //Creting a object IDataAccessImplementation class , BusinessLayer project
        BusinessLayer.IDataAccessImplementation koko = new BusinessLayer.IDataAccessImplementation();
        public GetTransactionByID()
        {
            InitializeComponent();
        }
        
        //Search transaction using transaction ID
        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                uint transID = Convert.ToUInt32(transactionID.Text);

                koko.SelectTransaction(transID);
                uint amountTrans = koko.GetAmount();
                uint sendID = koko.GetSendrAcct();
                uint resiveID = koko.GetRecvrAcct();

                senderID.Text = sendID.ToString();
                amount.Text = amountTrans.ToString();
                resiverID.Text = resiveID.ToString();
            }
            catch {

                MessageBox.Show("Error !!!! ");

            }

        }
    }
}
