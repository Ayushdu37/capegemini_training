static class TradeExtenstions
{
    public static double Brokerage(this double tradeValue)
    {
        return tradeValue * 0.01;
    }

    public static double CalculateGST(this double tradeValue)
    {
        return tradeValue * 0.18;
    }
}