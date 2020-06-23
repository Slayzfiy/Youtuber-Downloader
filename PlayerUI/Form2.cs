using System;
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

        private Downloader downloader = new Downloader();
        private List<VideoObject> objects = new List<VideoObject>();
        private void btn_search_Click(object sender, EventArgs e)
        {
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

        private void btn_download_Click(object sender, EventArgs e)
        {

        }

        private void tb_input_Enter(object sender, EventArgs e)
        {
            tb_input.Text = "";
        }

        private void lb_items_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_items.SelectedItem != null)
            {
                this.pb_thumbnail.BackgroundImage = this.downloader.DownloadImage(
                    this.objects.Where(item => item.video_title == lb_items.SelectedItem.ToString()).First().video_thumbnail);

            }
        }
    }
}
