using System.Diagnostics;

string procName = Process.GetCurrentProcess().ProcessName;
using PerformanceCounter pc = 
    new PerformanceCounter("Process", "Private Bytes", procName);
    Console.WriteLine(pc.NextValue());