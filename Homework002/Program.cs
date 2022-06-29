Console.WriteLine("Введите три числа для сравнения");
int numberA, numberB, numberC;
numberA = Convert.ToInt32(Console.ReadLine());
numberB = Convert.ToInt32(Console.ReadLine());
numberC = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB && numberA > numberC)
{
    Console.WriteLine("Максимальное число {0}", numberA);
}
else if (numberB > numberC)
{
        Console.WriteLine("Максимальное число {0}", numberB);
}
else
{
        Console.WriteLine("Максимальное число {0}", numberC);
};
Console.ReadLine();