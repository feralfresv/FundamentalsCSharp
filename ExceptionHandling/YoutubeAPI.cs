using System.Collections.Generic;

namespace ExceptionHandling
{
    public class YoutubeAPI
    {   
        public List<Video> GetVideos(string user)
        {
            try
            {
                //Access YOUTUBE web service
                //Read the data
                //Create a list of video objects
                
                //throw new System.Exception("Ooops some low level Youtube error");
            }
            catch (System.Exception ex)
            {
                //Log
                throw new YoutubeException("Could not fetch the video from Youtube.", ex);
            }

            return new List<Video>();
        }
    }
}
