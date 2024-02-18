partial class Program
{
    static int[] ReadNumbers(in uint NUMAR_ELEMENTE)
    {
        var numere= new int[NUMAR_ELEMENTE];
        Console.WriteLine($"Introduceti {NUMAR_ELEMENTE} numere separate de un spatiu");
        var numereRaw = Console.ReadLine()?.Split(" ");
        if (numereRaw?.Length == NUMAR_ELEMENTE)
            for (int i = 0; i < NUMAR_ELEMENTE; i++)
            {
                if (!int.TryParse(numereRaw[i], out numere[i]))
                {
                    Console.WriteLine("Nu ati introdus datele in format valid, mai incercati");
                    return ReadNumbers(NUMAR_ELEMENTE);
                }
            }
        else
        {
            Console.WriteLine("Nu ati introdus datele in format valid, mai incercati");
            return ReadNumbers(NUMAR_ELEMENTE);
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