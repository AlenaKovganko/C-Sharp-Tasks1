// 50. В двумерном массиве n×k заменить четные элементы на противоположные

int n = 2;
int k =3;

int [,] Array = new int [n,k];
Random rnd = new Random();
void CreateArray(int [,] Array)
{
    for(int i = 0; i <Array.GetLength(0); i++)
    {
        for(int j =0; j <Array.GetLength(1); j++)
        {
             Array[i,j] = rnd.Next(-100,100);
        }
        
    }
}
void PrintArray(int [,] Array)
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
void ChangeEvenNumbers(int [,] Array)
{
    for(int i = 0; i <Array.GetLength(0); i++)
    {
        for(int j =0; j <Array.GetLength(1); j++)
        {
           if(Array[i,j]%2==0) Array[i,j] = -Array [i,j];
        }
    }

}
void PrintArray2(int [,] Array)
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
Console.WriteLine("Рандомный Массив");
PrintArray(Array);
Console.WriteLine("Массив после замены четных элементов на противоположные");
ChangeEvenNumbers(Array);
PrintArray2(Array);
