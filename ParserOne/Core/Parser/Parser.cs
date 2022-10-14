using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms.VisualStyles;
using AngleSharp.Html.Dom;

namespace ParserOne.Core.Parser
{
    public class Parser : IParser<string[]>
    {
        public string[] Parse(IHtmlDocument doc)
        {
            var list = new List<string>();
            var items = doc.QuerySelectorAll("a")
                .Where(item => item.ClassName != null
                               && item.ClassName.Contains("tm-article-snippet__title-link"));

            foreach (var item in items)
            {
                list.Add(item.TextContent);
            }

            return list.ToArray();
        }
    }
}