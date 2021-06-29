using System;
using System.Runtime.CompilerServices;

namespace AttributeConsumer
{
    class ModuleInitializer
    {
        [ModuleInitializer]
        internal static void Init()
        {
            Console.WriteLine("module initializer");
        }
    }
}
