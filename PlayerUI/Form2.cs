using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace PlayerUI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private Downloader downloader = new Downloader();
        private List<VideoObject> objects = new List<VideoObject>();
        private void btn_search_Click(object sender, EventArgs e)
        {
            lb_items.Visible = true;
            lb_items.Items.Clear();
            this.objects.Clear();
            string input = tb_input.Text;

            if (input.Contains("http"))
                this.objects.Add(downloader.Search_Video_Link(input));
            else
                this.objects.AddRange(downloader.Search_Video_Name(input));

            this.objects.ForEach(item => AddItem(item));
        }

        private void AddItem(VideoObject obj)
        {
            lb_items.Items.Add(obj.video_title);
        }


        private void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            pgb_download.Value = e.ProgressPercentage;
        }

        private void tb_input_Enter(object sender, EventArgs e)
        {
            tb_input.Text = "";
        }

        private void lb_items_SelectedIndexChanged(object sender, EventArgs e)
        {
            pb_thumbnail.Visible = true;
            if (lb_items.SelectedItem != null)
            {
                pb_thumbnail.BackgroundImage = downloader.DownloadImage(
                    objects.Where(item => item.video_title == lb_items.SelectedItem.ToString()).First().video_thumbnail);
            }
        }

        private void btn_download_Click(object sender, EventArgs e)
        {
            pgb_download.Visible = true;
            string video_url_download = this.objects.Where(item => item.video_title == lb_items.SelectedItem.ToString()).First().video_url.ToString();
            Preferences i = new Preferences();
            using (WebClient wc = new WebClient())
            {
                wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                wc.DownloadFileAsync(new Uri(video_url_download), i.Get_Download_Path());
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1200, 800);
           
            this.StartPosition = FormStartPosition.CenterScreen;
            pb_thumbnail.Visible = false;
            pgb_download.Visible = false;
            lb_items.Visible = false;
        }

        private void tb_input_Leave(object sender, EventArgs e)
        {
            tb_input.Text = "Insert Link or Video Name";
        }


        private void Form2_Click(object sender, EventArgs e)
        {
            btn_search.Focus();
        }

        private void btn_5_click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                btn_search_Click(new object(), new EventArgs());
            }
        }
    }
}
