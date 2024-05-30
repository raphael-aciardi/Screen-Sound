string startMensage = "Welcome to the Program";
//List<string> bandList = new List<string> {"U2", "The Beatles", "AC/DC" };

Dictionary<string, List<int>> RegistredBands = new Dictionary<string, List<int>>();
RegistredBands.Add("Linkin Park", new List<int> { 10, 8, 6 });
RegistredBands.Add("Beatles", new List<int>());


void displayLogo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");

    Console.WriteLine(startMensage);
}

void getOption()
{
    Console.WriteLine("Type 1 to register the band");
    Console.WriteLine("Type 2 to show all bands");
    Console.WriteLine("Type 3 to evaluate the band");
    Console.WriteLine("Type 4 to display the average for a band");
    Console.WriteLine("Type -1 to exit\n");
    Console.Write("Type your option: ");

    string option = Console.ReadLine();
    int numberOption = int.Parse(option);

    switch (numberOption)
    {
        case 1:
            RegisterBand();
            break;
        case 2:
            displayRegistredBands();
            break;
        case 3:
            evaluatingBand();
            break;
        case 4:
            avgBand();
            break;
        case -1:
            Console.WriteLine("See you!");
            break;
        default:
            Console.WriteLine("This option isn´t valid");
            break;

    }

}

void RegisterBand()
{
    Console.Clear();
    title("Band Register");
    Console.Write("Type the band that you want to register: ");
    string nameBand = Console.ReadLine();
    RegistredBands.Add(nameBand, new List<int>());
    Console.WriteLine($"The band that you registred was: {nameBand}");
    Thread.Sleep(2000);
    Console.Clear();
    displayLogo();
    getOption();

}

void displayRegistredBands()
{
    Console.Clear();
    title("Display all bands registreds");

    //for (int i = 0; i < bandList.Count; i++) Uso do for tradicional
    //{
    //    Console.WriteLine($"Band: {bandList[i]}");
    //};

    foreach (string band in RegistredBands.Keys) // Igual ao for c in (Python)
    {
        Console.WriteLine($"Band: {band}");
    }

    Console.Write("\nType something to return to the menu: ");
    Console.ReadKey();
    Console.Clear();
    displayLogo();
    getOption();
}

void title(string txt)
{
    int countTxt = txt.Length;
    string caracter = string.Empty.PadLeft(countTxt, '*');
    Console.WriteLine(caracter);
    Console.WriteLine(txt);
    Console.WriteLine(caracter + "\n");
};

void evaluatingBand()
{
    //Type the band
    // are there the band in dictionary
    // note
    // display mensage and return to menu

    Console.Clear();
    title("Evaluate band");
    Console.Write("Type the name of the band that you want to evaluate: ");
    string bandName = Console.ReadLine()!;
    if (RegistredBands.ContainsKey(bandName))
    {
        Console.WriteLine($"What is the note do you want to give {bandName}?");
        Console.Write("Type the note: ");
        int nota = int.Parse(Console.ReadLine()!);
        RegistredBands[bandName].Add(nota);
        Console.WriteLine("The note was registred!");
        Thread.Sleep(2000);
        Console.Clear();
        getOption();

    }
    else
    {
        Console.WriteLine($"\nThe band {bandName} is not registred");
        Console.Write("Type something to return to the menu: ");
        Console.ReadKey();
        Console.Clear();
        getOption();
    }
}

void avgBand()
{
    Console.Clear();
    title("Avarage Band");

    Console.Write("What is the band do you want to see the avarage? \n\nType the name of the band: ");
    string theBand = Console.ReadLine();

    if (RegistredBands.ContainsKey(theBand))
        {
        List<int> bandNotes = RegistredBands[theBand];
        
        Console.WriteLine($"The avarage of the band is: {bandNotes.Average()} ");
        Thread.Sleep(2500);
        } else
        {
        Console.WriteLine($"The band {theBand} is not registred!");
        Thread.Sleep(2000);
        }

    Console.Write("Type something to return to the menu: ");
    Console.ReadKey();
    Console.Clear();
    displayLogo();
    getOption();

}

displayLogo();
getOption();