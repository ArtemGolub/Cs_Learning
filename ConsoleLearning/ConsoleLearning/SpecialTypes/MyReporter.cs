namespace ConsoleLearning.SpecialTypes;

public delegate void ProgressReporter(int percentComplete);

public class MyReporter
{
    public string Prefix = " ";

    public void ReportProgress(int percentComplete) =>
        Console.WriteLine(Prefix + percentComplete);
}