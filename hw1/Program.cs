/*

Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/


void PrintArray(int[,] matr)
        {
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    Console.Write($"{matr[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        void FillArray(int[,] matr)
        {
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    matr[i, j] = new Random().Next(1, 100);
                }
            }
        }


void PrintArraySecond(int[,] matr1)
        {
            for (int i = 0; i < matr1.GetLength(0); i++)
            {
                for (int j = 0; j < matr1.GetLength(1); j++)
                {
                    Console.Write($"{matr1[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        void FillArraySecond(int[,] matr1)
        {
            for (int i = 0; i < matr1.GetLength(0); i++)
            {
                for (int j = 0; j < matr1.GetLength(1); j++)
                {
                    matr1[i, j] = new Random().Next(1, 100);
                }
            }
        }

//  перемножение



void ResultArray(int[,] matr)
{
    

for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
         
         matr[i, j] = 0;

        for (int k = 0; k < matr.GetLength(1); k++)
        {
            matr[i, j] = matr[i, j] + matr[i, k] * matr[k, j];
        }
    }
}

}




        Console.WriteLine($"Задайте количество строк двумерного массива:");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Задайте количество столбцов двумерного массива:");
        int n = Convert.ToInt32(Console.ReadLine());
        int[,] matrix = new int[m, n];
        FillArray(matrix);
       Console.WriteLine();
        PrintArray(matrix);

       Console.WriteLine();

        FillArraySecond(matrix);
        Console.WriteLine();
        PrintArraySecond(matrix);
        
        Console.WriteLine();
        ResultArray(matrix);
        PrintArray(matrix);
     
        
