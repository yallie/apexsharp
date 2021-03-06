namespace Apex.Cache
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class CacheException : Exception
    {
        // infrastructure
        public CacheException(dynamic self)
        {
            Self = self;
        }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(CacheException));
            }
        }

        // API
        public CacheException()
        {
            Self = Implementation.Constructor();
        }

        public CacheException(Exception param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public CacheException(string msg)
        {
            Self = Implementation.Constructor(msg);
        }

        public CacheException(string param1, Exception param2)
        {
            Self = Implementation.Constructor(param1, param2);
        }
    }
}
