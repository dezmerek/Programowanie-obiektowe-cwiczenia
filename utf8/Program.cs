using System;
using System.IO;

namespace utf8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("put bellow the path of files:");
            string path = Console.ReadLine();
            File.SetAttributes(path, FileAttributes.Normal);

            var files = Directory.GetFiles(path);

            var utf8WithoutBOM = new System.Text.UTF8Encoding(false);

            foreach (var file in files)
            {
                File.SetAttributes(file, FileAttributes.Normal);
                var content = File.ReadAllLines(file);
                Console.WriteLine("Converting the file '" + file + "'...");
                System.IO.File.WriteAllLines(file, content, utf8WithoutBOM);
                Console.WriteLine(file + " Converted");
            }
            Console.WriteLine("Done.");
        }
    }
}
