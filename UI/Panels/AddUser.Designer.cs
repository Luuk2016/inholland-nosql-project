﻿namespace UI.Panels
{
    partial class AddUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_CreateUser = new System.Windows.Forms.Panel();
            this.cmb_TypeUser = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmb_Location = new System.Windows.Forms.ComboBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_PhoneNumber = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnl_CreateUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create new user";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "First name:";
            // 
            // pnl_CreateUser
            // 
            this.pnl_CreateUser.Controls.Add(this.cmb_TypeUser);
            this.pnl_CreateUser.Controls.Add(this.btnAdd);
            this.pnl_CreateUser.Controls.Add(this.btnCancel);
            this.pnl_CreateUser.Controls.Add(this.cmb_Location);
            this.pnl_CreateUser.Controls.Add(this.txt_Password);
            this.pnl_CreateUser.Controls.Add(this.txt_PhoneNumber);
            this.pnl_CreateUser.Controls.Add(this.txt_Email);
            this.pnl_CreateUser.Controls.Add(this.txt_LastName);
            this.pnl_CreateUser.Controls.Add(this.txt_FirstName);
            this.pnl_CreateUser.Controls.Add(this.label8);
            this.pnl_CreateUser.Controls.Add(this.label7);
            this.pnl_CreateUser.Controls.Add(this.label6);
            this.pnl_CreateUser.Controls.Add(this.label5);
            this.pnl_CreateUser.Controls.Add(this.label4);
            this.pnl_CreateUser.Controls.Add(this.label3);
            this.pnl_CreateUser.Controls.Add(this.label1);
            this.pnl_CreateUser.Controls.Add(this.label2);
            this.pnl_CreateUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_CreateUser.Location = new System.Drawing.Point(0, 0);
            this.pnl_CreateUser.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_CreateUser.Name = "pnl_CreateUser";
            this.pnl_CreateUser.Size = new System.Drawing.Size(651, 538);
            this.pnl_CreateUser.TabIndex = 2;
            // 
            // cmb_TypeUser
            // 
            this.cmb_TypeUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_TypeUser.FormattingEnabled = true;
            this.cmb_TypeUser.Items.AddRange(new object[] {
            "Employee",
            "Service desk employee"});
            this.cmb_TypeUser.Location = new System.Drawing.Point(336, 197);
            this.cmb_TypeUser.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_TypeUser.Name = "cmb_TypeUser";
            this.cmb_TypeUser.Size = new System.Drawing.Size(270, 21);
            this.cmb_TypeUser.TabIndex = 19;
            this.cmb_TypeUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_TypeUser_KeyPress);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(473, 447);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(133, 51);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(336, 447);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(133, 51);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // cmb_Location
            // 
            this.cmb_Location.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Location.FormattingEnabled = true;
            this.cmb_Location.Items.AddRange(new object[] {
            "Amsterdam",
            "Haarlem"});
            this.cmb_Location.Location = new System.Drawing.Point(336, 347);
            this.cmb_Location.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_Location.Name = "cmb_Location";
            this.cmb_Location.Size = new System.Drawing.Size(270, 21);
            this.cmb_Location.TabIndex = 15;
            this.cmb_Location.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_Location_KeyPress);
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(336, 397);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(270, 20);
            this.txt_Password.TabIndex = 14;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // txt_PhoneNumber
            // 
            this.txt_PhoneNumber.Location = new System.Drawing.Point(336, 297);
            this.txt_PhoneNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txt_PhoneNumber.Name = "txt_PhoneNumber";
            this.txt_PhoneNumber.Size = new System.Drawing.Size(270, 20);
            this.txt_PhoneNumber.TabIndex = 12;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(336, 246);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(270, 20);
            this.txt_Email.TabIndex = 11;
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(336, 147);
            this.txt_LastName.Margin = new System.Windows.Forms.Padding(2);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(270, 20);
            this.txt_LastName.TabIndex = 9;
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Location = new System.Drawing.Point(336, 97);
            this.txt_FirstName.Margin = new System.Windows.Forms.Padding(2);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(270, 20);
            this.txt_FirstName.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(31, 140);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Last name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 190);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Type of user:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 240);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "E-mail address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 291);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phone number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 341);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Location/ branch:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 390);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(651, 538);
            this.Controls.Add(this.pnl_CreateUser);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddUser";
            this.Text = "AddUser";
            this.pnl_CreateUser.ResumeLayout(false);
            this.pnl_CreateUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnl_CreateUser;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_PhoneNumber;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.TextBox txt_FirstName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_Location;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmb_TypeUser;
    }
}