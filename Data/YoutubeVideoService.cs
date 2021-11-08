namespace MarathonTutorialWebsite.Data
{
    public class YoutubeVideoService
    {
        private static YoutubeVideoEntry[] videos = new YoutubeVideoEntry[] {
            new YoutubeVideoEntry("New Hire Test 01", "new hire video", "https://www.youtube.com/embed/KZCIIg1Ti2w", "https://www.cognitoforms.com/f/zO-2uCkjikSrQTmb1-o_Tg/1"),
        };

        public YoutubeVideoEntry[] GetEntries()
        {
            return videos;
        }
    }
}