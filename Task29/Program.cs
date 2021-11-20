// Написать программу вычисления произведения чисел от 1 до N


int factorial(int N)
{
    int fact = 1;
    for (int i=1; i<=N; i++)
    {
        fact = fact * i;
    }
    return fact;
   
}
Console.WriteLine("Введите число N");
int N =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Факториал числа N");
Console.WriteLine(factorial(N));
