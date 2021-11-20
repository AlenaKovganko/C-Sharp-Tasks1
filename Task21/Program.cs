// Программа проверяет пятизначное число на палиндромом.
Console.WriteLine("Введите число");

int numbernumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Первая цифра числа");

int a = numbernumber/10000; 
Console.WriteLine(a);
Console.WriteLine("Вторая цифра числа");
int b = numbernumber/1000%10; 
Console.WriteLine(b);
Console.WriteLine("Четвертая цифра числа");
int c = numbernumber/10%10; 
Console.WriteLine(c);
Console.WriteLine("Пятая цифра числа");
int d = numbernumber%10; 
Console.WriteLine(d);

if ((a == d) & (b == c))
{
    Console.WriteLine("Число является палиндромом");
}
else Console.WriteLine("Число не является палиндромом");

