// Найти третью цифру числа или сообщить, что её нет
int a = new Random().Next(1,300);
Console.WriteLine("Рандомное число от от 1 до 300");
Console.WriteLine(a);
int b = a/100;  //нахождение 3 цифры

if (b > 0)
{
    Console.WriteLine("Третья цифра:{0}", b);
}
else Console.WriteLine("Третьей цифры нет");
