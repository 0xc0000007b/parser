using ParserOne.Properties;

namespace ParserOne.Core.Parser
{
     class ParserSettings : IParserSettings
    {
        public ParserSettings(int start, int end)
        {
            StartPoint = start;
            EndPoint = end;
        }
        public string BaseUrl { get; set; } = "https://habr.com";
        public string Prefix { get; set; } = "page{currentId}";
        public int StartPoint { get; set; }
        public int EndPoint { get; set; }
    }
}