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

        //ws = new WebService.WebService();
        //dtFunc = new DTFunc();

        //--------------------------------------



        int errorInt = -1;
        string errorString = "ERROR undefined at dtFunc";



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

            int uid = errorInt;
            string username = errorString;
            int userLevel = errorInt;
            string userEmail = errorString;


            // For each row, print the values of each column
            foreach (DataRow row in dt.Rows)
            {


                
                uid = (int)row[0];
                if(uid == -1)
                {
                    //Leave rest as error string or int
                }
                else
                {
                    username = (string)row[1];
                    userLevel = (int)row[2];
                    userEmail = (string)row[3];
                }
                

            }


            User temp = new User(uid, username, userLevel, userEmail);
            return temp;

        }

        // END data table functions -------------





        public bool getBool(System.Data.DataTable dt)
        {

            //IdAndValue class
            //private int id;       0
            //private string value; 1

            // expected return item list of 1
            // option 3 in webservice
            //
            //if (result)
            //{
            //    temp = new IdAndValue(0, "true");
            //}
            //else
            //{
            //    temp = new IdAndValue(-1, "false");
            //}

            int id = errorInt;
            string value = errorString;

            foreach (DataRow row in dt.Rows)
            {
                id = (int)row[0];
                value = (string)row[1];
            }


            IdAndValue temp = new IdAndValue(id, value);


            if (id == 0)   // 0 == true
            {  
                return true;

            }
            else
            {
                return false;
            }


        }


        public String[] getStrArray(System.Data.DataTable dt)
        {

            //IdAndValue class
            //private int id;        0
            //private string value;  1

            // expected return item list of 1
            // option 4 in webservice
            //
            //if (strArr[0] == "true")
            //{
            //    temp = new IdAndValue(0, strArr[1]);
            //}
            //else
            //{
            //    temp = new IdAndValue(-1, strArr[1]);
            //}
            //
            // id int value will be:     -1 or 0  (boolean)  
            // value string will be:     ( error / success message)

            

            string[] strArr = new string[] { "false", "error message" };

            int id = errorInt;
            string value = errorString;

            foreach (DataRow row in dt.Rows)
            {
                id = (int)row[0];
                value = (string)row[1];
            }

            if(id == 0)     // convert int back into string
            {
                strArr[0] = "true";
            }
            else
            {
                strArr[0] = "false";
            }

            strArr[1] = value;

            
            return strArr;

        }




    }
}
