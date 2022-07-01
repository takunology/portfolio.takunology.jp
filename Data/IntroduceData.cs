using System.Runtime.Serialization;

namespace TakunologyPortfolio.Data
{
    [DataContract]
    public class IntroduceData
    {
        [DataMember(Name = "biography")]
        public string? Bio { get; set; }
    }
}
