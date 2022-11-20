using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

            player = new MpvPlayer(panel1.Handle)
            {
                Loop = true,
                Volume = 50
            };
            player.Load(@"http://techslides.com/demos/sample-videos/small.mp4");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            player.Dispose();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }
    }
}
