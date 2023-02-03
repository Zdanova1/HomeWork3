//Найти сумму чисел от 1 до А.

System.Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());

int GetSum(int A)
{
    int num = 1;
    int sum = 0;
    for(int i = 0; i<A; i++)
    {
            sum = sum + num;
            num++;
    }
    return sum;
}

int NumSum = GetSum(A);
System.Console.Write($"Сумма чисел от 1 до А = ");
System.Console.WriteLine(NumSum);
