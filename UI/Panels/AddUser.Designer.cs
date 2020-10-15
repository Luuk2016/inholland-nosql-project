namespace UI.Panels
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmb_TypeUser = new System.Windows.Forms.ComboBox();
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
            this.lbl_FirstNameWarning = new System.Windows.Forms.Label();
            this.lbl_LastNameWarning = new System.Windows.Forms.Label();
            this.lbl_TypeWarning = new System.Windows.Forms.Label();
            this.lbl_PasswordWarning = new System.Windows.Forms.Label();
            this.lbl_LocationWarning = new System.Windows.Forms.Label();
            this.lbl_PhoneNumberWarning = new System.Windows.Forms.Label();
            this.lbl_MailWarning = new System.Windows.Forms.Label();
            this.btn_Check = new System.Windows.Forms.Button();
            this.pnl_CreateUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create new user";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "First name:";
            // 
            // pnl_CreateUser
            // 
            this.pnl_CreateUser.Controls.Add(this.btn_Check);
            this.pnl_CreateUser.Controls.Add(this.lbl_MailWarning);
            this.pnl_CreateUser.Controls.Add(this.lbl_PhoneNumberWarning);
            this.pnl_CreateUser.Controls.Add(this.lbl_LocationWarning);
            this.pnl_CreateUser.Controls.Add(this.lbl_PasswordWarning);
            this.pnl_CreateUser.Controls.Add(this.lbl_TypeWarning);
            this.pnl_CreateUser.Controls.Add(this.lbl_LastNameWarning);
            this.pnl_CreateUser.Controls.Add(this.lbl_FirstNameWarning);
            this.pnl_CreateUser.Controls.Add(this.btnAdd);
            this.pnl_CreateUser.Controls.Add(this.btnCancel);
            this.pnl_CreateUser.Controls.Add(this.cmb_TypeUser);
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
            this.pnl_CreateUser.Location = new System.Drawing.Point(12, 12);
            this.pnl_CreateUser.Name = "pnl_CreateUser";
            this.pnl_CreateUser.Size = new System.Drawing.Size(1259, 847);
            this.pnl_CreateUser.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(618, 669);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(177, 63);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(436, 669);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(177, 63);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // cmb_TypeUser
            // 
            this.cmb_TypeUser.Cursor = System.Windows.Forms.Cursors.Cross;
            this.cmb_TypeUser.FormattingEnabled = true;
            this.cmb_TypeUser.Items.AddRange(new object[] {
            "Employee",
            "Manager"});
            this.cmb_TypeUser.Location = new System.Drawing.Point(436, 299);
            this.cmb_TypeUser.Name = "cmb_TypeUser";
            this.cmb_TypeUser.Size = new System.Drawing.Size(359, 24);
            this.cmb_TypeUser.TabIndex = 16;
            // 
            // cmb_Location
            // 
            this.cmb_Location.FormattingEnabled = true;
            this.cmb_Location.Items.AddRange(new object[] {
            "Amsterdam",
            "Haarlem"});
            this.cmb_Location.Location = new System.Drawing.Point(436, 484);
            this.cmb_Location.Name = "cmb_Location";
            this.cmb_Location.Size = new System.Drawing.Size(359, 24);
            this.cmb_Location.TabIndex = 15;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(436, 545);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(359, 22);
            this.txt_Password.TabIndex = 14;
            // 
            // txt_PhoneNumber
            // 
            this.txt_PhoneNumber.Location = new System.Drawing.Point(436, 422);
            this.txt_PhoneNumber.Name = "txt_PhoneNumber";
            this.txt_PhoneNumber.Size = new System.Drawing.Size(359, 22);
            this.txt_PhoneNumber.TabIndex = 12;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(436, 360);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(359, 22);
            this.txt_Email.TabIndex = 11;
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(436, 237);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(359, 22);
            this.txt_LastName.TabIndex = 9;
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Location = new System.Drawing.Point(436, 176);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(359, 22);
            this.txt_FirstName.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 29);
            this.label8.TabIndex = 7;
            this.label8.Text = "Last name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "Type of user:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "E-mail address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 415);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phone number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 476);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Location/ branch:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 537);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // lbl_FirstNameWarning
            // 
            this.lbl_FirstNameWarning.AutoSize = true;
            this.lbl_FirstNameWarning.ForeColor = System.Drawing.Color.Red;
            this.lbl_FirstNameWarning.Location = new System.Drawing.Point(891, 176);
            this.lbl_FirstNameWarning.Name = "lbl_FirstNameWarning";
            this.lbl_FirstNameWarning.Size = new System.Drawing.Size(128, 17);
            this.lbl_FirstNameWarning.TabIndex = 19;
            this.lbl_FirstNameWarning.Text = "Field must be filled!";
            // 
            // lbl_LastNameWarning
            // 
            this.lbl_LastNameWarning.AutoSize = true;
            this.lbl_LastNameWarning.ForeColor = System.Drawing.Color.Red;
            this.lbl_LastNameWarning.Location = new System.Drawing.Point(891, 237);
            this.lbl_LastNameWarning.Name = "lbl_LastNameWarning";
            this.lbl_LastNameWarning.Size = new System.Drawing.Size(128, 17);
            this.lbl_LastNameWarning.TabIndex = 20;
            this.lbl_LastNameWarning.Text = "Field must be filled!";
            // 
            // lbl_TypeWarning
            // 
            this.lbl_TypeWarning.AutoSize = true;
            this.lbl_TypeWarning.ForeColor = System.Drawing.Color.Red;
            this.lbl_TypeWarning.Location = new System.Drawing.Point(891, 299);
            this.lbl_TypeWarning.Name = "lbl_TypeWarning";
            this.lbl_TypeWarning.Size = new System.Drawing.Size(128, 17);
            this.lbl_TypeWarning.TabIndex = 21;
            this.lbl_TypeWarning.Text = "Field must be filled!";
            // 
            // lbl_PasswordWarning
            // 
            this.lbl_PasswordWarning.AutoSize = true;
            this.lbl_PasswordWarning.ForeColor = System.Drawing.Color.Red;
            this.lbl_PasswordWarning.Location = new System.Drawing.Point(891, 545);
            this.lbl_PasswordWarning.Name = "lbl_PasswordWarning";
            this.lbl_PasswordWarning.Size = new System.Drawing.Size(128, 17);
            this.lbl_PasswordWarning.TabIndex = 22;
            this.lbl_PasswordWarning.Text = "Field must be filled!";
            // 
            // lbl_LocationWarning
            // 
            this.lbl_LocationWarning.AutoSize = true;
            this.lbl_LocationWarning.ForeColor = System.Drawing.Color.Red;
            this.lbl_LocationWarning.Location = new System.Drawing.Point(891, 484);
            this.lbl_LocationWarning.Name = "lbl_LocationWarning";
            this.lbl_LocationWarning.Size = new System.Drawing.Size(128, 17);
            this.lbl_LocationWarning.TabIndex = 23;
            this.lbl_LocationWarning.Text = "Field must be filled!";
            // 
            // lbl_PhoneNumberWarning
            // 
            this.lbl_PhoneNumberWarning.AutoSize = true;
            this.lbl_PhoneNumberWarning.ForeColor = System.Drawing.Color.Red;
            this.lbl_PhoneNumberWarning.Location = new System.Drawing.Point(891, 422);
            this.lbl_PhoneNumberWarning.Name = "lbl_PhoneNumberWarning";
            this.lbl_PhoneNumberWarning.Size = new System.Drawing.Size(128, 17);
            this.lbl_PhoneNumberWarning.TabIndex = 24;
            this.lbl_PhoneNumberWarning.Text = "Field must be filled!";
            // 
            // lbl_MailWarning
            // 
            this.lbl_MailWarning.AutoSize = true;
            this.lbl_MailWarning.ForeColor = System.Drawing.Color.Red;
            this.lbl_MailWarning.Location = new System.Drawing.Point(891, 360);
            this.lbl_MailWarning.Name = "lbl_MailWarning";
            this.lbl_MailWarning.Size = new System.Drawing.Size(128, 17);
            this.lbl_MailWarning.TabIndex = 25;
            this.lbl_MailWarning.Text = "Field must be filled!";
            // 
            // btn_Check
            // 
            this.btn_Check.Location = new System.Drawing.Point(436, 596);
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.Size = new System.Drawing.Size(112, 37);
            this.btn_Check.TabIndex = 26;
            this.btn_Check.Text = "Check";
            this.btn_Check.UseVisualStyleBackColor = true;
            this.btn_Check.Click += new System.EventHandler(this.btn_Check_Click);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1283, 881);
            this.Controls.Add(this.pnl_CreateUser);
            this.Margin = new System.Windows.Forms.Padding(5);
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
        private System.Windows.Forms.ComboBox cmb_TypeUser;
        private System.Windows.Forms.ComboBox cmb_Location;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbl_MailWarning;
        private System.Windows.Forms.Label lbl_PhoneNumberWarning;
        private System.Windows.Forms.Label lbl_LocationWarning;
        private System.Windows.Forms.Label lbl_PasswordWarning;
        private System.Windows.Forms.Label lbl_TypeWarning;
        private System.Windows.Forms.Label lbl_LastNameWarning;
        private System.Windows.Forms.Label lbl_FirstNameWarning;
        private System.Windows.Forms.Button btn_Check;
    }
}