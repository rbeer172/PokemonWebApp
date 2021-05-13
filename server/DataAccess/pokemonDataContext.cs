using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace server.DataAccess
{
    public class pokemonDataContext : DbContext
    {
        public pokemonDataContext(DbContextOptions<pokemonDataContext> opts) : base(opts) { }
    }
}
