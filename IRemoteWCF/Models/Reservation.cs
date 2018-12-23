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
    class Reservation
    {
        private Borrower borrower;
        private Work work;
        private string reservationDate;

        public Reservation(Borrower borrower, Work work)
        {
            this.Borrower = borrower;
            this.Work = work;
            DateTime dt = DateTime.Now;
            this.ReservationDate = dt.ToString("yyyy-MM-dd HH:mm:ss");

        }
        [DataMember]
        public Borrower Borrower { get => borrower; set => borrower = value; }
        [DataMember]
        public Work Work { get => work; set => work = value; }
        [DataMember]
        public string ReservationDate { get => reservationDate; set => reservationDate = value; }
    }
}