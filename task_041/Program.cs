// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

void FillArrayManually(int number, int[] array)
{
    for (int i = 0; i < number; i++)
    {
        Console.Write($"A[{i - 1 + 1}] = ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}


Console.WriteLine("Enter array's length");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = new int[length];
FillArrayManually(length, array);
Console.WriteLine("Your array is");
Console.WriteLine(string.Join(", ", array));

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        count++;
    }
}
Console.WriteLine("Number of digits bigger than 0 is: ");
Console.WriteLine(count);