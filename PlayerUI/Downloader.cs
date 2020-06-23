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

        public List<VideoObject> Search_Video(string keyword)
        {
            string link = $"https://www.googleapis.com/youtube/v3/search?part=snippet&maxResults=5&q={keyword}&type=video&key={api_token}";
            using (var wb = new WebClient())
            {
                var response = wb.DownloadString(link);
                var tmpResult = JObject.Parse(response);
                var temp_video_title = tmpResult["items"].Values("snippet").Values("title").ToArray();
                var temp_video_id = tmpResult["items"].Values("id").Values("videoId").ToArray();
                var temp_video_thumbnail = tmpResult["items"].Values("snippet").Values("thumbnails").Values("high").Values("url").ToArray();

                List<VideoObject> video_list = new List<VideoObject>();
                for (int i = 0; i < 4; i++) 
                {
                    string temp_video_url = string.Format("https://www.youtube.com/watch?v={0}", temp_video_id[i].ToString());
                    VideoObject video_obj = new VideoObject(temp_video_title[i].ToString(), temp_video_url, temp_video_thumbnail[i].ToString());
                    video_list.Add(video_obj);
                }

                return video_list; 
            }
        }

        public async Task<Bitmap> GetImageBitmapFromUrl(string url)
        {
            Bitmap imageBitmap = null;
            try
            {
                using (var webClient = new WebClient())
                {
                    var imageBytes = await webClient.DownloadDataTaskAsync(url);
                    if (imageBytes != null && imageBytes.Length > 0)
                    {
                        //imageBitmap = BitmapFactory.DecodeByteArray(Encoding.ASCII.GetBytes(imageBytes), 0, imageBytes.Length);
                        imageBitmap = BitmapFactory.DecodeByteArray(Encoding.BigEndianUnicode.GetBytes(imageBytes), 0, imageBytes.Length);
                    }
                }
            }
            catch
            {
                //Silence is gold.
            }
           
            return imageBitmap;
        }
    }
}
