using System;

public enum EarFlop //enum that gives different states for the ears
{
    No,   
    Left,
    Right,
    Both
}

public class Bunny //bunny class with get/set inputs
{
    public string Name { get; set; }
    public bool LikesCarrots { get; set; }
    public bool LikesHumans { get; set; }
    public EarFlop FloppyEars { get; set; }
    public bool Naughty { get; set; }

    public Bunny() { }

    public Bunny(string name)
    {
        Name = name;
    }
//constructor, sets properties
    public Bunny(string name, bool likesCarrots = false, bool likesHumans = false, EarFlop floppyEars = EarFlop.No, bool naughty = false)
    {
        Name = name;
        LikesCarrots = likesCarrots;
        LikesHumans = likesHumans;
        FloppyEars = floppyEars;
        Naughty = naughty;
    }

    public void Dump()
    {
        Console.WriteLine($"{Name} {(LikesCarrots ? "likes" : "does not like")} carrots, " +
                          $"{(LikesHumans ? "likes" : "does not like")} humans, " +
                          $"and has {FloppyEars.ToString().ToLower()} floppy ears. " +
                          $"{(Naughty ? "This bunny is naughty and does not use their litter box." : "This bunny is well-behaved.")}");
    }
}

class Program
{
    static void Main()
    {
        // object initializer with properties
        Bunny b1 = new Bunny { Name = "S'mores", LikesCarrots = true, LikesHumans = false, FloppyEars = EarFlop.No, Naughty = false };
        Bunny b2 = new Bunny("Willow") { LikesCarrots = true, LikesHumans = true, FloppyEars = EarFlop.Left, Naughty = true };
//dumps object
        b1.Dump();
        b2.Dump();
    }
}