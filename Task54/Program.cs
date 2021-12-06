// В матрице чисел найти сумму элементов главной диагонали

Random rnd = new Random();
int [,] array = new int [3,3];
void CreateArray(int [,] array)
{
    for(int i =0; i <array.GetLength(0); i++ )
    {
        for(int j=0; j <array.GetLength(1); j++)
        {
            array[i,j] = rnd.Next(1,10);
        }
    }
}
void PrintArray(int [,] array)
{
    for(int i =0; i <array.GetLength(0); i++ )
    {
        for(int j=0; j <array.GetLength(1); j++)
        {
            Console.Write($" {array[i,j],4}");
        }
    Console.WriteLine();
    }

}
int SumElements(int [,] array)
{
    int sum = 0;
    for(int i =0; i <array.GetLength(0); i++ )
    {
        for(int j=0; j <array.GetLength(1); j++)
        {
            if (i==j) sum = sum +array[i,j];

        }
    
    }
    return sum;

}
Console.WriteLine("Рандомный массив");
CreateArray(array);
PrintArray(array);
Console.WriteLine("Сумма чисел главной диагонали");
Console.WriteLine(SumElements(array));
