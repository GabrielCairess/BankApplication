using System;

public class Conta
{
    public int Number { get; set; }
    public double Balance { get; private set; }
    public Cliente Titular { get; set; }

    public void Deposit(double valueOperation)
    {
        Balance += valueOperation;
    }

    public virtual void Withdraw(double valueOperation)
    {
        Balance -= valueOperation;
    }
}