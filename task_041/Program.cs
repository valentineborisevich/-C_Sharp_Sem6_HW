// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3



Console.WriteLine("Enter array's length");
int length = Convert.ToInt32(Console.ReadLine());
int[] Arr = new int[length];
FillArray(Arr);
Console.WriteLine("Your array is");
Console.WriteLine(string.Join(", ", Arr));