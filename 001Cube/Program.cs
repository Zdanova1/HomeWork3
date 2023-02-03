﻿// Найти кубы чисел от 1 до N.

System.Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

int[] Cube(int N)
{
    int[] cubs = new int[N];
    int number = 1;
    for(int i = 0; i < N; i++)
    {
            cubs[i] = number*number*number;
            number++;
    }
    return cubs;
}
void PrintCubs(int[] array)
{
    int number = 1;
    for (int i = 0; i < array.Length; i++)
{

    System.Console.Write($"{number}^3 = ");
    System.Console.WriteLine(array[i]);
    number++;
    
}
}
int[] CubeNum = Cube(N);
PrintCubs(CubeNum);
