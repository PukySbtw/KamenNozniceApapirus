using Spectre.Console;

Random generator = new Random();

#region
AnsiConsole.Write(
    new FigletText("     Vítejte ve hře")
        .LeftAligned()
        .Color(Color.Red));

AnsiConsole.Write(
    new FigletText("Kámen nůžky papír")
        .LeftAligned()
        .Color(Color.Blue));
AnsiConsole.Status()
#endregion
    .Start("Vyčkejte prosím...", ctx =>
    {

        AnsiConsole.MarkupLine("Loading...");
        Thread.Sleep(3000);


        ctx.Status("...");
        ctx.Spinner(Spinner.Known.Star);
        ctx.SpinnerStyle(Style.Parse("green"));


        AnsiConsole.MarkupLine("Loading Game...");
        Thread.Sleep(5000);
    });

Console.Clear();


Console.WriteLine("napište PLAY (pro spuštění) nebo EXIT (pro vypnutí)");
string odpoved = Console.ReadLine();
if (odpoved == "EXIT")
{
    AnsiConsole.Status()
    .Start("Processing...", ctx =>
    {

        AnsiConsole.MarkupLine("loading answer...");
        Thread.Sleep(3000);

        
        ctx.Status("...");
        ctx.Spinner(Spinner.Known.Star);
        ctx.SpinnerStyle(Style.Parse("green"));

       
        AnsiConsole.MarkupLine("NASCHLE PANE");
        Thread.Sleep(2000);
    });
    Thread.Sleep(3000);
    Console.Clear();
    Environment.Exit(1);
}

Console.Clear();
#region 
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("You: 0");
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("Enemy: 0");
Console.WriteLine("--------------------");
Console.WriteLine("Kolo hráče (tebe):");
Console.WriteLine("    1 - kámen");
Console.WriteLine("    2 - nůžky");
Console.WriteLine("    3 - papír");
Console.WriteLine("--------------------");

string hrac = Console.ReadLine();
if (hrac == "1")
{

}

int volba = generator.Next(1, 4);