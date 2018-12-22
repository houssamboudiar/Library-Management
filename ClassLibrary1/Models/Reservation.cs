using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRemote.Models
{
    [Serializable]
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

        public Borrower Borrower { get => borrower; set => borrower = value; }
        public Work Work { get => work; set => work = value; }
        public string ReservationDate { get => reservationDate; set => reservationDate = value; }
    }
}