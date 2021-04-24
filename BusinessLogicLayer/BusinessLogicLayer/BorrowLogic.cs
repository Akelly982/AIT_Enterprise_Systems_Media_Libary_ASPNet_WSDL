using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BorrowLogic
    {

        private BorrowDAO borrowDAO;


        public BorrowLogic()
        {
            borrowDAO = new BorrowDAO();
        }

        
        
        
        
        //Fill ----------
        public List<Borrow> getAllReserved()
        {
            List<Borrow> myList = new List<Borrow>();

            BorrowDS.TabBorrowDataTable myData = borrowDAO.getAllBorrowTab();

            //parse data from datatable rows to list elements
            myList = parseBorrowDataTolistAll(myData);

            return myList;

        }

        public List<Borrow> getByUserForActiveLateFees(int userId)
        {
            List<Borrow> myList = new List<Borrow>();

            BorrowDS.TabBorrowDataTable myData = borrowDAO.getForActiveLateFees(userId);

            //parse data from datatable rows to list elements
            myList = parseBorrowDataTolistAll(myData);

            return myList;
            
        }


        public List<Borrow> getByUserForUserHistory(int userId)
        {
            List<Borrow> myList = new List<Borrow>();

            BorrowDS.TabBorrowDataTable myData = borrowDAO.getForUserHistory(userId);

            //parse data from datatable rows to list elements
            myList = parseBorrowDataTolistAll(myData);

            return myList;

        }

        public List<Borrow> getByUserForUserActivity(int userId)
        {
            List<Borrow> myList = new List<Borrow>();

            BorrowDS.TabBorrowDataTable myData = borrowDAO.getByUserIdForActiveBookings(userId);

            //parse data from datatable rows to list elements
            myList = parseBorrowDataTolistAll(myData);

            return myList;

        }


        public bool getIsMediaAvailable(int mediaId)
        {
            List<Borrow> myList = new List<Borrow>();

            BorrowDS.TabBorrowDataTable myData = borrowDAO.getIsMediaAvailable(mediaId);

            //parse data from datatable rows to list elements
            myList = parseBorrowDataTolistAll(myData);

            // results list count == 0
            if (myList.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool getMediaExists(int mediaId)
        {
            List<Borrow> myList = new List<Borrow>();

            BorrowDS.TabBorrowDataTable myData = borrowDAO.getMediaExists(mediaId);

            //parse data from datatable rows to list elements
            myList = parseBorrowDataTolistAll(myData);

            // results list count == 0
            if (myList.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }





        //insert --------
        public bool insertForCheckOutMedia(int userId, int mediaId)
        {
            return borrowDAO.InsertNewItemBorrowed(userId, mediaId);
        }


        // update -------
        public bool updateMediaForReturn(int borrowId, int lateFee)
        {
            return borrowDAO.updateForMediaReturn(borrowId, lateFee);
        }

        public bool updateMediaPayLateFee(int borrowId)
        {
            return borrowDAO.updateForPayUserLateFee(borrowId);
        }


        //delete ---------
        public bool deleteBorrowItem(int borrowId)
        {
            return borrowDAO.deleteBorrowItem(borrowId);
        }








        //functions ---------
        public List<Borrow> parseBorrowDataTolistAll(BorrowDS.TabBorrowDataTable myDataTable)
        {
            //create list 
            List<Borrow> myList = new List<Borrow>();

            // sort through data by rows
            foreach (BorrowDS.TabBorrowRow row in myDataTable.Rows)
            {

                if (row == null)
                {
                    return null;
                }
                else
                {
                    
                    Borrow borrowItem = new Borrow(row.BID, row.UID, row.MediaID, row.BorrowDate.ToString(), row.ReturnDate.ToString(), row.ActualReturnDate.ToString(), (int)row.LateFee);
                    myList.Add(borrowItem);

                }

            }
            return myList;
        }











    }
}
