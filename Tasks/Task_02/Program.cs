// Подсчитать сумму цифр в числе

Console.Write("Введите число: ");
int num1 = int.Parse(Console.ReadLine() ?? "0");
int num2 = num1;
int sum = 0;

while (num2 > 0)
{
    int digit = num2 % 10;
    sum = sum + digit;
    num2 = num2 / 10;
}

Console.WriteLine($"Сумма цифр числа {num1} равна {sum}");