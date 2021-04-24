
namespace ES_AitLibary_WindowsForms
{
    partial class StudentActivity
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
            this.PanelFees = new System.Windows.Forms.Panel();
            this.BtnPayFees = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DataGridViewFees = new System.Windows.Forms.DataGridView();
            this.PanelReservations = new System.Windows.Forms.Panel();
            this.BtnCancelReservedMedia = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.DataGridViewActiveReservations = new System.Windows.Forms.DataGridView();
            this.PanelActiveBookings = new System.Windows.Forms.Panel();
            this.BtnReturnMedia = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.DataGridViewActiveBookings = new System.Windows.Forms.DataGridView();
            this.PanelBase = new System.Windows.Forms.Panel();
            this.panelNav.SuspendLayout();
            this.PanelFees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewFees)).BeginInit();
            this.PanelReservations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewActiveReservations)).BeginInit();
            this.PanelActiveBookings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewActiveBookings)).BeginInit();
            this.PanelBase.SuspendLayout();
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
            this.LabelUserId.Location = new System.Drawing.Point(720, 101);
            this.LabelUserId.Name = "LabelUserId";
            this.LabelUserId.Size = new System.Drawing.Size(107, 25);
            this.LabelUserId.TabIndex = 6;
            this.LabelUserId.Text = "undefined";
            // 
            // LabelUsername
            // 
            this.LabelUsername.AutoSize = true;
            this.LabelUsername.Location = new System.Drawing.Point(847, 101);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.Size = new System.Drawing.Size(107, 25);
            this.LabelUsername.TabIndex = 4;
            this.LabelUsername.Text = "undefined";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(718, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Student Activity";
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
            // PanelFees
            // 
            this.PanelFees.Controls.Add(this.DataGridViewFees);
            this.PanelFees.Controls.Add(this.label2);
            this.PanelFees.Controls.Add(this.BtnPayFees);
            this.PanelFees.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelFees.Location = new System.Drawing.Point(0, 0);
            this.PanelFees.Name = "PanelFees";
            this.PanelFees.Size = new System.Drawing.Size(1647, 620);
            this.PanelFees.TabIndex = 0;
            // 
            // BtnPayFees
            // 
            this.BtnPayFees.Location = new System.Drawing.Point(1408, 81);
            this.BtnPayFees.Name = "BtnPayFees";
            this.BtnPayFees.Size = new System.Drawing.Size(153, 131);
            this.BtnPayFees.TabIndex = 0;
            this.BtnPayFees.Text = "Pay";
            this.BtnPayFees.UseVisualStyleBackColor = true;
            this.BtnPayFees.Click += new System.EventHandler(this.BtnPayFees_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fees";
            // 
            // DataGridViewFees
            // 
            this.DataGridViewFees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewFees.Location = new System.Drawing.Point(129, 56);
            this.DataGridViewFees.Name = "DataGridViewFees";
            this.DataGridViewFees.RowHeadersWidth = 82;
            this.DataGridViewFees.RowTemplate.Height = 33;
            this.DataGridViewFees.Size = new System.Drawing.Size(1240, 500);
            this.DataGridViewFees.TabIndex = 2;
            this.DataGridViewFees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewFees_CellClick);
            // 
            // PanelReservations
            // 
            this.PanelReservations.Controls.Add(this.DataGridViewActiveReservations);
            this.PanelReservations.Controls.Add(this.label3);
            this.PanelReservations.Controls.Add(this.BtnCancelReservedMedia);
            this.PanelReservations.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelReservations.Location = new System.Drawing.Point(0, 620);
            this.PanelReservations.Name = "PanelReservations";
            this.PanelReservations.Size = new System.Drawing.Size(1647, 620);
            this.PanelReservations.TabIndex = 3;
            // 
            // BtnCancelReservedMedia
            // 
            this.BtnCancelReservedMedia.Location = new System.Drawing.Point(1408, 70);
            this.BtnCancelReservedMedia.Name = "BtnCancelReservedMedia";
            this.BtnCancelReservedMedia.Size = new System.Drawing.Size(153, 131);
            this.BtnCancelReservedMedia.TabIndex = 0;
            this.BtnCancelReservedMedia.Text = "Cancel";
            this.BtnCancelReservedMedia.UseVisualStyleBackColor = true;
            this.BtnCancelReservedMedia.Click += new System.EventHandler(this.BtnCancelReservedMedia_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Reservations";
            // 
            // DataGridViewActiveReservations
            // 
            this.DataGridViewActiveReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewActiveReservations.Location = new System.Drawing.Point(128, 52);
            this.DataGridViewActiveReservations.Name = "DataGridViewActiveReservations";
            this.DataGridViewActiveReservations.RowHeadersWidth = 82;
            this.DataGridViewActiveReservations.RowTemplate.Height = 33;
            this.DataGridViewActiveReservations.Size = new System.Drawing.Size(1240, 500);
            this.DataGridViewActiveReservations.TabIndex = 3;
            this.DataGridViewActiveReservations.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewActiveReservations_CellClick);
            // 
            // PanelActiveBookings
            // 
            this.PanelActiveBookings.Controls.Add(this.DataGridViewActiveBookings);
            this.PanelActiveBookings.Controls.Add(this.label4);
            this.PanelActiveBookings.Controls.Add(this.BtnReturnMedia);
            this.PanelActiveBookings.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelActiveBookings.Location = new System.Drawing.Point(0, 1240);
            this.PanelActiveBookings.Name = "PanelActiveBookings";
            this.PanelActiveBookings.Size = new System.Drawing.Size(1647, 620);
            this.PanelActiveBookings.TabIndex = 4;
            // 
            // BtnReturnMedia
            // 
            this.BtnReturnMedia.Location = new System.Drawing.Point(1406, 84);
            this.BtnReturnMedia.Name = "BtnReturnMedia";
            this.BtnReturnMedia.Size = new System.Drawing.Size(153, 131);
            this.BtnReturnMedia.TabIndex = 0;
            this.BtnReturnMedia.Text = "Return";
            this.BtnReturnMedia.UseVisualStyleBackColor = true;
            this.BtnReturnMedia.Click += new System.EventHandler(this.BtnReturnMedia_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Active Bookings";
            // 
            // DataGridViewActiveBookings
            // 
            this.DataGridViewActiveBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewActiveBookings.Location = new System.Drawing.Point(128, 56);
            this.DataGridViewActiveBookings.Name = "DataGridViewActiveBookings";
            this.DataGridViewActiveBookings.RowHeadersWidth = 82;
            this.DataGridViewActiveBookings.RowTemplate.Height = 33;
            this.DataGridViewActiveBookings.Size = new System.Drawing.Size(1240, 500);
            this.DataGridViewActiveBookings.TabIndex = 3;
            this.DataGridViewActiveBookings.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewActiveBookings_CellClick);
            // 
            // PanelBase
            // 
            this.PanelBase.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PanelBase.Controls.Add(this.PanelActiveBookings);
            this.PanelBase.Controls.Add(this.PanelReservations);
            this.PanelBase.Controls.Add(this.PanelFees);
            this.PanelBase.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBase.Location = new System.Drawing.Point(0, 164);
            this.PanelBase.Name = "PanelBase";
            this.PanelBase.Size = new System.Drawing.Size(1647, 1913);
            this.PanelBase.TabIndex = 2;
            // 
            // StudentActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1681, 1500);
            this.Controls.Add(this.PanelBase);
            this.Controls.Add(this.panelNav);
            this.Name = "StudentActivity";
            this.Text = "StudentActivity";
            this.panelNav.ResumeLayout(false);
            this.panelNav.PerformLayout();
            this.PanelFees.ResumeLayout(false);
            this.PanelFees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewFees)).EndInit();
            this.PanelReservations.ResumeLayout(false);
            this.PanelReservations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewActiveReservations)).EndInit();
            this.PanelActiveBookings.ResumeLayout(false);
            this.PanelActiveBookings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewActiveBookings)).EndInit();
            this.PanelBase.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelUsername;
        private System.Windows.Forms.Label LabelUserId;
        private System.Windows.Forms.Panel PanelFees;
        private System.Windows.Forms.DataGridView DataGridViewFees;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnPayFees;
        private System.Windows.Forms.Panel PanelReservations;
        private System.Windows.Forms.DataGridView DataGridViewActiveReservations;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnCancelReservedMedia;
        private System.Windows.Forms.Panel PanelActiveBookings;
        private System.Windows.Forms.DataGridView DataGridViewActiveBookings;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnReturnMedia;
        private System.Windows.Forms.Panel PanelBase;
    }
}