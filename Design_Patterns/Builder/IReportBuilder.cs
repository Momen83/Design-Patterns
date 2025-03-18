using Design_Patterns.Builder;

public interface IReportBuilder
{
    IReportBuilder SetTitle(string title);
    IReportBuilder SetSummary(string summary);
    IReportBuilder SetBody(string body);
    IReportBuilder SetFooter(string footer);
    Report Build();
}
