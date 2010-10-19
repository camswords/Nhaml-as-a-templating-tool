using NHaml;
using System.Collections.Generic;
using System.IO;

namespace NHamlAsATemplatingLanguage
{
    public class HamlTemplate : Template
    {
        public Dictionary<string, string> Model { get; set; }

        public string Render()
        {
            var textWriter = new StringWriter();
            base.Render(textWriter);
            return textWriter.ToString();
        }
    }
}
