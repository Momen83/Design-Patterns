using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Proxy
{
    public class ProxyVideoStreamingService : IVideoStramingService
    {
        List<Video> cached_vidoes = new List<Video>();
        VideoStreamingService videoStreamingService = new VideoStreamingService();
        public Video GetVideoInfo(int id)
        {
            if (cached_vidoes.Any(c => c.Id == id))
            {
                return cached_vidoes.First(c => c.Id == id);
            }

            else
            {
                Video video = videoStreamingService.GetVideoInfo(id);
                cached_vidoes.Add(video);
                return video;
            }

        }

  
    }
}
