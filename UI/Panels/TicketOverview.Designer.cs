namespace UI.Pages
{
    partial class TicketOverview
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtbEmailFilter = new System.Windows.Forms.TextBox();
            this.btnCreateTicket = new System.Windows.Forms.Button();
            this.lvUnresolvedTickets = new System.Windows.Forms.ListView();
            this.clmID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSubject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LvResovledTickets = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.LvResovledTickets, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lvUnresolvedTickets, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(989, 739);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(3, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(361, 51);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Overview tickets";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.8159F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.1841F));
            this.tableLayoutPanel2.Controls.Add(this.txtbEmailFilter, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnCreateTicket, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 76);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(983, 67);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // txtbEmailFilter
            // 
            this.txtbEmailFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbEmailFilter.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbEmailFilter.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtbEmailFilter.Location = new System.Drawing.Point(3, 3);
            this.txtbEmailFilter.Name = "txtbEmailFilter";
            this.txtbEmailFilter.Size = new System.Drawing.Size(444, 30);
            this.txtbEmailFilter.TabIndex = 0;
            this.txtbEmailFilter.Text = "Filter by name";
            this.txtbEmailFilter.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtbEmailFilter_MouseClick);
            this.txtbEmailFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbEmailFilter_KeyDown);
            // 
            // btnCreateTicket
            // 
            this.btnCreateTicket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateTicket.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCreateTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateTicket.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTicket.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCreateTicket.Location = new System.Drawing.Point(814, 3);
            this.btnCreateTicket.Name = "btnCreateTicket";
            this.btnCreateTicket.Size = new System.Drawing.Size(166, 47);
            this.btnCreateTicket.TabIndex = 1;
            this.btnCreateTicket.Text = "CREATE INCIDENT";
            this.btnCreateTicket.UseVisualStyleBackColor = false;
            this.btnCreateTicket.Click += new System.EventHandler(this.btnCreateTicket_Click);
            // 
            // lvUnresolvedTickets
            // 
            this.lvUnresolvedTickets.BackColor = System.Drawing.SystemColors.Info;
            this.lvUnresolvedTickets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmID,
            this.clmSubject,
            this.clmUser,
            this.clmDate,
            this.clmStatus});
            this.lvUnresolvedTickets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvUnresolvedTickets.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvUnresolvedTickets.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lvUnresolvedTickets.FullRowSelect = true;
            this.lvUnresolvedTickets.GridLines = true;
            this.lvUnresolvedTickets.HideSelection = false;
            this.lvUnresolvedTickets.Location = new System.Drawing.Point(3, 149);
            this.lvUnresolvedTickets.Name = "lvUnresolvedTickets";
            this.lvUnresolvedTickets.Size = new System.Drawing.Size(983, 289);
            this.lvUnresolvedTickets.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.lvUnresolvedTickets.TabIndex = 2;
            this.lvUnresolvedTickets.UseCompatibleStateImageBehavior = false;
            this.lvUnresolvedTickets.View = System.Windows.Forms.View.Details;
            this.lvUnresolvedTickets.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvTickets_MouseDoubleClick);
            // 
            // clmID
            // 
            this.clmID.Text = "ID";
            // 
            // clmSubject
            // 
            this.clmSubject.Text = "Subject";
            this.clmSubject.Width = 300;
            // 
            // clmUser
            // 
            this.clmUser.Text = "First Name";
            this.clmUser.Width = 250;
            // 
            // clmDate
            // 
            this.clmDate.Text = "Date";
            this.clmDate.Width = 250;
            // 
            // clmStatus
            // 
            this.clmStatus.Text = "Status";
            this.clmStatus.Width = 117;
            // 
            // LvResovledTickets
            // 
            this.LvResovledTickets.BackColor = System.Drawing.SystemColors.Info;
            this.LvResovledTickets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.LvResovledTickets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LvResovledTickets.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LvResovledTickets.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LvResovledTickets.FullRowSelect = true;
            this.LvResovledTickets.GridLines = true;
            this.LvResovledTickets.HideSelection = false;
            this.LvResovledTickets.Location = new System.Drawing.Point(3, 444);
            this.LvResovledTickets.Name = "LvResovledTickets";
            this.LvResovledTickets.Size = new System.Drawing.Size(983, 292);
            this.LvResovledTickets.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.LvResovledTickets.TabIndex = 3;
            this.LvResovledTickets.UseCompatibleStateImageBehavior = false;
            this.LvResovledTickets.View = System.Windows.Forms.View.Details;
            this.LvResovledTickets.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LvResovledTickets_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Subject";
            this.columnHeader2.Width = 300;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "First Name";
            this.columnHeader3.Width = 250;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Date";
            this.columnHeader4.Width = 250;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Status";
            this.columnHeader5.Width = 119;
            // 
            // TicketOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(989, 739);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Enabled = false;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TicketOverview";
            this.Text = "TicketOverview";
            this.VisibleChanged += new System.EventHandler(this.TicketOverview_VisibleChanged);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtbEmailFilter;
        private System.Windows.Forms.Button btnCreateTicket;
        private System.Windows.Forms.ListView lvUnresolvedTickets;
        private System.Windows.Forms.ColumnHeader clmID;
        private System.Windows.Forms.ColumnHeader clmSubject;
        private System.Windows.Forms.ColumnHeader clmUser;
        private System.Windows.Forms.ColumnHeader clmDate;
        private System.Windows.Forms.ColumnHeader clmStatus;
        private System.Windows.Forms.ListView LvResovledTickets;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}