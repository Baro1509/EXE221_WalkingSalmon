using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementation {
    public class ReviewRepository : RepositoryBase<Review>, IReviewRepository {
        public void CreateReview(Review review) {
            review.ReviewStatus = 1;
            Create(review);
        }

        public void DeleteReview(int id) {
            Review db = GetReviewById(id);
            if (db == null) {
                throw new Exception("This review does not exists");
            }
            db.ReviewStatus = 0;
            Update(db);
        }

        public Review GetReviewById(int id) {
            return GetAll().Where(p => p.ReviewId == id && p.ReviewStatus != 0).FirstOrDefault();
        }

        public List<Review> GetReviews() {
            return GetAll().Where(p => p.ReviewStatus != 0).ToList();
        }

        public void UpdateReview(Review review) {
            Review db = GetReviewById(review.ReviewId);
            if (db == null) {
                throw new Exception("This review does not exists");
            }
            db.StudentComment = review.StudentComment;
            db.StudentSatisfaction = review.StudentSatisfaction;
            db.EmployerComment  = review.EmployerComment;
            db.EmployerSatisfaction = review.EmployerSatisfaction;
            Update(db);
        }
    }
}
