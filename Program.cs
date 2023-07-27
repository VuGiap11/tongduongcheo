using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace tongduongcheomatranvuong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap kich thuoc ma tran vuong: ");
            int n = int.Parse(Console.ReadLine());

            int[,] array = new int[n, n];

            Console.WriteLine("nhap phan tu cua mang");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"nhap phan tu [{i},{j}]");
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += array[i, i];
            }

            Console.WriteLine("ma tran: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(array[i, j] + "\n");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"tong cua duong cheo chinh la : {sum}");
        }
    }
}
