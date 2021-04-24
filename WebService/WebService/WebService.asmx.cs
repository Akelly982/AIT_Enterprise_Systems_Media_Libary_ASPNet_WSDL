using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
//added
using System.Data;
using BusinessLogicLayer;

namespace WebService
{
    /// <summary>
    /// Summary description for WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {

        // init addded 
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }




        [WebMethod]
        public DataTable GetListOfUsers()
        {

            UserLogic userLogic = new UserLogic();
            List<User> users = userLogic.getAllUsers();

            //convert our list to a datatable and return it
            return AppUtil.ToDataTable(users); //returns this in the form of xml to be sent via the internet or local network

        }


        [WebMethod]
        public DataTable Login(string username, string password)
        {
            UserLogic userLogic = new UserLogic();
            User user = userLogic.userLogin(username, password);

            //sneaky list user of 1 user
            List<User> userList = new List<User>();
            userList.Add(user);

            return AppUtil.ToDataTable(userList);

        }



        [WebMethod]
        public DataTable NewMethodAddedByAidan(string username, string password)
        {
            UserLogic userLogic = new UserLogic();
            User user = userLogic.userLogin(username, password);

            //sneaky list user of 1 user
            List<User> userList = new List<User>();
            userList.Add(user);

            return AppUtil.ToDataTable(userList);

        }






    }
}
