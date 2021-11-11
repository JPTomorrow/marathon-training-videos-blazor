using System;

namespace MarathonTutorialWebsite.Data
{
    public class YoutubeVideoEntry
    {
        public string Title { get; set; }
        public string Description { get; set; } = string.Empty;
        public string EnglishVideoUrl { get; set; }
        public string SpanishVideoUrl { get; set; }

        public YoutubeVideoEntry(
            string title, string description,
            string englishVideoUrl, string spanishVideoUrl)
        {
            Title = title;
            Description = description;
            EnglishVideoUrl = englishVideoUrl;
            SpanishVideoUrl = spanishVideoUrl;
        }
    }
}