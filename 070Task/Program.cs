// Найти сумму цифр числа

int SumOfDigit(int number)
{
    if(number>=1)
    {
        return number%10 + SumOfDigit(number/10);
    }
    return 0;
}
int number = SumOfDigit(893);
Console.WriteLine(number);