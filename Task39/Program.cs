// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
int [] a = new int [6];
void Array(int [] a)
{
    for(int i =0; i <a.Length; i++)
    {
        a[i] = new Random().Next(1,10);
        Console.Write($"{a[i]} ");
    }
    
}
Console.WriteLine("Одномерный массив");
Array(a);
Console.WriteLine();

void Product(int [] a)
{
    int j = a.Length-1;
    int count = a.Length/2;
    for(int i =0;  i <count; i++)
    {
        
            Console.WriteLine($"{a[i]} * {a[j]} = {a[i] * a[j]}");
            j--;           
        
    }
}
Product(a);


