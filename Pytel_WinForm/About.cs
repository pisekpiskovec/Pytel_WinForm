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
        public About() { InitializeComponent(); }
        private void About_FormClosing(object sender, FormClosingEventArgs e) { Settings.Default.Save(); }
        private void nudVolume_ValueChanged(object sender, EventArgs e) { Settings.Default.volumeChange = nudVolume.Value; }
        private void nudPosition_ValueChanged(object sender, EventArgs e) { Settings.Default.positionChange = nudPosition.Value; }
        private void rbOff_CheckedChanged(object sender, EventArgs e) { Settings.Default.tbVisual = 0; }
        private void rbState_CheckedChanged(object sender, EventArgs e) { Settings.Default.tbVisual = 1; }
        private void rbPosition_CheckedChanged(object sender, EventArgs e) { Settings.Default.tbVisual = 2; }
        private void rbVolume_CheckedChanged(object sender, EventArgs e) { Settings.Default.tbVisual = 3; }
    }
}
