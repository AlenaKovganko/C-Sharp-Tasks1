// Показать числа от -N до N
Console.WriteLine("Введите число N");
int maxN;
maxN = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Числа от -N  до N");
int minN;
minN = - maxN;

int index;
index = minN;
while (index <= maxN)
{
    Console.WriteLine(index);
    index++;
}

