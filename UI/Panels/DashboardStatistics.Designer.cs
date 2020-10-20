namespace UI.Pages
{
    partial class DashboardStatistics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnShowList = new System.Windows.Forms.Button();
            this.chResolvedUnresolvedTickets = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chPastDeadline = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chResolvedUnresolvedTickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chPastDeadline)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnShowList, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.chResolvedUnresolvedTickets, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.chPastDeadline, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(962, 716);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(579, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "On time/past deadline tickets";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(3, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(377, 51);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Current incidents";
            // 
            // btnShowList
            // 
            this.btnShowList.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnShowList.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnShowList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowList.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowList.ForeColor = System.Drawing.SystemColors.Control;
            this.btnShowList.Location = new System.Drawing.Point(805, 25);
            this.btnShowList.Name = "btnShowList";
            this.btnShowList.Size = new System.Drawing.Size(154, 57);
            this.btnShowList.TabIndex = 1;
            this.btnShowList.Text = "SHOW LIST";
            this.btnShowList.UseVisualStyleBackColor = false;
            this.btnShowList.Click += new System.EventHandler(this.btnShowList_Click);
            // 
            // chResolvedUnresolvedTickets
            // 
            this.chResolvedUnresolvedTickets.BorderlineColor = System.Drawing.Color.Peru;
            this.chResolvedUnresolvedTickets.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chResolvedUnresolvedTickets.BorderlineWidth = 2;
            chartArea1.Name = "ChartArea1";
            this.chResolvedUnresolvedTickets.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chResolvedUnresolvedTickets.Legends.Add(legend1);
            this.chResolvedUnresolvedTickets.Location = new System.Drawing.Point(3, 181);
            this.chResolvedUnresolvedTickets.Name = "chResolvedUnresolvedTickets";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "unresolved-resolved-tickets";
            this.chResolvedUnresolvedTickets.Series.Add(series1);
            this.chResolvedUnresolvedTickets.Size = new System.Drawing.Size(475, 390);
            this.chResolvedUnresolvedTickets.TabIndex = 4;
            this.chResolvedUnresolvedTickets.Tag = "";
            this.chResolvedUnresolvedTickets.Text = "Unresolved/Resolved tickets";
            // 
            // chPastDeadline
            // 
            this.chPastDeadline.BorderlineColor = System.Drawing.Color.Maroon;
            this.chPastDeadline.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chPastDeadline.BorderlineWidth = 2;
            this.chPastDeadline.BorderSkin.BorderColor = System.Drawing.Color.DarkRed;
            this.chPastDeadline.BorderSkin.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.Name = "ChartArea1";
            this.chPastDeadline.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chPastDeadline.Legends.Add(legend2);
            this.chPastDeadline.Location = new System.Drawing.Point(484, 181);
            this.chPastDeadline.Name = "chPastDeadline";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Legend = "Legend1";
            series2.Name = "pastDeadline";
            this.chPastDeadline.Series.Add(series2);
            this.chPastDeadline.Size = new System.Drawing.Size(475, 390);
            this.chPastDeadline.TabIndex = 5;
            this.chPastDeadline.Text = "Past deadline/On time tickets";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(101, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Unresolved/Resolved tickets";
            // 
            // DashboardStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(962, 716);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DashboardStatistics";
            this.Text = "DashboardStatistics";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chResolvedUnresolvedTickets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chPastDeadline)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnShowList;
        private System.Windows.Forms.DataVisualization.Charting.Chart chResolvedUnresolvedTickets;
        private System.Windows.Forms.DataVisualization.Charting.Chart chPastDeadline;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}