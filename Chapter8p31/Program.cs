using System;
using System.IO;
namespace Chapter8p31
{
    internal class Program
    {
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
            ReadFileToConsole();
        }
    }
}