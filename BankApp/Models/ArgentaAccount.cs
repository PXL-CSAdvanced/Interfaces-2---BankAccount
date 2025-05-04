using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Models
{
    public class ArgentaAccount : IBankAccount
    {
        public ArgentaAccount(string name, string iban)
        {
            this.Iban = iban;
            this.Name = name;
            this.Saldo = 50M;
        }

        public string Bank => "Argenta";

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
        }
    }
}
