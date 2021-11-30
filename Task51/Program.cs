// Задать двумерный массив следующим правилом: Aₘₙ = m+n
int [,] Array = new int[10,10];
void CreateArray(int [,] Array)
{
    for(int m = 0; m <Array.GetLength(0); m++)
    {
        for(int n =0; n <Array.GetLength(1); n++)
        {
             Array[m,n] = m+n;
        }
        
    }
}
void PrintArray(int [,] Array)
{
    for(int m = 0; m <Array.GetLength(0); m++)
    {
        for(int n =0; n <Array.GetLength(1); n++)
        {
           Console.Write($" {Array[m,n],4}");
        }
        Console.WriteLine();
    }
}
CreateArray(Array);
PrintArray(Array);

