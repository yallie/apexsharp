namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class OriginCapability
    {
        // infrastructure
        public OriginCapability(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(OriginCapability));
            }
        }

        // API
        object actor
        {
            get
            {
                return Self.actor;
            }
            set
            {
                Self.actor = value;
            }
        }

        object originRecord
        {
            get
            {
                return Self.originRecord;
            }
            set
            {
                Self.originRecord = value;
            }
        }

        public OriginCapability()
        {
            Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }

        public bool equals(object obj)
        {
            return Self.equals(obj);
        }

        public double getBuildVersion()
        {
            return Self.getBuildVersion();
        }

        public int hashCode()
        {
            return Self.hashCode();
        }

        public string toString()
        {
            return Self.toString();
        }
    }
}
