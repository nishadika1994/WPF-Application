﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace BusinessLayer
{
    /*
     * 
     * IAccountAccessInterface that replicates all the functionality of Account Managemnet in the DataLayer
     * [ServiceContract] - Specifies that this is an interface for a distributed  system   
     * [OperationContract]  Specifies that the function is available to clients.
     * 
     * */

    [ServiceContract]
    interface IAccountAccessInterface
    {
      
        [OperationContract]
        void SelectAccount(uint accountID);

        [OperationContract]
        List<uint> GetAccountIDsByUser(uint userID);

        [OperationContract]
        uint CreateAccount(uint userID);

        [OperationContract]
        void Deposit(uint amount);

        [OperationContract]
        void Withdraw(uint amount);

        [OperationContract]
        uint GetBalance();

        [OperationContract]
        uint GetOwner();
    }
}
