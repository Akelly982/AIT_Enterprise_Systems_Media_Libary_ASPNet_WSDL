
namespace ES_AitLibary_WindowsForms
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelNav = new System.Windows.Forms.Panel();
            this.LabelAdminUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnBack = new System.Windows.Forms.Button();
            this.panelStudentDataRow = new System.Windows.Forms.Panel();
            this.PanelStudentBtnsHolder = new System.Windows.Forms.Panel();
            this.PanelStudentBtns = new System.Windows.Forms.Panel();
            this.BtnStudentActivity = new System.Windows.Forms.Button();
            this.BtnStudentRecords = new System.Windows.Forms.Button();
            this.BtnStudentSettings = new System.Windows.Forms.Button();
            this.PanelStudentRowShowAdminContent = new System.Windows.Forms.Panel();
            this.BtnAdminAddUser = new System.Windows.Forms.Button();
            this.TextBoxAdminStudentNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PanelStudentRowShowStudentContent = new System.Windows.Forms.Panel();
            this.LabelStudentId = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LabelStudentUsername = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PanelMediaLibary = new System.Windows.Forms.Panel();
            this.DataGridViewMediaLibary = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBoxReserveDate = new System.Windows.Forms.TextBox();
            this.BtnReserve = new System.Windows.Forms.Button();
            this.BtnCheckOut = new System.Windows.Forms.Button();
            this.PanelMediaLibaryAdminBtns = new System.Windows.Forms.Panel();
            this.BtnEditMedia = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnResetMediaLibary = new System.Windows.Forms.Button();
            this.BtnMediaLibarySearch = new System.Windows.Forms.Button();
            this.TextBoxMediaLibarySearchField = new System.Windows.Forms.TextBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.RadioBtnGenre = new System.Windows.Forms.RadioButton();
            this.RadioBtnYear = new System.Windows.Forms.RadioButton();
            this.RadioBtnTitle = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.PanelSpacer1 = new System.Windows.Forms.Panel();
            this.panelNav.SuspendLayout();
            this.panelStudentDataRow.SuspendLayout();
            this.PanelStudentBtnsHolder.SuspendLayout();
            this.PanelStudentBtns.SuspendLayout();
            this.PanelStudentRowShowAdminContent.SuspendLayout();
            this.PanelStudentRowShowStudentContent.SuspendLayout();
            this.PanelMediaLibary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewMediaLibary)).BeginInit();
            this.panel2.SuspendLayout();
            this.PanelMediaLibaryAdminBtns.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNav
            // 
            this.panelNav.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelNav.Controls.Add(this.LabelAdminUsername);
            this.panelNav.Controls.Add(this.label1);
            this.panelNav.Controls.Add(this.BtnBack);
            this.panelNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNav.Location = new System.Drawing.Point(0, 0);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(1934, 164);
            this.panelNav.TabIndex = 0;
            // 
            // LabelAdminUsername
            // 
            this.LabelAdminUsername.AutoSize = true;
            this.LabelAdminUsername.Location = new System.Drawing.Point(1352, 80);
            this.LabelAdminUsername.Name = "LabelAdminUsername";
            this.LabelAdminUsername.Size = new System.Drawing.Size(171, 25);
            this.LabelAdminUsername.TabIndex = 2;
            this.LabelAdminUsername.Text = "undefined admin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(697, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Main Menu";
            // 
            // BtnBack
            // 
            this.BtnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.Location = new System.Drawing.Point(35, 31);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(188, 104);
            this.BtnBack.TabIndex = 0;
            this.BtnBack.Text = "<";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // panelStudentDataRow
            // 
            this.panelStudentDataRow.Controls.Add(this.PanelStudentBtnsHolder);
            this.panelStudentDataRow.Controls.Add(this.PanelStudentRowShowAdminContent);
            this.panelStudentDataRow.Controls.Add(this.PanelStudentRowShowStudentContent);
            this.panelStudentDataRow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStudentDataRow.Location = new System.Drawing.Point(0, 164);
            this.panelStudentDataRow.Name = "panelStudentDataRow";
            this.panelStudentDataRow.Size = new System.Drawing.Size(1934, 283);
            this.panelStudentDataRow.TabIndex = 1;
            // 
            // PanelStudentBtnsHolder
            // 
            this.PanelStudentBtnsHolder.Controls.Add(this.PanelStudentBtns);
            this.PanelStudentBtnsHolder.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelStudentBtnsHolder.Location = new System.Drawing.Point(1211, 0);
            this.PanelStudentBtnsHolder.Name = "PanelStudentBtnsHolder";
            this.PanelStudentBtnsHolder.Size = new System.Drawing.Size(873, 283);
            this.PanelStudentBtnsHolder.TabIndex = 2;
            // 
            // PanelStudentBtns
            // 
            this.PanelStudentBtns.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PanelStudentBtns.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PanelStudentBtns.Controls.Add(this.BtnStudentActivity);
            this.PanelStudentBtns.Controls.Add(this.BtnStudentRecords);
            this.PanelStudentBtns.Controls.Add(this.BtnStudentSettings);
            this.PanelStudentBtns.Location = new System.Drawing.Point(54, 37);
            this.PanelStudentBtns.Name = "PanelStudentBtns";
            this.PanelStudentBtns.Size = new System.Drawing.Size(769, 213);
            this.PanelStudentBtns.TabIndex = 0;
            // 
            // BtnStudentActivity
            // 
            this.BtnStudentActivity.Location = new System.Drawing.Point(539, 31);
            this.BtnStudentActivity.Name = "BtnStudentActivity";
            this.BtnStudentActivity.Size = new System.Drawing.Size(182, 153);
            this.BtnStudentActivity.TabIndex = 2;
            this.BtnStudentActivity.Text = "Activity";
            this.BtnStudentActivity.UseVisualStyleBackColor = true;
            this.BtnStudentActivity.Click += new System.EventHandler(this.BtnStudentActivity_Click);
            // 
            // BtnStudentRecords
            // 
            this.BtnStudentRecords.Location = new System.Drawing.Point(293, 30);
            this.BtnStudentRecords.Name = "BtnStudentRecords";
            this.BtnStudentRecords.Size = new System.Drawing.Size(182, 153);
            this.BtnStudentRecords.TabIndex = 1;
            this.BtnStudentRecords.Text = "Records";
            this.BtnStudentRecords.UseVisualStyleBackColor = true;
            this.BtnStudentRecords.Click += new System.EventHandler(this.BtnStudentRecords_Click);
            // 
            // BtnStudentSettings
            // 
            this.BtnStudentSettings.Location = new System.Drawing.Point(42, 31);
            this.BtnStudentSettings.Name = "BtnStudentSettings";
            this.BtnStudentSettings.Size = new System.Drawing.Size(182, 153);
            this.BtnStudentSettings.TabIndex = 0;
            this.BtnStudentSettings.Text = "Settings";
            this.BtnStudentSettings.UseVisualStyleBackColor = true;
            this.BtnStudentSettings.Click += new System.EventHandler(this.BtnStudentSettings_Click);
            // 
            // PanelStudentRowShowAdminContent
            // 
            this.PanelStudentRowShowAdminContent.Controls.Add(this.BtnAdminAddUser);
            this.PanelStudentRowShowAdminContent.Controls.Add(this.TextBoxAdminStudentNumber);
            this.PanelStudentRowShowAdminContent.Controls.Add(this.label4);
            this.PanelStudentRowShowAdminContent.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelStudentRowShowAdminContent.Location = new System.Drawing.Point(584, 0);
            this.PanelStudentRowShowAdminContent.Name = "PanelStudentRowShowAdminContent";
            this.PanelStudentRowShowAdminContent.Size = new System.Drawing.Size(627, 283);
            this.PanelStudentRowShowAdminContent.TabIndex = 1;
            // 
            // BtnAdminAddUser
            // 
            this.BtnAdminAddUser.Location = new System.Drawing.Point(32, 78);
            this.BtnAdminAddUser.Name = "BtnAdminAddUser";
            this.BtnAdminAddUser.Size = new System.Drawing.Size(118, 131);
            this.BtnAdminAddUser.TabIndex = 4;
            this.BtnAdminAddUser.Text = "New User";
            this.BtnAdminAddUser.UseVisualStyleBackColor = true;
            this.BtnAdminAddUser.Click += new System.EventHandler(this.BtnAdminAddUser_Click);
            // 
            // TextBoxAdminStudentNumber
            // 
            this.TextBoxAdminStudentNumber.Location = new System.Drawing.Point(318, 132);
            this.TextBoxAdminStudentNumber.Name = "TextBoxAdminStudentNumber";
            this.TextBoxAdminStudentNumber.Size = new System.Drawing.Size(252, 31);
            this.TextBoxAdminStudentNumber.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Student Id:";
            // 
            // PanelStudentRowShowStudentContent
            // 
            this.PanelStudentRowShowStudentContent.Controls.Add(this.LabelStudentId);
            this.PanelStudentRowShowStudentContent.Controls.Add(this.label5);
            this.PanelStudentRowShowStudentContent.Controls.Add(this.LabelStudentUsername);
            this.PanelStudentRowShowStudentContent.Controls.Add(this.label3);
            this.PanelStudentRowShowStudentContent.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelStudentRowShowStudentContent.Location = new System.Drawing.Point(0, 0);
            this.PanelStudentRowShowStudentContent.Name = "PanelStudentRowShowStudentContent";
            this.PanelStudentRowShowStudentContent.Size = new System.Drawing.Size(584, 283);
            this.PanelStudentRowShowStudentContent.TabIndex = 0;
            // 
            // LabelStudentId
            // 
            this.LabelStudentId.AutoSize = true;
            this.LabelStudentId.Location = new System.Drawing.Point(345, 108);
            this.LabelStudentId.Name = "LabelStudentId";
            this.LabelStudentId.Size = new System.Drawing.Size(56, 25);
            this.LabelStudentId.TabIndex = 3;
            this.LabelStudentId.Text = "xxxx";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Student Id:";
            // 
            // LabelStudentUsername
            // 
            this.LabelStudentUsername.AutoSize = true;
            this.LabelStudentUsername.Location = new System.Drawing.Point(345, 150);
            this.LabelStudentUsername.Name = "LabelStudentUsername";
            this.LabelStudentUsername.Size = new System.Drawing.Size(184, 25);
            this.LabelStudentUsername.TabIndex = 1;
            this.LabelStudentUsername.Text = "undefined student";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Student Username:";
            // 
            // PanelMediaLibary
            // 
            this.PanelMediaLibary.Controls.Add(this.DataGridViewMediaLibary);
            this.PanelMediaLibary.Controls.Add(this.panel2);
            this.PanelMediaLibary.Controls.Add(this.PanelMediaLibaryAdminBtns);
            this.PanelMediaLibary.Controls.Add(this.panel1);
            this.PanelMediaLibary.Controls.Add(this.label2);
            this.PanelMediaLibary.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelMediaLibary.Location = new System.Drawing.Point(0, 447);
            this.PanelMediaLibary.Name = "PanelMediaLibary";
            this.PanelMediaLibary.Size = new System.Drawing.Size(1934, 1442);
            this.PanelMediaLibary.TabIndex = 3;
            // 
            // DataGridViewMediaLibary
            // 
            this.DataGridViewMediaLibary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewMediaLibary.Location = new System.Drawing.Point(502, 149);
            this.DataGridViewMediaLibary.MaximumSize = new System.Drawing.Size(1050, 1211);
            this.DataGridViewMediaLibary.Name = "DataGridViewMediaLibary";
            this.DataGridViewMediaLibary.RowHeadersWidth = 20;
            this.DataGridViewMediaLibary.RowTemplate.Height = 20;
            this.DataGridViewMediaLibary.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewMediaLibary.Size = new System.Drawing.Size(1050, 1211);
            this.DataGridViewMediaLibary.TabIndex = 5;
            this.DataGridViewMediaLibary.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewMediaLibary_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.TextBoxReserveDate);
            this.panel2.Controls.Add(this.BtnReserve);
            this.panel2.Controls.Add(this.BtnCheckOut);
            this.panel2.Location = new System.Drawing.Point(48, 769);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(420, 317);
            this.panel2.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Reserve date:";
            // 
            // TextBoxReserveDate
            // 
            this.TextBoxReserveDate.Location = new System.Drawing.Point(181, 62);
            this.TextBoxReserveDate.Name = "TextBoxReserveDate";
            this.TextBoxReserveDate.Size = new System.Drawing.Size(199, 31);
            this.TextBoxReserveDate.TabIndex = 4;
            this.TextBoxReserveDate.Text = "02-20-1994";
            // 
            // BtnReserve
            // 
            this.BtnReserve.Location = new System.Drawing.Point(225, 132);
            this.BtnReserve.Name = "BtnReserve";
            this.BtnReserve.Size = new System.Drawing.Size(155, 126);
            this.BtnReserve.TabIndex = 2;
            this.BtnReserve.Text = "Reserve";
            this.BtnReserve.UseVisualStyleBackColor = true;
            this.BtnReserve.Click += new System.EventHandler(this.BtnReserve_Click);
            // 
            // BtnCheckOut
            // 
            this.BtnCheckOut.Location = new System.Drawing.Point(31, 132);
            this.BtnCheckOut.Name = "BtnCheckOut";
            this.BtnCheckOut.Size = new System.Drawing.Size(157, 126);
            this.BtnCheckOut.TabIndex = 1;
            this.BtnCheckOut.Text = "Check out";
            this.BtnCheckOut.UseVisualStyleBackColor = true;
            this.BtnCheckOut.Click += new System.EventHandler(this.BtnCheckOut_Click);
            // 
            // PanelMediaLibaryAdminBtns
            // 
            this.PanelMediaLibaryAdminBtns.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PanelMediaLibaryAdminBtns.Controls.Add(this.BtnEditMedia);
            this.PanelMediaLibaryAdminBtns.Location = new System.Drawing.Point(48, 1102);
            this.PanelMediaLibaryAdminBtns.Name = "PanelMediaLibaryAdminBtns";
            this.PanelMediaLibaryAdminBtns.Size = new System.Drawing.Size(420, 258);
            this.PanelMediaLibaryAdminBtns.TabIndex = 0;
            // 
            // BtnEditMedia
            // 
            this.BtnEditMedia.Location = new System.Drawing.Point(31, 113);
            this.BtnEditMedia.Name = "BtnEditMedia";
            this.BtnEditMedia.Size = new System.Drawing.Size(349, 115);
            this.BtnEditMedia.TabIndex = 5;
            this.BtnEditMedia.Text = "Edit Media";
            this.BtnEditMedia.UseVisualStyleBackColor = true;
            this.BtnEditMedia.Click += new System.EventHandler(this.BtnEditMedia_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.BtnResetMediaLibary);
            this.panel1.Controls.Add(this.BtnMediaLibarySearch);
            this.panel1.Controls.Add(this.TextBoxMediaLibarySearchField);
            this.panel1.Controls.Add(this.radioButton4);
            this.panel1.Controls.Add(this.RadioBtnGenre);
            this.panel1.Controls.Add(this.RadioBtnYear);
            this.panel1.Controls.Add(this.RadioBtnTitle);
            this.panel1.Location = new System.Drawing.Point(48, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 600);
            this.panel1.TabIndex = 3;
            // 
            // BtnResetMediaLibary
            // 
            this.BtnResetMediaLibary.Location = new System.Drawing.Point(106, 516);
            this.BtnResetMediaLibary.Name = "BtnResetMediaLibary";
            this.BtnResetMediaLibary.Size = new System.Drawing.Size(173, 66);
            this.BtnResetMediaLibary.TabIndex = 6;
            this.BtnResetMediaLibary.Text = "Reset";
            this.BtnResetMediaLibary.UseVisualStyleBackColor = true;
            this.BtnResetMediaLibary.Click += new System.EventHandler(this.BtnResetMediaLibary_Click);
            // 
            // BtnMediaLibarySearch
            // 
            this.BtnMediaLibarySearch.Location = new System.Drawing.Point(106, 427);
            this.BtnMediaLibarySearch.Name = "BtnMediaLibarySearch";
            this.BtnMediaLibarySearch.Size = new System.Drawing.Size(173, 66);
            this.BtnMediaLibarySearch.TabIndex = 5;
            this.BtnMediaLibarySearch.Text = "Search";
            this.BtnMediaLibarySearch.UseVisualStyleBackColor = true;
            this.BtnMediaLibarySearch.Click += new System.EventHandler(this.BtnMediaLibarySearch_Click);
            // 
            // TextBoxMediaLibarySearchField
            // 
            this.TextBoxMediaLibarySearchField.Location = new System.Drawing.Point(41, 351);
            this.TextBoxMediaLibarySearchField.Multiline = true;
            this.TextBoxMediaLibarySearchField.Name = "TextBoxMediaLibarySearchField";
            this.TextBoxMediaLibarySearchField.Size = new System.Drawing.Size(312, 58);
            this.TextBoxMediaLibarySearchField.TabIndex = 4;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(114, 274);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(165, 29);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // RadioBtnGenre
            // 
            this.RadioBtnGenre.AutoSize = true;
            this.RadioBtnGenre.Location = new System.Drawing.Point(114, 200);
            this.RadioBtnGenre.Name = "RadioBtnGenre";
            this.RadioBtnGenre.Size = new System.Drawing.Size(102, 29);
            this.RadioBtnGenre.TabIndex = 2;
            this.RadioBtnGenre.TabStop = true;
            this.RadioBtnGenre.Text = "Genre";
            this.RadioBtnGenre.UseVisualStyleBackColor = true;
            // 
            // RadioBtnYear
            // 
            this.RadioBtnYear.AutoSize = true;
            this.RadioBtnYear.Location = new System.Drawing.Point(114, 122);
            this.RadioBtnYear.Name = "RadioBtnYear";
            this.RadioBtnYear.Size = new System.Drawing.Size(89, 29);
            this.RadioBtnYear.TabIndex = 1;
            this.RadioBtnYear.TabStop = true;
            this.RadioBtnYear.Text = "Year";
            this.RadioBtnYear.UseVisualStyleBackColor = true;
            // 
            // RadioBtnTitle
            // 
            this.RadioBtnTitle.AutoSize = true;
            this.RadioBtnTitle.Location = new System.Drawing.Point(114, 50);
            this.RadioBtnTitle.Name = "RadioBtnTitle";
            this.RadioBtnTitle.Size = new System.Drawing.Size(84, 29);
            this.RadioBtnTitle.TabIndex = 0;
            this.RadioBtnTitle.TabStop = true;
            this.RadioBtnTitle.Text = "Title";
            this.RadioBtnTitle.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(689, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Media Libary";
            // 
            // PanelSpacer1
            // 
            this.PanelSpacer1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PanelSpacer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSpacer1.Location = new System.Drawing.Point(0, 1889);
            this.PanelSpacer1.Name = "PanelSpacer1";
            this.PanelSpacer1.Size = new System.Drawing.Size(1934, 150);
            this.PanelSpacer1.TabIndex = 4;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1968, 1931);
            this.Controls.Add(this.PanelSpacer1);
            this.Controls.Add(this.PanelMediaLibary);
            this.Controls.Add(this.panelStudentDataRow);
            this.Controls.Add(this.panelNav);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.panelNav.ResumeLayout(false);
            this.panelNav.PerformLayout();
            this.panelStudentDataRow.ResumeLayout(false);
            this.PanelStudentBtnsHolder.ResumeLayout(false);
            this.PanelStudentBtns.ResumeLayout(false);
            this.PanelStudentRowShowAdminContent.ResumeLayout(false);
            this.PanelStudentRowShowAdminContent.PerformLayout();
            this.PanelStudentRowShowStudentContent.ResumeLayout(false);
            this.PanelStudentRowShowStudentContent.PerformLayout();
            this.PanelMediaLibary.ResumeLayout(false);
            this.PanelMediaLibary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewMediaLibary)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.PanelMediaLibaryAdminBtns.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Panel panelStudentDataRow;
        private System.Windows.Forms.Panel PanelStudentRowShowAdminContent;
        private System.Windows.Forms.TextBox TextBoxAdminStudentNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel PanelStudentRowShowStudentContent;
        private System.Windows.Forms.Label LabelStudentUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel PanelStudentBtnsHolder;
        private System.Windows.Forms.Panel PanelStudentBtns;
        private System.Windows.Forms.Button BtnStudentActivity;
        private System.Windows.Forms.Button BtnStudentRecords;
        private System.Windows.Forms.Button BtnStudentSettings;
        private System.Windows.Forms.Panel PanelMediaLibary;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel PanelMediaLibaryAdminBtns;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnMediaLibarySearch;
        private System.Windows.Forms.TextBox TextBoxMediaLibarySearchField;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton RadioBtnGenre;
        private System.Windows.Forms.RadioButton RadioBtnYear;
        private System.Windows.Forms.RadioButton RadioBtnTitle;
        private System.Windows.Forms.Button BtnReserve;
        private System.Windows.Forms.Button BtnCheckOut;
        private System.Windows.Forms.Button BtnEditMedia;
        private System.Windows.Forms.Label LabelAdminUsername;
        private System.Windows.Forms.Panel PanelSpacer1;
        private System.Windows.Forms.DataGridView DataGridViewMediaLibary;
        private System.Windows.Forms.Button BtnResetMediaLibary;
        private System.Windows.Forms.Label LabelStudentId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnAdminAddUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextBoxReserveDate;
    }
}