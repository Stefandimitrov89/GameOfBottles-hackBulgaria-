using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Point[] bottles = new Point[n];
            int maxRow = 1;
            int maxCol = 1;

            for (int i = 0; i < n; i++)
            {
                string coords = Console.ReadLine();
                var numbers = coords.Split(' ').Select(Int32.Parse).ToList();

                bottles[i] = new Point(numbers[0], numbers[1]);

                if (numbers[0] > maxRow)
                {
                    maxRow = numbers[0];
                }

                if (numbers[1] > maxCol)
                {
                    maxCol = numbers[1];
                }

            }

            int[,] field = new int[maxRow, maxCol];
            foreach (var item in bottles)
            {
                field[item.col - 1, item.row - 1] = 1;
            }
            Console.ReadKey();
        }

    }
}
