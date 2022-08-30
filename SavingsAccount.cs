public class SavingAccount : BankAccount
{
    // we need to create a constructor 
    public SavingAccount() : base()
    {
        Balance = 200;
    }

    // we accept a decimal ampunt and we send it to the base class. for line 9
    public SavingAccount(decimal amount) : base(amount)
    {

    }
}