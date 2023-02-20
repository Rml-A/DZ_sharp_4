// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]


int[] GetArr(int size, int leftRange, int rightRange)
{

    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(leftRange, rightRange);
    return arr;
}


void PrintArray(int[] mass)
{

    System.Console.Write("[" + string.Join(", ", mass) +"]");

}

int[] array = GetArr(8, 0, 101);
PrintArray(array);
