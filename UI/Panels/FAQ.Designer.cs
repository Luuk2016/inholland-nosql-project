namespace UI.Panels
{
    partial class FAQ
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Yes. Via \'Reset your pasword\', copy & paste the token you received in your email " +
        "and fill in your new password.");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Is it possible to change my password?", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Yes. On the page \'User management\' fill in the email address of the user you want" +
        " to search for.");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Can I search for a user?", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("No. You have to know the his/her email address.");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Is it possible to search for a user if you don\'t know his/her email address?", new System.Windows.Forms.TreeNode[] {
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Yes. Send in your question, and we\'ll get back to you as soon as possible.");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Can I ask a question that isn\'t mentioned above?", new System.Windows.Forms.TreeNode[] {
            treeNode7});
            this.panel1 = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.treeView1);
            this.panel1.Controls.Add(this.btnAddQuestion);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1252, 783);
            this.panel1.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.AllowDrop = true;
            this.treeView1.BackColor = System.Drawing.SystemColors.Window;
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.ForeColor = System.Drawing.SystemColors.Window;
            this.treeView1.Indent = 19;
            this.treeView1.ItemHeight = 40;
            this.treeView1.LineColor = System.Drawing.Color.WhiteSmoke;
            this.treeView1.Location = new System.Drawing.Point(26, 260);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4);
            this.treeView1.Name = "treeView1";
            treeNode1.BackColor = System.Drawing.Color.White;
            treeNode1.ForeColor = System.Drawing.Color.Black;
            treeNode1.Name = "A1";
            treeNode1.Text = "Yes. Via \'Reset your pasword\', copy & paste the token you received in your email " +
    "and fill in your new password.";
            treeNode2.ForeColor = System.Drawing.Color.Teal;
            treeNode2.Name = "Q1";
            treeNode2.Text = "Is it possible to change my password?";
            treeNode3.ForeColor = System.Drawing.Color.Black;
            treeNode3.Name = "A2";
            treeNode3.Text = "Yes. On the page \'User management\' fill in the email address of the user you want" +
    " to search for.";
            treeNode4.ForeColor = System.Drawing.Color.Teal;
            treeNode4.Name = "Q2";
            treeNode4.Text = "Can I search for a user?";
            treeNode5.ForeColor = System.Drawing.Color.Black;
            treeNode5.Name = "A3";
            treeNode5.Text = "No. You have to know the his/her email address.";
            treeNode6.ForeColor = System.Drawing.Color.Teal;
            treeNode6.Name = "Q3";
            treeNode6.Text = "Is it possible to search for a user if you don\'t know his/her email address?";
            treeNode7.ForeColor = System.Drawing.Color.Black;
            treeNode7.Name = "A4";
            treeNode7.Text = "Yes. Send in your question, and we\'ll get back to you as soon as possible.";
            treeNode8.ForeColor = System.Drawing.Color.Teal;
            treeNode8.Name = "Q4";
            treeNode8.Text = "Can I ask a question that isn\'t mentioned above?";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode4,
            treeNode6,
            treeNode8});
            this.treeView1.Size = new System.Drawing.Size(1031, 398);
            this.treeView1.TabIndex = 3;
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddQuestion.BackColor = System.Drawing.Color.GreenYellow;
            this.btnAddQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddQuestion.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddQuestion.Location = new System.Drawing.Point(996, 50);
            this.btnAddQuestion.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(221, 58);
            this.btnAddQuestion.TabIndex = 2;
            this.btnAddQuestion.Text = "Add new question";
            this.btnAddQuestion.UseVisualStyleBackColor = false;
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "FAQ";
            // 
            // FAQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1276, 798);
            this.Controls.Add(this.panel1);
            this.Name = "FAQ";
            this.Text = "FAQ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.TreeView treeView1;
    }
}