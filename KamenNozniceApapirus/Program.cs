global using KamenNozniceApapirus;
global using Spectre.Console;
#region generators
Random generator = new Random();
Score idk = new Score();
idk.lol();
#endregion generators


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

#region diffOptionMenu
//AnsiConsole.Write(
//    new FigletText("write PLAY ")
//        .LeftAligned()
//        .Color(Color.Green));
//Console.WriteLine("pro spuštění hry");
//AnsiConsole.Write(
//    new FigletText("write EXIT")
//        .LeftAligned()
//        .Color(Color.Yellow));
//Console.WriteLine("pro ukončení aplikace");
//Console.WriteLine("---------------------");
//string odpoved = Console.ReadLine();
#endregion diffOptionMenu

#region info
Console.WriteLine("Menší info na začátek: Tvoje skóre v této hře se ti po výhře sčítá a automaticky převádí do měny (coins).");
Console.WriteLine("Hra se sa chvíli spustí. Užívej :)");
Thread.Sleep(150);
#endregion info

Console.Clear();
while (true)
{
    #region MainMenu
    var odpoved = AnsiConsole.Prompt(
        new SelectionPrompt<string>()
            .Title("[green]Vyber z možností[/]")
            .PageSize(25)
            .AddChoices(new[] {
            "PLAY", "EXIT"
            }));

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


            AnsiConsole.MarkupLine("Stiskněte jakoukoliv klávesu (pro vypnutí aplikace) nebo chvíli vyčkejte");
            Thread.Sleep(2000);
        });
        Thread.Sleep(3000);
        Console.Clear();
        Environment.Exit(1);
    }
    #endregion MainMenu

    Console.Clear();

    #region cykly
    while (idk.playAgain == true)
    {

        int volba = generator.Next(1, 4);
        if (idk.TvojeScore == 5 || idk.EnemyScore == 5)
        {

            if (idk.EnemyScore == 5)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
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
                idk.celkoveTvojeScore += 5;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Vyhrál si! Tvoje score je 5");
                #region ukazatelskore2
                AnsiConsole.Write(new BarChart()
                .Width(60)
                .Label("[green bold underline]Herní skóre[/]")
                .CenterLabel()
                .AddItem("Tvoje skóre", idk.TvojeScore, Color.Blue)
                .AddItem("Enemy skóre", idk.EnemyScore, Color.Red));
                if (idk.doubleskore == true)
                {
                    idk.celkoveTvojeScore += 5;

                }
                #endregion ukazatelskore2
                break;

            }


        }
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine($"You: {idk.TvojeScore}");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine($"Enemy: {idk.EnemyScore}");
        Console.WriteLine("--------------------");
        Console.WriteLine("Kolo hráče (tebe):");
        Console.WriteLine("    1 - kámen");
        Console.WriteLine("    2 - nůžky");
        Console.WriteLine("    3 - papír");
        Console.WriteLine("--------------------");
        if (idk.mamtitul == true)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor= ConsoleColor.DarkMagenta;
            Console.WriteLine("Vlastníš vzácný titul");
            Console.ResetColor();
        }
        if (idk.doubleskore ==true)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Double score je zapnutý");
            Console.ResetColor();
        }
        string hrac = Console.ReadLine();
        Console.Clear();


        if (volba == 1)
        {
            if (hrac == "1")
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("nepřítel zvolil kámen:");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" je to remíza ");
            }
            else if (hrac == "3")
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("nepřítel zvolil papír:");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" je to remíza ");

            }
            else if (hrac == "2")
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("nepřítel zvolil nůžky:");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Cyan;
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
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("nepřítel zvolil papír:");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("prohrál si");
                idk.EnemyScore++;
            }
            else if (hrac == "3")
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("nepřítel zvolil nůžky:");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("prohrál si ");
                idk.EnemyScore++;

            }
            else if (hrac == "2")
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("nepřítel zvolil kámen:");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red;
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
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("nepřítel zvolil nůžky:");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("vyhrál si!");
                idk.TvojeScore++;

            }
            else if (hrac == "3")
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("nepřítel zvolil kámen:");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("vyhrál si");
                idk.TvojeScore++;
            }
            else if (hrac == "2")
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("nepřítel zvolil papír:");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("vyhrál si");
                idk.TvojeScore++;
            }
            else
            {
                Console.WriteLine("musíš si vybrat kámen, nůžky nebo papír!");
            }
        }
        Console.BackgroundColor = ConsoleColor.DarkGray;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"Máš těžce vydřených: {idk.celkoveTvojeScore} coins");
        Console.ResetColor();
        Console.WriteLine("------------------------------------------");
        Console.ResetColor();

    }
    #endregion cykly

    #region credit
    var table = new Table().Centered();
    AnsiConsole.Live(table)
        .Start(ctx =>
        {
            table.AddColumn("MADE BY:");
            ctx.Refresh();
            Thread.Sleep(1000);

            table.AddColumn("Lukáš Punt :)");
            ctx.Refresh();
            Thread.Sleep(1200);

        });
    #endregion credit

    Console.Clear();

#region shopmenu
Loop:
dvacet:
    sesthotovo:
    Console.BackgroundColor = ConsoleColor.DarkGray;
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine($"Máš těžce vydřených: {idk.celkoveTvojeScore} coins");
    Console.ResetColor();
    Console.WriteLine("------------------------------------------");
    var odpoved2 = AnsiConsole.Prompt(
        new SelectionPrompt<string>()
            .Title("[green]Vyber z možností[/]")
            .PageSize(25)
            .AddChoices(new[] {
            "RESTART","SHOP (beta)", "Reedem code","EXIT"
            }));
    #region restart
    if (odpoved2 == "RESTART")
    {
        idk.EnemyScore = 0;
        idk.TvojeScore = 0;
        continue;
    }
    #endregion restart
    if (odpoved2 == "Reedem code")
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.DarkGray;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"Máš těžce vydřených: {idk.celkoveTvojeScore} coins");
        Console.ResetColor();
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Napište code:");
        int code = Convert.ToInt32(Console.ReadLine());
        if (code == 666 && idk.sestsestsest == false)
        {
            idk.celkoveTvojeScore += 666;
            idk.sestsestsest = true;
            Console.ForegroundColor= ConsoleColor.DarkRed;
            Console.WriteLine($"Code aktivován. K vašim coins bylo přidáno + 666 coins a máte {idk.celkoveTvojeScore} :)");
            Console.ResetColor();
            Thread.Sleep(2666);
            Console.Clear();
            goto sesthotovo;
        }
        else if (code == 666 && idk.sestsestsest == true)
        {
            Console.WriteLine("Code byl již využit :)");
            Thread.Sleep(2666);
            Console.Clear();
            goto sesthotovo;
        }

        if (code == 420 && idk.ctiristadvacet == false)
        {
            idk.celkoveTvojeScore += 420;
            idk.ctiristadvacet = true;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"Code aktivován. K vašim coins bylo přidáno + 420 coins a máte {idk.celkoveTvojeScore} :)");
            Console.ResetColor();
            Thread.Sleep(2420);
            Console.Clear();
            goto dvacet;
        }
        else if (code == 420 && idk.ctiristadvacet == true)
        {
            Console.WriteLine("Code byl již využit :)");
            Thread.Sleep(2420);
            Console.Clear();
            goto dvacet;
            
        }
        if (code != 666 || code != 420)
        {
            Console.Clear();
            Console.WriteLine("Byl zadán špatný kód!");
            Thread.Sleep(2500);
            Console.Clear();
            goto dvacet;
        }
    }
    #region shopbeta.
    if (odpoved2 == "SHOP (beta)")
    {
        await AnsiConsole.Progress()
            .StartAsync(async ctx =>
            {

                var task1 = ctx.AddTask("[green]Načítání obchodu[/]");


                while (!ctx.IsFinished)
                {

                    await Task.Delay(75);


                    task1.Increment(1.5);

                }
            });
        Thread.Sleep(750);
        Console.Clear();
    nemamlove:
    backtoshop:
    nemamlove2:
    backtoshop2:
    dblyes:
   titulbuy:
           
        Console.BackgroundColor = ConsoleColor.DarkGray;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"Máš těžce vydřených: {idk.celkoveTvojeScore} coins");
        Console.ResetColor();
        Console.WriteLine("------------------------------------------");

        Console.WriteLine("Prodavač: Výtejte v obchodě, co si přejete ?");
        var odpoved3 = AnsiConsole.Prompt(
        new SelectionPrompt<string>()
            .Title("[green][/]")
            .PageSize(25)
            .AddChoices(new[] {
            "Perk Procenta","TITUL: Nejostřejší nůžky, nejtvrdší kámen a nejrovnější papír","Double score", "zpět do menu"

            }));
 
        if (odpoved3 == "TITUL: Nejostřejší nůžky, nejtvrdší kámen a nejrovnější papír")
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Máš těžce vydřených: {idk.celkoveTvojeScore} coins");
            Console.ResetColor();
            Console.WriteLine("------------------------------------------");

            Console.WriteLine("Tento titul si zaslouží jenom ten nejtvrdší z kameňáků, neostřejší z nožnic a najrovnější z papírů !");
            Console.WriteLine("Titul stojí 50 coins!");
            var Titulbuy = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title("[green]Chcete si koupit Titul ?[/]")
                .PageSize(25)
                .AddChoices(new[] {
            "Ano", "ne"
                }));
            if (Titulbuy == "Ano" && idk.celkoveTvojeScore >= 50 && idk.mamtitul == false)
            {
                idk.celkoveTvojeScore = idk.celkoveTvojeScore - 50;
                Console.WriteLine("Nyní jste si koupil TITUL. Napište prosím své jméno:");
                string uzivateljmeno = Console.ReadLine();
                Console.BackgroundColor= ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{uzivateljmeno} vlastní vzácný titul!");
                Console.ResetColor();
                idk.mamtitul = true;
                Thread.Sleep(2500);
                Console.Clear();
                goto titulbuy;

            }
            else if (Titulbuy == "Ano" && idk.celkoveTvojeScore != 50 && idk.mamtitul == true || idk.celkoveTvojeScore < 50 && idk.mamtitul == true)
            {
                Console.Clear();
                Console.WriteLine("Vypadá to že nemáte dostatek coins na koupi tohoto TITULU, nebo TITUL již vlastníš...");
                Console.WriteLine("(Po chvilce vás to hodí zpět do obchodu)");
                Thread.Sleep(5000);
                Console.Clear();
                goto nemamlove;
            }
            if (Titulbuy == "ne")
            {
                Console.Clear();
                goto backtoshop;
            }
        }
        if (odpoved3 == "zpět do menu")
        {
            Console.Clear();
            goto Loop;
        }
      
   
        if (odpoved3 == "Double score")
        {
            Console.WriteLine("Tato funkce vám dává 2x více coins za výhru...");
            Console.WriteLine("Double score stojí 65 coins");
            var DblScr = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("[green]Chcete si koupit Double score ?[/]")
                    .PageSize(25)
                    .AddChoices(new[] {
            "Ano", "ne"
                    }));
            if (DblScr == "Ano" && idk.celkoveTvojeScore >= 65 && idk.doubleskore == false)
            {
                idk.celkoveTvojeScore = idk.celkoveTvojeScore - 65;
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Zakoupil jste si Double score!");
                Console.ResetColor();
                idk.doubleskore = true;
                Thread.Sleep(2500);
                Console.Clear();
                goto dblyes;
            }
            else if (DblScr == "Ano" && idk.celkoveTvojeScore != 65 && idk.doubleskore == true || idk.celkoveTvojeScore < 65 && idk.doubleskore == true)
            {
                Console.Clear();
                Console.WriteLine("Vypadá to že nemáte dostatek coins na koupi Double score, nebo máte double score již zakoupeno...");
                Console.WriteLine("(Po chvilce vás to hodí zpět do obchodu)");
                Thread.Sleep(5000);
                Console.Clear();
                goto nemamlove2;
            }
            if (DblScr == "ne")
            {
                Console.Clear();
                goto backtoshop2;
            }
            
        }
        #endregion shopbeta.
        #region exitshop
        if (odpoved2 == "EXIT")
        {
            AnsiConsole.Status()
           .Start("Processing...", ctx =>
           {

               AnsiConsole.MarkupLine("loading answer...");
               Thread.Sleep(3000);


               ctx.Status("...");
               ctx.Spinner(Spinner.Known.Star);
               ctx.SpinnerStyle(Style.Parse("green"));


               AnsiConsole.MarkupLine("Stiskněte jakoukoliv klávesu (pro vypnutí aplikace) nebo chvíli vyčkejte");
               Thread.Sleep(2000);
           });
            Thread.Sleep(3000);
            Console.Clear();
            Environment.Exit(1);
        }


    }
    #endregion exitshop
    idk.ResetSkore();
}
#endregion shopmenu
