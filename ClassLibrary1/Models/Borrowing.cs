using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRemote.Models
{
    [Serializable]
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

        public Work Work { get => work; set => work = value; }
        public string Date { get => date; set => date = value; }
        internal Borrower Borrower { get => borrower; set => borrower = value; }
    }
}
