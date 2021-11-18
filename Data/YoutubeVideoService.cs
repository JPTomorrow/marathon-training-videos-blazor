using System.Linq;

namespace MarathonTutorialWebsite.Data
{
    public class YoutubeVideoService
    {
        private static YoutubeVideoEntry[] videos = new YoutubeVideoEntry[] {
            new YoutubeVideoEntry(
                "New Hire Onboarding Video",
                "Marathon holds electrical safety as a top priority for all employees" +
                " and their livelihood. This video will be showing you the core safety" +
                " standards of which Marathon expects all of its employees to conduct on" +
                " every job site.",
                "https://www.youtube-nocookie.com/embed/Qj5PkIrmHoQ",
                "https://www.youtube-nocookie.com/embed/cxaDNRfRj2Y"),
        };

        public YoutubeVideoEntry[] GetEntries()
        {
            return videos;
        }

        public YoutubeVideoEntry[] GetEntriesByVideoName(string video_name)
        {
            return videos.Where(x => x.Title.ToLower().Contains(video_name.ToLower())).ToArray();
        }
    }
}