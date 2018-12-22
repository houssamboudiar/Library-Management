using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRemote.Models
{
    [Serializable]
    public class Account
    {
        private string userName, passWord , type;

        public Account(string userName, string passWord, string type)
        {
            this.UserName = userName;
            this.PassWord = passWord;
            this.Type = type;
        }

        public string UserName { get => userName; set => userName = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        public string Type { get => type; set => type = value; }
    }
}

