using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mpv.NET.Player;

namespace Pytel_WinForm
{

    public partial class Form1 : Form
    {

        MpvPlayer player;

        public Form1()
        {
            InitializeComponent();
            player = new MpvPlayer(panel1.Handle);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            player.Dispose();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player.Load();
        }

        private void tsbPrevious_Click(object sender, EventArgs e)
        {
            player.PlaylistPrevious();
        }

        private void tsbNext_Click(object sender, EventArgs e)
        {
            player.PlaylistNext();
        }

        private void tsbPlay_Click(object sender, EventArgs e)
        {
            player.Resume();
        }

        private void tsbPause_Click(object sender, EventArgs e)
        {
            player.Pause();
        }

        private void tsbStop_Click(object sender, EventArgs e)
        {
            player.Stop();
        }
    }
}
