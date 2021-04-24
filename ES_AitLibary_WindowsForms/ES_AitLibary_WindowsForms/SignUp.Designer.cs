
namespace ES_AitLibary_WindowsForms
{
    partial class SignUp
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
            this.panelSignUpContainer = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxUsername = new System.Windows.Forms.TextBox();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PanelSignUpUser = new System.Windows.Forms.Panel();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.PanelSignUpAdmin = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RadioButtonStudent = new System.Windows.Forms.RadioButton();
            this.RadioButtonAdmin = new System.Windows.Forms.RadioButton();
            this.panelNav = new System.Windows.Forms.Panel();
            this.BtnBack = new System.Windows.Forms.Button();
            this.panelSignUpContainer.SuspendLayout();
            this.PanelSignUpUser.SuspendLayout();
            this.PanelSignUpAdmin.SuspendLayout();
            this.panelNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSignUpContainer
            // 
            this.panelSignUpContainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelSignUpContainer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelSignUpContainer.Controls.Add(this.PanelSignUpAdmin);
            this.panelSignUpContainer.Controls.Add(this.PanelSignUpUser);
            this.panelSignUpContainer.Location = new System.Drawing.Point(459, 229);
            this.panelSignUpContainer.Name = "panelSignUpContainer";
            this.panelSignUpContainer.Size = new System.Drawing.Size(782, 792);
            this.panelSignUpContainer.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(308, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign Up";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // TextBoxUsername
            // 
            this.TextBoxUsername.Location = new System.Drawing.Point(239, 150);
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.Size = new System.Drawing.Size(345, 31);
            this.TextBoxUsername.TabIndex = 3;
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Location = new System.Drawing.Point(239, 233);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(345, 31);
            this.TextBoxPassword.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Username:";
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.Location = new System.Drawing.Point(239, 313);
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.Size = new System.Drawing.Size(345, 31);
            this.TextBoxEmail.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email:";
            // 
            // PanelSignUpUser
            // 
            this.PanelSignUpUser.Controls.Add(this.BtnRegister);
            this.PanelSignUpUser.Controls.Add(this.TextBoxUsername);
            this.PanelSignUpUser.Controls.Add(this.label1);
            this.PanelSignUpUser.Controls.Add(this.TextBoxEmail);
            this.PanelSignUpUser.Controls.Add(this.label3);
            this.PanelSignUpUser.Controls.Add(this.label4);
            this.PanelSignUpUser.Controls.Add(this.TextBoxPassword);
            this.PanelSignUpUser.Controls.Add(this.label2);
            this.PanelSignUpUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSignUpUser.Location = new System.Drawing.Point(0, 0);
            this.PanelSignUpUser.Name = "PanelSignUpUser";
            this.PanelSignUpUser.Size = new System.Drawing.Size(782, 489);
            this.PanelSignUpUser.TabIndex = 8;
            // 
            // BtnRegister
            // 
            this.BtnRegister.Location = new System.Drawing.Point(239, 380);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(316, 62);
            this.BtnRegister.TabIndex = 8;
            this.BtnRegister.Text = "Register";
            this.BtnRegister.UseVisualStyleBackColor = true;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // PanelSignUpAdmin
            // 
            this.PanelSignUpAdmin.Controls.Add(this.RadioButtonAdmin);
            this.PanelSignUpAdmin.Controls.Add(this.RadioButtonStudent);
            this.PanelSignUpAdmin.Controls.Add(this.label6);
            this.PanelSignUpAdmin.Controls.Add(this.label5);
            this.PanelSignUpAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSignUpAdmin.Location = new System.Drawing.Point(0, 489);
            this.PanelSignUpAdmin.Name = "PanelSignUpAdmin";
            this.PanelSignUpAdmin.Size = new System.Drawing.Size(782, 246);
            this.PanelSignUpAdmin.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(312, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Admin Options";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(140, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "User Level:";
            // 
            // RadioButtonStudent
            // 
            this.RadioButtonStudent.AutoSize = true;
            this.RadioButtonStudent.Checked = true;
            this.RadioButtonStudent.Location = new System.Drawing.Point(318, 106);
            this.RadioButtonStudent.Name = "RadioButtonStudent";
            this.RadioButtonStudent.Size = new System.Drawing.Size(117, 29);
            this.RadioButtonStudent.TabIndex = 12;
            this.RadioButtonStudent.TabStop = true;
            this.RadioButtonStudent.Text = "Student";
            this.RadioButtonStudent.UseVisualStyleBackColor = true;
            // 
            // RadioButtonAdmin
            // 
            this.RadioButtonAdmin.AutoSize = true;
            this.RadioButtonAdmin.Location = new System.Drawing.Point(514, 106);
            this.RadioButtonAdmin.Name = "RadioButtonAdmin";
            this.RadioButtonAdmin.Size = new System.Drawing.Size(103, 29);
            this.RadioButtonAdmin.TabIndex = 13;
            this.RadioButtonAdmin.TabStop = true;
            this.RadioButtonAdmin.Text = "Admin";
            this.RadioButtonAdmin.UseVisualStyleBackColor = true;
            // 
            // panelNav
            // 
            this.panelNav.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelNav.Controls.Add(this.BtnBack);
            this.panelNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNav.Location = new System.Drawing.Point(0, 0);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(1674, 164);
            this.panelNav.TabIndex = 2;
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
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1674, 1129);
            this.Controls.Add(this.panelNav);
            this.Controls.Add(this.panelSignUpContainer);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.panelSignUpContainer.ResumeLayout(false);
            this.PanelSignUpUser.ResumeLayout(false);
            this.PanelSignUpUser.PerformLayout();
            this.PanelSignUpAdmin.ResumeLayout(false);
            this.PanelSignUpAdmin.PerformLayout();
            this.panelNav.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSignUpContainer;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.TextBox TextBoxUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PanelSignUpUser;
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.TextBox TextBoxEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel PanelSignUpAdmin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton RadioButtonAdmin;
        private System.Windows.Forms.RadioButton RadioButtonStudent;
        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.Button BtnBack;
    }
}