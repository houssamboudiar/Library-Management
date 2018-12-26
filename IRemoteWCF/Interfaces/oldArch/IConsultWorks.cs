using System;
using System.Collections.Generic;
using System.ServiceModel;
using IRemoteWCF.Models;

namespace IRemoteWCF
{
    [ServiceContract]
    public interface IConsultWorks
    {

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

    }
}