// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
int numbernumber = new Random().Next(10,99);
Console.WriteLine("Рандомное число с отрезка");
Console.WriteLine(numbernumber);
Console.WriteLine("наибольшая цифра числа");
int secondnumber = numbernumber%10;
int firstnumber = (numbernumber - secondnumber)/10;
if (firstnumber > secondnumber)
{
    Console.WriteLine(firstnumber);
}
else Console.WriteLine(secondnumber);
