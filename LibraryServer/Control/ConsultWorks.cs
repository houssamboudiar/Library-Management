using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IRemote.Models;
using IRemote;
using LibraryServer.DataServiceBase;
using System.Data;

namespace LibraryServer.Control
{
    public class ConsultWorks : MarshalByRefObject, IConsultWorks
    {
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

                string[] separatingChars = { ", " , ","};

                tags = Strtags.Split(separatingChars, System.StringSplitOptions.RemoveEmptyEntries).ToList();
                writers = Strwriters.Split(separatingChars, System.StringSplitOptions.RemoveEmptyEntries).ToList();

                workList.Add(new Work(tags,writers, title,theme,type,idWork));
            }
            return workList;
        }

        public Work getById(int idWork)
        {
            List<Work> listWorks = getAllWorks();
            foreach (Work work in listWorks)
            {
                Console.WriteLine("Work ID : " + work.IdWork );
                Console.WriteLine("Searched Work ID : " + idWork );
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
    }
}
