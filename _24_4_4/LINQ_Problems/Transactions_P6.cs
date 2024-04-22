using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace FirstProject._24_4_4.LINQ_Problems
{
    internal class Transactions_P6
    {
        public int Id { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal Amount { get; set; }

        public List<Transactions_P6> GetAllTransactions()
        {

            return new List<Transactions_P6> 
            {
                new Transactions_P6 { Id = 0, TransactionDate = new DateTime(2024, 4, 1), Amount = 100 }, 
                new Transactions_P6 { Id = 1, TransactionDate = DateTime.Parse("2024-4-3"), Amount = 1250 },
                new Transactions_P6 { Id = 2, TransactionDate = DateTime.Parse("2024-4-2"), Amount = 450 },
                new Transactions_P6 { Id = 3, TransactionDate = DateTime.Parse("2024-4-1"), Amount = 500 },
                new Transactions_P6 { Id = 4, TransactionDate = DateTime.Parse("2024-4-2"), Amount = 800 },
                new Transactions_P6 { Id = 5, TransactionDate = DateTime.Parse("2024-4-2"), Amount = 1000 },
                new Transactions_P6 { Id = 6, TransactionDate = DateTime.Parse("2024-4-3"), Amount = 2500 },
            };
        }
    }
}
