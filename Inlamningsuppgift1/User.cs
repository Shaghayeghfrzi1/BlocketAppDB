using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlamningsuppgift1
{
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        int userID;
        public User()
        {

        }
        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
        public bool GetUser(ref string registerUser, ref int userNumber )
        {
            string user = Username + "," + Password;
            bool isRegister = false;
            registerUser = ""; 

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=localhost; Initial Catalog=BlocetSearch; Integrated Security=SSPI";
            conn.Open();

            string sqlCode = "select LoginID, Username, Username+','+Password as RegisterUser from Login";

            SqlCommand cmd = new SqlCommand(sqlCode, conn);

            SqlDataReader customer = cmd.ExecuteReader();
            while (customer.Read())
            {
                if ((string)customer["RegisterUser"] == user)
                {
                    //isRegister = true;
                    registerUser = user;
                    userNumber = (int)customer["LoginID"];
                    isRegister = true;
                    break;
                }
               
            }
            customer.Close();
            conn.Close();
            conn.Dispose();

            return isRegister;

        }

        public bool CreateUser(string usernameValue, string passwordValue)
        {
            bool isCreate = false;
            using (SqlConnection conn=new SqlConnection())
            {
                conn.ConnectionString = "Data Source=localhost; Initial Catalog=BlocetSearch; Integrated Security=SSPI";
                conn.Open();

                string sqlCode = "insert into Login (Username,Password) values (@Username, @Password)";
                sqlCode += "Select cast(@@Identity as int)";

                SqlCommand cmd = new SqlCommand(sqlCode, conn);

                cmd.Parameters.AddWithValue("Username", usernameValue);
                cmd.Parameters.AddWithValue("Password", passwordValue);

                //cmd.ExecuteScalar();
                int newID = (int)cmd.ExecuteScalar();
                userID = newID;
                isCreate = true;
            }
            return isCreate;
        }
    }
}
