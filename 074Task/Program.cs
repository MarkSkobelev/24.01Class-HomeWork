// В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита.

void showWords(string str, int number, int indexForStr, int indexForNumber)
{
    if(indexForNumber<number)
    {
        Console.Write(str[indexForStr]);
        showWords(str, number, indexForStr, indexForNumber+1);
    }
    if(indexForStr<str.Length-1)
    {
        showWords(str,number,indexForStr+1,indexForNumber);
    }
}
string alphabet = "аисв";
Console.WriteLine("Укажите длину слов, которые нужно составить");
int number = Convert.ToInt32(Console.ReadLine());
showWords(alphabet, number, 0, 0);


