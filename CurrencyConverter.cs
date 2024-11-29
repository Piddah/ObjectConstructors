namespace AssignmenObjectConstructors;

public class CurrencyConverter
{
    public decimal USD { get; private set; }
    public decimal EUR { get; private set; }
    public decimal SEK { get; private set; }

    public CurrencyConverter(decimal usd = 0.095m, decimal eur = 0.085m, decimal sek = 1m)
    {
        USD = usd;
        EUR = eur;
        SEK = sek;
    }

    public decimal EURToUSD(decimal amount) => amount * (USD / EUR);
    public decimal EURToSEK(decimal amount) => amount * (SEK / EUR);
    public decimal USDToEUR(decimal amount) => amount * (EUR / USD);
    public decimal USDToSEK(decimal amount) => amount * (SEK / USD);
    public decimal SEKToEUR(decimal amount) => amount * (EUR / SEK);
    public decimal SEKToUSD(decimal amount) => amount * (USD / SEK);
}
