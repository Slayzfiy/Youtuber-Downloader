using System;

namespace PlayerUI
{
    class VideoObject
    {
        private string video_title, video_url, video_thumbnail;
        public VideoObject(string video_title, string video_url, string video_thumbnail)
        {
            this.video_title = video_title;
            this.video_url = video_url;
            this.video_thumbnail = video_thumbnail;
        }
    }
}
