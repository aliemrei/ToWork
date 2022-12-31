// See https://aka.ms/new-console-template for more information
Console.WriteLine("Runnig totals : ");

foreach (var item in YieldOperations.GetRunningTotals())
{
    Console.WriteLine(item);
}

Console.WriteLine("Filtered numbers : ");

foreach (var item in YieldOperations.Filter())
{
    Console.WriteLine(item);
}

Console.ReadKey();

public class YieldOperations
{
    static List<int> numbers = Enumerable.Range(1, 30).Where(x => x % 2 == 0).ToList();

    public static IEnumerable<double> GetRunningTotals()
    {
        double total = 0;

        foreach (double item in numbers)
        {
            total += item;

            yield return total;
        }
    }

    public static IEnumerable<double> Filter()
    {
        foreach (double item in numbers)
        {
            if (item > 10)
                yield return item;
        }
    }
}

