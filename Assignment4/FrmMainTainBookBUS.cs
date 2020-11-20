using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO_Ass4;
namespace Assignment4
{
    class FrmMainTainBookBUS
    {
        private static FrmMainTainBookBUS instance;

        internal static FrmMainTainBookBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FrmMainTainBookBUS();
                }
                return instance;
            }
        }
        private FrmMainTainBookBUS() { }

        public DataTable GetBook()
        {
            return BookDAO.Instance.GetBook();
        }

        public DataTable GetReport()
        {
            return BookDAO.Instance.GetReport();
        }

        public bool AddBook(string name, float price)
        {
            return BookDAO.Instance.AddBook(name, price);
        }

        public bool UpdateBook(string id, string name, float price)
        {
            return BookDAO.Instance.UpdateBook(id, name, price);
        }
        public bool DeleteBook(string id)
        {
            return BookDAO.Instance.DeleteBook(id);
        }
        
    }
}
