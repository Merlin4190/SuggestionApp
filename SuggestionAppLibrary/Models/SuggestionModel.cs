namespace SuggestionAppLibrary.Models
{
    public class SuggestionModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Suggestion { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;
        public Category Category { get; set; }
        public BasicUserModel Author { get; set; }
        public HashSet<string> UserVotes { get; set; } = new();
        public Status SuggestionStatus { get; set; }
        public string OwnerNotes { get; set; }
        public bool ApproveForRelease { get; set; } = false;
        public bool Archived { get; set; } = false;
        public bool Rejected { get; set; } = false;
    }
}
