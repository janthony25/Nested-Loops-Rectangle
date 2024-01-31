using System;
using System.Data;

namespace NestedLoops
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.Write("How many rows: ");
            int row = Convert.ToInt32(Console.ReadLine());

            Console.Write("How many column: ");
            int col = Convert.ToInt32(Console.ReadLine());

            Console.Write("What is the symbol: ");
            string symbol = Console.ReadLine();

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }






            Console.ReadKey();
        }
    }
}