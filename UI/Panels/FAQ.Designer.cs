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
            this.panel1 = new System.Windows.Forms.Panel();
            this.treeViewFAQSoftware = new System.Windows.Forms.TreeView();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.treeViewFAQHardware = new System.Windows.Forms.TreeView();
            this.treeViewFAQService = new System.Windows.Forms.TreeView();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.treeViewFAQService);
            this.panel1.Controls.Add(this.treeViewFAQHardware);
            this.panel1.Controls.Add(this.treeViewFAQSoftware);
            this.panel1.Controls.Add(this.btnAddQuestion);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 482);
            this.panel1.TabIndex = 0;
            // 
            // treeViewFAQSoftware
            // 
            this.treeViewFAQSoftware.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.treeViewFAQSoftware.Location = new System.Drawing.Point(31, 153);
            this.treeViewFAQSoftware.Name = "treeViewFAQSoftware";
            this.treeViewFAQSoftware.Size = new System.Drawing.Size(269, 314);
            this.treeViewFAQSoftware.TabIndex = 3;
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddQuestion.BackColor = System.Drawing.Color.GreenYellow;
            this.btnAddQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddQuestion.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddQuestion.Location = new System.Drawing.Point(763, 41);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(166, 47);
            this.btnAddQuestion.TabIndex = 2;
            this.btnAddQuestion.Text = "Add new question";
            this.btnAddQuestion.UseVisualStyleBackColor = false;
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "FAQ";
            // 
            // treeViewFAQHardware
            // 
            this.treeViewFAQHardware.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.treeViewFAQHardware.Location = new System.Drawing.Point(352, 153);
            this.treeViewFAQHardware.Name = "treeViewFAQHardware";
            this.treeViewFAQHardware.Size = new System.Drawing.Size(269, 314);
            this.treeViewFAQHardware.TabIndex = 4;
            // 
            // treeViewFAQService
            // 
            this.treeViewFAQService.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.treeViewFAQService.Location = new System.Drawing.Point(660, 153);
            this.treeViewFAQService.Name = "treeViewFAQService";
            this.treeViewFAQService.Size = new System.Drawing.Size(269, 314);
            this.treeViewFAQService.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(36, 125);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(257, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Questions about software";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(356, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Questions about hardware";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(665, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Questions about services";
            // 
            // FAQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1001, 499);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FAQ";
            this.Text = "FAQ";
            this.VisibleChanged += new System.EventHandler(this.FAQ_VisibleChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.TreeView treeViewFAQSoftware;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TreeView treeViewFAQService;
        private System.Windows.Forms.TreeView treeViewFAQHardware;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}