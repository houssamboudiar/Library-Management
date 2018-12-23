using IRemoteWCF.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace IRemoteWCF.Control.DataServiceBase
{
    [ServiceContract]
    public class ConsultWorksDataService
    {
        crudMysql crudmysql = new crudMysql("localhost", "poc", "houssamboudiar", "stormspirit99");

        public DataTable getAllWorks()
        {
            string query = "SELECT* FROM `ouvrage`";

            return crudmysql.ReadData(query);
        }

        public List<Work> getByTags(string mot_cle)
        {
            throw new NotImplementedException();
        }


    }
}