namespace Banking_System_Basic
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var canContinue = true;

            var account = new Account()
            {
                Id = "123456789",
                AccountType = AccountType.Local,
                Balance = 0, 
            };  // create thẻ

            

            while ( canContinue ) {
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. History");
                Console.WriteLine("4. Balance ");
                Console.WriteLine("5. Exit ");

                var option =  int.Parse( Console.ReadLine() );

                if (option == 1)
                {
                    var amount = int.Parse(Console.ReadLine());
                    var message = Console.ReadLine();

                    account.Deposit(amount, message);
                    Console.WriteLine("Successful");
                }
                else if (option == 2)
                {
                    var amount = int.Parse(Console.ReadLine());
                    var message = Console.ReadLine();

                    var result = account.WithDraw(amount, message);
                    if (result)
                    {
                        Console.WriteLine("Successful");
                    }
                    else
                    {
                        Console.WriteLine("Fail");
                    }
                }
                else if (option == 3)
                {
                    foreach (var transaction in account.Transactions)
                    {
                        Console.WriteLine($"{transaction.TransactionType} - " +
                            $" {transaction.Amount} - {transaction.Message} " +
                            $"{transaction.ExecutedAt}");

                    }
                }
                else if (option == 4)
                {
                    Console.WriteLine($"current balance : {account.Balance}");
                }
                else { 
                    canContinue = false;
                }
            }


        }

        // Bank Manager
        // User 
        // Account 
        // Transaction 
    }

    public class User 
    { 
        public string UserName { get; set; } // nhập hàng ngày 
        public string HashPassword { get; set; }
        public Gender Gender { get; set; } 

        public List<Account> Accounts { get; set; } 

    }

    public enum AccountType
    { 
        Local,
        International
    }

    public enum Gender
    { 
        Male,
        Female, 
        Other
    }

    // Child -> Parent --> Kế thừa 

    public class Account
    { 
        public string Id { get; set; }  
        public AccountType AccountType { get; set; } 
        public double Balance { get; set;  }

        public List<Transaction> Transactions { get; set; } = new List<Transaction>();

        public void Deposit( int amount , string message )
        {
            this.Balance += amount;

            var transaction = new Transaction()
            {
                TransactionType = TransactionType.Deposit,
                Amount = amount,
                Message = message, 
                ExecutedAt = DateTime.Now,
            }; 
            Transactions.Add( transaction );
        }

        public bool WithDraw (int amount, string message)
        {
            if ( this.Balance < amount ) {    // if tiền ít hơn balance sẽ hk rút được
                return false;
            }

            this.Balance += amount;

            var transaction = new Transaction()
            {
                TransactionType = TransactionType.Deposit,
                Amount = amount,
                Message = message,
                ExecutedAt = DateTime.Now,
            };
            Transactions.Add(transaction);

            return true; 
        }
    }

    public enum TransactionType
    { 
        Deposit, 
        Withdraw
    
    }

    public class Transaction
    { 
        public TransactionType TransactionType { get; set; }    
        public double Amount { get; set; }  

        public string Message { get; set; } 

        public DateTime ExecutedAt { get; set; }

    }


    // Encapsulation 
    // Abstraction 
    

    
}
