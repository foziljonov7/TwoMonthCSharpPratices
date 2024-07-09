namespace OneWeek.ClassAndObject;

//Encapsution
public class BankAccount
{
    private double balance; 

    public double Balance
    {
        get { return balance; }
        private set { balance = value; }
    }

    public BankAccount(double initialBalance)
    {
        balance = initialBalance;
    }

    public void Deposit(double amount)
    {
        if(amount > 0)
        {
            Balance += amount;
        }
    }
    
    public void Withdraw(double amount)
    {
        if(amount > 0 && amount <= Balance)
        {
            Balance -= amount;
        }
    }
}