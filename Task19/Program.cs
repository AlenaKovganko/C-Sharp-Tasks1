//  Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0

Console.Write("Введите значение x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение y: ");
int y = Convert.ToInt32(Console.ReadLine());
string quarter(int x, int y)
{
    string result = String.Empty;
    if (x>0 & y>0) result = "Четверть № 1";
    if (x<0 & y>0) result = "Четверть № 2";
    if (x<0 & y<0) result = "Четверть № 3";
    if (x>0 & y<0) result = "Четверть № 4";
    return result;
}


Console.WriteLine(quarter(x,y));