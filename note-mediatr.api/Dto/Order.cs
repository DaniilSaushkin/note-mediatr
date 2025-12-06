namespace note_mediatr.api.Dto
{
    public class Order
    {
        public Guid Id { get; set; }
        public required string? CustomerName { get; set; }
        public decimal Amount { get; set; }
        public bool Paid { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
