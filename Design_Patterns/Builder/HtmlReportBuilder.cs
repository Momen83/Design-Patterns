using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Builder
{
    internal class HtmlReportBuilder : IReportBuilder
    {
        private Report _report = new Report();

        public Report Build()
        {
            return _report;
        }

        public IReportBuilder SetBody(string body)
        {
            _report.Body = $"<h2>Content</h2><p>{body}</p>";
            return this;
        }

        public IReportBuilder SetFooter(string footer)
        {
            _report.Footer = $"<footer><p>{footer}</p></footer>";
            return this;
        }

        public IReportBuilder SetSummary(string summary)
        {
            _report.Summary = $"<h2>Summary</h2><p>{summary}</p>";
            return this;
        }

        public IReportBuilder SetTitle(string title)
        {
            _report.Title = $"<h1>{title}</h1>";
            return this;
        }
    }
}
