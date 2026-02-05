
char input = ' ';
static void PrintMenu()
{
    Console.Clear();
    Console.WriteLine("=====================================");
    Console.WriteLine("            Sleep Tracker            ");
    Console.WriteLine("=====================================");
    Console.WriteLine("1) create a sleep log");
    Console.WriteLine("2) view sleep logs");
    Console.WriteLine("3) exit");
    Console.Write("Enter:");
    

}
DateTime  GetSundayOfWeek(DateTime date)
{
    // Get the current day of the week (e.g., Monday, Tuesday, Sunday, etc.)
    DayOfWeek currentDayOfWeek = date.DayOfWeek;

    // Calculate how many days back to go to reach Sunday.
    // In .NET, Sunday is represented by 0, Monday by 1, and so on.
    int daysUntilSunday = DayOfWeek.Sunday - currentDayOfWeek;

    // Add this offset to the original date. This will be a negative number
    // for days other than Sunday, effectively going backward in time.
    DateTime sundayDate = date.AddDays(daysUntilSunday);

    // Return the result, ensuring the time component is set to midnight (start of the day).
    return sundayDate.Date;
}
DateTime today = DateTime.Today;

do 
{ 
    PrintMenu();
    input = Console.ReadKey().KeyChar;
    if (input == '1')
    {
        // Create a sleep log
        Console.Clear();
        Console.WriteLine("Sleep Tracker - Create Sleep Log");
        DateTime weekOf = GetSundayOfWeek(today);
        Console.WriteLine("Please enter the amount of hours you slept each night");
        Console.Write("Sunday: ");
        string sunday = Console.ReadLine();
        Console.Write("Monday: ");
        string monday = Console.ReadLine();
        Console.Write("Tuesday: ");
        string tuesday = Console.ReadLine();
        Console.Write("Wednesday: ");
        string wednesday = Console.ReadLine();
        Console.Write("Thursday: ");
        string thursday = Console.ReadLine();
        Console.Write("Friday: ");
        string friday = Console.ReadLine();
        Console.Write("Saturday: ");
        string saturday = Console.ReadLine();
        Console.WriteLine("Sleep log created successfully!");
        Task.Delay(1000).Wait();
        Console.Clear();
    } else if (input == '2')
    {
        // View sleep logs
        Console.Clear();
        Console.WriteLine("You entered 2");
    } else if (input == '3')
    {
        Console.Clear();
        Console.WriteLine("Exiting...");
        Task.Delay(1000).Wait();
        Console.WriteLine("Goodbye!");
    }
    else
    {
        // Invalid input
        Console.Clear();
        Console.WriteLine("Invalid input");
        Task.Delay(1000).Wait();
        Console.Clear();
    } 
}while (input != '3');

