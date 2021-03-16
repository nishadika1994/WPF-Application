using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace DataLayer
{
    /*
     * 
     * 
     * 
     *  This is the actual host service system.
     *  
     *  */

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hey so like welcome to my server");
           

            ServiceHost host1; //This represents a tcp/ip binding in the Windows network stack  
            ServiceHost host2;
            ServiceHost host3;
            NetTcpBinding tcp = new NetTcpBinding(); //Bind server to the implementation of DataServer 

            host1 = new ServiceHost(typeof(IDataImplimantaion));  //Present the publicly accessible interface to the client. 
            host2 = new ServiceHost(typeof(IDataImplimantaion));
            host3 = new ServiceHost(typeof(IDataImplimantaion));
            
            /*0.0.0.0 tells .net to accept on any interface. :8005 means this will use port 8100. 
             * DataService is a name for the actual service, this can be any 
            string. */

            host1.AddServiceEndpoint(typeof(IUserAccessInterface), tcp, "net.tcp://localhost:8005/DataService");
            host2.AddServiceEndpoint(typeof(IAccountInterface), tcp, "net.tcp://0.0.0.0:8200/DataService");
            host3.AddServiceEndpoint(typeof(ITransactionInterface), tcp, "net.tcp://localhost:8006/DataService");
          
            //And open the host for data sharing            

            host1.Open();
            host2.Open();
            host3.Open();
          //  Console.WriteLine("System Online");
           // Console.ReadLine();           
            
            //Host Closing 

            host1.Close();
            host2.Close();
            host3.Close();
        }
        }
}

