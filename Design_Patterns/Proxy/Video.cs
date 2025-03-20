﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Proxy
{
    public class Video
    {

        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }

        public Video(int Id , string Name , string Description) {
              this.Id = Id;
              this.Name = Name;
               this.Description = Description;
        }
    }
}
