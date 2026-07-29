// Create a BankAccount class with private decimal balance. Add:

// A constructor that takes an initial balance (must be ≥ 0, else throw ArgumentException)
// Deposit(decimal amount) — rejects negative amounts
// Withdraw(decimal amount) — rejects if amount > balance
// GetBalance() — returns current balance

public class BankAccount
{
    private decimal balance;
    public void initialBalance(decimal initialBalance)
    {
        if (initialBalance <= 0)
        {
            throw new ArgumentException("Initial balance cannot be negative.");
        }
        balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount < 0)
        {
            throw new ArgumentException("Deposit amount cannot be negative.");
        }
        balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount < 0)
        {
            throw new ArgumentException("Withdraw amount cannot be negative.");
        }
        if (amount > balance)
        {
            throw new ArgumentException("Insufficient funds.");
        }
        balance -= amount;
    }

    public decimal GetBalance()
    {
        return balance;
    }
}