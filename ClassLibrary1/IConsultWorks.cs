using System;
using System.Collections.Generic;
using IRemote.Models;

namespace IRemote
{
    public interface IConsultWorks
    {
        List<Work> getAllWorks();
        List<Work> getByTitle(String titre);
        List<Work> getByWriter(String writer);
        List<Work> getByTags(String mot_cle);
        List<Work> getByTheme(String theme);
    }
}
