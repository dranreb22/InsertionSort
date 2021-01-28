using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;

namespace Insertion_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("In terms of 10^n, how many values shall we sort? Up to 1,000,000.");
            int n = Convert.ToInt32(Console.ReadLine());
            string fileNum = n + "numbers.txt";
            string filePath = "C:\\Users\\berna\\Documents\\C sharp practice\\NumGenerated\\" + fileNum;
            string[] lines = File.ReadAllLines(filePath);
            int[] array = Array.ConvertAll(lines, int.Parse);

            var timer = Stopwatch.StartNew();
            for (int i = 1; i < array.Length; i++)
            {
                int currVal = array[i];

                int x = i - 1;
                while (x > -1 && array[x] > currVal)
                {
                    array[x + 1] = array[x];
                    x -= 1;
                }
                array[x + 1] = currVal;
            }
            timer.Stop();
            var timespan = timer.Elapsed;

            using (StreamWriter sw = new StreamWriter(fileNum+"output.txt"))
            {
                foreach (int value in array)
                    sw.WriteLine(value);
            }

            using (StreamWriter timespent = File.AppendText(fileNum + "output.txt"))
            {
                timespent.WriteLine(String.Format("{0:00}:{1:00}:{2:000000000000000000000000000000000000000}", timespan.Minutes, timespan.Seconds, timespan.Milliseconds));
            }
            

            Console.WriteLine(String.Format("{0:00}:{1:00}:{2:000000000000000000000000000000000000000}", timespan.Minutes, timespan.Seconds, timespan.Milliseconds));


            Console.ReadLine();

            //foreach(int value in array)
            //{
            //    Console.WriteLine(value);
            //}
        }
    }
}