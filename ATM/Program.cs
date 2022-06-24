using System;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
         int code;
            int fact;
            int with;
            int dep;
            int pass = 1234;

            Login:
            Console.WriteLine("Enter a password: ");
            code = Convert.ToInt32(Console.ReadLine());
            if (code == pass)
            {

                Console.WriteLine("The value You entered is :" + code + ", Press enter to continue");
                Console.WriteLine("**************Welcome to ATM Service***************");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Withdraw Cash");
                Console.WriteLine("3. Deposit Cash");
                Console.WriteLine("4. Quite");
                Console.WriteLine("***********************************************************************");
                Console.WriteLine("");
                Console.WriteLine("Enter Your choice:");
               
                fact = Convert.ToInt32(Console.ReadLine());
                switch (fact)
                {

                    case 1:
                        Console.WriteLine("Your Balance is: ");
                        Console.WriteLine("R2500");
                        Console.WriteLine("***********************************************************************");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Enter the amount you wish to withdraw: ");
                        with = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Transaction Complete");
                        Console.WriteLine("***********************************************************************");
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Inset amount you wish to deposit: ");
                        dep = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Transaction Complete");
                        Console.WriteLine("***********************************************************************");
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.Clear();
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Error");
                        Console.WriteLine("Option Not Found");
                        Console.ReadLine();
                        break;
                        
                }
               
            }
            else
            {
                Console.WriteLine("Your password is incorrect");
                goto Login;
            }
        }
    }
}
