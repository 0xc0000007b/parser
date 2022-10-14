using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace ParserOne.Core
{
    public class HtmlLoader
    {
        readonly HttpClient _client;
         readonly string url;

        public HtmlLoader(IParserSettings settings)
        {
            _client = new HttpClient();
            url = $"{settings.BaseUrl}/{settings.Prefix}/";
        }

        public async Task<string> GetSourceByPageId(int id)
        {
            var currentUrl = url.Replace("{currentId}", id.ToString());
            var resp = await _client.GetAsync(currentUrl);
            string source = null;

            if (resp != null && resp.StatusCode == HttpStatusCode.OK)
            {
                source = await resp.Content.ReadAsStringAsync();
            }

            return source;
        }
        
    }
}