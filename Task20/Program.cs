// Ввести номер четверти, показать диапазоны для возможных координат

string Range(int q)
{
    string result = String.Empty;
    if(q == 1) result = "Диапазоны для возможных координат: x>0 & y>0 ";
    if(q == 2) result = "Диапазоны для возможных координат: x<0 & y>0";
    if(q == 3) result = "Диапазоны для возможных координат: x<0 & y<0 ";
    if(q == 4) result = "Диапазоны для возможных координат: x>0 & y<0";
    return result;

}

Console.WriteLine("Введите № четверти");
int q = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Range(q));
