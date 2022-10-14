


using AngleSharp.Html.Dom;

namespace ParserOne.Core
{
     interface IParser<T> where T : class
     {
         T Parse(IHtmlDocument doc);
     }
}