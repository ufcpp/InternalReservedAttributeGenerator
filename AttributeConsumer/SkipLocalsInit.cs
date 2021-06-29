using System.Runtime.CompilerServices;

namespace AttributeConsumer
{
    class SkipLocalsInit
    {
        [SkipLocalsInit]
        public static unsafe int M()
        {
            byte* s = stackalloc byte[4];
            for (int i = 0; i < 4; i++) s[i] = (byte)(i + 1);
            return *(int*)s;
        }
    }
}
