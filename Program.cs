using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using static C__Studing.Program;
using System;
using System.Reflection;
using System.Text;
using System.Collections;

namespace C__Studing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cardNumber, bankcode;
            Bank_Factory bank_factory = new Bank_Factory();


            Console.WriteLine("Enter your card Number");
            cardNumber=Console.ReadLine();
            bankcode = cardNumber.Substring(0, 6);
            IBank_Product bank= bank_factory.GetBank(bankcode);
            Console.WriteLine(bank.withdrow());


        }
    }
}












    







 
