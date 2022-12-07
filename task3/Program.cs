/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */


int[] fillArray(int size)

{
    int[] numbersArray = new int[size];
    int i = 0;
    do
    {
        Console.WriteLine("Input the number: ");
        bool isNumber = int.TryParse(Console.ReadLine(), out int num);
        

        if (!isNumber)
        {
            Console.WriteLine("Not a number! Try again");
            continue;
        }

        numbersArray[i] = num;
        i++;

    } while (i < size);

    return numbersArray;
}

Console.WriteLine("[" + String.Join(", ", fillArray(5)) + "]");
Console.WriteLine("[" + String.Join(", ", fillArray(3)) + "]");