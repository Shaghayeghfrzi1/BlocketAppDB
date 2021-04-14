using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlamningsuppgift1
{
    public class Advert
    {
        int infoo = 0;
        public int AdvertID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public String Category { get; set; }
        public DateTime Date { get; set; }
        public int Price { get; set; }
        public int UserID { get; set; }
        public List<object> AllAdverts { get; set; }

        public Advert()
        {
        }
        public Advert(string title, string category)
        {
            Title = title;
            Category = category;
        }
        public Advert(string title)
        {
            Title = title;
        }
       
        public List<object> GetAdverts(string theUser, int sortType)
        {
            int categoryNumber = 0;
            if (Category == "Möbler") categoryNumber = 1;
            if (Category == "Mobiltelefoner") categoryNumber = 2;
            if (Category == "Cyklar") categoryNumber = 3;
            if (Category == "Datorer") categoryNumber = 4;

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=localhost; Initial Catalog=BlocetSearch; Integrated Security=SSPI";
            conn.Open();

            string sqlCode = "select Title from Advert a ";
            if(theUser==" ")
            {
                sqlCode += "where Title LIKE @SearchValue AND CategoryID=@SearchCategory";
            }
            else
            {
                sqlCode += "inner join login l on a.LoginID = l.LoginID where l.Username + ',' + Password = @Logedinser";
            }

            if (sortType == 1)
            {
                sqlCode += " order by Date desc";
            }
            else if (sortType == 2)
            {
                sqlCode += " order by Price";
            }
            else sqlCode += " ";

            SqlCommand cmd = new SqlCommand(sqlCode, conn);
            cmd.Parameters.AddWithValue("@Logedinser", theUser);
            cmd.Parameters.AddWithValue("@SearchValue", "%" + Title + "%");
            cmd.Parameters.AddWithValue("@SearchCategory", categoryNumber);


            SqlDataReader adverts = cmd.ExecuteReader();
            AllAdverts = new List<object>();

            while (adverts.Read())
            {
                AllAdverts.Add((object)adverts["Title"]);
            }
            adverts.Close();
            conn.Close();
            conn.Dispose();

            return AllAdverts;

        }
        public int GetSelectedAdvertID()
        {
            int result = 0;

            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = "Data Source=localhost; Initial Catalog=BlocetSearch; Integrated Security=SSPI";
            conn.Open();
            string sqlCode = "select AdvertID, Title from Advert where title=@SearchValue";


            SqlCommand cmd = new SqlCommand(sqlCode, conn);
            cmd.Parameters.AddWithValue("@SearchValue", Title);


            SqlDataReader adverts = cmd.ExecuteReader();

            while (adverts.Read())
            {
                if ((string)adverts["Title"] == Title)
                {
                    infoo = (int)adverts["AdvertID"];
                }
            }

            result = infoo;

            adverts.Close();
            conn.Close();
            conn.Dispose();

            return result;
        }

        public string GetSelectedAdvertAllInfo(int idNumber)
        {
            string result = "";

            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = "Data Source=localhost; Initial Catalog=BlocetSearch; Integrated Security=SSPI";
            conn.Open();
            string sqlCode = "select AdvertID, Title, Description,date,Price, CategoryID from Advert where AdvertID=@AdvertIdValue";


            SqlCommand cmd = new SqlCommand(sqlCode, conn);
            cmd.Parameters.AddWithValue("@AdvertIdValue", idNumber);

            SqlDataReader adverts = cmd.ExecuteReader();

            while (adverts.Read())
            {
                if ((int)adverts["AdvertID"] == idNumber)
                {
                    result = (string)adverts["Title"] + "*" + (string)adverts["Description"] +
                             "*" + ((DateTime)adverts["Date"]).ToString() + "*" + ((int)adverts["Price"]).ToString() +
                             "*" + ((int)adverts["CategoryID"]).ToString();
                }
            }

            adverts.Close();
            conn.Close();
            conn.Dispose();

            return result;
        }
       

    }

}
