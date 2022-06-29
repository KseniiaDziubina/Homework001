Console.WriteLine("Введите два числа для сравнения");
int numberA, numberB;
numberA = Convert.ToInt32(Console.ReadLine());
numberB = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB)
{
    Console.WriteLine("Максимальное число {0}", numberA);
    Console.WriteLine("Минимальное число {0}", numberB);
}
else
{
    Console.WriteLine("Максимальное число {0}", numberB);
    Console.WriteLine("Минимальное число {0}", numberA);

};
Console.ReadLine();