namespace HybridNeuralNetwork
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.c_SetUpMonitoringToolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.c_RunMonitoringMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.c_StopMonitoringMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.c_OpenMonitoringLogMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.c_ExitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.l_CurrentNetworkPerformance = new System.Windows.Forms.Label();
            this.l_NetworkStatus = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.t_NetworkStatusPanel = new System.Windows.Forms.TableLayoutPanel();
            this.d_InputTable = new System.Windows.Forms.DataGridView();
            this.с_InputNameColunm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_DateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_InputValueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_NetworkStatusPanel = new System.Windows.Forms.Panel();
            this.c_Graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.p_MonitoringStatusPanel = new System.Windows.Forms.Panel();
            this.menuStripMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.t_NetworkStatusPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.d_InputTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_Graph)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.AutoSize = false;
            this.menuStripMain.BackColor = System.Drawing.Color.White;
            this.menuStripMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.menuStripMain.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.c_SetUpMonitoringToolsMenu,
            this.c_RunMonitoringMenu,
            this.c_StopMonitoringMenu,
            this.c_OpenMonitoringLogMenu,
            this.c_ExitMenu});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(784, 40);
            this.menuStripMain.TabIndex = 3;
            this.menuStripMain.Text = "menuStripMain";
            // 
            // c_SetUpMonitoringToolsMenu
            // 
            this.c_SetUpMonitoringToolsMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.c_SetUpMonitoringToolsMenu.ForeColor = System.Drawing.Color.Black;
            this.c_SetUpMonitoringToolsMenu.Image = ((System.Drawing.Image)(resources.GetObject("c_SetUpMonitoringToolsMenu.Image")));
            this.c_SetUpMonitoringToolsMenu.ImageTransparentColor = System.Drawing.Color.White;
            this.c_SetUpMonitoringToolsMenu.Name = "c_SetUpMonitoringToolsMenu";
            this.c_SetUpMonitoringToolsMenu.Size = new System.Drawing.Size(176, 36);
            this.c_SetUpMonitoringToolsMenu.Text = "Set up monitoring tools";
            this.c_SetUpMonitoringToolsMenu.Click += new System.EventHandler(this.c_SetUpMonitoringToolsMenu_Click);
            // 
            // c_RunMonitoringMenu
            // 
            this.c_RunMonitoringMenu.Image = ((System.Drawing.Image)(resources.GetObject("c_RunMonitoringMenu.Image")));
            this.c_RunMonitoringMenu.ImageTransparentColor = System.Drawing.Color.White;
            this.c_RunMonitoringMenu.Name = "c_RunMonitoringMenu";
            this.c_RunMonitoringMenu.Size = new System.Drawing.Size(128, 36);
            this.c_RunMonitoringMenu.Text = "Run monitoring";
            this.c_RunMonitoringMenu.Click += new System.EventHandler(this.c_RunMonitoringMenu_Click);
            // 
            // c_StopMonitoringMenu
            // 
            this.c_StopMonitoringMenu.Image = ((System.Drawing.Image)(resources.GetObject("c_StopMonitoringMenu.Image")));
            this.c_StopMonitoringMenu.ImageTransparentColor = System.Drawing.Color.White;
            this.c_StopMonitoringMenu.Name = "c_StopMonitoringMenu";
            this.c_StopMonitoringMenu.Size = new System.Drawing.Size(133, 36);
            this.c_StopMonitoringMenu.Text = "Stop monitoring";
            this.c_StopMonitoringMenu.Click += new System.EventHandler(this.c_StopMonitoringMenu_Click);
            // 
            // c_OpenMonitoringLogMenu
            // 
            this.c_OpenMonitoringLogMenu.Image = ((System.Drawing.Image)(resources.GetObject("c_OpenMonitoringLogMenu.Image")));
            this.c_OpenMonitoringLogMenu.ImageTransparentColor = System.Drawing.Color.White;
            this.c_OpenMonitoringLogMenu.Name = "c_OpenMonitoringLogMenu";
            this.c_OpenMonitoringLogMenu.Size = new System.Drawing.Size(160, 36);
            this.c_OpenMonitoringLogMenu.Text = "Open monitoring log";
            this.c_OpenMonitoringLogMenu.Click += new System.EventHandler(this.c_OpenMonitoringLogMenu_Click);
            // 
            // c_ExitMenu
            // 
            this.c_ExitMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.c_ExitMenu.ForeColor = System.Drawing.Color.Black;
            this.c_ExitMenu.Image = ((System.Drawing.Image)(resources.GetObject("c_ExitMenu.Image")));
            this.c_ExitMenu.ImageTransparentColor = System.Drawing.Color.White;
            this.c_ExitMenu.Name = "c_ExitMenu";
            this.c_ExitMenu.Size = new System.Drawing.Size(60, 36);
            this.c_ExitMenu.Text = "Exit";
            this.c_ExitMenu.Click += new System.EventHandler(this.c_ExitMenu_Click);
            // 
            // l_CurrentNetworkPerformance
            // 
            this.l_CurrentNetworkPerformance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(209)))));
            this.l_CurrentNetworkPerformance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_CurrentNetworkPerformance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_CurrentNetworkPerformance.ForeColor = System.Drawing.Color.White;
            this.l_CurrentNetworkPerformance.Location = new System.Drawing.Point(3, 0);
            this.l_CurrentNetworkPerformance.Name = "l_CurrentNetworkPerformance";
            this.l_CurrentNetworkPerformance.Size = new System.Drawing.Size(386, 30);
            this.l_CurrentNetworkPerformance.TabIndex = 4;
            this.l_CurrentNetworkPerformance.Text = "Current network performance";
            this.l_CurrentNetworkPerformance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l_NetworkStatus
            // 
            this.l_NetworkStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(209)))));
            this.l_NetworkStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_NetworkStatus.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_NetworkStatus.ForeColor = System.Drawing.Color.White;
            this.l_NetworkStatus.Location = new System.Drawing.Point(395, 0);
            this.l_NetworkStatus.Name = "l_NetworkStatus";
            this.l_NetworkStatus.Size = new System.Drawing.Size(386, 30);
            this.l_NetworkStatus.TabIndex = 5;
            this.l_NetworkStatus.Text = "Network status";
            this.l_NetworkStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.l_NetworkStatus.Paint += new System.Windows.Forms.PaintEventHandler(this.l_NetworkStatus_Paint);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.l_CurrentNetworkPerformance, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.l_NetworkStatus, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 40);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 30);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(241)))), ((int)(((byte)(250)))));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.t_NetworkStatusPanel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.c_Graph, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 70);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.58859F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.41141F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(784, 491);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // t_NetworkStatusPanel
            // 
            this.t_NetworkStatusPanel.ColumnCount = 2;
            this.t_NetworkStatusPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.t_NetworkStatusPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.t_NetworkStatusPanel.Controls.Add(this.d_InputTable, 0, 0);
            this.t_NetworkStatusPanel.Controls.Add(this.p_NetworkStatusPanel, 1, 0);
            this.t_NetworkStatusPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.t_NetworkStatusPanel.Location = new System.Drawing.Point(0, 0);
            this.t_NetworkStatusPanel.Margin = new System.Windows.Forms.Padding(0);
            this.t_NetworkStatusPanel.Name = "t_NetworkStatusPanel";
            this.t_NetworkStatusPanel.RowCount = 1;
            this.t_NetworkStatusPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.t_NetworkStatusPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 182F));
            this.t_NetworkStatusPanel.Size = new System.Drawing.Size(784, 105);
            this.t_NetworkStatusPanel.TabIndex = 0;
            // 
            // d_InputTable
            // 
            this.d_InputTable.AllowUserToAddRows = false;
            this.d_InputTable.AllowUserToDeleteRows = false;
            this.d_InputTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.d_InputTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.d_InputTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(241)))), ((int)(((byte)(250)))));
            this.d_InputTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.d_InputTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(241)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.d_InputTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.d_InputTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.d_InputTable.ColumnHeadersVisible = false;
            this.d_InputTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.с_InputNameColunm,
            this.c_DateColumn,
            this.c_InputValueColumn});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(241)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.d_InputTable.DefaultCellStyle = dataGridViewCellStyle4;
            this.d_InputTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.d_InputTable.EnableHeadersVisualStyles = false;
            this.d_InputTable.Location = new System.Drawing.Point(3, 0);
            this.d_InputTable.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.d_InputTable.Name = "d_InputTable";
            this.d_InputTable.RowHeadersVisible = false;
            this.d_InputTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.d_InputTable.Size = new System.Drawing.Size(386, 105);
            this.d_InputTable.TabIndex = 4;
            // 
            // с_InputNameColunm
            // 
            this.с_InputNameColunm.HeaderText = "Имя входного параметра";
            this.с_InputNameColunm.Name = "с_InputNameColunm";
            this.с_InputNameColunm.ReadOnly = true;
            // 
            // c_DateColumn
            // 
            this.c_DateColumn.HeaderText = "Время";
            this.c_DateColumn.Name = "c_DateColumn";
            this.c_DateColumn.ReadOnly = true;
            // 
            // c_InputValueColumn
            // 
            this.c_InputValueColumn.HeaderText = "Значение входного параметра";
            this.c_InputValueColumn.Name = "c_InputValueColumn";
            // 
            // p_NetworkStatusPanel
            // 
            this.p_NetworkStatusPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(241)))), ((int)(((byte)(250)))));
            this.p_NetworkStatusPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_NetworkStatusPanel.Location = new System.Drawing.Point(392, 0);
            this.p_NetworkStatusPanel.Margin = new System.Windows.Forms.Padding(0);
            this.p_NetworkStatusPanel.Name = "p_NetworkStatusPanel";
            this.p_NetworkStatusPanel.Size = new System.Drawing.Size(392, 105);
            this.p_NetworkStatusPanel.TabIndex = 5;
            this.p_NetworkStatusPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.p_NetworkStatusPanel_Paint);
            // 
            // c_Graph
            // 
            this.c_Graph.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(241)))), ((int)(((byte)(250)))));
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea2.Name = "ChartArea1";
            this.c_Graph.ChartAreas.Add(chartArea2);
            this.c_Graph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c_Graph.Location = new System.Drawing.Point(3, 108);
            this.c_Graph.Name = "c_Graph";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series2.Color = System.Drawing.Color.Black;
            series2.Legend = "Legend1";
            series2.MarkerBorderWidth = 2;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series2.Name = "Values";
            series2.YValuesPerPoint = 2;
            this.c_Graph.Series.Add(series2);
            this.c_Graph.Size = new System.Drawing.Size(778, 380);
            this.c_Graph.TabIndex = 1;
            this.c_Graph.Text = "chart1";
            title2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(209)))));
            title2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title2.ForeColor = System.Drawing.Color.White;
            title2.Name = "Title1";
            title2.Text = "Network status in time (Y = 1 - Normal work; Y = 2 - Overload; Y = 3 - Failure)";
            this.c_Graph.Titles.Add(title2);
            // 
            // p_MonitoringStatusPanel
            // 
            this.p_MonitoringStatusPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.p_MonitoringStatusPanel.BackColor = System.Drawing.Color.White;
            this.p_MonitoringStatusPanel.Location = new System.Drawing.Point(714, 0);
            this.p_MonitoringStatusPanel.Name = "p_MonitoringStatusPanel";
            this.p_MonitoringStatusPanel.Size = new System.Drawing.Size(70, 40);
            this.p_MonitoringStatusPanel.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(241)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.p_MonitoringStatusPanel);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStripMain);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monitoring technology data network";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.t_NetworkStatusPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.d_InputTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_Graph)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem c_SetUpMonitoringToolsMenu;
        private System.Windows.Forms.ToolStripMenuItem c_RunMonitoringMenu;
        private System.Windows.Forms.ToolStripMenuItem c_StopMonitoringMenu;
        private System.Windows.Forms.ToolStripMenuItem c_ExitMenu;
        private System.Windows.Forms.ToolStripMenuItem c_OpenMonitoringLogMenu;
        private System.Windows.Forms.Label l_CurrentNetworkPerformance;
        private System.Windows.Forms.Label l_NetworkStatus;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel t_NetworkStatusPanel;
        private System.Windows.Forms.DataGridView d_InputTable;
        private System.Windows.Forms.Panel p_NetworkStatusPanel;
        private System.Windows.Forms.Panel p_MonitoringStatusPanel;
        private System.Windows.Forms.DataVisualization.Charting.Chart c_Graph;
        private System.Windows.Forms.DataGridViewTextBoxColumn с_InputNameColunm;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_DateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_InputValueColumn;
    }
}

