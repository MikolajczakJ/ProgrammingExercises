// See https://aka.ms/new-console-template for more information
using ProgrammingExercises;


//Console.WriteLine(LeetCode.RomanToInt("CVII"));
string test = "Tutaj jest string który tak i tak nie zostanie wyświetlony w całości";
int[] ints = { 1, 2, 2, 3, 3, 44, 2, 1 };
foreach (int i in ints)
{
    Console.Write($"{i} ");
}
Console.WriteLine("\n\n");
Console.WriteLine(LeetCode.RemoveDuplicates(ints));
Console.WriteLine("\n\n");
foreach (int i in ints)
{
    Console.Write($"{i} ");
}

Console.WriteLine((char)('['+2));
//List<(int,string)> sqr = new List<(int,string)>(LinqExercises.FileExtCount(new string[] { "test.exe","teeeee.bat","te.txt", "te.txt" , "te.txt" }));
//foreach (var item in sqr)
//{
//    Console.WriteLine($"Liczba plików: {item.Item1} Rozszerzenie: {item.Item2}");
//}
//List<string> months = new(DateAndTimeExc.GiveAllMonths());
//Console.WriteLine(DateAndTimeExc.CountDays(new DateTime(1999,2,11),DateTime.Now));

//foreach (var month in months)
//{
//    Console.WriteLine(month);
//}
