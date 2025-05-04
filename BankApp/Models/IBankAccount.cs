using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Models
{
    public interface IBankAccount
    {
        string Bank { get; }
        string Name { get; set; }
        string Iban { get; set; }
        decimal Saldo { get; }

        void Withdrawal(decimal amount);
        void Deposit(decimal amount);
    }
}
