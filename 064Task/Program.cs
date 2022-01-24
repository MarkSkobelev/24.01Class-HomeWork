// Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника

void showPaskalTriangle(int[,] array)
{
    int spaceNumbers = array.GetLength(0);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int k = 0; k < spaceNumbers;k++)
        {
            Console.Write(" ");
        }
        for(int j = 0; j <= i; j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        spaceNumbers--;
        Console.WriteLine();
    }
}
int length = 5;
int[,] paskalTriangle = new int[length,length];

for(int i = 0; i < length; i++)
{
    for(int j = 0 ; j < length; j++)
    {
        if(i == j || i == 0)
        {
            paskalTriangle[i,j] = 1;
        }
        else if (i>j)
        {
            paskalTriangle[i,j] = paskalTriangle[i,j] + paskalTriangle[i-1,j];
        }
    }
}
showPaskalTriangle(paskalTriangle);