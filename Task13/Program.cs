// Выяснить, кратно ли число заданному, если нет, вывести остаток.
int a = new Random ().Next(2,10); 
Console.WriteLine("Рандомное число");
Console.WriteLine(a);
Console.WriteLine("Введите число вероятно кратное ему");
int c = Convert.ToInt32(Console.ReadLine());
int b = c%a;

if (c%a == 0)
{
    Console.WriteLine("кратно");
}
else Console.WriteLine("некратно остаток:{0}", b);
