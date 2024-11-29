namespace AssignmenObjectConstructors;

public class Money
{
    public decimal Amount { get; private set; }
    public Currency Currency { get; private set; }


    public Money(decimal amount, Currency currency)
    {
        Amount = amount;
        Currency = currency;
    }

    public Money ConvertMoney(Currency convertTo, CurrencyConverter converter)
    {
        decimal convertedAmount = (Currency, convertTo) switch
        {
            (Currency.EUR, Currency.USD) => converter.EURToUSD(Amount),
            (Currency.EUR, Currency.SEK) => converter.EURToSEK(Amount),
            (Currency.USD, Currency.EUR) => converter.USDToEUR(Amount),
            (Currency.USD, Currency.SEK) => converter.USDToSEK(Amount),
            (Currency.SEK, Currency.EUR) => converter.SEKToEUR(Amount),
            (Currency.SEK, Currency.USD) => converter.SEKToUSD(Amount),
            _ => throw new ArgumentException("Unsupported currency conversion.")
        };

        return new Money(convertedAmount, convertTo);
    }
}
