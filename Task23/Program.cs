//  Показать таблицу квадратов чисел от 1 до N 

Console.WriteLine("Введите число");
void Method(int N)
{
    for(int count = 1; count <=N; count++)
    {
        Console.WriteLine($"квадрат числа {count} = {count*count}");
    }
}
int N = Convert.ToInt32(Console.ReadLine());

Method(N);
