// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.

Console.WriteLine("Введите цифру");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1 || number > 7)
    Console.WriteLine("Введена не корректная цифра, повторите ввод");
else
{
    if (number == 6 || number == 7)
        {
            Console.WriteLine("Выбранный день является выходным");
        }
    else
    Console.WriteLine("Выбранный день Не является выходным");
}
