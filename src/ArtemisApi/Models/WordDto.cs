namespace ArtemisApi.Models {
    public class WordDto {
        public WordDto (int id, string frontside, string backside, int? wordSetId = null) => (Id, Frontside, Backside, WordSetId) = (id, frontside, backside, wordSetId);
        public int Id { get; }
        public string Frontside { get; }
        public string Backside { get; }
        public int? WordSetId { get; }
    }
}