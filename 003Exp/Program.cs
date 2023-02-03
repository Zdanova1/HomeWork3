// Возведите число А в натуральную степень В используя цикл

int num = 2;
int exp = 6;
int count = 1;
int res = num;

while (count < exp)
{
    res = res*num;
    count++;
}

System.Console.WriteLine($"{num} ^ {exp} = {res} ");