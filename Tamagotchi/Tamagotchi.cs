using System;
using System.Collections.Generic;

public class Tamagotchi{
    private int hunger;
    private int boredom;
    private List<string> words;
    private bool IsAlive;
    public string name;

    public Tamagotchi(string name)
    {
        this.name = name;
        hunger = 0;
        boredom = 0;
        words = new List<string>() { "Hej!" };
        IsAlive = true;
    }

    public void Feed()
    {
        Console.WriteLine($"Mums! [{name}] äter och blir mindre hungrig!");
        hunger -= 2;
        if (hunger < 0)
        {
            hunger = 0;
        }
    }

    public void Hi()
    {
        if (words.Count > 0)
        {
            int wordNum = Random.Shared.Next(words.Count);
            Console.WriteLine($"[{name}]: {words[wordNum]}!");
            ReduceBoredom();
        }
    }

    public void Teach(string word)
    {
        Console.WriteLine($"[{name}] lär sig ordet: {word}!");
        words.Add(word);
        ReduceBoredom();
    }

    public void Tick()
    {
        hunger++;
        boredom++;
        if (hunger > 10 || boredom > 10)
        {
            IsAlive = false;
            Console.WriteLine($"[{name}] har dött! Så synd..");
        }
    }

    public void PrintStats()
    {
        Console.WriteLine($"Namn: {name} || Hunger: {hunger} || Uttråkad: {boredom} || Ordförråd: {words.Count} ord");
    }

    public bool GetAlive()
    {
        return IsAlive;
    }

    public void ReduceBoredom()
    {
        Console.WriteLine($"[{name}] är nu mindre uttråkad!");
        boredom -= 2;
        if (boredom < 0)
        {
            boredom = 0;
        }
    }

}