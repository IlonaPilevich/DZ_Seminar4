
Console.WriteLine("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень В: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int numberC = 1;
for (int i = 0; i < numberC; i++)
{
    Console.WriteLine($"Число А в степени В равно: " + Math.Pow(numberA, numberB));
}