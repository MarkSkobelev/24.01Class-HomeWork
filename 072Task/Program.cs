// Написать программу возведения числа А в целую степень B

int PowMyNumber(int A, int B, int index)
{
    if(index<B)
    {
        Console.WriteLine("Программа зашла в цикл в {0} раз", index+1);
        index++;
        return A * PowMyNumber(A,B,index);
    }
    else return 1;
}
Console.WriteLine(PowMyNumber(5,3,0));
