namespace is_kino_admin.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        public IEnumerable<TicketInOrder> TicketInOrders { get; set; }
    }
}
