namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_methods_system_restresponse.htm#apex_methods_system_restresponse
    /// </summary>
    public class RestResponse
    {
        // infrastructure
        public RestResponse(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(RestResponse));
            }
        }

        // API
        public RestResponse()
        {
            Implementation.Constructor();
        }

        Blob responseBody
        {
            get
            {
                return Self.responseBody;
            }
            set
            {
                Self.responseBody = value;
            }
        }

        Map<string, string> headers
        {
            get
            {
                return Self.headers;
            }
            set
            {
                Self.headers = value;
            }
        }

        int statuscode
        {
            get
            {
                return Self.statuscode;
            }
            set
            {
                Self.statuscode = value;
            }
        }

        public void addHeader(string name, string value)
        {
            Self.addHeader(name, value);
        }

        int statusCode
        {
            get
            {
                return Self.statusCode;
            }
            set
            {
                Self.statusCode = value;
            }
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}
