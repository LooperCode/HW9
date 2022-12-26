int Ackermann (int m, int n) 
{
    
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 && n == 0)
    {
        return Ackermann(m - 1, 1);
    }
    if (m > 0 && n > 0)
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
    return Ackermann(m,n);
}

void Sum (int m, int n, int res)
{
    
    if (m == n)
    {
        res = res + m;
        Console.Write(res);
    }
    else 
    {
        res = res + m;
        Sum(m+1, n, res);
    }
    
}

Console.Write("Выберите задачу: 66, 68: ");
int choice = Convert.ToInt32(Console.ReadLine());
if (choice == 68){
    Console.Write("Введите значение m: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите значение n: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write($"{Ackermann(m, n)}");
}
else if (choice == 66)
{
    Console.Write("Введите значение m: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите значение n: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int res = 0;
    Sum(m,n,res);
}