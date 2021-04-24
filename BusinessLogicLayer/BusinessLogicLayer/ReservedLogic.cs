using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class ReservedLogic
    {

        private ReservedDAO reservedDAO;

        public ReservedLogic()
        {
            reservedDAO = new ReservedDAO();
        }



        public List<Reserve> getAllReserved()
        {
            List<Reserve> myList = new List<Reserve>();

            ReservedDS.TabReservedDataTable myData = reservedDAO.getAllReservedTab();

            //parse data from datatable rows to list elements
            myList = parseReserveDataTolistAll(myData);

            return myList;

        }


        public List<Reserve> getReservedActive(int userId)
        {
            List<Reserve> myList = new List<Reserve>();

            ReservedDS.TabReservedDataTable myData = reservedDAO.getReservedActive(userId);

            //parse data from datatable rows to list elements
            myList = parseReserveDataTolistAll(myData);

            return myList;

        }

        public List<Reserve> getReservedHistory(int userId)
        {
            List<Reserve> myList = new List<Reserve>();

            ReservedDS.TabReservedDataTable myData = reservedDAO.getReservedHistory(userId);

            //parse data from datatable rows to list elements
            myList = parseReserveDataTolistAll(myData);

            return myList;

        }

        public bool getMediaExists(int mediaId)
        {
            List<Reserve> myList = new List<Reserve>();

            ReservedDS.TabReservedDataTable myData = reservedDAO.getMediaExist(mediaId);

            //parse data from datatable rows to list elements
            myList = parseReserveDataTolistAll(myData);

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
        public bool insertNewReservation(int userId, int mediaId, string dateMonthDayYear)
        {
            return reservedDAO.insertNewReserved(userId, mediaId, dateMonthDayYear);
        }


        //delete ---------
        public bool deleteReservation(int reserveId)
        {
            return reservedDAO.deleteReserved(reserveId);
        }










        //functions ---------
        public List<Reserve> parseReserveDataTolistAll(ReservedDS.TabReservedDataTable myDataTable)
        {
            //create list 
            List<Reserve> myList = new List<Reserve>();

            // sort through data by rows
            foreach (ReservedDS.TabReservedRow row in myDataTable.Rows)
            {

                if (row == null)
                {
                    return null;
                }
                else
                {
                    Reserve reserveItem = new Reserve(row.RID, row.UID, row.MediaID, row.ReservedDate.ToString());
                    myList.Add(reserveItem);
                }

            }
            return myList;
        }


















    }
}
