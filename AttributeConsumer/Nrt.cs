#nullable enable

using System.Diagnostics.CodeAnalysis;

namespace AttributeConsumer
{
    class Nrt
    {
        [return: NotNullIfNotNull("x")]
        public static string? M(string? x) => x;

        public static string? P
        {
            [return: NotNull]
            get => _p ?? "";
            set => _p = value;
        }
        private static string? _p;
    }
}
