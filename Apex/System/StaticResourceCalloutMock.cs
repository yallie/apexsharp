namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_methods_system_staticresourcecalloutmock.htm#apex_methods_system_staticresourcecalloutmock
    /// </summary>
    public class StaticResourceCalloutMock
    {
        // infrastructure
        public StaticResourceCalloutMock(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(StaticResourceCalloutMock));
            }
        }

        // API
        public StaticResourceCalloutMock()
        {
            Implementation.Constructor();
        }

        public void setHeader(string headerName, string headerValue)
        {
            Self.setHeader(headerName, headerValue);
        }

        public void setStaticResource(string resourceName)
        {
            Self.setStaticResource(resourceName);
        }

        public void setStatus(string httpStatus)
        {
            Self.setStatus(httpStatus);
        }

        public void setStatusCode(int httpStatusCode)
        {
            Self.setStatusCode(httpStatusCode);
        }

        public object clone()
        {
            return Self.clone();
        }

        public HttpResponse respond(HttpRequest request)
        {
            return Self.respond(request);
        }
    }
}
