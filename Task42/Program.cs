// Определить сколько чисел больше 0 введено с клавиатуры
Console.WriteLine("Введите 4 числа:");
int[] a = new int[4];
void Array(int [] a)
{
    for (int i = 0; i < a.Length; i++)
    a[i] = Convert.ToInt32(Console.ReadLine());
}
Array(a);

Console.WriteLine("Количество чисел больше 0");
int Count(int [] a)
{
    int count=0;
    for(int i = 0; i < a.Length; i++)
    {
        if(a[i]<0) count++;
    }
    return count;
}
Console.WriteLine(Count(a));





