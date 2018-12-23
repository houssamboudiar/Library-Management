using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using IRemoteWCF.Models;

namespace IRemoteWCF
{
    [ServiceContract]
    public interface ILibrarian
    {
        // Manage Works
        [OperationContract]
        Boolean AddWork(List<string> tags, List<string> writers, string title, string theme, string type);

        [OperationContract]
        Boolean EditWork(int idWork, List<string> tags, List<string> writers, string title, string theme, string type);

        [OperationContract]
        Boolean DeleteWork(int idWork);

        [OperationContract]
        Boolean ConfirmWork(int idWork, int idBorrower);

        [OperationContract]
        Boolean returnWork(int idWork, int idBorrower);

        // Consult Works
        [OperationContract]
        List<Work> getAllWorks();

        [OperationContract]
        Work getById(int idWork);

        [OperationContract]
        List<Work> getByTitle(String titre);

        [OperationContract]
        List<Work> getByWriter(String writer);

        [OperationContract]
        List<Work> getByTags(String mot_cle);

        [OperationContract]
        List<Work> getByTheme(String theme);

        // Manage Users
        Boolean addUser(string userName, string passWord, string type);

        Boolean deleteUser(string userName, string passWord, string type);
    }
}
