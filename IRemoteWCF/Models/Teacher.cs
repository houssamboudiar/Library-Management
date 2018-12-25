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
    public class Teacher
    {
        private string grade;
        private Borrower borrower;

        public Teacher(string grade, Borrower borrower )
        {
            this.Grade = grade;
            this.Borrower = borrower;
        }

        [DataMember]
        public string Grade { get => grade; set => grade = value; }
        [DataMember]
        public Borrower Borrower { get => borrower; set => borrower = value; }
    }
}
