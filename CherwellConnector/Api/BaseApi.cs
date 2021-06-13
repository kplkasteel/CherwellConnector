using System;

using CherwellConnector.Client;

namespace CherwellConnector.Api
{
    public abstract class BaseApi
    {
        private ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return Configuration.ApiClient.RestClient.BaseUrl?.ToString();
        }
        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multi-cast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set => _exceptionFactory = value;
        }

        protected readonly string[] LocalVarHttpHeaderAccepts = {
            "application/json",
            "text/json",
            "application/xml",
            "text/xml"
        };
        
        protected readonly string[] LocalVarHttpContentTypes = {
            "application/json", 
            "text/json", 
            "application/xml", 
            "text/xml", 
            "application/x-www-form-urlencoded"
        };
        
    }
}
