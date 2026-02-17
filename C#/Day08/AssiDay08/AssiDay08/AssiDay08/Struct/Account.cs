using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssiDay08.Struct
{
    public struct Account
    {
        private int accountId;
        private string accountHolder;
        private decimal balance;

        public int AccountId
        {
            get { return accountId; }
            set { accountId = value; }
        }
        public string AccountHolder
        {
            get { return accountHolder; }
            set { accountHolder = value; }
        }
        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        override public string ToString()
        {
            return $"Account ID: {accountId}, Account Holder: {accountHolder}, Balance: {balance}";
        }
    }
}
