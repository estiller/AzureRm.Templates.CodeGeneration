using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace AzureRm.Templates.CodeGeneration.Schema
{
    internal sealed class SchemaBuilder
    {
        private readonly Uri _uri;
        private readonly DefinitionDownloader _downloader;
        private readonly Dictionary<string, DefinitionBuilder> _definitions; 

        internal SchemaBuilder(Uri uri)
        {
            Debug.Assert(uri != null);

            _uri = uri;
            _downloader = new DefinitionDownloader();
            _definitions = new Dictionary<string, DefinitionBuilder>();
        }

        internal async Task<TemplateSchema> BuildSchemaAsync()
        {
            await BuildSchemaAsync(_uri);
            throw new NotImplementedException();
        }

        private async Task BuildSchemaAsync(Uri uri)
        {
            Debug.Assert(uri != null);
            string definitionText = await _downloader.DownloadAsync(uri);
        }
    }
}