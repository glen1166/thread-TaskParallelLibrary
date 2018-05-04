//
// IMPORTANT!!!: Add a reference to System.Drawing.dll
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Drawing;

public class Example
{
    public static void Main()
    {
        string[] strs = {"a", "b", "c", "d", "e", "f", "g"};

        Parallel.ForEach(strs, (str) => 
                                {
                                    Console.WriteLine(str);
                                });


        // Keep the console window open in  debug mode.
        Console.WriteLine("Processing complete. Press any key to exit.");
        Console.ReadKey();
    }
}