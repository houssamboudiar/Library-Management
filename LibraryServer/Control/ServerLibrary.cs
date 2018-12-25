using ClassLibrary1;
using IRemote.Models;
using LibraryServer.DataServiceBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryServer.Control
{
    class ServerLibrary : MarshalByRefObject, ILibrarian, IClient
    {
        ManageWorksDataService manageWorksDataService = new ManageWorksDataService();

        public bool AddWork(List<string> tags, List<string> writers, string title, string theme, string type)
        {
            Work work = new Work(tags, writers, title, theme, type, idWork);
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
            Work work = new Work(tags, writers, title, theme, type, idWork);
            return manageWorksDataService.EditWork(idWork, work);
        }

        ConsultWorksDataService consultWorksDataService = new ConsultWorksDataService();
        private int idWork;

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
            Console.WriteLine(listWorks[0].Type);
            foreach (Work work in listWorks)
            {
                //Console.WriteLine(work.Type);
                Console.WriteLine(work.IdWork);
                if (work.IdWork == idWork)
                {
                    Console.WriteLine(work.Type);
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

        public bool reservation(int idClient, int idWork)
        {
            throw new NotImplementedException();
        }
    }
}
