using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository {
    public interface ITransactionDetailRepository {
        public TransactionDetail GetTransaction(int id);
        public List<TransactionDetail> GetTransactionDetailsByJobId(int id);
        public TransactionDetail UpdateTransactionDetail(TransactionDetail transactionDetail);
        public void CreateTransactionDetail(TransactionDetail transactionDetail);
        public void DeleteTransactionDetail(int id);
    }
}
