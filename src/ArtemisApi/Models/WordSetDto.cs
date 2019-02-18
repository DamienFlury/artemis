using System.Collections.Generic;

namespace ArtemisApi.Models {
    public class WordSetDto {
        public WordSetDto (int id, string title, IEnumerable<WordDto> words = null) => (Id, Title, Words) = (id, title, words);

        public int Id { get; }
        public string Title { get; }
        public IEnumerable<WordDto> Words { get; }
    }
}