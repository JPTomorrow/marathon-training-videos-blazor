namespace MarathonTutorialWebsite.Data
{
    public class YoutubeVideoService
    {
        private static YoutubeVideoEntry[] videos = new YoutubeVideoEntry[] {
            new YoutubeVideoEntry("New Hire Training", "New hire training video that every employee of Marathon Electrical will watch.", "https://www.youtube.com/embed/Qj5PkIrmHoQ", "https://www.youtube.com/embed/cxaDNRfRj2Y"),
        };

        public YoutubeVideoEntry[] GetEntries()
        {
            return videos;
        }
    }
}