public class ContaPoupanca : Conta
{
    public override void Withdraw(double valueOperation)
    {
        base.Withdraw(valueOperation + 0.10);
    }
}
