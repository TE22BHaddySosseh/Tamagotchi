Console.WriteLine("Vad vill du döpa din Tamagotchi till?");
string name = Console.ReadLine();

Tamagotchi myTamagotchi = new Tamagotchi(name);

while (myTamagotchi.GetAlive())
    {
        myTamagotchi.PrintStats();
        Console.WriteLine("Vad vill du göra?");
        Console.WriteLine("1. Mata");
        Console.WriteLine("2. Hälsa");
        Console.WriteLine("3. Lära ett nytt ord");
        Console.WriteLine("4. Ingenting");

        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                myTamagotchi.Feed();
                break;
            case "2":
                myTamagotchi.Hi();
                break;
            case "3":
                Console.WriteLine("Vilket ord vill du lära hen?");
                string newWord = Console.ReadLine();
                myTamagotchi.Teach(newWord);
                break;
            case "4":
                Console.WriteLine("Du gör ingenting... Vad tråkigt.");
                break;
            default:
                Console.WriteLine("Ogiltigt val, försök igen.");
                break;
            }

            myTamagotchi.Tick();
    }

Console.WriteLine("Spelet är över.");
