// https://metanit.com/sharp/tutorial/18.1.php

using System.Diagnostics;
using System.Reflection;

// Процессы

var process = Process.GetCurrentProcess();
Console.WriteLine("id: " + process.Id);
Console.WriteLine("machineName: " + process.MachineName);
Console.WriteLine("processName: " + process.ProcessName);
Console.WriteLine("pagememory: " + process.PagedMemorySize64);
Console.WriteLine("virtual memory: " + process.VirtualMemorySize64);
Console.WriteLine("main module: " + process.MainModule);

foreach(Process proc in Process.GetProcesses())
{   
    System.Console.WriteLine($"Процессы > ID: {proc.Id}, Name: {proc.ProcessName}");
}

// Потоки процесса
ProcessThreadCollection threads = process.Threads;

foreach(ProcessThread thread in threads)
{
    System.Console.WriteLine($"Треды > ThreadId: {thread.Id}");
}
System.Console.WriteLine();

AppDomain domain = AppDomain.CurrentDomain;
Console.WriteLine($"Домейн > Name: {domain.FriendlyName}");
Console.WriteLine($"Домейн > Base Directory: {domain.BaseDirectory}");
Console.WriteLine();
 
Assembly[] assemblies = domain.GetAssemblies();
foreach (Assembly asm in assemblies)
    Console.WriteLine("Assemblies > " + asm.GetName().Name);
 