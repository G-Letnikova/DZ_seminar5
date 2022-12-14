void InputArray(int[] array)
{     for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 32);             // [1, 31]
}


int HowMany4(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count += 1;
    }
    return count;
}


Console.Clear();
Console.Write("Введите кол-во дней: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");

int[] array3 = new int[array.Length-HowMany4(array)];
int[] array4 = new int[HowMany4(array)];

int inx1 = 0, inx2 = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] %2 == 0) 
    { 
    array4[inx1] = array[i];
    inx1++;
    }
    else 
    {
        array3[inx2] = array[i];
        inx2++;
    }
 }
    Console.WriteLine($"[{string.Join(", ", array3)}]");
    Console.WriteLine($"[{string.Join(", ", array4)}]");

if (array4.Length >= array3.Length) Console.WriteLine("Yes");
else Console.WriteLine("No");