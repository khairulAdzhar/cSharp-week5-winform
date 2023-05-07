using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace week9
{
    internal class Account
    {
        private string _FName;
        private string _LName;
        private decimal _Balance;
        private decimal _Deposit;

        //constructor
        public Account() { }

        public Account(decimal balance,decimal deposit)
        {
            _Deposit = deposit;
            _Balance = balance + _Deposit;
        }
        public decimal getBalance()
        {
            return _Balance;
        }

        public string FirstName
        {
            get { return _FName; }
            set { _FName = value; }
        }
        public string LastName
        {
            get { return _LName; }
            set { _LName = value; }
        }
        public decimal BBalance { get; set; } = 5000.00m;

        public decimal Deposit
        {
            get => _Deposit;

            private set
            {
                if(value > 0)
                {
                    _Deposit = value;
                }
            }
        }
    }








}
