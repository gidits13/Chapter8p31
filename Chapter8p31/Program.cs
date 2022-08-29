using System;
using System.IO;
namespace Chapter8p31
{
    internal class Program
    {
        static void WriteLastRun()
        {
            string path = @"C:\repos\Chapter8p31\Chapter8p31\Program.cs";
            FileInfo fileInfo = new FileInfo(path);
            using(StreamWriter sw = fileInfo.AppendText())
            {
                sw.WriteLine("//lasr execute: {0}",DateTime.Now);
            }
        }
        static void ReadFileToConsole()
        {
            string path = @"C:\repos\Chapter8p31\Chapter8p31\Program.cs";
            if(File.Exists(path))
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    string str = "";
                    while ((str = sr.ReadLine()) != null)
                            
                    {
                        Console.WriteLine(str);
                    }

                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            WriteLastRun(); 
            ReadFileToConsole();
        }
    }
}//lasr execute: 29.08.2022 13:05:55
//lasr execute: 29.08.2022 13:06:08
