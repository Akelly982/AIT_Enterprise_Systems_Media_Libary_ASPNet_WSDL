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
    public partial class StudentSettings : Form
    {

        public static bool isAdmin;
        public static User user;

        private UserLogic userLogic;

        public StudentSettings()
        {
            InitializeComponent();

            LabelUsername.Text = user.Username;
            LabelUserId.Text = user.Id.ToString();

            // hide admin panel / content
            if (!isAdmin)
            {
                PanelAdmin.Visible = false;
            }

            userLogic = new UserLogic();

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            //NOTES 
            //https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.application.openforms?view=net-5.0
            //The OpenForms property represents a read-only collection of forms owned by the application. 
            //This collection can be searched by index position or by the Name of the Form.

            //address Form class as a whole not you instance of it
            //from discussion with student OpenForms[string] refers to form window text

            Form mainform = Application.OpenForms["MainMenu"];
            mainform.Show();
            this.Close();
        }




        private void BtnAdminResetPassword_Click(object sender, EventArgs e)
        {
            string newPass = TextBoxAdminPasswordReset.Text;
            
            //check if empty
            if (newPass.Length <= 0)
            {
                MessageBox.Show("please fill in the admin new password textbox ");
                return;
            }

            bool result = userLogic.updateUserPassword(user.Id, newPass);

            if (result)
            {
                MessageBox.Show("Password updated to: " + newPass);
            }
            else
            {
                MessageBox.Show("db returned false their was an error.");
            }

        }

        private void BtnAdminDelete_Click(object sender, EventArgs e)
        {
            if (!ChkBoxDelete.Checked)
            {
                MessageBox.Show("please check the delete user check box.");
            }
            else
            {
                bool result = userLogic.deleteUser(user.Id);

                if (result)
                {
                    MessageBox.Show("user deleted successfully");

                    //return to main menu
                    Form mainform = Application.OpenForms["MainMenu"];
                    mainform.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("db returned false their was an error.");
                }
            }
        }

        private void BtnSaveChanges_Click(object sender, EventArgs e)
        {
            //get data 
            string newEmail = TextBoxEmail.Text;
            string newPass1 = TextBoxPassword.Text;
            string newPass2 = TextBoxPasswordRetype.Text;

            //check data 
            if(newEmail.Length == 0 || newPass1.Length == 0 || newPass2.Length == 0)
            {
                MessageBox.Show("one or more of the fields are empty");
                return;
            }

            if(newPass1 != newPass2)
            {
                MessageBox.Show("passwords do not match.");
                return;
            }

            //update user data 
            // current user is declared on entry to page
            userLogic.updateUserAll(user.Id,user.Username,newEmail,newPass1,user.Userlevel);
            MessageBox.Show("user email and password successfully updated.");



        }
    }
}
