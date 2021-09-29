
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cpuCounter = new System.Diagnostics.PerformanceCounter();
            this.memCounter = new System.Diagnostics.PerformanceCounter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cpuTempLabel = new MetroFramework.Controls.MetroLabel();
            this.cpuTempBar = new MetroFramework.Controls.MetroProgressBar();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.cpuCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memCounter)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sysUpTimeCounter)).BeginInit();
            this.SuspendLayout();
            // 
            // cpuProgressBar
            // 
            resources.ApplyResources(this.cpuProgressBar, "cpuProgressBar");
            this.cpuProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cpuProgressBar.AnimationSpeed = 1300;
            this.cpuProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.cpuProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cpuProgressBar.InnerColor = System.Drawing.Color.White;
            this.cpuProgressBar.InnerMargin = 2;
            this.cpuProgressBar.InnerWidth = -1;
            this.cpuProgressBar.MarqueeAnimationSpeed = 2000;
            this.cpuProgressBar.Name = "cpuProgressBar";
            this.cpuProgressBar.OuterColor = System.Drawing.Color.Gray;
            this.cpuProgressBar.OuterMargin = -25;
            this.cpuProgressBar.OuterWidth = 26;
            this.cpuProgressBar.ProgressColor = System.Drawing.Color.DeepSkyBlue;
            this.cpuProgressBar.ProgressWidth = 25;
            this.cpuProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cpuProgressBar.StartAngle = 270;
            this.cpuProgressBar.Step = 1;
            this.cpuProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpuProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cpuProgressBar.SubscriptText = "";
            this.cpuProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpuProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cpuProgressBar.SuperscriptText = "load";
            this.cpuProgressBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.cpuProgressBar.Value = 1;
            // 
            // ramProgressBar
            // 
            resources.ApplyResources(this.ramProgressBar, "ramProgressBar");
            this.ramProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.ramProgressBar.AnimationSpeed = 1300;
            this.ramProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.ramProgressBar.Cursor = System.Windows.Forms.Cursors.No;
            this.ramProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ramProgressBar.InnerColor = System.Drawing.Color.White;
            this.ramProgressBar.InnerMargin = 2;
            this.ramProgressBar.InnerWidth = -1;
            this.ramProgressBar.MarqueeAnimationSpeed = 2000;
            this.ramProgressBar.Name = "ramProgressBar";
            this.ramProgressBar.OuterColor = System.Drawing.Color.Gray;
            this.ramProgressBar.OuterMargin = -25;
            this.ramProgressBar.OuterWidth = 26;
            this.ramProgressBar.ProgressColor = System.Drawing.Color.Orange;
            this.ramProgressBar.ProgressWidth = 25;
            this.ramProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ramProgressBar.StartAngle = 270;
            this.ramProgressBar.Step = 1;
            this.ramProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.ramProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.ramProgressBar.SubscriptText = "";
            this.ramProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.ramProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.ramProgressBar.SuperscriptText = "free";
            this.ramProgressBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.ramProgressBar.Value = 68;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cpuCounter
            // 
            this.cpuCounter.CategoryName = "Processor";
            this.cpuCounter.CounterName = "% Processor Time";
            this.cpuCounter.InstanceName = "_Total";
            // 
            // memCounter
            // 
            this.memCounter.CategoryName = "Memory";
            this.memCounter.CounterName = "Available MBytes";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.cpuTempLabel);
            this.groupBox1.Controls.Add(this.cpuTempBar);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // cpuTempLabel
            // 
            resources.ApplyResources(this.cpuTempLabel, "cpuTempLabel");
            this.cpuTempLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.cpuTempLabel.Name = "cpuTempLabel";
            // 
            // cpuTempBar
            // 
            resources.ApplyResources(this.cpuTempBar, "cpuTempBar");
            this.cpuTempBar.Name = "cpuTempBar";
            this.cpuTempBar.Step = 1;
            // 
            // timer2
            // 
            this.timer2.Interval = 4000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.ramAmountLabel);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // ramAmountLabel
            // 
            resources.ApplyResources(this.ramAmountLabel, "ramAmountLabel");
            this.ramAmountLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.ramAmountLabel.Name = "ramAmountLabel";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.diskProgressBar, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cpuProgressBar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ramProgressBar, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 2, 1);
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // diskProgressBar
            // 
            resources.ApplyResources(this.diskProgressBar, "diskProgressBar");
            this.diskProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.diskProgressBar.AnimationSpeed = 1300;
            this.diskProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.diskProgressBar.Cursor = System.Windows.Forms.Cursors.No;
            this.diskProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.diskProgressBar.InnerColor = System.Drawing.Color.White;
            this.diskProgressBar.InnerMargin = 2;
            this.diskProgressBar.InnerWidth = -1;
            this.diskProgressBar.MarqueeAnimationSpeed = 2000;
            this.diskProgressBar.Name = "diskProgressBar";
            this.diskProgressBar.OuterColor = System.Drawing.Color.Gray;
            this.diskProgressBar.OuterMargin = -25;
            this.diskProgressBar.OuterWidth = 26;
            this.diskProgressBar.ProgressColor = System.Drawing.Color.LightGreen;
            this.diskProgressBar.ProgressWidth = 25;
            this.diskProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.diskProgressBar.StartAngle = 270;
            this.diskProgressBar.Step = 1;
            this.diskProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.diskProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.diskProgressBar.SubscriptText = "";
            this.diskProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.diskProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.diskProgressBar.SuperscriptText = "";
            this.diskProgressBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.diskProgressBar.Value = 100;
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Controls.Add(this.diskCLabel3);
            this.groupBox3.Controls.Add(this.diskCLabel2);
            this.groupBox3.Controls.Add(this.diskCLabel1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // diskCLabel3
            // 
            resources.ApplyResources(this.diskCLabel3, "diskCLabel3");
            this.diskCLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.diskCLabel3.Name = "diskCLabel3";
            // 
            // diskCLabel2
            // 
            resources.ApplyResources(this.diskCLabel2, "diskCLabel2");
            this.diskCLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.diskCLabel2.Name = "diskCLabel2";
            // 
            // diskCLabel1
            // 
            resources.ApplyResources(this.diskCLabel1, "diskCLabel1");
            this.diskCLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.diskCLabel1.Name = "diskCLabel1";
            // 
            // sysUpTimeCounter
            // 
            this.sysUpTimeCounter.CategoryName = "System";
            this.sysUpTimeCounter.CounterName = "System Up Time";
            // 
            // metroLabel1
            // 
            resources.ApplyResources(this.metroLabel1, "metroLabel1");
            this.metroLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Name = "metroLabel1";
            // 
            // systemUpTimeLabel
            // 
            this.systemUpTimeLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            resources.ApplyResources(this.systemUpTimeLabel, "systemUpTimeLabel");
            this.systemUpTimeLabel.Name = "systemUpTimeLabel";
            // 
            // Monitoring
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.systemUpTimeLabel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Monitoring";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Load += new System.EventHandler(this.Monitoring_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cpuCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memCounter)).EndInit();
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
        private System.Windows.Forms.Timer timer1;
        private System.Diagnostics.PerformanceCounter cpuCounter;
        private System.Diagnostics.PerformanceCounter memCounter;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroProgressBar cpuTempBar;
        private System.Windows.Forms.Timer timer2;
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
    }
}

