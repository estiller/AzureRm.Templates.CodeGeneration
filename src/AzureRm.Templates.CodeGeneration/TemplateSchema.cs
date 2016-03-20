using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AzureRm.Templates.CodeGeneration.Schema;

namespace AzureRm.Templates.CodeGeneration
{
    public sealed class TemplateSchema : IEnumerable<Definition>
    {
        public const string DefaultUri = "https://schema.management.azure.com/schemas/2015-01-01/deploymentTemplate.json";

        public static Task<TemplateSchema> FromDefaultUriAsync()
        {
            return FromUriAsync(DefaultUri);
        }

        public static Task<TemplateSchema> FromUriAsync(string uri)
        {
            if (uri == null) throw new ArgumentNullException(nameof(uri));

            var builder = new SchemaBuilder(new Uri(uri));
            return builder.BuildSchemaAsync();
        }

        private readonly Definition[] _definitions;

        public TemplateSchema(IEnumerable<Definition> definitions)
        {
            if (definitions == null) throw new ArgumentNullException(nameof(definitions));

            _definitions = definitions.ToArray();
        }

        public IEnumerator<Definition> GetEnumerator()
        {
            return ((IEnumerable<Definition>)_definitions).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}