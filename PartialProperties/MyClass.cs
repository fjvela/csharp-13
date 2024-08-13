using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PartialProperties
{
    [Generator]

    public partial class MyClassGenerator : ISourceGenerator
    {
        private static readonly Regex s_abcOrDefGeneratedRegex = new(
            pattern: "abc|def",
            options: RegexOptions.Compiled | RegexOptions.IgnoreCase
        );

        [GeneratedRegex("abc|def")]
        private static partial Regex AbcOrDefProperty { get; }


        private static void EvaluateText(string text)
        {
            if (s_abcOrDefGeneratedRegex.IsMatch(text))
            {
                // Take action with matching text
            }

            if (AbcOrDefProperty.IsMatch(text))
            {
                // Take action with matching text
            }
        }

        public void Execute(GeneratorExecutionContext context)
        {
            throw new NotImplementedException();
        }

        public void Initialize(GeneratorInitializationContext context)
        {
            throw new NotImplementedException();
        }
    }
}
