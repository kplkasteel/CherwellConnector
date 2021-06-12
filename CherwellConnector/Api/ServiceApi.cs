
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
    public partial class ServiceApi : IServiceApi
    {
        private ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ServiceApi(string basePath)
        {
            Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ServiceApi(Configuration configuration = null)
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
        /// Get information about the REST Api and CSM Operation to get information about the REST API and CSM.  The response is latest REST API operation version, CSM version, and CSM system date and time.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsCoreServiceInfoResponse</returns>
        public ServiceInfoResponse ServiceGetServiceInfoV1 (string lang = null, string locale = null)
        {
             ApiResponse<ServiceInfoResponse> localVarResponse = ServiceGetServiceInfoV1WithHttpInfo(lang, locale);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get information about the REST Api and CSM Operation to get information about the REST API and CSM.  The response is latest REST API operation version, CSM version, and CSM system date and time.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsCoreServiceInfoResponse</returns>
        public ApiResponse< ServiceInfoResponse > ServiceGetServiceInfoV1WithHttpInfo (string lang = null, string locale = null)
        {

            var localVarPath = "/api/V1/serviceinfo";
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


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ServiceGetServiceInfoV1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ServiceInfoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ServiceInfoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ServiceInfoResponse)));
        }

        /// <summary>
        /// Get information about the REST Api and CSM Operation to get information about the REST API and CSM.  The response is latest REST API operation version, CSM version, and CSM system date and time.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsCoreServiceInfoResponse</returns>
        public async System.Threading.Tasks.Task<ServiceInfoResponse> ServiceGetServiceInfoV1Async (string lang = null, string locale = null)
        {
             ApiResponse<ServiceInfoResponse> localVarResponse = await ServiceGetServiceInfoV1AsyncWithHttpInfo(lang, locale);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get information about the REST Api and CSM Operation to get information about the REST API and CSM.  The response is latest REST API operation version, CSM version, and CSM system date and time.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsCoreServiceInfoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ServiceInfoResponse>> ServiceGetServiceInfoV1AsyncWithHttpInfo (string lang = null, string locale = null)
        {

            var localVarPath = "/api/V1/serviceinfo";
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


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ServiceGetServiceInfoV1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ServiceInfoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ServiceInfoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ServiceInfoResponse)));
        }

        /// <summary>
        /// Log out user by token Operation that logs out the user referenced in the authentication token.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns></returns>
        public void ServiceLogoutUserV1 (string lang = null, string locale = null)
        {
             ServiceLogoutUserV1WithHttpInfo(lang, locale);
        }

        /// <summary>
        /// Log out user by token Operation that logs out the user referenced in the authentication token.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<object> ServiceLogoutUserV1WithHttpInfo (string lang = null, string locale = null)
        {

            var localVarPath = "/api/V1/logout";
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
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ServiceLogoutUserV1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Log out user by token Operation that logs out the user referenced in the authentication token.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ServiceLogoutUserV1Async (string lang = null, string locale = null)
        {
             await ServiceLogoutUserV1AsyncWithHttpInfo(lang, locale);

        }

        /// <summary>
        /// Log out user by token Operation that logs out the user referenced in the authentication token.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<object>> ServiceLogoutUserV1AsyncWithHttpInfo (string lang = null, string locale = null)
        {

            var localVarPath = "/api/V1/logout";
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
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ServiceLogoutUserV1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Get an access token Operation to request an access token for one of the following authentication modes. Or, you can request an access token using a refresh token. An API client key is required in both cases, and the authentication mode you use must be the mode used by the CSM Browser Client. &lt;/br&gt;  Internal - Use a CSM username and password. If no other mode is specified, Internal mode is used.&lt;/br&gt;  Windows - Uses the server variable LOGON_USER to attempt to find a CSM user.  You can also use domain\\username and password.&lt;/br&gt;  LDAP - Uses the LDAP settings configured for CSM and the server variable LOGON_USER to attempt to find a CSM user. You can also use domain\\username and password.&lt;/br&gt;  SAML - Uses the SAML settings configured for CSM to validate credentials and find the CSM user.&lt;/br&gt;  Auto - Uses the enabled authentication types configured for CSM.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="grantType">The type of grant being requested: password or refresh_token.</param>
        /// <param name="clientId">The API client key for the client making the token request.</param>
        /// <param name="clientSecret">The API client secret for the native client making the token request.  This is only required for native clients. (optional)</param>
        /// <param name="username">Specify the login ID for the CSM user who will be granted the access token.  (optional)</param>
        /// <param name="password">Specify the password assigned to the login ID. (optional)</param>
        /// <param name="refreshToken">Specify the refresh token used to grant another access token. (optional)</param>
        /// <param name="authMode">Specify the Authentication Mode to use for requesting an access token. (optional)</param>
        /// <param name="siteName">If for portal specify the Site name to use for requesting an access token. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsSecurityTokenResponse</returns>
        public TokenResponse ServiceToken (string grantType, string clientId, string clientSecret = null, string username = null, string password = null, string refreshToken = null, string authMode = null, string siteName = null)
        {
             ApiResponse<TokenResponse> localVarResponse = ServiceTokenWithHttpInfo(grantType, clientId, clientSecret, username, password, refreshToken, authMode, siteName);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an access token Operation to request an access token for one of the following authentication modes. Or, you can request an access token using a refresh token. An API client key is required in both cases, and the authentication mode you use must be the mode used by the CSM Browser Client. &lt;/br&gt;  Internal - Use a CSM username and password. If no other mode is specified, Internal mode is used.&lt;/br&gt;  Windows - Uses the server variable LOGON_USER to attempt to find a CSM user.  You can also use domain\\username and password.&lt;/br&gt;  LDAP - Uses the LDAP settings configured for CSM and the server variable LOGON_USER to attempt to find a CSM user. You can also use domain\\username and password.&lt;/br&gt;  SAML - Uses the SAML settings configured for CSM to validate credentials and find the CSM user.&lt;/br&gt;  Auto - Uses the enabled authentication types configured for CSM.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="grantType">The type of grant being requested: password or refresh_token.</param>
        /// <param name="clientId">The API client key for the client making the token request.</param>
        /// <param name="clientSecret">The API client secret for the native client making the token request.  This is only required for native clients. (optional)</param>
        /// <param name="username">Specify the login ID for the CSM user who will be granted the access token.  (optional)</param>
        /// <param name="password">Specify the password assigned to the login ID. (optional)</param>
        /// <param name="refreshToken">Specify the refresh token used to grant another access token. (optional)</param>
        /// <param name="authMode">Specify the Authentication Mode to use for requesting an access token. (optional)</param>
        /// <param name="siteName">If for portal specify the Site name to use for requesting an access token. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsSecurityTokenResponse</returns>
        public ApiResponse< TokenResponse > ServiceTokenWithHttpInfo (string grantType, string clientId, string clientSecret = null, string username = null, string password = null, string refreshToken = null, string authMode = null, string siteName = null)
        {
            // verify the required parameter 'grantType' is set
            if (grantType == null)
                throw new ApiException(400, "Missing required parameter 'grantType' when calling ServiceApi->ServiceToken");
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling ServiceApi->ServiceToken");

            var localVarPath = "/token";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
                "application/x-www-form-urlencoded"
            };
            string localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
            };
            string localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (authMode != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "auth_mode", authMode)); // query parameter
            if (siteName != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "site_name", siteName)); // query parameter
            if (grantType != null) localVarFormParams.Add("grant_type", Configuration.ApiClient.ParameterToString(grantType)); // form parameter
            if (clientId != null) localVarFormParams.Add("client_id", Configuration.ApiClient.ParameterToString(clientId)); // form parameter
            if (clientSecret != null) localVarFormParams.Add("client_secret", Configuration.ApiClient.ParameterToString(clientSecret)); // form parameter
            if (username != null) localVarFormParams.Add("username", Configuration.ApiClient.ParameterToString(username)); // form parameter
            if (password != null) localVarFormParams.Add("password", Configuration.ApiClient.ParameterToString(password)); // form parameter
            if (refreshToken != null) localVarFormParams.Add("refresh_token", Configuration.ApiClient.ParameterToString(refreshToken)); // form parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ServiceToken", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TokenResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TokenResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TokenResponse)));
        }

        /// <summary>
        /// Get an access token Operation to request an access token for one of the following authentication modes. Or, you can request an access token using a refresh token. An API client key is required in both cases, and the authentication mode you use must be the mode used by the CSM Browser Client. &lt;/br&gt;  Internal - Use a CSM username and password. If no other mode is specified, Internal mode is used.&lt;/br&gt;  Windows - Uses the server variable LOGON_USER to attempt to find a CSM user.  You can also use domain\\username and password.&lt;/br&gt;  LDAP - Uses the LDAP settings configured for CSM and the server variable LOGON_USER to attempt to find a CSM user. You can also use domain\\username and password.&lt;/br&gt;  SAML - Uses the SAML settings configured for CSM to validate credentials and find the CSM user.&lt;/br&gt;  Auto - Uses the enabled authentication types configured for CSM.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="grantType">The type of grant being requested: password or refresh_token.</param>
        /// <param name="clientId">The API client key for the client making the token request.</param>
        /// <param name="clientSecret">The API client secret for the native client making the token request.  This is only required for native clients. (optional)</param>
        /// <param name="username">Specify the login ID for the CSM user who will be granted the access token.  (optional)</param>
        /// <param name="password">Specify the password assigned to the login ID. (optional)</param>
        /// <param name="refreshToken">Specify the refresh token used to grant another access token. (optional)</param>
        /// <param name="authMode">Specify the Authentication Mode to use for requesting an access token. (optional)</param>
        /// <param name="siteName">If for portal specify the Site name to use for requesting an access token. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsSecurityTokenResponse</returns>
        public async System.Threading.Tasks.Task<TokenResponse> ServiceTokenAsync (string grantType, string clientId, string clientSecret = null, string username = null, string password = null, string refreshToken = null, string authMode = null, string siteName = null)
        {
             ApiResponse<TokenResponse> localVarResponse = await ServiceTokenAsyncWithHttpInfo(grantType, clientId, clientSecret, username, password, refreshToken, authMode, siteName);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an access token Operation to request an access token for one of the following authentication modes. Or, you can request an access token using a refresh token. An API client key is required in both cases, and the authentication mode you use must be the mode used by the CSM Browser Client. &lt;/br&gt;  Internal - Use a CSM username and password. If no other mode is specified, Internal mode is used.&lt;/br&gt;  Windows - Uses the server variable LOGON_USER to attempt to find a CSM user.  You can also use domain\\username and password.&lt;/br&gt;  LDAP - Uses the LDAP settings configured for CSM and the server variable LOGON_USER to attempt to find a CSM user. You can also use domain\\username and password.&lt;/br&gt;  SAML - Uses the SAML settings configured for CSM to validate credentials and find the CSM user.&lt;/br&gt;  Auto - Uses the enabled authentication types configured for CSM.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="grantType">The type of grant being requested: password or refresh_token.</param>
        /// <param name="clientId">The API client key for the client making the token request.</param>
        /// <param name="clientSecret">The API client secret for the native client making the token request.  This is only required for native clients. (optional)</param>
        /// <param name="username">Specify the login ID for the CSM user who will be granted the access token.  (optional)</param>
        /// <param name="password">Specify the password assigned to the login ID. (optional)</param>
        /// <param name="refreshToken">Specify the refresh token used to grant another access token. (optional)</param>
        /// <param name="authMode">Specify the Authentication Mode to use for requesting an access token. (optional)</param>
        /// <param name="siteName">If for portal specify the Site name to use for requesting an access token. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsSecurityTokenResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TokenResponse>> ServiceTokenAsyncWithHttpInfo (string grantType, string clientId, string clientSecret = null, string username = null, string password = null, string refreshToken = null, string authMode = null, string siteName = null)
        {
            // verify the required parameter 'grantType' is set
            if (grantType == null)
                throw new ApiException(400, "Missing required parameter 'grantType' when calling ServiceApi->ServiceToken");
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling ServiceApi->ServiceToken");

            var localVarPath = "/token";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
                "application/x-www-form-urlencoded"
            };
            string localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
            };
            string localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (authMode != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "auth_mode", authMode)); // query parameter
            if (siteName != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "site_name", siteName)); // query parameter
            if (grantType != null) localVarFormParams.Add("grant_type", Configuration.ApiClient.ParameterToString(grantType)); // form parameter
            if (clientId != null) localVarFormParams.Add("client_id", Configuration.ApiClient.ParameterToString(clientId)); // form parameter
            if (clientSecret != null) localVarFormParams.Add("client_secret", Configuration.ApiClient.ParameterToString(clientSecret)); // form parameter
            if (username != null) localVarFormParams.Add("username", Configuration.ApiClient.ParameterToString(username)); // form parameter
            if (password != null) localVarFormParams.Add("password", Configuration.ApiClient.ParameterToString(password)); // form parameter
            if (refreshToken != null) localVarFormParams.Add("refresh_token", Configuration.ApiClient.ParameterToString(refreshToken)); // form parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ServiceToken", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TokenResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TokenResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TokenResponse)));
        }

    }
}
