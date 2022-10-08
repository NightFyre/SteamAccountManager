
namespace SteamAccountManager
{
    partial class NightFyre_Frameworks
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Password_Textbox = new System.Windows.Forms.TextBox();
            this.Username_Textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NewUserAccount_Button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Accounts_ComboBox = new System.Windows.Forms.ComboBox();
            this.UserLogin_Button = new System.Windows.Forms.Button();
            this.UserLogout_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Password_Textbox);
            this.panel1.Controls.Add(this.Username_Textbox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.NewUserAccount_Button);
            this.panel1.Location = new System.Drawing.Point(13, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 123);
            this.panel1.TabIndex = 0;
            // 
            // Password_Textbox
            // 
            this.Password_Textbox.Location = new System.Drawing.Point(2, 64);
            this.Password_Textbox.MaxLength = 16;
            this.Password_Textbox.Name = "Password_Textbox";
            this.Password_Textbox.PasswordChar = '*';
            this.Password_Textbox.Size = new System.Drawing.Size(187, 22);
            this.Password_Textbox.TabIndex = 8;
            // 
            // Username_Textbox
            // 
            this.Username_Textbox.Location = new System.Drawing.Point(2, 19);
            this.Username_Textbox.MaxLength = 24;
            this.Username_Textbox.Name = "Username_Textbox";
            this.Username_Textbox.Size = new System.Drawing.Size(187, 22);
            this.Username_Textbox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "Username:";
            // 
            // NewUserAccount_Button
            // 
            this.NewUserAccount_Button.Location = new System.Drawing.Point(1, 91);
            this.NewUserAccount_Button.Name = "NewUserAccount_Button";
            this.NewUserAccount_Button.Size = new System.Drawing.Size(191, 21);
            this.NewUserAccount_Button.TabIndex = 1;
            this.NewUserAccount_Button.Text = "CREATE";
            this.NewUserAccount_Button.UseVisualStyleBackColor = true;
            this.NewUserAccount_Button.Click += new System.EventHandler(this.NewUserAccount_Button_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Accounts_ComboBox);
            this.panel2.Controls.Add(this.UserLogin_Button);
            this.panel2.Location = new System.Drawing.Point(214, 25);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 78);
            this.panel2.TabIndex = 1;
            // 
            // Accounts_ComboBox
            // 
            this.Accounts_ComboBox.FormattingEnabled = true;
            this.Accounts_ComboBox.Location = new System.Drawing.Point(2, 19);
            this.Accounts_ComboBox.Name = "Accounts_ComboBox";
            this.Accounts_ComboBox.Size = new System.Drawing.Size(190, 22);
            this.Accounts_ComboBox.TabIndex = 1;
            // 
            // UserLogin_Button
            // 
            this.UserLogin_Button.Location = new System.Drawing.Point(1, 49);
            this.UserLogin_Button.Name = "UserLogin_Button";
            this.UserLogin_Button.Size = new System.Drawing.Size(191, 21);
            this.UserLogin_Button.TabIndex = 0;
            this.UserLogin_Button.Text = "LOGIN";
            this.UserLogin_Button.UseVisualStyleBackColor = true;
            this.UserLogin_Button.Click += new System.EventHandler(this.UserLogin_Button_Click);
            // 
            // UserLogout_Button
            // 
            this.UserLogout_Button.Location = new System.Drawing.Point(217, 117);
            this.UserLogout_Button.Name = "UserLogout_Button";
            this.UserLogout_Button.Size = new System.Drawing.Size(191, 21);
            this.UserLogout_Button.TabIndex = 2;
            this.UserLogout_Button.Text = "LOGOUT CURRENT SESSION";
            this.UserLogout_Button.UseVisualStyleBackColor = true;
            this.UserLogout_Button.Click += new System.EventHandler(this.UserLogout_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "ADD NEW ACCOUNT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "ACCOUNT SELECTION";
            // 
            // NightFyre_Frameworks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(419, 157);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserLogout_Button);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "NightFyre_Frameworks";
            this.Text = "SteamAccountManager";
            this.Load += new System.EventHandler(this.NightFyre_Frameworks_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Password_Textbox;
        private System.Windows.Forms.TextBox Username_Textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button NewUserAccount_Button;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox Accounts_ComboBox;
        private System.Windows.Forms.Button UserLogin_Button;
        private System.Windows.Forms.Button UserLogout_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

