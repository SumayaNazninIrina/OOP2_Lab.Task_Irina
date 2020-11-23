using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_First_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Savings("irina", "SMI99", 6000,8);
            a1.ShowInfo();
            a1.Deposit(6000);
            a1.Withdraw(700);
            a1.ShowInfo();
            Console.WriteLine();
           
            Account a2 = new Fixed("A", "B1", 200,5,2019);
            a2.ShowInfo();
            a2.Deposit(4000);
            a2.Withdraw(700);
            a2.ShowInfo();
            Console.WriteLine();

            Account a3 = new SpecialSaving("B", "C1", 100, 9);
            a3.ShowInfo();
            a3.Deposit(9000);
            a3.Withdraw(2200);
            a3.ShowInfo();
            Console.WriteLine();
            Account a4 = new OverDraft("C", "D1", 400, 100);
            a4.ShowInfo();
            a4.Transfer(6300, a1);
            a4.ShowInfo();
            

        }
    }
}
