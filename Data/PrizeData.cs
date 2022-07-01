using System.Runtime.Serialization;

namespace TakunologyPortfolio.Data
{
    [DataContract]
    public class PrizeData
    {
        [DataMember(Name = "prize")]
        public List<Prize> PrizeList { get; set; } = new List<Prize>();

        [DataContract]
        public class Prize
        {
            [DataMember(Name = "date")]
            public string? Date { get; set; }
            [DataMember(Name = "name")]
            public string? Name { get; set; }
            [DataMember(Name = "link")]
            public string? Link { get; set; }
        }
    }
}
