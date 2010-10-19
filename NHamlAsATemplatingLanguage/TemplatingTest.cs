using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NHamlAsATemplatingLanguage
{
    public class TemplatingTest
    {
        public void RunHamlTest()
        {
            var model = new Dictionary<string, string>();
            model.Add("Message", "Hello World");

            var renderedText = new HamlTemplateEngine().Render("email/HelloWorld.haml", model);
            Console.WriteLine(renderedText);
        }

        public static void Main(string[] args)
        {
            new TemplatingTest().RunHamlTest();
            Console.ReadLine();
        }
    }
}
