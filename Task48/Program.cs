// Показать двумерный массив размером m×n заполненный целыми числами
Random rnd = new Random();
int m = 5;
int n = 4;
int [,] array = new int [m,n];
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
CreateArray(array);
PrintArray(array);