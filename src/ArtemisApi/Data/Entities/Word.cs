using System.ComponentModel.DataAnnotations;

namespace ArtemisApi.Data.Entities {
    public class Word {
        public int Id { get; set; }
        public string Primary { get; set; }
        public string Secondary { get; set; }
        
        [Required]
        public int? WordSetId { get; set; }
        public WordSet WordSet { get; set; }
    }
}