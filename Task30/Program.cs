// Показать кубы чисел, заканчивающихся на четную цифру
void Cube(int N)
{
    for(int i=1; i <=N; i++)
    {
        if(i*i*i%2==0)
        Console.WriteLine($"Куб числа {i} = {i*i*i}");
    }

}
Console.WriteLine("Введите число N, до которого будут выводиться кубы чисел");
int N = Convert.ToInt32(Console.ReadLine());

Cube(N);

