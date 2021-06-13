
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
    public class OneStepActionsApi :BaseApi, IOneStepActionsApi
    {
        #region Variables & Properties
        
        private static OneStepActionsApi _instance;

        private static readonly object Padlock = new();
        
        public static OneStepActionsApi Instance
        {
            get
            {
                lock (Padlock)
                {
                    return _instance ??= new OneStepActionsApi();
                }
            }
            set => _instance = value;
        }
        
        #endregion
        
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="OneStepActionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OneStepActionsApi(string basePath)
        {
            Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OneStepActionsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public OneStepActionsApi(Configuration configuration = null)
        {
            Configuration = configuration ?? Configuration.Default;

            ExceptionFactory = Configuration.DefaultExceptionFactory;
        }

        #endregion
        
        #region OneStepActionsGetOneStepActionsByAssociationScopeScopeOwnerFolderV1

         /// <summary>
        /// Get One-Step Actions by Folder Operation to get One-Step Actions by Association, Scope, Scope Owner in a specific folder.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Business Object association to get One-Step Actions for</param>
        /// <param name="scope">Scope to get One-Step Actions for</param>
        /// <param name="scopeowner">Scope owner to get One-Step Actions for</param>
        /// <param name="folder">Folder to get One-Step Actions from</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ManagerData</returns>
        public ManagerData OneStepActionsGetOneStepActionsByAssociationScopeScopeOwnerFolderV1 (string association, string scope, string scopeowner, string folder, bool? links = null, string lang = null, string locale = null)
        {
             return OneStepActionsGetOneStepActionsByAssociationScopeScopeOwnerFolderV1WithHttpInfo(association, scope, scopeowner, folder, links, lang, locale).Data;
            
        }

        /// <summary>
        /// Get One-Step Actions by Folder Operation to get One-Step Actions by Association, Scope, Scope Owner in a specific folder.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Business Object association to get One-Step Actions for</param>
        /// <param name="scope">Scope to get One-Step Actions for</param>
        /// <param name="scopeowner">Scope owner to get One-Step Actions for</param>
        /// <param name="folder">Folder to get One-Step Actions from</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsCoreManagerData</returns>
        private ApiResponse< ManagerData > OneStepActionsGetOneStepActionsByAssociationScopeScopeOwnerFolderV1WithHttpInfo (string association, string scope, string scopeowner, string folder, bool? links = null, string lang = null, string locale = null)
        {
            // verify the required parameter 'association' is set
            if (association == null)
                throw new ApiException(400, "Missing required parameter 'association' when calling OneStepActionsApi->OneStepActionsGetOneStepActionsByAssociationScopeScopeOwnerFolderV1");
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling OneStepActionsApi->OneStepActionsGetOneStepActionsByAssociationScopeScopeOwnerFolderV1");
            // verify the required parameter 'scopeowner' is set
            if (scopeowner == null)
                throw new ApiException(400, "Missing required parameter 'scopeowner' when calling OneStepActionsApi->OneStepActionsGetOneStepActionsByAssociationScopeScopeOwnerFolderV1");
            // verify the required parameter 'folder' is set
            if (folder == null)
                throw new ApiException(400, "Missing required parameter 'folder' when calling OneStepActionsApi->OneStepActionsGetOneStepActionsByAssociationScopeScopeOwnerFolderV1");

            var localVarPath = $"/api/V1/getonestepactions/association/{association}/scope/{scope}/scopeowner/{scopeowner}/folder/{folder}";
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

            localVarPathParams.Add("association", Configuration.ApiClient.ParameterToString(association)); // path parameter
            localVarPathParams.Add("scope", Configuration.ApiClient.ParameterToString(scope)); // path parameter
            localVarPathParams.Add("scopeowner", Configuration.ApiClient.ParameterToString(scopeowner)); // path parameter
            localVarPathParams.Add("folder", Configuration.ApiClient.ParameterToString(folder)); // path parameter
            if (links != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "links", links)); // query parameter
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

            var exception = ExceptionFactory?.Invoke("OneStepActionsGetOneStepActionsByAssociationScopeScopeOwnerFolderV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<ManagerData>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (ManagerData) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManagerData)));
        }


        #endregion

        #region OneStepActionsGetOneStepActionsByAssociationScopeScopeOwnerV1

        /// <summary>
        /// Get One-Step Actions by Scope Owner Operation to get One-Step Actions by Association, Scope, Scope Owner
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Business Object association to get One-Step Actions for</param>
        /// <param name="scope">Scope to get One-Step Actions for</param>
        /// <param name="scopeowner">Scope owner to get One-Step Actions for</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ManagerData</returns>
        public ManagerData OneStepActionsGetOneStepActionsByAssociationScopeScopeOwnerV1 (string association, string scope, string scopeowner, bool? links = null, string lang = null, string locale = null)
        {
             return OneStepActionsGetOneStepActionsByAssociationScopeScopeOwnerV1WithHttpInfo(association, scope, scopeowner, links, lang, locale).Data;
           
        }

        /// <summary>
        /// Get One-Step Actions by Scope Owner Operation to get One-Step Actions by Association, Scope, Scope Owner
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Business Object association to get One-Step Actions for</param>
        /// <param name="scope">Scope to get One-Step Actions for</param>
        /// <param name="scopeowner">Scope owner to get One-Step Actions for</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of ManagerData</returns>
        private ApiResponse< ManagerData > OneStepActionsGetOneStepActionsByAssociationScopeScopeOwnerV1WithHttpInfo (string association, string scope, string scopeowner, bool? links = null, string lang = null, string locale = null)
        {
            // verify the required parameter 'association' is set
            if (association == null)
                throw new ApiException(400, "Missing required parameter 'association' when calling OneStepActionsApi->OneStepActionsGetOneStepActionsByAssociationScopeScopeOwnerV1");
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling OneStepActionsApi->OneStepActionsGetOneStepActionsByAssociationScopeScopeOwnerV1");
            // verify the required parameter 'scopeowner' is set
            if (scopeowner == null)
                throw new ApiException(400, "Missing required parameter 'scopeowner' when calling OneStepActionsApi->OneStepActionsGetOneStepActionsByAssociationScopeScopeOwnerV1");

            var localVarPath = $"/api/V1/getonestepactions/association/{association}/scope/{scope}/scopeowner/{scopeowner}";
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

            localVarPathParams.Add("association", Configuration.ApiClient.ParameterToString(association)); // path parameter
            localVarPathParams.Add("scope", Configuration.ApiClient.ParameterToString(scope)); // path parameter
            localVarPathParams.Add("scopeowner", Configuration.ApiClient.ParameterToString(scopeowner)); // path parameter
            if (links != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "links", links)); // query parameter
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

            var exception = ExceptionFactory?.Invoke("OneStepActionsGetOneStepActionsByAssociationScopeScopeOwnerV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<ManagerData>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (ManagerData) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManagerData)));
        }

        #endregion

        #region OneStepActionsGetOneStepActionsByAssociationScopeV1

         /// <summary>
        /// Get One-Step Actions by Scope Operation to get One-Step Actions by Association, Scope
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Business Object association to get One-Step Actions for</param>
        /// <param name="scope">Scope to get One-Step Actions for</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ManagerData</returns>
        public ManagerData OneStepActionsGetOneStepActionsByAssociationScopeV1 (string association, string scope, bool? links = null, string lang = null, string locale = null)
        {
             return OneStepActionsGetOneStepActionsByAssociationScopeV1WithHttpInfo(association, scope, links, lang, locale).Data;
             
        }

        /// <summary>
        /// Get One-Step Actions by Scope Operation to get One-Step Actions by Association, Scope
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Business Object association to get One-Step Actions for</param>
        /// <param name="scope">Scope to get One-Step Actions for</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of ManagerData</returns>
        private ApiResponse< ManagerData > OneStepActionsGetOneStepActionsByAssociationScopeV1WithHttpInfo (string association, string scope, bool? links = null, string lang = null, string locale = null)
        {
            // verify the required parameter 'association' is set
            if (association == null)
                throw new ApiException(400, "Missing required parameter 'association' when calling OneStepActionsApi->OneStepActionsGetOneStepActionsByAssociationScopeV1");
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling OneStepActionsApi->OneStepActionsGetOneStepActionsByAssociationScopeV1");

            var localVarPath = $"/api/V1/getonestepactions/association/{association}/scope/{scope}";
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

            localVarPathParams.Add("association", Configuration.ApiClient.ParameterToString(association)); // path parameter
            localVarPathParams.Add("scope", Configuration.ApiClient.ParameterToString(scope)); // path parameter
            if (links != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "links", links)); // query parameter
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

            var exception = ExceptionFactory?.Invoke("OneStepActionsGetOneStepActionsByAssociationScopeV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<ManagerData>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (ManagerData) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManagerData)));
        }
        
        #endregion

        #region OneStepActionsGetOneStepActionsByAssociationV1

        /// <summary>
        /// Get One-Step Actions by Association Operation to get One-Step Actions by Association
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Business Object association to get One-Step Actions for</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ManagerData</returns>
        public ManagerData OneStepActionsGetOneStepActionsByAssociationV1 (string association, bool? links = null, string lang = null, string locale = null)
        {
             return OneStepActionsGetOneStepActionsByAssociationV1WithHttpInfo(association, links, lang, locale).Data;
           
        }

        /// <summary>
        /// Get One-Step Actions by Association Operation to get One-Step Actions by Association
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Business Object association to get One-Step Actions for</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of ManagerData</returns>
        private ApiResponse< ManagerData > OneStepActionsGetOneStepActionsByAssociationV1WithHttpInfo (string association, bool? links = null, string lang = null, string locale = null)
        {
            // verify the required parameter 'association' is set
            if (association == null)
                throw new ApiException(400, "Missing required parameter 'association' when calling OneStepActionsApi->OneStepActionsGetOneStepActionsByAssociationV1");

            var localVarPath = $"/api/V1/getonestepactions/association/{association}";
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

            localVarPathParams.Add("association", Configuration.ApiClient.ParameterToString(association)); // path parameter
            if (links != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "links", links)); // query parameter
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

            var exception = ExceptionFactory?.Invoke("OneStepActionsGetOneStepActionsByAssociationV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<ManagerData>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (ManagerData) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManagerData)));
        }

        #endregion

        #region OneStepActionsGetOneStepActionsV1

         /// <summary>
        /// Get One-Step Actions by default Association Operation to get One-Step Actions by default Association
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ManagerData</returns>
        public ManagerData OneStepActionsGetOneStepActionsV1 (bool? links = null, string lang = null, string locale = null)
        {
             return OneStepActionsGetOneStepActionsV1WithHttpInfo(links, lang, locale).Data;
            
        }

        /// <summary>
        /// Get One-Step Actions by default Association Operation to get One-Step Actions by default Association
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of ManagerData</returns>
        private ApiResponse< ManagerData > OneStepActionsGetOneStepActionsV1WithHttpInfo (bool? links = null, string lang = null, string locale = null)
        {

            const string varPath = "/api/V1/getonestepactions";
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

            if (links != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "links", links)); // query parameter
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

            var exception = ExceptionFactory?.Invoke("OneStepActionsGetOneStepActionsV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<ManagerData>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (ManagerData) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManagerData)));
        }

        #endregion

        #region OneStepActionsRunOneStepActionByKeyForRecordByRecIdV1

        /// <summary>
        /// Run a One-Step Action for a Business Object record Operation to run a One-Step Action for a Business Object record by Business Object ID and Business Object Record ID.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="standinkey">The key to find the One-Step Action to run</param>
        /// <param name="busobid">Specify the Business Object ID.</param>
        /// <param name="busobrecid">Specify the Business Object record ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>OneStepActionResponse</returns>
        public OneStepActionResponse OneStepActionsRunOneStepActionByKeyForRecordByRecIdV1 (string standinkey, string busobid, string busobrecid, string lang = null, string locale = null)
        {
             return OneStepActionsRunOneStepActionByKeyForRecordByRecIdV1WithHttpInfo(standinkey, busobid, busobrecid, lang, locale).Data;
             
        }

        /// <summary>
        /// Run a One-Step Action for a Business Object record Operation to run a One-Step Action for a Business Object record by Business Object ID and Business Object Record ID.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="standinkey">The key to find the One-Step Action to run</param>
        /// <param name="busobid">Specify the Business Object ID.</param>
        /// <param name="busobrecid">Specify the Business Object record ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of OneStepActionResponse</returns>
        private ApiResponse< OneStepActionResponse > OneStepActionsRunOneStepActionByKeyForRecordByRecIdV1WithHttpInfo (string standinkey, string busobid, string busobrecid, string lang = null, string locale = null)
        {
            // verify the required parameter 'standinkey' is set
            if (standinkey == null)
                throw new ApiException(400, "Missing required parameter 'standinkey' when calling OneStepActionsApi->OneStepActionsRunOneStepActionByKeyForRecordByRecIdV1");
            // verify the required parameter 'busobid' is set
            if (busobid == null)
                throw new ApiException(400, "Missing required parameter 'busobid' when calling OneStepActionsApi->OneStepActionsRunOneStepActionByKeyForRecordByRecIdV1");
            // verify the required parameter 'busobrecid' is set
            if (busobrecid == null)
                throw new ApiException(400, "Missing required parameter 'busobrecid' when calling OneStepActionsApi->OneStepActionsRunOneStepActionByKeyForRecordByRecIdV1");

            var localVarPath = $"/api/V1/runonestepaction/standinkey/{standinkey}/busobid/{busobid}/busobrecid/{busobrecid}";
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

            localVarPathParams.Add("standinkey", Configuration.ApiClient.ParameterToString(standinkey)); // path parameter
            localVarPathParams.Add("busobid", Configuration.ApiClient.ParameterToString(busobid)); // path parameter
            localVarPathParams.Add("busobrecid", Configuration.ApiClient.ParameterToString(busobrecid)); // path parameter
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

            var exception = ExceptionFactory?.Invoke("OneStepActionsRunOneStepActionByKeyForRecordByRecIdV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<OneStepActionResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (OneStepActionResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OneStepActionResponse)));
        }

        #endregion

        #region OneStepActionsRunOneStepActionByStandInKeyV1

        /// <summary>
        /// Run a stand alone One-Step Action Operation to run a One-Step Action that doesn&#39;t run against a Business Object Record.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="standinkey">The key to find the One-Step Action to run</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>OneStepActionResponse</returns>
        public OneStepActionResponse OneStepActionsRunOneStepActionByStandInKeyV1 (string standinkey, string lang = null, string locale = null)
        {
            return OneStepActionsRunOneStepActionByStandInKeyV1WithHttpInfo(standinkey, lang, locale).Data;
        }

        /// <summary>
        /// Run a stand alone One-Step Action Operation to run a One-Step Action that doesn&#39;t run against a Business Object Record.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="standinkey">The key to find the One-Step Action to run</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of OneStepActionResponse</returns>
        private ApiResponse< OneStepActionResponse > OneStepActionsRunOneStepActionByStandInKeyV1WithHttpInfo (string standinkey, string lang = null, string locale = null)
        {
            // verify the required parameter 'standinkey' is set
            if (standinkey == null)
                throw new ApiException(400, "Missing required parameter 'standinkey' when calling OneStepActionsApi->OneStepActionsRunOneStepActionByStandInKeyV1");

            var localVarPath = $"/api/V1/runonestepaction/standinkey/{standinkey}";
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

            localVarPathParams.Add("standinkey", Configuration.ApiClient.ParameterToString(standinkey)); // path parameter
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

            var exception = ExceptionFactory?.Invoke("OneStepActionsRunOneStepActionByStandInKeyV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<OneStepActionResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (OneStepActionResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OneStepActionResponse)));
        }

        #endregion

        #region OneStepActionsRunOneStepActionV1

        /// <summary>
        /// Run a One-Step Action using a OneStepActionRequest Operation to run a One-Step Action using a OneStepActionRequest. This request is used to start a One-Step Action run with additional information such as prompt values.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object containing all the properties need to start a One-Step Action.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>OneStepActionResponse</returns>
        public OneStepActionResponse OneStepActionsRunOneStepActionV1 (OneStepActionRequest request, string lang = null, string locale = null)
        {
             return OneStepActionsRunOneStepActionV1WithHttpInfo(request, lang, locale).Data;
        }

        /// <summary>
        /// Run a One-Step Action using a OneStepActionRequest Operation to run a One-Step Action using a OneStepActionRequest. This request is used to start a One-Step Action run with additional information such as prompt values.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object containing all the properties need to start a One-Step Action.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsOneStepActionsOneStepActionResponse</returns>
        private ApiResponse< OneStepActionResponse > OneStepActionsRunOneStepActionV1WithHttpInfo (OneStepActionRequest request, string lang = null, string locale = null)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling OneStepActionsApi->OneStepActionsRunOneStepActionV1");

            const string varPath = "/api/V1/runonestepaction";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody;

           
            var localVarHttpContentType = ApiClient.SelectHeaderContentType(LocalVarHttpContentTypes);

            var localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(LocalVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (lang != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter
            if (request.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }

            // authentication (oauth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            var localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(varPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int) localVarResponse.StatusCode;

            var exception = ExceptionFactory?.Invoke("OneStepActionsRunOneStepActionV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<OneStepActionResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (OneStepActionResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OneStepActionResponse)));
        }

        #endregion
    }
}
