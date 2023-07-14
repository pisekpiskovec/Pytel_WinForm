namespace Pytel_WinForm
{
    partial class Queue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Queue));
            this.gbPlaylist = new System.Windows.Forms.GroupBox();
            this.bPlaylistPlay = new System.Windows.Forms.Button();
            this.bPlaylistDelete = new System.Windows.Forms.Button();
            this.lbList = new System.Windows.Forms.ListBox();
            this.bPlaylistAdd = new System.Windows.Forms.Button();
            this.bPlaylistClear = new System.Windows.Forms.Button();
            this.bPlaylistSave = new System.Windows.Forms.Button();
            this.bPlaylistLoad = new System.Windows.Forms.Button();
            this.gbLoop = new System.Windows.Forms.GroupBox();
            this.rbLoopOne = new System.Windows.Forms.RadioButton();
            this.rbLoopPlaylist = new System.Windows.Forms.RadioButton();
            this.rbOff = new System.Windows.Forms.RadioButton();
            this.ofdLoad = new System.Windows.Forms.OpenFileDialog();
            this.sfdSave = new System.Windows.Forms.SaveFileDialog();
            this.ofdAdd = new System.Windows.Forms.OpenFileDialog();
            this.gbPlaylist.SuspendLayout();
            this.gbLoop.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPlaylist
            // 
            this.gbPlaylist.Controls.Add(this.bPlaylistPlay);
            this.gbPlaylist.Controls.Add(this.bPlaylistDelete);
            this.gbPlaylist.Controls.Add(this.lbList);
            this.gbPlaylist.Controls.Add(this.bPlaylistAdd);
            this.gbPlaylist.Controls.Add(this.bPlaylistClear);
            this.gbPlaylist.Controls.Add(this.bPlaylistSave);
            this.gbPlaylist.Controls.Add(this.bPlaylistLoad);
            this.gbPlaylist.Location = new System.Drawing.Point(12, 12);
            this.gbPlaylist.Name = "gbPlaylist";
            this.gbPlaylist.Size = new System.Drawing.Size(325, 320);
            this.gbPlaylist.TabIndex = 0;
            this.gbPlaylist.TabStop = false;
            this.gbPlaylist.Text = "Playlist";
            // 
            // bPlaylistPlay
            // 
            this.bPlaylistPlay.Enabled = false;
            this.bPlaylistPlay.Location = new System.Drawing.Point(244, 291);
            this.bPlaylistPlay.Name = "bPlaylistPlay";
            this.bPlaylistPlay.Size = new System.Drawing.Size(75, 23);
            this.bPlaylistPlay.TabIndex = 6;
            this.bPlaylistPlay.Text = "Play Playlist";
            this.bPlaylistPlay.UseVisualStyleBackColor = true;
            this.bPlaylistPlay.Click += new System.EventHandler(this.bPlaylistPlay_Click);
            // 
            // bPlaylistDelete
            // 
            this.bPlaylistDelete.Location = new System.Drawing.Point(244, 158);
            this.bPlaylistDelete.Name = "bPlaylistDelete";
            this.bPlaylistDelete.Size = new System.Drawing.Size(75, 46);
            this.bPlaylistDelete.TabIndex = 5;
            this.bPlaylistDelete.Text = "Delete from Playlist";
            this.bPlaylistDelete.UseVisualStyleBackColor = true;
            this.bPlaylistDelete.Click += new System.EventHandler(this.bPlaylistDelete_Click);
            // 
            // lbList
            // 
            this.lbList.FormattingEnabled = true;
            this.lbList.Location = new System.Drawing.Point(6, 19);
            this.lbList.Name = "lbList";
            this.lbList.Size = new System.Drawing.Size(232, 290);
            this.lbList.TabIndex = 4;
            // 
            // bPlaylistAdd
            // 
            this.bPlaylistAdd.Location = new System.Drawing.Point(244, 106);
            this.bPlaylistAdd.Name = "bPlaylistAdd";
            this.bPlaylistAdd.Size = new System.Drawing.Size(75, 46);
            this.bPlaylistAdd.TabIndex = 3;
            this.bPlaylistAdd.Text = "Add to Playlist";
            this.bPlaylistAdd.UseVisualStyleBackColor = true;
            this.bPlaylistAdd.Click += new System.EventHandler(this.bPlaylistAdd_Click);
            // 
            // bPlaylistClear
            // 
            this.bPlaylistClear.Location = new System.Drawing.Point(244, 77);
            this.bPlaylistClear.Name = "bPlaylistClear";
            this.bPlaylistClear.Size = new System.Drawing.Size(75, 23);
            this.bPlaylistClear.TabIndex = 2;
            this.bPlaylistClear.Text = "Clear Playlist";
            this.bPlaylistClear.UseVisualStyleBackColor = true;
            this.bPlaylistClear.Click += new System.EventHandler(this.bPlaylistClear_Click);
            // 
            // bPlaylistSave
            // 
            this.bPlaylistSave.Location = new System.Drawing.Point(244, 48);
            this.bPlaylistSave.Name = "bPlaylistSave";
            this.bPlaylistSave.Size = new System.Drawing.Size(75, 23);
            this.bPlaylistSave.TabIndex = 1;
            this.bPlaylistSave.Text = "Save Playlist";
            this.bPlaylistSave.UseVisualStyleBackColor = true;
            this.bPlaylistSave.Click += new System.EventHandler(this.bPlaylistSave_Click);
            // 
            // bPlaylistLoad
            // 
            this.bPlaylistLoad.Location = new System.Drawing.Point(244, 19);
            this.bPlaylistLoad.Name = "bPlaylistLoad";
            this.bPlaylistLoad.Size = new System.Drawing.Size(75, 23);
            this.bPlaylistLoad.TabIndex = 0;
            this.bPlaylistLoad.Text = "Load Playlist";
            this.bPlaylistLoad.UseVisualStyleBackColor = true;
            this.bPlaylistLoad.Click += new System.EventHandler(this.bPlaylistLoad_Click);
            // 
            // gbLoop
            // 
            this.gbLoop.Controls.Add(this.rbLoopOne);
            this.gbLoop.Controls.Add(this.rbLoopPlaylist);
            this.gbLoop.Controls.Add(this.rbOff);
            this.gbLoop.Location = new System.Drawing.Point(12, 338);
            this.gbLoop.Name = "gbLoop";
            this.gbLoop.Size = new System.Drawing.Size(325, 100);
            this.gbLoop.TabIndex = 1;
            this.gbLoop.TabStop = false;
            this.gbLoop.Text = "Looping";
            // 
            // rbLoopOne
            // 
            this.rbLoopOne.AutoSize = true;
            this.rbLoopOne.Location = new System.Drawing.Point(126, 65);
            this.rbLoopOne.Name = "rbLoopOne";
            this.rbLoopOne.Size = new System.Drawing.Size(72, 17);
            this.rbLoopOne.TabIndex = 2;
            this.rbLoopOne.Text = "Loop One";
            this.rbLoopOne.UseVisualStyleBackColor = true;
            this.rbLoopOne.CheckedChanged += new System.EventHandler(this.rbLoopOne_CheckedChanged);
            // 
            // rbLoopPlaylist
            // 
            this.rbLoopPlaylist.AutoSize = true;
            this.rbLoopPlaylist.Enabled = false;
            this.rbLoopPlaylist.Location = new System.Drawing.Point(120, 42);
            this.rbLoopPlaylist.Name = "rbLoopPlaylist";
            this.rbLoopPlaylist.Size = new System.Drawing.Size(84, 17);
            this.rbLoopPlaylist.TabIndex = 1;
            this.rbLoopPlaylist.Text = "Loop Playlist";
            this.rbLoopPlaylist.UseVisualStyleBackColor = true;
            this.rbLoopPlaylist.CheckedChanged += new System.EventHandler(this.rbLoopPlaylist_CheckedChanged);
            // 
            // rbOff
            // 
            this.rbOff.AutoSize = true;
            this.rbOff.Checked = true;
            this.rbOff.Location = new System.Drawing.Point(143, 19);
            this.rbOff.Name = "rbOff";
            this.rbOff.Size = new System.Drawing.Size(39, 17);
            this.rbOff.TabIndex = 0;
            this.rbOff.TabStop = true;
            this.rbOff.Text = "Off";
            this.rbOff.UseVisualStyleBackColor = true;
            this.rbOff.CheckedChanged += new System.EventHandler(this.rbOff_CheckedChanged);
            // 
            // ofdLoad
            // 
            this.ofdLoad.DefaultExt = "m3u";
            this.ofdLoad.Filter = "MP3 URL|*.m3u";
            this.ofdLoad.RestoreDirectory = true;
            this.ofdLoad.Title = "Load Playlist";
            // 
            // sfdSave
            // 
            this.sfdSave.DefaultExt = "m3u";
            this.sfdSave.FileName = "playlist";
            this.sfdSave.Filter = "MP3 URL|*.m3u";
            this.sfdSave.Title = "Save Playlist";
            // 
            // ofdAdd
            // 
            this.ofdAdd.DefaultExt = "mp3";
            this.ofdAdd.Filter = resources.GetString("ofdAdd.Filter");
            this.ofdAdd.Multiselect = true;
            this.ofdAdd.Title = "Add to Playlist";
            // 
            // Queue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 450);
            this.Controls.Add(this.gbLoop);
            this.Controls.Add(this.gbPlaylist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Queue";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Queue";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Queue_FormClosing);
            this.Load += new System.EventHandler(this.Queue_Load);
            this.gbPlaylist.ResumeLayout(false);
            this.gbLoop.ResumeLayout(false);
            this.gbLoop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPlaylist;
        private System.Windows.Forms.GroupBox gbLoop;
        private System.Windows.Forms.RadioButton rbOff;
        private System.Windows.Forms.RadioButton rbLoopOne;
        private System.Windows.Forms.RadioButton rbLoopPlaylist;
        private System.Windows.Forms.Button bPlaylistDelete;
        private System.Windows.Forms.ListBox lbList;
        private System.Windows.Forms.Button bPlaylistAdd;
        private System.Windows.Forms.Button bPlaylistClear;
        private System.Windows.Forms.Button bPlaylistSave;
        private System.Windows.Forms.Button bPlaylistLoad;
        private System.Windows.Forms.Button bPlaylistPlay;
        private System.Windows.Forms.OpenFileDialog ofdLoad;
        private System.Windows.Forms.SaveFileDialog sfdSave;
        private System.Windows.Forms.OpenFileDialog ofdAdd;
    }
}