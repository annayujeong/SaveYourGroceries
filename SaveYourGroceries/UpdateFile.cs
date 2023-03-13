using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveYourGroceries
{
    internal class UpdateFile
    {
//        public static async void WriteFile()
//        {
//            string[] lines =
//{
//            "First",
//            "Second",
//            "Third"
//        };

//            await File.WriteAllLinesAsync("WriteLines.txt", lines);
//        }

        public static void WriteFile()
        {
            string fullPath = "WriteFileTest.txt";

            // Write file using StreamWriter
            using (StreamWriter writer = new StreamWriter(fullPath))
            {
                writer.WriteLine("Monica Rathbun");
                writer.WriteLine("Vidya Agarwal");
                writer.WriteLine("Mahesh Chand");
                writer.WriteLine("Vijay Anand");
                writer.WriteLine("Jignesh Trivedi");
            }
            // Read a file
            string readText = File.ReadAllText(fullPath);
            Console.WriteLine(readText);
        }
    }
}
