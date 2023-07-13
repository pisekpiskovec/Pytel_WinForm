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
            if (Settings.Default.queCurrentPlaylist != null || !Settings.Default.queCurrentPlaylist.Equals(""))
            {
                string[] itemsToAdd = Settings.Default.queCurrentPlaylist.Split(separator, StringSplitOptions.RemoveEmptyEntries);
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
        private void bPlaylistLoad_Click(object sender, EventArgs e)
        {
            if (ofdLoad.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(ofdLoad.FileName);
                string[] inputing = reader.ReadToEnd().Split(separator, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < inputing.Length; i++) { lbList.Items.Add(inputing[i]); Settings.Default.queCurrentPlaylist += inputing[i] + "\n"; }
                Settings.Default.Save();
            }
        }

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

        private void bPlaylistClear_Click(object sender, EventArgs e) { lbList.Items.Clear(); Settings.Default.queCurrentPlaylist = ""; Settings.Default.queIndex = 0; }
        private void bPlaylistAdd_Click(object sender, EventArgs e)
        {
            if (ofdAdd.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < ofdAdd.FileNames.Count(); i++) { lbList.Items.Add(ofdAdd.FileNames[i]); Settings.Default.queCurrentPlaylist += ofdAdd.FileNames[i] + "\n"; }
                Settings.Default.Save();
            }
        }
        private void bPlaylistDelete_Click(object sender, EventArgs e) { if ( lbList.SelectedItems.Count != 0 ) lbList.Items.RemoveAt(lbList.SelectedIndex); }
        private void bPlaylistPlay_Click(object sender, EventArgs e) { mainForm.loadMedia(lbList.Items[0].ToString()); }
        private void rbOff_CheckedChanged(object sender, EventArgs e) { Settings.Default.queLoop = 0; }
        private void rbLoopPlaylist_CheckedChanged(object sender, EventArgs e) { Settings.Default.queLoop = 1; }
        private void rbLoopOne_CheckedChanged(object sender, EventArgs e) { Settings.Default.queLoop = 2; }
    }
}
