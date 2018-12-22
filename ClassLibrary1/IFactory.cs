using System;
using System.Collections.Generic;
using System.Text;

namespace IRemote
{
    public interface IFactory
    {
        IConsultWorks consultWorks();
        IManageWorks manageWorks();
    }
}
