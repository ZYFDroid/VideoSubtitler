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
    public partial class FrmEditLine : Form
    {
        string defaultText;


        public FrmEditLine(string defaultText)
        {
            this.defaultText = defaultText; InitializeComponent();
        }

        private void FrmEditLine_Load(object sender, EventArgs e)
        {
            textBox1.Text = defaultText;
        }

        public static void Edit(string defaultText,Action<string> callback) {
            FrmEditLine editLine = new FrmEditLine(defaultText);
            if (DialogResult.OK == editLine.ShowDialog()) {
                callback.Invoke(editLine.textBox1.Text);
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains('\n')) {
                textBox1.Text= textBox1.Text.Replace("\n", "").Replace("\r", "");
                DialogResult = DialogResult.OK;
            }
        }
    }
}
