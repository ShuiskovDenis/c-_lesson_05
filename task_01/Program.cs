// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве. Программа
// должна выдать ответ: Да/Нет.
// Примеры
// [1 3 4 19 3], 8 => Нет
// [-4 3 4 1], 3 => Да

// int[] array = { 11, 22, 3, 9, 5, 6, 7, 8, 9 };

// int numberForSearch = Convert.ToInt32(Console.ReadLine());

// bool isFound = false;

// for (int i = 0; i < array.Length; i++)
// {
//     if (numberForSearch == array[i])
//     {
//         isFound = true;
//         Console.WriteLine($"Number is found -> {array[i]} \n[store in case -> {i+1}]");
//         break;
//     }

// }

// if (isFound == false)
// {
//     Console.WriteLine($"Number {numberForSearch} is not found");
// }



// Задайте массив из 10 элементов, заполненный числами из
// промежутка [-10, 10]. Замените отрицательные элементы на
// положительные, а положительные на отрицательные.
// Пример
// [1 -5 6]
// => [-1 5 -6]

// int[] array = { -1, 2, -2, -3, 0, -6, 3, 1, 9 };

// Console.WriteLine($"Start -> [{string.Join("; ",array)}]");    

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = -array[i];
// }
// Console.Write($"Rezult -> [{string.Join("; ",array)}]");    


// Найдите произведения пар чисел в одномерном массиве. Парой
// считаем первый и последний элемент, второй и предпоследний и
// т.д. Результат запишите в новый массив.

// int[] array = { 11, 22, 33, 44, 55, 66, 77, 88 };
// int[] arrayResult = new int[array.Length / 2];
// int j = array.Length - 1;
// for (int i = 0; i < arrayResult.Length; i++, j--)
// {
//     arrayResult[i] = array[i] * array[j];
// }
// Console.WriteLine($"Result -> [{string.Join("; ",arrayResult)}]");