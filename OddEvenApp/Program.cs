

int[] numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9];
PrintNumbers("Numbers", numbers);
PrintNumbers("Even numbers", numbers.Where(num => IsEven(num)));
PrintNumbers("Odd numbers", numbers.Where(num => IsOdd(num)));



Console.ReadKey();
static void PrintNumbers(string title, IEnumerable<int> numbers)
{
    Console.Write($"\n{title}: [ ");
    foreach (var number in numbers)
    {
        Console.Write($"{number} ");
    }
    Console.Write(" ]\n");
}
static bool IsEven(int number)
{
    if (number % 2 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}
static bool IsOdd(int number)
{
    if (number % 2 != 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}