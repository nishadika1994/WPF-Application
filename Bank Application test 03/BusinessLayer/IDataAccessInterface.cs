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
     * IDataAccessInterface that replicates all the functionality of userMangemenet in the DataLayer
     * [ServiceContract] - Specifies that this is an interface for a distributed  system   
     * [OperationContract]  Specifies that the function is available to clients.
     * 
     * */


    [ServiceContract]
     interface IDataAccessInterface
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
