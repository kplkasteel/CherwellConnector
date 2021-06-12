
using CherwellConnector.Interface;

namespace CherwellConnector.Api
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;

    using Client;
    using Model;

    using RestSharp;

    using Object = System.Object;

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SecurityApi : ISecurityApi
    {
        private ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SecurityApi(string basePath)
        {
            Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SecurityApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                Configuration = Configuration.Default;
            else
                Configuration = configuration;

            ExceptionFactory = Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(string basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<string, string> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Get client security settings Operation to get the configured client security settings. Returns true if internal, Windows, LDAP, or SAML are enabled as authentication methods.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationtype">The type of CSM application to return security settings for.  Application type is Desktop Client, Browser Client, Browser Portal or Cherwell Mobile.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsSecurityClientSecuritySettingsResponse</returns>
        public ClientSecuritySettingsResponse SecurityGetClientSecuritySettingsV1 (string applicationtype, string lang = null, string locale = null)
        {
             ApiResponse<ClientSecuritySettingsResponse> localVarResponse = SecurityGetClientSecuritySettingsV1WithHttpInfo(applicationtype, lang, locale);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get client security settings Operation to get the configured client security settings. Returns true if internal, Windows, LDAP, or SAML are enabled as authentication methods.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationtype">The type of CSM application to return security settings for.  Application type is Desktop Client, Browser Client, Browser Portal or Cherwell Mobile.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsSecurityClientSecuritySettingsResponse</returns>
        public ApiResponse< ClientSecuritySettingsResponse > SecurityGetClientSecuritySettingsV1WithHttpInfo (string applicationtype, string lang = null, string locale = null)
        {
            // verify the required parameter 'applicationtype' is set
            if (applicationtype == null)
                throw new ApiException(400, "Missing required parameter 'applicationtype' when calling SecurityApi->SecurityGetClientSecuritySettingsV1");

            var localVarPath = "/api/V1/getclientsecuritysettings/applicationtype/{applicationtype}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            string localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (applicationtype != null) localVarPathParams.Add("applicationtype", Configuration.ApiClient.ParameterToString(applicationtype)); // path parameter
            if (lang != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SecurityGetClientSecuritySettingsV1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ClientSecuritySettingsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ClientSecuritySettingsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ClientSecuritySettingsResponse)));
        }

        /// <summary>
        /// Get client security settings Operation to get the configured client security settings. Returns true if internal, Windows, LDAP, or SAML are enabled as authentication methods.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationtype">The type of CSM application to return security settings for.  Application type is Desktop Client, Browser Client, Browser Portal or Cherwell Mobile.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsSecurityClientSecuritySettingsResponse</returns>
        public async System.Threading.Tasks.Task<ClientSecuritySettingsResponse> SecurityGetClientSecuritySettingsV1Async (string applicationtype, string lang = null, string locale = null)
        {
             ApiResponse<ClientSecuritySettingsResponse> localVarResponse = await SecurityGetClientSecuritySettingsV1AsyncWithHttpInfo(applicationtype, lang, locale);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get client security settings Operation to get the configured client security settings. Returns true if internal, Windows, LDAP, or SAML are enabled as authentication methods.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationtype">The type of CSM application to return security settings for.  Application type is Desktop Client, Browser Client, Browser Portal or Cherwell Mobile.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsSecurityClientSecuritySettingsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ClientSecuritySettingsResponse>> SecurityGetClientSecuritySettingsV1AsyncWithHttpInfo (string applicationtype, string lang = null, string locale = null)
        {
            // verify the required parameter 'applicationtype' is set
            if (applicationtype == null)
                throw new ApiException(400, "Missing required parameter 'applicationtype' when calling SecurityApi->SecurityGetClientSecuritySettingsV1");

            var localVarPath = "/api/V1/getclientsecuritysettings/applicationtype/{applicationtype}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            string localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (applicationtype != null) localVarPathParams.Add("applicationtype", Configuration.ApiClient.ParameterToString(applicationtype)); // path parameter
            if (lang != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SecurityGetClientSecuritySettingsV1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ClientSecuritySettingsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ClientSecuritySettingsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ClientSecuritySettingsResponse)));
        }

        /// <summary>
        /// Get all available Roles Operation to get all available Roles.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsSecurityRoleReadResponse</returns>
        public SecurityRoleReadResponse SecurityGetRolesV1 (string lang = null, string locale = null)
        {
             ApiResponse<SecurityRoleReadResponse> localVarResponse = SecurityGetRolesV1WithHttpInfo(lang, locale);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all available Roles Operation to get all available Roles.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsSecurityRoleReadResponse</returns>
        public ApiResponse< SecurityRoleReadResponse > SecurityGetRolesV1WithHttpInfo (string lang = null, string locale = null)
        {

            var localVarPath = "/api/V1/getroles";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            string localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (lang != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SecurityGetRolesV1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SecurityRoleReadResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SecurityRoleReadResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SecurityRoleReadResponse)));
        }

        /// <summary>
        /// Get all available Roles Operation to get all available Roles.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsSecurityRoleReadResponse</returns>
        public async System.Threading.Tasks.Task<SecurityRoleReadResponse> SecurityGetRolesV1Async (string lang = null, string locale = null)
        {
             ApiResponse<SecurityRoleReadResponse> localVarResponse = await SecurityGetRolesV1AsyncWithHttpInfo(lang, locale);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all available Roles Operation to get all available Roles.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsSecurityRoleReadResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SecurityRoleReadResponse>> SecurityGetRolesV1AsyncWithHttpInfo (string lang = null, string locale = null)
        {

            var localVarPath = "/api/V1/getroles";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            string localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (lang != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SecurityGetRolesV1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SecurityRoleReadResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SecurityRoleReadResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SecurityRoleReadResponse)));
        }

        /// <summary>
        /// Get all available Roles Operation to get all available Roles.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsSecurityRoleReadV2Response</returns>
        public RoleReadV2Response SecurityGetRolesV2 (string lang = null, string locale = null)
        {
             ApiResponse<RoleReadV2Response> localVarResponse = SecurityGetRolesV2WithHttpInfo(lang, locale);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all available Roles Operation to get all available Roles.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsSecurityRoleReadV2Response</returns>
        public ApiResponse< RoleReadV2Response > SecurityGetRolesV2WithHttpInfo (string lang = null, string locale = null)
        {

            var localVarPath = "/api/V2/getroles";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            string localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (lang != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SecurityGetRolesV2", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RoleReadV2Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RoleReadV2Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RoleReadV2Response)));
        }

        /// <summary>
        /// Get all available Roles Operation to get all available Roles.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsSecurityRoleReadV2Response</returns>
        public async System.Threading.Tasks.Task<RoleReadV2Response> SecurityGetRolesV2Async (string lang = null, string locale = null)
        {
             ApiResponse<RoleReadV2Response> localVarResponse = await SecurityGetRolesV2AsyncWithHttpInfo(lang, locale);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all available Roles Operation to get all available Roles.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsSecurityRoleReadV2Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RoleReadV2Response>> SecurityGetRolesV2AsyncWithHttpInfo (string lang = null, string locale = null)
        {

            var localVarPath = "/api/V2/getroles";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            string localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (lang != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SecurityGetRolesV2", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RoleReadV2Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RoleReadV2Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RoleReadV2Response)));
        }

        /// <summary>
        /// Get Business Object permissions by Security Group Operation to get specific Business Object permissions for a Security Group. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupid">Specify the Security Group ID. </param>
        /// <param name="busObId">Specify the Business Object ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>List&lt;TrebuchetWebApiDataContractsSecurityBusinessObjectPermission&gt;</returns>
        public List<BusinessObjectPermission> SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV1 (string groupid, string busObId, string lang = null, string locale = null)
        {
             ApiResponse<List<BusinessObjectPermission>> localVarResponse = SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV1WithHttpInfo(groupid, busObId, lang, locale);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Business Object permissions by Security Group Operation to get specific Business Object permissions for a Security Group. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupid">Specify the Security Group ID. </param>
        /// <param name="busObId">Specify the Business Object ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of List&lt;TrebuchetWebApiDataContractsSecurityBusinessObjectPermission&gt;</returns>
        public ApiResponse< List<BusinessObjectPermission> > SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV1WithHttpInfo (string groupid, string busObId, string lang = null, string locale = null)
        {
            // verify the required parameter 'groupid' is set
            if (groupid == null)
                throw new ApiException(400, "Missing required parameter 'groupid' when calling SecurityApi->SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV1");
            // verify the required parameter 'busObId' is set
            if (busObId == null)
                throw new ApiException(400, "Missing required parameter 'busObId' when calling SecurityApi->SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV1");

            var localVarPath = "/api/V1/getsecuritygroupbusinessobjectpermissions/groupid/{groupid}/busobid/{busObId}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            string localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (groupid != null) localVarPathParams.Add("groupid", Configuration.ApiClient.ParameterToString(groupid)); // path parameter
            if (busObId != null) localVarPathParams.Add("busObId", Configuration.ApiClient.ParameterToString(busObId)); // path parameter
            if (lang != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<BusinessObjectPermission>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<BusinessObjectPermission>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<BusinessObjectPermission>)));
        }

        /// <summary>
        /// Get Business Object permissions by Security Group Operation to get specific Business Object permissions for a Security Group. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupid">Specify the Security Group ID. </param>
        /// <param name="busObId">Specify the Business Object ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of List&lt;TrebuchetWebApiDataContractsSecurityBusinessObjectPermission&gt;</returns>
        public async System.Threading.Tasks.Task<List<BusinessObjectPermission>> SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV1Async (string groupid, string busObId, string lang = null, string locale = null)
        {
             ApiResponse<List<BusinessObjectPermission>> localVarResponse = await SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV1AsyncWithHttpInfo(groupid, busObId, lang, locale);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Business Object permissions by Security Group Operation to get specific Business Object permissions for a Security Group. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupid">Specify the Security Group ID. </param>
        /// <param name="busObId">Specify the Business Object ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;TrebuchetWebApiDataContractsSecurityBusinessObjectPermission&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<BusinessObjectPermission>>> SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV1AsyncWithHttpInfo (string groupid, string busObId, string lang = null, string locale = null)
        {
            // verify the required parameter 'groupid' is set
            if (groupid == null)
                throw new ApiException(400, "Missing required parameter 'groupid' when calling SecurityApi->SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV1");
            // verify the required parameter 'busObId' is set
            if (busObId == null)
                throw new ApiException(400, "Missing required parameter 'busObId' when calling SecurityApi->SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV1");

            var localVarPath = "/api/V1/getsecuritygroupbusinessobjectpermissions/groupid/{groupid}/busobid/{busObId}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            string localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (groupid != null) localVarPathParams.Add("groupid", Configuration.ApiClient.ParameterToString(groupid)); // path parameter
            if (busObId != null) localVarPathParams.Add("busObId", Configuration.ApiClient.ParameterToString(busObId)); // path parameter
            if (lang != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<BusinessObjectPermission>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<BusinessObjectPermission>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<BusinessObjectPermission>)));
        }

        /// <summary>
        /// Get Business Object permissions by Security Group Operation to get specific Business Object permissions for a Security Group. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupid">Specify the Security Group ID. </param>
        /// <param name="busObId">Specify the Business Object ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsSecurityGetSecurityGroupBusinessObjectPermissionsResponse</returns>
        public SecurityGroupBusinessObjectPermissionsResponse SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV2 (string groupid, string busObId, string lang = null, string locale = null)
        {
             ApiResponse<SecurityGroupBusinessObjectPermissionsResponse> localVarResponse = SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV2WithHttpInfo(groupid, busObId, lang, locale);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Business Object permissions by Security Group Operation to get specific Business Object permissions for a Security Group. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupid">Specify the Security Group ID. </param>
        /// <param name="busObId">Specify the Business Object ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsSecurityGetSecurityGroupBusinessObjectPermissionsResponse</returns>
        public ApiResponse< SecurityGroupBusinessObjectPermissionsResponse > SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV2WithHttpInfo (string groupid, string busObId, string lang = null, string locale = null)
        {
            // verify the required parameter 'groupid' is set
            if (groupid == null)
                throw new ApiException(400, "Missing required parameter 'groupid' when calling SecurityApi->SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV2");
            // verify the required parameter 'busObId' is set
            if (busObId == null)
                throw new ApiException(400, "Missing required parameter 'busObId' when calling SecurityApi->SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV2");

            var localVarPath = "/api/V2/getsecuritygroupbusinessobjectpermissions/groupid/{groupid}/busobid/{busObId}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            string localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (groupid != null) localVarPathParams.Add("groupid", Configuration.ApiClient.ParameterToString(groupid)); // path parameter
            if (busObId != null) localVarPathParams.Add("busObId", Configuration.ApiClient.ParameterToString(busObId)); // path parameter
            if (lang != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV2", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SecurityGroupBusinessObjectPermissionsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SecurityGroupBusinessObjectPermissionsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SecurityGroupBusinessObjectPermissionsResponse)));
        }

        /// <summary>
        /// Get Business Object permissions by Security Group Operation to get specific Business Object permissions for a Security Group. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupid">Specify the Security Group ID. </param>
        /// <param name="busObId">Specify the Business Object ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsSecurityGetSecurityGroupBusinessObjectPermissionsResponse</returns>
        public async System.Threading.Tasks.Task<SecurityGroupBusinessObjectPermissionsResponse> SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV2Async (string groupid, string busObId, string lang = null, string locale = null)
        {
             ApiResponse<SecurityGroupBusinessObjectPermissionsResponse> localVarResponse = await SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV2AsyncWithHttpInfo(groupid, busObId, lang, locale);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Business Object permissions by Security Group Operation to get specific Business Object permissions for a Security Group. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupid">Specify the Security Group ID. </param>
        /// <param name="busObId">Specify the Business Object ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsSecurityGetSecurityGroupBusinessObjectPermissionsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SecurityGroupBusinessObjectPermissionsResponse>> SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV2AsyncWithHttpInfo (string groupid, string busObId, string lang = null, string locale = null)
        {
            // verify the required parameter 'groupid' is set
            if (groupid == null)
                throw new ApiException(400, "Missing required parameter 'groupid' when calling SecurityApi->SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV2");
            // verify the required parameter 'busObId' is set
            if (busObId == null)
                throw new ApiException(400, "Missing required parameter 'busObId' when calling SecurityApi->SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV2");

            var localVarPath = "/api/V2/getsecuritygroupbusinessobjectpermissions/groupid/{groupid}/busobid/{busObId}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            string localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (groupid != null) localVarPathParams.Add("groupid", Configuration.ApiClient.ParameterToString(groupid)); // path parameter
            if (busObId != null) localVarPathParams.Add("busObId", Configuration.ApiClient.ParameterToString(busObId)); // path parameter
            if (lang != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV2", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SecurityGroupBusinessObjectPermissionsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SecurityGroupBusinessObjectPermissionsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SecurityGroupBusinessObjectPermissionsResponse)));
        }

        /// <summary>
        /// Get Business Object permissions by Security Group Operation to get specific Business Object permissions for a Security Group. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupname">Specify the Security Group name. </param>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>List&lt;TrebuchetWebApiDataContractsSecurityBusinessObjectPermission&gt;</returns>
        public List<BusinessObjectPermission> SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV1 (string groupname, string busobname, string lang = null, string locale = null)
        {
             ApiResponse<List<BusinessObjectPermission>> localVarResponse = SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV1WithHttpInfo(groupname, busobname, lang, locale);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Business Object permissions by Security Group Operation to get specific Business Object permissions for a Security Group. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupname">Specify the Security Group name. </param>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of List&lt;TrebuchetWebApiDataContractsSecurityBusinessObjectPermission&gt;</returns>
        public ApiResponse< List<BusinessObjectPermission> > SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV1WithHttpInfo (string groupname, string busobname, string lang = null, string locale = null)
        {
            // verify the required parameter 'groupname' is set
            if (groupname == null)
                throw new ApiException(400, "Missing required parameter 'groupname' when calling SecurityApi->SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV1");
            // verify the required parameter 'busobname' is set
            if (busobname == null)
                throw new ApiException(400, "Missing required parameter 'busobname' when calling SecurityApi->SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV1");

            var localVarPath = "/api/V1/getsecuritygroupbusinessobjectpermissions/groupname/{groupname}/busobname/{busobname}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            string localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (groupname != null) localVarPathParams.Add("groupname", Configuration.ApiClient.ParameterToString(groupname)); // path parameter
            if (busobname != null) localVarPathParams.Add("busobname", Configuration.ApiClient.ParameterToString(busobname)); // path parameter
            if (lang != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<BusinessObjectPermission>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<BusinessObjectPermission>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<BusinessObjectPermission>)));
        }

        /// <summary>
        /// Get Business Object permissions by Security Group Operation to get specific Business Object permissions for a Security Group. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupname">Specify the Security Group name. </param>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of List&lt;TrebuchetWebApiDataContractsSecurityBusinessObjectPermission&gt;</returns>
        public async System.Threading.Tasks.Task<List<BusinessObjectPermission>> SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV1Async (string groupname, string busobname, string lang = null, string locale = null)
        {
             ApiResponse<List<BusinessObjectPermission>> localVarResponse = await SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV1AsyncWithHttpInfo(groupname, busobname, lang, locale);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Business Object permissions by Security Group Operation to get specific Business Object permissions for a Security Group. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupname">Specify the Security Group name. </param>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;TrebuchetWebApiDataContractsSecurityBusinessObjectPermission&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<BusinessObjectPermission>>> SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV1AsyncWithHttpInfo (string groupname, string busobname, string lang = null, string locale = null)
        {
            // verify the required parameter 'groupname' is set
            if (groupname == null)
                throw new ApiException(400, "Missing required parameter 'groupname' when calling SecurityApi->SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV1");
            // verify the required parameter 'busobname' is set
            if (busobname == null)
                throw new ApiException(400, "Missing required parameter 'busobname' when calling SecurityApi->SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV1");

            var localVarPath = "/api/V1/getsecuritygroupbusinessobjectpermissions/groupname/{groupname}/busobname/{busobname}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            string localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (groupname != null) localVarPathParams.Add("groupname", Configuration.ApiClient.ParameterToString(groupname)); // path parameter
            if (busobname != null) localVarPathParams.Add("busobname", Configuration.ApiClient.ParameterToString(busobname)); // path parameter
            if (lang != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<BusinessObjectPermission>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<BusinessObjectPermission>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<BusinessObjectPermission>)));
        }

        /// <summary>
        /// Get Business Object permissions by Security Group Operation to get specific Business Object permissions for a Security Group. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupname">Specify the Security Group name. </param>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsSecurityGetSecurityGroupBusinessObjectPermissionsResponse</returns>
        public SecurityGroupBusinessObjectPermissionsResponse SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV2 (string groupname, string busobname, string lang = null, string locale = null)
        {
             ApiResponse<SecurityGroupBusinessObjectPermissionsResponse> localVarResponse = SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV2WithHttpInfo(groupname, busobname, lang, locale);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Business Object permissions by Security Group Operation to get specific Business Object permissions for a Security Group. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupname">Specify the Security Group name. </param>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsSecurityGetSecurityGroupBusinessObjectPermissionsResponse</returns>
        public ApiResponse< SecurityGroupBusinessObjectPermissionsResponse > SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV2WithHttpInfo (string groupname, string busobname, string lang = null, string locale = null)
        {
            // verify the required parameter 'groupname' is set
            if (groupname == null)
                throw new ApiException(400, "Missing required parameter 'groupname' when calling SecurityApi->SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV2");
            // verify the required parameter 'busobname' is set
            if (busobname == null)
                throw new ApiException(400, "Missing required parameter 'busobname' when calling SecurityApi->SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV2");

            var localVarPath = "/api/V2/getsecuritygroupbusinessobjectpermissions/groupname/{groupname}/busobname/{busobname}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            string localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (groupname != null) localVarPathParams.Add("groupname", Configuration.ApiClient.ParameterToString(groupname)); // path parameter
            if (busobname != null) localVarPathParams.Add("busobname", Configuration.ApiClient.ParameterToString(busobname)); // path parameter
            if (lang != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV2", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SecurityGroupBusinessObjectPermissionsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SecurityGroupBusinessObjectPermissionsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SecurityGroupBusinessObjectPermissionsResponse)));
        }

        /// <summary>
        /// Get Business Object permissions by Security Group Operation to get specific Business Object permissions for a Security Group. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupname">Specify the Security Group name. </param>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsSecurityGetSecurityGroupBusinessObjectPermissionsResponse</returns>
        public async System.Threading.Tasks.Task<SecurityGroupBusinessObjectPermissionsResponse> SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV2Async (string groupname, string busobname, string lang = null, string locale = null)
        {
             ApiResponse<SecurityGroupBusinessObjectPermissionsResponse> localVarResponse = await SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV2AsyncWithHttpInfo(groupname, busobname, lang, locale);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Business Object permissions by Security Group Operation to get specific Business Object permissions for a Security Group. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupname">Specify the Security Group name. </param>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsSecurityGetSecurityGroupBusinessObjectPermissionsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SecurityGroupBusinessObjectPermissionsResponse>> SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV2AsyncWithHttpInfo (string groupname, string busobname, string lang = null, string locale = null)
        {
            // verify the required parameter 'groupname' is set
            if (groupname == null)
                throw new ApiException(400, "Missing required parameter 'groupname' when calling SecurityApi->SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV2");
            // verify the required parameter 'busobname' is set
            if (busobname == null)
                throw new ApiException(400, "Missing required parameter 'busobname' when calling SecurityApi->SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV2");

            var localVarPath = "/api/V2/getsecuritygroupbusinessobjectpermissions/groupname/{groupname}/busobname/{busobname}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            string localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (groupname != null) localVarPathParams.Add("groupname", Configuration.ApiClient.ParameterToString(groupname)); // path parameter
            if (busobname != null) localVarPathParams.Add("busobname", Configuration.ApiClient.ParameterToString(busobname)); // path parameter
            if (lang != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV2", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SecurityGroupBusinessObjectPermissionsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SecurityGroupBusinessObjectPermissionsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SecurityGroupBusinessObjectPermissionsResponse)));
        }

        /// <summary>
        /// Get Business Object permission for current user Operation to get Business Object permissions for the currently logged-in user&#39;s Security Group.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busObId">Specify the Business Object ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>List&lt;TrebuchetWebApiDataContractsSecurityBusinessObjectPermission&gt;</returns>
        public List<BusinessObjectPermission> SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV1 (string busObId, string lang = null, string locale = null)
        {
             ApiResponse<List<BusinessObjectPermission>> localVarResponse = SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV1WithHttpInfo(busObId, lang, locale);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Business Object permission for current user Operation to get Business Object permissions for the currently logged-in user&#39;s Security Group.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busObId">Specify the Business Object ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of List&lt;TrebuchetWebApiDataContractsSecurityBusinessObjectPermission&gt;</returns>
        public ApiResponse< List<BusinessObjectPermission> > SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV1WithHttpInfo (string busObId, string lang = null, string locale = null)
        {
            // verify the required parameter 'busObId' is set
            if (busObId == null)
                throw new ApiException(400, "Missing required parameter 'busObId' when calling SecurityApi->SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV1");

            var localVarPath = "/api/V1/getsecuritygroupbusinessobjectpermissionsforcurrentuserbybusobid/busobid/{busObId}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            string localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (busObId != null) localVarPathParams.Add("busObId", Configuration.ApiClient.ParameterToString(busObId)); // path parameter
            if (lang != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<BusinessObjectPermission>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<BusinessObjectPermission>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<BusinessObjectPermission>)));
        }

        /// <summary>
        /// Get Business Object permission for current user Operation to get Business Object permissions for the currently logged-in user&#39;s Security Group.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busObId">Specify the Business Object ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of List&lt;TrebuchetWebApiDataContractsSecurityBusinessObjectPermission&gt;</returns>
        public async System.Threading.Tasks.Task<List<BusinessObjectPermission>> SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV1Async (string busObId, string lang = null, string locale = null)
        {
             ApiResponse<List<BusinessObjectPermission>> localVarResponse = await SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV1AsyncWithHttpInfo(busObId, lang, locale);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Business Object permission for current user Operation to get Business Object permissions for the currently logged-in user&#39;s Security Group.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busObId">Specify the Business Object ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;TrebuchetWebApiDataContractsSecurityBusinessObjectPermission&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<BusinessObjectPermission>>> SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV1AsyncWithHttpInfo (string busObId, string lang = null, string locale = null)
        {
            // verify the required parameter 'busObId' is set
            if (busObId == null)
                throw new ApiException(400, "Missing required parameter 'busObId' when calling SecurityApi->SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV1");

            var localVarPath = "/api/V1/getsecuritygroupbusinessobjectpermissionsforcurrentuserbybusobid/busobid/{busObId}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            string localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (busObId != null) localVarPathParams.Add("busObId", Configuration.ApiClient.ParameterToString(busObId)); // path parameter
            if (lang != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<BusinessObjectPermission>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<BusinessObjectPermission>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<BusinessObjectPermission>)));
        }

        /// <summary>
        /// Get Business Object permission for current user Operation to get Business Object permissions for the currently logged-in user&#39;s Security Group.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busObId">Specify the Business Object ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsSecurityGetSecurityGroupBusinessObjectPermissionsResponse</returns>
        public SecurityGroupBusinessObjectPermissionsResponse SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV2 (string busObId, string lang = null, string locale = null)
        {
             ApiResponse<SecurityGroupBusinessObjectPermissionsResponse> localVarResponse = SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV2WithHttpInfo(busObId, lang, locale);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Business Object permission for current user Operation to get Business Object permissions for the currently logged-in user&#39;s Security Group.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busObId">Specify the Business Object ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsSecurityGetSecurityGroupBusinessObjectPermissionsResponse</returns>
        public ApiResponse< SecurityGroupBusinessObjectPermissionsResponse > SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV2WithHttpInfo (string busObId, string lang = null, string locale = null)
        {
            // verify the required parameter 'busObId' is set
            if (busObId == null)
                throw new ApiException(400, "Missing required parameter 'busObId' when calling SecurityApi->SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV2");

            var localVarPath = "/api/V2/getsecuritygroupbusinessobjectpermissionsforcurrentuserbybusobid/busobid/{busObId}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            string localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (busObId != null) localVarPathParams.Add("busObId", Configuration.ApiClient.ParameterToString(busObId)); // path parameter
            if (lang != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV2", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SecurityGroupBusinessObjectPermissionsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SecurityGroupBusinessObjectPermissionsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SecurityGroupBusinessObjectPermissionsResponse)));
        }

        /// <summary>
        /// Get Business Object permission for current user Operation to get Business Object permissions for the currently logged-in user&#39;s Security Group.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busObId">Specify the Business Object ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsSecurityGetSecurityGroupBusinessObjectPermissionsResponse</returns>
        public async System.Threading.Tasks.Task<SecurityGroupBusinessObjectPermissionsResponse> SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV2Async (string busObId, string lang = null, string locale = null)
        {
             ApiResponse<SecurityGroupBusinessObjectPermissionsResponse> localVarResponse = await SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV2AsyncWithHttpInfo(busObId, lang, locale);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Business Object permission for current user Operation to get Business Object permissions for the currently logged-in user&#39;s Security Group.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busObId">Specify the Business Object ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsSecurityGetSecurityGroupBusinessObjectPermissionsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SecurityGroupBusinessObjectPermissionsResponse>> SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV2AsyncWithHttpInfo (string busObId, string lang = null, string locale = null)
        {
            // verify the required parameter 'busObId' is set
            if (busObId == null)
                throw new ApiException(400, "Missing required parameter 'busObId' when calling SecurityApi->SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV2");

            var localVarPath = "/api/V2/getsecuritygroupbusinessobjectpermissionsforcurrentuserbybusobid/busobid/{busObId}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            string localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (busObId != null) localVarPathParams.Add("busObId", Configuration.ApiClient.ParameterToString(busObId)); // path parameter
            if (lang != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV2", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SecurityGroupBusinessObjectPermissionsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SecurityGroupBusinessObjectPermissionsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SecurityGroupBusinessObjectPermissionsResponse)));
        }

        /// <summary>
        /// Get Business Object permissions for current user Operation to get Business Object permissions for currently logged in user&#39;s Security Group.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>List&lt;TrebuchetWebApiDataContractsSecurityBusinessObjectPermission&gt;</returns>
        public List<BusinessObjectPermission> SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV1 (string busobname, string lang = null, string locale = null)
        {
             ApiResponse<List<BusinessObjectPermission>> localVarResponse = SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV1WithHttpInfo(busobname, lang, locale);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Business Object permissions for current user Operation to get Business Object permissions for currently logged in user&#39;s Security Group.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of List&lt;TrebuchetWebApiDataContractsSecurityBusinessObjectPermission&gt;</returns>
        public ApiResponse< List<BusinessObjectPermission> > SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV1WithHttpInfo (string busobname, string lang = null, string locale = null)
        {
            // verify the required parameter 'busobname' is set
            if (busobname == null)
                throw new ApiException(400, "Missing required parameter 'busobname' when calling SecurityApi->SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV1");

            var localVarPath = "/api/V1/getsecuritygroupbusinessobjectpermissionsforcurrentuserbybusobname/busobname/{busobname}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            string localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (busobname != null) localVarPathParams.Add("busobname", Configuration.ApiClient.ParameterToString(busobname)); // path parameter
            if (lang != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<BusinessObjectPermission>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<BusinessObjectPermission>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<BusinessObjectPermission>)));
        }

        /// <summary>
        /// Get Business Object permissions for current user Operation to get Business Object permissions for currently logged in user&#39;s Security Group.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of List&lt;TrebuchetWebApiDataContractsSecurityBusinessObjectPermission&gt;</returns>
        public async System.Threading.Tasks.Task<List<BusinessObjectPermission>> SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV1Async (string busobname, string lang = null, string locale = null)
        {
             ApiResponse<List<BusinessObjectPermission>> localVarResponse = await SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV1AsyncWithHttpInfo(busobname, lang, locale);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Business Object permissions for current user Operation to get Business Object permissions for currently logged in user&#39;s Security Group.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;TrebuchetWebApiDataContractsSecurityBusinessObjectPermission&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<BusinessObjectPermission>>> SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV1AsyncWithHttpInfo (string busobname, string lang = null, string locale = null)
        {
            // verify the required parameter 'busobname' is set
            if (busobname == null)
                throw new ApiException(400, "Missing required parameter 'busobname' when calling SecurityApi->SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV1");

            var localVarPath = "/api/V1/getsecuritygroupbusinessobjectpermissionsforcurrentuserbybusobname/busobname/{busobname}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            string localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (busobname != null) localVarPathParams.Add("busobname", Configuration.ApiClient.ParameterToString(busobname)); // path parameter
            if (lang != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<BusinessObjectPermission>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<BusinessObjectPermission>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<BusinessObjectPermission>)));
        }

        /// <summary>
        /// Get Business Object permissions for current user Operation to get Business Object permissions for currently logged in user&#39;s Security Group.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsSecurityGetSecurityGroupBusinessObjectPermissionsResponse</returns>
        public SecurityGroupBusinessObjectPermissionsResponse SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV2 (string busobname, string lang = null, string locale = null)
        {
             ApiResponse<SecurityGroupBusinessObjectPermissionsResponse> localVarResponse = SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV2WithHttpInfo(busobname, lang, locale);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Business Object permissions for current user Operation to get Business Object permissions for currently logged in user&#39;s Security Group.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsSecurityGetSecurityGroupBusinessObjectPermissionsResponse</returns>
        public ApiResponse< SecurityGroupBusinessObjectPermissionsResponse > SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV2WithHttpInfo (string busobname, string lang = null, string locale = null)
        {
            // verify the required parameter 'busobname' is set
            if (busobname == null)
                throw new ApiException(400, "Missing required parameter 'busobname' when calling SecurityApi->SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV2");

            var localVarPath = "/api/V2/getsecuritygroupbusinessobjectpermissionsforcurrentuserbybusobname/busobname/{busobname}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            string localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (busobname != null) localVarPathParams.Add("busobname", Configuration.ApiClient.ParameterToString(busobname)); // path parameter
            if (lang != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV2", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SecurityGroupBusinessObjectPermissionsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SecurityGroupBusinessObjectPermissionsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SecurityGroupBusinessObjectPermissionsResponse)));
        }

        /// <summary>
        /// Get Business Object permissions for current user Operation to get Business Object permissions for currently logged in user&#39;s Security Group.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsSecurityGetSecurityGroupBusinessObjectPermissionsResponse</returns>
        public async System.Threading.Tasks.Task<SecurityGroupBusinessObjectPermissionsResponse> SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV2Async (string busobname, string lang = null, string locale = null)
        {
             ApiResponse<SecurityGroupBusinessObjectPermissionsResponse> localVarResponse = await SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV2AsyncWithHttpInfo(busobname, lang, locale);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Business Object permissions for current user Operation to get Business Object permissions for currently logged in user&#39;s Security Group.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsSecurityGetSecurityGroupBusinessObjectPermissionsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SecurityGroupBusinessObjectPermissionsResponse>> SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV2AsyncWithHttpInfo (string busobname, string lang = null, string locale = null)
        {
            // verify the required parameter 'busobname' is set
            if (busobname == null)
                throw new ApiException(400, "Missing required parameter 'busobname' when calling SecurityApi->SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV2");

            var localVarPath = "/api/V2/getsecuritygroupbusinessobjectpermissionsforcurrentuserbybusobname/busobname/{busobname}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            string localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (busobname != null) localVarPathParams.Add("busobname", Configuration.ApiClient.ParameterToString(busobname)); // path parameter
            if (lang != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV2", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SecurityGroupBusinessObjectPermissionsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SecurityGroupBusinessObjectPermissionsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SecurityGroupBusinessObjectPermissionsResponse)));
        }

        /// <summary>
        /// Get all Security Group categories Operation to get IDs and names for all available Security Group categories. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>List&lt;TrebuchetWebApiDataContractsSecurityRightCategory&gt;</returns>
        public List<RightCategory> SecurityGetSecurityGroupCategoriesV1 (string lang = null, string locale = null)
        {
             ApiResponse<List<RightCategory>> localVarResponse = SecurityGetSecurityGroupCategoriesV1WithHttpInfo(lang, locale);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all Security Group categories Operation to get IDs and names for all available Security Group categories. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of List&lt;TrebuchetWebApiDataContractsSecurityRightCategory&gt;</returns>
        public ApiResponse< List<RightCategory> > SecurityGetSecurityGroupCategoriesV1WithHttpInfo (string lang = null, string locale = null)
        {

            var localVarPath = "/api/V1/getsecuritygroupcategories";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            string localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (lang != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SecurityGetSecurityGroupCategoriesV1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<RightCategory>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<RightCategory>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<RightCategory>)));
        }

        /// <summary>
        /// Get all Security Group categories Operation to get IDs and names for all available Security Group categories. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of List&lt;TrebuchetWebApiDataContractsSecurityRightCategory&gt;</returns>
        public async System.Threading.Tasks.Task<List<RightCategory>> SecurityGetSecurityGroupCategoriesV1Async (string lang = null, string locale = null)
        {
             ApiResponse<List<RightCategory>> localVarResponse = await SecurityGetSecurityGroupCategoriesV1AsyncWithHttpInfo(lang, locale);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all Security Group categories Operation to get IDs and names for all available Security Group categories. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;TrebuchetWebApiDataContractsSecurityRightCategory&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<RightCategory>>> SecurityGetSecurityGroupCategoriesV1AsyncWithHttpInfo (string lang = null, string locale = null)
        {

            var localVarPath = "/api/V1/getsecuritygroupcategories";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            string localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (lang != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SecurityGetSecurityGroupCategoriesV1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<RightCategory>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<RightCategory>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<RightCategory>)));
        }

        /// <summary>
        /// Get all Security Group categories Operation to get IDs and names for all available Security Group categories. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsSecuritySecurityRightCategoriesResponse</returns>
        public SecurityRightCategoriesResponse SecurityGetSecurityGroupCategoriesV2 (string lang = null, string locale = null)
        {
             ApiResponse<SecurityRightCategoriesResponse> localVarResponse = SecurityGetSecurityGroupCategoriesV2WithHttpInfo(lang, locale);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all Security Group categories Operation to get IDs and names for all available Security Group categories. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsSecuritySecurityRightCategoriesResponse</returns>
        public ApiResponse< SecurityRightCategoriesResponse > SecurityGetSecurityGroupCategoriesV2WithHttpInfo (string lang = null, string locale = null)
        {

            var localVarPath = "/api/V2/getsecuritygroupcategories";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            string localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (lang != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SecurityGetSecurityGroupCategoriesV2", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SecurityRightCategoriesResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SecurityRightCategoriesResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SecurityRightCategoriesResponse)));
        }

        /// <summary>
        /// Get all Security Group categories Operation to get IDs and names for all available Security Group categories. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsSecuritySecurityRightCategoriesResponse</returns>
        public async System.Threading.Tasks.Task<SecurityRightCategoriesResponse> SecurityGetSecurityGroupCategoriesV2Async (string lang = null, string locale = null)
        {
             ApiResponse<SecurityRightCategoriesResponse> localVarResponse = await SecurityGetSecurityGroupCategoriesV2AsyncWithHttpInfo(lang, locale);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all Security Group categories Operation to get IDs and names for all available Security Group categories. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsSecuritySecurityRightCategoriesResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SecurityRightCategoriesResponse>> SecurityGetSecurityGroupCategoriesV2AsyncWithHttpInfo (string lang = null, string locale = null)
        {

            var localVarPath = "/api/V2/getsecuritygroupcategories";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            string localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (lang != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SecurityGetSecurityGroupCategoriesV2", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SecurityRightCategoriesResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SecurityRightCategoriesResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SecurityRightCategoriesResponse)));
        }

        /// <summary>
        /// Get permissions for a Security Group by category Operation to get permissions for a Security Group by category. To get Security Group IDs, use \&quot;Get all available Security Groups.\&quot; To get Security Group category IDs, use \&quot;Get all Security Group categories.\&quot;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupid">Specify the Security Group ID</param>
        /// <param name="categoryid">Specify the Security Group category ID</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>List&lt;TrebuchetWebApiDataContractsSecurityRight&gt;</returns>
        public List<SecurityRight> SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV1 (string groupid, string categoryid, string lang = null, string locale = null)
        {
             ApiResponse<List<SecurityRight>> localVarResponse = SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV1WithHttpInfo(groupid, categoryid, lang, locale);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get permissions for a Security Group by category Operation to get permissions for a Security Group by category. To get Security Group IDs, use \&quot;Get all available Security Groups.\&quot; To get Security Group category IDs, use \&quot;Get all Security Group categories.\&quot;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupid">Specify the Security Group ID</param>
        /// <param name="categoryid">Specify the Security Group category ID</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of List&lt;TrebuchetWebApiDataContractsSecurityRight&gt;</returns>
        public ApiResponse< List<SecurityRight> > SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV1WithHttpInfo (string groupid, string categoryid, string lang = null, string locale = null)
        {
            // verify the required parameter 'groupid' is set
            if (groupid == null)
                throw new ApiException(400, "Missing required parameter 'groupid' when calling SecurityApi->SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV1");
            // verify the required parameter 'categoryid' is set
            if (categoryid == null)
                throw new ApiException(400, "Missing required parameter 'categoryid' when calling SecurityApi->SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV1");

            var localVarPath = "/api/V1/getsecuritygrouprights/groupid/{groupid}/categoryid/{categoryid}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            string localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (groupid != null) localVarPathParams.Add("groupid", Configuration.ApiClient.ParameterToString(groupid)); // path parameter
            if (categoryid != null) localVarPathParams.Add("categoryid", Configuration.ApiClient.ParameterToString(categoryid)); // path parameter
            if (lang != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<SecurityRight>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<SecurityRight>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<SecurityRight>)));
        }

        /// <summary>
        /// Get permissions for a Security Group by category Operation to get permissions for a Security Group by category. To get Security Group IDs, use \&quot;Get all available Security Groups.\&quot; To get Security Group category IDs, use \&quot;Get all Security Group categories.\&quot;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupid">Specify the Security Group ID</param>
        /// <param name="categoryid">Specify the Security Group category ID</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of List&lt;TrebuchetWebApiDataContractsSecurityRight&gt;</returns>
        public async System.Threading.Tasks.Task<List<SecurityRight>> SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV1Async (string groupid, string categoryid, string lang = null, string locale = null)
        {
             ApiResponse<List<SecurityRight>> localVarResponse = await SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV1AsyncWithHttpInfo(groupid, categoryid, lang, locale);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get permissions for a Security Group by category Operation to get permissions for a Security Group by category. To get Security Group IDs, use \&quot;Get all available Security Groups.\&quot; To get Security Group category IDs, use \&quot;Get all Security Group categories.\&quot;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupid">Specify the Security Group ID</param>
        /// <param name="categoryid">Specify the Security Group category ID</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;TrebuchetWebApiDataContractsSecurityRight&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<SecurityRight>>> SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV1AsyncWithHttpInfo (string groupid, string categoryid, string lang = null, string locale = null)
        {
            // verify the required parameter 'groupid' is set
            if (groupid == null)
                throw new ApiException(400, "Missing required parameter 'groupid' when calling SecurityApi->SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV1");
            // verify the required parameter 'categoryid' is set
            if (categoryid == null)
                throw new ApiException(400, "Missing required parameter 'categoryid' when calling SecurityApi->SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV1");

            var localVarPath = "/api/V1/getsecuritygrouprights/groupid/{groupid}/categoryid/{categoryid}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            string localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (groupid != null) localVarPathParams.Add("groupid", Configuration.ApiClient.ParameterToString(groupid)); // path parameter
            if (categoryid != null) localVarPathParams.Add("categoryid", Configuration.ApiClient.ParameterToString(categoryid)); // path parameter
            if (lang != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<SecurityRight>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<SecurityRight>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<SecurityRight>)));
        }

        /// <summary>
        /// Get permissions for a Security Group by category Operation to get permissions for a Security Group by category. To get Security Group IDs, use \&quot;Get all available Security Groups.\&quot; To get Security Group category IDs, use \&quot;Get all Security Group categories.\&quot;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupid">Specify the Security Group ID</param>
        /// <param name="categoryid">Specify the Security Group category ID</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsSecuritySecurityRightsResponse</returns>
        public SecurityRightsResponse SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV2 (string groupid, string categoryid, string lang = null, string locale = null)
        {
             ApiResponse<SecurityRightsResponse> localVarResponse = SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV2WithHttpInfo(groupid, categoryid, lang, locale);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get permissions for a Security Group by category Operation to get permissions for a Security Group by category. To get Security Group IDs, use \&quot;Get all available Security Groups.\&quot; To get Security Group category IDs, use \&quot;Get all Security Group categories.\&quot;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupid">Specify the Security Group ID</param>
        /// <param name="categoryid">Specify the Security Group category ID</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsSecuritySecurityRightsResponse</returns>
        public ApiResponse< SecurityRightsResponse > SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV2WithHttpInfo (string groupid, string categoryid, string lang = null, string locale = null)
        {
            // verify the required parameter 'groupid' is set
            if (groupid == null)
                throw new ApiException(400, "Missing required parameter 'groupid' when calling SecurityApi->SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV2");
            // verify the required parameter 'categoryid' is set
            if (categoryid == null)
                throw new ApiException(400, "Missing required parameter 'categoryid' when calling SecurityApi->SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV2");

            var localVarPath = "/api/V2/getsecuritygrouprights/groupid/{groupid}/categoryid/{categoryid}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            string localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (groupid != null) localVarPathParams.Add("groupid", Configuration.ApiClient.ParameterToString(groupid)); // path parameter
            if (categoryid != null) localVarPathParams.Add("categoryid", Configuration.ApiClient.ParameterToString(categoryid)); // path parameter
            if (lang != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV2", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SecurityRightsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SecurityRightsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SecurityRightsResponse)));
        }

        /// <summary>
        /// Get permissions for a Security Group by category Operation to get permissions for a Security Group by category. To get Security Group IDs, use \&quot;Get all available Security Groups.\&quot; To get Security Group category IDs, use \&quot;Get all Security Group categories.\&quot;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupid">Specify the Security Group ID</param>
        /// <param name="categoryid">Specify the Security Group category ID</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsSecuritySecurityRightsResponse</returns>
        public async System.Threading.Tasks.Task<SecurityRightsResponse> SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV2Async (string groupid, string categoryid, string lang = null, string locale = null)
        {
             ApiResponse<SecurityRightsResponse> localVarResponse = await SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV2AsyncWithHttpInfo(groupid, categoryid, lang, locale);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get permissions for a Security Group by category Operation to get permissions for a Security Group by category. To get Security Group IDs, use \&quot;Get all available Security Groups.\&quot; To get Security Group category IDs, use \&quot;Get all Security Group categories.\&quot;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupid">Specify the Security Group ID</param>
        /// <param name="categoryid">Specify the Security Group category ID</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsSecuritySecurityRightsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SecurityRightsResponse>> SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV2AsyncWithHttpInfo (string groupid, string categoryid, string lang = null, string locale = null)
        {
            // verify the required parameter 'groupid' is set
            if (groupid == null)
                throw new ApiException(400, "Missing required parameter 'groupid' when calling SecurityApi->SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV2");
            // verify the required parameter 'categoryid' is set
            if (categoryid == null)
                throw new ApiException(400, "Missing required parameter 'categoryid' when calling SecurityApi->SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV2");

            var localVarPath = "/api/V2/getsecuritygrouprights/groupid/{groupid}/categoryid/{categoryid}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            string localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (groupid != null) localVarPathParams.Add("groupid", Configuration.ApiClient.ParameterToString(groupid)); // path parameter
            if (categoryid != null) localVarPathParams.Add("categoryid", Configuration.ApiClient.ParameterToString(categoryid)); // path parameter
            if (lang != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV2", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SecurityRightsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SecurityRightsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SecurityRightsResponse)));
        }

        /// <summary>
        /// Get permissions for a Security Group by category Operation to get permissions for a Security Group by category.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupname">Specify the Security Group name.</param>
        /// <param name="categoryname">Specify the Security Group category name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>List&lt;TrebuchetWebApiDataContractsSecurityRight&gt;</returns>
        public List<SecurityRight> SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV1 (string groupname, string categoryname, string lang = null, string locale = null)
        {
             ApiResponse<List<SecurityRight>> localVarResponse = SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV1WithHttpInfo(groupname, categoryname, lang, locale);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get permissions for a Security Group by category Operation to get permissions for a Security Group by category.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupname">Specify the Security Group name.</param>
        /// <param name="categoryname">Specify the Security Group category name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of List&lt;TrebuchetWebApiDataContractsSecurityRight&gt;</returns>
        public ApiResponse< List<SecurityRight> > SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV1WithHttpInfo (string groupname, string categoryname, string lang = null, string locale = null)
        {
            // verify the required parameter 'groupname' is set
            if (groupname == null)
                throw new ApiException(400, "Missing required parameter 'groupname' when calling SecurityApi->SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV1");
            // verify the required parameter 'categoryname' is set
            if (categoryname == null)
                throw new ApiException(400, "Missing required parameter 'categoryname' when calling SecurityApi->SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV1");

            var localVarPath = "/api/V1/getsecuritygrouprights/groupname/{groupname}/categoryname/{categoryname}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            string localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (groupname != null) localVarPathParams.Add("groupname", Configuration.ApiClient.ParameterToString(groupname)); // path parameter
            if (categoryname != null) localVarPathParams.Add("categoryname", Configuration.ApiClient.ParameterToString(categoryname)); // path parameter
            if (lang != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<SecurityRight>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<SecurityRight>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<SecurityRight>)));
        }

        /// <summary>
        /// Get permissions for a Security Group by category Operation to get permissions for a Security Group by category.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupname">Specify the Security Group name.</param>
        /// <param name="categoryname">Specify the Security Group category name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of List&lt;TrebuchetWebApiDataContractsSecurityRight&gt;</returns>
        public async System.Threading.Tasks.Task<List<SecurityRight>> SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV1Async (string groupname, string categoryname, string lang = null, string locale = null)
        {
             ApiResponse<List<SecurityRight>> localVarResponse = await SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV1AsyncWithHttpInfo(groupname, categoryname, lang, locale);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get permissions for a Security Group by category Operation to get permissions for a Security Group by category.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupname">Specify the Security Group name.</param>
        /// <param name="categoryname">Specify the Security Group category name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;TrebuchetWebApiDataContractsSecurityRight&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<SecurityRight>>> SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV1AsyncWithHttpInfo (string groupname, string categoryname, string lang = null, string locale = null)
        {
            // verify the required parameter 'groupname' is set
            if (groupname == null)
                throw new ApiException(400, "Missing required parameter 'groupname' when calling SecurityApi->SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV1");
            // verify the required parameter 'categoryname' is set
            if (categoryname == null)
                throw new ApiException(400, "Missing required parameter 'categoryname' when calling SecurityApi->SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV1");

            var localVarPath = "/api/V1/getsecuritygrouprights/groupname/{groupname}/categoryname/{categoryname}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            string localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (groupname != null) localVarPathParams.Add("groupname", Configuration.ApiClient.ParameterToString(groupname)); // path parameter
            if (categoryname != null) localVarPathParams.Add("categoryname", Configuration.ApiClient.ParameterToString(categoryname)); // path parameter
            if (lang != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<SecurityRight>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<SecurityRight>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<SecurityRight>)));
        }

        /// <summary>
        /// Get permissions for a Security Group by category Operation to get permissions for a Security Group by category.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupname">Specify the Security Group name.</param>
        /// <param name="categoryname">Specify the Security Group category name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsSecuritySecurityRightsResponse</returns>
        public SecurityRightsResponse SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV2 (string groupname, string categoryname, string lang = null, string locale = null)
        {
             ApiResponse<SecurityRightsResponse> localVarResponse = SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV2WithHttpInfo(groupname, categoryname, lang, locale);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get permissions for a Security Group by category Operation to get permissions for a Security Group by category.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupname">Specify the Security Group name.</param>
        /// <param name="categoryname">Specify the Security Group category name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsSecuritySecurityRightsResponse</returns>
        public ApiResponse< SecurityRightsResponse > SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV2WithHttpInfo (string groupname, string categoryname, string lang = null, string locale = null)
        {
            // verify the required parameter 'groupname' is set
            if (groupname == null)
                throw new ApiException(400, "Missing required parameter 'groupname' when calling SecurityApi->SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV2");
            // verify the required parameter 'categoryname' is set
            if (categoryname == null)
                throw new ApiException(400, "Missing required parameter 'categoryname' when calling SecurityApi->SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV2");

            var localVarPath = "/api/V2/getsecuritygrouprights/groupname/{groupname}/categoryname/{categoryname}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            string localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (groupname != null) localVarPathParams.Add("groupname", Configuration.ApiClient.ParameterToString(groupname)); // path parameter
            if (categoryname != null) localVarPathParams.Add("categoryname", Configuration.ApiClient.ParameterToString(categoryname)); // path parameter
            if (lang != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV2", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SecurityRightsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SecurityRightsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SecurityRightsResponse)));
        }

        /// <summary>
        /// Get permissions for a Security Group by category Operation to get permissions for a Security Group by category.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupname">Specify the Security Group name.</param>
        /// <param name="categoryname">Specify the Security Group category name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsSecuritySecurityRightsResponse</returns>
        public async System.Threading.Tasks.Task<SecurityRightsResponse> SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV2Async (string groupname, string categoryname, string lang = null, string locale = null)
        {
             ApiResponse<SecurityRightsResponse> localVarResponse = await SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV2AsyncWithHttpInfo(groupname, categoryname, lang, locale);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get permissions for a Security Group by category Operation to get permissions for a Security Group by category.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupname">Specify the Security Group name.</param>
        /// <param name="categoryname">Specify the Security Group category name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsSecuritySecurityRightsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SecurityRightsResponse>> SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV2AsyncWithHttpInfo (string groupname, string categoryname, string lang = null, string locale = null)
        {
            // verify the required parameter 'groupname' is set
            if (groupname == null)
                throw new ApiException(400, "Missing required parameter 'groupname' when calling SecurityApi->SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV2");
            // verify the required parameter 'categoryname' is set
            if (categoryname == null)
                throw new ApiException(400, "Missing required parameter 'categoryname' when calling SecurityApi->SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV2");

            var localVarPath = "/api/V2/getsecuritygrouprights/groupname/{groupname}/categoryname/{categoryname}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            string localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (groupname != null) localVarPathParams.Add("groupname", Configuration.ApiClient.ParameterToString(groupname)); // path parameter
            if (categoryname != null) localVarPathParams.Add("categoryname", Configuration.ApiClient.ParameterToString(categoryname)); // path parameter
            if (lang != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV2", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SecurityRightsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SecurityRightsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SecurityRightsResponse)));
        }

        /// <summary>
        /// Get current user&#39;s permissions by Security Group category by ID Operation to get permissions for the current user&#39;s Security Group by category. To get Security Group category IDs, use \&quot;Get all Security Group categories.\&quot;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryid">Specify the Security Group category ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>List&lt;TrebuchetWebApiDataContractsSecurityRight&gt;</returns>
        public List<SecurityRight> SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV1 (string categoryid, string lang = null, string locale = null)
        {
             ApiResponse<List<SecurityRight>> localVarResponse = SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV1WithHttpInfo(categoryid, lang, locale);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get current user&#39;s permissions by Security Group category by ID Operation to get permissions for the current user&#39;s Security Group by category. To get Security Group category IDs, use \&quot;Get all Security Group categories.\&quot;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryid">Specify the Security Group category ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of List&lt;TrebuchetWebApiDataContractsSecurityRight&gt;</returns>
        public ApiResponse< List<SecurityRight> > SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV1WithHttpInfo (string categoryid, string lang = null, string locale = null)
        {
            // verify the required parameter 'categoryid' is set
            if (categoryid == null)
                throw new ApiException(400, "Missing required parameter 'categoryid' when calling SecurityApi->SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV1");

            var localVarPath = "/api/V1/getsecuritygrouprightsforcurrentuserbycategoryid/categoryid/{categoryid}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            string localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (categoryid != null) localVarPathParams.Add("categoryid", Configuration.ApiClient.ParameterToString(categoryid)); // path parameter
            if (lang != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<SecurityRight>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<SecurityRight>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<SecurityRight>)));
        }

        /// <summary>
        /// Get current user&#39;s permissions by Security Group category by ID Operation to get permissions for the current user&#39;s Security Group by category. To get Security Group category IDs, use \&quot;Get all Security Group categories.\&quot;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryid">Specify the Security Group category ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of List&lt;TrebuchetWebApiDataContractsSecurityRight&gt;</returns>
        public async System.Threading.Tasks.Task<List<SecurityRight>> SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV1Async (string categoryid, string lang = null, string locale = null)
        {
             ApiResponse<List<SecurityRight>> localVarResponse = await SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV1AsyncWithHttpInfo(categoryid, lang, locale);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get current user&#39;s permissions by Security Group category by ID Operation to get permissions for the current user&#39;s Security Group by category. To get Security Group category IDs, use \&quot;Get all Security Group categories.\&quot;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryid">Specify the Security Group category ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;TrebuchetWebApiDataContractsSecurityRight&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<SecurityRight>>> SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV1AsyncWithHttpInfo (string categoryid, string lang = null, string locale = null)
        {
            // verify the required parameter 'categoryid' is set
            if (categoryid == null)
                throw new ApiException(400, "Missing required parameter 'categoryid' when calling SecurityApi->SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV1");

            var localVarPath = "/api/V1/getsecuritygrouprightsforcurrentuserbycategoryid/categoryid/{categoryid}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            string localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (categoryid != null) localVarPathParams.Add("categoryid", Configuration.ApiClient.ParameterToString(categoryid)); // path parameter
            if (lang != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<SecurityRight>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<SecurityRight>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<SecurityRight>)));
        }

        /// <summary>
        /// Get current user&#39;s permissions by Security Group category by ID Operation to get permissions for the current user&#39;s Security Group by category. To get Security Group category IDs, use \&quot;Get all Security Group categories.\&quot;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryid">Specify the Security Group category ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsSecuritySecurityRightsResponse</returns>
        public SecurityRightsResponse SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV2 (string categoryid, string lang = null, string locale = null)
        {
             ApiResponse<SecurityRightsResponse> localVarResponse = SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV2WithHttpInfo(categoryid, lang, locale);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get current user&#39;s permissions by Security Group category by ID Operation to get permissions for the current user&#39;s Security Group by category. To get Security Group category IDs, use \&quot;Get all Security Group categories.\&quot;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryid">Specify the Security Group category ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsSecuritySecurityRightsResponse</returns>
        public ApiResponse< SecurityRightsResponse > SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV2WithHttpInfo (string categoryid, string lang = null, string locale = null)
        {
            // verify the required parameter 'categoryid' is set
            if (categoryid == null)
                throw new ApiException(400, "Missing required parameter 'categoryid' when calling SecurityApi->SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV2");

            var localVarPath = "/api/V2/getsecuritygrouprightsforcurrentuserbycategoryid/categoryid/{categoryid}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            string localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (categoryid != null) localVarPathParams.Add("categoryid", Configuration.ApiClient.ParameterToString(categoryid)); // path parameter
            if (lang != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV2", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SecurityRightsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SecurityRightsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SecurityRightsResponse)));
        }

        /// <summary>
        /// Get current user&#39;s permissions by Security Group category by ID Operation to get permissions for the current user&#39;s Security Group by category. To get Security Group category IDs, use \&quot;Get all Security Group categories.\&quot;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryid">Specify the Security Group category ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsSecuritySecurityRightsResponse</returns>
        public async System.Threading.Tasks.Task<SecurityRightsResponse> SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV2Async (string categoryid, string lang = null, string locale = null)
        {
             ApiResponse<SecurityRightsResponse> localVarResponse = await SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV2AsyncWithHttpInfo(categoryid, lang, locale);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get current user&#39;s permissions by Security Group category by ID Operation to get permissions for the current user&#39;s Security Group by category. To get Security Group category IDs, use \&quot;Get all Security Group categories.\&quot;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryid">Specify the Security Group category ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsSecuritySecurityRightsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SecurityRightsResponse>> SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV2AsyncWithHttpInfo (string categoryid, string lang = null, string locale = null)
        {
            // verify the required parameter 'categoryid' is set
            if (categoryid == null)
                throw new ApiException(400, "Missing required parameter 'categoryid' when calling SecurityApi->SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV2");

            var localVarPath = "/api/V2/getsecuritygrouprightsforcurrentuserbycategoryid/categoryid/{categoryid}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            string localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (categoryid != null) localVarPathParams.Add("categoryid", Configuration.ApiClient.ParameterToString(categoryid)); // path parameter
            if (lang != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV2", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SecurityRightsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SecurityRightsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SecurityRightsResponse)));
        }

        /// <summary>
        /// Get current user&#39;s permissions by Security Group category by name Operation to get permissions for the current user&#39;s Security Group by category.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryname">Specify the Security Group category name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>List&lt;TrebuchetWebApiDataContractsSecurityRight&gt;</returns>
        public List<SecurityRight> SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV1 (string categoryname, string lang = null, string locale = null)
        {
             ApiResponse<List<SecurityRight>> localVarResponse = SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV1WithHttpInfo(categoryname, lang, locale);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get current user&#39;s permissions by Security Group category by name Operation to get permissions for the current user&#39;s Security Group by category.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryname">Specify the Security Group category name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of List&lt;TrebuchetWebApiDataContractsSecurityRight&gt;</returns>
        public ApiResponse< List<SecurityRight> > SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV1WithHttpInfo (string categoryname, string lang = null, string locale = null)
        {
            // verify the required parameter 'categoryname' is set
            if (categoryname == null)
                throw new ApiException(400, "Missing required parameter 'categoryname' when calling SecurityApi->SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV1");

            var localVarPath = "/api/V1/getsecuritygrouprightsforcurrentuserbycategoryname/categoryname/{categoryname}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            string localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (categoryname != null) localVarPathParams.Add("categoryname", Configuration.ApiClient.ParameterToString(categoryname)); // path parameter
            if (lang != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<SecurityRight>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<SecurityRight>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<SecurityRight>)));
        }

        /// <summary>
        /// Get current user&#39;s permissions by Security Group category by name Operation to get permissions for the current user&#39;s Security Group by category.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryname">Specify the Security Group category name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of List&lt;TrebuchetWebApiDataContractsSecurityRight&gt;</returns>
        public async System.Threading.Tasks.Task<List<SecurityRight>> SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV1Async (string categoryname, string lang = null, string locale = null)
        {
             ApiResponse<List<SecurityRight>> localVarResponse = await SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV1AsyncWithHttpInfo(categoryname, lang, locale);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get current user&#39;s permissions by Security Group category by name Operation to get permissions for the current user&#39;s Security Group by category.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryname">Specify the Security Group category name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;TrebuchetWebApiDataContractsSecurityRight&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<SecurityRight>>> SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV1AsyncWithHttpInfo (string categoryname, string lang = null, string locale = null)
        {
            // verify the required parameter 'categoryname' is set
            if (categoryname == null)
                throw new ApiException(400, "Missing required parameter 'categoryname' when calling SecurityApi->SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV1");

            var localVarPath = "/api/V1/getsecuritygrouprightsforcurrentuserbycategoryname/categoryname/{categoryname}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            string localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (categoryname != null) localVarPathParams.Add("categoryname", Configuration.ApiClient.ParameterToString(categoryname)); // path parameter
            if (lang != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<SecurityRight>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<SecurityRight>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<SecurityRight>)));
        }

        /// <summary>
        /// Get current user&#39;s permissions by Security Group category by name Operation to get permissions for the current user&#39;s Security Group by category.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryname">Specify the Security Group category name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsSecuritySecurityRightsResponse</returns>
        public SecurityRightsResponse SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV2 (string categoryname, string lang = null, string locale = null)
        {
             ApiResponse<SecurityRightsResponse> localVarResponse = SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV2WithHttpInfo(categoryname, lang, locale);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get current user&#39;s permissions by Security Group category by name Operation to get permissions for the current user&#39;s Security Group by category.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryname">Specify the Security Group category name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsSecuritySecurityRightsResponse</returns>
        public ApiResponse< SecurityRightsResponse > SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV2WithHttpInfo (string categoryname, string lang = null, string locale = null)
        {
            // verify the required parameter 'categoryname' is set
            if (categoryname == null)
                throw new ApiException(400, "Missing required parameter 'categoryname' when calling SecurityApi->SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV2");

            var localVarPath = "/api/V2/getsecuritygrouprightsforcurrentuserbycategoryname/categoryname/{categoryname}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            string localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (categoryname != null) localVarPathParams.Add("categoryname", Configuration.ApiClient.ParameterToString(categoryname)); // path parameter
            if (lang != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV2", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SecurityRightsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SecurityRightsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SecurityRightsResponse)));
        }

        /// <summary>
        /// Get current user&#39;s permissions by Security Group category by name Operation to get permissions for the current user&#39;s Security Group by category.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryname">Specify the Security Group category name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsSecuritySecurityRightsResponse</returns>
        public async System.Threading.Tasks.Task<SecurityRightsResponse> SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV2Async (string categoryname, string lang = null, string locale = null)
        {
             ApiResponse<SecurityRightsResponse> localVarResponse = await SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV2AsyncWithHttpInfo(categoryname, lang, locale);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get current user&#39;s permissions by Security Group category by name Operation to get permissions for the current user&#39;s Security Group by category.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryname">Specify the Security Group category name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsSecuritySecurityRightsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SecurityRightsResponse>> SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV2AsyncWithHttpInfo (string categoryname, string lang = null, string locale = null)
        {
            // verify the required parameter 'categoryname' is set
            if (categoryname == null)
                throw new ApiException(400, "Missing required parameter 'categoryname' when calling SecurityApi->SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV2");

            var localVarPath = "/api/V2/getsecuritygrouprightsforcurrentuserbycategoryname/categoryname/{categoryname}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            string localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (categoryname != null) localVarPathParams.Add("categoryname", Configuration.ApiClient.ParameterToString(categoryname)); // path parameter
            if (lang != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV2", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SecurityRightsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SecurityRightsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SecurityRightsResponse)));
        }

        /// <summary>
        /// Get all available Security Groups Operation to get IDs, names, and descriptions for all available Security Groups.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsSecuritySecurityGroupResponse</returns>
        public SecurityGroupResponse SecurityGetSecurityGroupsV1 (string lang = null, string locale = null)
        {
             ApiResponse<SecurityGroupResponse> localVarResponse = SecurityGetSecurityGroupsV1WithHttpInfo(lang, locale);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all available Security Groups Operation to get IDs, names, and descriptions for all available Security Groups.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsSecuritySecurityGroupResponse</returns>
        public ApiResponse< SecurityGroupResponse > SecurityGetSecurityGroupsV1WithHttpInfo (string lang = null, string locale = null)
        {

            var localVarPath = "/api/V1/getsecuritygroups";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            string localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (lang != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SecurityGetSecurityGroupsV1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SecurityGroupResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SecurityGroupResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SecurityGroupResponse)));
        }

        /// <summary>
        /// Get all available Security Groups Operation to get IDs, names, and descriptions for all available Security Groups.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsSecuritySecurityGroupResponse</returns>
        public async System.Threading.Tasks.Task<SecurityGroupResponse> SecurityGetSecurityGroupsV1Async (string lang = null, string locale = null)
        {
             ApiResponse<SecurityGroupResponse> localVarResponse = await SecurityGetSecurityGroupsV1AsyncWithHttpInfo(lang, locale);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all available Security Groups Operation to get IDs, names, and descriptions for all available Security Groups.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsSecuritySecurityGroupResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SecurityGroupResponse>> SecurityGetSecurityGroupsV1AsyncWithHttpInfo (string lang = null, string locale = null)
        {

            var localVarPath = "/api/V1/getsecuritygroups";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            string localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (lang != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SecurityGetSecurityGroupsV1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SecurityGroupResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SecurityGroupResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SecurityGroupResponse)));
        }

        /// <summary>
        /// Get all available Security Groups Operation to get IDs, names, and descriptions for all available Security Groups.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsSecuritySecurityGroupV2Response</returns>
        public SecurityGroupV2Response SecurityGetSecurityGroupsV2 (string lang = null, string locale = null)
        {
             ApiResponse<SecurityGroupV2Response> localVarResponse = SecurityGetSecurityGroupsV2WithHttpInfo(lang, locale);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all available Security Groups Operation to get IDs, names, and descriptions for all available Security Groups.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsSecuritySecurityGroupV2Response</returns>
        public ApiResponse< SecurityGroupV2Response > SecurityGetSecurityGroupsV2WithHttpInfo (string lang = null, string locale = null)
        {

            var localVarPath = "/api/V2/getsecuritygroups";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            string localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (lang != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SecurityGetSecurityGroupsV2", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SecurityGroupV2Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SecurityGroupV2Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SecurityGroupV2Response)));
        }

        /// <summary>
        /// Get all available Security Groups Operation to get IDs, names, and descriptions for all available Security Groups.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsSecuritySecurityGroupV2Response</returns>
        public async System.Threading.Tasks.Task<SecurityGroupV2Response> SecurityGetSecurityGroupsV2Async (string lang = null, string locale = null)
        {
             ApiResponse<SecurityGroupV2Response> localVarResponse = await SecurityGetSecurityGroupsV2AsyncWithHttpInfo(lang, locale);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all available Security Groups Operation to get IDs, names, and descriptions for all available Security Groups.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsSecuritySecurityGroupV2Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SecurityGroupV2Response>> SecurityGetSecurityGroupsV2AsyncWithHttpInfo (string lang = null, string locale = null)
        {

            var localVarPath = "/api/V2/getsecuritygroups";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            string localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (lang != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SecurityGetSecurityGroupsV2", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SecurityGroupV2Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SecurityGroupV2Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SecurityGroupV2Response)));
        }

        /// <summary>
        /// Get users in a Security Group Operation to get the users in a specified Security Group. Use \&quot;Get all available Security Groups\&quot; to get Security Group record IDs. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupid">Specify the Security Group ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>List&lt;TrebuchetWebApiDataContractsUsersUser&gt;</returns>
        public List<User> SecurityGetUsersInSecurityGroupV1 (string groupid, string lang = null, string locale = null)
        {
             ApiResponse<List<User>> localVarResponse = SecurityGetUsersInSecurityGroupV1WithHttpInfo(groupid, lang, locale);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get users in a Security Group Operation to get the users in a specified Security Group. Use \&quot;Get all available Security Groups\&quot; to get Security Group record IDs. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupid">Specify the Security Group ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of List&lt;TrebuchetWebApiDataContractsUsersUser&gt;</returns>
        public ApiResponse< List<User> > SecurityGetUsersInSecurityGroupV1WithHttpInfo (string groupid, string lang = null, string locale = null)
        {
            // verify the required parameter 'groupid' is set
            if (groupid == null)
                throw new ApiException(400, "Missing required parameter 'groupid' when calling SecurityApi->SecurityGetUsersInSecurityGroupV1");

            var localVarPath = "/api/V1/getusersinsecuritygroup/groupid/{groupid}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            string localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (groupid != null) localVarPathParams.Add("groupid", Configuration.ApiClient.ParameterToString(groupid)); // path parameter
            if (lang != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SecurityGetUsersInSecurityGroupV1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<User>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<User>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<User>)));
        }

        /// <summary>
        /// Get users in a Security Group Operation to get the users in a specified Security Group. Use \&quot;Get all available Security Groups\&quot; to get Security Group record IDs. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupid">Specify the Security Group ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of List&lt;TrebuchetWebApiDataContractsUsersUser&gt;</returns>
        public async System.Threading.Tasks.Task<List<User>> SecurityGetUsersInSecurityGroupV1Async (string groupid, string lang = null, string locale = null)
        {
             ApiResponse<List<User>> localVarResponse = await SecurityGetUsersInSecurityGroupV1AsyncWithHttpInfo(groupid, lang, locale);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get users in a Security Group Operation to get the users in a specified Security Group. Use \&quot;Get all available Security Groups\&quot; to get Security Group record IDs. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupid">Specify the Security Group ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;TrebuchetWebApiDataContractsUsersUser&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<User>>> SecurityGetUsersInSecurityGroupV1AsyncWithHttpInfo (string groupid, string lang = null, string locale = null)
        {
            // verify the required parameter 'groupid' is set
            if (groupid == null)
                throw new ApiException(400, "Missing required parameter 'groupid' when calling SecurityApi->SecurityGetUsersInSecurityGroupV1");

            var localVarPath = "/api/V1/getusersinsecuritygroup/groupid/{groupid}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            string localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (groupid != null) localVarPathParams.Add("groupid", Configuration.ApiClient.ParameterToString(groupid)); // path parameter
            if (lang != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SecurityGetUsersInSecurityGroupV1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<User>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<User>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<User>)));
        }

        /// <summary>
        /// Get users in a Security Group Operation to get the users in a specified Security Group. Use \&quot;Get all available Security Groups\&quot; to get Security Group record IDs. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupid">Specify the Security Group ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsUsersUserReadV2Response</returns>
        public UserReadV2Response SecurityGetUsersInSecurityGroupV2 (string groupid, string lang = null, string locale = null)
        {
             ApiResponse<UserReadV2Response> localVarResponse = SecurityGetUsersInSecurityGroupV2WithHttpInfo(groupid, lang, locale);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get users in a Security Group Operation to get the users in a specified Security Group. Use \&quot;Get all available Security Groups\&quot; to get Security Group record IDs. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupid">Specify the Security Group ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsUsersUserReadV2Response</returns>
        public ApiResponse< UserReadV2Response > SecurityGetUsersInSecurityGroupV2WithHttpInfo (string groupid, string lang = null, string locale = null)
        {
            // verify the required parameter 'groupid' is set
            if (groupid == null)
                throw new ApiException(400, "Missing required parameter 'groupid' when calling SecurityApi->SecurityGetUsersInSecurityGroupV2");

            var localVarPath = "/api/V2/getusersinsecuritygroup/groupid/{groupid}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            string localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (groupid != null) localVarPathParams.Add("groupid", Configuration.ApiClient.ParameterToString(groupid)); // path parameter
            if (lang != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SecurityGetUsersInSecurityGroupV2", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<UserReadV2Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserReadV2Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserReadV2Response)));
        }

        /// <summary>
        /// Get users in a Security Group Operation to get the users in a specified Security Group. Use \&quot;Get all available Security Groups\&quot; to get Security Group record IDs. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupid">Specify the Security Group ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsUsersUserReadV2Response</returns>
        public async System.Threading.Tasks.Task<UserReadV2Response> SecurityGetUsersInSecurityGroupV2Async (string groupid, string lang = null, string locale = null)
        {
             ApiResponse<UserReadV2Response> localVarResponse = await SecurityGetUsersInSecurityGroupV2AsyncWithHttpInfo(groupid, lang, locale);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get users in a Security Group Operation to get the users in a specified Security Group. Use \&quot;Get all available Security Groups\&quot; to get Security Group record IDs. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupid">Specify the Security Group ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsUsersUserReadV2Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserReadV2Response>> SecurityGetUsersInSecurityGroupV2AsyncWithHttpInfo (string groupid, string lang = null, string locale = null)
        {
            // verify the required parameter 'groupid' is set
            if (groupid == null)
                throw new ApiException(400, "Missing required parameter 'groupid' when calling SecurityApi->SecurityGetUsersInSecurityGroupV2");

            var localVarPath = "/api/V2/getusersinsecuritygroup/groupid/{groupid}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            string localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (groupid != null) localVarPathParams.Add("groupid", Configuration.ApiClient.ParameterToString(groupid)); // path parameter
            if (lang != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SecurityGetUsersInSecurityGroupV2", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<UserReadV2Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserReadV2Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserReadV2Response)));
        }

    }
}
