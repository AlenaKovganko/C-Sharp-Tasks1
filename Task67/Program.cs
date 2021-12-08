// Показать натуральные числа от N до 1, N задано
Console.WriteLine("Введите число n");
int n = Convert.ToInt32(Console.ReadLine());
int NaturalNumbers(int n)
{
    if (n==1) return 1;
    else return NaturalNumbers(1)*n;
}
for (int i=n; i>0; i--)
{
    Console.Write(NaturalNumbers(i) + " ");
}
NaturalNumbers(n);
