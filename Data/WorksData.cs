using System.Runtime.Serialization;

namespace TakunologyPortfolio.Data
{
    [DataContract]
    public class WorksData
    {
        [DataMember(Name = "works")]
        public List<Works> WorksList { get; set; } = new List<Works>();

        [DataContract]
        public class Works
        {
            [DataMember(Name = "title")]
            public string? Title { get; set; }
            [DataMember(Name = "type")]
            public string? Type { get; set; }
            [DataMember(Name = "tech")]
            public List<string> TechList { get; set; } = new List<string>();
            [DataMember(Name = "description")]
            public string? Description { get; set; }
            [DataMember(Name = "link")]
            public string? Link { get; set; }
            [DataMember(Name = "img")]
            public string? Image { get; set; }
        }
    }
}
