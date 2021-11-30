// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет

Random rnd = new Random();
int NumberUser;
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
string FindNumber(int [,] array)
{
     string result = "Числo не найдено";
    for(int i =0; i <array.GetLength(0); i++ )
    {
        for(int j=0; j <array.GetLength(1); j++)
        {
            if (array[i,j]  ==  NumberUser)  result = $"Указанное число найдено в массиве в строке {i} и в столбце {j}";
      
        }
    }
    return result;
}
CreateArray(array);
PrintArray(array);
Console.WriteLine("Введите число");
NumberUser = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine(FindNumber(array));
