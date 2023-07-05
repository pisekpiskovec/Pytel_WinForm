using System;
using System.Drawing;
using System.Windows.Forms;
using Mpv.NET.Player;

namespace Pytel_WinForm
{

    public partial class Form1 : Form
    {
        MpvPlayer player;
        int saveLocalVolume = 0;
        bool isMediaLoaded = false;
        bool isMediaPlaying = false;
        bool isFullScreen = false;

        public Form1() { InitializeComponent(); player = new MpvPlayer(pPlayer.Handle); player.Volume = 100; player.MediaFinished += this.mediaFinished; }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e) { player.Dispose(); }
        private void tbPosition_Seek(object sender, EventArgs e) { player.Position = TimeSpan.FromSeconds(tbPosition.Value); }
        private void tsmiOpenFile_Click(object sender, EventArgs e)
        {
            player.Pause();
            if (ofdFile.ShowDialog() == DialogResult.OK)
            {
                player.Load(ofdFile.FileName);
                this.Text = "Pytel | " + ofdFile.SafeFileName;
                isMediaLoaded = true;
                player.Resume();
                isMediaPlaying = true;
                tDuration.Start();
            }
            else { player.Resume(); }
        }

        private void tsbPrevious_Click(object sender, EventArgs e) { player.PlaylistPrevious(); }
        private void tsbNext_Click(object sender, EventArgs e) { player.PlaylistNext(); }
        private void tsbPlay_Click(object sender, EventArgs e) { player.Resume(); isMediaPlaying = true; if (isFullScreen && tsFullScreen.Visible) { tsFullScreen.Visible = false; } }
        private void tsbPause_Click(object sender, EventArgs e) { player.Pause(); isMediaPlaying = false; }
        private void tsbStop_Click(object sender, EventArgs e) { player.Stop(); isMediaPlaying = false; isMediaLoaded = false; }
        private void tDuration_Tick(object sender, EventArgs e)
        {
            tbPosition.Maximum = (int)player.Duration.TotalSeconds;
            tspbPosition.Maximum = (int)player.Duration.TotalSeconds;
            string hoursPosition = null;
            string hoursTotal = null;
            if (player.Duration.Hours.ToString("00") != "00") { hoursPosition = player.Position.Hours.ToString("00") + ":"; };
            if (player.Duration.Hours.ToString("00") != "00") { hoursTotal = player.Duration.Hours.ToString("00") + ":"; };
            tslDuration.Text = $"{hoursPosition}{player.Position.Minutes:00}:{player.Position.Seconds:00}/{hoursTotal}{player.Duration.Minutes:00}:{player.Duration.Seconds:00}";
            tslFSDuration.Text = $"{hoursPosition}{player.Position.Minutes:00}:{player.Position.Seconds:00}/{hoursTotal}{player.Duration.Minutes:00}:{player.Duration.Seconds:00}";
            tslDuration.ToolTipText = $"Volume: {player.Volume.ToString()}%";
            tslFSDuration.ToolTipText = $"Volume: {player.Volume.ToString()}%";
        }

        private void tControls_Tick(object sender, EventArgs e)
        {
            pFullScreenControl.Visible = isFullScreen;
            tsBasic.Visible = !isFullScreen;
            pBottom.Visible = !isFullScreen;
            if (!isMediaPlaying) { tsFullScreen.Visible = isFullScreen; }
            tbPosition.Enabled = isMediaLoaded;
            tbVolume.Enabled = isMediaLoaded;
            tsbFullScreen.Enabled = isMediaLoaded;
            tbPosition.Value = (int)player.Position.TotalSeconds;
            tspbPosition.Value = (int)player.Position.TotalSeconds;
            tspbPosition.Size = new System.Drawing.Size(tsFullScreen.Width - (tslFSDuration.Text.Length == 11 ? 267 : 297), 22);
            tbVolume.Value = (int)player.Volume;
            tspbVolume.Value = (int)player.Volume;
            tsb10SecBack.Enabled = player.Position.TotalSeconds >= 10;
            tsb10SecForward.Enabled = player.Duration.TotalSeconds - player.Position.TotalSeconds >= 10;
        }

        private void tbVolume_Scroll(object sender, EventArgs e) { player.Volume = tbVolume.Value; }
        private void tbVolume_MouseUp(object sender, MouseEventArgs e) { if (e.Button == MouseButtons.Right) { if (player.Volume == 0) { player.Volume = saveLocalVolume; } else { saveLocalVolume = player.Volume; player.Volume = 0; } } }
        private void tsb10SecBack_Click(object sender, EventArgs e) { player.SeekAsync(player.Position.TotalSeconds - 10); }
        private void tsb10SecForward_Click(object sender, EventArgs e) { player.SeekAsync(player.Position.TotalSeconds + 10); }
        private void pPlayer_MouseClick(object sender, MouseEventArgs e) { if (e.Button == MouseButtons.Right) { if (isMediaPlaying) { tsbPause.PerformClick(); } else { tsbPlay.PerformClick(); } } }
        private void tsbFSPlay_Click(object sender, EventArgs e) { player.Resume(); isMediaPlaying = true; }
        private void tsbFSPause_Click(object sender, EventArgs e) { player.Pause(); isMediaPlaying = false; }
        private void tsbFullScreen_Click(object sender, EventArgs e)
        {
            isFullScreen = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void tsbExitFullScreen_Click(object sender, EventArgs e)
        {
            isFullScreen = false;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.WindowState = FormWindowState.Normal;
        }

        private void panel1_MouseEnter(object sender, EventArgs e) { tsFullScreen.Visible = true; }
        private void panel1_MouseLeave(object sender, EventArgs e) { tsFullScreen.Visible = false; }
        private void tspbPosition_Click(object sender, EventArgs e)
        {
            float absoluteMouse = (PointToClient(MousePosition).X - tspbPosition.Bounds.X);
            float calcFactor = tspbPosition.Width / (float)tspbPosition.Maximum;
            float relativeMouse = absoluteMouse / calcFactor;
            player.Position = TimeSpan.FromSeconds(Convert.ToInt32(relativeMouse));
        }

        private void tspbVolume_Click(object sender, EventArgs e)
        {
            float absoluteMouse = (PointToClient(MousePosition).X - tspbVolume.Bounds.X);
            float calcFactor = tspbVolume.Width / (float)tspbVolume.Maximum;
            float relativeMouse = absoluteMouse / calcFactor;
            player.Volume = Convert.ToInt32(relativeMouse);
        }

        private void tsmiOpenFileUniversal_Click(object sender, EventArgs e)
        {
            player.Pause();
            if (ofdUniversal.ShowDialog() == DialogResult.OK)
            {
                player.Load(ofdUniversal.FileName);
                this.Text = "Pytel | " + ofdUniversal.SafeFileName;
                isMediaLoaded = true;
                player.Resume();
                isMediaPlaying = true;
                tDuration.Start();
            }
            else { player.Resume(); }
        }

        private void mediaFinished(object sender, EventArgs e) { isMediaPlaying = false; isMediaLoaded = false; isFullScreen = false; this.FormBorderStyle = FormBorderStyle.Sizable; this.WindowState = FormWindowState.Normal; this.Text = "Pytel"; }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
            if (e.Control && e.Shift)
            {
                if (e.KeyCode == Keys.O) { tsmiOpenURL.PerformClick(); }
            }
            else if (e.Control && e.Alt)
            {
                if (e.KeyCode == Keys.O) { tsmiOpenFileUniversal.PerformClick(); }
                else if (e.KeyCode == Keys.F6) { isFullScreen = false; this.FormBorderStyle = FormBorderStyle.Sizable; this.WindowState = FormWindowState.Normal; this.Location = new Point(0, 0); }

            }
            else if (e.Control)
            {
                if (e.KeyCode == Keys.O) { tsmiOpenFile.PerformClick(); }
                else if (e.KeyCode == Keys.L) { tsbQueue.PerformClick(); }
                else if (e.KeyCode == Keys.Oemcomma) { tsbPrevious.PerformClick(); }
                else if (e.KeyCode == Keys.S) { tsbStop.PerformClick(); }
                else if (e.KeyCode == Keys.OemPeriod) { tsbNext.PerformClick(); }
            }
            else if (e.Alt) { if (e.KeyCode == Keys.F4) { player.Stop(); Application.Exit(); } }
            else if (e.KeyCode == Keys.F9) { tsbQueue.PerformClick(); }
            else if (e.KeyCode == Keys.F || e.KeyCode == Keys.F11) { if (isFullScreen) { tsbExitFullScreen.PerformClick(); } else { tsbFullScreen.PerformClick(); } }
            else if (e.KeyCode == Keys.Escape) { if (isFullScreen) { tsbExitFullScreen.PerformClick(); } }
            else if (e.KeyCode == Keys.Left) { tsb10SecBack.PerformClick(); }
            else if (e.KeyCode == Keys.P || e.KeyCode == Keys.Space) { if (isMediaPlaying) { tsbPause.PerformClick(); } else { tsbPlay.PerformClick(); } }
            else if (e.KeyCode == Keys.Right) { tsb10SecForward.PerformClick(); }
            else if (e.KeyCode == Keys.Up) { if (isMediaPlaying & !(player.Volume + 10 > 100)) { player.Volume += 10; } }
            else if (e.KeyCode == Keys.Down) { if (isMediaPlaying & !(player.Volume - 10 < 0)) { player.Volume -= 10; } }
            else if (e.KeyCode == Keys.M) { if (player.Volume == 0) { player.Volume = saveLocalVolume; } else { saveLocalVolume = player.Volume; player.Volume = 0; } }
            else if (e.KeyCode == Keys.Q) { player.Stop(); Application.Exit(); }
        }

        private void pPlayer_MouseDoubleClick(object sender, MouseEventArgs e) { { if (e.Button == MouseButtons.Left) { if (isFullScreen) { tsbExitFullScreen.PerformClick(); } else { tsbFullScreen.PerformClick(); } } } }
    }
}
