// Дано число. Проверить кратно ли оно 7 и 23
void number(int a)
{
    if (a%7 == 0 & a%23 == 0)
{
    Console.WriteLine("Число кратно 7 и 23");
}
else Console.WriteLine("Число некратно 7 и 23");

}

Console.WriteLine("Введите число");
int a  = Convert.ToInt32(Console.ReadLine());
number(a);
