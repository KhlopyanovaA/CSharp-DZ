// Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07

void PrintArray(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; i < matrix.GetLength(0); i++)
        {
            Console.Write($" {matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}
int[,] ArrayFiledSpirally(int row, int col)
{
    int[,] result = new int[row, col];
    int round;
    if(row > col)
    {
        round = row / 2;
    }
    else
    {
        round = col / 2;
    }

    int count = 0;
    for(int i =0; i < round; i++)
    {
        for(int j = 0 + i; j < col - i; j++)
        {
            result[i, j] = count++;
        }
        if(count >= col * row)
        {
            break;
        }
        for(int k = 1 + i; k < row -i; k++)
        {
            result[k, col -1 -i] = count++;
        }
        if(count >= col * row)
        {
            break;
        }
        for(int l = col - 2 - i; l > 0 + i; l--)
        {
            result[row -1 -i,l] = count++;
        }
        if(count >= col * row)
        {
            break;
        }
        for(int m = row - 2 - i; m > 0 + i; m--)
        {
            result[m,i] = count++;
        }
    }
    if(row == col && row % 2 == 1)
    {
        result[row / 2, col / 2] = count++;
    }
    return result;
    
}

Console.Clear();
Console.Write("Введите кол-во строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов: ");
int col = int.Parse(Console.ReadLine()!);

Console.WriteLine();
int[,] array2D = ArrayFiledSpirally(row, col);
PrintArray(array2D);