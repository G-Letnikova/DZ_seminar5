// Задача 36. Найти сумму элементов, стоящих на нечетных позициях, нумерация c 0
void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-20, 21); // [-20, 20]
}

int ReleaseArray(int[] array)
{
    int result = 0;
    for (int i = 1; i < array.Length; i=i+2)
        result = result + array[i] ;
    return result;
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine($"Сумма чисел на нечетных позициях = {ReleaseArray(array)}");
