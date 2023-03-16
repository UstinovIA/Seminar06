// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] CreateArrayIntUser(int size)
{
    int[] arr = new int[size];
    Console.WriteLine($"Введите {size} чисел:");
    for(int i=0; i<size; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

int CountPositiveElements(int[] arr)
{
    int countPositiveElements = 0;
    for(int i=0; i<arr.Length; i++)
    {
        if(arr[i]>0) countPositiveElements++;
    }
    return countPositiveElements;
}

Console.Write("Введите количество чисел: ");
int lenght = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArrayIntUser(lenght);
int count = CountPositiveElements(array);
Console.WriteLine($"Количество введенных положительных чисел: {count}");


