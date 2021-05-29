using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Accounts
{
    interface IAccount
    {
        string GetBalanceInfo();
        decimal Balance { get; set; }
    }
}
