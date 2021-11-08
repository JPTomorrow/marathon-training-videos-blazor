using System;

namespace MarathonTutorialWebsite.Data
{
    public class YoutubeVideoEntry
    {
        public string Title { get; set; }
        public string Description { get; set; } = string.Empty;
        public string VideoUrl { get; set; }
        public string FormUrl { get; set; }

        public YoutubeVideoEntry(string title, string description, string videoUrl, string formUrl)
        {
            Title = title;
            Description = description;
            VideoUrl = videoUrl;
            FormUrl = formUrl;
        }
    }
}