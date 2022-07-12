// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if (number / 100 < 1)
    Console.WriteLine("В введенном числе нет третьей цифры ");
else
    {
        string numbertext = Convert.ToString(number);
        Console.Write("В данном числе третья цифра - это ");
        Console.Write(numbertext[2]);
        Console.WriteLine("");
    }
