global using KamenNozniceApapirus;
using Spectre.Console;

Random generator = new Random();
Score idk = new Score();


#region title
AnsiConsole.Write(
    new FigletText("     Vítejte ve hře")
        .LeftAligned()
        .Color(Color.Red));

AnsiConsole.Write(
    new FigletText("Kámen nůžky papír")
        .LeftAligned()
        .Color(Color.Blue));
AnsiConsole.Status()
#endregion title
#region loading
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
#endregion loading

Console.Clear();

AnsiConsole.Write(
    new FigletText("write PLAY ")
        .LeftAligned()
        .Color(Color.Green));
Console.WriteLine("pro spuštění hry");
AnsiConsole.Write(
    new FigletText("write EXIT")
        .LeftAligned()
        .Color(Color.Yellow));
Console.WriteLine("pro ukončení aplikace");
Console.WriteLine("---------------------");

string odpoved = Console.ReadLine();
if (odpoved == "PLAY")
{
    idk.playAgain = true;
}
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

while (idk.playAgain == true)
{

    int volba = generator.Next(1, 4);
    if (idk.TvojeScore == 5 || idk.EnemyScore == 5)
    {
        if (idk.EnemyScore == 5)
        {
            Console.Clear();
            Console.WriteLine("Prohrál si :(");
            #region ukazatelskore
            AnsiConsole.Write(new BarChart()
    .Width(60)
    .Label("[green bold underline]Herní skóre[/]")
    .CenterLabel()
    .AddItem("Tvoje skóre", idk.TvojeScore, Color.Blue)
    .AddItem("Enemy skóre", idk.EnemyScore, Color.Red));
            #endregion ukazatelskore
            break;
        }
        if (idk.TvojeScore == 5)
        {

            Console.Clear();
            Console.WriteLine("Vyhrál si! Tvoje score je 5");
            #region ukazatelskore2
            AnsiConsole.Write(new BarChart()
    .Width(60)
    .Label("[green bold underline]Herní skóre[/]")
    .CenterLabel()
    .AddItem("Tvoje skóre", idk.TvojeScore, Color.Blue)
    .AddItem("Enemy skóre", idk.EnemyScore, Color.Red));
            #endregion ukazatelskore2
            break;

        }
    }
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"You: {idk.TvojeScore}");
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine($"Enemy: {idk.EnemyScore}");
    Console.WriteLine("--------------------");
    Console.WriteLine("Kolo hráče (tebe):");
    Console.WriteLine("    1 - kámen");
    Console.WriteLine("    2 - nůžky");
    Console.WriteLine("    3 - papír");
    Console.WriteLine("--------------------");
    string hrac = Console.ReadLine();
    Console.Clear();


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
            idk.EnemyScore++;

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


        }
        else if (hrac == "3")
        {
            Console.WriteLine("nepřítel zvolil kámen");
            Console.WriteLine("vyhrál si");

        }
        else if (hrac == "2")
        {
            Console.WriteLine("nepřítel zvolil papír");
            Console.WriteLine("vyhrál si");

        }
        else
        {
            Console.WriteLine("musíš si vybrat kámen, nůžky nebo papír!");

        }
    }



}

var table = new Table().Centered();

AnsiConsole.Live(table)
    .Start(ctx =>
    {
        table.AddColumn("MADE BY:");
        ctx.Refresh();
        Thread.Sleep(1000);

        table.AddColumn("Lukáš Punt :)");
        ctx.Refresh();
        Thread.Sleep(1000);
    });
