using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Accounts
{
    class DebitAccount : IAccount
    {
        public decimal Balance { get; set; }

        public string GetBalanceInfo()
        {
            return $"Balance: {Balance}";
        }
    }
}
