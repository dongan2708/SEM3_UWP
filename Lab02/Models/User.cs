using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02.Models
{
    class User
    {
        private string email;
        private string content;


        public User(string email, string content)
        {
            Email = email;
            Content = content;
        }
        public string Email
        {
            get => email;
            set => email = value;
        }

        public string Content
        {
            get => content;
            set => content = value;
        }

    }
}