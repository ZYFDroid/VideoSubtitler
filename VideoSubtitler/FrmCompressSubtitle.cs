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
    public partial class FrmCompressSubtitle : Form
    {
        private string normalCompress = "-i \"{:VIDEO}\" -vf subtitles=\"{:SUB}\" -y out.mp4";
        private string fontCompress = "-i \"{:VIDEO}\" -vf subtitles=\"{:SUB}\":force_style='Fontsize={:FONTSIZE},Fontname={:FONTNAME},' -y out.mp4";


        public FrmCompressSubtitle(string videoPath, string subPath)
        {
            normalCompress = normalCompress.Replace("{:VIDEO}", videoPath).Replace("{:SUB}", subPath) ;
            fontCompress = fontCompress.Replace("{:VIDEO}", videoPath).Replace("{:SUB}", subPath) ;
            InitializeComponent();
        }

        private void FrmCompressSubtitle_Load(object sender, EventArgs e)
        {
            txtCmdline.Text ="ffmpeg.exe "+ normalCompress;
            cmd = normalCompress;
        }

        private void OpenFolderAndSelectFile(String fileFullName)
        {
            ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo("Explorer.exe");
            psi.Arguments = "/e,/select," + fileFullName;
            Process.Start(psi);
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        string cmd = "";

        private void Button2_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK) {
                string size = fontDialog1.Font.Size.ToString();
                string fontname = fontDialog1.Font.Name;
                cmd = fontCompress.Replace("{:FONTNAME}", fontname).Replace("{:FONTSIZE}", size);
                txtCmdline.Text = "ffmpeg.exe " + cmd;
                lblChosenFont.Text = $"已选字体： {fontname}，大小为{size}";
            }
        }

        private void BtnCompress_Click(object sender, EventArgs e)
        {
            Process ps =  Process.Start(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath),"ffmpeg.exe"),cmd);
            ps.WaitForExit();
            if (File.Exists("out.mp4")) {
                OpenFolderAndSelectFile("out.mp4");
            }
        }
    }
}
