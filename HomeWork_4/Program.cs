﻿/*
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
void Stepen (int a, int b) {                                                // Создаем метод void
    int result = 1;                                                         // Перемення для вывода результата
    for (int i = 0; i < b; i++){                                            // Цикл в котором накапливаем результат перемножая его на введенное число
        result *= a;                                                        //
    }                                                                       //
    Console.WriteLine($"{a} в степени {b} равно {result}");                 // Вывод результата
}

Console.Write("Введите число больше 0 которое возводим в степень: ");       // Запрос данные у пользователя
int a = Convert.ToInt32(Console.ReadLine());                                // Ввод данных
Console.Write("Введите число больше 0 для возведения в степень: ");         // -//-
int b = Convert.ToInt32(Console.ReadLine());                                // -//-
if(a > 0 && b > 0) Stepen(a, b);                                            // Проверка условия на ненулевые значения и вызов метода
else Console.Write("Введенные числа не соответствуют условию");             // Сообщение о некорректном вводе
*/

/*
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
void Sum (int num) {                                                        // Создаем метод void
    int result = 0;                                                         // Переменная для вывода результата
    for (int i = num; i != 0; i /= 10) {                                    // Цикл в котором накапливаем результат суммируя в него остаток от деления 
        result += num % 10;                                                 // введеного числа и уменьшаем его на уже просуммированную цифру
        num /= 10;                                                          //
    }                                                                       //
    Console.WriteLine(result);                                              // Вывод результата
}
Console.Write("Введите число больше 0: ");                                  // Запрос данных у пользователя
int a = Convert.ToInt32(Console.ReadLine());                                // Ввод данных
if(a > 0) Sum(a);                                                           // Проверка введенного числа на условие числа и вызов метода
else Console.Write("Введенные числа не соответствуют условию");             // Вывод сообщения о некорректном вводе
*/

/*
// Напишите программу, которая задаёт массив из произвольного элементов и выводит их на экран.
int[] StartArr (int size){                                              // Создаем метод для создания массива
    int[] result = new int[size];                                       // Создаем массив который будем наполнять и возвращать
    for (int i = 0; i < size; i++) {                                    // Цикл в котором на каждом проходе запрашивается число у пользователя и записывается в массив
        Console.Write($"Введите {i + 1} число массива: ");              //
        result[i] = Convert.ToInt32(Console.ReadLine());                //
    } 
    return result;                                                      //возвращаем массив
}

void PrintArray (int[] arr) {                                           // Создаем метод void для вывода массива
    Console.Write("{ ");                                                //
    for (int i = 0; i < arr.Length; i++){                               // Цикл на каждом проходе выводит значения из массива
        Console.Write("[" + arr[i] + "]");                              //
    }
    Console.Write(" }");                                                //
}

Console.Write("Введите число больше 0 равное размеру мессива: ");       // Запрос у пользователя числа равного глубине массива
int size = Convert.ToInt32(Console.ReadLine());                         // Ввод данных
if (size > 0) PrintArray(StartArr(size));                               // Проверка введенного числа на условие и использование методов
else Console.Write("Введенное число не соответствует условию");         // Сообщение о некорректном вводе
*/
//


