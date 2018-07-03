using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoCSharp.Model.Pojo;

namespace TrabalhoCSharp.Model.Repostiory
{
    class DatabaseContext
        : DbContext
    {

        public DatabaseContext() : base("gamesConnectionString")
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Game> Games { get; set; }
    }
}
