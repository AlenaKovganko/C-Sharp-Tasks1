// Написать программу преобразования десятичного числа в двоичное
Console.WriteLine("Введите число");

int number = Convert.ToInt32(Console.ReadLine());

string s= Convert.ToString(number, 2);
Console.WriteLine("В двоичной системе счисления это: "+s);



