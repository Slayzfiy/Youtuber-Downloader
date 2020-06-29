using System;
using System.IO;
using System.Windows.Forms;
using System.Text;
using System.Xml;
using System.Drawing;

namespace PlayerUI
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void Form3_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1200, 800);
            this.StartPosition = FormStartPosition.CenterScreen;
            Preferences a = new Preferences();
            tb_downloadpath.Text = a.Get_Download_Path();

        }

        private void btn_savechanges_Click(object sender, EventArgs e)
        {
            Preferences i = new Preferences();
            i.Change_Download_Path(tb_downloadpath.Text);
            MessageBox.Show(tb_downloadpath.Text);
            MessageBox.Show(i.Get_Download_Path());
        }
    }
}
