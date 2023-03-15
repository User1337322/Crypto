using Crypto;
using Crypto.Ciphers;

internal class Program
{
    private static void Main(string[] args)
    {
        string text = File.ReadAllText("file.txt");




        string TestString = "There is something wrong with this task, but i believe that it will be done untill tomorrow ";
        string repeats = Filter.RemoveSpecialCharacters(TestString, false);
        Dictionary<char, int> symbolsCount = CalculateSymbols.GetSymbolCount(repeats);
        Dictionary<string, int> bigrams = CalculateSymbols.GetBigramsCount(repeats);
        foreach (KeyValuePair<char, int> pair in symbolsCount)
        {
            Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
        }

        Console.WriteLine(symbolsCount.Count);

        Console.WriteLine(new String('_', 50));

        foreach (KeyValuePair<string, int> pair in bigrams)
        {
            Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
        }
    }
}