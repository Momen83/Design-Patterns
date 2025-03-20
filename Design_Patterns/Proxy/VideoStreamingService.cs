using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Proxy
{
    public class VideoStreamingService : IVideoStramingService
    {
        public Video GetVideoInfo(int id)
        {

            Thread.Sleep(3000);

            return DataStore.Videos.FirstOrDefault(video => video.Id == id);
        }

    }
}
