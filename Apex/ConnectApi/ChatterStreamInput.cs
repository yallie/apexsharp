namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class ChatterStreamInput
    {
        // infrastructure
        public ChatterStreamInput(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ChatterStreamInput));
            }
        }

        // API
        object description
        {
            get
            {
                return Self.description;
            }
            set
            {
                Self.description = value;
            }
        }

        object name
        {
            get
            {
                return Self.name;
            }
            set
            {
                Self.name = value;
            }
        }

        object subscriptionsToAdd
        {
            get
            {
                return Self.subscriptionsToAdd;
            }
            set
            {
                Self.subscriptionsToAdd = value;
            }
        }

        object subscriptionsToRemove
        {
            get
            {
                return Self.subscriptionsToRemove;
            }
            set
            {
                Self.subscriptionsToRemove = value;
            }
        }

        public ChatterStreamInput()
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
