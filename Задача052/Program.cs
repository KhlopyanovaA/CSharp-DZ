// Задайте двумерный массив из целых чисел.
//Найдите среднее арифметическое элементов в каждом столбце.

int [,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int [m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
        
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"[{inArray[i, j]}\t]");
        }
        Console.WriteLine();
    }
}

void FindArifm(int[,] arr)
{  
   
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        int arifm = 0;
        int sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {   
            sum += arr[i, j];
            arifm = Math.Round(sum / arr.GetLength(0), 2);
        }
        
        Console.Write($"[{arifm}]\t");
    }
   
 }  


Console.Clear();
Console.WriteLine("введите количество строк");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество строк");
int col = Convert.ToInt32(Console.ReadLine()); 
int[,] array2D = GetArray(row, col, -10, 10);

PrintArray(array2D);
Console.WriteLine();

FindArifm(array2D);


