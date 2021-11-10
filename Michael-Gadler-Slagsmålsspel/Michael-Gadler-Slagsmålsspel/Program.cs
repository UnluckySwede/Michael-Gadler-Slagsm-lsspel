using System;


int Randomhobohp = 69;

int Policehp = 420;

int round = 0;

Random generator = new Random();

System.Console.WriteLine("You got caught drilling a hobo!!! You run and leave the hobo behind, save him from the police!");
Console.ReadLine();

while (Randomhobohp > 0 && Policehp > 0)
{
    System.Console.WriteLine($"----->Round {round + 1}<-----");
    round++;
    System.Console.WriteLine("       Start");

    int Hobodmg = generator.Next(140);
    Policehp -= Hobodmg;
    Policehp = Math.Max(0, Policehp);
    System.Console.WriteLine("Hobo used cock slap!");
    System.Console.WriteLine("Super Effective!");
    System.Console.WriteLine($"It dealt {Hobodmg}, the police has {Policehp} left!");

    int Policedmg = generator.Next(23);
    Randomhobohp -= Policedmg;
    Randomhobohp = Math.Max(0, Randomhobohp);
    System.Console.WriteLine("The hobo is white so police uses baton!");
    System.Console.WriteLine("It's not effective since the hobo is drunk!");
    System.Console.WriteLine($"It dealt {Policedmg}, Hobo stands up with {Randomhobohp} left!");

    System.Console.WriteLine("you wanna play another round to see who wins?");
    System.Console.WriteLine("          -----> Press enter <-----");
    Console.ReadLine();

}

System.Console.WriteLine("The Cum has dried and the fight has aswell!");

if (Randomhobohp == 0 && Policehp == 0)
{
    System.Console.WriteLine("They both fall to the ground after an intense fight!");
}
else if (Randomhobohp == 0)
{
    System.Console.WriteLine("The hobo finally dies of bloodloss from being hit by the baton!");
}
else if (Policehp == 0)
{
    System.Console.WriteLine("The police loves BDSM and kneels in submission!");
}

System.Console.WriteLine("Same story different kink. Press enter to end the game.");
Console.ReadLine();

