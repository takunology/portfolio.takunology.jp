using System.Runtime.Serialization;

namespace TakunologyPortfolio.Data
{
    [DataContract]
    public class ActivityData
    {
        [DataMember(Name = "activity")]
        public List<Activity> ActivityList { get; set; } = new List<Activity>();

        [DataContract]
        public class Activity
        {
            [DataMember(Name = "title")]
            public string? Title { get; set; }
            [DataMember(Name = "type")]
            public string? Type { get; set; }
            [DataMember(Name = "description")]
            public string? Description { get; set; }
            [DataMember(Name = "link")]
            public string? Link { get; set; }
            [DataMember(Name = "img")]
            public string? Image { get; set; }
        }
    }
}
