using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exec_Personal_Ex1.Entities.Exceptions;

namespace Exec_Personal_Ex1.Entities
{
    internal class Account
    {
        //Nomear os atributos e determinar as variáveis; 
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        //Construtor genérico; 
        public Account() { }

        //Construtor Account; 
        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        //Método depósito (Nesse exercício, não utilizaremos o depósito, pois o foco é o exercício de exceções de saque); 
        public void Deposit(double amount)
        {
            Balance += amount;
        }

        //Método Saque; 
        public void Withdraw(double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new DomainsException("Withdraw error: The amount exceeds withdraw limit.");
            }
            if (Balance < amount)
            {
                throw new DomainsException("Value error: The amount exceeds balance.");
            }
            Balance -= amount;
        }
    }

}