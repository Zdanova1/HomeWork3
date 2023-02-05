// Найти произведение чисел от 1 до N.

System.Console.Write("Введите число: ");
 int N = Convert.ToInt32(Console.ReadLine());

 int GetNumComp(int x)
 {
        int comp = 1;
        for (int num = 1; num <= x; num++)
        {
            comp = comp * num;
        }

return comp;
 }
System.Console.WriteLine($"Произведение чисел от я до {N} равно: "+ GetNumComp(N));