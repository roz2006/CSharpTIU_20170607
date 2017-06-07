using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.FileSystemWatcher fsw = new System.IO.FileSystemWatcher(@"c:\temp\", "*.txt");
            fsw.Changed += Fsw_Changed;
            fsw.Deleted += (s, e) => { Console.WriteLine("A file {0} is deleted.", e.Name); };
            fsw.EnableRaisingEvents = true;
            fsw.Created += (s, e) => { Console.WriteLine("A new file {0} is created.",e.Name); } ;
            fsw.Created += Fsw_Created1;
            fsw.NotifyFilter = System.IO.NotifyFilters.FileName | System.IO.NotifyFilters.Size;
            do
            {

            } while (true);
        }

        private static void Fsw_Created1(object sender, System.IO.FileSystemEventArgs e)
        {
            Console.WriteLine("A second subscriber");
        }
        
        private static void Fsw_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            Console.WriteLine("Filen {0} er rettet", e.Name);
        }
    }
}
