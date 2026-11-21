
//01


using System.Diagnostics;

double[] price = { 25.5, 40.0, 33.75 };

Console.WriteLine(price[1]);


//02


int[,] shelfCopies =
{
    {3, 5 },
    {1, 4 }
};
Console.WriteLine(shelfCopies[1, 0]);


//03


static void PrintWelcomeMessage()
{
    Console.WriteLine("Welcome to the Library!");
}
PrintWelcomeMessage();


//04


static void PrintBookTitle(string title)
{
    Console.WriteLine($"Book Title: {title}");
}
PrintBookTitle("clean Code");



//05


static void AddBonusPages(int pages)
{
    pages += 50;
}
int pages = 400;
AddBonusPages(pages);
Console.WriteLine(pages);             //  int = value type msh reference type fa kda httb3 400 bs



//06


static void ApplyDiscount(double[] prices)
{
    prices[0] -= 5; 
}
double[] Prices = { 25.5, 40.0 };
ApplyDiscount(Prices);
Console.WriteLine(Prices[0]);           // double = reference type msh value type fa kda httb3 20.5 


//07


static void AddBonusPagesByRef(ref int pages)
{
    pages += 50;
}
int pages01 = 400;
AddBonusPagesByRef(ref pages01);
Console.WriteLine(pages01);             // bsbb enna 3mlna ref    



//08 ####################



//09


//static bool TryGetPrice(string title, out double price)
//{
//    if (title == "Clean Code")
//    {
//        price = 25.5;
//        return true;
//    }

//    price = 0;
//    return false;
//}
//TryGetPrice("Clean Code", out double price);
//Console.WriteLine(price);


//10#########

//11#########


//12


static void PrintAllTitles(params string[] titles)
{
    foreach (string title in titles)
    {
        Console.WriteLine($"Book Title: {title}");
    }
}
PrintAllTitles("Clean Code", "The Pragmatic Programmer", "Design Patterns");