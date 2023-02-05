// Найти произведение пар чисел в одномерном массиве. 

int size = new Random().Next(10, 26);
int min = 1;
int max = 100;
System.Console.WriteLine($"Количество элементов массива: {size}");

int[] FillArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

int[] GetPairProduct(int[] data)
{
    int[] product = new int[data.Length / 2];
    int last = data.Length - 1;
    for (int i = 0; i < data.Length / 2; i++)
    {
        product[i] = data[i] * data[last];
        last = last - 1;
    }
    return product;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + " ");
    }
    System.Console.WriteLine();
}

int[] array = FillArray(size, min, max);
PrintArray(array);

System.Console.WriteLine();
System.Console.WriteLine("Произведения пар чисел:");
PrintArray(GetPairProduct(array));