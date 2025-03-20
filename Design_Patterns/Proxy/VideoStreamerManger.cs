using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Proxy
{
    public class VideoStreamerManger
    {
        IVideoStramingService _videoStramingService;
        public VideoStreamerManger(IVideoStramingService videoStramingService) {
            _videoStramingService = videoStramingService;
         }

        public void GetVideoInfo(int id)
        {
            Console.WriteLine($"Get Details of Video {id} .......");
            Video v = _videoStramingService.GetVideoInfo(id);
            Console.WriteLine("Video Name: " +  v.Name);
            Console.WriteLine("Video Description: " + v.Description);
            Console.WriteLine("==============================================");
   
        }
    }
}
