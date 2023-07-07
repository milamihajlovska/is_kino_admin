namespace is_kino_admin.Models
{
    public class Ticket
    {
        public Guid Id { get; set; }

        public int SeatNum { get; set; }
        public DateTime Date { get; set; }
        public Guid MovieId { get; set; }

        public  Movie? Movie { get; set; }

        public int Price { get; set; }

       

    }
}
