using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnDApi.Models
{
    public class MonsterContext : DbContext
    {
        public MonsterContext(DbContextOptions<MonsterContext> options) : base(options)
        {

        }



        public DbSet<Monster> Monsters { get; set; }

       
}
