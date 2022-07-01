using System.Runtime.Serialization;

namespace TakunologyPortfolio.Data
{
    [DataContract]
    public class SkillData
    {
        [DataMember(Name = "comment")]
        public string? Comment { get; set; }
        [DataMember(Name = "program_lang")]
        public List<Skill> ProgramLangList { get; set; } = new List<Skill>();
        [DataMember(Name = "markup")]
        public List<Skill> MarkupList { get; set; } = new List<Skill>();
        [DataMember(Name = "framework")]
        public List<Skill> FrameworkList { get; set; } = new List<Skill>();
        [DataMember(Name = "cloud")]
        public List<Skill> CloudList { get; set; } = new List<Skill>();
        [DataMember(Name = "other")]
        public List<Skill> OtherList { get; set; } = new List<Skill>();

        [DataContract]
        public class Skill
        {
            [DataMember(Name = "name")]
            public string? Name { get; set; }
            [DataMember(Name = "comment")]
            public string? Comment { get; set; }
            [DataMember(Name = "icon")]
            public string? IconPath { get; set; }
        }
    }
}
