using System.Runtime.Serialization;

namespace TakunologyPortfolio.Data
{
    [DataContract]
    public class EventData
    {
        [DataMember(Name = "event")]
        public List<Event> EventList { get; set; } = new List<Event>();

        [DataContract]
        public class Event
        {
            [DataMember(Name = "date")]
            public string? Date { get; set; }
            [DataMember(Name = "title")]
            public string? Title { get; set; }
            [DataMember(Name = "subtitle")]
            public string? SubTitle { get; set; }
            [DataMember(Name = "description")]
            public string? Description { get; set; }
            [DataMember(Name = "link_event")]
            public string? EventLink { get; set; }
            [DataMember(Name = "link_document")]
            public string? DocumentLink { get; set; }
            [DataMember(Name = "link_video")]
            public string? VideoLink { get; set; }
            [DataMember(Name = "link_img")]
            public string? ImageLink { get; set; }
        }
    }
}
