namespace AzureRm.Templates.CodeGeneration
{
    public sealed class CSharpGenerator : CodeGenerator
    {
        public CSharpGenerator(TemplateSchema schema, string outputDir = null) 
            : base(schema, outputDir)
        {
        }

        protected override void OnGenerate()
        {
            throw new System.NotImplementedException();
        }
    }
}