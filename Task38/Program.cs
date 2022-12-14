// Массив вещественных чисел. Найти разницу между максимальным и минимальным
void InputArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = Math.Round(new Random().NextDouble() * (30 - 1) + 1, 2); // [1, 30]
}

double ReleaseArray(double[] array)
{
    double result = 0; 
    double max = array[0]; 
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
        if (array[i] < min)
            min = array[i];
    }
    result = max - min;
    return result;
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
InputArray(array);
Console.WriteLine($"[{string.Join("  ", array)}]");
Console.WriteLine($"max - min = {Math.Round(ReleaseArray(array),2)}");
