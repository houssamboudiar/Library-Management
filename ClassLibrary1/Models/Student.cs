using System;
using System.Collections.Generic;
using System.Text;

namespace IRemote.Models
{
    [Serializable]
    public class Student
    {
        private int cardID;
        private String firstName, lastName, specialty, level;
        private Account account;

        public Student(int cardID, string firstName, string lastName, string specialty, string level, Account account)
        {
            this.CardID = cardID;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Specialty = specialty;
            this.Level = level;
            this.Account = account;
        }

        public int CardID { get => cardID; set => cardID = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Specialty { get => specialty; set => specialty = value; }
        public string Level { get => level; set => level = value; }
        public Account Account { get => account; set => account = value; }
    }
}
