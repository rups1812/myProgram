using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram.Exception_handling
{

    class InvalidPasswordException:ApplicationException
    {
        public InvalidPasswordException()
        {

        }
        public InvalidPasswordException(string msg):base(msg)
        {

        }
    }
    class Studd
    {
        string username;
        string password;


        public string Username
        {
            set {
                if (value.Length <= 5)
                    throw new ApplicationException("Password length greater than 5");
                else
                this.username = value; }
            get { return username; }
        }
        public string Password
        {
            set { this.password = value; }
            get { return password; }
        }

        static void Main(string[] args)
        {
            Studd s1 = new Studd();
            s1.Username = "Rupesh";

            try
            {
                s1.Password = "pqrs";
            }
            catch(InvalidPasswordException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Main ends");
        }
    }
}
