// Найти сумму цифр числа

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int sum = Summ(number);
int Summ(int number)
{
    if (number > 0)
        return
        number % 10 + Summ(number / 10);
    else
        return 0;
}
Console.WriteLine($" {sum}");