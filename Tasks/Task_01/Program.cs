// Найти кубы чисел от 1 до N

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine() ?? "0");
int count = 1;
int res = 0;
Console.WriteLine("\nЧисло \t Куб числа");

while (count <= N)
{
    res = count * count * count;
    Console.WriteLine($"{count} \t {res}");
    count++;
}