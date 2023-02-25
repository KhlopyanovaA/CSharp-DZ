// Пользователь вводит с клавиатуры M чисел.
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();
int[] GetArray(int size, int minValue, int maxValue)
{
  int[] result = new int[size];
    for(int i = 0; i < size; i++)
    {
       result[i] = new Random().Next(minValue, maxValue + 1);
    }
   return result;
}
int findcount(int[] inArray)
{
    int count = 0;
    for(int i = 0; i < inArray.Length; i += 1)
    {
       if(inArray[i] > 0)
       {
        count++;
       }
    }
    return count;
}

int[] array = GetArray(5, -4, 10);
Console.WriteLine(String.Join(",", array));
int count = findcount(array);
Console.WriteLine($"введено чисел больше 0 = {count}");
