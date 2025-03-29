namespace QueueApi.Models
{
    public class QueueTicket
    {
        public int Id { get; set; }
        public string QueueNumber { get; set; } = string.Empty;
        public DateTime IssuedDate { get; set; }
    }

}
