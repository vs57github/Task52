
using System;
 
namespace ArrayAverage
{
    class Program
    {
        static void Main(string[] args)
        { 
            int[,] array = new int[3, 4] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };

            double sum = 0;

            for (int i = 0; i < array.GetLength(1); i++)  // проходим по столбцам массива с помощью GetLength(1) - возвращает количество столбцов массива 
            {                                           // GetLength(0) - возвращает количество строк массива

                for (int j = 0; j < array.GetLength(0); j++) // проходим по строкам массива  
                {                                             // GetLength(0) - возвращает количество строк массива

                    sum += array[j, i]; // уклыдывыем ячейку [j][i] (j-нумеруемый ряд , i-нумеруемый стлбец)

                }

                Console.Write($"{sum / array.GetLength(0):F2} "); // F2 - 2-я знакa po decimal'noi tochke

                sum = 0; // o4istim peremennuyu sum dlya sleduushhego cikla po stolbcam

            }

            Console.WriteLine();

        }
    }
}