namespace Apex.Cache
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class SessionCacheException
    {
        // infrastructure
        public SessionCacheException(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(SessionCacheException));
            }
        }

        // API
        public SessionCacheException()
        {
            Implementation.Constructor();
        }

        public SessionCacheException(Exception param1)
        {
            Implementation.Constructor(param1);
        }

        public SessionCacheException(string msg)
        {
            Implementation.Constructor(msg);
        }

        public SessionCacheException(string param1, Exception param2)
        {
            Implementation.Constructor(param1, param2);
        }

        public object clone()
        {
            return Self.clone();
        }

        public string getTypeName()
        {
            return Self.getTypeName();
        }
    }
}
