using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Proxy
{
    public static class  DataStore
    {
        public static List<Video> Videos = new List<Video>
        {
           new Video(1 , "C++" , "How to learn c++"),
           new Video(2 , "Python" , "How to learn Python"),
           new Video(3 , "Java" , "How to learn Java")
        };
    }
}
