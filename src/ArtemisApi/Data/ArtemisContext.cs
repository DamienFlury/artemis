using Microsoft.EntityFrameworkCore;
using ArtemisApi.Data.Entities;
using System.Linq;
using System;

namespace ArtemisApi.Data {
    public class ArtemisContext: DbContext {
        public ArtemisContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            var wordSets = Enumerable.Range(1, 10).Select(index => new WordSet{
                Id = index,
                Title = $"WordSet #{index}"
            }).ToArray();
            var random = new Random();
            var words = Enumerable.Range(1, 100).Select(index => new Word {
                Id = index,
                Primary = $"Frontside #{index}",
                Secondary = $"Backside #{index}",
                WordSetId = random.Next(1, 11)
            }).ToArray();

            modelBuilder.Entity<WordSet>().HasData(wordSets);
            modelBuilder.Entity<Word>().HasData(words);
        }
        public DbSet<Word> Words { get; set; }
        public DbSet<WordSet> WordSets { get; set; }
    }
}