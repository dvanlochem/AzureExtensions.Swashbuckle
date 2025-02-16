using System;

namespace AzureFunctions.Extensions.Swashbuckle.Attribute
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, AllowMultiple = true)]
    public class RequestHttpHeaderAttribute : System.Attribute
    {
        public RequestHttpHeaderAttribute(string headerName, bool isRequired = false)
        {
            this.HeaderName = headerName;
            this.IsRequired = isRequired;
        }

        public string HeaderName { get; }

        public bool IsRequired { get; }
    }
}
