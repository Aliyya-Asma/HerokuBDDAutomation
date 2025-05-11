using System;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Config;
using System.IO;
using System.Diagnostics;
public class ReportManager
{
    private static ExtentReports extent;
    public static ExtentReports GetInstance()
    {
        if (extent == null)
        {
            Directory.SetCurrentDirectory(AppDomain.CurrentDomain.BaseDirectory);
            var reportPath = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\..\\Reports\\ExtentReports.html");
            Debug.WriteLine("Report Path: " + reportPath);

            var sparkReporter = new ExtentSparkReporter(reportPath);
            extent = new ExtentReports();
            sparkReporter.Config.Theme = Theme.Standard;
            sparkReporter.Config.DocumentTitle = "Automation Test Report";
            sparkReporter.Config.ReportName = "Test Results";
            extent = new ExtentReports();
            extent.AttachReporter(sparkReporter);
        }
        return extent;
    }
}
