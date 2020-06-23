﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerUI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            Downloader d = new Downloader();
            string link = tb_input.Text;
            if (link.Contains("http"))
            {
                d.Save_Video_LINK(link);
            }
            else
            {
                MessageBox.Show(d.Save_Video_KEYWORD(link).ToString());
                //d.Save_Video_KEYWORD(link);
            }
        }

        private void btn_download_Click(object sender, EventArgs e)
        {

        }

        private void tb_input_Enter(object sender, EventArgs e)
        {
            tb_input.Text = "";
        }
    }
}
