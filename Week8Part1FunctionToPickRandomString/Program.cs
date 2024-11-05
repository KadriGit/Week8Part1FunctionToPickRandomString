string[] tvShows = { "Firefly", "Office", "The Last of Us", "Friends", "Twin Peaks", "House", "Stranger Things" };
string[] food = { "sushi", "pizza", "Chinese takeaway", "burger and chips", "chicken wings", "chips", "popcorn" };
string[] drinks = { "mineral water", "Coca-Cola", "apple juice", "milk", "beer" };

PickRandomFromArray(tvShows);
PickRandomFromArray(food);
PickRandomFromArray(drinks);

static void PickRandomFromArray(string[] someArray)
{
    Random rnd = new Random();
    int randomIndex = rnd.Next(0,someArray.Length);
    string randomeElement = someArray[randomIndex];
    Console.WriteLine(randomeElement);
}