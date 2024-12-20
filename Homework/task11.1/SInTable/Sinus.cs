﻿using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {

        // Create a string array with the lines of text
        string[] lines = { "First line", "Second line", "Third line" };

        // Set a variable to the Documents path.
        string docPath =
          Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        // Write the string array to a new file named "WriteLines.txt".
        using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "f.txt")))
        {
            //foreach (string line in lines)
            //    outputFile.WriteLine(line);
            outputFile.WriteLine("┌───┬──────┐");
            outputFile.WriteLine("│ x │sin(x)│");
            outputFile.WriteLine("├───┼──────┤");

            for (double i = 0; i<=10; i++)
            {
                outputFile.WriteLine("│{0:F1}│ {1:F2} │", i/10, Math.Sin(i/10));
            }
            outputFile.WriteLine("└───┴──────┘");
        }
    }
}

//─ │ ┌ ┐ └ ┘ ├ ┤ ┬ ┴ ┼ 

