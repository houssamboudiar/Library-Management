using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRemote.Models
{
    [Serializable]
    public class Teacher
    {
        private int grade,cardID;
        private String firstName, lastName;
        private Account account;

        public Teacher(int grade, int cardID, string firstName, string lastName, Account account)
        {
            this.Grade = grade;
            this.CardID = cardID;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Account = account;
        }

        public int Grade { get => grade; set => grade = value; }
        public int CardID { get => cardID; set => cardID = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public Account Account { get => account; set => account = value; }
    }
}
