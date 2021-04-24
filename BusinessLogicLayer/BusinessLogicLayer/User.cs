using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class User
    {
        private int id;
        private string username;
        private int userLevel;
        private string email;

        // security no password held in user class
        //private string password;




        public int Id
        {
            set { id = value;  /*extra code, whatever*/ }
            get { return id; }
        }

        public string Username
        {
            set { username = value;}
            get { return username; }
        }

        public int Userlevel
        {
            set { userLevel = value;}
            get { return userLevel; }
        }

        public string Email
        {
            set { email = value;}
            get { return email; }
        }




        public User()
        {

        }

        public User(int userId, string username, int userLevel, string email)
        {
            this.id = userId;
            this.username = username;
            this.userLevel = userLevel;
            this.email = email;
          
        }



        public void setData(int userId, string username, int userLevel, string email)
        {
            this.id = userId;
            this.username = username;
            this.userLevel = userLevel;
            this.email = email;
        }


        //dose not get the password from the user table left out 
        public static User Parse(UserDS.TabUserRow userRow)
        {
            if (userRow == null)
            {
                return null;
            }
            else
            {
                //use the constructor
                User user = new User(userRow.UID, userRow.UserName, userRow.UserLevel, userRow.UserEmail);
                return user;
            }
            
        }


       






    }
}
