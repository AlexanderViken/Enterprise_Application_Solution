using System;
using Moq;

namespace $ext_safeprojectname$.$safeprojectname$
{
    /// <summary>
    /// Wrapper class for abstract values tests tests using Moq.It
    /// </summary>
    public static class AnyKindOf
    {
        public static string String
        {
            get { return It.IsAny<string>(); }
        }

        public static int Int
        {
            get { return It.IsAny<int>(); }
        }

        public static long Long
        {
            get { return It.IsAny<long>(); }
        }

        public static Guid Guid
        {
            get { return It.IsAny<Guid>(); }
        }
    }
}
