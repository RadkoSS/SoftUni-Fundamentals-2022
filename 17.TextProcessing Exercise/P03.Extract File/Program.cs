using System;

namespace P03.Extract_File
{
    internal class Program
    {
        static void Main()
        {
            string fileLocation = Console.ReadLine();

            string fullFileName = fileLocation.Substring(fileLocation.LastIndexOf('\\') + 1);

            int dotIndex = fullFileName.LastIndexOf('.');

            string fileName = fullFileName.Substring(0, dotIndex);
            string fileExtension = fullFileName.Substring(dotIndex + 1);

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}
