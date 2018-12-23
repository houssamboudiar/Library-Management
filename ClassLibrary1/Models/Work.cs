using System;
using System.Collections.Generic;
using System.Text;

namespace IRemote.Models
{
    [Serializable]
    public class Work
    {
        private List<string> tags, writers;
        private String title, theme, type;
        private int idWork;

        public Work(List<string> tags, List<string> writers, string title, string theme, string type,int idWork)
        {
            this.Tags = tags;
            this.Writers = writers;
            this.Title = title;
            this.Theme = theme;
            this.Type = type;
            IdWork = idWork;
        }

        public List<string> Tags { get => tags; set => tags = value; }
        public List<string> Writers { get => writers; set => writers = value; }
        public string Title { get => title; set => title = value; }
        public string Theme { get => theme; set => theme = value; }
        public string Type { get => type; set => type = value; }
        public int IdWork { get => idWork; set => idWork = value; }
    }
}
