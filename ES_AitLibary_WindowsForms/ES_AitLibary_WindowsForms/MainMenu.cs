using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace ES_AitLibary_WindowsForms
{
    public partial class MainMenu : Form
    {


        private bool isAdmin = false;  //initialize as false
        private WebService.WebService ws;
        private DTFunc dtFunc;
        public static User currentUser;
        public DataGridViewRow activeMediaViewRow = null; //init as no row selected

        public MainMenu()
        {
            InitializeComponent();

            if(currentUser.Userlevel != 1)   // check if user is admin
            {
                isAdmin = true;
            }

            if (!isAdmin)    // depending on user level show different content
            {
                LabelStudentUsername.Text = currentUser.Username;
                LabelStudentId.Text = currentUser.Id.ToString();
                LabelAdminUsername.Visible = false;

                PanelMediaLibaryAdminBtns.Visible = false;
                PanelStudentRowShowAdminContent.Visible = false;

            }
            else
            {
                LabelAdminUsername.Text = "Admin: " + currentUser.Username;
                PanelStudentRowShowStudentContent.Visible = false;
            }



            //inits
            dtFunc = new DTFunc();
            ws = new WebService.WebService();
            //mediaLogic = new MediaLogic();
            //userLogic = new UserLogic();
            //borrowLogic = new BorrowLogic();
            //reservedLogic = new ReservedLogic();


            //show all media
            // set data  source for data grid view
            // In this case a List<media>

            // TODO: MainMenu - mediaLibary.ds
            //DataGridViewMediaLibary.DataSource = mediaLogic.getAllMedia();
            


        }





        private void BtnMediaLibarySearch_Click(object sender, EventArgs e)
        {

            //which radio btn are we seraching by
            // should return string 
            // title / year / genre / none
            string activeRadio = getActiveRadioBtn();

            //get text box data 
            //ensure not empty

            String userSearch = TextBoxMediaLibarySearchField.Text;
            if(userSearch.Length <= 0)
            {
                MessageBox.Show("Please input your seach by text / num in the text box.");
            }
            else
            {
                switch (activeRadio)
                {
                    case "none":
                        MessageBox.Show("Please select an active Category Radio Button");
                        break;

                    case "title":
                        // TODO: MainMenu - DGV media by title 
                        //DataGridViewMediaLibary.DataSource = mediaLogic.getMediaByTitle(userSearch);
                        break;

                    case "year":
                        int year = 0;
                        bool result = int.TryParse(userSearch, out year);
                        if (result)
                        {
                            // TODO: MainMenu - DGV getMediaByYear
                            //DataGridViewMediaLibary.DataSource = mediaLogic.getMediaByYear(year);
                        }
                        else
                        {
                            MessageBox.Show("Could not convert your year to a number try again.");
                        }
                        break;

                    case "genre":
                        // TODO: MainMenu - DGV getMediaByGenre 
                        //DataGridViewMediaLibary.DataSource = mediaLogic.getMediaByGenre(userSearch);
                        break;

                    default:
                        MessageBox.Show("Somthing went wrong try again -- Switch Default");
                        break;
                }
            }

            

        }


        private void BtnResetMediaLibary_Click(object sender, EventArgs e)
        {
            //DataGridViewMediaLibary.DataSource = mediaLogic.getAllMedia();
        }





        private void BtnStudentSettings_Click(object sender, EventArgs e)
        {

            //check if i am a student or not using admin
            //if student pass my data to next screen 

            if (isAdmin)
            {
                //index 0 == true=1 / false=0        (binary - true / false)
                //index 1 == studentNum             (string converted to int)
 
                int[] result = getStudentById();

                if(result[0] == 1) 
                {
                    // TODO: MainMenu - getStudentById
                    //User studentUser = userLogic.getUserById(result[1]);
                    //if (studentUser.Id != -1) 
                    //{
                    //    //set retrieved data
                    //    StudentSettings.isAdmin = isAdmin;
                    //    StudentSettings.user = studentUser;

                    //    //move between forms
                    //    StudentSettings ss = new StudentSettings();
                    //    ss.Show();
                    //    this.Hide();
                    //}
                    //else
                    //{
                    //    MessageBox.Show("error retrieving user from db");
                    //}
                }

            }
            else
            {
                //set data 
                StudentSettings.isAdmin = isAdmin;
                StudentSettings.user = currentUser;

                //move between forms
                StudentSettings ss = new StudentSettings();
                ss.Show();
                this.Hide();
            }

        }



        private void BtnStudentRecords_Click(object sender, EventArgs e)
        {
            //check if i am a student or not using admin
            //if student pass my data to next screen 

            if (isAdmin)
            {
                //index 0 == true=1 / false=0        (binary - true / false)
                //index 1 == studentNum             (string converted to int)

                int[] result = getStudentById();

                if (result[0] == 1)
                {
                    // TODO: MainMenu - getUserId - 2
                    //User studentUser = userLogic.getUserById(result[1]);
                    //if (studentUser.Id != -1)
                    //{
                    //    //set retrieved data
                    //    StudentRecord.isAdmin = isAdmin;
                    //    StudentRecord.user = studentUser;

                    //    //move between forms
                    //    StudentRecord sr = new StudentRecord();
                    //    sr.Show();
                    //    this.Hide();
                    //}
                    //else
                    //{
                    //    MessageBox.Show("error retrieving user from db");
                    //}
                }

            }
            else
            {
                //set data 
                StudentRecord.isAdmin = isAdmin;
                StudentRecord.user = currentUser;

                //move between forms
                StudentRecord sr = new StudentRecord();
                sr.Show();
                this.Hide();
            }
        }



        private void BtnStudentActivity_Click(object sender, EventArgs e)
        {
            //check if i am a student or not using admin
            //if student pass my data to next screen 

            if (isAdmin)
            {
                //index 0 == true=1 / false=0        (binary - true / false)
                //index 1 == studentNum             (string converted to int)

                int[] result = getStudentById();

                if (result[0] == 1)
                {
                    // TODO: MainMenu - getUserID - 3
                    //User studentUser = userLogic.getUserById(result[1]);
                    //if (studentUser.Id != -1)
                    //{
                    //    //set retrieved data
                    //    StudentActivity.isAdmin = isAdmin;
                    //    StudentActivity.user = studentUser;

                    //    //move between forms
                    //    StudentActivity sa = new StudentActivity();
                    //    sa.Show();
                    //    this.Hide();
                    //}
                    //else
                    //{
                    //    MessageBox.Show("error retrieving user from db");
                    //}
                }

            }
            else
            {
                //set data 
                StudentActivity.isAdmin = isAdmin;
                StudentActivity.user = currentUser;

                //move between forms
                StudentActivity sa = new StudentActivity();
                sa.Show();
                this.Hide();
            }
        }



        //media menu student
        private void BtnCheckOut_Click(object sender, EventArgs e)
        {
            //get active student or admin defined student
            if (isAdmin)
            {
                string idStr = TextBoxAdminStudentNumber.Text;
                bool parseResult = int.TryParse(idStr, out int stuId);
                if (parseResult)
                {
                    checkOutMediaToUser(stuId);
                }
                else
                {
                    MessageBox.Show("could not convert student id to string");
                    return;
                }

            }
            else
            {
                string idStr = LabelStudentId.Text;
                bool parseResult = int.TryParse(idStr, out int stuId);
                if (parseResult)
                {
                    checkOutMediaToUser(stuId);
                }
                else
                {
                    MessageBox.Show("could not convert student id to string");
                    return;
                }
            }

        }

      
        private void checkOutMediaToUser( int userId)
        {
            //check if user exists

            // TODO: MainMenu -  if user exists 
            //User curUser = userLogic.getUserById(userId); //sets user id to -1 if error
            //if (curUser.Id == -1)
            //{
            //    //ERROR couldent get user by their id
            //    MessageBox.Show("unable to find current user in list");
            //    return;
            //}


            //get selected media data
            string mIdAsStr = activeMediaViewRow.Cells[0].Value.ToString();

            //checker bool
            bool result = false;

            //if mediaId parse worked correctly
            result = int.TryParse(mIdAsStr, out int mediaId);  //try parse idAsStr to int id
            if (result)
            {
                // TODO: MainMenu - borrow logic
                //result = borrowLogic.getIsMediaAvailable(mediaId);
                ////if media is already checked out
                //if (result)
                //{
                //    result = borrowLogic.insertForCheckOutMedia(userId, mediaId);
                //    //if checkOut went smoothly
                //    if (result)
                //    {
                //        MessageBox.Show("successfully checked out media.");
                //    }
                //    else
                //    {
                //        MessageBox.Show("error checking out media.");
                //    }
                //}
                //else
                //{
                //    MessageBox.Show("Media Item is not currently available");
                //}
            }
            else
            {
                MessageBox.Show("checkOut Error: could not parse mediaIdStr to mediaIdInt ");
            }



        }



        private void BtnReserve_Click(object sender, EventArgs e)
        {
            //get active student or admin defined student
            if (isAdmin)
            {
                string idStr = TextBoxAdminStudentNumber.Text;
                bool parseResult = int.TryParse(idStr, out int stuId);
                if (parseResult)
                {
                    reserveMediaToUser(stuId);
                }
                else
                {
                    MessageBox.Show("could not convert student id to string");
                    return;
                }

            }
            else
            {
                string idStr = LabelStudentId.Text;
                bool parseResult = int.TryParse(idStr, out int stuId);
                if (parseResult)
                {
                    reserveMediaToUser(stuId);
                }
                else
                {
                    MessageBox.Show("could not convert student id to string");
                    return;
                }
            }
        }


        private void reserveMediaToUser(int userId)
        {
            //check if user exists
            // TODO: MainMenu - ReserveMediaToUser current user
            //User curUser = userLogic.getUserById(userId); //sets user id to -1 if error
            //if (curUser.Id == -1)
            //{
            //    //ERROR couldent get user by their id
            //    MessageBox.Show("unable to find current user in list");
            //    return;
            //}


            //checker bool
            bool result = false;

            if(activeMediaViewRow == null)
            {
                MessageBox.Show("Please select the selector row on the left of the data view");
                return;
            }
            
            //get selected media data
            string mIdAsStr = activeMediaViewRow.Cells[0].Value.ToString();
            //if mediaId parse worked correctly
            result = int.TryParse(mIdAsStr, out int mediaId);  //try parse idAsStr to int id
            if (!result)
            {
                MessageBox.Show("checkOut Error: could not parse mediaIdStr to mediaIdInt ");
                return;
            }


            //get selected dateMonthDayString
            string dateMonthDayYear = TextBoxReserveDate.Text;


            //check to see if reservation is available 
            //result = borrowLogic.getIsMediaAvailable(mediaId);
            result = true;  //TODO    @@@@@@@ Media always available @@@@@@@@@

            //if media is already reserved
            if (result)
            {
                // TODO: MainMenu -  reserve logic
                //result = reservedLogic.insertNewReservation(userId, mediaId, dateMonthDayYear); //monthDayYear format == "04-20-2020" == mm-dd-yyyy
                ////if checkOut went smoothly
                //if (result)
                //{
                //    MessageBox.Show("successfully reserved media.");
                //}
                //else
                //{
                //    MessageBox.Show("error creating reservation.");
                //}
            }
            else
            {
                MessageBox.Show("Reserve Item is not currently available");
                
            }
            
            
        }



        //media menu admin
        private void BtnAddMedia_Click(object sender, EventArgs e)
        {

        }

        private void BtnDeleteMedia_Click(object sender, EventArgs e)
        {

        }

        private void BtnEditMedia_Click(object sender, EventArgs e)
        {
            //move between forms
            EditMediaLibary eml = new EditMediaLibary();
            eml.Show();
            this.Hide();
        }




        private void BtnBack_Click(object sender, EventArgs e)
        {
            returnToLogin();
        }





        // functions ---


        private void returnToLogin()
        {

            //create login instance
            Login loginScreen = new Login();
            //show login page
            loginScreen.Show();
            //close this page
            this.Close();

        }


        private int[] getStudentById()
        {
            // 0 == false 
            // 1 == true
            int result = 1;    // bool to catch errors along the way 
            string studentNumStr = "undefined";   // init student number
            

            //get data (studentNum / ID)
            //get from admin student data text box 
            //ensure text box is not empty first
            if (TextBoxAdminStudentNumber.Text.Length != 0)
            {
                //ensure string can be converted to int 
                studentNumStr = TextBoxAdminStudentNumber.Text;
                bool parseResult = int.TryParse(studentNumStr, out int studentNum);
                if (parseResult == true)
                {
                    int[] tempArray2 = { result, studentNum};
                    return tempArray2;

                }
                else
                {
                    result = 0; //false
                }

            }
            else
            {

                MessageBox.Show("please insert student username");
                result = 0; // false

            }

            int[] tempArray = { result };
            return tempArray;

        }


        private string getActiveRadioBtn()
        {
            string activeRadio = "none";

            // go through buttons and find one that is checked (should only be ONE)
            if (RadioBtnTitle.Checked)
            {
                activeRadio = "title";
            }
            else if(RadioBtnYear.Checked)
            {
                activeRadio = "year";
            }
            else if (RadioBtnGenre.Checked)
            {
                activeRadio = "genre";
            }
            

            return activeRadio;
        }

        private void BtnAdminAddUser_Click(object sender, EventArgs e)
        {
            //set data 
            SignUp.currentUser = currentUser;

            //move between forms
            SignUp su = new SignUp();
            su.Show();
            this.Hide();
        }



        //DGV ViewMedia
        private void DataGridViewMediaLibary_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // cells / columns by index
                // 0 == mediaID
                // 1 == title
                // 2 == genreName
                // 3 == directorName
                // 4 == language name
                // 5 == publish year
                // 6 == budget
                // 7 == genreId
                // 8 == directorId
                // 9 == languageId


                //get row by its self
                DataGridViewRow row = DataGridViewMediaLibary.Rows[e.RowIndex];

                //set mediaRow as active 
                activeMediaViewRow = row;

            }
        }
    }
}
