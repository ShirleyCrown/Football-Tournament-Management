using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootBall_Tournament_Management.Object
{
    internal class Account
    {
        private string username;
        private string password;
        private int accountRole;

        public Account(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public int AccountRole { get => accountRole; set => accountRole = value; }
    }
}
