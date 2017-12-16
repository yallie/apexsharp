namespace Apex.QuickAction
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class Control
    {
        // infrastructure
        public Control(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Control));
            }
        }

        // API
        public int getDisplayLines()
        {
            return Self.getDisplayLines();
        }

        public int getTabOrder()
        {
            return Self.getTabOrder();
        }

        public string getType()
        {
            return Self.getType();
        }

        public string getValue()
        {
            return Self.getValue();
        }
    }
}
