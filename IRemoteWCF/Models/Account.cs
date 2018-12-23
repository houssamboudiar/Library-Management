using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;


namespace IRemoteWCF.Models
{
    [DataContract]
    public class Account
    {
        private string userName, passWord , type;

        public Account(string userName, string passWord, string type)
        {
            this.UserName = userName;
            this.PassWord = passWord;
            this.Type = type;
        }

        [DataMember]
        public string UserName { get => userName; set => userName = value; }
        [DataMember]
        public string PassWord { get => passWord; set => passWord = value; }
        [DataMember]
        public string Type { get => type; set => type = value; }
    }
}

