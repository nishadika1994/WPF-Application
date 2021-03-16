using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using BankDB;

namespace DataLayer
{
    /*
     * Actual Implimentation of IUserAccessInterface, IAccountInterface, ITransactionInterface classes.
     * */

    //implementation specific behaviour 
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, UseSynchronizationContext = false)]
  public  class IDataImplimantaion : IUserAccessInterface, IAccountInterface, ITransactionInterface
    {
        /*
         * creating a single, static BankDB.BankDB object.This will let you createUserInterfaces,AccountInterfaces,and 
         * TransactionInterfaces,eachofwhichallowthedatatiertocommunicateviatheBankDB interfacetothebankitself.
         * */
        private static BankDB.BankDB lkj = new BankDB.BankDB();

        /* // Run RPC function.     
          * Actual Implimentation of interfaces 
          * 
        -------------------------------User Management Interface function Implimataion--------------------------------------------------
          *  
          *    
          */
        public uint CreateUser()
        {
            uint userID = lkj.GetUserAccess().CreateUser();
            lkj.SaveToDisk();
            System.Console.WriteLine("User ID" + userID);
            return userID;
        }

        public void SelectUser(uint userID)
        {
            lkj.GetUserAccess().SelectUser(userID);
            lkj.SaveToDisk();
        }

        public void SetUserName(string fname, string lname)
        {
            
            
                lkj.GetUserAccess().SetUserName(fname, lname);
                lkj.SaveToDisk();
            

        }

        public void GetUserName(out string fname, out string lname)
        {
          
                lkj.GetUserAccess().GetUserName(out fname, out lname);
        }


        public List<uint> GetUsers()
        {
            List<uint> users = lkj.GetUserAccess().GetUsers();
            return users;
        }

        /*
         * 
         * 
          ----------------------------  Transaction Management Interface function Implimantation-----------------------------------------------------
         */

        public uint CreateTransaction()
        {
            uint id = lkj.GetTransactionInterface().CreateTransaction();
            lkj.SaveToDisk();
            return id;
        }

        public uint GetAmount()
        {
            uint amount = lkj.GetTransactionInterface().GetAmount();
            return amount;
        }

        public uint GetRecvrAcct()
        {
            uint reAcc = lkj.GetTransactionInterface().GetRecvrAcct();
            return reAcc;
        }

        public uint GetSendrAcct()
        {
            uint sedAcc = lkj.GetTransactionInterface().GetSendrAcct();
            return sedAcc;
        }

        public List<uint> GetTransactions()
        {
            List<uint> tarnsaction = lkj.GetTransactionInterface().GetTransactions();
            return tarnsaction;
        }

        public void SelectTransaction(uint TransactionID)
        {
            lkj.GetTransactionInterface().SelectTransaction(TransactionID);
            lkj.SaveToDisk();
        }


        public void SetAmount(uint amount)
        {
            lkj.GetTransactionInterface().SetAmount(amount);
            lkj.SaveToDisk();
        }


        public void SetRecvr(uint acctID)
        {
            lkj.GetTransactionInterface().SetRecvr(acctID);
            lkj.SaveToDisk();
        }


        public void SetSendr(uint acctID)
        {
            lkj.GetTransactionInterface().SetSendr(acctID);
            lkj.SaveToDisk();
        }


        /*
         * 
         * 
         * 
         ------------------------------- Account Managment Interface function Implimataion--------------------------------------   
         */

        public uint CreateAccount(uint userID)
        {
            uint accountID = lkj.GetAccountInterface().CreateAccount(userID);
            lkj.SaveToDisk();
            System.Console.WriteLine("User ID" + userID);
            return accountID;
        }

        public void Deposit(uint amount)
        {
            lkj.GetAccountInterface().Deposit(amount);
            lkj.SaveToDisk();
        }

        public List<uint> GetAccountIDsByUser(uint userID)
        {
            List<uint> getAll = lkj.GetAccountInterface().GetAccountIDsByUser(userID);
            return getAll;
        }

       

        public uint GetBalance()
        {            
            uint balance = lkj.GetAccountInterface().GetBalance();
            return balance;
        }

        public uint GetOwner()
        {
            uint ownerID = lkj.GetAccountInterface().GetOwner();
            return ownerID;

        }      

        public void SelectAccount(uint accountID)
        {
            lkj.GetAccountInterface().SelectAccount(accountID);
            lkj.SaveToDisk();
        }
     
        public void Withdraw(uint amount)
        {
            lkj.GetAccountInterface().Withdraw(amount);
            lkj.SaveToDisk();
        }


        /*
         *  To Process All transaction sending a request to BankDB
         * 
         * */

        public void ExitFunction() {

            lkj.ProcessAllTransactions();
        }
    }
}
