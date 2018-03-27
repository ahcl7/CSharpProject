using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace libraries.DTL
{
    public class User
    {
        private string username, password;
        private int status;

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public int Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }

        public User(string username, string password, int status)
        {
            this.Username = username;
            this.Password = password;
            this.Status = status;
        }
    }
}
