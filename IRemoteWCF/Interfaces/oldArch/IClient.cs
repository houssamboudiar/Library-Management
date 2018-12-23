using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using IRemoteWCF.Models;


namespace IRemoteWCF
{
    [ServiceContract]
    public interface IClient
    {
        // Consult Works
        [OperationContract]
        List<Work> getAllWorks();

        [OperationContract]
        List<Work> getByTitle(String titre);

        [OperationContract]
        List<Work> getByWriter(String writer);

        [OperationContract]
        List<Work> getByTags(String mot_cle);

        [OperationContract]
        List<Work> getByTheme(String theme);

        // Manage Works
        [OperationContract]
        Boolean reserveWork(int idClient, int idWork);


        // Manage account
        [OperationContract]
        Boolean authenticateUser(string userName, string passWord, string type);

        [OperationContract]
        Boolean modifyUser(string userName, string passWord, string type);

    }
}


