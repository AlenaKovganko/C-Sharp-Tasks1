// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
double [] a = new double[10];
void Array(double [] a)
{
    for(int i=0; i<a.Length;i++)
    {
    a[i] = new Random().Next(1,20);
    Console.Write($"{a[i]} ");

    }
    
}

double Difference(double [] a)
{
    double maxValue = a.Max<double>();
    double minValue = a.Min<double>();
    double diff = maxValue - minValue;
    return diff;

}


Console.WriteLine("Рандомный массив");
Array(a);
Console.WriteLine();

Console.WriteLine("Разница между максимальным и минимальным элементом");
Console.WriteLine(Difference(a));



