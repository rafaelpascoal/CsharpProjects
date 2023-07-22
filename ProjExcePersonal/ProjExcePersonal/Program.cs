using Exec_Personal_Ex1.Entities;
using Exec_Personal_Ex1.Entities.Exceptions;
using System.Globalization;
using System;

namespace Exec_Personal_Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Dados da conta; 

                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());

                //Titular da conta; 

                Console.Write("Holder: ");
                string holder = Console.ReadLine();

                //Saldo Inicial; 

                Console.Write("Initial Balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                //Limite de Saque; 

                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                //Instanciando a classe Account; 

                Account acc = new Account(number, holder, balance, withdrawLimit);
                Console.WriteLine();

                //Solicitando o valor do saque; 

                Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                acc.Withdraw(amount);
                Console.WriteLine("New Balance: " + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            //Determinando as exceções; 

            catch (DomainsException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}