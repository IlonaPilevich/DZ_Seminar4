// Напишите программу, которая принимает на вход число и выдает сумму цифр в числе

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int Sum(int number)
{
    int result = 0;
    while (number > 0)
    {
        result += number % 10;
        number = number / 10;
    }
    return result;
}
Console.WriteLine($"Сумма всех чисел в цифре равна:  {number} = {Sum(number)}'");




