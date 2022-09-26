namespace Banking.Models;

public class Account {

    public int AccountNo { get; set; }
    public string Description { get; set; } = string.Empty;
    public decimal Balance { get; set; }

    public void Deposit(decimal Amount) {
        if (Amount <= 0) {
            throw new ArgumentOutOfRangeException("Amount must be GT Zero");
        }
        Balance += Amount;
    }
    public void Withdraw(decimal Amount) {
        if (Amount <= 0) {
            throw new ArgumentOutOfRangeException("Amount must be > Zero");
        }
        if (Amount > Balance) {
            throw new ArgumentOutOfRangeException("Amount must be <= Balance");
        }
        Balance -= Amount;
    }
    public void Transfer(decimal Amount, Account ToAccount) {
        try {
            Withdraw(Amount);
        } catch (ArgumentOutOfRangeException) {
            throw;
        }
        try {
            ToAccount.Deposit(Amount);
        } catch (ArgumentOutOfRangeException) {
            Deposit(Amount);
            throw;
        }
    }


}
