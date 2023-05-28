namespace Pytel_WinForm
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tssbOpen = new System.Windows.Forms.ToolStripSplitButton();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbQueue = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbPrevious = new System.Windows.Forms.ToolStripButton();
            this.tsb10SecBack = new System.Windows.Forms.ToolStripButton();
            this.tsbPlay = new System.Windows.Forms.ToolStripButton();
            this.tsbPause = new System.Windows.Forms.ToolStripButton();
            this.tsbStop = new System.Windows.Forms.ToolStripButton();
            this.tsb10SecForward = new System.Windows.Forms.ToolStripButton();
            this.tsbNext = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tslDuration = new System.Windows.Forms.ToolStripLabel();
            this.tbPosition = new System.Windows.Forms.TrackBar();
            this.tbVolume = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ofdFile = new System.Windows.Forms.OpenFileDialog();
            this.fbdFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.tDuration = new System.Windows.Forms.Timer(this.components);
            this.tControls = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssbOpen,
            this.tsbQueue,
            this.toolStripSeparator1,
            this.tsbPrevious,
            this.tsb10SecBack,
            this.tsbPlay,
            this.tsbPause,
            this.tsbStop,
            this.tsb10SecForward,
            this.tsbNext,
            this.toolStripSeparator2,
            this.tslDuration});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tssbOpen
            // 
            this.tssbOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tssbOpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.openFolderToolStripMenuItem});
            this.tssbOpen.Image = ((System.Drawing.Image)(resources.GetObject("tssbOpen.Image")));
            this.tssbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssbOpen.Name = "tssbOpen";
            this.tssbOpen.Size = new System.Drawing.Size(32, 22);
            this.tssbOpen.Text = "Open file";
            this.tssbOpen.ButtonClick += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.openToolStripMenuItem.Text = "Open file";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // openFolderToolStripMenuItem
            // 
            this.openFolderToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.openFolderToolStripMenuItem.Enabled = false;
            this.openFolderToolStripMenuItem.Name = "openFolderToolStripMenuItem";
            this.openFolderToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.openFolderToolStripMenuItem.Text = "Open folder";
            // 
            // tsbQueue
            // 
            this.tsbQueue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbQueue.Enabled = false;
            this.tsbQueue.Image = ((System.Drawing.Image)(resources.GetObject("tsbQueue.Image")));
            this.tsbQueue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbQueue.Name = "tsbQueue";
            this.tsbQueue.Size = new System.Drawing.Size(23, 22);
            this.tsbQueue.Text = "Queue";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbPrevious
            // 
            this.tsbPrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPrevious.Image = ((System.Drawing.Image)(resources.GetObject("tsbPrevious.Image")));
            this.tsbPrevious.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrevious.Name = "tsbPrevious";
            this.tsbPrevious.Size = new System.Drawing.Size(23, 22);
            this.tsbPrevious.Text = "Previous";
            this.tsbPrevious.Click += new System.EventHandler(this.tsbPrevious_Click);
            // 
            // tsb10SecBack
            // 
            this.tsb10SecBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb10SecBack.Image = ((System.Drawing.Image)(resources.GetObject("tsb10SecBack.Image")));
            this.tsb10SecBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb10SecBack.Name = "tsb10SecBack";
            this.tsb10SecBack.Size = new System.Drawing.Size(23, 22);
            this.tsb10SecBack.Text = "Seek back";
            this.tsb10SecBack.Click += new System.EventHandler(this.tsb10SecBack_Click);
            // 
            // tsbPlay
            // 
            this.tsbPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPlay.Image = ((System.Drawing.Image)(resources.GetObject("tsbPlay.Image")));
            this.tsbPlay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPlay.Name = "tsbPlay";
            this.tsbPlay.Size = new System.Drawing.Size(23, 22);
            this.tsbPlay.Text = "Play";
            this.tsbPlay.Click += new System.EventHandler(this.tsbPlay_Click);
            // 
            // tsbPause
            // 
            this.tsbPause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPause.Image = ((System.Drawing.Image)(resources.GetObject("tsbPause.Image")));
            this.tsbPause.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPause.Name = "tsbPause";
            this.tsbPause.Size = new System.Drawing.Size(23, 22);
            this.tsbPause.Text = "Pause";
            this.tsbPause.Click += new System.EventHandler(this.tsbPause_Click);
            // 
            // tsbStop
            // 
            this.tsbStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbStop.Image = ((System.Drawing.Image)(resources.GetObject("tsbStop.Image")));
            this.tsbStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStop.Name = "tsbStop";
            this.tsbStop.Size = new System.Drawing.Size(23, 22);
            this.tsbStop.Text = "Stop";
            this.tsbStop.Click += new System.EventHandler(this.tsbStop_Click);
            // 
            // tsb10SecForward
            // 
            this.tsb10SecForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb10SecForward.Enabled = false;
            this.tsb10SecForward.Image = ((System.Drawing.Image)(resources.GetObject("tsb10SecForward.Image")));
            this.tsb10SecForward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb10SecForward.Name = "tsb10SecForward";
            this.tsb10SecForward.Size = new System.Drawing.Size(23, 22);
            this.tsb10SecForward.Text = "Seek forward";
            // 
            // tsbNext
            // 
            this.tsbNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNext.Image = ((System.Drawing.Image)(resources.GetObject("tsbNext.Image")));
            this.tsbNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNext.Name = "tsbNext";
            this.tsbNext.Size = new System.Drawing.Size(23, 22);
            this.tsbNext.Text = "Next";
            this.tsbNext.Click += new System.EventHandler(this.tsbNext_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tslDuration
            // 
            this.tslDuration.Name = "tslDuration";
            this.tslDuration.Size = new System.Drawing.Size(66, 22);
            this.tslDuration.Text = "00:00/00:00";
            // 
            // tbPosition
            // 
            this.tbPosition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPosition.LargeChange = 10;
            this.tbPosition.Location = new System.Drawing.Point(12, 393);
            this.tbPosition.Maximum = 1;
            this.tbPosition.Name = "tbPosition";
            this.tbPosition.Size = new System.Drawing.Size(385, 45);
            this.tbPosition.SmallChange = 5;
            this.tbPosition.TabIndex = 1;
            this.tbPosition.Scroll += new System.EventHandler(this.tbPosition_Scroll);
            // 
            // tbVolume
            // 
            this.tbVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbVolume.LargeChange = 10;
            this.tbVolume.Location = new System.Drawing.Point(403, 393);
            this.tbVolume.Maximum = 100;
            this.tbVolume.Name = "tbVolume";
            this.tbVolume.Size = new System.Drawing.Size(385, 45);
            this.tbVolume.TabIndex = 2;
            this.tbVolume.Value = 100;
            this.tbVolume.Scroll += new System.EventHandler(this.tbVolume_Scroll);
            this.tbVolume.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tbVolume_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(12, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 359);
            this.panel1.TabIndex = 3;
            // 
            // tDuration
            // 
            this.tDuration.Interval = 750;
            this.tDuration.Tick += new System.EventHandler(this.tDuration_Tick);
            // 
            // tControls
            // 
            this.tControls.Enabled = true;
            this.tControls.Interval = 750;
            this.tControls.Tick += new System.EventHandler(this.tControls_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbVolume);
            this.Controls.Add(this.tbPosition);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form1";
            this.Text = "Pytel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TrackBar tbPosition;
        private System.Windows.Forms.TrackBar tbVolume;
        private System.Windows.Forms.ToolStripSplitButton tssbOpen;
        private System.Windows.Forms.ToolStripButton tsbQueue;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbPrevious;
        private System.Windows.Forms.ToolStripButton tsb10SecBack;
        private System.Windows.Forms.ToolStripButton tsbPlay;
        private System.Windows.Forms.ToolStripButton tsbPause;
        private System.Windows.Forms.ToolStripButton tsbStop;
        private System.Windows.Forms.ToolStripButton tsb10SecForward;
        private System.Windows.Forms.ToolStripButton tsbNext;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel tslDuration;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFolderToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.OpenFileDialog ofdFile;
        private System.Windows.Forms.FolderBrowserDialog fbdFolder;
        private System.Windows.Forms.Timer tDuration;
        private System.Windows.Forms.Timer tControls;
        private System.Windows.Forms.Timer timer1;
    }
}

