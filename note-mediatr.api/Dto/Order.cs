namespace note_mediatr.api.Dto
{
    public class Order : BaseDto
    {
        public required string? CustomerName { get; set; }
        public decimal Amount { get; set; }
        public bool Paid { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
