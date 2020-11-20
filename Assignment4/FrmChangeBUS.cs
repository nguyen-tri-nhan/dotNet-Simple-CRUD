using DAO_Ass4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class FrmChangeBUS
    {
        private static FrmChangeBUS instance;

        internal static FrmChangeBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FrmChangeBUS();
                }
                return instance;
            }
        }
        private FrmChangeBUS() { }

        public bool ChangePass(string id, string newpass)
        {
            return EmployeeDAO.Instance.ChangePass(id, newpass);
        }
    }
}
