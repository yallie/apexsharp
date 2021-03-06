namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class Iterator
    {
        // infrastructure
        public Iterator(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Iterator));
            }
        }

        // API
        public bool hasNext()
        {
            return Self.hasNext();
        }

        public object next()
        {
            return Self.next();
        }
    }
}
