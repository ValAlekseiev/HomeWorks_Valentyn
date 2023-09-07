using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            string logFilePath = "sample.log"; 

       
            if (!File.Exists(logFilePath))
            {
                Console.WriteLine("The log file does not exist.");
                return;
            }

        
            string[] logLines = File.ReadAllLines(logFilePath);

         
            int totalLogEntries = logLines.Length;
            int errorCount = logLines.Count(line => line.Contains("ERROR"));
            int warningCount = logLines.Count(line => line.Contains("WARNING"));
            int infoCount = logLines.Count(line => line.Contains("INFO"));

           
            string report = $"Log File Analysis Report:\n" +
                            $"Total Log Entries: {totalLogEntries}\n" +
                            $"Errors: {errorCount}\n" +
                            $"Warnings: {warningCount}\n" +
                            $"Informational Entries: {infoCount}\n";

            
            Console.WriteLine(report);

            string reportFilePath = "log_report.txt";
            File.WriteAllText(reportFilePath, report);

            Console.WriteLine($"Report written to {reportFilePath}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}

