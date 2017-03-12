using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FormsWithHttpPost.Models;
using System.Data.SqlClient;

namespace FormsWithHttpPost.DAL
{
    public class ReviewSqlDAL : IReviewDAL
    {
        string connectionString = @"Data Source=DESKTOP-ICT08NO\SQLEXPRESS;Initial Catalog=BookReview;Integrated Security=True";
        string SQL_GetAllReviews = @"Select username, rating, title, message, review_date, id from review;";
        string SQL_SaveReview = @"Insert into review (username, rating, title, message, review_date) values (@username, @rating, @title, @message, GETDATE())";

        public List<Review> GetAllReviews()
        {
            List<Review> result = new List<Review>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(SQL_GetAllReviews, conn);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Review r = new Review();
                        r.Id = Convert.ToInt32(reader["id"]);
                        r.Username = Convert.ToString(reader["username"]);
                        r.Rating = Convert.ToInt32(reader["rating"]);
                        r.Title = Convert.ToString(reader["title"]);
                        r.Message = Convert.ToString(reader["message"]);
                        r.ReviewDate = Convert.ToDateTime(reader["review_date"]);

                        result.Add(r);
                    }

                }
            }
            catch (SqlException ex)
            {
                throw new NotImplementedException();
            }

            return result;
        }

        public bool SaveReview(Review newReview)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(SQL_SaveReview, conn);

                    cmd.Parameters.AddWithValue("@username", newReview.Username);
                    cmd.Parameters.AddWithValue("@rating", newReview.Rating);
                    cmd.Parameters.AddWithValue("@title", newReview.Title);
                    cmd.Parameters.AddWithValue("@message", newReview.Message);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return (rowsAffected == 1);
                }
            }
            catch (SqlException ex)
            {
                throw new NotImplementedException();
            }
        }
    }
}