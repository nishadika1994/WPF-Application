using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace DataLayer
{
    /*
     * This interface use to commiunicate with BankDB User Interface functionality using .net remoting.
    *  [ServiceContract] - Specifies that this is an interface for a distributed  system   
    *    [OperationContract]  Specifies that the function is available to clients.
    *    The actcal implimentation ind the IDataImplimentation class.
    * */

    [ServiceContract]
   public  interface IUserAccessInterface
    {
        [OperationContract]
        uint CreateUser();


        [OperationContract]
        void SetUserName(string fname, string lname);

        [OperationContract]
        void SelectUser(uint userID);

        [OperationContract]
        List<uint> GetUsers();

        [OperationContract]
        void GetUserName(out string fname, out string lname);

    }
}
