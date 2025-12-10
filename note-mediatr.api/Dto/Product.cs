namespace note_mediatr.api.Dto
{
    public class Product : BaseDto
    {
        public required string? Name { get; set; }
        public decimal Price { get; set; }
        public bool IsArchived { get; set; }
        public int Version { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
