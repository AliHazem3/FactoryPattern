using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Studing
{
    public class Bank_Factory : IBank_Factory
    {


        public IBank_Product GetBank(string bankcode)
        {
            switch (bankcode)
            {
                case "123456": return new Bank_A();
                case "789456": return new Bank_B();
            }
            return null; 
        }
    }
}
