//задача 34. найти количество четных чисел в массиве из трехзначных положительных чисел


void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000); // [100, 999]
}

int ReleaseArray(int[] arr)
{
    int count = 0;
    for (int i=0; i<arr.Length; i++)
        if (arr[i]%2==0) count++;

return count;
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");

Console.WriteLine($"Четных чисел: {ReleaseArray(array)}");
