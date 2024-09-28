Menu();

static void Menu()
{
    Console.Clear();
    Console.WriteLine("S = Segundo");
    Console.WriteLine("M = Minuto");
    Console.WriteLine("0 = Sair");
    Console.WriteLine("Quanto tempo deseja contar?");

    string? data = Console.ReadLine()?.ToLower();

    char res = Convert.ToChar(data.Substring(data.Length - 1, 1));
    if (res == '0')
    {
        System.Environment.Exit(0);
    }
    
    int time = int.Parse(data.Substring(0, data.Length - 1));

    if (res == 'm')
    {
        time *= 60;
    }

    
    
    Prestart(time);

}

static void Prestart(int time)
{
    Console.Clear();
    Console.WriteLine("Ready...");
    Thread.Sleep(1000);
    Console.WriteLine("Set...");
    Thread.Sleep(1000);
    Console.WriteLine("Go!");
    Thread.Sleep(2500);
    
    Start(time);
}


static void Start(int time)
{
    int currentTime = 0;

    while (currentTime != time)
    {
        Console.Clear();
        currentTime++;
        Console.WriteLine(currentTime);
        Thread.Sleep(1000);
    }
    
    Console.Clear();
    Console.WriteLine("Stopwatch finalizado");
    Thread.Sleep(2500);
    Menu();
}