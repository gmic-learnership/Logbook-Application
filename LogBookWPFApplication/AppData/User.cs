using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogBookWPFApplication.AppData
{
    class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Surname { get; set; }
        public int RoleID { get; set; }



        public User(int id, string name, string surname, string email, string password, int role)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Email = email;
            Password = password;
            RoleID = role;
          

        }
    }
}
