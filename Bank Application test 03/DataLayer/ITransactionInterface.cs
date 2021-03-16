using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace DataLayer
{

    /*
    *  [ServiceContract] - Specifies that this is an interface for a distributed  system   
    *    [OperationContract]  Specifies that the function is available to clients.
    *    This iterface is use to communicate with BankDB TransactionInterface  functionality using .net remoting.
    *    The actcal implimentation ind the IDataImplimentation class.
    * */

    [ServiceContract]
    public interface ITransactionInterface
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
