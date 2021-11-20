// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

int [] a = new int [20];
Console.WriteLine("Рандомный массив");

void Create(int [] a)
{
    int count = a.Length;
    for (int i = 0; i < count; i++)
    {
        
        a[i] = new Random().Next (20);
        Console.Write($"{a[i]}   ");
    }
}
Create(a);

Console.WriteLine();
Console.WriteLine("Количество четных чисел");

int Even (int[] a)
{
    int count = a.Length;
    int b = 0;
    for (int i = 0; i < count; i++)
    {
        if (a[i]%2==0) b = b +1;
    }
    return b;
}
Console.WriteLine(Even(a));
Console.WriteLine("Количество нечетных чисел");
int OddNumber(int [] a)
{
    int count = a.Length;
    int c = 0;
    for (int i = 0; i < count; i++)
    {
        if(a[i]%2 > 0) c = c + 1;
    }
    return c;
}
Console.WriteLine(OddNumber(a));
//Console.WriteLine(EvenNumber(a));