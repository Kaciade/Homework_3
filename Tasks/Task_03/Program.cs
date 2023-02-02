// Написать программу вычисления произведения чисел от 1 до N

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine() ?? "0");
int count = 1;
int res = 1;

while (count <= num)
{
    res = res * count;
    count++;
}

Console.WriteLine($"Произведение чисел от 1 до {num} равно {res}");