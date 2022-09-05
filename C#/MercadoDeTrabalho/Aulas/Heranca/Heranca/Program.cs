using System;
using Heranca.Entities;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            // UPCASTING E DOWNCASTING
            /*Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bcc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            // UPCASTING
            Account acc1 = bcc;
            Account acc2 = new BusinessAccount(103, "Bob", 0.0, 200.00);
            Account acc3 = new SavingsAccount(104, "Anna", 0.0, 0.01);

            // DOWNCASTING

            BusinessAccount bcc1 = (BusinessAccount)acc2;
            bcc1.Loan(100.00);

            //BusinessAccount bcc2 = (BusinessAccount)acc3; // quando for compilar irá dar erro, pois p BusinessAccount não é compativel com SavingsAccount

            if(acc3 is BusinessAccount)
            {
                BusinessAccount bcc3 = (BusinessAccount)acc3;
                //outra forma de fazer
                //BusinessAccount bcc3 = acc3 as BusinessAccount;
                bcc3.Loan(200.0);
                Console.WriteLine("Loan");
            }

            if (acc3 is SavingsAccount)
            {
                SavingsAccount scc1 = (SavingsAccount)acc3;
                scc1.UpdateBalance();
                Console.WriteLine("UpdateBalance");
            }*/

            //SOBREPOSICAO

            Account acc1 = new Account(1001, "Alex", 500.0);
            Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);

        }
    }
}
