// Найти максимальное из трех чисел
int a = 10;
int b = 20;
int c = 30;
int max = a;
{
    if (a<b) max = b;
    if (max<c) max = c;
}

Console.WriteLine(max);
