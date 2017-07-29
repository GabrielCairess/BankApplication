public class TotalizadorContas
{
    private double totalValue;
    public double TotalValue { get; set; }

    public void Soma(Conta account)
    {
        TotalValue += account.Balance;
    }
}