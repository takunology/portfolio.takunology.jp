using System.Runtime.Serialization;

namespace TakunologyPortfolio.Data
{
    [DataContract]
    public class BookData
    {
        [DataMember(Name = "book")]
        public List<Book> BookList { get; set; } = new List<Book>();

        [DataContract]
        public class Book
        {
            [DataMember(Name = "date")]
            public string? Date { get; set; }
            [DataMember(Name = "title")]
            public string? Title { get; set; }
            [DataMember(Name = "price")]
            public int Price { get; set; }
            [DataMember(Name = "description")]
            public string? Description { get; set; }
            [DataMember(Name = "link_book")]
            public string? BookLink { get; set; }
            [DataMember(Name = "link_img")]
            public string? ImageLink { get; set; }
        }
    }
}
