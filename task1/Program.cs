﻿/* Задача 25: Напишите программу, которая принимает на вход два числа (A и B) 
и метод который возводит число A в натуральную степень B. 
Задание должно быть выполнено в методе. 
В методе не должно быть вывода в консоль. Не использовать Math.Pow() */

int pow(int num, int times)
{
    int result = 1;

    for (int i = 0; i < times; i++)
    {
        result *= num;
    }
    return result;
}

