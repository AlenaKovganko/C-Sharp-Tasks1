

Console.WriteLine("Рандомный массив");

int [] a = new int [20];

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
Console.WriteLine("Введите число");
int b = Convert.ToInt32(Console.ReadLine());

string Find(int[] a)
{
     int count = a.Length;
     string result = "Числа нет ";
    for (int i = 0; i < count; i++)
    {
         if (a[i] == b) result = "Число есть";
    }
    return result;
}
Console.WriteLine(Find (a));
