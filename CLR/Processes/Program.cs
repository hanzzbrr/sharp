using System;
using System.Diagnostics;
using System.Linq;
using System.Collections.Generic;

namespace Processes
{
    class Program
    {
        static void Main(string[] args)
        {
            var processes = ListCurrentProcesses();        
            var notepad = processes.FirstOrDefault(p => p.ProcessName == "notepad++");
            System.Console.WriteLine("Notepad is: " +  notepad.ProcessName + " " + notepad.Id);            
            foreach(ProcessThread pt in notepad.Threads)            
            {
                string info = $"-> Thread ID: {pt.Id}\tStart Time: {pt.StartTime.ToShortTimeString()}\tPriority: {pt.PriorityLevel}";
                Console.WriteLine(info);
            }
            System.Console.WriteLine();
            foreach(ProcessModule pm in notepad.Modules)
            {
                string info = $"-> Mod Name: {pm.ModuleName}";
                Console.WriteLine(info);
            }
            System.Console.WriteLine();
            notepad.Kill();
        }

        private static IEnumerable<Process> ListCurrentProcesses()
        {
            var runningProcesses = 
                from proc
                in Process.GetProcesses(".")
                orderby proc.Id
                select proc;
            
            foreach(var p in runningProcesses)
            {
                string info = $"-> PID: {p.Id}\tName: {p.ProcessName}";
                Console.WriteLine(info);
            }

            System.Console.WriteLine();

            return runningProcesses;
        }
    }
}
