// В прямоугольной матрице найти строку с наименьшей суммой элементов.

Random rnd = new Random();
int [,] array = new int [2,3];
void CreatArray(int [,] array)
{
    for (int i = 0; i <array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1);j++)
        {
            array[i,j] = rnd.Next(1,10);
        }
    }
}
void PrintArray (int [,] array)
{
    for (int i = 0; i <array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1);j++)
        {
            Console.Write($"{array[i,j],4}");
        }
        Console.WriteLine();
    }
}
void StringMaxSumElements(int [,] array)
{
    int sumstring0 = 0;
    int sumstring1 =0;
    for (int i = 0; i <array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1);j++)
        {
            if (i==0) sumstring0 = sumstring0 +array[i,j];
            if (i==1) sumstring1 = sumstring1 +array[i,j];
        }

    }
    if (sumstring0 < sumstring1) Console.WriteLine($"Строка 0 является строкой с наименьшей суммой элементов");
    if (sumstring0 > sumstring1) Console.WriteLine($"Строка 1 является строкой с наименьшей суммой элементов");
    if (sumstring0 == sumstring1) Console.WriteLine($"сумма элементов в строках равна");
}
CreatArray(array);
PrintArray(array);
StringMaxSumElements(array);