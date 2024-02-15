partial class Program
{
    static int[] ReadNumbers(uint length)
    {
        var numere= new int[length];
        Console.WriteLine($"Introduceti {length} numere separate de un spatiu");
        var numereRaw = Console.ReadLine()?.Split(" ");
        if (numereRaw?.Length == length)
            for (int i = 0; i < length; i++)
            {
                if (!int.TryParse(numereRaw[i], out numere[i]))
                {
                    Console.WriteLine("Nu ati introdus datele in format valid, mai incercati");
                    return ReadNumbers(length);
                }
            }
        else
        {
            Console.WriteLine("Nu ati introdus datele in format valid, mai incercati");
            return ReadNumbers(length);
        }
        return numere;
    }
    static decimal ComputeAverage(int[] numbers)
    {
        decimal average;
        average=(decimal)numbers.Sum()/numbers.Length;
        return average;
    }
    static void ShowAverage(decimal average)
    {
        Console.WriteLine(average);
    }
}