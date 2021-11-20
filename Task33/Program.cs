// Задать массив из 12 элементов, заполненных числами из [-9,9]. Найти сумму положительных/отрицательных элементов массива

int [] a = new int [12];
void Array(int [] a)
{
    int count = a.Length;
    for(int i=0; i <a.Length; i++)
    {
    a [i] = new Random().Next(-9, 9);
    Console.Write($"{a[i]} ");
    }
}
Console.WriteLine("Рандомный массив из 12 элементов от -9 до 9:");
Array(a);
Console.WriteLine();
Console.WriteLine("Сумма всех положительных чисел:");
int SumNegative(int [] a)
{
    int count = a.Length;
    int sumn = 0;
    for(int i=0; i <a.Length; i++)
    {
        if(a [i] < 0) sumn = sumn + a[i];
    }
    return sumn;
} 
Console.WriteLine(SumNegative(a));

Console.WriteLine("Сумма всех положительных чисел:");
int SumPositiv(int [] a)
{
    int count = a.Length;
    int sump = 0;
    for(int i=0; i <a.Length; i++)
    {
        if(a [i] > 0) sump = sump + a[i];
    }
    return sump;
} 
Console.WriteLine(SumPositiv(a));


