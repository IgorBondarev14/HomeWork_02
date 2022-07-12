// Вклад в банке составляет X рублей. Ежегодно он увеличивается на P процентов, 
//после чего дробная часть копеек отбрасывается. 
//Требуется определить: через сколько лет вклад составит не менее Y рублей.

Console.WriteLine("Введите сумму вклада: ");
double x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите процент по вкладу: ");
int p = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите сумму, которую нужно накопить: ");
int y = Convert.ToInt32(Console.ReadLine());
int s = 0;
while (x < y)
{
    x = x + ((x * p) / 100);
    s = s + 1;
}
Console.Write("Для накопления желаемой суммы Вам понадобится ");
Console.Write(s);
Console.Write(" лет");
Console.WriteLine("");
