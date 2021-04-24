using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ES_AitLibary_WindowsForms
{
    public partial class SignUp : Form
    {


        private bool isAdmin = false;
        //public UserLogic userLogic;
        public static User currentUser = null;  //initialize as null
        


        public SignUp()
        {
            InitializeComponent();

            PanelSignUpAdmin.Visible = false;

            // check if I have a user set
            // if true check if its admin 
            // if not admin return to main menu
            if (currentUser != null)  
            {
                if (currentUser.Userlevel != 1)
                {
                    PanelSignUpAdmin.Visible = true;
                    isAdmin = true;
                }
                else
                {
                    //todo return non admin to main menu screen
                    // they should not be able to get here

                }

            }

            //get connection to user logic
            // TODO: SignUp - init connection
            //userLogic = new UserLogic();

        }


        private void BtnRegister_Click(object sender, EventArgs e)
        {
            // get data 
            string username = TextBoxUsername.Text;
            string email = TextBoxEmail.Text;
            string password = TextBoxPassword.Text;
            int userLevel = 1;

            if (isAdmin)
            {
                userLevel = getAdminUserLevelRadioBtnValue();
                if(userLevel == -1)
                {
                    //if for some reason no radio btn set (should default to student)
                    MessageBox.Show("Please select a userlevel for this new student");
                    return;
                }
                
            }


            //check fields valid
            if (username.Length == 0 || email.Length == 0 || password.Length == 0)
            {
                MessageBox.Show("Please Fill in all text boxes.");
                return;
            }


            if(userLevel == 1 || userLevel == 2)  // has to be student or admin user
            {
                //run update method
                // TODO: SignUp - insert new user
                //bool result = userLogic.insertNewUser(username, email, password, userLevel);

                //if (result)
                //{
                //    //reset signUp pg class vars
                //    resetSignUpPgAdminStatus();

                //    if (isAdmin)
                //    {
                //        //for more details go to STUDENT SETTINGS return btn method
                //        Form mainform = Application.OpenForms["MainMenu"];
                //        mainform.Show();
                //        this.Close();


                //    }
                //    //for more details go to STUDENT SETTINGS return btn method
                //    Form login = Application.OpenForms["Login"];
                //    login.Show();
                //    this.Close();

                //}
                //else
                //{
                //    MessageBox.Show("DB returned false");
                //}
            }
            else
            {
                MessageBox.Show("UserLevel out of range");
                return;
            }

            




        }



        private int getAdminUserLevelRadioBtnValue()
        {
            int radioBtnValue = -1;

            if (RadioButtonStudent.Checked)
            {
                radioBtnValue = 1;
            }
            else if (RadioButtonAdmin.Checked)
            {
                radioBtnValue = 2;
            }

            return radioBtnValue;
        }










        private void BtnBack_Click(object sender, EventArgs e)
        {
            //for more details go to STUDENT SETTINGS return btn method
            Form mainform = Application.OpenForms["MainMenu"];

            //reset signUp pg class vars
            resetSignUpPgAdminStatus();

            if(mainform != null)  //does not yet exist
            {
                mainform.Show();
                this.Close();
            }
            else
            {
                //return to login
                Form login = Application.OpenForms["login"];
                login.Show();
                this.Close();

            }
            
        }




        // reset class variables to default on page leave
        private void resetSignUpPgAdminStatus()
        {
            isAdmin = false;
            currentUser = null;
        }

        


    }
}
