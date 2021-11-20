// Выяснить являются ли три числа сторонами треугольника 
Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int c = Convert.ToInt32(Console.ReadLine());


void triangle(int a, int b, int c)
{
    if ( (a+b>c) & (b+c>a) & (a+c>b)) Console.WriteLine("Числа являются сторонами треугольника");
    else Console.WriteLine("Числа не являются сторонами треугольника");
}
triangle(a,b,c);
