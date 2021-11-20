// 28. Подсчитать сумму цифр в числе

int SumDigit(int n)
{
    int sum =0;
    for (int k =0; n!=0; k++)
    {
        sum = sum + n%10;
        n=n/10;
       
    }
    return sum;
}
Console.WriteLine("Введите число");
int n =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сумма цифр в числе");
Console.WriteLine(SumDigit(n));
