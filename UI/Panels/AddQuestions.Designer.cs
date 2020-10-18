namespace UI.Panels
{
    partial class AddQuestions
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
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_SendFaqQuestion = new System.Windows.Forms.Button();
            this.rtb_AddFaqQuestion = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnl_AddQuestions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_AddQuestions
            // 
            this.pnl_AddQuestions.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_AddQuestions.Controls.Add(this.btnCancel);
            this.pnl_AddQuestions.Controls.Add(this.txt_Email);
            this.pnl_AddQuestions.Controls.Add(this.label2);
            this.pnl_AddQuestions.Controls.Add(this.btn_SendFaqQuestion);
            this.pnl_AddQuestions.Controls.Add(this.rtb_AddFaqQuestion);
            this.pnl_AddQuestions.Controls.Add(this.label1);
            this.pnl_AddQuestions.Location = new System.Drawing.Point(12, 12);
            this.pnl_AddQuestions.Name = "pnl_AddQuestions";
            this.pnl_AddQuestions.Size = new System.Drawing.Size(1262, 785);
            this.pnl_AddQuestions.TabIndex = 0;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(214, 191);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(287, 22);
            this.txt_Email.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 29);
            this.label2.TabIndex = 20;
            this.label2.Text = "E-mail:";
            // 
            // btn_SendFaqQuestion
            // 
            this.btn_SendFaqQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_SendFaqQuestion.ForeColor = System.Drawing.Color.Black;
            this.btn_SendFaqQuestion.Location = new System.Drawing.Point(809, 655);
            this.btn_SendFaqQuestion.Name = "btn_SendFaqQuestion";
            this.btn_SendFaqQuestion.Size = new System.Drawing.Size(177, 63);
            this.btn_SendFaqQuestion.TabIndex = 19;
            this.btn_SendFaqQuestion.Text = "SEND";
            this.btn_SendFaqQuestion.UseVisualStyleBackColor = false;
            this.btn_SendFaqQuestion.Click += new System.EventHandler(this.btn_SendFaqQuestion_Click);
            // 
            // rtb_AddFaqQuestion
            // 
            this.rtb_AddFaqQuestion.Location = new System.Drawing.Point(73, 270);
            this.rtb_AddFaqQuestion.Name = "rtb_AddFaqQuestion";
            this.rtb_AddFaqQuestion.Size = new System.Drawing.Size(913, 313);
            this.rtb_AddFaqQuestion.TabIndex = 1;
            this.rtb_AddFaqQuestion.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add new question";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(75, 655);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(177, 63);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1286, 795);
            this.Controls.Add(this.pnl_AddQuestions);
            this.Name = "AddQuestions";
            this.Text = "Add questions";
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
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Button btnCancel;
    }
}