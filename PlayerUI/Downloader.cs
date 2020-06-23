using VideoLibrary;
using System.IO;
using System.Net.Http;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;

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

        public void Save_Video_KEYWORD(string keyword)
        {
            string link = $"https://www.googleapis.com/youtube/v3/search?part=snippet&maxResults=1&q={keyword}&type=video&key={api_token}";
            using (var wb = new WebClient())
            {
                var response = wb.DownloadString(link);
                dynamic stuff = JsonConvert.DeserializeObject(response);
                string video_id = stuff.videoId;
                string youtube_url = $"https://www.youtube.com/watch?v={video_id}";
                Save_Video_LINK(youtube_url);
            }
        }
    }
}
