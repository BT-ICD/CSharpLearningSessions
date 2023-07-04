// See https://aka.ms/new-console-template for more information
//C# yield keyword
//Learning References: https://www.programiz.com/csharp-programming/yield-keyword

Console.WriteLine("Hello, World!");

IEnumerable<int> GetNumber()
{
    // create a list of integers 
    List<int> myList = new List<int> { -1, -4, 3, 5 };

    foreach (var num in myList)
    {
        // returns positive number from myList 
        if (num >= 0)
        {
            yield return num;

            // location of the code is preserved 
            // so on the next iteration getNumber() is executed from here 
            Console.WriteLine(".... After yeild return ....");
        }

    }
}
// define an iterator method
IEnumerable<string> getString()
{
    // create a list of strings 
    List<string> myList = new List<string> { "Sun", "Mon", "Tue" };

    foreach (var day in myList)
    {
        if (day == "Mon")
        {
            // terminates the iterator block after encountering "Mon"
            yield break;

        }

        yield return day;
    }
}
// display return values of getNumber() 
foreach (var items in GetNumber())
{
    Console.WriteLine(items);
}
// display return values of getString() 
Console.WriteLine("String Names");
foreach (var items in getString())
{
    Console.WriteLine(items);
}