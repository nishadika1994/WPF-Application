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
    /// Interaction logic for TransactionCreation.xaml
    /// </summary>
    public partial class TransactionCreation : Page
    {
        //Creting a object IDataAccessImplementation class , BusinessLayer project
        BusinessLayer.IDataAccessImplementation koko = new BusinessLayer.IDataAccessImplementation();

        public TransactionCreation()
        {
            InitializeComponent();
        }

        //Create Transaction ID
        private void ProceedTransaction_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
               

                uint id = koko.CreateTransaction();
                transactionID.Text = id.ToString();
           
               
            }
            catch {

              MessageBox.Show("Error !!! ");
            }
        }
        //Create Transaction
        private void CreateTransactionButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                uint transAmount = Convert.ToUInt32(amount.Text);
                uint send = Convert.ToUInt32(accountIDsender.Text);
                uint resiv = Convert.ToUInt32(accountIDreciver.Text);

                uint transID = Convert.ToUInt32(transactionID.Text);

                koko.SelectTransaction(transID);
                koko.SetAmount(transAmount);
                koko.SetSendr(send);
                koko.SetRecvr(resiv);
            }
            catch {

                MessageBox.Show("Transaction Not Succesfull !!! ");

            }
        }

       
    }
}
