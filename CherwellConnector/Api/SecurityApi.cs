
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
    public class SecurityApi :BaseApi, ISecurityApi
    {
        #region Variables & Properties
        
        private static SecurityApi _instance;

        private static readonly object Padlock = new();
        
        public static SecurityApi Instance
        {
            get
            {
                lock (Padlock)
                {
                    return _instance ??= new SecurityApi();
                }
            }
            set => _instance = value;
        }
        
        #endregion

        #region Constructors

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
            Configuration = configuration ?? Configuration.Default;

            ExceptionFactory = Configuration.DefaultExceptionFactory;
        }

        #endregion

        #region SecurityGetClientSecuritySettingsV1

        /// <summary>
        /// Get client security settings Operation to get the configured client security settings. Returns true if internal, Windows, LDAP, or SAML are enabled as authentication methods.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationtype">The type of CSM application to return security settings for.  Application type is Desktop Client, Browser Client, Browser Portal or Cherwell Mobile.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ClientSecuritySettingsResponse</returns>
        public ClientSecuritySettingsResponse SecurityGetClientSecuritySettingsV1 (string applicationtype, string lang = null, string locale = null)
        {
             return SecurityGetClientSecuritySettingsV1WithHttpInfo(applicationtype, lang, locale).Data;
        }

        /// <summary>
        /// Get client security settings Operation to get the configured client security settings. Returns true if internal, Windows, LDAP, or SAML are enabled as authentication methods.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationtype">The type of CSM application to return security settings for.  Application type is Desktop Client, Browser Client, Browser Portal or Cherwell Mobile.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of ClientSecuritySettingsResponse</returns>
        private ApiResponse< ClientSecuritySettingsResponse > SecurityGetClientSecuritySettingsV1WithHttpInfo (string applicationtype, string lang = null, string locale = null)
        {
            // verify the required parameter 'applicationtype' is set
            if (applicationtype == null)
                throw new ApiException(400, "Missing required parameter 'applicationtype' when calling SecurityApi->SecurityGetClientSecuritySettingsV1");

            var localVarPath = $"/api/V1/getclientsecuritysettings/applicationtype/{applicationtype}";
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

            localVarPathParams.Add("applicationtype", Configuration.ApiClient.ParameterToString(applicationtype)); // path parameter
            if (lang != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter


            // make the HTTP request
            var localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int) localVarResponse.StatusCode;

            var exception = ExceptionFactory?.Invoke("SecurityGetClientSecuritySettingsV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<ClientSecuritySettingsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (ClientSecuritySettingsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ClientSecuritySettingsResponse)));
        }

        #endregion

        #region SecurityGetRolesV1

        /// <summary>
        /// Get all available Roles Operation to get all available Roles.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>SecurityRoleReadResponse</returns>
        public SecurityRoleReadResponse SecurityGetRolesV1 (string lang = null, string locale = null)
        {
             return SecurityGetRolesV1WithHttpInfo(lang, locale).Data;
        }

        /// <summary>
        /// Get all available Roles Operation to get all available Roles.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of SecurityRoleReadResponse</returns>
        private ApiResponse< SecurityRoleReadResponse > SecurityGetRolesV1WithHttpInfo (string lang = null, string locale = null)
        {
            const string varPath = "/api/V1/getroles";
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

            // authentication (oauth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            var localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(varPath,
                Method.GET, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int) localVarResponse.StatusCode;

            var exception = ExceptionFactory?.Invoke("SecurityGetRolesV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<SecurityRoleReadResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (SecurityRoleReadResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SecurityRoleReadResponse)));
        }

        #endregion

        #region SecurityGetRolesV2

         /// <summary>
        /// Get all available Roles Operation to get all available Roles.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>RoleReadV2Response</returns>
        public RoleReadV2Response SecurityGetRolesV2 (string lang = null, string locale = null)
        {
             return SecurityGetRolesV2WithHttpInfo(lang, locale).Data;
        }

        /// <summary>
        /// Get all available Roles Operation to get all available Roles.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of RoleReadV2Response</returns>
        private ApiResponse< RoleReadV2Response > SecurityGetRolesV2WithHttpInfo (string lang = null, string locale = null)
        {

            const string varPath = "/api/V2/getroles";
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

            // authentication (oauth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            var localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(varPath,
                Method.GET, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int) localVarResponse.StatusCode;

            var exception = ExceptionFactory?.Invoke("SecurityGetRolesV2", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<RoleReadV2Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (RoleReadV2Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RoleReadV2Response)));
        }

        #endregion

        #region SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV1

        /// <summary>
        /// Get Business Object permissions by Security Group Operation to get specific Business Object permissions for a Security Group. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupid">Specify the Security Group ID. </param>
        /// <param name="busObId">Specify the Business Object ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>List&lt;BusinessObjectPermission&gt;</returns>
        public List<BusinessObjectPermission> SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV1 (string groupid, string busObId, string lang = null, string locale = null)
        {
             return SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV1WithHttpInfo(groupid, busObId, lang, locale).Data;
        }

        /// <summary>
        /// Get Business Object permissions by Security Group Operation to get specific Business Object permissions for a Security Group. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupid">Specify the Security Group ID. </param>
        /// <param name="busObId">Specify the Business Object ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of List&lt;BusinessObjectPermission&gt;</returns>
        private ApiResponse< List<BusinessObjectPermission> > SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV1WithHttpInfo (string groupid, string busObId, string lang = null, string locale = null)
        {
            // verify the required parameter 'groupid' is set
            if (groupid == null)
                throw new ApiException(400, "Missing required parameter 'groupid' when calling SecurityApi->SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV1");
            // verify the required parameter 'busObId' is set
            if (busObId == null)
                throw new ApiException(400, "Missing required parameter 'busObId' when calling SecurityApi->SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV1");

            var localVarPath = $"/api/V1/getsecuritygroupbusinessobjectpermissions/groupid/{groupid}/busobid/{busObId}";
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

            localVarPathParams.Add("groupid", Configuration.ApiClient.ParameterToString(groupid)); // path parameter
            localVarPathParams.Add("busObId", Configuration.ApiClient.ParameterToString(busObId)); // path parameter
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
                Method.GET, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int) localVarResponse.StatusCode;

            var exception = ExceptionFactory?.Invoke("SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<List<BusinessObjectPermission>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (List<BusinessObjectPermission>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<BusinessObjectPermission>)));
        }


        #endregion

        #region SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV2

         /// <summary>
        /// Get Business Object permissions by Security Group Operation to get specific Business Object permissions for a Security Group. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupid">Specify the Security Group ID. </param>
        /// <param name="busObId">Specify the Business Object ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>SecurityGroupBusinessObjectPermissionsResponse</returns>
        public SecurityGroupBusinessObjectPermissionsResponse SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV2 (string groupid, string busObId, string lang = null, string locale = null)
        {
             return SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV2WithHttpInfo(groupid, busObId, lang, locale).Data;
        }

        /// <summary>
        /// Get Business Object permissions by Security Group Operation to get specific Business Object permissions for a Security Group. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupid">Specify the Security Group ID. </param>
        /// <param name="busObId">Specify the Business Object ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of SecurityGroupBusinessObjectPermissionsResponse</returns>
        private ApiResponse< SecurityGroupBusinessObjectPermissionsResponse > SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV2WithHttpInfo (string groupid, string busObId, string lang = null, string locale = null)
        {
            // verify the required parameter 'groupid' is set
            if (groupid == null)
                throw new ApiException(400, "Missing required parameter 'groupid' when calling SecurityApi->SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV2");
            // verify the required parameter 'busObId' is set
            if (busObId == null)
                throw new ApiException(400, "Missing required parameter 'busObId' when calling SecurityApi->SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV2");

            var localVarPath = $"/api/V2/getsecuritygroupbusinessobjectpermissions/groupid/{groupid}/busobid/{busObId}";
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

            localVarPathParams.Add("groupid", Configuration.ApiClient.ParameterToString(groupid)); // path parameter
            localVarPathParams.Add("busObId", Configuration.ApiClient.ParameterToString(busObId)); // path parameter
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
                Method.GET, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int) localVarResponse.StatusCode;

            var exception = ExceptionFactory?.Invoke("SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV2", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<SecurityGroupBusinessObjectPermissionsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (SecurityGroupBusinessObjectPermissionsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SecurityGroupBusinessObjectPermissionsResponse)));
        }

        #endregion

        #region SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV1

        /// <summary>
        /// Get Business Object permissions by Security Group Operation to get specific Business Object permissions for a Security Group. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupname">Specify the Security Group name. </param>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>List&lt;BusinessObjectPermission&gt;</returns>
        public List<BusinessObjectPermission> SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV1 (string groupname, string busobname, string lang = null, string locale = null)
        {
             return SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV1WithHttpInfo(groupname, busobname, lang, locale).Data;
        }

        /// <summary>
        /// Get Business Object permissions by Security Group Operation to get specific Business Object permissions for a Security Group. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupname">Specify the Security Group name. </param>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of List&lt;BusinessObjectPermission&gt;</returns>
        private ApiResponse< List<BusinessObjectPermission> > SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV1WithHttpInfo (string groupname, string busobname, string lang = null, string locale = null)
        {
            // verify the required parameter 'groupname' is set
            if (groupname == null)
                throw new ApiException(400, "Missing required parameter 'groupname' when calling SecurityApi->SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV1");
            // verify the required parameter 'busobname' is set
            if (busobname == null)
                throw new ApiException(400, "Missing required parameter 'busobname' when calling SecurityApi->SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV1");

            var localVarPath = $"/api/V1/getsecuritygroupbusinessobjectpermissions/groupname/{groupname}/busobname/{busobname}";
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

            localVarPathParams.Add("groupname", Configuration.ApiClient.ParameterToString(groupname)); // path parameter
            localVarPathParams.Add("busobname", Configuration.ApiClient.ParameterToString(busobname)); // path parameter
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
                Method.GET, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int) localVarResponse.StatusCode;

            var exception = ExceptionFactory?.Invoke("SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<List<BusinessObjectPermission>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (List<BusinessObjectPermission>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<BusinessObjectPermission>)));
        }

        #endregion

        #region SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV2

        /// <summary>
        /// Get Business Object permissions by Security Group Operation to get specific Business Object permissions for a Security Group. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupname">Specify the Security Group name. </param>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>SecurityGroupBusinessObjectPermissionsResponse</returns>
        public SecurityGroupBusinessObjectPermissionsResponse SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV2 (string groupname, string busobname, string lang = null, string locale = null)
        {
             return SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV2WithHttpInfo(groupname, busobname, lang, locale).Data;
        }

        /// <summary>
        /// Get Business Object permissions by Security Group Operation to get specific Business Object permissions for a Security Group. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupname">Specify the Security Group name. </param>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of SecurityGroupBusinessObjectPermissionsResponse</returns>
        private ApiResponse< SecurityGroupBusinessObjectPermissionsResponse > SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV2WithHttpInfo (string groupname, string busobname, string lang = null, string locale = null)
        {
            // verify the required parameter 'groupname' is set
            if (groupname == null)
                throw new ApiException(400, "Missing required parameter 'groupname' when calling SecurityApi->SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV2");
            // verify the required parameter 'busobname' is set
            if (busobname == null)
                throw new ApiException(400, "Missing required parameter 'busobname' when calling SecurityApi->SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV2");

            var localVarPath = $"/api/V2/getsecuritygroupbusinessobjectpermissions/groupname/{groupname}/busobname/{busobname}";
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

            localVarPathParams.Add("groupname", Configuration.ApiClient.ParameterToString(groupname)); // path parameter
            localVarPathParams.Add("busobname", Configuration.ApiClient.ParameterToString(busobname)); // path parameter
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
                Method.GET, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int) localVarResponse.StatusCode;

            var exception = ExceptionFactory?.Invoke("SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV2", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<SecurityGroupBusinessObjectPermissionsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (SecurityGroupBusinessObjectPermissionsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SecurityGroupBusinessObjectPermissionsResponse)));
        }

        #endregion

        #region SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV1

         /// <summary>
        /// Get Business Object permission for current user Operation to get Business Object permissions for the currently logged-in user&#39;s Security Group.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busObId">Specify the Business Object ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>List&lt;BusinessObjectPermission&gt;</returns>
        public List<BusinessObjectPermission> SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV1 (string busObId, string lang = null, string locale = null)
        {
             return SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV1WithHttpInfo(busObId, lang, locale).Data;
        }

        /// <summary>
        /// Get Business Object permission for current user Operation to get Business Object permissions for the currently logged-in user&#39;s Security Group.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busObId">Specify the Business Object ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of List&lt;BusinessObjectPermission&gt;</returns>
        private ApiResponse< List<BusinessObjectPermission> > SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV1WithHttpInfo (string busObId, string lang = null, string locale = null)
        {
            // verify the required parameter 'busObId' is set
            if (busObId == null)
                throw new ApiException(400, "Missing required parameter 'busObId' when calling SecurityApi->SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV1");

            var localVarPath = $"/api/V1/getsecuritygroupbusinessobjectpermissionsforcurrentuserbybusobid/busobid/{busObId}";
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

            localVarPathParams.Add("busObId", Configuration.ApiClient.ParameterToString(busObId)); // path parameter
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
                Method.GET, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int) localVarResponse.StatusCode;

            var exception = ExceptionFactory?.Invoke("SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<List<BusinessObjectPermission>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (List<BusinessObjectPermission>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<BusinessObjectPermission>)));
        }

        #endregion

        #region SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV2

        /// <summary>
        /// Get Business Object permission for current user Operation to get Business Object permissions for the currently logged-in user&#39;s Security Group.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busObId">Specify the Business Object ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>SecurityGroupBusinessObjectPermissionsResponse</returns>
        public SecurityGroupBusinessObjectPermissionsResponse SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV2 (string busObId, string lang = null, string locale = null)
        {
             return SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV2WithHttpInfo(busObId, lang, locale).Data;
        }

        /// <summary>
        /// Get Business Object permission for current user Operation to get Business Object permissions for the currently logged-in user&#39;s Security Group.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busObId">Specify the Business Object ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of SecurityGroupBusinessObjectPermissionsResponse</returns>
        private ApiResponse< SecurityGroupBusinessObjectPermissionsResponse > SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV2WithHttpInfo (string busObId, string lang = null, string locale = null)
        {
            // verify the required parameter 'busObId' is set
            if (busObId == null)
                throw new ApiException(400, "Missing required parameter 'busObId' when calling SecurityApi->SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV2");

            var localVarPath = $"/api/V2/getsecuritygroupbusinessobjectpermissionsforcurrentuserbybusobid/busobid/{busObId}";
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

            localVarPathParams.Add("busObId", Configuration.ApiClient.ParameterToString(busObId)); // path parameter
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
                Method.GET, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int) localVarResponse.StatusCode;

            var exception = ExceptionFactory?.Invoke("SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV2", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<SecurityGroupBusinessObjectPermissionsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (SecurityGroupBusinessObjectPermissionsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SecurityGroupBusinessObjectPermissionsResponse)));
        }

        

        /// <summary>
        /// Get Business Object permissions for current user Operation to get Business Object permissions for currently logged in user&#39;s Security Group.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>List&lt;BusinessObjectPermission&gt;</returns>
        public List<BusinessObjectPermission> SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV1 (string busobname, string lang = null, string locale = null)
        {
             var localVarResponse = SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV1WithHttpInfo(busobname, lang, locale);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Business Object permissions for current user Operation to get Business Object permissions for currently logged in user&#39;s Security Group.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of List&lt;BusinessObjectPermission&gt;</returns>
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

            // to determine the Content-Type header
            var localVarHttpContentTypes = new string[] {
            };
            var localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
            
            var localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(LocalVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            localVarPathParams.Add("busobname", Configuration.ApiClient.ParameterToString(busobname)); // path parameter
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
                Method.GET, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int) localVarResponse.StatusCode;

            var exception = ExceptionFactory?.Invoke("SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<List<BusinessObjectPermission>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (List<BusinessObjectPermission>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<BusinessObjectPermission>)));
        }

        #endregion

        #region SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV2

        /// <summary>
        /// Get Business Object permissions for current user Operation to get Business Object permissions for currently logged in user&#39;s Security Group.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>SecurityGroupBusinessObjectPermissionsResponse</returns>
        public SecurityGroupBusinessObjectPermissionsResponse SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV2 (string busobname, string lang = null, string locale = null)
        {
             return SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV2WithHttpInfo(busobname, lang, locale).Data;
        }

        /// <summary>
        /// Get Business Object permissions for current user Operation to get Business Object permissions for currently logged in user&#39;s Security Group.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of SecurityGroupBusinessObjectPermissionsResponse</returns>
        private ApiResponse< SecurityGroupBusinessObjectPermissionsResponse > SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV2WithHttpInfo (string busobname, string lang = null, string locale = null)
        {
            // verify the required parameter 'busobname' is set
            if (busobname == null)
                throw new ApiException(400, "Missing required parameter 'busobname' when calling SecurityApi->SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV2");

            var localVarPath = $"/api/V2/getsecuritygroupbusinessobjectpermissionsforcurrentuserbybusobname/busobname/{busobname}";
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

            localVarPathParams.Add("busobname", Configuration.ApiClient.ParameterToString(busobname)); // path parameter
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
                Method.GET, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int) localVarResponse.StatusCode;

            var exception = ExceptionFactory?.Invoke("SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV2", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<SecurityGroupBusinessObjectPermissionsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (SecurityGroupBusinessObjectPermissionsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SecurityGroupBusinessObjectPermissionsResponse)));
        }
        

        #endregion

        #region SecurityGetSecurityGroupCategoriesV1

        /// <summary>
        /// Get all Security Group categories Operation to get IDs and names for all available Security Group categories. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>List&lt;RightCategory&gt;</returns>
        public List<RightCategory> SecurityGetSecurityGroupCategoriesV1 (string lang = null, string locale = null)
        {
             return SecurityGetSecurityGroupCategoriesV1WithHttpInfo(lang, locale).Data;
        }

        /// <summary>
        /// Get all Security Group categories Operation to get IDs and names for all available Security Group categories. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of List&lt;RightCategory&gt;</returns>
        private ApiResponse< List<RightCategory> > SecurityGetSecurityGroupCategoriesV1WithHttpInfo (string lang = null, string locale = null)
        {

            const string varPath = "/api/V1/getsecuritygroupcategories";
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

            // authentication (oauth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            var localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(varPath,
                Method.GET, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int) localVarResponse.StatusCode;

            var exception = ExceptionFactory?.Invoke("SecurityGetSecurityGroupCategoriesV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<List<RightCategory>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (List<RightCategory>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<RightCategory>)));
        }

        #endregion

        #region SecurityGetSecurityGroupCategoriesV2

        /// <summary>
        /// Get all Security Group categories Operation to get IDs and names for all available Security Group categories. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>SecurityRightCategoriesResponse</returns>
        public SecurityRightCategoriesResponse SecurityGetSecurityGroupCategoriesV2 (string lang = null, string locale = null)
        {
             return SecurityGetSecurityGroupCategoriesV2WithHttpInfo(lang, locale).Data;
        }

        /// <summary>
        /// Get all Security Group categories Operation to get IDs and names for all available Security Group categories. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of SecurityRightCategoriesResponse</returns>
        private ApiResponse< SecurityRightCategoriesResponse > SecurityGetSecurityGroupCategoriesV2WithHttpInfo (string lang = null, string locale = null)
        {

            var localVarPath = $"/api/V2/getsecuritygroupcategories";
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

            // authentication (oauth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            var localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int) localVarResponse.StatusCode;

            var exception = ExceptionFactory?.Invoke("SecurityGetSecurityGroupCategoriesV2", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<SecurityRightCategoriesResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (SecurityRightCategoriesResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SecurityRightCategoriesResponse)));
        }

        #endregion

        #region SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV1

        /// <summary>
        /// Get permissions for a Security Group by category Operation to get permissions for a Security Group by category. To get Security Group IDs, use \&quot;Get all available Security Groups.\&quot; To get Security Group category IDs, use \&quot;Get all Security Group categories.\&quot;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupid">Specify the Security Group ID</param>
        /// <param name="categoryid">Specify the Security Group category ID</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>List&lt;SecurityRight&gt;</returns>
        public List<SecurityRight> SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV1 (string groupid, string categoryid, string lang = null, string locale = null)
        {
             return SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV1WithHttpInfo(groupid, categoryid, lang, locale).Data;
        }

        /// <summary>
        /// Get permissions for a Security Group by category Operation to get permissions for a Security Group by category. To get Security Group IDs, use \&quot;Get all available Security Groups.\&quot; To get Security Group category IDs, use \&quot;Get all Security Group categories.\&quot;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupid">Specify the Security Group ID</param>
        /// <param name="categoryid">Specify the Security Group category ID</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of List&lt;SecurityRight&gt;</returns>
        private ApiResponse< List<SecurityRight> > SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV1WithHttpInfo (string groupid, string categoryid, string lang = null, string locale = null)
        {
            // verify the required parameter 'groupid' is set
            if (groupid == null)
                throw new ApiException(400, "Missing required parameter 'groupid' when calling SecurityApi->SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV1");
            // verify the required parameter 'categoryid' is set
            if (categoryid == null)
                throw new ApiException(400, "Missing required parameter 'categoryid' when calling SecurityApi->SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV1");

            var localVarPath = $"/api/V1/getsecuritygrouprights/groupid/{groupid}/categoryid/{categoryid}";
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

            localVarPathParams.Add("groupid", Configuration.ApiClient.ParameterToString(groupid)); // path parameter
            localVarPathParams.Add("categoryid", Configuration.ApiClient.ParameterToString(categoryid)); // path parameter
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
                Method.GET, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int) localVarResponse.StatusCode;

            var exception = ExceptionFactory?.Invoke("SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<List<SecurityRight>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (List<SecurityRight>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<SecurityRight>)));
        }


        #endregion

        #region SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV2

         /// <summary>
        /// Get permissions for a Security Group by category Operation to get permissions for a Security Group by category. To get Security Group IDs, use \&quot;Get all available Security Groups.\&quot; To get Security Group category IDs, use \&quot;Get all Security Group categories.\&quot;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupid">Specify the Security Group ID</param>
        /// <param name="categoryid">Specify the Security Group category ID</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>SecurityRightsResponse</returns>
        public SecurityRightsResponse SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV2 (string groupid, string categoryid, string lang = null, string locale = null)
        {
             return SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV2WithHttpInfo(groupid, categoryid, lang, locale).Data;
        }

        /// <summary>
        /// Get permissions for a Security Group by category Operation to get permissions for a Security Group by category. To get Security Group IDs, use \&quot;Get all available Security Groups.\&quot; To get Security Group category IDs, use \&quot;Get all Security Group categories.\&quot;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupid">Specify the Security Group ID</param>
        /// <param name="categoryid">Specify the Security Group category ID</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of SecurityRightsResponse</returns>
        private ApiResponse< SecurityRightsResponse > SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV2WithHttpInfo (string groupid, string categoryid, string lang = null, string locale = null)
        {
            // verify the required parameter 'groupid' is set
            if (groupid == null)
                throw new ApiException(400, "Missing required parameter 'groupid' when calling SecurityApi->SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV2");
            // verify the required parameter 'categoryid' is set
            if (categoryid == null)
                throw new ApiException(400, "Missing required parameter 'categoryid' when calling SecurityApi->SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV2");

            var localVarPath = $"/api/V2/getsecuritygrouprights/groupid/{groupid}/categoryid/{categoryid}";
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

            localVarPathParams.Add("groupid", Configuration.ApiClient.ParameterToString(groupid)); // path parameter
            localVarPathParams.Add("categoryid", Configuration.ApiClient.ParameterToString(categoryid)); // path parameter
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
                Method.GET, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int) localVarResponse.StatusCode;

            var exception = ExceptionFactory?.Invoke("SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV2", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<SecurityRightsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (SecurityRightsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SecurityRightsResponse)));
        }

        #endregion

        #region SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV1

        /// <summary>
        /// Get permissions for a Security Group by category Operation to get permissions for a Security Group by category.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupname">Specify the Security Group name.</param>
        /// <param name="categoryname">Specify the Security Group category name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>List&lt;SecurityRight&gt;</returns>
        public List<SecurityRight> SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV1 (string groupname, string categoryname, string lang = null, string locale = null)
        {
             return SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV1WithHttpInfo(groupname, categoryname, lang, locale).Data;
        }

        /// <summary>
        /// Get permissions for a Security Group by category Operation to get permissions for a Security Group by category.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupname">Specify the Security Group name.</param>
        /// <param name="categoryname">Specify the Security Group category name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of List&lt;SecurityRight&gt;</returns>
        private ApiResponse< List<SecurityRight> > SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV1WithHttpInfo (string groupname, string categoryname, string lang = null, string locale = null)
        {
            // verify the required parameter 'groupname' is set
            if (groupname == null)
                throw new ApiException(400, "Missing required parameter 'groupname' when calling SecurityApi->SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV1");
            // verify the required parameter 'categoryname' is set
            if (categoryname == null)
                throw new ApiException(400, "Missing required parameter 'categoryname' when calling SecurityApi->SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV1");

            var localVarPath = $"/api/V1/getsecuritygrouprights/groupname/{groupname}/categoryname/{categoryname}";
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

            localVarPathParams.Add("groupname", Configuration.ApiClient.ParameterToString(groupname)); // path parameter
            localVarPathParams.Add("categoryname", Configuration.ApiClient.ParameterToString(categoryname)); // path parameter
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
                Method.GET, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int) localVarResponse.StatusCode;

            var exception = ExceptionFactory?.Invoke("SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<List<SecurityRight>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (List<SecurityRight>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<SecurityRight>)));
        }

        #endregion

        #region SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV2

        /// <summary>
        /// Get permissions for a Security Group by category Operation to get permissions for a Security Group by category.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupname">Specify the Security Group name.</param>
        /// <param name="categoryname">Specify the Security Group category name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>SecurityRightsResponse</returns>
        public SecurityRightsResponse SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV2 (string groupname, string categoryname, string lang = null, string locale = null)
        {
             return SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV2WithHttpInfo(groupname, categoryname, lang, locale).Data;
        }

        /// <summary>
        /// Get permissions for a Security Group by category Operation to get permissions for a Security Group by category.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupname">Specify the Security Group name.</param>
        /// <param name="categoryname">Specify the Security Group category name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of SecurityRightsResponse</returns>
        private ApiResponse< SecurityRightsResponse > SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV2WithHttpInfo (string groupname, string categoryname, string lang = null, string locale = null)
        {
            // verify the required parameter 'groupname' is set
            if (groupname == null)
                throw new ApiException(400, "Missing required parameter 'groupname' when calling SecurityApi->SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV2");
            // verify the required parameter 'categoryname' is set
            if (categoryname == null)
                throw new ApiException(400, "Missing required parameter 'categoryname' when calling SecurityApi->SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV2");

            var localVarPath = $"/api/V2/getsecuritygrouprights/groupname/{groupname}/categoryname/{categoryname}";
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

            localVarPathParams.Add("groupname", Configuration.ApiClient.ParameterToString(groupname)); // path parameter
            localVarPathParams.Add("categoryname", Configuration.ApiClient.ParameterToString(categoryname)); // path parameter
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
                Method.GET, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int) localVarResponse.StatusCode;

            var exception = ExceptionFactory?.Invoke("SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV2", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<SecurityRightsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (SecurityRightsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SecurityRightsResponse)));
        }

        #endregion

        #region SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV1

         /// <summary>
        /// Get current user&#39;s permissions by Security Group category by ID Operation to get permissions for the current user&#39;s Security Group by category. To get Security Group category IDs, use \&quot;Get all Security Group categories.\&quot;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryid">Specify the Security Group category ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>List&lt;SecurityRight&gt;</returns>
        public List<SecurityRight> SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV1 (string categoryid, string lang = null, string locale = null)
        {
             return SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV1WithHttpInfo(categoryid, lang, locale).Data;
        }

        /// <summary>
        /// Get current user&#39;s permissions by Security Group category by ID Operation to get permissions for the current user&#39;s Security Group by category. To get Security Group category IDs, use \&quot;Get all Security Group categories.\&quot;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryid">Specify the Security Group category ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of List&lt;SecurityRight&gt;</returns>
        private ApiResponse< List<SecurityRight> > SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV1WithHttpInfo (string categoryid, string lang = null, string locale = null)
        {
            // verify the required parameter 'categoryid' is set
            if (categoryid == null)
                throw new ApiException(400, "Missing required parameter 'categoryid' when calling SecurityApi->SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV1");

            var localVarPath = $"/api/V1/getsecuritygrouprightsforcurrentuserbycategoryid/categoryid/{categoryid}";
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

            localVarPathParams.Add("categoryid", Configuration.ApiClient.ParameterToString(categoryid)); // path parameter
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
                Method.GET, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int) localVarResponse.StatusCode;

            var exception = ExceptionFactory?.Invoke("SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<List<SecurityRight>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (List<SecurityRight>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<SecurityRight>)));
        }

        #endregion

        #region SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV2

        /// <summary>
        /// Get current user&#39;s permissions by Security Group category by ID Operation to get permissions for the current user&#39;s Security Group by category. To get Security Group category IDs, use \&quot;Get all Security Group categories.\&quot;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryid">Specify the Security Group category ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>SecurityRightsResponse</returns>
        public SecurityRightsResponse SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV2 (string categoryid, string lang = null, string locale = null)
        {
             return SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV2WithHttpInfo(categoryid, lang, locale).Data;
        }

        /// <summary>
        /// Get current user&#39;s permissions by Security Group category by ID Operation to get permissions for the current user&#39;s Security Group by category. To get Security Group category IDs, use \&quot;Get all Security Group categories.\&quot;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryid">Specify the Security Group category ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of SecurityRightsResponse</returns>
        private ApiResponse< SecurityRightsResponse > SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV2WithHttpInfo (string categoryid, string lang = null, string locale = null)
        {
            // verify the required parameter 'categoryid' is set
            if (categoryid == null)
                throw new ApiException(400, "Missing required parameter 'categoryid' when calling SecurityApi->SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV2");

            var localVarPath = $"/api/V2/getsecuritygrouprightsforcurrentuserbycategoryid/categoryid/{categoryid}";
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

            localVarPathParams.Add("categoryid", Configuration.ApiClient.ParameterToString(categoryid)); // path parameter
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
                Method.GET, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int) localVarResponse.StatusCode;

            var exception = ExceptionFactory?.Invoke("SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV2", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<SecurityRightsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (SecurityRightsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SecurityRightsResponse)));
        }

        #endregion

        #region SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV1

        /// <summary>
        /// Get current user&#39;s permissions by Security Group category by name Operation to get permissions for the current user&#39;s Security Group by category.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryname">Specify the Security Group category name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>List&lt;SecurityRight&gt;</returns>
        public List<SecurityRight> SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV1 (string categoryname, string lang = null, string locale = null)
        {
             return SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV1WithHttpInfo(categoryname, lang, locale).Data;
        }

        /// <summary>
        /// Get current user&#39;s permissions by Security Group category by name Operation to get permissions for the current user&#39;s Security Group by category.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryname">Specify the Security Group category name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of List&lt;SecurityRight&gt;</returns>
        private ApiResponse< List<SecurityRight> > SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV1WithHttpInfo (string categoryname, string lang = null, string locale = null)
        {
            // verify the required parameter 'categoryname' is set
            if (categoryname == null)
                throw new ApiException(400, "Missing required parameter 'categoryname' when calling SecurityApi->SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV1");

            var localVarPath = $"/api/V1/getsecuritygrouprightsforcurrentuserbycategoryname/categoryname/{categoryname}";
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

            localVarPathParams.Add("categoryname", Configuration.ApiClient.ParameterToString(categoryname)); // path parameter
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
                Method.GET, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int) localVarResponse.StatusCode;

            var exception = ExceptionFactory?.Invoke("SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<List<SecurityRight>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (List<SecurityRight>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<SecurityRight>)));
        }

        #endregion

        #region SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV2

        /// <summary>
        /// Get current user&#39;s permissions by Security Group category by name Operation to get permissions for the current user&#39;s Security Group by category.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryname">Specify the Security Group category name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>SecurityRightsResponse</returns>
        public SecurityRightsResponse SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV2 (string categoryname, string lang = null, string locale = null)
        {
             return SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV2WithHttpInfo(categoryname, lang, locale).Data;
        }
        
        /// <summary>
        /// Get current user&#39;s permissions by Security Group category by name Operation to get permissions for the current user&#39;s Security Group by category.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryname">Specify the Security Group category name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of SecurityRightsResponse</returns>
        private ApiResponse< SecurityRightsResponse > SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV2WithHttpInfo (string categoryname, string lang = null, string locale = null)
        {
            // verify the required parameter 'categoryname' is set
            if (categoryname == null)
                throw new ApiException(400, "Missing required parameter 'categoryname' when calling SecurityApi->SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV2");

            var localVarPath = $"/api/V2/getsecuritygrouprightsforcurrentuserbycategoryname/categoryname/{categoryname}";
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

            localVarPathParams.Add("categoryname", Configuration.ApiClient.ParameterToString(categoryname)); // path parameter
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
                Method.GET, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int) localVarResponse.StatusCode;

            var exception = ExceptionFactory?.Invoke("SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV2", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<SecurityRightsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (SecurityRightsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SecurityRightsResponse)));
        }

        #endregion

        #region SecurityGetSecurityGroupsV2

        /// <summary>
        /// Get all available Security Groups Operation to get IDs, names, and descriptions for all available Security Groups.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>SecurityGroupV2Response</returns>
        public SecurityGroupV2Response SecurityGetSecurityGroupsV2 (string lang = null, string locale = null)
        {
             return  SecurityGetSecurityGroupsV2WithHttpInfo(lang, locale).Data;
        }

        /// <summary>
        /// Get all available Security Groups Operation to get IDs, names, and descriptions for all available Security Groups.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of SecurityGroupV2Response</returns>
        private ApiResponse< SecurityGroupV2Response > SecurityGetSecurityGroupsV2WithHttpInfo (string lang = null, string locale = null)
        {

            const string varPath = "/api/V2/getsecuritygroups";
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

            // authentication (oauth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            var localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(varPath,
                Method.GET, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int) localVarResponse.StatusCode;

            var exception = ExceptionFactory?.Invoke("SecurityGetSecurityGroupsV2", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<SecurityGroupV2Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (SecurityGroupV2Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SecurityGroupV2Response)));
        }

        #endregion

        #region SecurityGetUsersInSecurityGroupV1

        /// <summary>
        /// Get users in a Security Group Operation to get the users in a specified Security Group. Use \&quot;Get all available Security Groups\&quot; to get Security Group record IDs. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupid">Specify the Security Group ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>List&lt;User&gt;</returns>
        public List<User> SecurityGetUsersInSecurityGroupV1 (string groupid, string lang = null, string locale = null)
        {
             return SecurityGetUsersInSecurityGroupV1WithHttpInfo(groupid, lang, locale).Data;
        }

        /// <summary>
        /// Get users in a Security Group Operation to get the users in a specified Security Group. Use \&quot;Get all available Security Groups\&quot; to get Security Group record IDs. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupid">Specify the Security Group ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of List&lt;User&gt;</returns>
        private ApiResponse< List<User> > SecurityGetUsersInSecurityGroupV1WithHttpInfo (string groupid, string lang = null, string locale = null)
        {
            // verify the required parameter 'groupid' is set
            if (groupid == null)
                throw new ApiException(400, "Missing required parameter 'groupid' when calling SecurityApi->SecurityGetUsersInSecurityGroupV1");

            var localVarPath = $"/api/V1/getusersinsecuritygroup/groupid/{groupid}";
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

            localVarPathParams.Add("groupid", Configuration.ApiClient.ParameterToString(groupid)); // path parameter
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
                Method.GET, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int) localVarResponse.StatusCode;

            var exception = ExceptionFactory?.Invoke("SecurityGetUsersInSecurityGroupV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<List<User>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (List<User>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<User>)));
        }

        #endregion

        #region SecurityGetUsersInSecurityGroupV2

        /// <summary>
        /// Get users in a Security Group Operation to get the users in a specified Security Group. Use \&quot;Get all available Security Groups\&quot; to get Security Group record IDs. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupid">Specify the Security Group ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>UserReadV2Response</returns>
        public UserReadV2Response SecurityGetUsersInSecurityGroupV2 (string groupid, string lang = null, string locale = null)
        {
             return SecurityGetUsersInSecurityGroupV2WithHttpInfo(groupid, lang, locale).Data;
        }

        /// <summary>
        /// Get users in a Security Group Operation to get the users in a specified Security Group. Use \&quot;Get all available Security Groups\&quot; to get Security Group record IDs. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupid">Specify the Security Group ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of UserReadV2Response</returns>
        private ApiResponse< UserReadV2Response > SecurityGetUsersInSecurityGroupV2WithHttpInfo (string groupid, string lang = null, string locale = null)
        {
            // verify the required parameter 'groupid' is set
            if (groupid == null)
                throw new ApiException(400, "Missing required parameter 'groupid' when calling SecurityApi->SecurityGetUsersInSecurityGroupV2");

            var localVarPath = $"/api/V2/getusersinsecuritygroup/groupid/{groupid}";
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

            localVarPathParams.Add("groupid", Configuration.ApiClient.ParameterToString(groupid)); // path parameter
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
                Method.GET, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int) localVarResponse.StatusCode;

            var exception = ExceptionFactory?.Invoke("SecurityGetUsersInSecurityGroupV2", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<UserReadV2Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (UserReadV2Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserReadV2Response)));
        }

        #endregion

        #region SecurityGetSecurityGroupsV1

        /// <summary>
        /// Get all available Security Groups Operation to get IDs, names, and descriptions for all available Security Groups.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>SecurityGroupResponse</returns>
        public SecurityGroupResponse SecurityGetSecurityGroupsV1 (string lang = null, string locale = null)
        {
            return SecurityGetSecurityGroupsV1WithHttpInfo(lang, locale).Data;
        }

        /// <summary>
        /// Get all available Security Groups Operation to get IDs, names, and descriptions for all available Security Groups.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of SecurityGroupResponse</returns>
        private ApiResponse< SecurityGroupResponse > SecurityGetSecurityGroupsV1WithHttpInfo (string lang = null, string locale = null)
        {

            const string varPath = "/api/V1/getsecuritygroups";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();

            // to determine the Content-Type header
            var localVarHttpContentTypes = Array.Empty<string>();
            var localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
            
            var localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(LocalVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (lang != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            var localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(varPath,
                Method.GET, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int) localVarResponse.StatusCode;

            var exception = ExceptionFactory?.Invoke("SecurityGetSecurityGroupsV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<SecurityGroupResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (SecurityGroupResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SecurityGroupResponse)));
        }

        #endregion
        
        
        
    }
}
