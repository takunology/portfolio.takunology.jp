using System.Runtime.Serialization;

namespace TakunologyPortfolio.Data
{
    [DataContract]
    public class HistoryData
    {
        [DataMember(Name = "history")]
        public List<History> HistoryList { get; set; } = new List<History>();

        [DataContract]
        public class History
        {
            [DataMember(Name = "date")]
            public string? Date { get; set; }
            [DataMember(Name = "event")]
            public string? Event { get; set; }
        }
    }
}
