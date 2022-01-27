// Найти сумму элементов от M до N, N и M заданы

int SumOfNumbers(int userM, int userN)
{
    if(userM<=userN)
    {
        return userM + SumOfNumbers(userM+1,userN);   
    }
    return 0;
}
int result = SumOfNumbers(1, 5);
Console.WriteLine(result);