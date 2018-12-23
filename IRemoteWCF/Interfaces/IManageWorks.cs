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
    public interface IManageWorks
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

        [OperationContract]
        Boolean reserveWork(int idClient, int idWork);
    }
}
