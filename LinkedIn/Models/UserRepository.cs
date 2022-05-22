using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
namespace LinkedIn.Models
{
    public class UserRepository
    {
        
        public static void addUser(User u)
        {
            string connstring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LinkedIn;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(connstring);
            conn.Open();
            string query = $"INSERT INTO Users (email,password ) VALUES('{u.Email}','{u.Password}'); ";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close(); 

        }
        public static List<User> getUsers()
        {
            List<User> users = new List<User>();
            string connstring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LinkedIn;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(connstring);
            conn.Open();
            string query = "Select * from Users";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                User u = new User();
                u.Email = dr.GetString(1);
                u.Password = dr.GetString(2);
                users.Add(u);
            }
            return users;
        }
        public static bool verifyCredentials(User u)
        {
            string connstring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LinkedIn;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(connstring);
            conn.Open();
            string query = $"Select * from [Users] where Email='{u.Email}' AND Password='{u.Password}'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                return true;
                conn.Close();
            }
            else
            {
                return false;
                conn.Close();
            }
        }

    }
}
