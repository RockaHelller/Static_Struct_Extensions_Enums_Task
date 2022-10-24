using Service;
using Static__Struct__Extentions__Enums_Homework.Helpers;
using System;
using static Service.Account;

namespace Static__Struct__Extentions__Enums_Homework
{
    class Program
    {

        static void Main(string[] args)
        {

            #region Task1 Login and Roles check
            Account account = new Account();

            account.Login("test@code.edu.az", "test12345", CheckStatus(1)); //all true
            account.Login("test@cowde.edu.az", "test12345", CheckStatus(1)); //wrong email
            account.Login("test@code.edu.az", "test12w345", CheckStatus(1)); //wrong password
            account.Login("test@code.edu.az", "test12345", CheckStatus(2)); //wrong role
            account.Login("test@code.edu.az", "test12345", CheckStatus(3)); //wrong role
            account.Login("tesss@code.edu.az", "test12s345", CheckStatus(4)); //all wrong

            #endregion

            #region Task2 Factorial
            //double a = 4;
            //Console.WriteLine(a.GetFactorial());
            #endregion

        }
        
        
        public static string CheckStatus(int operation)
        {
            switch (operation)
            {
                case (int)Roles.SuperAdmin:
                    return "Super Admindir";
                    break;
                case (int)Roles.Admin:
                    return "Admindir";
                    break;      
                case (int)Roles.Member:
                    return "Memberdir";
                    break;
            }
            return "Not Valid";
        }        
        
        

    }
}
