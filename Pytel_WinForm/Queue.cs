using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Pytel_WinForm.Properties;

namespace Pytel_WinForm
{
    public partial class Queue : Form
    {
        BindingList<string> mediaQueue;

        public Queue(List<string> listPass) { InitializeComponent(); mediaQueue = new BindingList<string>(listPass); }
        private void Queue_Load(object sender, EventArgs e)
        {
            lbList.DataSource = mediaQueue;
            switch (Settings.Default.queLoop)
            {
                case 0: rbOff.Checked = true; break;
                case 1: rbLoopOne.Checked = true; break;
                case 2: rbLoopPlaylist.Checked = true; break;
            }
        }

        private void Queue_FormClosing(object sender, FormClosingEventArgs e) { Settings.Default.Save(); }
        private void bPlaylistSave_Click(object sender, EventArgs e) { try { if(sfdSave.ShowDialog() == DialogResult.OK) { File.WriteAllLines(sfdSave.FileName, mediaQueue.ToArray()); } } catch { MessageBox.Show("Opening dialog failed. Please try again.", "Opening dialog failed", MessageBoxButtons.OK, MessageBoxIcon.Error); } }
        private void bPlaylistClear_Click(object sender, EventArgs e) { mediaQueue.Clear(); Settings.Default.Save(); }
        private void bPlaylistAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (ofdAdd.ShowDialog() == DialogResult.OK)
                {
                    for (int i = 0; i < ofdAdd.FileNames.Count(); i++) {
                        if (Path.GetExtension(ofdAdd.FileNames[i]) == ".m3u")
                        {
                            String[] inputing = File.ReadAllLines(ofdAdd.FileNames[i]);
                            foreach(string item in inputing) { mediaQueue.Add(item); }
                        } else { mediaQueue.Add(ofdAdd.FileNames[i]); }
                    }
                }
            } catch { MessageBox.Show("Opening dialog failed. Please try again.", "Opening dialog failed", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void bPlaylistDelete_Click(object sender, EventArgs e) { mediaQueue.RemoveAt(lbList.SelectedIndex); }
        private void rbOff_CheckedChanged(object sender, EventArgs e) { Settings.Default.queLoop = 0; }
        private void rbLoopOne_CheckedChanged(object sender, EventArgs e) { Settings.Default.queLoop = 1; }
        private void rbLoopPlaylist_CheckedChanged(object sender, EventArgs e) { Settings.Default.queLoop = 2; }
        private void tControls_Tick(object sender, EventArgs e)
        {
            bPlaylistPlay.Enabled = lbList.Items.Count == 0 ? false : true;
            bPlaylistSave.Enabled = lbList.Items.Count == 0 ? false : true;
            bPlaylistClear.Enabled = lbList.Items.Count == 0 ? false : true;
            bPlaylistDelete.Enabled = lbList.SelectedItems.Count == 0 ? false : true;
            bPlaylistPlaySelected.Enabled = lbList.SelectedItems.Count == 0 ? false : true;
        }

        public List<string> getEditedMediaQueue() { return mediaQueue.ToList(); }
        private void Queue_KeyDown(object sender, KeyEventArgs e) { e.SuppressKeyPress = true; if(e.KeyCode == Keys.Escape) { DialogResult = DialogResult.Cancel; } }

        private void lbList_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] validFileExtension = { ".avi", ".mkv", ".mp4", ".m4a", ".m4v", ".ogg", ".mpg", ".mpeg", ".mpv", ".mp3", ".wmv", ".wma", ".mov", ".m3u" };
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                for (int i = 0; i < files.Length; i++) { if (validFileExtension.Contains(Path.GetExtension(files[i]))) fileLoad(files[i]); }

            }
        }

        private void fileLoad(string FileName)
        {
            if (Path.GetExtension(FileName) == ".m3u")
            {
                string[] inputing = File.ReadAllLines(FileName);
                foreach (string item in inputing) { fileLoad(item); }
            }
            else { mediaQueue.Add(FileName); }
        }

        private void lbList_DragEnter(object sender, DragEventArgs e) { e.Effect = DragDropEffects.Copy; }
    }
}
