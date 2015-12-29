using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Threading.Tasks;
using Data;
using Data.Models;

namespace Business
{
    public class UserManager : ManagerBase
    {
        public UserManager(DataContext dataContext)
            : base(dataContext)
        {
        }

        public User[] GetUsers()
        {
            return this.DataContext.Users.ToArray();
        }

        public User GetUser(int id)
        {
            User user = this.DataContext.Users.SingleOrDefault(u => u.ID == id);
            this.DataContext.Users.First(u => u.ID == id);
            return user;
        }
    }
}
