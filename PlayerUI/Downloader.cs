using VideoLibrary;
using System.IO;
using System.Net.Http;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq;

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

        public string Save_Video_KEYWORD(string keyword)
        {
            string link = $"https://www.googleapis.com/youtube/v3/search?part=snippet&maxResults=5&q={keyword}&type=video&key={api_token}";
            using (var wb = new WebClient())
            {
                var response = wb.DownloadString(link);
                var tmpResult = JObject.Parse(response);
                var temp_video_title = tmpResult["items"].Values("snippet").Values("title").ToArray();
                var temp_video_id = tmpResult["items"].Values("id").Values("videoId").ToArray();
                var temp_video_thumbnail = tmpResult["items"].Values("snippet").Values("thumbnails").Values("high").Values("url").ToArray();

                return temp_video_title[0].ToString();
                foreach (var item in temp_video_id)
                {
                    string video_url = $"https://www.youtube.com/watch?v={item}";
                    //VideoObject o = new VideoObject("hallo", video_url, temp_video_thumbnail);
                }

                foreach (var item in temp_video_thumbnail)
                {

                }
               
                
               

                // finished 
                //string id = video_id[0].ToString();
                //string youtube_url = $"https://www.youtube.com/watch?v={id}";
                //Save_Video_LINK(youtube_url);
                //return youtube_url;
            }
        }
    }
}
