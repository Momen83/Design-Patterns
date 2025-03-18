using Design_Patterns.Builder;

public class PdfReportBuilder : IReportBuilder
{
    private Report _report = new Report();

    public IReportBuilder SetTitle(string title)
    {
        _report.Title = $"PDF Report: {title}";
        return this;
    }

    public IReportBuilder SetSummary(string summary)
    {
        _report.Summary = $"[PDF Summary] {summary}";
        return this;
    }

    public IReportBuilder SetBody(string body)
    {
        _report.Body = $"[PDF Content] {body}";
        return this;
    }

    public IReportBuilder SetFooter(string footer)
    {
        _report.Footer = $"[PDF Footer] {footer}";
        return this;
    }

    public Report Build()
    {
        return _report;
    }
}
