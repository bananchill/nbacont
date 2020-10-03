using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nbacont
{
    class DbController
    {
        public static Player ActiveUser;
        public static NbacontEntities db { get; set; }
        static DbController()
        {
            db = new NbacontEntities();
        }
        public static Admin Activeus(string login, string password)
        {
            db.Admin.Load();
            List<Admin> users = db.Admin.Local.ToList();
            foreach (var user in users)
            {
                if (user.Phone == login && user.Password == password)
                {
                    return user;
                }
            }
            return null;

        }
        ////////////////
        public string auto(string login, string password)
        {
            var query = from Admin in db.Admin
                        join role in db.Role on Admin.Role_Role equals role.Role1
                        where Admin.Phone == login && Admin.Password == password && Admin.Role_Role == role.Role1
                        select role.Name;
            foreach (string usser in query)
            {
                switch (usser)
                {
                    case "Event Administrator":
                        return "Event Administrator";
                    case "Technical Administrator":
                        return "Technical Administrator";
                }
            }
            return "Exception";
        }
        ////////////////
        internal static List<MatchUp> match()
        {
            db.MatchUp.Load();
            List<MatchUp> match = db.MatchUp.Local.ToList();
            return match.Where(u => u.Season == u.Season).ToList();

        }

        ////
        public static List<MatchUp> MatchUppp()
        {
            db.MatchUp.Load();
            List<MatchUp> material = db.MatchUp.Local.ToList();
            return material.Where(o => o.idMatchUp == o.idMatchUp).ToList();
        }
        
        
    }
}

