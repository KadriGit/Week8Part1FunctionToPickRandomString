string[] tvShows = { "Firefly", "Office", "The Last of Us", "Friends", "Twin Peaks", "House", "Stranger Things" };
string[] food = { "sushi", "pizza", "Chinese takeaway", "burger and chips", "chicken wings", "chips", "popcorn" };
string[] drinks = { "mineral water", "Coca-Cola", "apple juice", "milk", "beer" };

Random rnd = new Random();

int randomIndex = rnd.Next(0,tvShows.Length);

Console.WriteLine(randomIndex);
