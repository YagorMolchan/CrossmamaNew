using CrossmamaNew.DAL.Entities;
using CrossmamaNew.DAL.Entities.Sizes.Abstracts;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossmamaNew.DAL.EF
{
    public class CrossmamaDbContext:IdentityDbContext<User>
    {

        static CrossmamaDbContext()
        {
            Database.SetInitializer<CrossmamaDbContext>(new CrossmamaDbInitializer());
        }

        public CrossmamaDbContext():base("DefaultConnection")
        {

        }

        public static CrossmamaDbContext Create()
        {
            return new CrossmamaDbContext();
        }

        public DbSet<Parent> Parents { get; set; }

        //Lots
        public DbSet<Lot> Lots { get; set; }

        public DbSet<Size> Sizes { get; set; }

        //Nouns
        public DbSet<Noun> Nouns { get; set; }

        //Categories
        public DbSet<Category> Categories { get; set; }

        //Genders
        public DbSet<Gender> Genders { get; set; }

        //Colors
        public DbSet<Color> Colors { get; set; }

        //States
        public DbSet<State> States { get; set; }

        //Sections
        public DbSet<Section> Sections { get; set; }

        //Colors
        public DbSet<Structure> Structures { get; set; }
    }
}
