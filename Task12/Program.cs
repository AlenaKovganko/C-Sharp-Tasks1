// Удалить вторую цифру трёхзначного числа
int numbernumber = new Random().Next(100,1000);
Console.WriteLine("Рандомное число с отрезка");
Console.WriteLine(numbernumber);

Console.WriteLine("Что значит Удалить?");
Console.WriteLine("1. Если обнулить второй знак");

int newnumber1 = numbernumber - numbernumber%100+numbernumber%10;

Console.WriteLine(newnumber1);

Console.WriteLine("2. Если оставить первую и третью цифру числа, то есть из трехзначного сделать двухзначное");

int number2 = numbernumber/100*10+numbernumber%10;
Console.WriteLine(number2);











