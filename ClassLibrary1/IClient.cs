using IRemote.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public interface IClient
    {
        List<Work> getAllWorks();
        List<Work> getByTitle(String titre);
        List<Work> getByWriter(String writer);
        List<Work> getByTags(String mot_cle);
        List<Work> getByTheme(String theme);
        Boolean reservation(int idClient, int idWork);
    }
}
