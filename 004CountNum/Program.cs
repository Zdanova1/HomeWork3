// Подсчитать сумму цифр в числе

int n = 4321;
int sum = 0;
for (int i = n; i>0; i=i/10)
{
    sum = sum + i%10;
}
Console.WriteLine(sum);