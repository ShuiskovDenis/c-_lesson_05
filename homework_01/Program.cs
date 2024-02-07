// Задайте одномерный массив из 10 целых чисел от 1 до 100. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,90].

// int [] array = {1, 5, 10, 20, 30, 40, 99, 4, 90, 3};

// int count = 0 ; 
// int max = 90;
// int min = 10;

// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] <= max && array[i] >= min)
//     {
//         count++;
//     }
// }
//     Console.WriteLine($"Count numbers = {count}");



// Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.

// int[] array = {2, 5, 2, 3, 6, 3, 7, 8, 2, 4};

// int count = 0;

// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] % 2 == 0)
//     {
//         count++;
//     }
// }

// Console.WriteLine(count);



// Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.


// double[] array = {0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01};
// double max = array[0];
// double min = array[0];

// //Нахождение максимума массива
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] > max)
//     {
//         max = array[i];
//     }
// }
// Console.WriteLine(max);

// //Нахождение минимума массива

// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] < min)
//     {
//         min = array[i];
//     }
// }
// Console.WriteLine(min);