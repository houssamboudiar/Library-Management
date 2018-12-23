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
        [DataMember]
        public int Grade { get => grade; set => grade = value; }
        [DataMember]
        public int CardID { get => cardID; set => cardID = value; }
        [DataMember]
        public string FirstName { get => firstName; set => firstName = value; }
        [DataMember]
        public string LastName { get => lastName; set => lastName = value; }
        [DataMember]
        public Account Account { get => account; set => account = value; }
    }
}
