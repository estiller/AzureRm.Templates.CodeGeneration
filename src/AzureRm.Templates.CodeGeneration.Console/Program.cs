namespace AzureRm.Templates.CodeGeneration.Console
{
    class Program
    {
        static void Main()
        {
            TemplateSchema schema = TemplateSchema.FromDefaultUri();
            var generator = new CSharpGenerator(schema);
            generator.Generate();
        }
    }
}
