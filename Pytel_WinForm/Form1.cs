using System;
using System.Windows.Forms;
using Mpv.NET.Player;

namespace Pytel_WinForm
{

    public partial class Form1 : Form
    {
        MpvPlayer player;
        public int saveLocalVolume = 0;

        public Form1() { InitializeComponent(); player = new MpvPlayer(panel1.Handle); player.Volume = 100; }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e) { player.Dispose(); }
        private void tbPosition_Scroll(object sender, EventArgs e) { player.Position = TimeSpan.FromSeconds(tbPosition.Value); }
        private void openToolStripMenuItem_Click(object sender, EventArgs e) { player.Pause(); if (ofdFile.ShowDialog() == DialogResult.OK) { player.Load(ofdFile.FileName); player.Resume(); tDuration.Start(); } else { player.Resume(); } }
        private void tsbPrevious_Click(object sender, EventArgs e) { player.PlaylistPrevious(); }
        private void tsbNext_Click(object sender, EventArgs e) { player.PlaylistNext(); }
        private void tsbPlay_Click(object sender, EventArgs e) { player.Resume(); }
        private void tsbPause_Click(object sender, EventArgs e) { player.Pause(); }
        private void tsbStop_Click(object sender, EventArgs e) { player.Stop(); }

        private void tDuration_Tick(object sender, EventArgs e)
        {
            tbPosition.Maximum = (int)player.Duration.TotalSeconds;
            string hoursPosition = null;
            string hoursTotal = null;
            if (player.Duration.Hours.ToString("00") != "00") { hoursPosition = player.Position.Hours.ToString("00") + ":"; };
            if (player.Duration.Hours.ToString("00") != "00") { hoursTotal = player.Duration.Hours.ToString("00") + ":"; };
            tslDuration.Text = $"{hoursPosition}{player.Position.Minutes:00}:{player.Position.Seconds:00}/{hoursTotal}{player.Duration.Minutes:00}:{player.Duration.Seconds:00}";
        }

        private void tControls_Tick(object sender, EventArgs e) 
        { 
            tbPosition.Enabled = player.IsMediaLoaded;
            tbVolume.Enabled = player.IsMediaLoaded;
            tbPosition.Value = (int)player.Position.TotalSeconds;
            tbVolume.Value = (int)player.Volume;
            tsb10SecBack.Enabled = player.Position.TotalSeconds >= 10;
            tsb10SecForward.Enabled = player.Duration.TotalSeconds - player.Position.TotalSeconds >= 10;
        }

        private void tbVolume_Scroll(object sender, EventArgs e) { player.Volume = tbVolume.Value; }
        private void tbVolume_MouseUp(object sender, MouseEventArgs e) { if (e.Button == MouseButtons.Right) { if (player.Volume == 0) { player.Volume = saveLocalVolume; } else { saveLocalVolume = player.Volume; player.Volume = 0; } } }

        private void tsb10SecBack_Click(object sender, EventArgs e) { player.SeekAsync(player.Position.TotalSeconds - 10); }
        private void tsb10SecForward_Click(object sender, EventArgs e) { player.SeekAsync(player.Position.TotalSeconds + 10); }
    }
}
