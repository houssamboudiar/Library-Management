using IRemote.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public interface ILibrarian
    {
        Boolean AddWork(List<string> tags, List<string> writers, string title, string theme, string type);
        Boolean EditWork(int idWork, List<string> tags, List<string> writers, string title, string theme, string type);
        Boolean DeleteWork(int idWork);
        Boolean ConfirmWork(int idWork, int idBorrower);
        Work getById(int idWork);
        //Boolean rendreWork(int idWork, int idBorrower);
    }
}
