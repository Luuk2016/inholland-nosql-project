namespace UI.Panels
{
    partial class AddFAQItem
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
            this.pnl_AddQuestions = new System.Windows.Forms.Panel();
            this.rtb_AddFaqAnswer = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_Category = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_SendFaqQuestion = new System.Windows.Forms.Button();
            this.rtb_AddFaqQuestion = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_AddQuestions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_AddQuestions
            // 
            this.pnl_AddQuestions.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_AddQuestions.Controls.Add(this.rtb_AddFaqAnswer);
            this.pnl_AddQuestions.Controls.Add(this.label4);
            this.pnl_AddQuestions.Controls.Add(this.label3);
            this.pnl_AddQuestions.Controls.Add(this.cmb_Category);
            this.pnl_AddQuestions.Controls.Add(this.btnCancel);
            this.pnl_AddQuestions.Controls.Add(this.label2);
            this.pnl_AddQuestions.Controls.Add(this.btn_SendFaqQuestion);
            this.pnl_AddQuestions.Controls.Add(this.rtb_AddFaqQuestion);
            this.pnl_AddQuestions.Controls.Add(this.label1);
            this.pnl_AddQuestions.Location = new System.Drawing.Point(3, 11);
            this.pnl_AddQuestions.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_AddQuestions.Name = "pnl_AddQuestions";
            this.pnl_AddQuestions.Size = new System.Drawing.Size(568, 377);
            this.pnl_AddQuestions.TabIndex = 0;
            // 
            // rtb_AddFaqAnswer
            // 
            this.rtb_AddFaqAnswer.Location = new System.Drawing.Point(140, 177);
            this.rtb_AddFaqAnswer.Margin = new System.Windows.Forms.Padding(2);
            this.rtb_AddFaqAnswer.Name = "rtb_AddFaqAnswer";
            this.rtb_AddFaqAnswer.Size = new System.Drawing.Size(351, 125);
            this.rtb_AddFaqAnswer.TabIndex = 26;
            this.rtb_AddFaqAnswer.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(30, 177);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "Answer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "Question:";
            // 
            // cmb_Category
            // 
            this.cmb_Category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Category.FormattingEnabled = true;
            this.cmb_Category.Items.AddRange(new object[] {
            "Software",
            "Hardware",
            "Service"});
            this.cmb_Category.Location = new System.Drawing.Point(140, 74);
            this.cmb_Category.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_Category.Name = "cmb_Category";
            this.cmb_Category.Size = new System.Drawing.Size(133, 21);
            this.cmb_Category.TabIndex = 23;
            this.cmb_Category.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_Category_KeyPress);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(221, 306);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(133, 51);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Category:";
            // 
            // btn_SendFaqQuestion
            // 
            this.btn_SendFaqQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_SendFaqQuestion.ForeColor = System.Drawing.Color.Black;
            this.btn_SendFaqQuestion.Location = new System.Drawing.Point(358, 306);
            this.btn_SendFaqQuestion.Margin = new System.Windows.Forms.Padding(2);
            this.btn_SendFaqQuestion.Name = "btn_SendFaqQuestion";
            this.btn_SendFaqQuestion.Size = new System.Drawing.Size(133, 51);
            this.btn_SendFaqQuestion.TabIndex = 19;
            this.btn_SendFaqQuestion.Text = "SEND";
            this.btn_SendFaqQuestion.UseVisualStyleBackColor = false;
            this.btn_SendFaqQuestion.Click += new System.EventHandler(this.btn_SendFaqQuestion_Click);
            // 
            // rtb_AddFaqQuestion
            // 
            this.rtb_AddFaqQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_AddFaqQuestion.Location = new System.Drawing.Point(140, 120);
            this.rtb_AddFaqQuestion.Margin = new System.Windows.Forms.Padding(2);
            this.rtb_AddFaqQuestion.Name = "rtb_AddFaqQuestion";
            this.rtb_AddFaqQuestion.Size = new System.Drawing.Size(351, 33);
            this.rtb_AddFaqQuestion.TabIndex = 1;
            this.rtb_AddFaqQuestion.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(523, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add a new item to the FAQ";
            // 
            // AddFAQItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(577, 391);
            this.Controls.Add(this.pnl_AddQuestions);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddFAQItem";
            this.Text = "Add a FAQ item";
            this.pnl_AddQuestions.ResumeLayout(false);
            this.pnl_AddQuestions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_AddQuestions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtb_AddFaqQuestion;
        private System.Windows.Forms.Button btn_SendFaqQuestion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RichTextBox rtb_AddFaqAnswer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_Category;
    }
}