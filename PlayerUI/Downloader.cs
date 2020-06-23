using VideoLibrary;
using System.IO;
using System.Net.Http;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System;

namespace PlayerUI
{
    public class Downloader
    {
        private string api_token = "AIzaSyB1EhfuAjpxzXsTT6koEC_N9lfMhMvkW0U";
        public void Save_Video_LINK(string link)
        {
            var youTube = YouTube.Default; // starting point for YouTube actions
            var video = youTube.GetVideo(link); // gets a Video object with info about the video
            File.WriteAllBytes(@"D:\" + video.FullName, video.GetBytes());
        }

        public VideoObject Search_Video_Link(string link)
        {
            return new VideoObject("a", "b", "c");
        }
        public List<VideoObject> Search_Video_Name(string keyword)
        {
            string link = $"https://www.googleapis.com/youtube/v3/search?part=snippet&maxResults=11&q={keyword}&type=video&key={api_token}";
            using (var wb = new WebClient())
            {
                var response = wb.DownloadString(link);
                var tmpResult = JObject.Parse(response);
                var temp_video_title = tmpResult["items"].Values("snippet").Values("title").ToArray();
                var temp_video_id = tmpResult["items"].Values("id").Values("videoId").ToArray();
                var temp_video_thumbnail = tmpResult["items"].Values("snippet").Values("thumbnails").Values("high").Values("url").ToArray();

                List<VideoObject> video_list = new List<VideoObject>();
                for (int i = 0; i < 10; i++)
                {
                    string temp_video_url = string.Format("https://www.youtube.com/watch?v={0}", temp_video_id[i].ToString());
                    VideoObject video_obj = new VideoObject(temp_video_title[i].ToString(), temp_video_url, temp_video_thumbnail[i].ToString());
                    video_list.Add(video_obj);
                }

                return video_list;
            }
        }
        public Image DownloadImage(string url)
        {
            using (System.Net.WebClient webClient = new System.Net.WebClient())
            {
                using (Stream stream = webClient.OpenRead(url))
                {
                    return Image.FromStream(stream);
                }
            }
        }
    }
}
