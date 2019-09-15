
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoSubtitler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            videoView.SetVideoFile("test.mp4");
            
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {

            videoView.Play();

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            int pos = videoView.PositionInt;
            int len= Math.Max(pos, videoView.LengthInt);
            trackBar1.Maximum = len;
            if(!lockpos)
            trackBar1.Value = pos;
            label1.Text = videoView.Position.ToString("hh\\:mm\\:ss\\.fff");
        }

        bool lockpos = false;
        private void TrackBar1_MouseDown(object sender, MouseEventArgs e)
        {
            lockpos = true;
        }

        private void TrackBar1_MouseUp(object sender, MouseEventArgs e)
        {
            videoView.PositionInt = trackBar1.Value;
            lockpos = false;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            videoView.Stop();
        }


    }
}
