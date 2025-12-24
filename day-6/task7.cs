class TradeProcessor
{
    public void ProcessTrade(Trade trade)
    {
        if(trade is EquityTrade equityTrade)
        {
            Console.WriteLine("Calculating Equity Trade");
            Console.WriteLine($"Trade Value : {equityTrade.CalculateTradeValue()}");
        }
        else
        {
            Console.WriteLine("Unknown Trade Type");
        }
    }
}