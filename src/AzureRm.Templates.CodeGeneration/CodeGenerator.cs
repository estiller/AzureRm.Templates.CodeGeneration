using System;

namespace AzureRm.Templates.CodeGeneration
{
    public abstract class CodeGenerator
    {
        public const string DefaultOutputDir = "Generated";

        protected CodeGenerator(TemplateSchema schema, string outputDir = null)
        {
            if (schema == null) throw new ArgumentNullException(nameof(schema));

            Schema = schema;
            OutputDir = outputDir ?? DefaultOutputDir;
        }

        public TemplateSchema Schema { get; }

        public string OutputDir { get; }

        public void Generate()
        {
            OnGenerate();
        }

        protected abstract void OnGenerate();
    }
}