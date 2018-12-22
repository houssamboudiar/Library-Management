using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRemote.Models
{
    [Serializable]
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

        public Account Account { get => account; set => account = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
    }
}
