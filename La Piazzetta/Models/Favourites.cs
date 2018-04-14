namespace La_Piazzetta.Models
{
    public class Favourites
    {
        public int Id { get; set; }
        public int ReceiptId { get; set; }
        public Receipt Receipt { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}