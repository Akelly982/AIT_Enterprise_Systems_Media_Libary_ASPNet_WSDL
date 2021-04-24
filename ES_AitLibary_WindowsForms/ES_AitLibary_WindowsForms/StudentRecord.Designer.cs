
namespace ES_AitLibary_WindowsForms
{
    partial class StudentRecord
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
            this.PanelBase = new System.Windows.Forms.Panel();
            this.DataGridViewReservedHistory = new System.Windows.Forms.DataGridView();
            this.DataGridViewBookingHistory = new System.Windows.Forms.DataGridView();
            this.label67 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelNav.SuspendLayout();
            this.PanelBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewReservedHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewBookingHistory)).BeginInit();
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
            this.panelNav.Size = new System.Drawing.Size(1647, 164);
            this.panelNav.TabIndex = 1;
            // 
            // LabelUserId
            // 
            this.LabelUserId.AutoSize = true;
            this.LabelUserId.Location = new System.Drawing.Point(699, 99);
            this.LabelUserId.Name = "LabelUserId";
            this.LabelUserId.Size = new System.Drawing.Size(107, 25);
            this.LabelUserId.TabIndex = 5;
            this.LabelUserId.Text = "undefined";
            // 
            // LabelUsername
            // 
            this.LabelUsername.AutoSize = true;
            this.LabelUsername.Location = new System.Drawing.Point(812, 99);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.Size = new System.Drawing.Size(107, 25);
            this.LabelUsername.TabIndex = 4;
            this.LabelUsername.Text = "undefined";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(693, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student Record";
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
            // PanelBase
            // 
            this.PanelBase.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PanelBase.Controls.Add(this.DataGridViewReservedHistory);
            this.PanelBase.Controls.Add(this.DataGridViewBookingHistory);
            this.PanelBase.Controls.Add(this.label67);
            this.PanelBase.Controls.Add(this.label2);
            this.PanelBase.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBase.Location = new System.Drawing.Point(0, 164);
            this.PanelBase.Name = "PanelBase";
            this.PanelBase.Size = new System.Drawing.Size(1647, 1198);
            this.PanelBase.TabIndex = 2;
            // 
            // DataGridViewReservedHistory
            // 
            this.DataGridViewReservedHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewReservedHistory.Location = new System.Drawing.Point(56, 581);
            this.DataGridViewReservedHistory.Name = "DataGridViewReservedHistory";
            this.DataGridViewReservedHistory.RowHeadersWidth = 82;
            this.DataGridViewReservedHistory.RowTemplate.Height = 33;
            this.DataGridViewReservedHistory.Size = new System.Drawing.Size(1528, 429);
            this.DataGridViewReservedHistory.TabIndex = 3;
            // 
            // DataGridViewBookingHistory
            // 
            this.DataGridViewBookingHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewBookingHistory.Location = new System.Drawing.Point(56, 73);
            this.DataGridViewBookingHistory.Name = "DataGridViewBookingHistory";
            this.DataGridViewBookingHistory.RowHeadersWidth = 82;
            this.DataGridViewBookingHistory.RowTemplate.Height = 33;
            this.DataGridViewBookingHistory.Size = new System.Drawing.Size(1528, 434);
            this.DataGridViewBookingHistory.TabIndex = 2;
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(51, 540);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(200, 25);
            this.label67.TabIndex = 1;
            this.label67.Text = "Reservation History";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Booking History";
            // 
            // StudentRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1647, 1454);
            this.Controls.Add(this.PanelBase);
            this.Controls.Add(this.panelNav);
            this.Name = "StudentRecord";
            this.Text = "StudentRecord";
            this.panelNav.ResumeLayout(false);
            this.panelNav.PerformLayout();
            this.PanelBase.ResumeLayout(false);
            this.PanelBase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewReservedHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewBookingHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Label LabelUsername;
        private System.Windows.Forms.Panel PanelBase;
        private System.Windows.Forms.Label LabelUserId;
        private System.Windows.Forms.DataGridView DataGridViewReservedHistory;
        private System.Windows.Forms.DataGridView DataGridViewBookingHistory;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Label label2;
    }
}