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
#region 08
//static void ReplaceArray(ref double[] prices)
//{
//    prices = new double[] { 10.0, 12.5, 15.0 };
//}
//double[] pricesArray = { 25.5, 40.0 };
//ReplaceArray(ref pricesArray);
//Console.WriteLine(pricesArray.Length);
#endregion
#region 09
//static bool TryGetPrice(string title, out double price)
//{
//    if (title == "Clean Code")
//    {
//        price = 25.5;
//        return true;
//    }
//    else
//    {
//        price = 0;
//        return false;
//    }
//}
//if (TryGetPrice("Clean Code", out double bookPrice))
//{
//    Console.WriteLine("Price: " + bookPrice);
//}
#endregion
#region 10
//static void PrintBookInfo(string title, int pages = 300)
//{
//    Console.WriteLine($"title: {title}, Pages: {pages}");
//}
//PrintBookInfo("Clean Code");
//PrintBookInfo("clean code", 450);
#endregion
#region 11
//static void PrintBookInfo(int pages, string title)
//{
//    Console.WriteLine($"title: {title}, Pages: {pages}");
//}
//PrintBookInfo(pages: 500, title: "Clean Code");
//#endregion