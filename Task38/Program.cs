// Найти сумму чисел одномерного массива стоящих на нечетной позиции
int [] a = new int [4];
void Array(int [] a)
{
    for(int i=0; i< a.Length; i++)
    {
        a[i] = new Random().Next(0,50);
        Console.Write($"{a[i]} ");
    }
} 
int SumOdd(int [] a)
{
    int sd = 0;
    for(int i=0; i< a.Length; i++)
    {
        if(i%2 > 0) sd = sd + a[i];
    }
    return sd;

}

Console.WriteLine("Рандомный массив:");
Array(a);
Console.WriteLine();
Console.WriteLine("Сумма чисел одномерного массива стоящих на нечетной позиции:");
Console.WriteLine(SumOdd(a));
