using ConsoleLearning.SpecialTypes;

MyReporter reporter = new MyReporter();
reporter.Prefix = "% Completed: ";

ProgressReporter progressReporter = reporter.ReportProgress;
progressReporter(90);

Console.WriteLine(progressReporter.Target == reporter);
Console.WriteLine(progressReporter.Method);

reporter.Prefix = " ";
progressReporter(1);
