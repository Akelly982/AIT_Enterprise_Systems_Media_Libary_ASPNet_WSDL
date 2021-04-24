using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.ReservedDSTableAdapters;

namespace DataAccessLayer
{
    public class ReservedDAO
    {



        private ReservedDS reservedDataSet;
        private TabReservedTableAdapter tabReservedTableAdapter;



        public ReservedDAO()
        {
            reservedDataSet = new ReservedDS();
            tabReservedTableAdapter = new TabReservedTableAdapter();
        }




        //FillBy ---------

        public ReservedDS.TabReservedDataTable getAllReservedTab()
        {
            try
            {
                tabReservedTableAdapter.FillAll(reservedDataSet.TabReserved);
                return reservedDataSet.TabReserved;
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public ReservedDS.TabReservedDataTable getMediaExist(int mediaId)
        {
            try
            {
                tabReservedTableAdapter.FillByMediaIdForIfMediaExists(reservedDataSet.TabReserved, mediaId);
                return reservedDataSet.TabReserved;
            }
            catch (Exception e)
            {
                throw e;
            }

        }



        public ReservedDS.TabReservedDataTable getReservedActive(int userId)
        {
            try
            {
                tabReservedTableAdapter.FillByUserIdForReservedActive(reservedDataSet.TabReserved, userId);
                return reservedDataSet.TabReserved;
            }
            catch (Exception e)
            {
                throw e;
            }

        }


        public ReservedDS.TabReservedDataTable getReservedHistory(int userId)
        {
            try
            {
                tabReservedTableAdapter.FillByUserIdForReservedHistory(reservedDataSet.TabReserved, userId);
                return reservedDataSet.TabReserved;
            }
            catch (Exception e)
            {
                throw e;
            }

        }


        // insert ---------------------

        public bool insertNewReserved(int userId, int mediaId, string dateMonthDayYear)   //monthDayYear format == "04-20-2020"
        {
            try
            {
                tabReservedTableAdapter.InsertNewReservedMedia(userId, mediaId, dateMonthDayYear);
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }

        }



        //delete ----------------
        public bool deleteReserved(int reservedId)  
        {
            try
            {
                tabReservedTableAdapter.DeleteWithReservedId(reservedId);
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }

        }















    }
}
