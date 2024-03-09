﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            lbList.Items.Clear();
            lbList.DataSource = mediaQueue;
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

        private void bPlaylistClear_Click(object sender, EventArgs e) { mediaQueue.Clear(); Settings.Default.queIndex = 0; Settings.Default.Save(); }
        private void bPlaylistAdd_Click(object sender, EventArgs e)
        {
            if (ofdAdd.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < ofdAdd.FileNames.Count(); i++) { mediaQueue.Add(ofdAdd.FileNames[i]); }
                Settings.Default.Save();
            }
        }
        private void bPlaylistDelete_Click(object sender, EventArgs e) { mediaQueue.RemoveAt(lbList.SelectedIndex); }
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

        public List<string> getEditedMediaQueue() { return mediaQueue.ToList(); }
    }
}
