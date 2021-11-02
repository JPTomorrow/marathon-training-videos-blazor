namespace MarathonTutorialWebsite.Data
{
    public class YoutubeVideoService
    {
        private static YoutubeVideoEntry[] videos = new YoutubeVideoEntry[] {
            new YoutubeVideoEntry("New Hire Test 01", "new hire video", "https://www.youtube.com/embed/KZCIIg1Ti2w"),
            new YoutubeVideoEntry("aaa", "bbb", "ccc")
        };

        public YoutubeVideoEntry[] GetEntries()
        {
            return videos;
        }
    }
    // https://www.youtube.com/embed/KZCIIg1Ti2w
}