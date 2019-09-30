
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            videoView.SetVideoFile("video.mp4");
            if (File.Exists("sub.json")) {
                load();
                loadAddedView();
            }
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

        public void save() {
            File.WriteAllText("sub.json", JsonConvert.SerializeObject(addedSubtitles));
        }

        public void load() {
            addedSubtitles = JsonConvert.DeserializeObject<List<SubtitleClass>>(File.ReadAllText("sub.json"));
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
            save();
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
        bool pressed = false;
        private void BtnCurrent_MouseDown(object sender, MouseEventArgs e)
        {
            if (currentAddingSubs.Count > 0)
            {
                pressed = true;
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
            if (pressed)
            {
                tempEnd = videoView.Position;
                currentAddedSubtitles.Add(new SubtitleClass(tempCurrent, tempBegin, tempEnd));
                lblRealTimeSubtitle.Text = "";
                btnCurrent.Text = ">  <";
                refreshAddSubView();
            }
            pressed = false;
        }

        private void BtnCurrent_Click(object sender, EventArgs e)
        {

        }

        void loadAddedView() {
            listAddedSubtitles.Items.Clear();
            addedSubtitles.Sort();
            foreach (SubtitleClass sub in addedSubtitles) {
                listAddedSubtitles.Items.Add(new ListViewItem(new string[] { sub.BeginTime.ToString("hh\\:mm\\:ss\\.fff"), sub.Content }));
            }
        }

        private void BtnClear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Confirm("清空列表？", delegate {
                readyAddingSubs.Clear();
                loadPreAddingList();
            });
            
        }


        public delegate void ConformAction();
        public static void Confirm(string str, ConformAction action)
        {
            if (MessageBox.Show( str, "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                action.Invoke();
            }
        }

        private void MnuSave_Click(object sender, EventArgs e)
        {
            save();
            MessageBox.Show("保存成功");
        }

        private void MnuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MnuExitNoSave_Click(object sender, EventArgs e)
        {
            Confirm("是否不保存退出？", delegate
            {
                Confirm("再次确认:是否不保存退出？", delegate
                {
                    this.FormClosing -= Form1_FormClosing;
                    Application.Exit();
                });
            });
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            save();
            Application.Exit();
        }

        private void BtnUnDo_Click(object sender, EventArgs e)
        {
            if (currentAddedSubtitles.Count > 0) {
                SubtitleClass sub = currentAddedSubtitles[currentAddedSubtitles.Count - 1];
                currentAddedSubtitles.RemoveAt(currentAddedSubtitles.Count - 1);
                videoView.Position = sub.BeginTime - TimeSpan.FromSeconds(1);
                currentAddingSubs.Add(sub.Content);
                refreshAddSubView();
            }
        }

        private void BtnAddByHind_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmAddByManual frmAddByManual = new FrmAddByManual();
            frmAddByManual.textBox1.Text = combine(readyAddingSubs);
            if (frmAddByManual.ShowDialog() == DialogResult.OK) {
                readyAddingSubs.Clear();
                readyAddingSubs.AddRange(frmAddByManual.textBox1.Lines);
                loadPreAddingList();
            }
            frmAddByManual.Dispose();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Confirm("是否删除选中的内容", delegate
            {
                List<ListViewItem> selectedItems = new List<ListViewItem>();
                foreach (ListViewItem item in listAddedSubtitles.SelectedItems) {
                    selectedItems.Add(item);
                }

                IEnumerable < int> deleteIndexs = from i in selectedItems orderby i.Index descending select i.Index;
                deleteIndexs.ToList().ForEach(item => addedSubtitles.RemoveAt(item));
                loadAddedView();
            });
        }

        private void BtnEditSubtitle_Click(object sender, EventArgs e)
        {
            if (listAddedSubtitles.SelectedItems.Count == 1)
            {
                int index = listAddedSubtitles.SelectedItems[0].Index;
                FrmEditLine.Edit(addedSubtitles[index].Content, str => addedSubtitles[index].Content = str);
                loadAddedView();
            }
            else {
                MessageBox.Show("目前一次只能编辑一行");
            }
        }

        private void MnuExport_Click(object sender, EventArgs e)
        {
            new SrtExportor().Export(addedSubtitles);
            MessageBox.Show("导出成功");
            OpenFolderAndSelectFile("video.srt");
        }



        private void MnuCompressSubs_Click(object sender, EventArgs e)
        {
            new SrtExportor().Export(addedSubtitles);
            new FrmCompressSubtitle().ShowDialog();

        }

        private void OpenFolderAndSelectFile(String fileFullName)
        {
            ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo("Explorer.exe");
            psi.Arguments = "/e,/select," + fileFullName;
            Process.Start(psi);
        }
    }

    class SrtExportor : IExportor
    {
        public void Export(IEnumerable<SubtitleClass> subs)
        {
            StringBuilder sb = new StringBuilder();
            int ptr = 1;
            foreach (SubtitleClass sub in subs) {
                sb.Append(ptr);
                sb.AppendLine();
                sb.Append(sub.BeginTime.ToString("hh\\:mm\\:ss\\.fff") + " --> " + sub.EndTime.ToString("hh\\:mm\\:ss\\.fff"));
                sb.AppendLine();
                sb.Append(sub.Content);
                sb.AppendLine();
                sb.AppendLine();
                ptr++;
            }
            File.WriteAllText("video.srt", sb.ToString(), Encoding.UTF8);
        }
    }
}
