using BankApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public class KbcAccount : IBankAccount
    {
        public KbcAccount(string name, string iban)
        {
            this.Iban = iban;
            this.Name = name;
            this.Saldo = 100M;
        }

        public string Bank => "KBC";

        public string Name { get; set; }

        public string Iban { get; set; }

        public decimal Saldo { get; private set; }

        public void Deposit(decimal amount)
        {
            this.Saldo += amount;
        }

        public void Withdrawal(decimal amount)
        {
            this.Saldo -= amount;
            this.Saldo -= (0.01M * amount);
        }
    }
}
