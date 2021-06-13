
using CherwellConnector.Interface;

namespace CherwellConnector.Api
{
    using System.Collections.Generic;
    using System.Linq;

    using Client;
    using Model;

    using RestSharp;
    
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CoreApi :BaseApi, ICoreApi
    {
        #region Variables & Properties
        
        private static CoreApi _instance;

        private static readonly object Padlock = new();
        
        public static CoreApi Instance
        {
            get
            {
                lock (Padlock)
                {
                    return _instance ??= new CoreApi();
                }
            }
            set => _instance = value;
        }
        
        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CoreApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CoreApi(string basePath)
        {
            Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CoreApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CoreApi(Configuration configuration = null)
        {
            Configuration = configuration ?? Configuration.Default;

            ExceptionFactory = Configuration.DefaultExceptionFactory;
        }

        #endregion

        #region CoreDeleteGalleryImageByStandInKeyV1

        /// <summary>
        /// Delete a gallery image Endpoint to delete a gallery image.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="standinkey">The StandIn key for the gallery image to delete.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Object</returns>
        public object CoreDeleteGalleryImageByStandInKeyV1 (string standinkey, string lang = null, string locale = null)
        {
             return CoreDeleteGalleryImageByStandInKeyV1WithHttpInfo(standinkey, lang, locale).Data;
        }

        /// <summary>
        /// Delete a gallery image Endpoint to delete a gallery image.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="standinkey">The StandIn key for the gallery image to delete.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of Object</returns>
        private ApiResponse<object> CoreDeleteGalleryImageByStandInKeyV1WithHttpInfo (string standinkey, string lang = null, string locale = null)
        {
            // verify the required parameter 'standinkey' is set
            if (standinkey == null)
                throw new ApiException(400, "Missing required parameter 'standinkey' when calling CoreApi->CoreDeleteGalleryImageByStandInKeyV1");

            var localVarPath = $"/api/V1/deletegalleryimage/standinkey/{standinkey}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();

            // to determine the Content-Type header
            var localVarHttpContentTypes = System.Array.Empty<string>();
            var localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            var localVarHttpHeaderAccepts = System.Array.Empty<string>();
            var localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
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
                Method.DELETE, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int) localVarResponse.StatusCode;

            var exception = ExceptionFactory?.Invoke("CoreDeleteGalleryImageByStandInKeyV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                null);
        }

        #endregion

        #region CoreGetGalleryImageV1

        /// <summary>
        /// Get built-in images Operation that gets built-in images. If you are requesting an icon (.ico), you can specify width and height.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Image name and folder location in the Image Manager. Parameter must begin with \&quot;[PlugIn]Images;\&quot; and then a period-separated list of folders. Example: \&quot;[PlugIn]Images;Images.Common.Cherwell.ico\&quot;.</param>
        /// <param name="width">Specify the width (icons only). (optional)</param>
        /// <param name="height">Specify the height (icons only). (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>string</returns>
        public string CoreGetGalleryImageV1 (string name, int? width = null, int? height = null, string lang = null, string locale = null)
        {
            return CoreGetGalleryImageV1WithHttpInfo(name, width, height, lang, locale).Data;
        }

        /// <summary>
        /// Get built-in images Operation that gets built-in images. If you are requesting an icon (.ico), you can specify width and height.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Image name and folder location in the Image Manager. Parameter must begin with \&quot;[PlugIn]Images;\&quot; and then a period-separated list of folders. Example: \&quot;[PlugIn]Images;Images.Common.Cherwell.ico\&quot;.</param>
        /// <param name="width">Specify the width (icons only). (optional)</param>
        /// <param name="height">Specify the height (icons only). (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of string</returns>
        private ApiResponse< string > CoreGetGalleryImageV1WithHttpInfo (string name, int? width = null, int? height = null, string lang = null, string locale = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling CoreApi->CoreGetGalleryImageV1");

            var localVarPath = $"/api/V1/getgalleryimage/name/{name}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();

            // to determine the Content-Type header
            var localVarHttpContentTypes = System.Array.Empty<string>();
            var localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

          
            var localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(LocalVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            localVarPathParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // path parameter
            if (width != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "width", width)); // query parameter
            if (height != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "height", height)); // query parameter
            if (lang != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter


            // make the HTTP request
            var localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int) localVarResponse.StatusCode;

            var exception = ExceptionFactory?.Invoke("CoreGetGalleryImageV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

        #endregion

        #region CoreGetGalleryImagesFolderV1

        /// <summary>
        /// Get gallery images by scope, scopeowner, and folder Get gallery images for the specified scope, scopeowner, and folder.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope to get gallery images for.</param>
        /// <param name="scopeowner">the scopeowner to get gallery images for.</param>
        /// <param name="folder">The folder to get gallery images for.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ManagerData</returns>
        public ManagerData CoreGetGalleryImagesFolderV1 (string scope, string scopeowner, string folder, bool? links = null, string lang = null, string locale = null)
        {
            return CoreGetGalleryImagesFolderV1WithHttpInfo(scope, scopeowner, folder, links, lang, locale).Data;
        }

        /// <summary>
        /// Get gallery images by scope, scopeowner, and folder Get gallery images for the specified scope, scopeowner, and folder.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope to get gallery images for.</param>
        /// <param name="scopeowner">the scopeowner to get gallery images for.</param>
        /// <param name="folder">The folder to get gallery images for.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of ManagerData</returns>
        private ApiResponse< ManagerData > CoreGetGalleryImagesFolderV1WithHttpInfo (string scope, string scopeowner, string folder, bool? links = null, string lang = null, string locale = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling CoreApi->CoreGetGalleryImagesFolderV1");
            // verify the required parameter 'scopeowner' is set
            if (scopeowner == null)
                throw new ApiException(400, "Missing required parameter 'scopeowner' when calling CoreApi->CoreGetGalleryImagesFolderV1");
            // verify the required parameter 'folder' is set
            if (folder == null)
                throw new ApiException(400, "Missing required parameter 'folder' when calling CoreApi->CoreGetGalleryImagesFolderV1");

            var localVarPath = $"/api/V1/getgalleryimages/scope/{scope}/scopeowner/{scopeowner}/folder/{folder}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();

            // to determine the Content-Type header
            var localVarHttpContentTypes = System.Array.Empty<string>();
            var localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            var localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(LocalVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

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

            var exception = ExceptionFactory?.Invoke("CoreGetGalleryImagesFolderV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<ManagerData>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (ManagerData) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManagerData)));
        }

        #endregion

        #region CoreGetGalleryImagesScopeOwnerV1

         /// <summary>
        /// Get gallery images by scope and scopeowner Get all gallery images for the specified scope and scope owner.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope to get gallery images for.</param>
        /// <param name="scopeowner">The scopeowner to get gallery images for.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ManagerData</returns>
        public ManagerData CoreGetGalleryImagesScopeOwnerV1 (string scope, string scopeowner, bool? links = null, string lang = null, string locale = null)
        {
            return CoreGetGalleryImagesScopeOwnerV1WithHttpInfo(scope, scopeowner, links, lang, locale).Data;
        }

        /// <summary>
        /// Get gallery images by scope and scopeowner Get all gallery images for the specified scope and scope owner.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope to get gallery images for.</param>
        /// <param name="scopeowner">The scopeowner to get gallery images for.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of ManagerData</returns>
        private ApiResponse<ManagerData> CoreGetGalleryImagesScopeOwnerV1WithHttpInfo(string scope, string scopeowner,
            bool? links = null, string lang = null, string locale = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400,
                    "Missing required parameter 'scope' when calling CoreApi->CoreGetGalleryImagesScopeOwnerV1");
            // verify the required parameter 'scopeowner' is set
            if (scopeowner == null)
                throw new ApiException(400,
                    "Missing required parameter 'scopeowner' when calling CoreApi->CoreGetGalleryImagesScopeOwnerV1");

            var localVarPath = $"/api/V1/getgalleryimages/scope/{scope}/scopeowner/{scopeowner}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();

            // to determine the Content-Type header
            var localVarHttpContentTypes = System.Array.Empty<string>();
            var localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

           
            var localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(LocalVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            localVarPathParams.Add("scope", Configuration.ApiClient.ParameterToString(scope)); // path parameter
            localVarPathParams.Add("scopeowner",
                Configuration.ApiClient.ParameterToString(scopeowner)); // path parameter
            if (links != null)
                localVarQueryParams.AddRange(
                    Configuration.ApiClient.ParameterToKeyValuePairs("", "links", links)); // query parameter
            if (lang != null)
                localVarQueryParams.AddRange(
                    Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null)
                localVarQueryParams.AddRange(
                    Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            var localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, null, localVarHeaderParams, localVarFormParams,
                localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int) localVarResponse.StatusCode;

            var exception = ExceptionFactory?.Invoke("CoreGetGalleryImagesScopeOwnerV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<ManagerData>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (ManagerData) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManagerData)));
        }

        #endregion

        #region CoreGetGalleryImagesScopeV1

        /// <summary>
        /// Get gallery images by scope Get all gallery images for the specified scope.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope to get the images for.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ManagerData</returns>
        public ManagerData CoreGetGalleryImagesScopeV1 (string scope, bool? links = null, string lang = null, string locale = null)
        {
             return CoreGetGalleryImagesScopeV1WithHttpInfo(scope, links, lang, locale).Data;
        }

        /// <summary>
        /// Get gallery images by scope Get all gallery images for the specified scope.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope to get the images for.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of ManagerData</returns>
        private ApiResponse< ManagerData > CoreGetGalleryImagesScopeV1WithHttpInfo (string scope, bool? links = null, string lang = null, string locale = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling CoreApi->CoreGetGalleryImagesScopeV1");

            var localVarPath = $"/api/V1/getgalleryimages/scope/{scope}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();

            // to determine the Content-Type header
            var localVarHttpContentTypes = System.Array.Empty<string>();
            var localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

           
            var localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(LocalVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

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

            var exception = ExceptionFactory?.Invoke("CoreGetGalleryImagesScopeV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<ManagerData>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (ManagerData) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManagerData)));
        }

        #endregion

        #region CoreGetGalleryImagesV1

        /// <summary>
        /// Get all gallery images Get all the gallery images in the system.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="links">Flag to include hyperlinks in results. Default is false. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ManagerData</returns>
        public ManagerData CoreGetGalleryImagesV1 (bool? links = null, string lang = null, string locale = null)
        {
            return CoreGetGalleryImagesV1WithHttpInfo(links, lang, locale).Data;
        }

        /// <summary>
        /// Get all gallery images Get all the gallery images in the system.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="links">Flag to include hyperlinks in results. Default is false. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of ManagerData</returns>
        private ApiResponse< ManagerData > CoreGetGalleryImagesV1WithHttpInfo (bool? links = null, string lang = null, string locale = null)
        {

            const string varPath = "/api/V1/getgalleryimages";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();

            // to determine the Content-Type header
            var localVarHttpContentTypes = System.Array.Empty<string>();
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

            var exception = ExceptionFactory?.Invoke("CoreGetGalleryImagesV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<ManagerData>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (ManagerData) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManagerData)));
        }

        #endregion

        #region CoreGetStoredValueV1

        /// <summary>
        /// Get a  stored value Get a stored value by its StandIn key.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="standInKey">The StandIn key for the Stored Value you would like to retrieve.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>StoredValueResponse</returns>
        public StoredValueResponse CoreGetStoredValueV1 (string standInKey, string lang = null, string locale = null)
        {
            return CoreGetStoredValueV1WithHttpInfo(standInKey, lang, locale).Data;
        }

        /// <summary>
        /// Get a  stored value Get a stored value by its StandIn key.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="standInKey">The StandIn key for the Stored Value you would like to retrieve.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of StoredValueResponse</returns>
        private ApiResponse< StoredValueResponse > CoreGetStoredValueV1WithHttpInfo (string standInKey, string lang = null, string locale = null)
        {
            // verify the required parameter 'standInKey' is set
            if (standInKey == null)
                throw new ApiException(400, "Missing required parameter 'standInKey' when calling CoreApi->CoreGetStoredValueV1");

            var localVarPath = $"/api/V1/getstoredvalue/standinkey/{standInKey}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();

            // to determine the Content-Type header
            var localVarHttpContentTypes = System.Array.Empty<string>();
            var localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            var localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(LocalVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            localVarPathParams.Add("standInKey", Configuration.ApiClient.ParameterToString(standInKey)); // path parameter
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

            var exception = ExceptionFactory?.Invoke("CoreGetStoredValueV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<StoredValueResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (StoredValueResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StoredValueResponse)));
        }

        #endregion

        #region CoreGetStoredValuesFolderV1

        /// <summary>
        /// Get stored values by folder Get stored values for the specified folder.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope for which to get stored values.</param>
        /// <param name="scopeowner">The scope owner for which to get stored values.</param>
        /// <param name="folder">The folder for which to get stored values.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ManagerData</returns>
        public ManagerData CoreGetStoredValuesFolderV1 (string scope, string scopeowner, string folder, bool? links = null, string lang = null, string locale = null)
        {
            return CoreGetStoredValuesFolderV1WithHttpInfo(scope, scopeowner, folder, links, lang, locale).Data;
        }

        /// <summary>
        /// Get stored values by folder Get stored values for the specified folder.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope for which to get stored values.</param>
        /// <param name="scopeowner">The scope owner for which to get stored values.</param>
        /// <param name="folder">The folder for which to get stored values.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of ManagerData</returns>
        private ApiResponse<ManagerData> CoreGetStoredValuesFolderV1WithHttpInfo (string scope, string scopeowner, string folder, bool? links = null, string lang = null, string locale = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling CoreApi->CoreGetStoredValuesFolderV1");
            // verify the required parameter 'scopeowner' is set
            if (scopeowner == null)
                throw new ApiException(400, "Missing required parameter 'scopeowner' when calling CoreApi->CoreGetStoredValuesFolderV1");
            // verify the required parameter 'folder' is set
            if (folder == null)
                throw new ApiException(400, "Missing required parameter 'folder' when calling CoreApi->CoreGetStoredValuesFolderV1");

            var localVarPath = $"/api/V1/storedvalues/scope/{scope}/scopeowner/{scopeowner}/folder/{folder}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();

            // to determine the Content-Type header
            var localVarHttpContentTypes = System.Array.Empty<string>();
            var localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            
            var localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(LocalVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

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

            var exception = ExceptionFactory?.Invoke("CoreGetStoredValuesFolderV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<ManagerData>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (ManagerData) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManagerData)));
        }

        #endregion

        #region CoreGetStoredValuesScopeOwnerV1

        /// <summary>
        /// Get stored values by scope owner Get stored values for the specified scope and scope owner.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope for which to get stored values.</param>
        /// <param name="scopeowner">The scope owner for which to get stored values.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ManagerData</returns>
        public ManagerData CoreGetStoredValuesScopeOwnerV1 (string scope, string scopeowner, bool? links = null, string lang = null, string locale = null)
        {
            return CoreGetStoredValuesScopeOwnerV1WithHttpInfo(scope, scopeowner, links, lang, locale).Data;
        }

        /// <summary>
        /// Get stored values by scope owner Get stored values for the specified scope and scope owner.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope for which to get stored values.</param>
        /// <param name="scopeowner">The scope owner for which to get stored values.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of ManagerData</returns>
        private ApiResponse< ManagerData > CoreGetStoredValuesScopeOwnerV1WithHttpInfo (string scope, string scopeowner, bool? links = null, string lang = null, string locale = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling CoreApi->CoreGetStoredValuesScopeOwnerV1");
            // verify the required parameter 'scopeowner' is set
            if (scopeowner == null)
                throw new ApiException(400, "Missing required parameter 'scopeowner' when calling CoreApi->CoreGetStoredValuesScopeOwnerV1");

            var localVarPath = $"/api/V1/storedvalues/scope/{scope}/scopeowner/{scopeowner}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();

            // to determine the Content-Type header
            var localVarHttpContentTypes = System.Array.Empty<string>();
            var localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            var localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(LocalVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

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

            var exception = ExceptionFactory?.Invoke("CoreGetStoredValuesScopeOwnerV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<ManagerData>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (ManagerData) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManagerData)));
        }

        #endregion

        #region MyRegion

         /// <summary>
        /// Get stored values by scope Get all the stored values for the specified scope.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope for which to get stored values.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ManagerData</returns>
        public ManagerData CoreGetStoredValuesScopeV1 (string scope, bool? links = null, string lang = null, string locale = null)
        {
            return CoreGetStoredValuesScopeV1WithHttpInfo(scope, links, lang, locale).Data;
        }

        /// <summary>
        /// Get stored values by scope Get all the stored values for the specified scope.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope for which to get stored values.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of ManagerData</returns>
        private ApiResponse< ManagerData > CoreGetStoredValuesScopeV1WithHttpInfo (string scope, bool? links = null, string lang = null, string locale = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling CoreApi->CoreGetStoredValuesScopeV1");

            var localVarPath = $"/api/V1/storedvalues/scope/{scope}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();

            // to determine the Content-Type header
            var localVarHttpContentTypes = System.Array.Empty<string>();
            var localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            var localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(LocalVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

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

            var exception = ExceptionFactory?.Invoke("CoreGetStoredValuesScopeV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<ManagerData>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (ManagerData) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManagerData)));
        }

        #endregion

        #region MyRegion

         /// <summary>
        /// Gets all the stored values in the system Get all the stored values in the system.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="links">Flag to include hyperlinks in results. Default is false. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsCoreManagerData</returns>
        public ManagerData CoreGetStoredValuesV1 (bool? links = null, string lang = null, string locale = null)
        {
            return CoreGetStoredValuesV1WithHttpInfo(links, lang, locale).Data;
        }

        /// <summary>
        /// Gets all the stored values in the system Get all the stored values in the system.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="links">Flag to include hyperlinks in results. Default is false. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of ManagerData</returns>
        private ApiResponse< ManagerData > CoreGetStoredValuesV1WithHttpInfo (bool? links = null, string lang = null, string locale = null)
        {

            const string varPath = "/api/V1/storedvalues";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();

            // to determine the Content-Type header
            var localVarHttpContentTypes = System.Array.Empty<string>();
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

            var exception = ExceptionFactory?.Invoke("CoreGetStoredValuesV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<ManagerData>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (ManagerData) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManagerData)));
        }

        #endregion

        #region CoreGetViewsV1

        /// <summary>
        /// Get a list of the views Operation to get a list of views that are configured in the system.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ViewsResponse</returns>
        public ViewsResponse CoreGetViewsV1 (string lang = null, string locale = null)
        {
             return CoreGetViewsV1WithHttpInfo(lang, locale).Data;
        }

        /// <summary>
        /// Get a list of the views Operation to get a list of views that are configured in the system.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of ViewsResponse</returns>
        private ApiResponse< ViewsResponse > CoreGetViewsV1WithHttpInfo (string lang = null, string locale = null)
        {

            const string varPath = "/api/V1/getviews";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();

            // to determine the Content-Type header
            var localVarHttpContentTypes = System.Array.Empty<string>();
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

            var exception = ExceptionFactory?.Invoke("CoreGetViewsV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<ViewsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (ViewsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ViewsResponse)));
        }

        #endregion

        #region CoreSaveGalleryImageV1

        /// <summary>
        /// Create or update a gallery image Endpoint to Create or update a gallery image. To create a new gallery image leave the StandIn key blank. To update a gallery image provide the StandIn key of the gallery image you want to update.&lt;/br&gt;There are three different ImageTypes allowed: Imported, Url, and File. To use the Imported image type, provide the filename in the Name property, with extension, and provide the image data in a Base64 encoded format in the Base64EncodedImageData property. The max file size is 512k.&lt;/br&gt;To use the Url image type,  provide the full network share path to the file in the Name property, ie: \&quot;\\\\\\\\\\\\\\\\networkshare\\\\\\somefolder\\\\\\somefile.jpg\&quot;. If the file is not accessible to all users it will not visible to all users.&lt;/br&gt;To use the File image type, provide the full path to the file in the Name property, ie: \&quot;C:\\\\\\somefolder\\\\\\somfile.jpg\&quot;. If the file is not accessible to all users it will not visible to all users.&lt;/br&gt;When creating or updating an image, Name and ImageType are always required, and if the image type is \&quot;Imported\&quot;, then the Base64EncodedImageData is also required. &lt;/br&gt;scope, scopeowner, and folder can all be updated independently.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">To create a new gallery image leave the StandIn key blank. To update a gallery image provide the StandIn key of the gallery image you want to update.&lt;/br&gt;There are three different ImageTypes allowed: Imported, Url, and File. To use the Imported image type, provide the filename in the Name property, with extension, and provide the image data in a Base64 encoded format in the Base64EncodedImageData property. The max file size is 512k.&lt;/br&gt;To use the Url image type,  provide the full network share path to the file in the Name property, ie: \&quot;\\\\\\\\\\\\\\\\networkshare\\\\\\somefolder\\\\\\somefile.jpg\&quot;. If the file is not accessible to all users it will not visible to all users.&lt;/br&gt;To use the File image type, provide the full path to the file in the Name property, ie: \&quot;C:\\\\\\somefolder\\\\\\somfile.jpg\&quot;. If the file is not accessible to all users it will not visible to all users.&lt;/br&gt;When creating or updating an image, Name and ImageType are always required, and if the image type is \&quot;Imported\&quot;, then the Base64EncodedImageData is also required. &lt;/br&gt;scope, scopeowner, and folder can all be updated independently.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>SaveGalleryImageResponse</returns>
        public SaveGalleryImageResponse CoreSaveGalleryImageV1 (SaveGalleryImageRequest request, string lang = null, string locale = null)
        {
            return CoreSaveGalleryImageV1WithHttpInfo(request, lang, locale).Data;
        }

        /// <summary>
        /// Create or update a gallery image Endpoint to Create or update a gallery image. To create a new gallery image leave the StandIn key blank. To update a gallery image provide the StandIn key of the gallery image you want to update.&lt;/br&gt;There are three different ImageTypes allowed: Imported, Url, and File. To use the Imported image type, provide the filename in the Name property, with extension, and provide the image data in a Base64 encoded format in the Base64EncodedImageData property. The max file size is 512k.&lt;/br&gt;To use the Url image type,  provide the full network share path to the file in the Name property, ie: \&quot;\\\\\\\\\\\\\\\\networkshare\\\\\\somefolder\\\\\\somefile.jpg\&quot;. If the file is not accessible to all users it will not visible to all users.&lt;/br&gt;To use the File image type, provide the full path to the file in the Name property, ie: \&quot;C:\\\\\\somefolder\\\\\\somfile.jpg\&quot;. If the file is not accessible to all users it will not visible to all users.&lt;/br&gt;When creating or updating an image, Name and ImageType are always required, and if the image type is \&quot;Imported\&quot;, then the Base64EncodedImageData is also required. &lt;/br&gt;scope, scopeowner, and folder can all be updated independently.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">To create a new gallery image leave the StandIn key blank. To update a gallery image provide the StandIn key of the gallery image you want to update.&lt;/br&gt;There are three different ImageTypes allowed: Imported, Url, and File. To use the Imported image type, provide the filename in the Name property, with extension, and provide the image data in a Base64 encoded format in the Base64EncodedImageData property. The max file size is 512k.&lt;/br&gt;To use the Url image type,  provide the full network share path to the file in the Name property, ie: \&quot;\\\\\\\\\\\\\\\\networkshare\\\\\\somefolder\\\\\\somefile.jpg\&quot;. If the file is not accessible to all users it will not visible to all users.&lt;/br&gt;To use the File image type, provide the full path to the file in the Name property, ie: \&quot;C:\\\\\\somefolder\\\\\\somfile.jpg\&quot;. If the file is not accessible to all users it will not visible to all users.&lt;/br&gt;When creating or updating an image, Name and ImageType are always required, and if the image type is \&quot;Imported\&quot;, then the Base64EncodedImageData is also required. &lt;/br&gt;scope, scopeowner, and folder can all be updated independently.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of SaveGalleryImageResponse</returns>
        private ApiResponse< SaveGalleryImageResponse > CoreSaveGalleryImageV1WithHttpInfo (SaveGalleryImageRequest request, string lang = null, string locale = null)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling CoreApi->CoreSaveGalleryImageV1");

            const string varPath = "/api/V1/savegalleryimage";
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

            var exception = ExceptionFactory?.Invoke("CoreSaveGalleryImageV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<SaveGalleryImageResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (SaveGalleryImageResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SaveGalleryImageResponse)));
        }

        #endregion

        #region CoreSaveStoredValueV1

         /// <summary>
        /// Create or update a stored value Operation to create or update a stored value. To update, specify the StandIn key for the stored value to update. To create leave StandIn key blank, and provide a name, a scope, a type, and a value.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">The stored value to create or update. To update include the StandIn key for the associated stored value. To create, name, scope, type, and value are required.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>StoredValueResponse</returns>
        public StoredValueResponse CoreSaveStoredValueV1 (SaveStoredValueRequest request, string lang = null, string locale = null)
        {
            return CoreSaveStoredValueV1WithHttpInfo(request, lang, locale).Data;
        }

        /// <summary>
        /// Create or update a stored value Operation to create or update a stored value. To update, specify the StandIn key for the stored value to update. To create leave StandIn key blank, and provide a name, a scope, a type, and a value.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">The stored value to create or update. To update include the StandIn key for the associated stored value. To create, name, scope, type, and value are required.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of StoredValueResponse</returns>
        private ApiResponse< StoredValueResponse > CoreSaveStoredValueV1WithHttpInfo (SaveStoredValueRequest request, string lang = null, string locale = null)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling CoreApi->CoreSaveStoredValueV1");

            const string varPath = "/api/V1/savestoredvalue";
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

            var exception = ExceptionFactory?.Invoke("CoreSaveStoredValueV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<StoredValueResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (StoredValueResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StoredValueResponse)));
        }

        #endregion

        #region CoreSetCultureV1

        /// <summary>
        /// Set the culture for the current user Operation to update the current users culture by culture code. This returns a new access token that has the updated information in it.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="culturecode">The culture code to set for the current user.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>string</returns>
        public string CoreSetCultureV1 (string culturecode, string lang = null, string locale = null)
        {
            return CoreSetCultureV1WithHttpInfo(culturecode, lang, locale).Data;
        }

        /// <summary>
        /// Set the culture for the current user Operation to update the current users culture by culture code. This returns a new access token that has the updated information in it.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="culturecode">The culture code to set for the current user.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of string</returns>
        private ApiResponse< string > CoreSetCultureV1WithHttpInfo (string culturecode, string lang = null, string locale = null)
        {
            // verify the required parameter 'culturecode' is set
            if (culturecode == null)
                throw new ApiException(400, "Missing required parameter 'culturecode' when calling CoreApi->CoreSetCultureV1");

            var localVarPath = $"/api/V1/setculture/culturecode/{culturecode}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();

            // to determine the Content-Type header
            var localVarHttpContentTypes = System.Array.Empty<string>();
            var localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

           
            var localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(LocalVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            localVarPathParams.Add("culturecode", Configuration.ApiClient.ParameterToString(culturecode)); // path parameter
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
                Method.PUT, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int) localVarResponse.StatusCode;

            var exception = ExceptionFactory?.Invoke("CoreSetCultureV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

        #endregion

    }
}
