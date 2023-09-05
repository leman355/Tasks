using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
    }
    public class UserCall
    {
        public List<int> UniqueAges(List<User> users)
        {
            List<int> uniqueAges = users.Select(user => user.Age).Distinct().ToList();
            return uniqueAges;
        }
    }
}