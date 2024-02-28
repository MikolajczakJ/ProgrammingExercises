// See https://aka.ms/new-console-template for more information
using ProgrammingExercises;

//List<(int,string)> sqr = new List<(int,string)>(LinqExercises.FileExtCount(new string[] { "test.exe","teeeee.bat","te.txt", "te.txt" , "te.txt" }));
//foreach (var item in sqr)
//{
//    Console.WriteLine($"Liczba plików: {item.Item1} Rozszerzenie: {item.Item2}");
//}
List<string> months = new(DateAndTimeExc.GiveAllMonths());
Console.WriteLine(DateAndTimeExc.CountDays(new DateTime(1999,2,11),DateTime.Now));

foreach (var month in months)
{
    Console.WriteLine(month);
}
