using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceManager
{
    public class Transaction
    {
        public Transaction(string descricao, decimal valor, DateTime? data)
        {
            Descricao = descricao;
            Valor = valor;
            Data = data;
        }

       public  string Descricao {  get; set; }
        public decimal Valor {  get; set; }
        public DateTime? Data { get; set; }

    }
}
