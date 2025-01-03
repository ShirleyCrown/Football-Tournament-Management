using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootBall_Tournament_Management.Object
{
    internal class Role
    {
        private int roleID;
        private string roleName;

        public Role(int roleID, string roleName)
        {
            this.RoleID = roleID;
            this.RoleName = roleName;
        }

        public int RoleID { get => roleID; set => roleID = value; }
        public string RoleName { get => roleName; set => roleName = value; }
    }
}
