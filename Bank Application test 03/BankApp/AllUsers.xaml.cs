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
    /// Interaction logic for AllUsers.xaml
    /// </summary>
    public partial class AllUsers : Page
    {

        //Creting a object IDataAccessImplementation class , BusinessLayer project
        BusinessLayer.IDataAccessImplementation koko = new BusinessLayer.IDataAccessImplementation();

        public AllUsers()
        {
            InitializeComponent(); //Loading xml page
        }

        private void getAllusers(object sender, RoutedEventArgs e)
        {
            try
            {
                List<uint> users = koko.GetUsers();
                foreach (uint i in users)
                {

                    String id = i.ToString();
                    ListView1.Items.Add(id);
                }
            }
            catch
            {
                MessageBox.Show("Try again");
            }
        }
    }
}
