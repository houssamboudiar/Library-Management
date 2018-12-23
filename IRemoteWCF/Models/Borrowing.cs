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
    public class Borrowing
    {
        private Borrower borrower;
        private Work work;
        private string date;

        public Borrowing(Borrower borrower, Work work, string date)
        {
            this.Borrower = borrower;
            this.Work = work;
            this.Date = date;
        }
        [DataMember]
        public Work Work { get => work; set => work = value; }
        [DataMember]
        public string Date { get => date; set => date = value; }
        [DataMember]
        internal Borrower Borrower { get => borrower; set => borrower = value; }
    }
}
