using DataAccessLayer.UserDSTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{

    public class UserDAO
    {

        private UserDS userDataSet;
        private TabUserTableAdapter tabUserAdapter;


        public UserDAO()
        {
            userDataSet = new UserDS();
            tabUserAdapter = new TabUserTableAdapter();
        }

        public UserDS.TabUserDataTable GetAllUserTab()
        {
            try
            {
                tabUserAdapter.FillAll(userDataSet.TabUser);
                return userDataSet.TabUser;
            }
            catch (Exception e)
            {
                throw e;
            }

        }




        public UserDS.TabUserDataTable GetUserByLogin(string username, string password)
        {
            try
            {
                //use adapter to fill the TabUser table in the userDataSet using the FillByUserNamePassword method
                // method requires active table followed by variables is SQL STMT within the method
                //tabUserAdapter.FillByUsernamePassword(userDataSet.TabUser, username, password);
                tabUserAdapter.FillByUsernamePassword(userDataSet.TabUser, username, password);
                //tabUserAdapter.GetDataByUsernamePassword(username, password);
                return userDataSet.TabUser; //return the table full of data
            }
            catch (Exception e)
            {
                throw e;
            }

        }


        public UserDS.TabUserDataTable GetUserById(int id)
        {
            try
            {
                tabUserAdapter.FillByUserId(userDataSet.TabUser, id);
                return userDataSet.TabUser;
            }
            catch (Exception e)
            {
                throw e;
            }

        }



        public bool insertNewUser(string username, string email, string password, int userlevel)
        {

            try
            {
                tabUserAdapter.InsertQueryWithUsernamePasswordUserlevelUserEmail(username,password,userlevel,email);
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
            
        }

        public bool deleteUser(int userId)
        {

            try
            {
                tabUserAdapter.DeleteQueryByUserId(userId);
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }

        }


        public bool updateUserPassword(int userId ,string newPassword)
        {

            try
            {
                tabUserAdapter.UpdateQueryByUserIdForPassword(newPassword, userId);
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public bool updateUser(int userId, string username, string password, string email, int userlevel)
        {

            try
            {
                tabUserAdapter.UpdateUserByUserIDForUsernamePasswordUserlevelUserEmail(username, password, userlevel, email, userId);
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }

        }



    }
}
