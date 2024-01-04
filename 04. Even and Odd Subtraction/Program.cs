int[] numbers = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();
int sum = 0;
int sum1 = 0;
foreach (int number in numbers)
{
    if (number % 2 == 0)
    {
        sum += number;
    }
    else
    {
        sum1 += number;
    }
}
Console.WriteLine(sum - sum1);