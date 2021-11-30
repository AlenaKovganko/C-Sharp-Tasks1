// 52. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
Random rnd = new Random();

int [,] array = new int [4,10];
void CreateArray(int [,] array)
{
    for(int i =0; i <array.GetLength(0); i++ )
    {
        for(int j=0; j <array.GetLength(1); j++)
        {
            array[i,j] = rnd.Next(1,100);
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
Console.WriteLine("Рандомный массив");
void ChangeElement(int [,] array)
{
    for(int i =0; i <array.GetLength(0); i++ )
    {
        for(int j=0; j <array.GetLength(1); j++)
        {
            if (i%2==0 & j%2==0) array[i,j] = array [i,j] * array [i,j];
        }
    }
}
void PrintArray2(int [,] array)
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
CreateArray(array);
PrintArray(array);
Console.WriteLine("Массив после замены элементов");
ChangeElement(array);
PrintArray2(array);


