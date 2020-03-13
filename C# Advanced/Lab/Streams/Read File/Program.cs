using System;
using System.IO;

namespace Read_File
{
    class Program
    {
        static void Main()
        {

            StreamReader reader = new StreamReader("../../../Program.cs");

            using (reader)
            {
                string line = reader.ReadLine();
                int count = 0;

                while (line != null)
                {
                    Console.WriteLine($"Line {++count}: {line}");

                    line = reader.ReadLine();
                }

            }
        }
    }
}