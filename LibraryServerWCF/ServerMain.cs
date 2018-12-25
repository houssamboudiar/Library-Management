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
            ServiceHost svcConsultWorks = null;
            ServiceHost svcManageWorks = null;
            try
            {
                svcConsultWorks = new ServiceHost(typeof(IRemoteWCF.ConsultWorks));
                svcManageWorks = new ServiceHost(typeof(IRemoteWCF.ManageWorks));
                svcConsultWorks.Open();
                svcManageWorks.Open();
                Console.WriteLine("\n\nService is Running  at following address");
                Console.WriteLine("\nhttp://localhost:9001/ConsultWorks");
                Console.WriteLine("\nnet.tcp://localhost:9002/ConsultWorks   ");

                Console.WriteLine("\n\nService is Running  at following address");
                Console.WriteLine("\nhttp://localhost:9001/ManageWorks");
                Console.WriteLine("\nnet.tcp://localhost:9002/ManageWorks   ");

                Console.ReadLine();
            }
            catch (Exception eX)
            {
                svcConsultWorks = null;
                svcManageWorks = null;
                Console.WriteLine("Service can not be started \n\nError Message [" + eX.Message + "]");
                Console.ReadLine();
            }
            if (svcConsultWorks != null && svcManageWorks != null)
            {
                Console.WriteLine("\nPress any key to close the Service");
                Console.ReadKey();
                svcConsultWorks.Close();
                svcManageWorks.Close();
                svcConsultWorks = null;
                svcManageWorks = null;
            }
            Console.ReadLine();
        }
    }
}