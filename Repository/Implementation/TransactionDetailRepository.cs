using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementation {
    public class TransactionDetailRepository : RepositoryBase<TransactionDetail>, ITransactionDetailRepository {
        public void CreateTransactionDetail(TransactionDetail transactionDetail) {
            Create(transactionDetail);
        }

        public void DeleteTransactionDetail(int id) {
            var trans = GetTransaction(id);
            if (trans == null) {
                return;
            }
            trans.TransStatus = 0;
            UpdateTransactionDetail(trans);
        }

        public TransactionDetail GetTransaction(int id) {
            return GetAll().Where(p => p.TransactionId == id && p.TransStatus != 0).FirstOrDefault();
        }

        public List<TransactionDetail> GetTransactionDetailsByJobId(int id) {
            return GetAll().Where(p => p.JobId == id && p.TransStatus != 0).ToList();
        }

        public TransactionDetail UpdateTransactionDetail(TransactionDetail transactionDetail) {
            var trans = GetTransaction(transactionDetail.TransactionId);
            if (trans == null) {
                throw new InvalidOperationException();
            }
            trans.TransactionCode = transactionDetail.TransactionCode;
            trans.Purpose = transactionDetail.Purpose;
            trans.CreatedDate = transactionDetail.CreatedDate;
            trans.TransStatus = transactionDetail.TransStatus;
            Update(trans);
            return GetTransaction(trans.TransactionId);
        }
    }
}
