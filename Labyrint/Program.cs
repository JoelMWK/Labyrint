using System;

string room = "mancave";
string action;

while (room != "exit")
{
    if (room == "mancave")
    {
        Console.WriteLine("You are in your mancave, if you head up you get to the store\n");

        Console.WriteLine("Where do you want to go?");
        action = Console.ReadLine();
        Console.Clear();

        if (action == "up")
        {
            room = "store";
        }
        else
        {
            Console.WriteLine("Stupid");
        }
    }

    else if (room == "store")
    {
        Console.WriteLine("You are now in the store, if you go down you get back to your mancave");
        Console.WriteLine("Or go right to the bathroom\n");

        Console.WriteLine("Where do you want to go?");
        action = Console.ReadLine();
        Console.Clear();

        if (action == "down")
        {
            room = "mancave";
        }

        else if (action == "right")
        {
            room = "bathroom";
        }
        else
        {
            Console.WriteLine("Stupid");
        }

    }
    else if (room == "bathroom")
    {
        Console.WriteLine("You are in the bathroom, if go left you head back to the store.");
        Console.WriteLine("If you want to exit jump down the toilet\n");
        action = Console.ReadLine();
        Console.Clear();

        if (action == "left")
        {
            room = "store";
        }
        else if (action == "jump" || action == "exit")
        {
            room = "exit";
        }
        else
        {
            Console.WriteLine("Stupid");
        }
    }
}