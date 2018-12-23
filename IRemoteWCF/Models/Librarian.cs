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
    public class Librarian
    {
        private Account account;
        private String firstName, lastName;

        public Librarian(Account account, string firstName, string lastName)
        {
            this.Account = account;
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        [DataMember]
        public Account Account { get => account; set => account = value; }
        [DataMember]
        public string FirstName { get => firstName; set => firstName = value; }
        [DataMember]
        public string LastName { get => lastName; set => lastName = value; }
    }
}
