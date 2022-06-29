Console.WriteLine("Введите число  ");
int numberA;
numberA = Convert.ToInt32(Console.ReadLine());
if (numberA % 2 == 0)
{
    Console.WriteLine("Число чётное");
}
else if (numberA %2 == 1)
{
    Console.WriteLine("Число нечётное");
}
