using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using DataLayer;

namespace BusinessLayer
{
    /*
     * 
     *   function that creates a ChannelFactory<IDataAccessInterface>  /  ChannelFactory<IAccountAccessInterface>  /
     *   ChannelFactory<ITransactionAccessInterface>
     *   and calls the required functions on the DataLayer
     *  
     *  
     *  */


    // //implementation specific behaviour  [
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, UseSynchronizationContext = false)]
   public class IDataAccessImplementation : IDataAccessInterface,IAccountAccessInterface,ITransactionAccessInterface 
    {
        //Making object of Datalayer IUserAccessInterface
        private IUserAccessInterface  user;    
        private IAccountInterface account;
        private ITransactionInterface trans;

        //Construncter - implimentation for the client service data sharing
        public IDataAccessImplementation()
         {

             //Client only knows about the interface
            
            ChannelFactory< DataLayer.IUserAccessInterface > userFactory;
            ChannelFactory<DataLayer.IAccountInterface> accFactory;
            ChannelFactory<DataLayer.ITransactionInterface> transFactory;

            //Set the URL and create the connection!

            NetTcpBinding tcpBinding = new NetTcpBinding();
            string sURL = "net.tcp://localhost:8005/DataService";
            string aURL = "net.tcp://localhost:8005/DataService";
            string tURL = "net.tcp://localhost:8005/DataService";

            userFactory = new ChannelFactory<IUserAccessInterface>(tcpBinding, sURL);
            accFactory = new ChannelFactory<IAccountInterface>(tcpBinding, aURL);
            transFactory = new ChannelFactory<ITransactionInterface>(tcpBinding, tURL);

            //request the object (object exists on the server) 

            user = userFactory.CreateChannel();  
            account = accFactory.CreateChannel();
            trans = transFactory.CreateChannel();
            user = new IDataImplimantaion();
            account = new IDataImplimantaion();
            trans = new IDataImplimantaion();



        }



        /* // Run RPC function.     
         * Actual Implimentation of interfaces 
         * 
       -------------------------------User Management function Implimataion--------------------------------------------------
         *  
         *    
         */

        public uint CreateUser()
        {
            try
            { 
                uint i = user.CreateUser();  
                return i;
            }
            catch {

                return 0; 
            }
        }

        public void SelectUser(uint userID)
        {
                user.SelectUser(userID);
            
        }

        public void SetUserName(string fname, string lname)
        {
            user.SetUserName(fname,lname);
            System.Console.WriteLine(fname, lname);
        }

        public void GetUserName(out string fname, out string lname)
        {
            user.GetUserName(out fname,out lname);
        }

        public List<uint> GetUsers()
        {
            List<uint> users = user.GetUsers();
            return users;
        }



        /*
         * 
         * 
          ----------------------------  Transaction Management function Implimantation-----------------------------------------------------
         */

        public uint CreateTransaction()
        {
            uint trrId = trans.CreateTransaction();
            return trrId;
        }


       public uint GetAmount()
       {
            uint ammount = trans.GetAmount();
            return ammount;
       }

       public uint GetRecvrAcct()
       {
            uint rsID = trans.GetRecvrAcct();
            return rsID;
       }

       public uint GetSendrAcct()
       {
            uint RsID = trans.GetSendrAcct();
            return RsID;
       }

       public List<uint> GetTransactions()
       {
            List<uint> allTrans = trans.GetTransactions();
            return allTrans;
        }

        public void SelectTransaction(uint TransactionID)
        {
            trans.SelectTransaction(TransactionID);
        }

        public void SetAmount(uint amount)
        {
            trans.SetAmount(amount);
        }

        public void SetRecvr(uint acctID)
        {
            trans.SetRecvr(acctID);
        }

        public void SetSendr(uint acctID)
        {
            trans.SetSendr(acctID);
        }

        public void ExitFunction() {

            trans.ExitFunction();
        }
        /*
         * 
         * 
         * 
         ------------------------------- Account Managment function Implimataion--------------------------------------   
         */


        public List<uint> GetAccountIDsByUser(uint userID)
        {
            List<uint> allaccount = account.GetAccountIDsByUser(userID);
            return allaccount;
        }
        public uint GetBalance()
        {
            uint owner = account.GetOwner();
            return owner;
        }

        public void SelectAccount(uint accountID)
        {
            account.SelectAccount(accountID);
        }

       
        public void Withdraw(uint amount)
        {
            account.Withdraw(amount);
        }

        public void Deposit(uint amount)
        {
            account.Deposit(amount);
        }
        public uint CreateAccount(uint userID)
        { 
             uint i = account.CreateAccount(userID);
             return i;
        }

        public uint GetOwner()
        {
            uint ownerID = account.GetOwner();
            return ownerID;
        }
    }
}
