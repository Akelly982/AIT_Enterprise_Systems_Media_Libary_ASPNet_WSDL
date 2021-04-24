using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class UserLogic
    {



        //if you are struggleing to find your class listed
        // make sure that your class is a public class

        private UserDAO userDAO;
        private UserDS.TabUserDataTable userTable;


        public UserLogic()
        {
            userDAO = new UserDAO();
            userTable = new UserDS.TabUserDataTable();
        }




        // gets singular user
        public User userLogin(string username,string password)
        {



            User user = new User();

            // get our table data from our DAO
            userTable = userDAO.GetUserByLogin(username, password);

            //go through table data row by row
            if(userTable.Count == 1) // their should only be one user 
            {
                //get data 
                foreach(UserDS.TabUserRow userRow in userTable.Rows)
                {
                    user.setData(userRow.UID, userRow.UserName, userRow.UserLevel, userRow.UserEmail);
                }
            }
            else
            {
                user.Id = -1;
            }


            //User will be either fully set or have an id of -1

            return user;

        }



        public User getUserById(int userId)
        {

            User user = new User();

            // get our table data from our DAO
            userTable = userDAO.GetUserById(userId);

            //go through table data row by row
            if (userTable.Count == 1) // their should only be one user 
            {
                //get data 
                foreach (UserDS.TabUserRow userRow in userTable.Rows)
                {
                    user.setData(userRow.UID, userRow.UserName, userRow.UserLevel, userRow.UserEmail);
                }
            }
            else
            {
                user.Id = -1;
            }


            //User will be either fully set or have an id of -1

            return user;

        }


        public List<User> getAllUsers()
        {
            List<User> users = new List<User>();

            // get our table data from our DAO
            userTable = userDAO.GetAllUserTab();

            //go through table data row by row
            //get data 
            foreach (UserDS.TabUserRow userRow in userTable.Rows)
            {
                User user = new User();
                user.setData(userRow.UID, userRow.UserName, userRow.UserLevel, userRow.UserEmail);

                //add user to list
                users.Add(user);
            }


            return users;
        }




        // CRUD ------------------------------------------

        public bool insertNewUser(string username, string email, string password, int userLevel)
        {
            bool checker = userDAO.insertNewUser(username, email, password, userLevel);
            return checker;
        }


        public bool updateUserAll(int userId,string username, string email, string password, int userLevel)
        {
            bool checker = userDAO.updateUser(userId,username,password,email,userLevel);
            return checker;
        }

        public bool updateUserPassword(int userId, string newPassword)
        {
            bool checker = userDAO.updateUserPassword(userId, newPassword);
            return checker;
        }

        public bool deleteUser(int userId)
        {
            bool checker = userDAO.deleteUser(userId);
            return checker;
        }

        //----------------------------------------------------------------------




    }
}
