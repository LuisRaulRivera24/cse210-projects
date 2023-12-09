public class VideoManager
{
    private List<Video> _videoList;

    public VideoManager()
    {
        _videoList = new List<Video>();

        List<string> videoOneComments = new List<string>{
                                                            "Jacob: That was a funny video!",
                                                            "James: That burger looked delicious.",
                                                            "Sarah: when will the next video be?"
                                                        };
        Video videoOne = new Video("Burger Video", "James Brown", 330, videoOneComments);
        _videoList.Add(videoOne);

        List<string> videoTwoComments = new List<string>{
                                                            "Jason: That was a funny video!",
                                                            "Timothy: That burger looked delicious.",
                                                            "Baxter: when will the next video be?"
                                                        };
        Video videoTwo = new Video("New 2022 F-150", "William Defoe", 780.7, videoTwoComments);
        _videoList.Add(videoTwo);

        List<string> videoThreeComments = new List<string>{
                                                            "Destiny: That was a funny video!",
                                                            "Richard: That burger looked delicious.",
                                                            "Jose: when will the next video be?"
                                                        };
        Video videoThree = new Video("How To Make Crepes", "Katherine Wright", 830, videoThreeComments);
        _videoList.Add(videoThree);
    }

    public void VideoInfo()
    {
        Console.WriteLine();
        foreach (Video video in _videoList)
        {
            video.Display();
        }
    }
}