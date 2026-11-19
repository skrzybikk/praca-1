static double Kolo(int r)
{
    return 3.14 * r * r;
    static double Trojkat(int a, int h)
    {
        return a * h / 2.0;
    }
    static int Kwadrat(int a)
    {
        return a * a;
    }
    static int Prostokat(int a, int b)
    {
        return a * b;
    }
    static int Silnia(int a)
    {
        int wynik = 1;
        for (int i = 1; i <= a; i++)
        {
            wynik = wynik * i;
        }
        return wynik;
    }
    {
        Console.WriteLine("Wybierz opcje");
        Console.WriteLine("1-kolo");
        Console.WriteLine("2-trojkat");
        Console.WriteLine("3-kwadrat");
        Console.WriteLine("4-prostokat");
        Console.WriteLine("5-silnia");
        string wybor = Console.ReadLine();
        int a, b;
        if (wybor == "1")
        {
            Console.WriteLine("Podaj promien:");
            if (int.TryParse(Console.ReadLine(), out a))
                Console.WriteLine("Pole kola: " + Kolo(a));
        }
        else if (wybor == "2")
        {
            Console.WriteLine("Podaj podstawe:");
            if (int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Podaj wysokosc:");
                if (int.TryParse(Console.ReadLine(), out b))
                    Console.WriteLine("Pole trojkata: " + Trojkat(a, b));
            }
        }
        else if (wybor == "3")
        {
            Console.WriteLine("Podaj bok:");
            if (int.TryParse(Console.ReadLine(), out a))
                Console.WriteLine("Pole kwadratu: " + Kwadrat(a));
        }
        else if (wybor == "4")
        {
            Console.WriteLine("Podaj pierwszy bok:");
            if (int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Podaj drugi bok:");
                if (int.TryParse(Console.ReadLine(), out b))
                    Console.WriteLine("Pole prostokata: " + Prostokat(a, b));
            }
        }
        else if (wybor == "5")
        {
            Console.WriteLine("Podaj liczbe:");
            if (int.TryParse(Console.ReadLine(), out a))
                Console.WriteLine("Silnia: " + Silnia(a));
        }
        else
        {
            Console.WriteLine("Brak, wybierz jeszcze raz");
        }
        Console.ReadKey();
    }
    Console.Clear;
    Console.ReadKey(true);
    Environment.Exit(0);
}
