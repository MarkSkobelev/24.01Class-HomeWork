// Показать натуральные числа от M до N, N и M заданы

void ShowNumbers(int M, int N)
{
    if(M<=N)
    {
        Console.Write($"{M} ");
        ShowNumbers(M+1,N);
    }
}
ShowNumbers(3,16);
