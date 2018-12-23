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

namespace IRemoteWCF.Control
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    //[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    //[ServiceBehavior(InstanceContextMode = InstanceContextMode.Percall)]
    public class ImplManage : IClient , ILibrarian
    {
        ManageWorksDataService manageWorksDataService = new ManageWorksDataService();
        ConsultWorksDataService consultWorksDataService = new ConsultWorksDataService();


        public bool AddWork(List<string> tags, List<string> writers, string title, string theme, string type)
        {
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
            Work work = new Work(tags, writers, title, theme, type,0);
            return manageWorksDataService.EditWork(idWork, work);
        }

        // Needs implementation
        public bool returnWork(int idWork, int idBorrower)
        {
            throw new NotImplementedException();
        }

        public bool reserveWork(int idClient, int idWork)
        {
            throw new NotImplementedException();
        }

        public bool authenticateUser(string userName, string passWord, string type)
        {
            throw new NotImplementedException();
        }

        public bool modifyUser(string userName, string passWord, string type)
        {
            throw new NotImplementedException();
        }

        public bool addUser(string userName, string passWord, string type)
        {
            throw new NotImplementedException();
        }

        public bool deleteUser(string userName, string passWord, string type)
        {
            throw new NotImplementedException();
        }

        // Implemented elsewhere
        public List<Work> getAllWorks()
        {
            throw new NotImplementedException();
        }

        public List<Work> getByTitle(string titre)
        {
            throw new NotImplementedException();
        }

        public List<Work> getByWriter(string writer)
        {
            throw new NotImplementedException();
        }

        public List<Work> getByTags(string mot_cle)
        {
            throw new NotImplementedException();
        }

        public List<Work> getByTheme(string theme)
        {
            throw new NotImplementedException();
        }

        public Work getById(int idWork)
        {
            throw new NotImplementedException();
        }
    }

    public class ImplConsult : IClient, ILibrarian
    {
        ManageWorksDataService manageWorksDataService = new ManageWorksDataService();
        ConsultWorksDataService consultWorksDataService = new ConsultWorksDataService();

        public List<Work> getAllWorks()
        {
            DataTable workTable = consultWorksDataService.getAllWorks();

            List<Work> workList = new List<Work>();

            foreach (DataRow dr in workTable.Rows)
            {
                List<string> tags = null, writers = null;
                String title, theme, type;
                int idWork;

                idWork = Convert.ToInt32(dr["code"]);
                title = dr["titre"].ToString();
                theme = dr["theme"].ToString();
                type = dr["type"].ToString();
                String Strtags = dr["mots_cle"].ToString();
                String Strwriters = dr["auteurs"].ToString();

                string[] separatingChars = { ", ", "," };

                tags = Strtags.Split(separatingChars, System.StringSplitOptions.RemoveEmptyEntries).ToList();
                writers = Strwriters.Split(separatingChars, System.StringSplitOptions.RemoveEmptyEntries).ToList();

                workList.Add(new Work(tags, writers, title, theme, type, idWork));
            }
            return workList;
        }

        public Work getById(int idWork)
        {
            List<Work> listWorks = getAllWorks();
            foreach (Work work in listWorks)
            {
                Console.WriteLine("Work ID : " + work.IdWork);
                Console.WriteLine("Searched Work ID : " + idWork);
                if (work.IdWork == idWork)
                {
                    return work;
                }
            }
            Console.WriteLine("Work with ID : " + idWork + " not found !");
            return null;
        }

        public List<Work> getByTags(string mot_cle)
        {
            List<Work> listWorks = getAllWorks();
            List<Work> searchResult = new List<Work>();
            foreach (Work work in listWorks)
            {
                if (work.Tags.Contains(mot_cle))
                {
                    searchResult.Add(work);
                }
            }
            return searchResult;
        }

        public List<Work> getByTheme(string theme)
        {
            List<Work> listWorks = getAllWorks();
            List<Work> searchResult = new List<Work>();

            foreach (Work work in listWorks)
            {
                if (work.Theme.Equals(theme))
                {
                    searchResult.Add(work);
                }
            }

            return searchResult;

        }

        public List<Work> getByTitle(string titre)
        {
            List<Work> listWorks = getAllWorks();
            List<Work> searchResult = new List<Work>();

            foreach (Work work in listWorks)
            {
                if (work.Title.Equals(titre))
                {
                    searchResult.Add(work);
                }
            }

            return searchResult;
        }

        public List<Work> getByWriter(string writer)
        {
            List<Work> listWorks = getAllWorks();
            List<Work> searchResult = new List<Work>();

            foreach (var work in listWorks)
            {
                if (work.Writers.Contains(writer))
                {
                    searchResult.Add(work);
                }
            }
            return searchResult;
        }

        // Implemented elsewhere

        public bool addUser(string userName, string passWord, string type)
        {
            throw new NotImplementedException();
        }

        public bool AddWork(List<string> tags, List<string> writers, string title, string theme, string type)
        {
            throw new NotImplementedException();
        }

        public bool authenticateUser(string userName, string passWord, string type)
        {
            throw new NotImplementedException();
        }

        public bool ConfirmWork(int idWork, int idBorrower)
        {
            throw new NotImplementedException();
        }

        public bool deleteUser(string userName, string passWord, string type)
        {
            throw new NotImplementedException();
        }

        public bool DeleteWork(int idWork)
        {
            throw new NotImplementedException();
        }

        public bool EditWork(int idWork, List<string> tags, List<string> writers, string title, string theme, string type)
        {
            throw new NotImplementedException();
        }



        public bool modifyUser(string userName, string passWord, string type)
        {
            throw new NotImplementedException();
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
