using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace BusinessLayer

{
    /*
     * 
     * ITransactionAccessInterface that replicates all the functionality of Transaction Manegemt in the DataLayer
     * [ServiceContract] - Specifies that this is an interface for a distributed  system   
     * [OperationContract]  Specifies that the function is available to clients.
     * This interface reperesent DataLayer Transaction Interface
     * */

    
    [ServiceContract]
    public interface ITransactionAccessInterface
    {
        
        [OperationContract]
        void SelectTransaction(uint TransactionID);
      
        [OperationContract]
        List<uint> GetTransactions();

        [OperationContract]
        uint CreateTransaction();

        [OperationContract]
        uint GetAmount();

        [OperationContract]
        uint GetSendrAcct();

        [OperationContract]
        uint GetRecvrAcct();

        [OperationContract]
        void SetAmount(uint amount);

        [OperationContract]
        void SetSendr(uint acctID);

        [OperationContract]
        void SetRecvr(uint acctID);

        [OperationContract]
        void ExitFunction();

    }
}