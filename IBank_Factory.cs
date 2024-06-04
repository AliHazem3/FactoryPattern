using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Studing
{
    public interface IBank_Factory
    {
        IBank_Product GetBank(string bankcode);
    }
}
