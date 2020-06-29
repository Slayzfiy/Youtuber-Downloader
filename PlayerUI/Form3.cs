using System;
using System.IO;
using System.Windows.Forms;
using System.Text;
using System.Xml;

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
