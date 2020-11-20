using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_Ass4;

namespace DAO_Ass4
{
    public class EmployeeDAO : DBConnect
    {
        private static EmployeeDAO instance;

        public static EmployeeDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new EmployeeDAO();
                }
                return instance;
            }
        }
        private EmployeeDAO() { }
        public EmployeeDTO CheckLogin(string Id, string Password)
        {
            EmployeeDTO dto = null;
            string SQL = "SELECT EmpID, EmpPassword, EmpRole FROM Employee" +
                " WHERE EmpID = @ID AND EmpPassword = @Password";
            SqlCommand cmd = new SqlCommand(SQL, conn);
            cmd.Parameters.AddWithValue("@ID", Id);
            cmd.Parameters.AddWithValue("@Password", Password);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            try
            {
                foreach (DataRow item in dt.Rows)
                {
                    dto = new EmployeeDTO(item.ItemArray.GetValue(0).ToString(),
                        item.ItemArray.GetValue(1).ToString(),
                        (bool)item.ItemArray.GetValue(2));
                }
            }
            catch
            {
                dto = null;
            }
            conn.Close();
            return dto;
        }

        public bool ChangePass(string id, string newpass)
        {
            string SQL = "UPDATE Employee SET EmpPassword = @EmpPassword, EmpRole = @EmpRole" +
                " WHERE EmpID = @EmpID";
            SqlCommand cmd = new SqlCommand(SQL, conn);
            cmd.Parameters.AddWithValue("@EmpPassword", newpass);
            cmd.Parameters.AddWithValue("@EmpID", id);
            cmd.Parameters.AddWithValue("@EmpRole", true);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            int count = cmd.ExecuteNonQuery();
            conn.Close();
            return count > 0;
        }
    }
}
