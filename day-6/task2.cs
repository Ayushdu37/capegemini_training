public abstract class Trade
{
    public int TradeId{get; set;}
    public string StockSymbol{get; set;}
    public int Quantity{get; set;}
    public abstract double CalculateTradeValue();

    public override string ToString()
    {
        return "TradeId : " + TradeId +
        "\nSymbol : " + StockSymbol + 
        "\nQuantity : " + Quantity;
    }

}

public class SimpleTrade : Trade
{
    public override double CalculateTradeValue()
    {
        return 0; 
    }
}