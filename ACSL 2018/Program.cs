using System;
using System.IO;

namespace ACSL_2018
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("sr-sample-input.txt");
            string line;
            int split;
            long number;
            int sum = 0;
            for(int i = 0; i<lines.Length;i++)
            {
                int j = 0;
                line = lines[i];
                string[] parts = line.Split(' ');
                while(parts[0].Length % parts[1].Length != 0)
                {
                    parts[0].PadRight(parts[0].Length+1, '0');
                }
                split = Convert.ToInt32(parts[1]);
                number = Convert.ToInt64(parts[0]);
                while (number != 0)
                {
                    if (j != 0)
                        sum += (int)(number % (long)Math.Pow(10, split * (j + 1))) / (int)Math.Pow(10, split * j);
                    else
                        sum += (int)(number % (long)Math.Pow(10, split * (j + 1)));
                    number -= sum;
                    j++;
                }
            }
        }
    }
}
