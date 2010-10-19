using System.Collections.Generic;
using System.IO;

namespace NHamlAsATemplatingLanguage
{
    public class HamlTemplateEngine
    {
        private readonly HamlTemplateFactory templateFactory = new HamlTemplateFactory();

        public string Render(string templatePath, Dictionary<string, string> model)
        {
            var template = templateFactory.Create(templatePath, model);
            return template.Render();
        }
    }
}
