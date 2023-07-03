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
            this.tsBasic = new System.Windows.Forms.ToolStrip();
            this.tssbOpen = new System.Windows.Forms.ToolStripSplitButton();
            this.tsmiOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpenURL = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpenFileUniversal = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbQueue = new System.Windows.Forms.ToolStripButton();
            this.tsbFullScreen = new System.Windows.Forms.ToolStripButton();
            this.tssBasic1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbPrevious = new System.Windows.Forms.ToolStripButton();
            this.tsb10SecBack = new System.Windows.Forms.ToolStripButton();
            this.tsbPlay = new System.Windows.Forms.ToolStripButton();
            this.tsbPause = new System.Windows.Forms.ToolStripButton();
            this.tsbStop = new System.Windows.Forms.ToolStripButton();
            this.tsb10SecForward = new System.Windows.Forms.ToolStripButton();
            this.tsbNext = new System.Windows.Forms.ToolStripButton();
            this.tssBasic2 = new System.Windows.Forms.ToolStripSeparator();
            this.tslDuration = new System.Windows.Forms.ToolStripLabel();
            this.tbPosition = new System.Windows.Forms.TrackBar();
            this.tbVolume = new System.Windows.Forms.TrackBar();
            this.pPlayer = new System.Windows.Forms.Panel();
            this.pFullScreenControl = new System.Windows.Forms.Panel();
            this.ofdFile = new System.Windows.Forms.OpenFileDialog();
            this.fbdFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.tDuration = new System.Windows.Forms.Timer(this.components);
            this.tControls = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tsFullScreen = new System.Windows.Forms.ToolStrip();
            this.tsbExitFullScreen = new System.Windows.Forms.ToolStripButton();
            this.tssFS1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbFSPlay = new System.Windows.Forms.ToolStripButton();
            this.tsbFSPause = new System.Windows.Forms.ToolStripButton();
            this.tssFS2 = new System.Windows.Forms.ToolStripSeparator();
            this.tspbPosition = new System.Windows.Forms.ToolStripProgressBar();
            this.tslFSDuration = new System.Windows.Forms.ToolStripLabel();
            this.tspbVolume = new System.Windows.Forms.ToolStripProgressBar();
            this.tssFS3 = new System.Windows.Forms.ToolStripSeparator();
            this.pBottom = new System.Windows.Forms.Panel();
            this.ofdUniversal = new System.Windows.Forms.OpenFileDialog();
            this.tsBasic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).BeginInit();
            this.pPlayer.SuspendLayout();
            this.tsFullScreen.SuspendLayout();
            this.pBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsBasic
            // 
            this.tsBasic.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssbOpen,
            this.tsbQueue,
            this.tsbFullScreen,
            this.tssBasic1,
            this.tsbPrevious,
            this.tsb10SecBack,
            this.tsbPlay,
            this.tsbPause,
            this.tsbStop,
            this.tsb10SecForward,
            this.tsbNext,
            this.tssBasic2,
            this.tslDuration});
            this.tsBasic.Location = new System.Drawing.Point(0, 0);
            this.tsBasic.Name = "tsBasic";
            this.tsBasic.Size = new System.Drawing.Size(800, 25);
            this.tsBasic.TabIndex = 0;
            this.tsBasic.Text = "toolStripBasic";
            // 
            // tssbOpen
            // 
            this.tssbOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tssbOpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOpenFile,
            this.tsmiOpenURL,
            this.tsmiOpenFileUniversal});
            this.tssbOpen.Image = ((System.Drawing.Image)(resources.GetObject("tssbOpen.Image")));
            this.tssbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssbOpen.Name = "tssbOpen";
            this.tssbOpen.Size = new System.Drawing.Size(32, 22);
            this.tssbOpen.Text = "Open file";
            this.tssbOpen.ButtonClick += new System.EventHandler(this.tsmiOpenFile_Click);
            // 
            // tsmiOpenFile
            // 
            this.tsmiOpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsmiOpenFile.Name = "tsmiOpenFile";
            this.tsmiOpenFile.Size = new System.Drawing.Size(181, 22);
            this.tsmiOpenFile.Text = "Open file";
            this.tsmiOpenFile.Click += new System.EventHandler(this.tsmiOpenFile_Click);
            // 
            // tsmiOpenURL
            // 
            this.tsmiOpenURL.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsmiOpenURL.Enabled = false;
            this.tsmiOpenURL.Name = "tsmiOpenURL";
            this.tsmiOpenURL.Size = new System.Drawing.Size(181, 22);
            this.tsmiOpenURL.Text = "Open from URL";
            // 
            // tsmiOpenFileUniversal
            // 
            this.tsmiOpenFileUniversal.Name = "tsmiOpenFileUniversal";
            this.tsmiOpenFileUniversal.Size = new System.Drawing.Size(181, 22);
            this.tsmiOpenFileUniversal.Text = "Open file (Universal)";
            this.tsmiOpenFileUniversal.Click += new System.EventHandler(this.tsmiOpenFileUniversal_Click);
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
            // tsbFullScreen
            // 
            this.tsbFullScreen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFullScreen.Enabled = false;
            this.tsbFullScreen.Image = global::Pytel_WinForm.Properties.Resources.showing_video_frames_96px;
            this.tsbFullScreen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFullScreen.Name = "tsbFullScreen";
            this.tsbFullScreen.Size = new System.Drawing.Size(23, 22);
            this.tsbFullScreen.Text = "Full Screen";
            this.tsbFullScreen.Click += new System.EventHandler(this.tsbFullScreen_Click);
            // 
            // tssBasic1
            // 
            this.tssBasic1.Name = "tssBasic1";
            this.tssBasic1.Size = new System.Drawing.Size(6, 25);
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
            this.tsb10SecForward.Image = ((System.Drawing.Image)(resources.GetObject("tsb10SecForward.Image")));
            this.tsb10SecForward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb10SecForward.Name = "tsb10SecForward";
            this.tsb10SecForward.Size = new System.Drawing.Size(23, 22);
            this.tsb10SecForward.Text = "Seek forward";
            this.tsb10SecForward.Click += new System.EventHandler(this.tsb10SecForward_Click);
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
            // tssBasic2
            // 
            this.tssBasic2.Name = "tssBasic2";
            this.tssBasic2.Size = new System.Drawing.Size(6, 25);
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
            this.tbPosition.Location = new System.Drawing.Point(12, 3);
            this.tbPosition.Maximum = 1;
            this.tbPosition.Name = "tbPosition";
            this.tbPosition.Size = new System.Drawing.Size(385, 45);
            this.tbPosition.SmallChange = 5;
            this.tbPosition.TabIndex = 2;
            this.tbPosition.TickFrequency = 60;
            this.tbPosition.Scroll += new System.EventHandler(this.tbPosition_Seek);
            // 
            // tbVolume
            // 
            this.tbVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbVolume.LargeChange = 10;
            this.tbVolume.Location = new System.Drawing.Point(403, 3);
            this.tbVolume.Maximum = 100;
            this.tbVolume.Name = "tbVolume";
            this.tbVolume.Size = new System.Drawing.Size(385, 45);
            this.tbVolume.TabIndex = 3;
            this.tbVolume.TickFrequency = 5;
            this.tbVolume.Value = 100;
            this.tbVolume.ValueChanged += new System.EventHandler(this.tbVolume_Scroll);
            this.tbVolume.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tbVolume_MouseUp);
            // 
            // pPlayer
            // 
            this.pPlayer.BackColor = System.Drawing.Color.Black;
            this.pPlayer.Controls.Add(this.pFullScreenControl);
            this.pPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPlayer.Location = new System.Drawing.Point(0, 25);
            this.pPlayer.MinimumSize = new System.Drawing.Size(776, 359);
            this.pPlayer.Name = "pPlayer";
            this.pPlayer.Size = new System.Drawing.Size(800, 374);
            this.pPlayer.TabIndex = 1;
            this.pPlayer.TabStop = true;
            this.pPlayer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pPlayer_MouseClick);
            // 
            // pFullScreenControl
            // 
            this.pFullScreenControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pFullScreenControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pFullScreenControl.Location = new System.Drawing.Point(0, 349);
            this.pFullScreenControl.Name = "pFullScreenControl";
            this.pFullScreenControl.Size = new System.Drawing.Size(800, 25);
            this.pFullScreenControl.TabIndex = 0;
            this.pFullScreenControl.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            // 
            // ofdFile
            // 
            this.ofdFile.Filter = resources.GetString("ofdFile.Filter");
            this.ofdFile.Title = "Open file...";
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
            // tsFullScreen
            // 
            this.tsFullScreen.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsFullScreen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbExitFullScreen,
            this.tssFS1,
            this.tsbFSPlay,
            this.tsbFSPause,
            this.tssFS2,
            this.tspbPosition,
            this.tslFSDuration,
            this.tspbVolume,
            this.tssFS3});
            this.tsFullScreen.Location = new System.Drawing.Point(0, 374);
            this.tsFullScreen.Name = "tsFullScreen";
            this.tsFullScreen.Size = new System.Drawing.Size(800, 25);
            this.tsFullScreen.TabIndex = 4;
            this.tsFullScreen.Text = "tsFullScreen";
            this.tsFullScreen.Visible = false;
            this.tsFullScreen.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // tsbExitFullScreen
            // 
            this.tsbExitFullScreen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExitFullScreen.Image = global::Pytel_WinForm.Properties.Resources.showing_video_frames_96px;
            this.tsbExitFullScreen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExitFullScreen.Name = "tsbExitFullScreen";
            this.tsbExitFullScreen.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.tsbExitFullScreen.Size = new System.Drawing.Size(23, 22);
            this.tsbExitFullScreen.Text = "Exit Full Screen";
            this.tsbExitFullScreen.Click += new System.EventHandler(this.tsbExitFullScreen_Click);
            // 
            // tssFS1
            // 
            this.tssFS1.Name = "tssFS1";
            this.tssFS1.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.tssFS1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbFSPlay
            // 
            this.tsbFSPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFSPlay.Image = global::Pytel_WinForm.Properties.Resources.play_96px;
            this.tsbFSPlay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFSPlay.Name = "tsbFSPlay";
            this.tsbFSPlay.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.tsbFSPlay.Size = new System.Drawing.Size(23, 22);
            this.tsbFSPlay.Text = "Play";
            this.tsbFSPlay.Click += new System.EventHandler(this.tsbFSPlay_Click);
            // 
            // tsbFSPause
            // 
            this.tsbFSPause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFSPause.Image = global::Pytel_WinForm.Properties.Resources.pause_96px;
            this.tsbFSPause.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFSPause.Name = "tsbFSPause";
            this.tsbFSPause.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.tsbFSPause.Size = new System.Drawing.Size(23, 22);
            this.tsbFSPause.Text = "Pause";
            this.tsbFSPause.Click += new System.EventHandler(this.tsbFSPause_Click);
            // 
            // tssFS2
            // 
            this.tssFS2.Name = "tssFS2";
            this.tssFS2.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.tssFS2.Size = new System.Drawing.Size(6, 25);
            // 
            // tspbPosition
            // 
            this.tspbPosition.Maximum = 1;
            this.tspbPosition.Name = "tspbPosition";
            this.tspbPosition.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.tspbPosition.Size = new System.Drawing.Size(500, 22);
            this.tspbPosition.Step = 1;
            this.tspbPosition.Click += new System.EventHandler(this.tspbPosition_Click);
            // 
            // tslFSDuration
            // 
            this.tslFSDuration.BackColor = System.Drawing.Color.Transparent;
            this.tslFSDuration.Name = "tslFSDuration";
            this.tslFSDuration.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.tslFSDuration.Size = new System.Drawing.Size(66, 22);
            this.tslFSDuration.Text = "00:00/00:00";
            // 
            // tspbVolume
            // 
            this.tspbVolume.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tspbVolume.AutoSize = false;
            this.tspbVolume.Name = "tspbVolume";
            this.tspbVolume.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.tspbVolume.Size = new System.Drawing.Size(100, 22);
            this.tspbVolume.Step = 2;
            this.tspbVolume.Value = 100;
            this.tspbVolume.Click += new System.EventHandler(this.tspbVolume_Click);
            // 
            // tssFS3
            // 
            this.tssFS3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tssFS3.Name = "tssFS3";
            this.tssFS3.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.tssFS3.Size = new System.Drawing.Size(6, 25);
            // 
            // pBottom
            // 
            this.pBottom.Controls.Add(this.tbVolume);
            this.pBottom.Controls.Add(this.tbPosition);
            this.pBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pBottom.Location = new System.Drawing.Point(0, 399);
            this.pBottom.Name = "pBottom";
            this.pBottom.Size = new System.Drawing.Size(800, 51);
            this.pBottom.TabIndex = 1;
            // 
            // ofdUniversal
            // 
            this.ofdUniversal.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tsFullScreen);
            this.Controls.Add(this.pPlayer);
            this.Controls.Add(this.tsBasic);
            this.Controls.Add(this.pBottom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form1";
            this.Text = "Pytel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tsBasic.ResumeLayout(false);
            this.tsBasic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).EndInit();
            this.pPlayer.ResumeLayout(false);
            this.tsFullScreen.ResumeLayout(false);
            this.tsFullScreen.PerformLayout();
            this.pBottom.ResumeLayout(false);
            this.pBottom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsBasic;
        private System.Windows.Forms.TrackBar tbPosition;
        private System.Windows.Forms.TrackBar tbVolume;
        private System.Windows.Forms.ToolStripSplitButton tssbOpen;
        private System.Windows.Forms.ToolStripButton tsbQueue;
        private System.Windows.Forms.ToolStripSeparator tssBasic1;
        private System.Windows.Forms.ToolStripButton tsbPrevious;
        private System.Windows.Forms.ToolStripButton tsb10SecBack;
        private System.Windows.Forms.ToolStripButton tsbPlay;
        private System.Windows.Forms.ToolStripButton tsbPause;
        private System.Windows.Forms.ToolStripButton tsbStop;
        private System.Windows.Forms.ToolStripButton tsb10SecForward;
        private System.Windows.Forms.ToolStripButton tsbNext;
        private System.Windows.Forms.ToolStripSeparator tssBasic2;
        private System.Windows.Forms.ToolStripLabel tslDuration;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpenFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpenURL;
        private System.Windows.Forms.Panel pPlayer;
        private System.Windows.Forms.OpenFileDialog ofdFile;
        private System.Windows.Forms.FolderBrowserDialog fbdFolder;
        private System.Windows.Forms.Timer tDuration;
        private System.Windows.Forms.Timer tControls;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripButton tsbFullScreen;
        private System.Windows.Forms.ToolStrip tsFullScreen;
        private System.Windows.Forms.ToolStripButton tsbExitFullScreen;
        private System.Windows.Forms.ToolStripSeparator tssFS1;
        private System.Windows.Forms.ToolStripButton tsbFSPlay;
        private System.Windows.Forms.ToolStripButton tsbFSPause;
        private System.Windows.Forms.ToolStripSeparator tssFS2;
        private System.Windows.Forms.ToolStripProgressBar tspbPosition;
        private System.Windows.Forms.ToolStripLabel tslFSDuration;
        private System.Windows.Forms.ToolStripSeparator tssFS3;
        private System.Windows.Forms.ToolStripProgressBar tspbVolume;
        private System.Windows.Forms.Panel pFullScreenControl;
        private System.Windows.Forms.Panel pBottom;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpenFileUniversal;
        private System.Windows.Forms.OpenFileDialog ofdUniversal;
    }
}

