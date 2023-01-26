using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
namespace ПР1
{
    public class GrantSystem 
    {

        private user currentUser;
        private List<user> users = new List<user>();
        private List<Project> projects;
        public int minSum;
        public int groundFount;

        static void Main(string[] args)
        {
            user a1 = new Admin("aaa");
            user c1 = new Clint("ccc");
        }
        public void addUser(string name, string login, string password, string repeation, int tipe)
        {
            users.Add(new user(name, login, password));
        }
        public user findUser(string login, string password)
        {
            return (user)users.Where(u => u.login == login && u.password == password);
        }
        void save()
        {

        }
        void load()
        {

        }
        public void GenerateResult(user user ,string name)
        {
            users.Add(new user(name));
        }
    }
}
