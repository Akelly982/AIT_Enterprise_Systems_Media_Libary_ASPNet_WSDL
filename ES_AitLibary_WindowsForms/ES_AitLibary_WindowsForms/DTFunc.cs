using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;       // get access to system dataTable  class
using BusinessLogicLayer;   //get access to user/media classes so i can define rows as an object

namespace ES_AitLibary_WindowsForms
{
    public class DTFunc    
    {


        //Setup helper-----------------------------
        //       NOT SPECIFIC FOR THIS CLASS   

        //Properties for copy and past

        //private WebService.WebService ws;
        //private DTFunc dtFunc;

        //inits for copy and past to new classes

        //private WebService.WebService ws;
        //private DTFunc dtFunc;

        //--------------------------------------




        // data table functions -------------
        public void consolePrintDT(System.Data.DataTable dt)
        {

            // For each row, print the values of each column.
            foreach (DataRow row in dt.Rows)
            {
                foreach (DataColumn column in dt.Columns)
                {
                    Console.WriteLine(row[column]);
                }
            }

        }


        public User getOneUserFromDt(System.Data.DataTable dt)
        {
            //Note although it is a datatable their should only be one row in the datatable

            //userClass
            //private int id;    0
            //private string username;   1
            //private int userLevel;    2
            //private string email;    3

            int uid = -1;
            string username = "undefined";
            int userLevel = -1;
            string userEmail = "undefined";


            // For each row, print the values of each column
            foreach (DataRow row in dt.Rows)
            {

                uid = (int)row[0];
                username = (string)row[1];
                userLevel = (int)row[2];
                userEmail = (string)row[3];

            }


            User temp = new User(uid, username, userLevel, userEmail);
            return temp;

        }

        // END data table functions -------------












    }
}
