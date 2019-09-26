
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoSubtitler
{
    public partial class Form1 : Form
    {

        List<SubtitleClass> addedSubtitles = new List<SubtitleClass>();
        List<SubtitleClass> currentAddedSubtitles = new List<SubtitleClass>();
        List<string> readyAddingSubs = new List<string>();
        List<string> currentAddingSubs = new List<string>();

        bool _isAdding = false;

        bool IsAdding {
            get {
                return _isAdding;
            }
            set {
                _isAdding = value;
                btnBeginAdd.Enabled = !value;
                btnEndAdd.Enabled = value;
                btnCurrent.Enabled = value;
                btnUnDo.Enabled = value;
            }
        }

        string getSubtitleAtTime(TimeSpan time) {
            return combine(from s in addedSubtitles where s.BeginTime <= time && s.EndTime >= time orderby s.BeginTime select s.Content);
        }

        private string combine(IEnumerable<string> strs) {
            StringBuilder sb = new StringBuilder();
            foreach (string str in strs) {
                if (sb.Length > 0) { sb.Append(Environment.NewLine); }
                sb.Append(str);
            }
            return sb.ToString();
        }

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
            if (!IsAdding)
            {
                lblRealTimeSubtitle.Text = getSubtitleAtTime(videoView.Position);
                //Console.WriteLine(getSubtitleAtTime(videoView.Position));
            }
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

        private void BtnSub1Sec_Click(object sender, EventArgs e)
        {
            videoView.PositionInt += int.Parse(((Button)sender).Tag.ToString());
        }



        private void BtnAddFromTxt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                readyAddingSubs.AddRange(File.ReadAllLines(openFileDialog1.FileName));
                loadPreAddingList();
            }
        }





        void loadPreAddingList() {
            listReadyAdd.Items.Clear();
            foreach (string s in readyAddingSubs) {
                listReadyAdd.Items.Add(s);
            }
        }

        private void BtnCurrent_MouseEnter(object sender, EventArgs e)
        {
            if (IsAdding)
            {
                videoView.Play();
            }
        }

        private void BtnCurrent_MouseLeave(object sender, EventArgs e)
        {
            if (IsAdding)
            {
                videoView.Stop();
            }
        }

        private void BtnBeginAdd_Click(object sender, EventArgs e)
        {
            if (readyAddingSubs.Count > 0)
            {
                currentAddingSubs.Clear();
                currentAddingSubs.AddRange(readyAddingSubs);
                IsAdding = true;
                videoView.Stop();
                btnCurrent.Text = "# 快把鼠标移到这里来 #";
                refreshAddSubView();
            }
        }

        private void BtnEndAdd_Click(object sender, EventArgs e)
        {
            IsAdding = false;
            addedSubtitles.AddRange(currentAddedSubtitles);
            currentAddedSubtitles.Clear();
            loadAddedView();
        }


        void refreshAddSubView() {
            List<string> lastfive = new List<string>();
            for (int i = currentAddedSubtitles.Count - 1; i >= 0; i--) {
                lastfive.Insert(0, currentAddedSubtitles[i].Content);
                if (lastfive.Count >= 5) {
                    break;
                }
            }
            lblPrevs.Text = combine(lastfive);
            List<string> nextfive = new List<string>();
            for (int i =0;i< currentAddingSubs.Count; i++)
            {
                nextfive.Add(currentAddingSubs[i]);
                if (nextfive.Count >= 5)
                {
                    break;
                }
            }
            lblNexts.Text = combine(nextfive);
        }

        TimeSpan tempBegin = TimeSpan.Zero;
        TimeSpan tempEnd = TimeSpan.Zero;
        string tempCurrent;
        private void BtnCurrent_MouseDown(object sender, MouseEventArgs e)
        {
            if (currentAddingSubs.Count > 0)
            {
                tempCurrent = currentAddingSubs[0];
                tempBegin = videoView.Position;
                currentAddingSubs.RemoveAt(0);
                refreshAddSubView();
                lblRealTimeSubtitle.Text = tempCurrent;
                btnCurrent.Text = "> "+tempCurrent+" <";
            }
        }

        private void BtnCurrent_MouseUp(object sender, MouseEventArgs e)
        {
            tempEnd = videoView.Position;
            currentAddedSubtitles.Add(new SubtitleClass(tempCurrent,tempBegin,tempEnd));
            lblRealTimeSubtitle.Text = "";
            btnCurrent.Text = ">  <";
            refreshAddSubView();
        }

        private void BtnCurrent_Click(object sender, EventArgs e)
        {

        }

        void loadAddedView() {
            listAddedSubtitles.Items.Clear();
            foreach (SubtitleClass sub in addedSubtitles.OrderBy(t => t.BeginTime)) {
                listAddedSubtitles.Items.Add(new ListViewItem(new string[] { sub.BeginTime.ToString("hh\\:mm\\:ss\\.fff"), sub.Content }));
            }
        }
    }
}
