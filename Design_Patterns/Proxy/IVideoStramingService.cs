﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Proxy
{
    public interface IVideoStramingService
    {
        public  Video GetVideoInfo(int id);
    }
}
