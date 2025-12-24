using System;
using System.Collections.Generic;

class TradeRepository<T> where T : Trade
{
    private List<T> trades = new List<T>();

    public static int TradeCount = 0;

    public void AddTrade(T trade)
    {
        trades.Add(trade);
        TradeCount++;
        TradeAnalytics.TotalTrades++;
    }

    public void ShowTrades()
    {
        foreach(T trade in trades)
        {
            Console.WriteLine(trade.ToString());
            Console.WriteLine("Trade Added Successfully");
        }
    }
}