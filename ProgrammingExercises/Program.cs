// See https://aka.ms/new-console-template for more information
using ProgrammingExercises;

List<string> sqr = new List<string>(LinqExercises.FindWordsInUpper("SOME of THESE words ARE IN uppercase"));

foreach (var item in sqr)
{
    Console.WriteLine(item);
}

Console.WriteLine(Basics.LongestCommonPrefix(new string[] { "Pacdas", "Packed", "Pace", "Pacha" }));
//Console.WriteLine(Basics.RemoveVowels("AASDDczxcvvcsFd43565ygdb33Wą#@!!@#"));