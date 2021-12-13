using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodApp.MyExtensionMethod
{
    static class StringExtension
    {
        public static string Foo(this string input)
        {
            return input + " : Foo";
        }
    }
}
