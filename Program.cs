/*
Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше
либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Пример:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []
*/

using System;
using static System.Console;

Clear();

string[] array = AskArray();
int newArrayLength = NewArrayLength(array);
string[] newArray = NewStringArray(array, newArrayLength);

Console.WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", newArray)}]");

string[] AskArray()
{
    Console.Write("Введите значения через пробел: ");
    return Console.ReadLine().Split();
}

int NewArrayLength(string[] arr)
{
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            j++;
        }
    }
    return j;
}

string[] NewStringArray(string[] arr, int length)
{
    string[] newStringArray = new string[length];
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            newStringArray[j] = arr[i];
            j++;
        }
    }
    return newStringArray;
}