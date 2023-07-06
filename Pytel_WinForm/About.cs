using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pytel_WinForm.Properties;

namespace Pytel_WinForm
{
    public partial class About : Form
    {
        public About() { InitializeComponent(); switch (Settings.Default.tbVisual) { case 0: rbOff.Checked = true; break; case 1: rbState.Checked = true; break; case 2: rbPosition.Checked = true; break; case 3: rbVolume.Checked = true; break; } }
        private void About_FormClosing(object sender, FormClosingEventArgs e) { Settings.Default.Save(); }
        private void nudVolume_ValueChanged(object sender, EventArgs e) { Settings.Default.volumeChange = nudVolume.Value; }
        private void nudPosition_ValueChanged(object sender, EventArgs e) { Settings.Default.positionChange = nudPosition.Value; }
        private void rbOff_CheckedChanged(object sender, EventArgs e) { Settings.Default.tbVisual = 0; }
        private void rbState_CheckedChanged(object sender, EventArgs e) { Settings.Default.tbVisual = 1; }
        private void rbPosition_CheckedChanged(object sender, EventArgs e) { Settings.Default.tbVisual = 2; }
        private void rbVolume_CheckedChanged(object sender, EventArgs e) { Settings.Default.tbVisual = 3; }
        private void pictureBox1_Click(object sender, EventArgs e) { lbShortcuts.Items.Add("++;"); }
    }
}
