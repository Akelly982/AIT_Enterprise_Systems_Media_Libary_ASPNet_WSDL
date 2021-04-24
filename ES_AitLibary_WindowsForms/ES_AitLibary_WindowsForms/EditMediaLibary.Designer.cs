
namespace ES_AitLibary_WindowsForms
{
    partial class EditMediaLibary
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
            this.LabelUserId = new System.Windows.Forms.Label();
            this.LabelUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnBack = new System.Windows.Forms.Button();
            this.DataGridViewMedia = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnMediaSubmit = new System.Windows.Forms.Button();
            this.RadioBtnDeleteMedia = new System.Windows.Forms.RadioButton();
            this.RadioBtnUpdateMedia = new System.Windows.Forms.RadioButton();
            this.RadioBtnNewMediaItem = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxBudget = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TextBoxTitle = new System.Windows.Forms.TextBox();
            this.TextBoxPublishYear = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TextBoxGenre = new System.Windows.Forms.TextBox();
            this.TextBoxLanguage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBoxDirector = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.DataGridViewDirector = new System.Windows.Forms.DataGridView();
            this.BtnDeleteDirector = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.DataGridViewGenre = new System.Windows.Forms.DataGridView();
            this.BtnDeleteGenre = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.DataGridViewLanguage = new System.Windows.Forms.DataGridView();
            this.BtnDeleteLanguage = new System.Windows.Forms.Button();
            this.panelNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewMedia)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewDirector)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewGenre)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewLanguage)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNav
            // 
            this.panelNav.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelNav.Controls.Add(this.LabelUserId);
            this.panelNav.Controls.Add(this.LabelUsername);
            this.panelNav.Controls.Add(this.label1);
            this.panelNav.Controls.Add(this.BtnBack);
            this.panelNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNav.Location = new System.Drawing.Point(0, 0);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(1994, 164);
            this.panelNav.TabIndex = 2;
            // 
            // LabelUserId
            // 
            this.LabelUserId.AutoSize = true;
            this.LabelUserId.Location = new System.Drawing.Point(855, 99);
            this.LabelUserId.Name = "LabelUserId";
            this.LabelUserId.Size = new System.Drawing.Size(107, 25);
            this.LabelUserId.TabIndex = 5;
            this.LabelUserId.Text = "undefined";
            this.LabelUserId.Click += new System.EventHandler(this.LabelUserId_Click);
            // 
            // LabelUsername
            // 
            this.LabelUsername.AutoSize = true;
            this.LabelUsername.Location = new System.Drawing.Point(968, 99);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.Size = new System.Drawing.Size(107, 25);
            this.LabelUsername.TabIndex = 4;
            this.LabelUsername.Text = "undefined";
            this.LabelUsername.Click += new System.EventHandler(this.LabelUsername_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(849, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student Record";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            // DataGridViewMedia
            // 
            this.DataGridViewMedia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewMedia.Location = new System.Drawing.Point(707, 86);
            this.DataGridViewMedia.Name = "DataGridViewMedia";
            this.DataGridViewMedia.RowHeadersWidth = 82;
            this.DataGridViewMedia.RowTemplate.Height = 33;
            this.DataGridViewMedia.Size = new System.Drawing.Size(1217, 653);
            this.DataGridViewMedia.TabIndex = 3;
            this.DataGridViewMedia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewMedia_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.DataGridViewMedia);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 164);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1994, 834);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnMediaSubmit);
            this.panel2.Controls.Add(this.RadioBtnDeleteMedia);
            this.panel2.Controls.Add(this.RadioBtnUpdateMedia);
            this.panel2.Controls.Add(this.RadioBtnNewMediaItem);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.TextBoxBudget);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.TextBoxTitle);
            this.panel2.Controls.Add(this.TextBoxPublishYear);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.TextBoxGenre);
            this.panel2.Controls.Add(this.TextBoxLanguage);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.TextBoxDirector);
            this.panel2.Location = new System.Drawing.Point(21, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(636, 653);
            this.panel2.TabIndex = 17;
            // 
            // BtnMediaSubmit
            // 
            this.BtnMediaSubmit.Location = new System.Drawing.Point(188, 565);
            this.BtnMediaSubmit.Name = "BtnMediaSubmit";
            this.BtnMediaSubmit.Size = new System.Drawing.Size(251, 66);
            this.BtnMediaSubmit.TabIndex = 20;
            this.BtnMediaSubmit.Text = "Submit";
            this.BtnMediaSubmit.UseVisualStyleBackColor = true;
            this.BtnMediaSubmit.Click += new System.EventHandler(this.BtnMediaSubmit_Click);
            // 
            // RadioBtnDeleteMedia
            // 
            this.RadioBtnDeleteMedia.AutoSize = true;
            this.RadioBtnDeleteMedia.Location = new System.Drawing.Point(448, 508);
            this.RadioBtnDeleteMedia.Name = "RadioBtnDeleteMedia";
            this.RadioBtnDeleteMedia.Size = new System.Drawing.Size(105, 29);
            this.RadioBtnDeleteMedia.TabIndex = 19;
            this.RadioBtnDeleteMedia.Text = "Delete";
            this.RadioBtnDeleteMedia.UseVisualStyleBackColor = true;
            // 
            // RadioBtnUpdateMedia
            // 
            this.RadioBtnUpdateMedia.AutoSize = true;
            this.RadioBtnUpdateMedia.Location = new System.Drawing.Point(258, 508);
            this.RadioBtnUpdateMedia.Name = "RadioBtnUpdateMedia";
            this.RadioBtnUpdateMedia.Size = new System.Drawing.Size(112, 29);
            this.RadioBtnUpdateMedia.TabIndex = 18;
            this.RadioBtnUpdateMedia.Text = "Update";
            this.RadioBtnUpdateMedia.UseVisualStyleBackColor = true;
            // 
            // RadioBtnNewMediaItem
            // 
            this.RadioBtnNewMediaItem.AutoSize = true;
            this.RadioBtnNewMediaItem.Checked = true;
            this.RadioBtnNewMediaItem.Location = new System.Drawing.Point(91, 508);
            this.RadioBtnNewMediaItem.Name = "RadioBtnNewMediaItem";
            this.RadioBtnNewMediaItem.Size = new System.Drawing.Size(81, 29);
            this.RadioBtnNewMediaItem.TabIndex = 17;
            this.RadioBtnNewMediaItem.TabStop = true;
            this.RadioBtnNewMediaItem.Text = "Add";
            this.RadioBtnNewMediaItem.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Language:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(251, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Media";
            // 
            // TextBoxBudget
            // 
            this.TextBoxBudget.Location = new System.Drawing.Point(203, 437);
            this.TextBoxBudget.Name = "TextBoxBudget";
            this.TextBoxBudget.Size = new System.Drawing.Size(378, 31);
            this.TextBoxBudget.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Title:";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 437);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Budget:";
            // 
            // TextBoxTitle
            // 
            this.TextBoxTitle.Location = new System.Drawing.Point(203, 86);
            this.TextBoxTitle.Name = "TextBoxTitle";
            this.TextBoxTitle.Size = new System.Drawing.Size(378, 31);
            this.TextBoxTitle.TabIndex = 6;
            // 
            // TextBoxPublishYear
            // 
            this.TextBoxPublishYear.Location = new System.Drawing.Point(203, 360);
            this.TextBoxPublishYear.Name = "TextBoxPublishYear";
            this.TextBoxPublishYear.Size = new System.Drawing.Size(378, 31);
            this.TextBoxPublishYear.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Genre:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 366);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Publish year:";
            // 
            // TextBoxGenre
            // 
            this.TextBoxGenre.Location = new System.Drawing.Point(203, 158);
            this.TextBoxGenre.Name = "TextBoxGenre";
            this.TextBoxGenre.Size = new System.Drawing.Size(378, 31);
            this.TextBoxGenre.TabIndex = 8;
            // 
            // TextBoxLanguage
            // 
            this.TextBoxLanguage.Location = new System.Drawing.Point(203, 292);
            this.TextBoxLanguage.Name = "TextBoxLanguage";
            this.TextBoxLanguage.Size = new System.Drawing.Size(378, 31);
            this.TextBoxLanguage.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Director:";
            // 
            // TextBoxDirector
            // 
            this.TextBoxDirector.Location = new System.Drawing.Point(203, 227);
            this.TextBoxDirector.Name = "TextBoxDirector";
            this.TextBoxDirector.Size = new System.Drawing.Size(378, 31);
            this.TextBoxDirector.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.DataGridViewDirector);
            this.panel3.Controls.Add(this.BtnDeleteDirector);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 998);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1994, 412);
            this.panel3.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(132, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 37);
            this.label9.TabIndex = 19;
            this.label9.Text = "Director";
            // 
            // DataGridViewDirector
            // 
            this.DataGridViewDirector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewDirector.Location = new System.Drawing.Point(388, 29);
            this.DataGridViewDirector.Name = "DataGridViewDirector";
            this.DataGridViewDirector.RowHeadersWidth = 82;
            this.DataGridViewDirector.RowTemplate.Height = 33;
            this.DataGridViewDirector.Size = new System.Drawing.Size(1537, 361);
            this.DataGridViewDirector.TabIndex = 18;
            this.DataGridViewDirector.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewDirector_CellClick);
            // 
            // BtnDeleteDirector
            // 
            this.BtnDeleteDirector.Location = new System.Drawing.Point(85, 174);
            this.BtnDeleteDirector.Name = "BtnDeleteDirector";
            this.BtnDeleteDirector.Size = new System.Drawing.Size(220, 87);
            this.BtnDeleteDirector.TabIndex = 0;
            this.BtnDeleteDirector.Text = "delete";
            this.BtnDeleteDirector.UseVisualStyleBackColor = true;
            this.BtnDeleteDirector.Click += new System.EventHandler(this.BtnDeleteDirector_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.DataGridViewGenre);
            this.panel4.Controls.Add(this.BtnDeleteGenre);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 1410);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1994, 412);
            this.panel4.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(132, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 37);
            this.label10.TabIndex = 19;
            this.label10.Text = "Genre";
            // 
            // DataGridViewGenre
            // 
            this.DataGridViewGenre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewGenre.Location = new System.Drawing.Point(388, 29);
            this.DataGridViewGenre.Name = "DataGridViewGenre";
            this.DataGridViewGenre.RowHeadersWidth = 82;
            this.DataGridViewGenre.RowTemplate.Height = 33;
            this.DataGridViewGenre.Size = new System.Drawing.Size(1537, 361);
            this.DataGridViewGenre.TabIndex = 18;
            this.DataGridViewGenre.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewGenre_CellClick);
            // 
            // BtnDeleteGenre
            // 
            this.BtnDeleteGenre.Location = new System.Drawing.Point(85, 174);
            this.BtnDeleteGenre.Name = "BtnDeleteGenre";
            this.BtnDeleteGenre.Size = new System.Drawing.Size(220, 87);
            this.BtnDeleteGenre.TabIndex = 0;
            this.BtnDeleteGenre.Text = "delete";
            this.BtnDeleteGenre.UseVisualStyleBackColor = true;
            this.BtnDeleteGenre.Click += new System.EventHandler(this.BtnDeleteGenre_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.DataGridViewLanguage);
            this.panel5.Controls.Add(this.BtnDeleteLanguage);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 1822);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1994, 412);
            this.panel5.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(112, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(160, 37);
            this.label11.TabIndex = 19;
            this.label11.Text = "Language";
            // 
            // DataGridViewLanguage
            // 
            this.DataGridViewLanguage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewLanguage.Location = new System.Drawing.Point(388, 29);
            this.DataGridViewLanguage.Name = "DataGridViewLanguage";
            this.DataGridViewLanguage.RowHeadersWidth = 82;
            this.DataGridViewLanguage.RowTemplate.Height = 33;
            this.DataGridViewLanguage.Size = new System.Drawing.Size(1537, 361);
            this.DataGridViewLanguage.TabIndex = 18;
            this.DataGridViewLanguage.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewLanguage_CellClick);
            // 
            // BtnDeleteLanguage
            // 
            this.BtnDeleteLanguage.Location = new System.Drawing.Point(85, 174);
            this.BtnDeleteLanguage.Name = "BtnDeleteLanguage";
            this.BtnDeleteLanguage.Size = new System.Drawing.Size(220, 87);
            this.BtnDeleteLanguage.TabIndex = 0;
            this.BtnDeleteLanguage.Text = "delete";
            this.BtnDeleteLanguage.UseVisualStyleBackColor = true;
            this.BtnDeleteLanguage.Click += new System.EventHandler(this.BtnDeleteLanguage_Click);
            // 
            // EditMediaLibary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(2028, 1308);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelNav);
            this.Name = "EditMediaLibary";
            this.Text = "EditMediaLibary";
            this.Load += new System.EventHandler(this.EditMediaLibary_Load);
            this.panelNav.ResumeLayout(false);
            this.panelNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewMedia)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewDirector)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewGenre)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewLanguage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.Label LabelUserId;
        private System.Windows.Forms.Label LabelUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.DataGridView DataGridViewMedia;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton RadioBtnDeleteMedia;
        private System.Windows.Forms.RadioButton RadioBtnUpdateMedia;
        private System.Windows.Forms.RadioButton RadioBtnNewMediaItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextBoxBudget;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TextBoxPublishYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TextBoxGenre;
        private System.Windows.Forms.TextBox TextBoxLanguage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextBoxDirector;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView DataGridViewDirector;
        private System.Windows.Forms.Button BtnDeleteDirector;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView DataGridViewGenre;
        private System.Windows.Forms.Button BtnDeleteGenre;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView DataGridViewLanguage;
        private System.Windows.Forms.Button BtnDeleteLanguage;
        private System.Windows.Forms.Button BtnMediaSubmit;
    }
}