Console.WriteLine("Hello, World!");
#region 01
double[] price = new double[3];

price[0] = 25.5;
price[1] = 40.0;
price[2] = 33.75;
{
    Console.WriteLine(price[1]);
}
#endregion
#region 02
double[] price = new double[3];

price[0] = 25.5;
price[1] = 40.0;
price[2] = 33.75;
{
    Console.WriteLine(price[1]);
}
#endregion
#region 03
static void PrintWelcomeMessage()
{
    Console.WriteLine("Welcome to the program!");
}
{
    PrintWelcomeMessage();
}
#endregion
#region 04
//static void PrintBookTitle(string title = "clean code")
//{
//    Console.WriteLine("Book Title: " + title);
//}
//PrintBookTitle();

#endregion
#region 05
//static void AddBonusPages(int pages)
//{
//    pages = pages + 50;
//    Console.WriteLine("Inside method: " + pages);
//}
//int pages = 400;
//AddBonusPages(pages);
//Console.WriteLine("Outside method: " + pages);

#endregion
#region 06
//static void ApplyDiscount(double[] prices)
//{
//    prices[0] -= 5;
//}
//double[] prices = { 25.5, 40.0 };
//ApplyDiscount(prices);
//Console.WriteLine(prices[0]);
#endregion
#region 07
//static void AddBonusPages(ref int pages)
//{
//    pages = pages + 50;
//    Console.WriteLine("Inside method: " + pages);
//}
//int pages = 400;
//AddBonusPages(ref pages);
//Console.WriteLine("Outside method: " + pages);

#endregion