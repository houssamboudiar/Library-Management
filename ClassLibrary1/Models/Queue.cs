using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRemote.Models
{
    [Serializable]
    class Queue
    {
        private Borrower borrower;
        private Work work;
        private string date;

        public Queue(Borrower borrower, Work work, string date)
        {
            this.Borrower = borrower;
            this.Work = work;
            this.Date = date;
        }

        public Borrower Borrower { get => borrower; set => borrower = value; }
        public Work Work { get => work; set => work = value; }
        public string Date { get => date; set => date = value; }
    }
}
