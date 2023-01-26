using System;
namespace ПР1
{
    public class user
    {
         public string name;
         public string login;
         public string password;

        //public string _name;
        //public string _login;
        //public string _password;
        public user(string name, string login, string password)
        {
            this.name = name;
            this.login = login;
            this.password = password;
        }
        public user(string name)
        {
            this.name = name;
        }
        public void print()
        {
            //Console.WriteLine($"name: {_name} login: {_login} password: {_password}");
        }
        public void enter()
        {

        }
        public void Read()
        {
            //_name = Convert.ToString(Console.ReadLine());
            //_login = Convert.ToString(Console.ReadLine());
            //_password = Convert.ToString(Console.ReadLine());
        }
        

    }

}
