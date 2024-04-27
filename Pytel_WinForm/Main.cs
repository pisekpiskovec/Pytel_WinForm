using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Mpv.NET.Player;
using Pytel_WinForm.Properties;
using System.IO;
using System.Linq;

namespace Pytel_WinForm
{
    public partial class Main : Form
    {
        MpvPlayer player;
        int saveLocalVolume = 0, winState, mediaQueueIndex = 0;
        bool isMediaLoaded = false, isMediaPlaying = false, isFullScreen = false, closedWithQ = false;
        string mediaPath;
        List<string> mediaQueue = new List<string>();

        public Main()
        {
            InitializeComponent();
            player = new MpvPlayer(pPlayer.Handle);
            player.MediaFinished += mediaFinished;
            this.Location = Settings.Default.lastPos;
            this.WindowState = (FormWindowState)Settings.Default.lastStat;
            this.Size = Settings.Default.lastSize;
            if (Settings.Default.volumeLast != 100) { player.Volume = Settings.Default.volumeLast; } else { player.Volume = 100; }
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
            if (closedWithQ) { Settings.Default.volumeLast = player.Volume; } else { Settings.Default.volumeLast = 100; }
            if (WindowState != FormWindowState.Maximized) Settings.Default.lastPos = this.Location;
            Settings.Default.lastStat = (int)this.WindowState;
            if (WindowState != FormWindowState.Maximized) Settings.Default.lastSize = this.Size;
            if (closedWithQ) { Settings.Default.mediaLast = mediaPath; } else { Settings.Default.mediaLast = ""; }
            if (!closedWithQ) { Settings.Default.queLoop = 0; }
            Settings.Default.Save();
            player.Dispose();
        }

        private void tbPosition_Seek(object sender, EventArgs e) { player.Position = TimeSpan.FromSeconds(tbPosition.Value); }
        private void tsmiOpenFile_Click(object sender, EventArgs e)
        {
            player.Pause();
            try {
                if (ofdFile.ShowDialog() == DialogResult.OK) { loadMedia(ofdFile.FileName); }
                else { player.Resume(); } }
            catch { MessageBox.Show("Opening dialog failed. Please try again.", "Opening dialog failed", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void tsbPrevious_Click(object sender, EventArgs e)
        {
            if (player.Position.TotalSeconds > (double)Settings.Default.positionChange) { player.Position = TimeSpan.FromSeconds(0); }
            else if (mediaQueueIndex != 0 && (Settings.Default.queLoop == 0 || Settings.Default.queLoop == 2))
            {
                player.Stop(); isMediaPlaying = false; isMediaLoaded = false; mediaPath = ""; mediaQueueIndex--;
                player.Load(mediaQueue[mediaQueueIndex]);
                mediaPath = mediaQueue[mediaQueueIndex];
                isMediaLoaded = true;
                player.Resume();
                isMediaPlaying = true;
                tDuration.Start();
            }
            else if (Settings.Default.queLoop == 1) { player.Position = TimeSpan.FromSeconds(0); }
            else if (mediaQueueIndex == 0 && Settings.Default.queLoop == 2)
            {
                player.Stop(); isMediaPlaying = false; isMediaLoaded = false; mediaPath = ""; mediaQueueIndex = mediaQueue.Count - 1;
                player.Load(mediaQueue[mediaQueueIndex]);
                mediaPath = mediaQueue[mediaQueueIndex];
                isMediaLoaded = true;
                player.Resume();
                isMediaPlaying = true;
                tDuration.Start();
            }
        }

        private void tsbNext_Click(object sender, EventArgs e)
        {
            if (mediaQueueIndex != mediaQueue.Count - 1 && (Settings.Default.queLoop == 0 || Settings.Default.queLoop == 2))
            {
                player.Stop(); isMediaPlaying = false; isMediaLoaded = false; mediaPath = ""; mediaQueueIndex++;
                player.Load(mediaQueue[mediaQueueIndex]);
                mediaPath = mediaQueue[mediaQueueIndex];
                isMediaLoaded = true;
                player.Resume();
                isMediaPlaying = true;
                tDuration.Start();
            }
            else if (Settings.Default.queLoop == 1) { player.Position = TimeSpan.FromSeconds(0); }
            else if (mediaQueueIndex == mediaQueue.Count - 1 && Settings.Default.queLoop == 2)
            {
                player.Stop(); isMediaPlaying = false; isMediaLoaded = false; mediaPath = ""; mediaQueueIndex = 0;
                player.Load(mediaQueue[mediaQueueIndex]);
                mediaPath = mediaQueue[mediaQueueIndex];
                isMediaLoaded = true;
                player.Resume();
                isMediaPlaying = true;
                tDuration.Start();
            }
        }

        private void tsbPlay_Click(object sender, EventArgs e) { player.Resume(); isMediaPlaying = true; if (isFullScreen && tsFullScreen.Visible) { tsFullScreen.Visible = false; } }
        private void tsbPause_Click(object sender, EventArgs e) { if (isMediaPlaying) { player.Pause(); isMediaPlaying = false; } else { player.NextFrame(); } }
        private void tsbStop_Click(object sender, EventArgs e) { player.Stop(); isMediaPlaying = false; isMediaLoaded = false; mediaPath = ""; }
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
            tslFSDuration.ToolTipText = $"Volume: {player.Volume}%";
        }

        private void tControls_Tick(object sender, EventArgs e)
        {
            pFullScreenControl.Visible = isFullScreen;
            tsBasic.Visible = !isFullScreen;
            pBottom.Visible = !isFullScreen;
            if (!isMediaPlaying) { tsFullScreen.Visible = isFullScreen; }
            tbPosition.Enabled = isMediaLoaded;
            tbPosition.Value = (int)player.Position.TotalSeconds;
            tspbPosition.Value = (int)player.Position.TotalSeconds;
            tspbPosition.Size = new System.Drawing.Size(tsFullScreen.Width - (tslFSDuration.Text.Length == 11 ? 267 : 297), 22);
            tbVolume.Value = (int)player.Volume;
            tspbVolume.Value = (int)player.Volume;
            tsbFullScreen.Enabled = isMediaLoaded;
            tsbPrevious.Enabled = isMediaLoaded;
            tsbSeekBack.Enabled = player.Position.TotalSeconds >= (double)Settings.Default.positionChange;
            tsbPlay.Enabled = !isMediaPlaying && isMediaLoaded;
            tsbPause.Enabled = isMediaLoaded;
            tsbFSPlay.Enabled = !isMediaPlaying;
            tsbFSPause.Enabled = isMediaLoaded;
            tsbStop.Enabled = isMediaLoaded;
            tsbSeekForward.Enabled = player.Duration.TotalSeconds - player.Position.TotalSeconds >= (double)Settings.Default.positionChange;
            tsbNext.Enabled = isMediaLoaded;
            this.Text = isMediaLoaded ? "Pytel | " + player.MediaTitle : "Pytel";
            toolTip.SetToolTip(tbVolume, $"Volume: {tbVolume.Value}%");
        }

        private void tbVolume_Scroll(object sender, EventArgs e) { player.Volume = tbVolume.Value; }
        private void tbVolume_MouseUp(object sender, MouseEventArgs e) { if (e.Button == MouseButtons.Right) { if (player.Volume == 0) { player.Volume = saveLocalVolume; } else { saveLocalVolume = player.Volume; player.Volume = 0; } } }
        private void tsbSeekBack_Click(object sender, EventArgs e) { player.SeekAsync(player.Position.TotalSeconds - (double)Settings.Default.positionChange); }
        private void tsbSeekForward_Click(object sender, EventArgs e) { player.SeekAsync(player.Position.TotalSeconds + (double)Settings.Default.positionChange); }
        private void pPlayer_MouseClick(object sender, MouseEventArgs e) { if (e.Button == MouseButtons.Right) { if (isMediaPlaying) { tsbPause.PerformClick(); } else { tsbPlay.PerformClick(); } } }
        private void tsbFSPlay_Click(object sender, EventArgs e) { player.Resume(); isMediaPlaying = true; }
        private void tsbFSPause_Click(object sender, EventArgs e) { if (isMediaPlaying) { player.Pause(); isMediaPlaying = false; } else { player.NextFrame(); } }
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

        private void pFullScreenControl_MouseEnter(object sender, EventArgs e) { tsFullScreen.Visible = true; }
        private void tsFullScreen_MouseLeave(object sender, EventArgs e) { tsFullScreen.Visible = false; }
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
            try {
                if (ofdUniversal.ShowDialog() == DialogResult.OK) { loadMedia(ofdUniversal.FileName); }
                else { player.Resume(); } }
            catch { MessageBox.Show("Opening dialog failed. Please try again.", "Opening dialog failed", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void mediaFinished(object sender, EventArgs e)
        {
            switch (Settings.Default.queLoop) 
            {
                case 0:
                    if(mediaQueueIndex != mediaQueue.Count - 1)
                    {
                    player.Stop(); isMediaPlaying = false; isMediaLoaded = false; mediaPath = ""; mediaQueueIndex++;
                    player.Load(mediaQueue[mediaQueueIndex]);
                    mediaPath = mediaQueue[mediaQueueIndex];
                    isMediaLoaded = true;
                    player.Resume();
                    isMediaPlaying = true;
                    tDuration.Start();
                    }
                    break;
                case 2:
                    if (mediaQueueIndex != mediaQueue.Count - 1)
                    {
                        player.Stop(); isMediaPlaying = false; isMediaLoaded = false; mediaPath = ""; mediaQueueIndex++;
                        player.Load(mediaQueue[mediaQueueIndex]);
                        mediaPath = mediaQueue[mediaQueueIndex];
                        isMediaLoaded = true;
                        player.Resume();
                        isMediaPlaying = true;
                        tDuration.Start();
                    }
                    else
                    {
                        player.Stop(); isMediaPlaying = false; isMediaLoaded = false; mediaPath = ""; mediaQueueIndex = 0;
                        player.Load(mediaQueue[0]);
                        mediaPath = mediaQueue[0];
                        isMediaLoaded = true;
                        player.Resume();
                        isMediaPlaying = true;
                        tDuration.Start();
                    }
                    break;
                case 1:
                    player.Stop(); isMediaPlaying = false; isMediaLoaded = false;
                    player.Load(mediaQueue[mediaQueueIndex]);
                    isMediaLoaded = true;
                    player.Resume();
                    isMediaPlaying = true;
                    tDuration.Start();
                    break;
            }
        }

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
                else if (e.KeyCode == Keys.Q) { closedWithQ = true; player.Stop(); Application.Exit(); }
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
            else if (e.KeyCode == Keys.S) {
                bool wasFSBarVisible = tsFullScreen.Visible;
                bool wasBasicBarVisible = tsBasic.Visible;

                tsFullScreen.Visible = false;
                tsBasic.Visible = false;

                Rectangle bounds = this.RectangleToScreen(this.ClientRectangle);
                int titleHeight = bounds.Top - this.Top;
                int borderWidth = bounds.Left - this.Left;
                Bitmap bitmap = new Bitmap(pPlayer.Width, pPlayer.Height);
                Graphics g = Graphics.FromImage(bitmap);
                g.CopyFromScreen(this.Left + borderWidth + pPlayer.Left, this.Top + titleHeight + pPlayer.Top, 0, 0, bitmap.Size, CopyPixelOperation.SourceCopy);

                tsBasic.Visible = wasBasicBarVisible;
                tsFullScreen.Visible = wasFSBarVisible;

                int scrNum = 0;
                bitmap.Save(@"" + player.MediaTitle + scrNum.ToString("###") + ".png", ImageFormat.Png);
            }
            else if (isMediaLoaded)
            {
                switch (e.KeyCode)
                {
                    case Keys.NumPad0: player.Position = TimeSpan.FromMilliseconds((player.Duration.TotalMilliseconds / 10) * 0); break;
                    case Keys.NumPad1: player.Position = TimeSpan.FromMilliseconds((player.Duration.TotalMilliseconds / 10) * 1); break;
                    case Keys.NumPad2: player.Position = TimeSpan.FromMilliseconds((player.Duration.TotalMilliseconds / 10) * 2); break;
                    case Keys.NumPad3: player.Position = TimeSpan.FromMilliseconds((player.Duration.TotalMilliseconds / 10) * 3); break;
                    case Keys.NumPad4: player.Position = TimeSpan.FromMilliseconds((player.Duration.TotalMilliseconds / 10) * 4); break;
                    case Keys.NumPad5: player.Position = TimeSpan.FromMilliseconds((player.Duration.TotalMilliseconds / 10) * 5); break;
                    case Keys.NumPad6: player.Position = TimeSpan.FromMilliseconds((player.Duration.TotalMilliseconds / 10) * 6); break;
                    case Keys.NumPad7: player.Position = TimeSpan.FromMilliseconds((player.Duration.TotalMilliseconds / 10) * 7); break;
                    case Keys.NumPad8: player.Position = TimeSpan.FromMilliseconds((player.Duration.TotalMilliseconds / 10) * 8); break;
                    case Keys.NumPad9: player.Position = TimeSpan.FromMilliseconds((player.Duration.TotalMilliseconds / 10) * 9); break;
                }
            }
        }

        private void pPlayer_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] validFileExtension = { ".avi", ".mkv", ".mp4", ".m4a", ".m4v", ".ogg", ".mpg", ".mpeg", ".mpv", ".mp3", ".wmv", ".wma", ".mov", ".m3u" };
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                for(int i = 0; i < files.Length; i++) { if (validFileExtension.Contains(Path.GetExtension(files[i]))) fileLoad(files[i]); }
                int newPlayIndex = mediaQueue.FindLastIndex(x => x.Contains(files[0]));

                player.Stop(); isMediaPlaying = false; isMediaLoaded = false; mediaPath = ""; mediaQueueIndex = newPlayIndex;
                player.Load(mediaQueue[newPlayIndex]);
                mediaPath = mediaQueue[newPlayIndex];
                isMediaLoaded = true;
                player.Resume();
                isMediaPlaying = true;
                tDuration.Start();

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

        private void pPlayer_DragEnter(object sender, DragEventArgs e) { e.Effect = DragDropEffects.Copy; }
        private void pPlayer_MouseDoubleClick(object sender, MouseEventArgs e) { { if (e.Button == MouseButtons.Left) { if (isFullScreen) { tsbExitFullScreen.PerformClick(); } else { tsbFullScreen.PerformClick(); } } } }
        private void tslDuration_Click(object sender, EventArgs e) { About abt = new About(); abt.ShowDialog(); }
        private void tsbQueue_Click(object sender, EventArgs e) {
            Queue que = new Queue(mediaQueue);
            switch (que.ShowDialog())
            {
                case DialogResult.OK:
                    player.Stop(); isMediaPlaying = false; isMediaLoaded = false; mediaPath = ""; mediaQueueIndex = 0;
                    mediaQueue = que.getEditedMediaQueue();
                    player.Load(mediaQueue[0]);
                    mediaPath = mediaQueue[0];
                    isMediaLoaded = true;
                    player.Resume();
                    isMediaPlaying = true;
                    tDuration.Start();
                    break;
                case DialogResult.Yes:
                    player.Stop(); isMediaPlaying = false; isMediaLoaded = false; mediaPath = ""; mediaQueueIndex = que.lbList.SelectedIndex;
                    mediaQueue = que.getEditedMediaQueue();
                    player.Load(mediaQueue[mediaQueueIndex]);
                    mediaPath = mediaQueue[mediaQueueIndex];
                    isMediaLoaded = true;
                    player.Resume();
                    isMediaPlaying = true;
                    tDuration.Start();
                    break;
            }
        }
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
                case 4:
                    TaskbarProgress.SetValue(this.Handle, mediaQueueIndex+1, mediaQueue.Count);
                    if (isMediaPlaying) TaskbarProgress.SetState(this.Handle, TaskbarProgress.TaskbarStates.Normal);
                    else if (!isMediaPlaying && isMediaLoaded) TaskbarProgress.SetState(this.Handle, TaskbarProgress.TaskbarStates.Paused);
                    else if (!isMediaLoaded) { TaskbarProgress.SetState(this.Handle, TaskbarProgress.TaskbarStates.Error); }
                    else TaskbarProgress.SetState(this.Handle, TaskbarProgress.TaskbarStates.NoProgress);
                    break;
            }
        }

        public void loadMedia(string path)
        {
            player.Load(path);
            mediaPath = path;
            mediaQueue.Add(path);
            mediaQueueIndex = mediaQueue.Count-1;
            isMediaLoaded = true;
            player.Resume();
            isMediaPlaying = true;
            tDuration.Start();
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