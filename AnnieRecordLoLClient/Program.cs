using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnieRecordLoLClient
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter outputFile = new StreamWriter(Directory.GetCurrentDirectory() + @"\AnnieRecord_currentGameInfo.txt"))
            {
                foreach (string arg in args)
                    outputFile.WriteLine(arg);
            }

            String arguments = "";
            foreach (string arg in args)
                arguments += "\"" + arg + "\" ";
            System.Diagnostics.Process p = System.Diagnostics.Process.Start(Directory.GetCurrentDirectory() + @"\League of Legends Real.exe", arguments);
        }
    }
}
