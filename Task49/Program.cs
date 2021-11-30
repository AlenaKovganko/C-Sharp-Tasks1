// 49. Показать двумерный массив размером m×n заполненный вещественными числами

Random rnd = new Random();
double [,] Array = new double [4,4];

void CreateArray(double [,] Array)
{
    for(int i = 0; i <Array.GetLength(0); i++)
    {
        for(int j =0; j <Array.GetLength(1); j++)
        {
             Array[i,j] = rnd.Next(1,100);
        }
        
    }
}
void PrintArray(double [,] Array)
{
    for(int i = 0; i <Array.GetLength(0); i++)
    {
        for(int j =0; j <Array.GetLength(1); j++)
        {
           Console.Write($" {Array[i,j],4}");
        }
        Console.WriteLine();
    }
}
CreateArray(Array);
PrintArray(Array);
