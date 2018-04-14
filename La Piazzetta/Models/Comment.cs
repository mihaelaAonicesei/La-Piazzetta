using System;

namespace La_Piazzetta.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime PublishedDate { get; set; }
        public int ReceiptId { get; set; }
        public Receipt Receipt { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}