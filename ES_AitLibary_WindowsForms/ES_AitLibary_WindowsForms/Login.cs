using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;    //now using ASP.NET project to access SQL_DB

namespace ES_AitLibary_WindowsForms
{

    //can be used to pause system for abit before continueing
    //System.Threading.Thread.Sleep(3000);

    public partial class Login : Form
    {

        private WebService.WebService ws;
        private DTFunc dtFunc;

        public Login()
        {
            InitializeComponent();

            BtnCheatLoggin.Visible = true;
            ChkBoxIsAdminCheat.Visible = true;


            ws = new WebService.WebService();
            dtFunc = new DTFunc(); //my class to work with dataTables

            DGVTemp.DataSource = ws.GetAllUsers();
            
        }

        private void BtnCheatLoggin_Click(object sender, EventArgs e)
        {
            bool adminCheat = ChkBoxIsAdminCheat.Checked;
            string username;
            string password;

            // check admin cheat chkbox
            if (adminCheat)
            {
                //get data 
                username = "sup";
                password = "Sup12345";

            }
            else
            {
                //run as if student 
                username = "user";
                password = "User1234";

            }

            getUserAndMoveToMain(username, password);

        }



        private void BtnLoggin_Click(object sender, EventArgs e)
        {
            //get data 
            string username = TextBoxUsername.Text;
            string password = TextBoxPassword.Text;

            //check if text is empty
            if (username.Length > 0 || password.Length > 0)
            {
                getUserAndMoveToMain(username, password);
            }




        }



        private void BtnForgotPassword_Click(object sender, EventArgs e)
        {

        }



        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            //move to next screen
            SignUp s = new SignUp();
            s.Show();
            this.Hide();
        }


        //my functions---------------------------------------------------



       


        public void getUserAndMoveToMain(string username, string password)
        {
            //send to business logic

           
            System.Data.DataTable dt = ws.userLogin(username, password);

            User user = dtFunc.getOneUserFromDt(dt);

            //check for errors
            if (user.Id == -1)
            {
                MessageBox.Show("get user error UID == -1 ");
            }
            else
            {

                //Console.WriteLine(user.Id + " " + user.Username + " " + user.Userlevel + " " + user.Email);
                moveToMainMenuWithData(user);

            }
        }



        public void moveToMainMenuWithData(User user)
        {
            // pass user to next screen
            MainMenu.currentUser = user;
            moveToMainMenuWithHide();
        }


        public void moveToMainMenuWithClose()
        {
            //move to next screen
            MainMenu m = new MainMenu();
            m.Show();
            this.Close();
        }

        public void moveToMainMenuWithHide()
        {
            //move to next screen
            MainMenu m = new MainMenu();
            m.Show();
            this.Hide();
        }





        private void TextBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
