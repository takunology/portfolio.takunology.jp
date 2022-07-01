using System.Runtime.Serialization;

namespace TakunologyPortfolio.Data
{
    [DataContract]
    public class PersonalData
    {
        [DataMember(Name = "name")]
        public string? Name { get; set; }
        [DataMember(Name = "name_en")]
        public string? EnName { get; set; }
        [DataMember(Name = "active_name")]
        public string? ActiveName { get; set; }
        [DataMember(Name = "age")]
        public int Age { get; set; }
        [DataMember(Name = "email")]
        public string? Email { get; set; }
        [DataMember(Name = "favorite")]
        public string[]? Favorite { get; set; }
        [DataMember(Name = "job")]
        public string? Job { get; set; }
    }
}
