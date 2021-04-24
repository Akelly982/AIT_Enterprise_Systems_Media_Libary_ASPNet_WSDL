using DataAccessLayer.BorrowDSTableAdapters;   //dont foget to add this line to get access to child class
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class BorrowDAO
    {

        private BorrowDS borrowDataSet;
        private TabBorrowTableAdapter tabBorrowTableAdapter;
       


        public BorrowDAO()
        {
            borrowDataSet = new BorrowDS();
            tabBorrowTableAdapter = new TabBorrowTableAdapter();
        }






        // fills -----------------
        public BorrowDS.TabBorrowDataTable getAllBorrowTab()
        {
            try
            {
                tabBorrowTableAdapter.FillAll(borrowDataSet.TabBorrow);
                return borrowDataSet.TabBorrow;
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public BorrowDS.TabBorrowDataTable getMediaExists(int mediaId)
        {
            try
            {
                tabBorrowTableAdapter.FillByMediaIdForIfMediaExists(borrowDataSet.TabBorrow, mediaId);
                return borrowDataSet.TabBorrow;
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public BorrowDS.TabBorrowDataTable getForActiveLateFees(int userId)
        {
            try
            {
                tabBorrowTableAdapter.FillByUserIdForActiveLateFees(borrowDataSet.TabBorrow, userId);
                return borrowDataSet.TabBorrow;
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public BorrowDS.TabBorrowDataTable getForUserHistory(int userId)
        {
            try
            {
                tabBorrowTableAdapter.FillByUserIdForUserHistory(borrowDataSet.TabBorrow, userId);
                return borrowDataSet.TabBorrow;
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public BorrowDS.TabBorrowDataTable getByUserIdForActiveBookings(int userId)
        {
            try
            {
                tabBorrowTableAdapter.FillByUserIdGetActiveBookings(borrowDataSet.TabBorrow,userId);
                return borrowDataSet.TabBorrow;
            }
            catch (Exception e)
            {
                throw e;
            }

        }


        public BorrowDS.TabBorrowDataTable getIsMediaAvailable(int mediaId)
        {

            // returns a row if it is out already to another user
            // checks to see if it has been returned
                  //  ActuralReturnDate != 1111-11-11
            try
            {
                tabBorrowTableAdapter.FillByMediaIDForIsMediaAvailable(borrowDataSet.TabBorrow, mediaId);
                return borrowDataSet.TabBorrow;
            }
            catch(Exception e)
            {
                throw e;
            }

        }




        // update -----------------------------------

        public bool updateForMediaReturn(int borrowId, int lateFee)
        {
            bool result = true;
            try
            {
                tabBorrowTableAdapter.UpdateForMediaReturn(lateFee,borrowId);
            }
            catch (Exception e)
            {
                result = false;
                throw e;
            }
            return result;

        }


        public bool updateForPayUserLateFee(int borrowId)
        {
            try
            {
                tabBorrowTableAdapter.UpdateForPayUserLateFee(borrowId);
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }

        }


        //Insert -------------------------------
        public bool InsertNewItemBorrowed(int userId, int mediaId)
        {
            try
            {
                tabBorrowTableAdapter.InsertQueryWithUserIdMediaId(userId, mediaId);
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }

        }


        // Delete -----------------------------------------
        public bool deleteBorrowItem(int borrowId)
        {
            try
            {
                tabBorrowTableAdapter.DeleteByBID(borrowId);
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }

        }





    }
}
