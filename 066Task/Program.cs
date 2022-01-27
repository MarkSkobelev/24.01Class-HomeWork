//Показать натуральные числа от 1 до N, N задано

void ShowNumbers(int userNumbers, int index)
{
    if(index <= userNumbers)
    {
        Console.WriteLine(index);
        ShowNumbers(userNumbers, index+1);
    }
}
int N = 10;
ShowNumbers(N, 5);