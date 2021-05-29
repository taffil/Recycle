using System.Linq;

namespace B1Rec
{
    public class UserModel
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string user_type { get; set; }

        public User Login(string email, string password)
        {
            using(var conn = new RecycleEntities())
            {
                var useri = conn.Users.Where(x => x.email == email || x.username == email && x.password == password).FirstOrDefault();

                return useri;
            }
        }
        public User AddUsername(string username)
        {
            using (var conn = new RecycleEntities())
            {
                var usernami = conn.Users.Where(x => x.username == username).FirstOrDefault();

                return usernami;
            }
        }
        public User AddEmail(string email)
        {
            using (var conn = new RecycleEntities())
            {
                var emaili = conn.Users.Where(x => x.email == email).FirstOrDefault();

                return emaili;
            }
        }
    }
}
