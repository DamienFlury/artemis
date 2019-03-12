using System;
using System.Linq;
using ArtemisApi.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ArtemisApi.Data {
    public class ArtemisContext : IdentityDbContext {
        public ArtemisContext (DbContextOptions options) : base (options) { }
        protected override void OnModelCreating (ModelBuilder modelBuilder) {
            base.OnModelCreating (modelBuilder);
            var wordSets = Enumerable.Range (1, 10).Select (index => new WordSet {
                Id = index,
                    Title = $"WordSet #{index}"
            }).ToArray ();
            var random = new Random ();
            var words = Enumerable.Range (1, 100).Select (index => new Word {
                Id = index,
                    Primary = $"Frontside #{index}",
                    Secondary = $"Backside #{index}",
                    WordSetId = random.Next (1, 11)
            }).ToArray ();

            modelBuilder.Entity<WordSet> ().HasData (wordSets);
            modelBuilder.Entity<Word> ().HasData (words);
        }
        public DbSet<Word> Words { get; set; }
        public DbSet<WordSet> WordSets { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }
}