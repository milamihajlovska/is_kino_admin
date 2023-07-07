namespace is_kino_admin.Models
{
    public class TicketInOrder
    {
        public Guid TicketId { get; set; }
        public Ticket OrderedTicket { get; set; }
        public Guid OrderId { get; set; }
        //public Order Order { get; set; }
        public int Quantity { get; set; }
    }
}
