// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


PriceSnapshot priceSnapshot = new PriceSnapshot();
priceSnapshot.StockSymbol = "TCS";
priceSnapshot.StockPrice = 150;

Console.WriteLine($"Stock Symbol : {priceSnapshot.StockSymbol}");
Console.WriteLine($"Stock Price : {priceSnapshot.StockPrice}");

Console.WriteLine();

SimpleTrade trade = new SimpleTrade();
trade.TradeId = 1;
trade.StockSymbol = "CapeGemini";
trade.Quantity = 100;

Console.WriteLine(trade.ToString());

Console.WriteLine();

EquityTrade trade1 = new EquityTrade();
trade1.TradeId = 2;
trade1.StockSymbol = "AAPL";
trade1.Quantity = 10;
trade1.marketPrice = 150;

EquityTrade trade2 = new EquityTrade();
trade2.TradeId = 3;
trade2.StockSymbol = "Google";
trade2.Quantity = 10;
trade2.marketPrice = null;

Console.WriteLine($"Trade Value : {trade1.CalculateTradeValue()}");
Console.WriteLine($"Trade Value : {trade2.CalculateTradeValue()}");

TradeRepository<EquityTrade> repository = new TradeRepository<EquityTrade>();
repository.AddTrade(trade1);
repository.AddTrade(trade2);

Console.WriteLine();

Console.WriteLine("------ Trade Details -------");
repository.ShowTrades();

TradeProcessor processor = new TradeProcessor();
processor.ProcessTrade(trade1);
processor.ProcessTrade(trade2);

Console.WriteLine();

Console.WriteLine("------ Final Calculations -------");

double tradeValue1 = trade1.CalculateTradeValue();
Console.WriteLine($"Trade 1 Value : {tradeValue1}");
Console.WriteLine($"Brokerage : {tradeValue1.Brokerage()}");
Console.WriteLine($"GST : {tradeValue1.CalculateGST()}");

Console.WriteLine();

double tradeValue2 = trade2.CalculateTradeValue();
Console.WriteLine($"Trade 2 Value : {tradeValue2}");
Console.WriteLine($"Brokerage : {tradeValue2.Brokerage()}");
Console.WriteLine($"GST : {tradeValue2.CalculateGST()}");

Console.WriteLine();

TradeAnalytics.DisplayAnalytics();
Console.WriteLine();

// ---------- TASK-8 -------------- //
TradeAnalytics.TotalTrades = 2;

object boxedTradeCount = TradeAnalytics.TotalTrades;

int unboxedTradecount = (int)boxedTradeCount;

Console.WriteLine($"Boxed Trade Count : {boxedTradeCount}");
Console.WriteLine($"Unboxed Trade Count : {unboxedTradecount}");

// -----------TASK-8 ------------- //

