using System;
using System.IO;
using System.Linq;

namespace ReversedStreamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("../../../Program.cs");
            StreamWriter writer = new StreamWriter("../../../writer.txt");

            using (reader)
            {
                using (writer)
                {
                    string line = reader.ReadLine();

                    while (line != null)
                    {
                        writer.WriteLine(string.Join("", line.Reverse()));
                      
                        line = reader.ReadLine();
                    }
                }
            }

        }
    }
}
