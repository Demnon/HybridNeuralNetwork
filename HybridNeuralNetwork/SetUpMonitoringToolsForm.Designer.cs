namespace HybridNeuralNetwork
{
    partial class SetUpMonitoringToolsForm
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.b_Close = new System.Windows.Forms.Button();
            this.b_Train = new System.Windows.Forms.Button();
            this.t_TrainingLog = new System.Windows.Forms.TextBox();
            this.l_CurrentNetworkPerformance = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.c_GraphAbsErrors = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.c_GraphPerfErrors = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.t_Error = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c_GraphAbsErrors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_GraphPerfErrors)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // b_Close
            // 
            this.b_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(209)))));
            this.b_Close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b_Close.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_Close.ForeColor = System.Drawing.Color.White;
            this.b_Close.Location = new System.Drawing.Point(674, 621);
            this.b_Close.Margin = new System.Windows.Forms.Padding(3, 3, 10, 10);
            this.b_Close.Name = "b_Close";
            this.b_Close.Size = new System.Drawing.Size(100, 30);
            this.b_Close.TabIndex = 15;
            this.b_Close.Text = "Close";
            this.b_Close.UseVisualStyleBackColor = false;
            this.b_Close.Click += new System.EventHandler(this.b_Close_Click);
            // 
            // b_Train
            // 
            this.b_Train.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.b_Train.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(209)))));
            this.b_Train.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b_Train.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_Train.ForeColor = System.Drawing.Color.White;
            this.b_Train.Location = new System.Drawing.Point(145, 4);
            this.b_Train.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.b_Train.Name = "b_Train";
            this.b_Train.Size = new System.Drawing.Size(143, 30);
            this.b_Train.TabIndex = 16;
            this.b_Train.Text = "Train neural network";
            this.b_Train.UseVisualStyleBackColor = false;
            this.b_Train.Click += new System.EventHandler(this.b_Train_Click);
            // 
            // t_TrainingLog
            // 
            this.t_TrainingLog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.t_TrainingLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(236)))), ((int)(((byte)(250)))));
            this.t_TrainingLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.t_TrainingLog.Location = new System.Drawing.Point(122, 33);
            this.t_TrainingLog.Margin = new System.Windows.Forms.Padding(0);
            this.t_TrainingLog.Multiline = true;
            this.t_TrainingLog.Name = "t_TrainingLog";
            this.t_TrainingLog.ReadOnly = true;
            this.t_TrainingLog.Size = new System.Drawing.Size(539, 96);
            this.t_TrainingLog.TabIndex = 17;
            // 
            // l_CurrentNetworkPerformance
            // 
            this.l_CurrentNetworkPerformance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l_CurrentNetworkPerformance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(241)))), ((int)(((byte)(250)))));
            this.l_CurrentNetworkPerformance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_CurrentNetworkPerformance.ForeColor = System.Drawing.Color.Black;
            this.l_CurrentNetworkPerformance.Location = new System.Drawing.Point(323, 1);
            this.l_CurrentNetworkPerformance.Name = "l_CurrentNetworkPerformance";
            this.l_CurrentNetworkPerformance.Size = new System.Drawing.Size(138, 30);
            this.l_CurrentNetworkPerformance.TabIndex = 18;
            this.l_CurrentNetworkPerformance.Text = "Training log";
            this.l_CurrentNetworkPerformance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.c_GraphAbsErrors, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.c_GraphPerfErrors, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.l_CurrentNetworkPerformance, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.b_Close, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.t_TrainingLog, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.143722F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.67474F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.900151F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.34191F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.73676F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.354009F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 661);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // c_GraphAbsErrors
            // 
            this.c_GraphAbsErrors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(241)))), ((int)(((byte)(250)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea1.Name = "ChartArea1";
            this.c_GraphAbsErrors.ChartAreas.Add(chartArea1);
            this.c_GraphAbsErrors.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.DockedToChartArea = "ChartArea1";
            legend1.Name = "Legend1";
            this.c_GraphAbsErrors.Legends.Add(legend1);
            this.c_GraphAbsErrors.Location = new System.Drawing.Point(3, 396);
            this.c_GraphAbsErrors.Name = "c_GraphAbsErrors";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Blue;
            series1.Legend = "Legend1";
            series1.MarkerBorderWidth = 2;
            series1.Name = "Delay time, ms";
            series1.YValuesPerPoint = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Red;
            series2.Legend = "Legend1";
            series2.MarkerBorderWidth = 2;
            series2.Name = "Average transfer speed, bps";
            this.c_GraphAbsErrors.Series.Add(series1);
            this.c_GraphAbsErrors.Series.Add(series2);
            this.c_GraphAbsErrors.Size = new System.Drawing.Size(778, 216);
            this.c_GraphAbsErrors.TabIndex = 21;
            this.c_GraphAbsErrors.Text = "chart1";
            title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(241)))), ((int)(((byte)(250)))));
            title1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.Name = "Title1";
            title1.Text = "Absolute errors after training";
            this.c_GraphAbsErrors.Titles.Add(title1);
            // 
            // c_GraphPerfErrors
            // 
            this.c_GraphPerfErrors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(241)))), ((int)(((byte)(250)))));
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea2.Name = "ChartArea1";
            this.c_GraphPerfErrors.ChartAreas.Add(chartArea2);
            this.c_GraphPerfErrors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c_GraphPerfErrors.Location = new System.Drawing.Point(3, 170);
            this.c_GraphPerfErrors.Name = "c_GraphPerfErrors";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Black;
            series3.Legend = "Legend1";
            series3.MarkerBorderWidth = 2;
            series3.Name = "Values";
            series3.YValuesPerPoint = 2;
            this.c_GraphPerfErrors.Series.Add(series3);
            this.c_GraphPerfErrors.Size = new System.Drawing.Size(778, 220);
            this.c_GraphPerfErrors.TabIndex = 20;
            this.c_GraphPerfErrors.Text = "chart1";
            title2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(241)))), ((int)(((byte)(250)))));
            title2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title2.Name = "Title1";
            title2.Text = "Performance errors during training";
            this.c_GraphPerfErrors.Titles.Add(title2);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.0102F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.38775F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.47449F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.b_Train, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.t_Error, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 129);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(784, 38);
            this.tableLayoutPanel2.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(241)))), ((int)(((byte)(250)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(301, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 30);
            this.label1.TabIndex = 19;
            this.label1.Text = "Average learning error:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // t_Error
            // 
            this.t_Error.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.t_Error.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(236)))), ((int)(((byte)(250)))));
            this.t_Error.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.t_Error.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.t_Error.Location = new System.Drawing.Point(460, 6);
            this.t_Error.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.t_Error.Name = "t_Error";
            this.t_Error.ReadOnly = true;
            this.t_Error.Size = new System.Drawing.Size(180, 26);
            this.t_Error.TabIndex = 17;
            this.t_Error.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SetUpMonitoringToolsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(241)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetUpMonitoringToolsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Set up monitoring tools";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c_GraphAbsErrors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_GraphPerfErrors)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_Close;
        private System.Windows.Forms.Button b_Train;
        private System.Windows.Forms.TextBox t_TrainingLog;
        private System.Windows.Forms.Label l_CurrentNetworkPerformance;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox t_Error;
        private System.Windows.Forms.DataVisualization.Charting.Chart c_GraphPerfErrors;
        private System.Windows.Forms.DataVisualization.Charting.Chart c_GraphAbsErrors;
    }
}