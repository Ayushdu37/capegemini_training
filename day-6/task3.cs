public class EquityTrade : Trade
{
    public double? marketPrice{get; set;} // nullable property

    public override double CalculateTradeValue()
    {
        return Quantity * (marketPrice ?? 0);
    }
}