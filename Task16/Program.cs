// Дано число обозначающее день недели. Выяснить является номер недели выходным днём
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine ());
if (a < 6)
{
    Console.WriteLine("Рабочий день");
}
else Console.WriteLine("Выходной день");
