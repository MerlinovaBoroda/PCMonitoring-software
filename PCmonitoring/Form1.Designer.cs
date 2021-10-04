
namespace PCmonitoring
{
    partial class Monitoring
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Monitoring));
            this.cpuProgressBar = new CircularProgressBar.CircularProgressBar();
            this.ramProgressBar = new CircularProgressBar.CircularProgressBar();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.cpuCounter = new System.Diagnostics.PerformanceCounter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cpuTempLabel = new MetroFramework.Controls.MetroLabel();
            this.cpuTempBar = new MetroFramework.Controls.MetroProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ramAmountLabel = new MetroFramework.Controls.MetroLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.diskProgressBar = new CircularProgressBar.CircularProgressBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.diskCLabel3 = new MetroFramework.Controls.MetroLabel();
            this.diskCLabel2 = new MetroFramework.Controls.MetroLabel();
            this.diskCLabel1 = new MetroFramework.Controls.MetroLabel();
            this.sysUpTimeCounter = new System.Diagnostics.PerformanceCounter();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.systemUpTimeLabel = new MetroFramework.Controls.MetroLabel();
            this.cpuTemperatureTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cpuCounter)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sysUpTimeCounter)).BeginInit();
            this.SuspendLayout();
            // 
            // cpuProgressBar
            // 
            this.cpuProgressBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cpuProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cpuProgressBar.AnimationSpeed = 1300;
            this.cpuProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.cpuProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.cpuProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cpuProgressBar.InnerColor = System.Drawing.Color.White;
            this.cpuProgressBar.InnerMargin = 2;
            this.cpuProgressBar.InnerWidth = -1;
            this.cpuProgressBar.Location = new System.Drawing.Point(13, 22);
            this.cpuProgressBar.MarqueeAnimationSpeed = 2000;
            this.cpuProgressBar.Name = "cpuProgressBar";
            this.cpuProgressBar.OuterColor = System.Drawing.Color.Gray;
            this.cpuProgressBar.OuterMargin = -25;
            this.cpuProgressBar.OuterWidth = 26;
            this.cpuProgressBar.ProgressColor = System.Drawing.Color.DeepSkyBlue;
            this.cpuProgressBar.ProgressWidth = 25;
            this.cpuProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cpuProgressBar.Size = new System.Drawing.Size(230, 230);
            this.cpuProgressBar.StartAngle = 270;
            this.cpuProgressBar.Step = 1;
            this.cpuProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpuProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cpuProgressBar.SubscriptText = "";
            this.cpuProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpuProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cpuProgressBar.SuperscriptText = "load";
            this.cpuProgressBar.TabIndex = 0;
            this.cpuProgressBar.Text = "CPU";
            this.cpuProgressBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.cpuProgressBar.Value = 1;
            // 
            // ramProgressBar
            // 
            this.ramProgressBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ramProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.ramProgressBar.AnimationSpeed = 1300;
            this.ramProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.ramProgressBar.Cursor = System.Windows.Forms.Cursors.No;
            this.ramProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.ramProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ramProgressBar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ramProgressBar.InnerColor = System.Drawing.Color.White;
            this.ramProgressBar.InnerMargin = 2;
            this.ramProgressBar.InnerWidth = -1;
            this.ramProgressBar.Location = new System.Drawing.Point(272, 22);
            this.ramProgressBar.MarqueeAnimationSpeed = 2000;
            this.ramProgressBar.Name = "ramProgressBar";
            this.ramProgressBar.OuterColor = System.Drawing.Color.Gray;
            this.ramProgressBar.OuterMargin = -25;
            this.ramProgressBar.OuterWidth = 26;
            this.ramProgressBar.ProgressColor = System.Drawing.Color.Orange;
            this.ramProgressBar.ProgressWidth = 25;
            this.ramProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ramProgressBar.Size = new System.Drawing.Size(230, 230);
            this.ramProgressBar.StartAngle = 270;
            this.ramProgressBar.Step = 1;
            this.ramProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.ramProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.ramProgressBar.SubscriptText = "";
            this.ramProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.ramProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.ramProgressBar.SuperscriptText = "free";
            this.ramProgressBar.TabIndex = 1;
            this.ramProgressBar.Text = "RAM";
            this.ramProgressBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.ramProgressBar.Value = 68;
            // 
            // mainTimer
            // 
            this.mainTimer.Enabled = true;
            this.mainTimer.Interval = 1000;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // cpuCounter
            // 
            this.cpuCounter.CategoryName = "Processor";
            this.cpuCounter.CounterName = "% Processor Time";
            this.cpuCounter.InstanceName = "_Total";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cpuTempLabel);
            this.groupBox1.Controls.Add(this.cpuTempBar);
            this.groupBox1.Location = new System.Drawing.Point(3, 277);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 170);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CPU information";
            // 
            // cpuTempLabel
            // 
            this.cpuTempLabel.AutoSize = true;
            this.cpuTempLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.cpuTempLabel.Location = new System.Drawing.Point(6, 20);
            this.cpuTempLabel.Name = "cpuTempLabel";
            this.cpuTempLabel.Size = new System.Drawing.Size(42, 19);
            this.cpuTempLabel.TabIndex = 6;
            this.cpuTempLabel.Text = "45#C";
            // 
            // cpuTempBar
            // 
            this.cpuTempBar.Location = new System.Drawing.Point(66, 18);
            this.cpuTempBar.Name = "cpuTempBar";
            this.cpuTempBar.Size = new System.Drawing.Size(182, 23);
            this.cpuTempBar.Step = 1;
            this.cpuTempBar.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.ramAmountLabel);
            this.groupBox2.Location = new System.Drawing.Point(259, 277);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 170);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RAM information";
            // 
            // ramAmountLabel
            // 
            this.ramAmountLabel.AutoSize = true;
            this.ramAmountLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.ramAmountLabel.Location = new System.Drawing.Point(6, 20);
            this.ramAmountLabel.Name = "ramAmountLabel";
            this.ramAmountLabel.Size = new System.Drawing.Size(116, 19);
            this.ramAmountLabel.TabIndex = 7;
            this.ramAmountLabel.Text = "Amount of RAM";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.42149F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.57851F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 271F));
            this.tableLayoutPanel1.Controls.Add(this.diskProgressBar, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cpuProgressBar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ramProgressBar, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 2, 1);
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.88889F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(791, 450);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // diskProgressBar
            // 
            this.diskProgressBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.diskProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.diskProgressBar.AnimationSpeed = 1300;
            this.diskProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.diskProgressBar.Cursor = System.Windows.Forms.Cursors.No;
            this.diskProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.diskProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.diskProgressBar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.diskProgressBar.InnerColor = System.Drawing.Color.White;
            this.diskProgressBar.InnerMargin = 2;
            this.diskProgressBar.InnerWidth = -1;
            this.diskProgressBar.Location = new System.Drawing.Point(540, 22);
            this.diskProgressBar.MarqueeAnimationSpeed = 2000;
            this.diskProgressBar.Name = "diskProgressBar";
            this.diskProgressBar.OuterColor = System.Drawing.Color.Gray;
            this.diskProgressBar.OuterMargin = -25;
            this.diskProgressBar.OuterWidth = 26;
            this.diskProgressBar.ProgressColor = System.Drawing.Color.LightGreen;
            this.diskProgressBar.ProgressWidth = 25;
            this.diskProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.diskProgressBar.Size = new System.Drawing.Size(230, 230);
            this.diskProgressBar.StartAngle = 270;
            this.diskProgressBar.Step = 1;
            this.diskProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.diskProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.diskProgressBar.SubscriptText = "";
            this.diskProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.diskProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.diskProgressBar.SuperscriptText = "free";
            this.diskProgressBar.TabIndex = 10;
            this.diskProgressBar.Text = "DISK";
            this.diskProgressBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.diskProgressBar.Value = 100;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.diskCLabel3);
            this.groupBox3.Controls.Add(this.diskCLabel2);
            this.groupBox3.Controls.Add(this.diskCLabel1);
            this.groupBox3.Location = new System.Drawing.Point(522, 277);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(266, 170);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DISK information";
            // 
            // diskCLabel3
            // 
            this.diskCLabel3.AutoSize = true;
            this.diskCLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.diskCLabel3.Location = new System.Drawing.Point(6, 58);
            this.diskCLabel3.Name = "diskCLabel3";
            this.diskCLabel3.Size = new System.Drawing.Size(114, 19);
            this.diskCLabel3.TabIndex = 10;
            this.diskCLabel3.Text = "Disk Free Space";
            // 
            // diskCLabel2
            // 
            this.diskCLabel2.AutoSize = true;
            this.diskCLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.diskCLabel2.Location = new System.Drawing.Point(6, 39);
            this.diskCLabel2.Name = "diskCLabel2";
            this.diskCLabel2.Size = new System.Drawing.Size(118, 19);
            this.diskCLabel2.TabIndex = 9;
            this.diskCLabel2.Text = "Disk Total Space";
            // 
            // diskCLabel1
            // 
            this.diskCLabel1.AutoSize = true;
            this.diskCLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.diskCLabel1.Location = new System.Drawing.Point(6, 20);
            this.diskCLabel1.Name = "diskCLabel1";
            this.diskCLabel1.Size = new System.Drawing.Size(81, 19);
            this.diskCLabel1.TabIndex = 8;
            this.diskCLabel1.Text = "Disk Name";
            // 
            // sysUpTimeCounter
            // 
            this.sysUpTimeCounter.CategoryName = "System";
            this.sysUpTimeCounter.CounterName = "System Up Time";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(632, 142);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(69, 25);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "DISK C";
            // 
            // systemUpTimeLabel
            // 
            this.systemUpTimeLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.systemUpTimeLabel.Location = new System.Drawing.Point(532, 38);
            this.systemUpTimeLabel.Name = "systemUpTimeLabel";
            this.systemUpTimeLabel.Size = new System.Drawing.Size(264, 19);
            this.systemUpTimeLabel.TabIndex = 8;
            this.systemUpTimeLabel.Text = "System Up Time: 4 Hours";
            this.systemUpTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cpuTemperatureTimer
            // 
            this.cpuTemperatureTimer.Enabled = true;
            this.cpuTemperatureTimer.Interval = 4000;
            this.cpuTemperatureTimer.Tick += new System.EventHandler(this.cpuTemperatureTimer_Tick);
            // 
            // Monitoring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 545);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.systemUpTimeLabel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Monitoring";
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Computer Monitoring";
            this.Load += new System.EventHandler(this.Monitoring_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cpuCounter)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sysUpTimeCounter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CircularProgressBar.CircularProgressBar cpuProgressBar;
        private CircularProgressBar.CircularProgressBar ramProgressBar;
        private System.Windows.Forms.Timer mainTimer;
        private System.Diagnostics.PerformanceCounter cpuCounter;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroProgressBar cpuTempBar;
        private MetroFramework.Controls.MetroLabel cpuTempLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private CircularProgressBar.CircularProgressBar diskProgressBar;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroLabel ramAmountLabel;
        private System.Diagnostics.PerformanceCounter sysUpTimeCounter;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel diskCLabel3;
        private MetroFramework.Controls.MetroLabel diskCLabel2;
        private MetroFramework.Controls.MetroLabel diskCLabel1;
        private MetroFramework.Controls.MetroLabel systemUpTimeLabel;
        private System.Windows.Forms.Timer cpuTemperatureTimer;
    }
}

