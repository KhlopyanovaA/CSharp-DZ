//Показать кубы чисел, заканчивающихся на четную цифру.

Console.Clear();

Console.WriteLine("Введите число");

int a = Convert.ToInt32(Console.ReadLine()!);
int res = 0;
int count = 1;

while(count <= a)
{
    res = count * count * count;
    if(res % 2 == 0)
    {
        Console.WriteLine(res);
    }
    count++;
}
