using Pytel_WinForm.Properties;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Pytel_WinForm
{
    public partial class Queue : Form
    {
        string[] separator = { "\n" };
        public Main mainForm;

        public Queue() { InitializeComponent(); }
        private void Queue_Load(object sender, EventArgs e)
        {
            if (Settings.Default.quePlaylist != null || !Settings.Default.quePlaylist.Equals(""))
            {
                string[] itemsToAdd = Settings.Default.quePlaylist.ToString().Split(separator, StringSplitOptions.RemoveEmptyEntries);
                foreach (string item in itemsToAdd) { lbList.Items.Add(item); }
            }
            switch (Settings.Default.queLoop) 
            {
                case 0: 
                    rbOff.Checked = true; break; 
                case 1: 
                    rbLoopPlaylist.Checked = true; break; 
                case 2: 
                    rbLoopOne.Checked = true; break; 
            }
        }

        private void Queue_FormClosing(object sender, FormClosingEventArgs e) { Settings.Default.Save(); }
        private void bPlaylistSave_Click(object sender, EventArgs e)
        {
            if (sfdSave.ShowDialog() == DialogResult.OK)
            {
                String[] inputing = {};
                Array.Resize(ref inputing, lbList.Items.Count);
                for (int i = 0; i < lbList.Items.Count;i++) { inputing[i] = lbList.Items[i].ToString(); }
                System.IO.File.WriteAllLines(sfdSave.FileName, inputing);
            }
        }

        private void bPlaylistClear_Click(object sender, EventArgs e) { lbList.Items.Clear(); Settings.Default.quePlaylist = ""; Settings.Default.queIndex = 0; Settings.Default.Save(); }
        private void bPlaylistAdd_Click(object sender, EventArgs e)
        {
            if (ofdAdd.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < ofdAdd.FileNames.Count(); i++) { lbList.Items.Add(ofdAdd.FileNames[i]); Settings.Default.quePlaylist += ofdAdd.FileNames[i] + "\n"; }
                Settings.Default.Save();
            }
        }
        private void bPlaylistDelete_Click(object sender, EventArgs e)
        {
            if (lbList.SelectedItems.Count != 0)
            {
                string[] playlistArr = Settings.Default.quePlaylist.Split('\n');
                int selIndex = lbList.SelectedIndex;
                playlistArr = playlistArr.Where((val, idx) => idx !=  selIndex).ToArray();
                Settings.Default.quePlaylist = string.Join("\n", playlistArr);
                Settings.Default.Save();
                lbList.Items.RemoveAt(lbList.SelectedIndex);
            } 
        }
        private void bPlaylistPlay_Click(object sender, EventArgs e) { Settings.Default.queIndex = 0; Settings.Default.Save(); }
        private void rbOff_CheckedChanged(object sender, EventArgs e) { Settings.Default.queLoop = 0; }
        private void rbLoopPlaylist_CheckedChanged(object sender, EventArgs e) { Settings.Default.queLoop = 1; }
        private void rbLoopOne_CheckedChanged(object sender, EventArgs e) { Settings.Default.queLoop = 2; }

        private void tControls_Tick(object sender, EventArgs e)
        {
            bPlaylistPlay.Enabled = lbList.Items.Count == 0 ? false : true;
            bPlaylistSave.Enabled = lbList.Items.Count == 0 ? false : true;
            bPlaylistClear.Enabled = lbList.Items.Count == 0 ? false : true;
            bPlaylistDelete.Enabled = lbList.SelectedItems.Count == 0 ? false : true;
        }
    }
}
