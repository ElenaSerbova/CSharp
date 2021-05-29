using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Accounts
{
    class ForeginAccount : IAccount
    {
        decimal balance;
        decimal kurs = 27.7m;

        public decimal Balance {
            get
            {
                return balance * kurs;
            }
            set
            {
                balance = value * kurs;
            }
        }

        public string GetBalanceInfo()
        {
            throw new NotImplementedException();
        }
    }
}
