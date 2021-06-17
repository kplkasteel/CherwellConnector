
using CherwellConnector.Interface;

namespace CherwellConnector.Api
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Client;
    using Model;

    using RestSharp;

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ServiceApi :BaseApi, IServiceApi
    {
        #region Variables & Properties
        
        private static ServiceApi _instance;

        private static readonly object Padlock = new();
        
        public static ServiceApi Instance
        {
            get
            {
                lock (Padlock)
                {
                    return _instance ??= new ServiceApi();
                }
            }
            set => _instance = value;
        }
        
        #endregion

        #region Contructors

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
            Configuration = configuration ?? Configuration.Default;

            ExceptionFactory = Configuration.DefaultExceptionFactory;
        }

        #endregion

        #region ServiceGetServiceInfoV1

         /// <summary>
        /// Get information about the REST Api and CSM Operation to get information about the REST API and CSM.  The response is latest REST API operation version, CSM version, and CSM system date and time.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ServiceInfoResponse</returns>
        public ServiceInfoResponse ServiceGetServiceInfoV1 (string lang = null, string locale = null)
        {
             return ServiceGetServiceInfoV1WithHttpInfo(lang, locale).Data;
        }

        /// <summary>
        /// Get information about the REST Api and CSM Operation to get information about the REST API and CSM.  The response is latest REST API operation version, CSM version, and CSM system date and time.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of ServiceInfoResponse</returns>
        private ApiResponse< ServiceInfoResponse > ServiceGetServiceInfoV1WithHttpInfo (string lang = null, string locale = null)
        {

            const string varPath = "/api/V1/serviceinfo";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();

            // to determine the Content-Type header
            var localVarHttpContentTypes = Array.Empty<string>();
            var localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
            
            var localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(LocalVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (lang != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter


            // make the HTTP request
            var localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(varPath,
                Method.GET, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int) localVarResponse.StatusCode;

            var exception = ExceptionFactory?.Invoke("ServiceGetServiceInfoV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<ServiceInfoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (ServiceInfoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ServiceInfoResponse)));
        }

        #endregion

        #region ServiceLogoutUserV1

        /// <summary>
        /// Log out user by token Operation that logs out the user referenced in the authentication token.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns></returns>
        public object ServiceLogoutUserV1 (string lang = null, string locale = null)
        {
             return ServiceLogoutUserV1WithHttpInfo(lang, locale).Data;
        }

        /// <summary>
        /// Log out user by token Operation that logs out the user referenced in the authentication token.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        private ApiResponse<object> ServiceLogoutUserV1WithHttpInfo (string lang = null, string locale = null)
        {

            var localVarPath = $"/api/V1/logout";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();

            // to determine the Content-Type header
            var localVarHttpContentTypes = Array.Empty<string>();
            var localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            var localVarHttpHeaderAccepts = Array.Empty<string>();
            var localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            
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
            var localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int) localVarResponse.StatusCode;

            var exception = ExceptionFactory?.Invoke("ServiceLogoutUserV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                null);
        }

        #endregion

        #region MyRegion

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
        /// <returns>TokenResponse</returns>
        public TokenResponse ServiceToken (string grantType, string clientId, string clientSecret = null, string username = null, string password = null, string refreshToken = null, string authMode = null, string siteName = null)
        {
             return ServiceTokenWithHttpInfo(grantType, clientId, clientSecret, username, password, refreshToken, authMode, siteName).Data;
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
        /// <returns>ApiResponse of TokenResponse</returns>
        private ApiResponse< TokenResponse > ServiceTokenWithHttpInfo (string grantType, string clientId, string clientSecret = null, string username = null, string password = null, string refreshToken = null, string authMode = null, string siteName = null)
        {
            // verify the required parameter 'grantType' is set
            if (grantType == null)
                throw new ApiException(400, "Missing required parameter 'grantType' when calling ServiceApi->ServiceToken");
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling ServiceApi->ServiceToken");

            const string varPath = "/token";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();

            // to determine the Content-Type header
            var localVarHttpContentTypes = new[] {
                "application/x-www-form-urlencoded"
            };
            var localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            var localVarHttpHeaderAccepts = Array.Empty<string>();
            var localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (authMode != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "auth_mode", authMode)); // query parameter
            if (siteName != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "site_name", siteName)); // query parameter
            localVarFormParams.Add("grant_type", Configuration.ApiClient.ParameterToString(grantType)); // form parameter
            localVarFormParams.Add("client_id", Configuration.ApiClient.ParameterToString(clientId)); // form parameter
            if (clientSecret != null) localVarFormParams.Add("client_secret", Configuration.ApiClient.ParameterToString(clientSecret)); // form parameter
            if (username != null) localVarFormParams.Add("username", Configuration.ApiClient.ParameterToString(username)); // form parameter
            if (password != null) localVarFormParams.Add("password", Configuration.ApiClient.ParameterToString(password)); // form parameter
            if (refreshToken != null) localVarFormParams.Add("refresh_token", Configuration.ApiClient.ParameterToString(refreshToken)); // form parameter


            // make the HTTP request
            var localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(varPath,
                Method.POST, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int) localVarResponse.StatusCode;

            var exception = ExceptionFactory?.Invoke("ServiceToken", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<TokenResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (TokenResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TokenResponse)));
        }
        
        #endregion

    }
}
