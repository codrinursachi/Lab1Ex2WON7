partial class Program
{
    static int[] ReadNumbers(uint numarElemente)
    {
        var numere= new int[numarElemente];
        Console.WriteLine($"Introduceti {numarElemente} numere separate de un spatiu");
        var numereRaw = Console.ReadLine()?.Split(" ");
        if (numereRaw?.Length == numarElemente)
            for (int i = 0; i < numarElemente; i++)
            {
                if (!int.TryParse(numereRaw[i], out numere[i]))
                {
                    Console.WriteLine("Nu ati introdus datele in format valid, mai incercati");
                    return ReadNumbers(numarElemente);
                }
            }
        else
        {
            Console.WriteLine("Nu ati introdus datele in format valid, mai incercati");
            return ReadNumbers(numarElemente);
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