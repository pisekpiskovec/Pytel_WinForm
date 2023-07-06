﻿using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mpv.NET.Player;
using Pytel_WinForm.Properties;

namespace Pytel_WinForm
{

    public partial class Main : Form
    {
        MpvPlayer player;
        int saveLocalVolume = 0;
        bool isMediaLoaded = false;
        bool isMediaPlaying = false;
        bool isFullScreen = false;
        string mediaPath;
        bool closedWithQ = false;
        int winState;

        public Main() 
        {
            InitializeComponent();
            player = new MpvPlayer(pPlayer.Handle);
            player.MediaFinished += this.mediaFinished; 
            this.Location = Settings.Default.lastPos;
            this.WindowState = (FormWindowState)Settings.Default.lastStat; 
            this.Size = Settings.Default.lastSize;
            player.Volume = Settings.Default.volumeLast;
            if (Settings.Default.mediaLast != "")
            {
                player.Load(Settings.Default.mediaLast);
                mediaPath = Settings.Default.mediaLast;
                Thread.Sleep(2000);
                this.Text = "Pytel | " + player.MediaTitle;
                isMediaLoaded = true;
                tDuration.Start();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.volumeLast = player.Volume;
            player.Dispose();
            Settings.Default.lastPos = this.Location;
            Settings.Default.lastStat = (int)this.WindowState;
            Settings.Default.lastSize = this.Size;
            if (closedWithQ) { Settings.Default.mediaLast = mediaPath; } else { Settings.Default.mediaLast = ""; }
            Settings.Default.Save();
        }

        private void tbPosition_Seek(object sender, EventArgs e) { player.Position = TimeSpan.FromSeconds(tbPosition.Value); }
        private void tsmiOpenFile_Click(object sender, EventArgs e)
        {
            player.Pause();
            if (ofdFile.ShowDialog() == DialogResult.OK)
            {
                player.Load(ofdFile.FileName);
                mediaPath = ofdFile.FileName;
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
        private void tsbStop_Click(object sender, EventArgs e) { player.Stop(); isMediaPlaying = false; isMediaLoaded = false; mediaPath = ""; Text = "Pytel"; }
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
            tslDuration.ToolTipText = $"Volume: {player.Volume.ToString()}%\nClick to open Settings.";
            tslFSDuration.ToolTipText = $"Volume: {player.Volume.ToString()}%";
        }

        private void tControls_Tick(object sender, EventArgs e)
        {
            pFullScreenControl.Visible = isFullScreen;
            tsBasic.Visible = !isFullScreen;
            pBottom.Visible = !isFullScreen;
            if (!isMediaPlaying) { tsFullScreen.Visible = isFullScreen; }
            tbPosition.Enabled = isMediaLoaded;
            tsbFullScreen.Enabled = isMediaLoaded;
            tbPosition.Value = (int)player.Position.TotalSeconds;
            tspbPosition.Value = (int)player.Position.TotalSeconds;
            tspbPosition.Size = new System.Drawing.Size(tsFullScreen.Width - (tslFSDuration.Text.Length == 11 ? 267 : 297), 22);
            tbVolume.Value = (int)player.Volume;
            tspbVolume.Value = (int)player.Volume;
            tsbSeekBack.Enabled = player.Position.TotalSeconds >= (double)Settings.Default.positionChange;
            tsbSeekForward.Enabled = player.Duration.TotalSeconds - player.Position.TotalSeconds >= (double)Settings.Default.positionChange;
        }

        private void tbVolume_Scroll(object sender, EventArgs e) { player.Volume = tbVolume.Value; }
        private void tbVolume_MouseUp(object sender, MouseEventArgs e) { if (e.Button == MouseButtons.Right) { if (player.Volume == 0) { player.Volume = saveLocalVolume; } else { saveLocalVolume = player.Volume; player.Volume = 0; } } }
        private void tsbSeekBack_Click(object sender, EventArgs e) { player.SeekAsync(player.Position.TotalSeconds - (double)Settings.Default.positionChange); }
        private void tsbSeekForward_Click(object sender, EventArgs e) { player.SeekAsync(player.Position.TotalSeconds + (double)Settings.Default.positionChange); }
        private void pPlayer_MouseClick(object sender, MouseEventArgs e) { if (e.Button == MouseButtons.Right) { if (isMediaPlaying) { tsbPause.PerformClick(); } else { tsbPlay.PerformClick(); } } }
        private void tsbFSPlay_Click(object sender, EventArgs e) { player.Resume(); isMediaPlaying = true; }
        private void tsbFSPause_Click(object sender, EventArgs e) { player.Pause(); isMediaPlaying = false; }
        private void tsbFullScreen_Click(object sender, EventArgs e)
        {
            isFullScreen = true;
            winState = (int)this.WindowState;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void tsbExitFullScreen_Click(object sender, EventArgs e)
        {
            isFullScreen = false;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.WindowState = (FormWindowState)winState;
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
                mediaPath = ofdUniversal.FileName;
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
                else if (e.KeyCode == Keys.Q) { if (isMediaPlaying) { closedWithQ = true; } player.Stop(); Application.Exit(); }
            }
            else if (e.Alt) { if (e.KeyCode == Keys.F4) { player.Stop(); Application.Exit(); } }
            else if (e.KeyCode == Keys.F9) { tsbQueue.PerformClick(); }
            else if (e.KeyCode == Keys.F || e.KeyCode == Keys.F11) { if (isFullScreen) { tsbExitFullScreen.PerformClick(); } else { tsbFullScreen.PerformClick(); } }
            else if (e.KeyCode == Keys.Escape) { if (isFullScreen) { tsbExitFullScreen.PerformClick(); } }
            else if (e.KeyCode == Keys.Left) { tsbSeekBack.PerformClick(); }
            else if (e.KeyCode == Keys.P || e.KeyCode == Keys.Space) { if (isMediaPlaying) { tsbPause.PerformClick(); } else { tsbPlay.PerformClick(); } }
            else if (e.KeyCode == Keys.Right) { tsbSeekForward.PerformClick(); }
            else if (e.KeyCode == Keys.Up) { if (!(player.Volume + Settings.Default.volumeChange > 100)) { player.Volume += (int)Settings.Default.volumeChange; } }
            else if (e.KeyCode == Keys.Down) { if (!(player.Volume - Settings.Default.volumeChange < 0)) { player.Volume -= (int)Settings.Default.volumeChange; } }
            else if (e.KeyCode == Keys.M) { if (player.Volume == 0) { player.Volume = saveLocalVolume; } else { saveLocalVolume = player.Volume; player.Volume = 0; } }
            else if (e.KeyCode == Keys.Q) { player.Stop(); Application.Exit(); }
        }

        private void pPlayer_MouseDoubleClick(object sender, MouseEventArgs e) { { if (e.Button == MouseButtons.Left) { if (isFullScreen) { tsbExitFullScreen.PerformClick(); } else { tsbFullScreen.PerformClick(); } } } }
        private void tslDuration_Click(object sender, EventArgs e) { About abt = new About(); abt.ShowDialog(); }

        private void tTaskbar_Tick(object sender, EventArgs e)
        {
            switch (Settings.Default.tbVisual)
            {
                case 0:
                    TaskbarProgress.SetState(this.Handle, TaskbarProgress.TaskbarStates.NoProgress);
                    break;
                case 1:
                    TaskbarProgress.SetValue(this.Handle, 1, 1);
                    if (isMediaPlaying) TaskbarProgress.SetState(this.Handle, TaskbarProgress.TaskbarStates.Indeterminate);
                    else if (!isMediaPlaying && isMediaLoaded) TaskbarProgress.SetState(this.Handle, TaskbarProgress.TaskbarStates.Paused);
                    else if (!isMediaLoaded) { TaskbarProgress.SetState(this.Handle, TaskbarProgress.TaskbarStates.Error); }
                    else TaskbarProgress.SetState(this.Handle, TaskbarProgress.TaskbarStates.NoProgress);
                    break;
                case 2:
                    if (isMediaPlaying) { TaskbarProgress.SetValue(this.Handle, player.Position.TotalSeconds, player.Duration.TotalSeconds); TaskbarProgress.SetState(this.Handle, TaskbarProgress.TaskbarStates.Normal); }
                    else if (!isMediaPlaying && isMediaLoaded) { TaskbarProgress.SetValue(this.Handle, player.Position.TotalSeconds, player.Duration.TotalSeconds); TaskbarProgress.SetState(this.Handle, TaskbarProgress.TaskbarStates.Paused); }
                    else if (!isMediaLoaded) { TaskbarProgress.SetValue(this.Handle, 1, 1); TaskbarProgress.SetState(this.Handle, TaskbarProgress.TaskbarStates.Error); }
                    else TaskbarProgress.SetState(this.Handle, TaskbarProgress.TaskbarStates.Normal);
                    break;
                case 3:
                    if (player.Volume >= 50) { TaskbarProgress.SetValue(this.Handle, player.Volume, 100); TaskbarProgress.SetState(this.Handle, TaskbarProgress.TaskbarStates.Normal); }
                    else if (player.Volume == 0) { TaskbarProgress.SetValue(this.Handle, 1, 1); TaskbarProgress.SetState(this.Handle, TaskbarProgress.TaskbarStates.Error); }
                    else if (player.Volume < 50) { TaskbarProgress.SetValue(this.Handle, player.Volume, 100); TaskbarProgress.SetState(this.Handle, TaskbarProgress.TaskbarStates.Paused); }
                    break;
            }
        }
    }
    public static class TaskbarProgress
    {
        public enum TaskbarStates { NoProgress = 0, Indeterminate = 0x1, Normal = 0x2, Error = 0x4, Paused = 0x8 }
        [ComImport()]
        [Guid("ea1afb91-9e28-4b86-90e9-9e9f8a5eefaf")]
        [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
        private interface ITaskbarList3
        {
            // ITaskbarList
            [PreserveSig] void HrInit();
            [PreserveSig] void AddTab(IntPtr hwnd);
            [PreserveSig] void DeleteTab(IntPtr hwnd);
            [PreserveSig] void ActivateTab(IntPtr hwnd);
            [PreserveSig] void SetActiveAlt(IntPtr hwnd);

            // ITaskbarList2
            [PreserveSig] void MarkFullscreenWindow(IntPtr hwnd, [MarshalAs(UnmanagedType.Bool)] bool fFullscreen);

            // ITaskbarList3
            [PreserveSig] void SetProgressValue(IntPtr hwnd, UInt64 ullCompleted, UInt64 ullTotal);
            [PreserveSig] void SetProgressState(IntPtr hwnd, TaskbarStates state);
        }

        [ComImport()]
        [Guid("56fdf344-fd6d-11d0-958a-006097c9a090")]
        [ClassInterface(ClassInterfaceType.None)]
        private class TaskbarInstance { }
        private static ITaskbarList3 taskbarInstance = (ITaskbarList3)new TaskbarInstance();
        private static bool taskbarSupported = Environment.OSVersion.Version >= new Version(6, 1);
        public static void SetState(IntPtr windowHandle, TaskbarStates taskbarState) { if (taskbarSupported) taskbarInstance.SetProgressState(windowHandle, taskbarState); }
        public static void SetValue(IntPtr windowHandle, double progressValue, double progressMax) { if (taskbarSupported) taskbarInstance.SetProgressValue(windowHandle, (ulong)progressValue, (ulong)progressMax); }
    }
}