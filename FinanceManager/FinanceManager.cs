using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceManager
{
    public class FinanceManager
    {
        private List<Transaction> transactions = new List<Transaction>();

        public void AddTransaction(string descricao, decimal valor, DateTime? data)
        {
            var transaction = new Transaction(descricao, valor, data);

            transactions.Add(transaction);

        }
        public void ListTransactions()
        {
            foreach (var transaction in transactions)

            {

                Console.WriteLine($"Descrição: {transaction.Descricao}, Valor: {transaction.Valor}, Data: {transaction.Data}");

            }

        }
    }
}