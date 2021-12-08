// Показать натуральные числа от 1 до N, N задано
int n = Convert.ToInt32(Console.ReadLine());
int NaturalNumbers(int n)
    {
        if (n==1) return 1;
        else return  NaturalNumbers(1)*n;
    }
for (int i=1; i<=n; i++)
{
    Console.Write(NaturalNumbers(i) + " ");
}

NaturalNumbers(n);



