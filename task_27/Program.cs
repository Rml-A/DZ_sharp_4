// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


System.Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

for (int i = 0; num != 0; num /= 10)
{
    i += num % 10;
    if (num < 10)
    {
        System.Console.WriteLine(i);
    }

}

