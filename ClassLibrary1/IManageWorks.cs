using System;
using System.Collections.Generic;
using System.Text;
using IRemote.Models;

namespace IRemote
{
    public interface IManageWorks
    {
        Boolean AddWork(List<string> tags, List<string> writers, string title, string theme, string type);
        Boolean EditWork(int idWork, List<string> tags, List<string> writers, string title, string theme, string type);
        Boolean DeleteWork(int idWork);
        Boolean ConfirmWork(int idWork , int idBorrower);
    }
}
