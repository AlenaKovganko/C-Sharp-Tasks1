// Возведите число А в натуральную степень B используя цикл
double degree(double a, double b)
{
    return Math.Pow(a, b);
}
Console.WriteLine("Введите число a");
double a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число b");
double b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Число a в степени b");
Console.WriteLine(degree(a,b));