﻿string greeting = @"Welcome to Thrown For a Loop
Your one-stop shop for used sporting equipment";

Console.WriteLine(greeting);

List<string> products = new List<string>()
{
    "Football",
    "Hockey Stick",
    "Boomerang",
    "Frisbee",
    "Golf Putter"
};

Console.WriteLine("Products:");

for (int i = 0; i < products.Count; i++)
{
    Console.WriteLine($"{i + 1}. {products[i]}");
}

Console.WriteLine("Please enter a product number: ");

int response = int.Parse(Console.ReadLine().Trim());

while (response > products.Count || response < 1)
{
    Console.WriteLine("Choose a number between 1 and 5!");
    response = int.Parse(Console.ReadLine().Trim());
}

Console.WriteLine($"You chose: {products[response - 1]}");