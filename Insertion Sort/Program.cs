using System;
using System.Globalization;
using System.IO;

namespace Insertion_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("In multiples of 10, how many values shall we sort? Up to 1,000,000.");
            int n = Convert.ToInt32(Console.ReadLine());
            string fileNum = n + "numbers.txt";
            string filePath = "C:\\Users\\berna\\Documents\\C sharp practice\\NumGenerated\\" + fileNum;
            string[] lines = File.ReadAllLines(filePath);
            int[] array = Array.ConvertAll(lines, int.Parse);
            
            foreach (int value in array)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine();

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

            foreach(int value in array)
            {
                Console.WriteLine(value);
            }
        }
    }
}