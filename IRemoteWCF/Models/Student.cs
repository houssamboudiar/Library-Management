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
        private String specialty, level;
        private Borrower borrower;

        public Student(Borrower borrower, string specialty, string level)
        {
            this.Specialty = specialty;
            this.Level = level;
            this.Borrower = borrower;
        }
        [DataMember]
        public string Specialty { get => specialty; set => specialty = value; }
        [DataMember]
        public string Level { get => level; set => level = value; }
        [DataMember]
        public Borrower Borrower { get => borrower; set => borrower = value; }
    }
}
