// Показать натуральные числа от N до 1, N задано

void ShowNumbers(int number)
{
    if(number>=1)
    {
        Console.Write($"{number} ");
        ShowNumbers(number-1);
    }
}

ShowNumbers(10);