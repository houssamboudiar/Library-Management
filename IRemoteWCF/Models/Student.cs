using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;
namespace IRemoteWCF.Models
{
    [DataContract]
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
        [DataMember]
        public int CardID { get => cardID; set => cardID = value; }
        [DataMember]
        public string FirstName { get => firstName; set => firstName = value; }
        [DataMember]
        public string LastName { get => lastName; set => lastName = value; }
        [DataMember]
        public string Specialty { get => specialty; set => specialty = value; }
        [DataMember]
        public string Level { get => level; set => level = value; }
        [DataMember]
        public Account Account { get => account; set => account = value; }
    }
}
