// В первый день спортсмен пробежал X километров. В каждый последующий день он увеличивал 
// пробег на 15% от предыдущего дня. По данному числу Y требуется определить номер дня, 
// в который пробег спортсмена составил не менее Y километров

Console.WriteLine("Введите количество километров, преодаленных в первый день");
double x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество километров, искомый день");
int y = Convert.ToInt32(Console.ReadLine());
int d = 0;
while (x < y)
{
    x = x + (x * 0.15);
    d++;
}
Console.Write("Чтобы пробежать указанное растояние, спортсмен потратил ");
Console.Write(d);
Console.Write(" дней");
Console.WriteLine("");