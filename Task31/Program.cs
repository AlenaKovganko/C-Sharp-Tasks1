//Задать массив из 8 элементов и вывести их на экран 

int [] A = new int [8];

int index = 0;
while(index < 8)
{
    A[index] = new Random().Next(10, 20);
    index++;
}

 Console.WriteLine("рандомный массив");
index = 0;
while(index < 8)
{
    Console.WriteLine(A[index]);
    index++;
}