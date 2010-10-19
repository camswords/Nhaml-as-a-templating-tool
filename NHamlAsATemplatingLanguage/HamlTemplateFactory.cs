using NHaml;
using NHaml.TemplateResolution;
using System.Collections.Generic;
using System.Linq;

namespace NHamlAsATemplatingLanguage
{
    public class HamlTemplateFactory
    {
        private readonly TemplateEngine templateEngine;

        public HamlTemplateFactory()
            : this(@"C:\development\learningProjects\NHamlAsATemplatingLanguage\NHamlAsATemplatingLanguage")
        {
        }

        public HamlTemplateFactory(string baseTemplatePath)
        {
            var templateOptions = new TemplateOptions();
            templateOptions.EncodeHtml = false;
            templateOptions.AutoRecompile = true;
            templateOptions.IndentSize = 2;
            templateOptions.TemplateBaseType = typeof(HamlTemplate);

            var fileTemplateResolver = new FileTemplateContentProvider();
            fileTemplateResolver.PathSources = new [] { baseTemplatePath }.ToList();

            this.templateEngine = new TemplateEngine(templateOptions) { TemplateContentProvider = fileTemplateResolver };
        }

        public HamlTemplate Create(string templatePath, Dictionary<string, string> model)
        {
            CompiledTemplate compiledTemplate = templateEngine.Compile(templatePath);
            HamlTemplate template = (HamlTemplate) compiledTemplate.CreateInstance();
            template.Model = model;

            return template;
        }
    }
}
