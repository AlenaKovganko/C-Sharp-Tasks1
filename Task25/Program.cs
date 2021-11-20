// Найти сумму чисел от 1 до А


void Sum(int a, int sum)
{
    for(int count = 0; count <= a; count++)
    {
        sum = sum + count;
    }
    Console.WriteLine(sum);
}
Console.WriteLine("Введите число a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сумма чисел от 1 до a");
int sum=0;
Sum(a,sum);

