using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO_Ass4
{
    public class BookDAO : DBConnect
    {
        private static BookDAO instance;

        public static BookDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BookDAO();
                }
                return instance;
            }
        }
        private BookDAO() { }

        public DataTable GetBook()
        {
            string SQL = "SELECT * FROM Books";
            SqlCommand cmd = new SqlCommand(SQL, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable DataProduct = new DataTable();
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                da.Fill(DataProduct);
            }
            catch (SqlException se)
            {
                throw new Exception(se.Message);
            }
            finally
            {
                conn.Close();
            }
            return DataProduct;
        }
        public bool AddBook(string name, float price)
        {
            string SQL = "INSERT Books VALUES(@BookName, @Price)";
            SqlCommand cmd = new SqlCommand(SQL, conn);
            cmd.Parameters.AddWithValue("@BookName", name);
            cmd.Parameters.AddWithValue("@Price", price);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            int count = cmd.ExecuteNonQuery();
            conn.Close();
            return count > 0;
        }

        public bool UpdateBook(string id, string name, float price)
        {
            string SQL = "UPDATE Books SET BookName = @BookName, BookPrice = @Price" +
                " WHERE BookID = @BookID";
            SqlCommand cmd = new SqlCommand(SQL, conn);
            cmd.Parameters.AddWithValue("@BookName", name);
            cmd.Parameters.AddWithValue("@Price", price);
            cmd.Parameters.AddWithValue("@BookID", id);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            int count = cmd.ExecuteNonQuery();
            conn.Close();
            return count > 0;
        }

        public bool DeleteBook(string id)
        {
            string SQL = "DELETE Books" +
                " WHERE BookID = @BookID";
            SqlCommand cmd = new SqlCommand(SQL, conn);
            cmd.Parameters.AddWithValue("@BookID", id);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            int count = cmd.ExecuteNonQuery();
            conn.Close();
            return count > 0;
        }

        public DataTable GetReport()
        {
            string SQL = "SELECT * FROM Books" +
                " ORDER BY BookID DESC";
            SqlCommand cmd = new SqlCommand(SQL, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable DataProduct = new DataTable();
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                da.Fill(DataProduct);
            }
            catch (SqlException se)
            {
                throw new Exception(se.Message);
            }
            finally
            {
                conn.Close();
            }
            return DataProduct;
        }
    }
}
