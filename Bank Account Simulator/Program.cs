using Bank_Account_Simulator;

namespace Bank_Account_Simulator

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Welcome to the bank simulation app");

            Console.WriteLine("Please enter your full name to get started");
            string accountName = Console.ReadLine();

            Random rand = new Random();
            int accountNumber = rand.Next(1000, 9999);

            Console.WriteLine($"Welcome {accountName}, your account number is: {accountNumber}");

            BankAccount bankAccount = new BankAccount(accountNumber, accountName,0);


            while (true)
            {
                Console.WriteLine($"your current account balance is {bankAccount.GetBalance()}");
                Console.WriteLine($"Press 1 to get your account balance");
                Console.WriteLine($"Press 2 to deposit");
                Console.WriteLine($"Press 3 to withdraw");
                Console.WriteLine($"Press 4 to get your transactions history");
                Console.WriteLine($"Press 5 to Exit");



                int transactionChoice = int.Parse(Console.ReadLine());


                switch (transactionChoice)
                {
                    case 1:
                        Console.WriteLine($"Your current account balance is: {bankAccount.GetBalance()}");
                        break;

                    case 2:
                        Console.WriteLine($"Please enter the amount you would like to deposit here:");
                        decimal depositAmount = decimal.Parse(Console.ReadLine());
                        bankAccount.Deposit(depositAmount);
                        break;

                    case 3:
                        Console.WriteLine($"Please enter the amount you would like to withdraw");
                        decimal withdrawAmount = decimal.Parse(Console.ReadLine());
                        bankAccount.Withdraw(withdrawAmount);
                        break;
                    case 4:
                        Console.WriteLine($"Your transactions history is: ");
                        bankAccount.GetTransactionHistory();
                        break;
                    case 5:
                        Console.WriteLine("Thank you for banking with us");
                        break;
                    default:
                        Console.WriteLine("wrong choice please try again");
                        break;
                }
            }
                
            
        }
    }
}
