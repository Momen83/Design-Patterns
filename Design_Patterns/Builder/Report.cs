using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Builder
{
    public class Report
    {
        public string Title { get; set; }
        public string Summary { get; set; }

        public string Body { get; set; }
        
        public string Footer { get; set; }

        public override string ToString()
        {
            return $"Title: {Title}\nSummary: {Summary}\nBody: {Body}\nFooter: {Footer}\n\n";
        }

    }
}
