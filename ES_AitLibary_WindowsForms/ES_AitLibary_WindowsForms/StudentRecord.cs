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
    public partial class StudentRecord : Form
    {

        public static bool isAdmin;
        public static User user;
        private WebService.WebService ws;
        private DTFunc dtFunc;


        public StudentRecord()
        {
            InitializeComponent();


            LabelUsername.Text = user.Username;
            LabelUserId.Text = user.Id.ToString();


            // hide admin panel / content
            if (!isAdmin)
            {

            }


            
            //inits
            ws = new WebService.WebService();
            dtFunc = new DTFunc();

            //DataGridViewMediaLibary.DataSource = userLogic.getAllUsers();
            //DataGridViewBookingHistory.DataSource = borrowLogic.getByUserForUserHistory(user.Id);
            //DataGridViewReservedHistory.DataSource = reservedLogic.getReservedHistory(user.Id);

            //DataGridViewMediaLibary.DataSource = ws.GetAllUsers();
            DataGridViewBookingHistory.DataSource = ws.GetByUserForUserHistory(user.Id);
            DataGridViewReservedHistory.DataSource = ws.getReservedHistory(user.Id);


        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            //for more details go to STUDENT SETTINGS return btn method
            Form mainform = Application.OpenForms["MainMenu"];
            mainform.Show();
            this.Close();
        }






    }
}
