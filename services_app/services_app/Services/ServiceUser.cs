using Microsoft.EntityFrameworkCore;
using services_app.Models;

namespace services_app.Services
{
    public interface IServiceUser
    {
        public UserContext? Db { get; set; }
        IEnumerable<User> Read();
        User Create(User user);
        User Update(User user);
        void Delete(int id);
        User? GetUserById(int id);
        User? GetUserByName(string name);
    }
    public class ServiceUser : IServiceUser
    {
        public UserContext? Db { get; set; }

        public User Create(User user)
        {
            Db?.Users.Add(user);
            Db.SaveChanges();
            return user;
        }

        public void Delete(int id)
        {
            var user = GetUserById(id);
            if (user != null)
            {
                Db?.Users.Remove(user);
                Db.SaveChanges();
            }
        }

        public User? GetUserById(int id)
        {
            return Db?.Users.Find(id);
        }

        public User? GetUserByName(string name)
        {
            return Db?.Users.FirstOrDefault(u => u.FirstName == name);
        }

        public IEnumerable<User> Read()
        {
            return Db?.Users.ToList() ?? Enumerable.Empty<User>();
        }

        public User Update(User user)
        {
            if (Db != null)
            {
                Db.Entry(user).State = EntityState.Modified;
                Db.SaveChanges();
            }
            return user;
        }
    }
}
