// Показать кубы чисел, заканчивающихся на четную цифру

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine() ?? "0");
int count = 1;
int res = 0;
int div = 0;
Console.WriteLine("\nЧисло \t Куб числа");

while (count <= N)
{
    res = count * count * count;
    div = count % 2;
    if (div == 0)
    {
        Console.WriteLine($"{count} \t {res}");
    }
    count++;
}