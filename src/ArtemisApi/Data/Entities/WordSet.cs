using System.Collections.Generic;

namespace ArtemisApi.Data.Entities {
    public class WordSet {
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<Word> Words { get; set; }
    }
}