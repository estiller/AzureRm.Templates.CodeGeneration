namespace AzureRm.Templates.CodeGeneration
{
    public sealed class TemplateSchema
    {
        public const string DefaultUri = "https://schema.management.azure.com/schemas/2015-01-01/deploymentTemplate.json";

        public static TemplateSchema FromDefaultUri()
        {
            return FromUri(DefaultUri);
        }

        public static TemplateSchema FromUri(string uri)
        {
            throw new System.NotImplementedException();
        }
    }
}