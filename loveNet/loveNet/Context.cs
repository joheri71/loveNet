using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using loveNet.Models;

namespace loveNet
{
    //Kommunikationen mellan applikationen och databasen går genom
    //Contextklassen. 
    //Det måste finnas en dbSet property för varje entitet som man 
    //behöver skriva querys till.
    public class Context : DbContext
    {
        public DbSet<User> DbSetUsers { get; set; }
    }
}