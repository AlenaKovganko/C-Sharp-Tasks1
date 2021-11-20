// Написать программу замену элементов массива на противоположный

int[] a = new int[10];

Console.WriteLine("Рандомный массив");

void CreateArray (int[] a)
{
    int count = a.Length;
    for (int i = 0; i < count; i++)
    {
        a [i] = new Random().Next(1, 10);
        Console.Write($"{a[i]}  ");
    }
}

CreateArray(a);

Console.WriteLine();

Console.WriteLine("Массив после замены элемнтов на противоположные");

void Opposite (int [] a)
{
    int count  = a.Length;
    for (int i = 0; i < count; i++)
    {
        a[i] = - a[i];
        Console.Write($"{a[i]}  ");
    }
}
Opposite(a);
