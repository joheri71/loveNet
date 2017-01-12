using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using loveNet.Models;

namespace loveNet
{
    //Denna klass "befolkar" databasen.
    public static class DbPopulator
    {
        public static void Populate()
        {
            using (var context = new Context())
            {
                context.DbSetUsers.Add(new User()
                {
                    FirstName = "Helge",
                    LastName = "Hagel",
                    Age = 45
                });

                context.DbSetUsers.Add(new User()
                {
                    FirstName = "Eva",
                    LastName = "Ek",
                    Age = 27
                });

                context.DbSetUsers.Add(new User()
                {
                    FirstName = "Jonna",
                    LastName = "Hansson",
                    Age = 22
                });

                context.DbSetUsers.Add(new User()
                {
                    FirstName = "Sten",
                    LastName = "Larsson",
                    Age = 30
                });

                context.DbSetUsers.Add(new User()
                {
                    FirstName = "Fanny",
                    LastName = "Finlund",
                    Age = 22
                });

                context.DbSetUsers.Add(new User()
                {
                    FirstName = "Evert",
                    LastName = "Gam",
                    Age = 70
                });

                context.DbSetUsers.Add(new User()
                {
                    FirstName = "Ronny",
                    LastName = "Schnabb",
                    Age = 20
                });

                context.DbSetUsers.Add(new User()
                {
                    FirstName = "Donald",
                    LastName = "Trump",
                    Age = 70
                });

                context.DbSetUsers.Add(new User()
                {
                    FirstName = "Hillary",
                    LastName = "Clinton",
                    Age = 69
                });

                context.DbSetUsers.Add(new User()
                {
                    FirstName = "Gudrun",
                    LastName = "Goding",
                    Age = 50
                });


                context.SaveChanges();
            }
        }
    }
}