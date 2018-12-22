using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRemote.Models
{
    [Serializable]
    public class Borrower
    {
        private int CardID;
        private String firstName, lastName;
        private Account account;

        public Borrower(int cardID, string firstName, string lastName, Account account)
        {
            CardID1 = cardID;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Account = account;
        }

        public int CardID1 { get => CardID; set => CardID = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public Account Account { get => account; set => account = value; }
    }
}
