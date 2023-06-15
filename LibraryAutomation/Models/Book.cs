namespace LibraryAutomation.Models
{
    public class Book
    {
        public string BookName { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string PublicationYear { get; set; }

        private string isbn;
        public string ISBN
        {
            get { return isbn; }
            set { isbn = value; }
        }
    }
}