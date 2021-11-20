// 27. Определить количество цифр в числе

int CountDigit(int n)
{
    int k=0;
    for (k =0; n!=0; k++)
    {
        n =n/10;

    }
 return k;
}
Console.WriteLine("Введите число");
int n =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Количество цифр в числе");
Console.WriteLine(CountDigit(n));


