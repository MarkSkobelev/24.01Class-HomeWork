// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. Первые два элемента последовательности задаются пользователем

void ShowNumbers(int number1, int number2, int howmanytimes, bool firstTime)
{
    if(howmanytimes>1)
    {
        if(firstTime)
        {
            Console.Write($"{number1} {number2} ");
            firstTime=false;
            ShowNumbers(number2,number1+number2,howmanytimes-1,firstTime);
        }
        else
        {
            Console.Write($"{number2} ");
            ShowNumbers(number2,number1+number2,howmanytimes-1,firstTime);
        }
    }
}
Console.WriteLine("Введите число номер 1");
int usernumber1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число номер 2");
int usernumber2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сколько чисел показать?");
int userEnter = Convert.ToInt32(Console.ReadLine());
bool firstTime = true;
ShowNumbers(usernumber1,usernumber2,userEnter,firstTime);