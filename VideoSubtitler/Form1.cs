
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

        private void BtnPlayBack_Click(object sender, EventArgs e)
        {
            if (videoView.IsPlaying)
            {
                videoView.Stop();
            }
            else {
                videoView.PositionInt = valPosition.Value;
                videoView.Play();
            }
           
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            int pos = videoView.PositionInt;
            int len= Math.Max(pos, videoView.LengthInt);
            valPosition.Maximum = len;
            if(!lockpos)
            valPosition.Value = pos;
            lblTime.Text = videoView.Position.ToString("hh\\:mm\\:ss\\.fff");
        }

        bool lockpos = false;
        private void ValPosition_MouseDown(object sender, MouseEventArgs e)
        {
            lockpos = true;
        }

        private void ValPosition_MouseUp(object sender, MouseEventArgs e)
        {
            videoView.PositionInt = valPosition.Value;
            lockpos = false;
        }

        private void VideoView_PlayStateChanged(object sender, EventArgs e)
        {
            btnPlayStop.Text = videoView.IsPlaying ? "STOP" : "PLAY";
        }

        private void ValPlaybackSpeed_Scroll(object sender, EventArgs e)
        {
            double speed = (double)valPlaybackSpeed.Value / 10;
            lblPlayBackSpeed.Text = speed + "x";
            videoView.PlayBackSpeed = speed;
        }

        private void ValPosition_Scroll(object sender, EventArgs e)
        {

        }
    }
}
