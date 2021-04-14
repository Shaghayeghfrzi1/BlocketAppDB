using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Inlamningsuppgift1
{
    public class AdvertCRUD
    {
        int advertID;
        public int AdvertID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public String Category { get; set; }
        public DateTime Date { get; set; }
        public int Price { get; set; }
        public int UserID { get; set; }
        public List<Advert> AllAdverts { get; set; }

        public AdvertCRUD(string title, string description, DateTime date, int price, int advertID)
        {
            Title = title;
            Description = description;
            Date = date;
            Price = price;
            AdvertID = advertID;
        }
        public AdvertCRUD(string title, string category, string description, DateTime date, int price, int userId)
        {
            Title = title;
            Category = category;
            Description = description;
            Date = date;
            Price = price;
            UserID = userId;
        }
        public AdvertCRUD(int advertId)
        {
            AdvertID = advertId;
        }
        public bool UpdateAdvert()
        {
            bool isUpdated = false;

            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = "Data Source=localhost; Initial Catalog=BlocetSearch; Integrated Security=SSPI";
                conn.Open();

                string sqlCode = "update advert set Title= @advertValue, Description= @DescriptionValue, Date= @DateValue, Price= @PriceValue" +
                    " where AdvertID=@SelectedAdvertID";

                SqlCommand cmd = new SqlCommand(sqlCode, conn);

                cmd.Parameters.AddWithValue("@advertValue", Title);
                cmd.Parameters.AddWithValue("@DescriptionValue", Description);
                cmd.Parameters.AddWithValue("@DateValue", Date);
                cmd.Parameters.AddWithValue("@PriceValue", Price);
                cmd.Parameters.AddWithValue("@SelectedAdvertID", AdvertID);

                cmd.ExecuteNonQuery();

                isUpdated = true;
            }
            return isUpdated;
        }

        public bool SaveAdvert()
        {
            bool isSave = false;
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = "Data Source=localhost; Initial Catalog=BlocetSearch; Integrated Security=SSPI";
                conn.Open();

                string sqlCode = "insert into Advert (Title,Description,Date, Price,CategoryID, LoginID) " +
                    "values (@TitleValue, @DescriptionValue, @DateValue, @PriceValue, @CategoryIDValue , @LoginIDValue)";
                sqlCode += "Select cast(@@Identity as int)";

                SqlCommand cmd = new SqlCommand(sqlCode, conn);

                cmd.Parameters.AddWithValue("@TitleValue", Title);
                cmd.Parameters.AddWithValue("@DescriptionValue", Description);
                cmd.Parameters.AddWithValue("@DateValue", Date);
                cmd.Parameters.AddWithValue("@PriceValue", Price);
                cmd.Parameters.AddWithValue("@CategoryIDValue", Category);
                cmd.Parameters.AddWithValue("@LoginIDValue", UserID);

                int newAdvertID = (int)cmd.ExecuteScalar();
                advertID = newAdvertID;

                isSave = true;
            }
            return isSave;
        }

        public bool DeleteAdvert()
        {
            bool isDelete = false;

            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = "Data Source=localhost; Initial Catalog=BlocetSearch; Integrated Security=SSPI";
                conn.Open();

                string sqlCode = "DELETE from Advert WHERE AdvertID= @advertValueID";

                SqlCommand cmd = new SqlCommand(sqlCode, conn);

                cmd.Parameters.AddWithValue("@advertValueID", AdvertID);

                cmd.ExecuteNonQuery();


                isDelete = true;
            }

            return isDelete;
        }


    }
}
