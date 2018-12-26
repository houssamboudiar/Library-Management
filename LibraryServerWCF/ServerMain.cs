using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Description;
using IRemoteWCF.Models;
using IRemoteWCF.Control.DataServiceBase;
using IRemoteWCF.Control;

namespace LibraryServiceWCF
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost svcClientServerLibrary = null;
            ServiceHost svcLibrarianServerLibrary = null;
            try
            {
                svcClientServerLibrary = new ServiceHost(typeof(IRemoteWCF.ClientServerLibrary));
                svcLibrarianServerLibrary = new ServiceHost(typeof(IRemoteWCF.LibrarianServerLibrary));
                svcClientServerLibrary.Open();
                svcLibrarianServerLibrary.Open();

                Console.WriteLine("\n\nService is Running  at following address");
                Console.WriteLine("\nnet.tcp://localhost:9002/ClientServerLibrary");

                Console.WriteLine("\n\nService is Running  at following address");
                Console.WriteLine("\nnet.tcp://localhost:9002/LibrarianServerLibrary");

                Console.ReadLine();
            }
            catch (Exception eX)
            {
                svcClientServerLibrary = null;
                svcLibrarianServerLibrary = null;
                Console.WriteLine("Service can not be started \n\nError Message [" + eX.Message + "]");
                Console.ReadLine();
            }
            if (svcClientServerLibrary != null || svcLibrarianServerLibrary != null)
            {
                Console.WriteLine("\nPress any key to close the Service");
                Console.ReadKey();
                svcClientServerLibrary.Close();
                svcLibrarianServerLibrary.Close();
                svcClientServerLibrary = null;
                svcLibrarianServerLibrary = null;
            }
            Console.ReadLine();
        }
    }
}