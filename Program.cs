string greeting = @"Welcome to Thrown For a Loop
Your one-stop shop for used sporting equipment";

Console.WriteLine(greeting);

List<Product> products = new List<Product>()
{
    new Product()
    {
        Name = "Football",
        Price = 15.00M,
        Sold = false,
        StockDate = new DateTime(2022, 10, 20),
        ManufactureYear = 2010,
        Condition = 4.2
    },
    new Product()
    {
        Name = "Hockey Stick",
        Price = 12.00m,
        Sold = false,
        StockDate = new DateTime(2024, 12, 25),
        ManufactureYear = 2020,
        Condition = 4.5
    },
    new Product()
    {
        Name = "Chest Piece",
        Price = 545.35m,
        Sold = false,
        StockDate = new DateTime(2015, 10, 20),
        ManufactureYear = 2005,
        Condition = 5.0
    }
};

decimal totalValue = 0.0M;
foreach (Product product in products)
{
    if (!product.Sold)
    {
        totalValue += product.Price;
    }
}
Console.WriteLine($"Total inventory value: ${totalValue}");

Console.WriteLine("Products:");

for (int i = 0; i < products.Count; i++)
{
    Console.WriteLine($"{i + 1}. {products[i].Name}");
}

Console.WriteLine("Please enter a product number: ");

int response = int.Parse(Console.ReadLine().Trim());

while (response > products.Count || response < 1)
{
    Console.WriteLine("Choose a number between 1 and 5!");
    response = int.Parse(Console.ReadLine().Trim());
}

DateTime now = DateTime.Now;

Product chosenProduct = products[response - 1];

TimeSpan timeInStock = now - chosenProduct.StockDate;
Console.WriteLine($@"You chose:
{chosenProduct.Name}, which costs {chosenProduct.Price} dollars.
It is {now.Year - chosenProduct.ManufactureYear} years old.
it {(chosenProduct.Sold ? "is not available." : $"has been in stock for {timeInStock.Days} days.")}");