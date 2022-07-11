using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [,] numbersArray = { { 4, 3 ,6 , 9}, { 3, 4, 9, 1 }, { 5, 6 , 7, 8} };
            int sumLine =0;
            int productColumn = 1;
            int numnerOfLine = 2;
            int numnerOfColumn = 1;

            for (int i = 0; i < numbersArray.GetLength(0); i++)
            {
                
                    productColumn *= numbersArray[i, numnerOfColumn-1];
               
                for (int j = 0; j < numbersArray.GetLength(1); j++)
                {
                    if (i == numnerOfLine - 1)
                    {
                        sumLine += numbersArray[i, j];
                    }
                    Console.Write(numbersArray[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(sumLine + " - сумма 2-й строки матрицы");
            Console.WriteLine(productColumn+" - произведение 1-го столбца матрицы");
        }
    }
}
