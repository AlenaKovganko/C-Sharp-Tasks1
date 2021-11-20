// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
int [] a = new int [123];
Console.WriteLine("Рандомный массив");
void Array(int [] a)
{
    for(int i=0; i < a.Length; i++)
    {
        a[i] = new Random().Next(0, 200);
        Console.Write($"{a[i]} ");
    }
}


int choice(int [] a)
{
    int k = 0;
    for(int i=0; i < a.Length; i++)
    {
        if(a[i]>10 & a[i] < 99) k = k + 1;
    }
    return k;
}
Array(a);
Console.WriteLine();
Console.WriteLine("Количество элементов из отрезка [10,99]");
Console.WriteLine(choice(a));



