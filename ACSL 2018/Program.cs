using System;
using System.IO;
using System.Numerics;

namespace ACSL_2018
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("sr-sample-input.txt");
            string line;
            string padded;
            BigInteger number;
            int pad;
            int split;
            for(int i = 0; i<lines.Length;i++)
            {
                int sum = 0;
                line = lines[i];
                string[] parts = line.Split(' ');
                split = Convert.ToInt32(parts[1]);
                if (parts[0].Length % split != 0)
                    pad = split - (parts[0].Length % split);
                else
                    pad = 0;
                padded = parts[0].PadRight(parts[0].Length+pad,'0');
                number = BigInteger.Parse(padded);
                while(number != 0)
                {
                    sum += (int)(number % (BigInteger)Math.Pow(10, split));
                    padded = padded.Substring(0, padded.Length - split);
                    if (padded == "")
                        break;
                    number = BigInteger.Parse(padded);
                }
                Console.WriteLine(sum);
            }
        }
    }
}
