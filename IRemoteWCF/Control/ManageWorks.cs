using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IRemoteWCF.Models;
using IRemoteWCF;
using IRemoteWCF.Control.DataServiceBase;
using System.Data;
using System.ServiceModel;


namespace IRemoteWCF
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    public class ManageWorks : IManageWorks
    {
        ManageWorksDataService manageWorksDataService = new ManageWorksDataService();

        public bool AddWork(List<string> tags, List<string> writers, string title, string theme, string type)
        {
            if( type != "Thèses" || type != "Livre" || type != "Mémoires")
            {
                Console.WriteLine("Sorry cannot insert such type "+ type);
                return false;
            }
            Work work = new Work(tags, writers, title, theme, type,0);
            return manageWorksDataService.addWorkDataService(work);
        }

        public bool ConfirmWork(int idWork, int idBorrower)
        {
            return manageWorksDataService.confirmReservationDataService(idWork, idBorrower);
        }

        public bool DeleteWork(int idWork)
        {
            return manageWorksDataService.deleteWorkDataService(idWork);
        }

        public bool EditWork(int idWork, List<string> tags, List<string> writers, string title, string theme, string type)
        {
            if (type != "Thèses" || type != "Livre" || type != "Mémoires")
            {
                Console.WriteLine("Sorry cannot insert such type " + type);
                return false;
            }

            Work work = new Work(tags, writers, title, theme, type,0);

            return manageWorksDataService.EditWork(idWork, work);
        }

        public bool reserveWork(int idClient, int idWork)
        {
            throw new NotImplementedException();
        }

        public bool returnWork(int idWork, int idBorrower)
        {
            throw new NotImplementedException();
        }
    }
}
