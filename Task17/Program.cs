// По двум заданным числам проверять является ли одно квадратом другого
void Print1()
{
    Console.WriteLine("Введите первое число");

}
Print1();
int a = Convert.ToInt32(Console.ReadLine());
void Print2()
{
    Console.WriteLine("Введите второе число");
}
Print2();
int b = Convert.ToInt32(Console.ReadLine());
int a2 = a*a;
int b2 = b*b;
if (b==a*a || a==b*b)
{
    Console.WriteLine("является");

}  
else Console.WriteLine("не является");









