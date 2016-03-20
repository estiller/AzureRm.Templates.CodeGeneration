using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace AzureRm.Templates.CodeGeneration.Schema
{
    internal sealed class DefinitionDownloader
    {
        private readonly Dictionary<Uri, string> _cache = new Dictionary<Uri, string>();
        private readonly HttpClient _httpClient = new HttpClient(new WebRequestHandler());

        internal async Task<string> DownloadAsync(Uri uri)
        {
            // TODO: Handle fragment
            string definition;
            if (_cache.TryGetValue(uri, out definition))
                return definition;

            definition = await _httpClient.GetStringAsync(uri);
            _cache.Add(uri, definition);
            return definition;
        }
    }
}