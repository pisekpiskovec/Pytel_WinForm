using Pytel_WinForm.Properties;

namespace Pytel_WinForm
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.gbAbout = new System.Windows.Forms.GroupBox();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.lAbout = new System.Windows.Forms.Label();
            this.gbShortcuts = new System.Windows.Forms.GroupBox();
            this.lbShortcuts = new System.Windows.Forms.ListBox();
            this.gbSettings = new System.Windows.Forms.GroupBox();
            this.gbYT = new System.Windows.Forms.GroupBox();
            this.tbFFmgegPath = new System.Windows.Forms.TextBox();
            this.lFFmgegPath = new System.Windows.Forms.Label();
            this.bFFmgegPath = new System.Windows.Forms.Button();
            this.bYTytdlPath = new System.Windows.Forms.Button();
            this.tbYTytdlPath = new System.Windows.Forms.TextBox();
            this.lYTytdlPath = new System.Windows.Forms.Label();
            this.chbYTEnable = new System.Windows.Forms.CheckBox();
            this.llScreenshotFolder = new System.Windows.Forms.LinkLabel();
            this.bChangeSCRLocation = new System.Windows.Forms.Button();
            this.lScreenshot = new System.Windows.Forms.Label();
            this.gbSettingsTaskbar = new System.Windows.Forms.GroupBox();
            this.rbPlaylist = new System.Windows.Forms.RadioButton();
            this.rbVolume = new System.Windows.Forms.RadioButton();
            this.rbPosition = new System.Windows.Forms.RadioButton();
            this.rbState = new System.Windows.Forms.RadioButton();
            this.rbOff = new System.Windows.Forms.RadioButton();
            this.nudPosition = new System.Windows.Forms.NumericUpDown();
            this.lPosition = new System.Windows.Forms.Label();
            this.nudVolume = new System.Windows.Forms.NumericUpDown();
            this.lVolume = new System.Windows.Forms.Label();
            this.gbAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.gbShortcuts.SuspendLayout();
            this.gbSettings.SuspendLayout();
            this.gbYT.SuspendLayout();
            this.gbSettingsTaskbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAbout
            // 
            this.gbAbout.Controls.Add(this.pbIcon);
            this.gbAbout.Controls.Add(this.lAbout);
            this.gbAbout.Location = new System.Drawing.Point(12, 12);
            this.gbAbout.Name = "gbAbout";
            this.gbAbout.Size = new System.Drawing.Size(378, 100);
            this.gbAbout.TabIndex = 0;
            this.gbAbout.TabStop = false;
            this.gbAbout.Text = "About";
            // 
            // pbIcon
            // 
            this.pbIcon.Image = global::Pytel_WinForm.Properties.Resources.pytel_icon_64;
            this.pbIcon.Location = new System.Drawing.Point(308, 18);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(64, 64);
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbIcon.TabIndex = 1;
            this.pbIcon.TabStop = false;
            this.pbIcon.Click += new System.EventHandler(this.pbIcon_Click);
            // 
            // lAbout
            // 
            this.lAbout.AutoSize = true;
            this.lAbout.Location = new System.Drawing.Point(6, 24);
            this.lAbout.Name = "lAbout";
            this.lAbout.Size = new System.Drawing.Size(78, 52);
            this.lAbout.TabIndex = 0;
            this.lAbout.Text = "Pytel_WinForm\r\nver. 0.9.0\r\nMpv.NET\r\nver. 1.2.0";
            // 
            // gbShortcuts
            // 
            this.gbShortcuts.Controls.Add(this.lbShortcuts);
            this.gbShortcuts.Location = new System.Drawing.Point(12, 118);
            this.gbShortcuts.Name = "gbShortcuts";
            this.gbShortcuts.Size = new System.Drawing.Size(378, 100);
            this.gbShortcuts.TabIndex = 1;
            this.gbShortcuts.TabStop = false;
            this.gbShortcuts.Text = "Shortcuts";
            // 
            // lbShortcuts
            // 
            this.lbShortcuts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbShortcuts.FormattingEnabled = true;
            this.lbShortcuts.Items.AddRange(new object[] {
            "Open File | Ctrl+O",
            "Open from URL | Ctrl+Shift+O",
            "Open File (Universal) | Ctrl+Alt+O",
            "Queue | F9/Ctrl+L",
            "Full Screen | F/F11/Left Double Click",
            "Exit Full Screen | F/F11/Escape/Left Double Click",
            "Previous File | Ctrl+,",
            "Seek backward | Left Arrow",
            "Play/Pause | P/Space/Right Click",
            "Stop | Ctrl+S",
            "Seek forward | Right Arrow",
            "Next File | Ctrl+.",
            "Volume up | Up Arrow",
            "Volume down | Down Arrow",
            "Mute/Unmute | M/Right Click on Volume Slider",
            "Quit | Alt+F4/Q",
            "Quit and Save Last File | Ctrl+Q",
            "Reset Window\'s Position | Ctrl+Alt+F6"});
            this.lbShortcuts.Location = new System.Drawing.Point(9, 19);
            this.lbShortcuts.Name = "lbShortcuts";
            this.lbShortcuts.Size = new System.Drawing.Size(363, 67);
            this.lbShortcuts.TabIndex = 0;
            this.lbShortcuts.TabStop = false;
            this.lbShortcuts.UseTabStops = false;
            // 
            // gbSettings
            // 
            this.gbSettings.Controls.Add(this.gbYT);
            this.gbSettings.Controls.Add(this.llScreenshotFolder);
            this.gbSettings.Controls.Add(this.bChangeSCRLocation);
            this.gbSettings.Controls.Add(this.lScreenshot);
            this.gbSettings.Controls.Add(this.gbSettingsTaskbar);
            this.gbSettings.Controls.Add(this.nudPosition);
            this.gbSettings.Controls.Add(this.lPosition);
            this.gbSettings.Controls.Add(this.nudVolume);
            this.gbSettings.Controls.Add(this.lVolume);
            this.gbSettings.Location = new System.Drawing.Point(12, 224);
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.Size = new System.Drawing.Size(378, 357);
            this.gbSettings.TabIndex = 2;
            this.gbSettings.TabStop = false;
            this.gbSettings.Text = "Settings";
            // 
            // gbYT
            // 
            this.gbYT.Controls.Add(this.tbFFmgegPath);
            this.gbYT.Controls.Add(this.lFFmgegPath);
            this.gbYT.Controls.Add(this.bFFmgegPath);
            this.gbYT.Controls.Add(this.bYTytdlPath);
            this.gbYT.Controls.Add(this.tbYTytdlPath);
            this.gbYT.Controls.Add(this.lYTytdlPath);
            this.gbYT.Controls.Add(this.chbYTEnable);
            this.gbYT.Location = new System.Drawing.Point(7, 244);
            this.gbYT.Name = "gbYT";
            this.gbYT.Size = new System.Drawing.Size(365, 103);
            this.gbYT.TabIndex = 8;
            this.gbYT.TabStop = false;
            this.gbYT.Text = "YouTube Player";
            // 
            // tbFFmgegPath
            // 
            this.tbFFmgegPath.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::Pytel_WinForm.Properties.Settings.Default, "ytdlEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbFFmgegPath.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Pytel_WinForm.Properties.Settings.Default, "ffmpegPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbFFmgegPath.Enabled = global::Pytel_WinForm.Properties.Settings.Default.ytdlEnabled;
            this.tbFFmgegPath.Location = new System.Drawing.Point(85, 68);
            this.tbFFmgegPath.Name = "tbFFmgegPath";
            this.tbFFmgegPath.ReadOnly = true;
            this.tbFFmgegPath.Size = new System.Drawing.Size(216, 20);
            this.tbFFmgegPath.TabIndex = 6;
            this.tbFFmgegPath.Text = global::Pytel_WinForm.Properties.Settings.Default.ffmpegPath;
            // 
            // lFFmgegPath
            // 
            this.lFFmgegPath.AutoSize = true;
            this.lFFmgegPath.Location = new System.Drawing.Point(6, 71);
            this.lFFmgegPath.Name = "lFFmgegPath";
            this.lFFmgegPath.Size = new System.Drawing.Size(73, 13);
            this.lFFmgegPath.TabIndex = 5;
            this.lFFmgegPath.Text = "FFmpeg Path:";
            // 
            // bFFmgegPath
            // 
            this.bFFmgegPath.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::Pytel_WinForm.Properties.Settings.Default, "ytdlEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.bFFmgegPath.Enabled = global::Pytel_WinForm.Properties.Settings.Default.ytdlEnabled;
            this.bFFmgegPath.Location = new System.Drawing.Point(307, 66);
            this.bFFmgegPath.Name = "bFFmgegPath";
            this.bFFmgegPath.Size = new System.Drawing.Size(52, 23);
            this.bFFmgegPath.TabIndex = 4;
            this.bFFmgegPath.Text = "Browse";
            this.bFFmgegPath.UseVisualStyleBackColor = true;
            this.bFFmgegPath.Click += new System.EventHandler(this.bFFmgegPath_Click);
            // 
            // bYTytdlPath
            // 
            this.bYTytdlPath.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::Pytel_WinForm.Properties.Settings.Default, "ytdlEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.bYTytdlPath.Enabled = global::Pytel_WinForm.Properties.Settings.Default.ytdlEnabled;
            this.bYTytdlPath.Location = new System.Drawing.Point(307, 37);
            this.bYTytdlPath.Name = "bYTytdlPath";
            this.bYTytdlPath.Size = new System.Drawing.Size(52, 23);
            this.bYTytdlPath.TabIndex = 3;
            this.bYTytdlPath.Text = "Browse";
            this.bYTytdlPath.UseVisualStyleBackColor = true;
            this.bYTytdlPath.Click += new System.EventHandler(this.bYTytdlPath_Click);
            // 
            // tbYTytdlPath
            // 
            this.tbYTytdlPath.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::Pytel_WinForm.Properties.Settings.Default, "ytdlEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbYTytdlPath.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Pytel_WinForm.Properties.Settings.Default, "ytdlPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbYTytdlPath.Enabled = global::Pytel_WinForm.Properties.Settings.Default.ytdlEnabled;
            this.tbYTytdlPath.Location = new System.Drawing.Point(63, 39);
            this.tbYTytdlPath.Name = "tbYTytdlPath";
            this.tbYTytdlPath.ReadOnly = true;
            this.tbYTytdlPath.Size = new System.Drawing.Size(238, 20);
            this.tbYTytdlPath.TabIndex = 2;
            this.tbYTytdlPath.Text = global::Pytel_WinForm.Properties.Settings.Default.ytdlPath;
            // 
            // lYTytdlPath
            // 
            this.lYTytdlPath.AutoSize = true;
            this.lYTytdlPath.Location = new System.Drawing.Point(6, 42);
            this.lYTytdlPath.Name = "lYTytdlPath";
            this.lYTytdlPath.Size = new System.Drawing.Size(51, 13);
            this.lYTytdlPath.TabIndex = 1;
            this.lYTytdlPath.Text = "ytdl Path:";
            // 
            // chbYTEnable
            // 
            this.chbYTEnable.AutoSize = true;
            this.chbYTEnable.Checked = global::Pytel_WinForm.Properties.Settings.Default.ytdlEnabled;
            this.chbYTEnable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbYTEnable.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Pytel_WinForm.Properties.Settings.Default, "ytdlEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chbYTEnable.Location = new System.Drawing.Point(110, 14);
            this.chbYTEnable.Name = "chbYTEnable";
            this.chbYTEnable.Size = new System.Drawing.Size(144, 17);
            this.chbYTEnable.TabIndex = 0;
            this.chbYTEnable.Text = "Enable YouTube support";
            this.chbYTEnable.UseVisualStyleBackColor = true;
            // 
            // llScreenshotFolder
            // 
            this.llScreenshotFolder.AutoEllipsis = true;
            this.llScreenshotFolder.Location = new System.Drawing.Point(148, 71);
            this.llScreenshotFolder.Name = "llScreenshotFolder";
            this.llScreenshotFolder.Size = new System.Drawing.Size(154, 23);
            this.llScreenshotFolder.TabIndex = 7;
            this.llScreenshotFolder.TabStop = true;
            this.llScreenshotFolder.Text = "llScreenshotFolder";
            this.llScreenshotFolder.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llScreenshotFolder_LinkClicked);
            // 
            // bChangeSCRLocation
            // 
            this.bChangeSCRLocation.Location = new System.Drawing.Point(308, 71);
            this.bChangeSCRLocation.Name = "bChangeSCRLocation";
            this.bChangeSCRLocation.Size = new System.Drawing.Size(64, 23);
            this.bChangeSCRLocation.TabIndex = 6;
            this.bChangeSCRLocation.Text = "Change";
            this.bChangeSCRLocation.UseVisualStyleBackColor = true;
            this.bChangeSCRLocation.Click += new System.EventHandler(this.bChangeSCRLocation_Click);
            // 
            // lScreenshot
            // 
            this.lScreenshot.AutoSize = true;
            this.lScreenshot.Location = new System.Drawing.Point(6, 76);
            this.lScreenshot.Name = "lScreenshot";
            this.lScreenshot.Size = new System.Drawing.Size(136, 13);
            this.lScreenshot.TabIndex = 5;
            this.lScreenshot.Text = "Screenshot Save Location:";
            // 
            // gbSettingsTaskbar
            // 
            this.gbSettingsTaskbar.Controls.Add(this.rbPlaylist);
            this.gbSettingsTaskbar.Controls.Add(this.rbVolume);
            this.gbSettingsTaskbar.Controls.Add(this.rbPosition);
            this.gbSettingsTaskbar.Controls.Add(this.rbState);
            this.gbSettingsTaskbar.Controls.Add(this.rbOff);
            this.gbSettingsTaskbar.Location = new System.Drawing.Point(6, 100);
            this.gbSettingsTaskbar.Name = "gbSettingsTaskbar";
            this.gbSettingsTaskbar.Size = new System.Drawing.Size(366, 137);
            this.gbSettingsTaskbar.TabIndex = 4;
            this.gbSettingsTaskbar.TabStop = false;
            this.gbSettingsTaskbar.Text = "Taskbar Visual";
            // 
            // rbPlaylist
            // 
            this.rbPlaylist.AutoSize = true;
            this.rbPlaylist.Location = new System.Drawing.Point(94, 104);
            this.rbPlaylist.Name = "rbPlaylist";
            this.rbPlaylist.Size = new System.Drawing.Size(178, 17);
            this.rbPlaylist.TabIndex = 4;
            this.rbPlaylist.TabStop = true;
            this.rbPlaylist.Text = "Queue Position and Player State";
            this.rbPlaylist.UseVisualStyleBackColor = true;
            this.rbPlaylist.CheckedChanged += new System.EventHandler(this.rbPlaylist_CheckedChanged);
            // 
            // rbVolume
            // 
            this.rbVolume.AutoSize = true;
            this.rbVolume.Location = new System.Drawing.Point(110, 84);
            this.rbVolume.Name = "rbVolume";
            this.rbVolume.Size = new System.Drawing.Size(147, 17);
            this.rbVolume.TabIndex = 3;
            this.rbVolume.Text = "Volume and Volume State";
            this.rbVolume.UseVisualStyleBackColor = true;
            this.rbVolume.CheckedChanged += new System.EventHandler(this.rbVolume_CheckedChanged);
            // 
            // rbPosition
            // 
            this.rbPosition.AutoSize = true;
            this.rbPosition.Location = new System.Drawing.Point(112, 61);
            this.rbPosition.Name = "rbPosition";
            this.rbPosition.Size = new System.Drawing.Size(143, 17);
            this.rbPosition.TabIndex = 2;
            this.rbPosition.Text = "Position and Player State";
            this.rbPosition.UseVisualStyleBackColor = true;
            this.rbPosition.CheckedChanged += new System.EventHandler(this.rbPosition_CheckedChanged);
            // 
            // rbState
            // 
            this.rbState.AutoSize = true;
            this.rbState.Location = new System.Drawing.Point(142, 38);
            this.rbState.Name = "rbState";
            this.rbState.Size = new System.Drawing.Size(82, 17);
            this.rbState.TabIndex = 1;
            this.rbState.Text = "Player State";
            this.rbState.UseVisualStyleBackColor = true;
            this.rbState.CheckedChanged += new System.EventHandler(this.rbState_CheckedChanged);
            // 
            // rbOff
            // 
            this.rbOff.AutoSize = true;
            this.rbOff.Checked = true;
            this.rbOff.Location = new System.Drawing.Point(164, 15);
            this.rbOff.Name = "rbOff";
            this.rbOff.Size = new System.Drawing.Size(39, 17);
            this.rbOff.TabIndex = 0;
            this.rbOff.TabStop = true;
            this.rbOff.Text = "Off";
            this.rbOff.UseVisualStyleBackColor = true;
            this.rbOff.CheckedChanged += new System.EventHandler(this.rbOff_CheckedChanged);
            // 
            // nudPosition
            // 
            this.nudPosition.Location = new System.Drawing.Point(99, 45);
            this.nudPosition.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudPosition.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPosition.Name = "nudPosition";
            this.nudPosition.Size = new System.Drawing.Size(273, 20);
            this.nudPosition.TabIndex = 3;
            this.nudPosition.Value = global::Pytel_WinForm.Properties.Settings.Default.positionChange;
            this.nudPosition.ValueChanged += new System.EventHandler(this.nudPosition_ValueChanged);
            // 
            // lPosition
            // 
            this.lPosition.AutoSize = true;
            this.lPosition.Location = new System.Drawing.Point(6, 47);
            this.lPosition.Name = "lPosition";
            this.lPosition.Size = new System.Drawing.Size(87, 13);
            this.lPosition.TabIndex = 2;
            this.lPosition.Text = "Position Change:";
            // 
            // nudVolume
            // 
            this.nudVolume.Location = new System.Drawing.Point(97, 19);
            this.nudVolume.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudVolume.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudVolume.Name = "nudVolume";
            this.nudVolume.Size = new System.Drawing.Size(275, 20);
            this.nudVolume.TabIndex = 1;
            this.nudVolume.Value = global::Pytel_WinForm.Properties.Settings.Default.volumeChange;
            this.nudVolume.ValueChanged += new System.EventHandler(this.nudVolume_ValueChanged);
            // 
            // lVolume
            // 
            this.lVolume.AutoSize = true;
            this.lVolume.Location = new System.Drawing.Point(6, 21);
            this.lVolume.Name = "lVolume";
            this.lVolume.Size = new System.Drawing.Size(85, 13);
            this.lVolume.TabIndex = 0;
            this.lVolume.Text = "Volume Change:";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 588);
            this.Controls.Add(this.gbSettings);
            this.Controls.Add(this.gbShortcuts);
            this.Controls.Add(this.gbAbout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About Pytel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.About_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.About_KeyDown);
            this.gbAbout.ResumeLayout(false);
            this.gbAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.gbShortcuts.ResumeLayout(false);
            this.gbSettings.ResumeLayout(false);
            this.gbSettings.PerformLayout();
            this.gbYT.ResumeLayout(false);
            this.gbYT.PerformLayout();
            this.gbSettingsTaskbar.ResumeLayout(false);
            this.gbSettingsTaskbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVolume)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAbout;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.Label lAbout;
        private System.Windows.Forms.GroupBox gbShortcuts;
        private System.Windows.Forms.GroupBox gbSettings;
        private System.Windows.Forms.ListBox lbShortcuts;
        private System.Windows.Forms.Label lVolume;
        private System.Windows.Forms.GroupBox gbSettingsTaskbar;
        private System.Windows.Forms.RadioButton rbPosition;
        private System.Windows.Forms.RadioButton rbState;
        private System.Windows.Forms.RadioButton rbOff;
        private System.Windows.Forms.NumericUpDown nudPosition;
        private System.Windows.Forms.Label lPosition;
        private System.Windows.Forms.NumericUpDown nudVolume;
        private System.Windows.Forms.RadioButton rbVolume;
        private System.Windows.Forms.RadioButton rbPlaylist;
        private System.Windows.Forms.LinkLabel llScreenshotFolder;
        private System.Windows.Forms.Button bChangeSCRLocation;
        private System.Windows.Forms.Label lScreenshot;
        private System.Windows.Forms.GroupBox gbYT;
        private System.Windows.Forms.CheckBox chbYTEnable;
        private System.Windows.Forms.Button bFFmgegPath;
        private System.Windows.Forms.Button bYTytdlPath;
        private System.Windows.Forms.TextBox tbYTytdlPath;
        private System.Windows.Forms.Label lYTytdlPath;
        private System.Windows.Forms.Label lFFmgegPath;
        private System.Windows.Forms.TextBox tbFFmgegPath;
    }
}