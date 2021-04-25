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
    public partial class StudentActivity : Form
    {

        
        public static bool isAdmin;
        public static User user;
        private WebService.WebService ws;
        private DTFunc dtFunc;
        private DataGridViewRow activeReservationsViewRow = null;
        private DataGridViewRow activeBookingsViewRow = null;
        private DataGridViewRow activeFeesViewRow = null;

        public StudentActivity()
        {
            InitializeComponent();

            LabelUsername.Text = user.Username;
            LabelUserId.Text = user.Id.ToString();


            // hide admin panel / content
            if (!isAdmin)
            {
                
            }

            // init connection
            ws = new WebService.WebService();
            dtFunc = new DTFunc();

            // get data for DGV's
            setDataForDataGridViews();


        }


        private void setDataForDataGridViews()
        {
            
            //DataGridViewActiveBookings.DataSource = borrowLogic.getByUserForUserActivity(user.Id);
            //DataGridViewFees.DataSource = borrowLogic.getByUserForActiveLateFees(user.Id);
            //DataGridViewActiveReservations.DataSource = reservedLogic.getReservedActive(user.Id);

            DataGridViewActiveBookings.DataSource = ws.GetByUserForUserActivity(user.Id);
            DataGridViewFees.DataSource = ws.GetByUserForActiveLateFees(user.Id);
            DataGridViewActiveReservations.DataSource = ws.getReservedActive(user.Id);
        }


        private void BtnBack_Click(object sender, EventArgs e)
        {
            //for more details go to STUDENT SETTINGS return btn method
            Form mainform = Application.OpenForms["MainMenu"];
            mainform.Show();
            this.Close();
        }





        //btns

        private void BtnReturnMedia_Click(object sender, EventArgs e)
        {
            
            if (activeBookingsViewRow == null)
            {
                MessageBox.Show("please select row correctly using selector column on the left.");
            }
            else
            {
                //BID == 0
                string myStrBorrowId = activeBookingsViewRow.Cells[0].Value.ToString(); //initialy it is saved as an object
                bool parseResult = int.TryParse(myStrBorrowId, out int borrowId);

                // set late fee 
                // currently hardcoded $10
                int lateFee = 10;

                if (parseResult)
                {
                    
                    //if (borrowLogic.updateMediaForReturn(borrowId, lateFee))

                    bool result = dtFunc.getBool(ws.updateMediaForReturn(borrowId, lateFee));
                    if(result)
                    {
                        MessageBox.Show("successfull media returned.");

                        //resfresh DGV
                        setDataForDataGridViews();
                        activeBookingsViewRow = null;  //reset active row value
                    }
                    else
                    {
                        MessageBox.Show("error media not returned on update.");
                    }
                }
                else
                {
                    MessageBox.Show("could not convert str of borrowId to int for media Return.");
                    return;
                }
            }

            
        }

        private void BtnCancelReservedMedia_Click(object sender, EventArgs e)
        {

            if (activeReservationsViewRow == null)
            {
                MessageBox.Show("please select row correctly using selector column on the left.");
            }
            else
            {
                //RID == 0
                string myStrReserveId = activeReservationsViewRow.Cells[0].Value.ToString(); //initialy it is saved as an object
                bool parseResult = int.TryParse(myStrReserveId, out int reserveId);

                if (parseResult)
                {
                    

                    //if(reservedLogic.deleteReservation(reserveId))
                    bool result = dtFunc.getBool(ws.deleteReservation(reserveId));
                    if (result)
                    {
                        MessageBox.Show("successfull reservation removed.");

                        //resfresh DGV
                        setDataForDataGridViews();
                        activeReservationsViewRow = null;  //reset active row value
                    }
                    else
                    {
                        MessageBox.Show("error reservation did not delete.");
                    }
                }
                else
                {
                    MessageBox.Show("could not convert str of reserveId to int for cancel reservation.");
                    return;
                }
            }
        }

        private void BtnPayFees_Click(object sender, EventArgs e)
        {

            if (activeFeesViewRow == null)
            {
                MessageBox.Show("please select row correctly using selector column on the left.");
            }
            else
            {
                //BID == 0
                string myStrBorrowId = activeFeesViewRow.Cells[0].Value.ToString(); //initialy it is saved as an object
                bool parseResult = int.TryParse(myStrBorrowId, out int borrowId);

                if (parseResult)
                {
                    
                    //if(borrowLogic.updateMediaPayLateFee(borrowId))
                    bool result = dtFunc.getBool(ws.updateMediaPayLateFee(borrowId));
                    if (result)
                    {
                        MessageBox.Show("successfull media late fee payment.");

                        //resfresh DGV
                        setDataForDataGridViews();
                        activeFeesViewRow = null; //reset active row value
                    }
                    else
                    {
                        MessageBox.Show("error late fee not paid.");
                    }
                }
                else
                {
                    MessageBox.Show("could not convert str of borrowId to int for LateFee Payment.");
                    return;
                }
            }
        }





        //DGV cell clicks --------
        private void DataGridViewFees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // cells / columns by index (borrowTable)
                // 0 == BID
                // 1 == UID
                // 2 == MediaId
                // 3 == borrowDate
                // 4 == returnDate
                // 5 == acturalReturnDate
                // 6 == LateFee



                //get row by its self
                DataGridViewRow row = DataGridViewFees.Rows[e.RowIndex];

                //set mediaRow as active 
                activeFeesViewRow = row;

            }
        }

        private void DataGridViewActiveReservations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // cells / columns by index (reseredTable)
                // 0 == RID
                // 1 == UID
                // 2 == MediaID
                


                //get row by its self
                DataGridViewRow row = DataGridViewActiveReservations.Rows[e.RowIndex];

                //set mediaRow as active 
                activeReservationsViewRow = row;

            }
        }

        private void DataGridViewActiveBookings_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // cells / columns by index (borrowTable)
                // 0 == BID
                // 1 == UID
                // 2 == MediaId
                // 3 == borrowDate
                // 4 == returnDate
                // 5 == acturalReturnDate
                // 6 == LateFee


                //get row by its self
                DataGridViewRow row = DataGridViewActiveBookings.Rows[e.RowIndex];

                //set mediaRow as active 
                activeBookingsViewRow = row;

            }
        }
    }
}
