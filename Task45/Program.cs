// Показать числа Фибоначчи
Console.WriteLine("Введите число до котрого будет выводится числа Фибоначи");
int n = Convert.ToInt32(Console.ReadLine());

    
    int a = 0;
    int b = 1;
    Console.WriteLine(a);
    Console.WriteLine(b);
    for(int i = 0; i <n; i++)
    {   
        int c = a + b;
        Console.WriteLine(c);
       a=b;
       b=c;
    }



