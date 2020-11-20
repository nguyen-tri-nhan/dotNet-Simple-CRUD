using DAO_Ass4;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Ass4;
using System.Windows.Forms;

namespace Assignment4
{
    public class FrmLoginBUS
    {
        private static FrmLoginBUS instance;

        internal static FrmLoginBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FrmLoginBUS();
                }
                return instance;
            }
        }
        private FrmLoginBUS() { }

        private EmployeeDTO forwarding;
        public EmployeeDTO Forwarding { get => forwarding; set => forwarding = value; }
        public EmployeeDTO CheckLogin(string ID, string Password)
        {
            EmployeeDTO dto = EmployeeDAO.Instance.CheckLogin(ID, Password);
            if (dto != null && dto.Role == false) Forwarding = dto;
            return dto;
        }

        
    }
}
