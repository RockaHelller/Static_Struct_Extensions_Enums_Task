using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public class Account : IAccount
    {



        public void Login(string email, string password, string role)
        {
            if (email == "test@code.edu.az" && password == "test12345" && role == "Super Admindir")
            {
                Console.WriteLine("Giris ugurludur");
            }
            else if ((email != "test@code.edu.az" || password != "test12345") && role == "Super Admindir")
            {
                Console.WriteLine("Email ve ya Password sehvdir");
            }
            else if ((email == "test@code.edu.az" && password == "test12345") && role != "Super Admindir")
            {
                Console.WriteLine("Giris ucun icazeniz yoxdur");
            }
            else
            {
                Console.WriteLine("Check your credentials or Role and try again please");
            }

        }






        public enum Roles
        {
            SuperAdmin = 1,
            Admin,
            Member
        }



    }
}
