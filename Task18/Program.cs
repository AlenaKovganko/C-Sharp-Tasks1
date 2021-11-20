// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
bool Even(int n)
{
    return n%2==0;
}

bool nit=Even(50);


bool x = true;
bool y = false;
bool f1 = ! (x || y);
bool f2 = !x && !y;
Console.WriteLine(f1==f2);

