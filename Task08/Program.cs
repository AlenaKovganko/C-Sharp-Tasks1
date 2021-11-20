// Показать четные числа от 1 до N
Console.WriteLine("Введите число N");
int N;
N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Четные числа от 1 до N");
 
 int index;
 index = 1;
 while (index < N)
 {
     if (index%2 == 0)
     {
         Console.WriteLine(index);
    
     }
      index++;
 }
