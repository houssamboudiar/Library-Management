using IRemote.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryServer.DataServiceBase
{
    public class ConsultWorksDataService : MarshalByRefObject
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
/*
public List<Work> getAllWorks()
{
    Queue<Work> h = new Queue<Work>();
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

public List<Work> getByTitle(string titre)
{
    throw new NotImplementedException();
}

public List<Work> getByWriter(string auteur)
{
    throw new NotImplementedException();
}
    }*/