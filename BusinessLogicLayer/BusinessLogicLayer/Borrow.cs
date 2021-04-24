using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class Borrow
    {

        //properties  with getters and setters 
        private int borrowId;
        private int userId;
        private int mediaId;
        private string borrowDate;
        private string returnDate;
        private string acturalReturnDate;
        private int lateFee;


        //getters and setters   
        public int BorrowId
        {
            set { borrowId = value;}
            get { return borrowId; }
        }

        public int UserId
        {
            set { userId = value; }
            get { return userId; }
        }

        public int MediaId
        {
            set { mediaId = value; }
            get { return mediaId; }
        }

        public string BorrowDate
        {
            set { borrowDate = value; }
            get { return borrowDate; }
        }

        public string ReturnDate
        {
            set { returnDate = value; }
            get { return returnDate; }
        }

        public string ActuralReturnDate
        {
            set { acturalReturnDate = value; }
            get { return acturalReturnDate; }
        }

        public int LateFee
        {
            set { lateFee = value; }
            get { return lateFee; }
        }



        //constructors---

        public Borrow()
        {

        }


        
        public Borrow(int borrowId, int userId, int mediaId, string borrowDate, string returnDate, string acturalReturnDate, int lateFee)
        {
            this.borrowId = borrowId;
            this.userId = userId;
            this.mediaId = mediaId;
            this.borrowDate = borrowDate;
            this.returnDate = returnDate;
            this.acturalReturnDate = acturalReturnDate;
            this.lateFee = lateFee;
        }
        





    }
}
