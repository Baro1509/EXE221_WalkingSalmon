using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository {
    public interface IReviewRepository {
        public Review GetReviewById(int id);
        public List<Review> GetReviews();
        public void CreateReview(Review review);
        public void UpdateReview(Review review);
        public void DeleteReview(int id);
    }
}
