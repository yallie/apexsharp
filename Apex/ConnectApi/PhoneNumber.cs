namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class PhoneNumber
    {
        // infrastructure
        public PhoneNumber(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(PhoneNumber));
            }
        }

        // API
        object label
        {
            get
            {
                return Self.label;
            }
            set
            {
                Self.label = value;
            }
        }

        object phoneNumber
        {
            get
            {
                return Self.phoneNumber;
            }
            set
            {
                Self.phoneNumber = value;
            }
        }

        object phoneType
        {
            get
            {
                return Self.phoneType;
            }
            set
            {
                Self.phoneType = value;
            }
        }

        object type
        {
            get
            {
                return Self.type;
            }
            set
            {
                Self.type = value;
            }
        }

        public PhoneNumber()
        {
            Self = Implementation.Constructor();
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
