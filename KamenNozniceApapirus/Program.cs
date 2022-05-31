global using KamenNozniceApapirus;
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
Score idk = new Score();

Console.Clear();
#region 
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"You: {idk.TvojeScore}");
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine($"Enemy: {idk.EnemyScore = 0}");
Console.WriteLine("--------------------");
Console.WriteLine("Kolo hráče (tebe):");
Console.WriteLine("    1 - kámen");
Console.WriteLine("    2 - nůžky");
Console.WriteLine("    3 - papír");
Console.WriteLine("--------------------");
#endregion
string hrac = Console.ReadLine();


int volba = generator.Next(1, 4);


if (volba == 1)
{
    if (hrac == "1")
    {
        Console.WriteLine("nepřítel zvolil kámen");
        Console.WriteLine(" je to remíza ");
    }
    else if (hrac == "3")
    {
        Console.WriteLine("nepřítel zvolil papír");
        Console.WriteLine(" je to remíza ");

    }
    else if (hrac == "2")
    {
        Console.WriteLine("nepřítel zvolil nůžky");
        Console.WriteLine("je to remíza ");
    }
    else
    {
        Console.WriteLine("musíš si vybrat kámen, nůžky nebo papír!");

    }

}

else if (volba == 2)
{
    if (hrac == "1")
    {
        Console.WriteLine("nepřítel zvolil papír");
        Console.WriteLine("prohrál si");
        idk.EnemyScore ++;

    }
    else if (hrac == "3")
    {
        Console.WriteLine("nepřítel zvolil nůžky");
        Console.WriteLine("prohrál si ");
        idk.EnemyScore++;

    }
    else if (hrac == "2")
    {
        Console.WriteLine("nepřítel zvolil kámen");
        Console.WriteLine("prohrál si");
        idk.EnemyScore++;
    }
    else
    {
        Console.WriteLine("musíš si vybrat kámen, nůžky nebo papír!");
    }
}
else if (volba == 3)
{
    if (hrac == "1")
    {
        Console.WriteLine("nepřítel zvolil nůžky");
        Console.WriteLine("vyhrál si!");
        idk.TvojeScore ++;

    }
    else if (hrac == "3")
    {
        Console.WriteLine("nepřítel zvolil kámen");
        Console.WriteLine("vyhrál si");
        idk.TvojeScore++;
    }
    else if (hrac == "2")
    {
        Console.WriteLine("nepřítel zvolil papír");
        Console.WriteLine("vyhrál si");
        idk.TvojeScore++;
    }
    else
    {
        Console.WriteLine("musíš si vybrat kámen, nůžky nebo papír!");
        idk.TvojeScore++;
    }
}
