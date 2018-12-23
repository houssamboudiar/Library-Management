using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace IRemoteWCF.Models
{
    [DataContract]
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
        [DataMember]
        public List<string> Tags { get => tags; set => tags = value; }
        [DataMember]
        public List<string> Writers { get => writers; set => writers = value; }
        [DataMember]
        public string Title { get => title; set => title = value; }
        [DataMember]
        public string Theme { get => theme; set => theme = value; }
        [DataMember]
        public string Type { get => type; set => type = value; }
        [DataMember]
        public int IdWork { get => idWork; set => idWork = value; }
    }
}
