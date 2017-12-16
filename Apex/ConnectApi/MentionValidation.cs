namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class MentionValidation
    {
        // infrastructure
        public MentionValidation(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(MentionValidation));
            }
        }

        // API
        object recordId
        {
            get
            {
                return Self.recordId;
            }
            set
            {
                Self.recordId = value;
            }
        }

        object validationStatus
        {
            get
            {
                return Self.validationStatus;
            }
            set
            {
                Self.validationStatus = value;
            }
        }

        public MentionValidation()
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
