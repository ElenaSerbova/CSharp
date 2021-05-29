using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Accounts
{
    class CreditAccount : IAccount
    {
        public decimal CreditLimit { get; set; }
        public decimal UsingCreditMoney { get; set; }
        public decimal PersonalMoney { get; set; }


        public decimal Balance { 
            get
            {
                return PersonalMoney - UsingCreditMoney;
            }
            set
            {
                if (UsingCreditMoney > 0)
                    UsingCreditMoney -= value;
                else
                    PersonalMoney += value;
            }
        }

        public string GetBalanceInfo()
        {
            return $"Credit: {UsingCreditMoney}, Money: {PersonalMoney}";
        }
    }

}
