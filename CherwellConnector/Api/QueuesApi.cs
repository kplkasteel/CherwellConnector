using System;
using System.Collections.Generic;
using System.Linq;
using CherwellConnector.Client;
using CherwellConnector.Interface;
using CherwellConnector.Model;
using RestSharp;

namespace CherwellConnector.Api
{
    /// <summary>
    ///     Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class QueuesApi : BaseApi, IQueuesApi
    {
        #region Variables & Properties

        private static QueuesApi _instance;

        private static readonly object Padlock = new();

        public static QueuesApi Instance
        {
            get
            {
                lock (Padlock)
                {
                    return _instance ??= new QueuesApi();
                }
            }
            set => _instance = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="QueuesApi" /> class.
        /// </summary>
        /// <returns></returns>
        public QueuesApi(string basePath)
        {
            Configuration = new Configuration {BasePath = basePath};

            ExceptionFactory = Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="QueuesApi" /> class
        ///     using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public QueuesApi(Configuration configuration = null)
        {
            Configuration = configuration ?? Configuration.Default;

            ExceptionFactory = Configuration.DefaultExceptionFactory;
        }

        #endregion

        #region AddItemToQueueResponse

        /// <summary>
        ///     Add a Business Object to a queue Operation to add a Business Object to a queue
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">
        ///     Request object containing all properties necessary to add an item to a queue. All properties are
        ///     required. The standin key defines the queue to which we want to add the Business Object.
        /// </param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>QueuesAddItemToQueueV1</returns>
        public AddItemToQueueResponse QueuesAddItemToQueueV1(AddItemToQueueRequest request, string lang = null,
            string locale = null)
        {
            return QueuesAddItemToQueueV1WithHttpInfo(request, lang, locale).Data;
        }

        /// <summary>
        ///     Add a Business Object to a queue Operation to add a Business Object to a queue
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">
        ///     Request object containing all properties necessary to add an item to a queue. All properties are
        ///     required. The standin key defines the queue to which we want to add the Business Object.
        /// </param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>ApiResponse of QueuesAddItemToQueueV1</returns>
        private ApiResponse<AddItemToQueueResponse> QueuesAddItemToQueueV1WithHttpInfo(AddItemToQueueRequest request,
            string lang = null, string locale = null)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling QueuesApi->QueuesAddItemToQueueV1");

            const string varPath = "/api/V1/additemtoqueue";
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

            if (lang != null)
                localVarQueryParams.AddRange(
                    Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null)
                localVarQueryParams.AddRange(
                    Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter
            if (request.GetType() != typeof(byte[]))
                localVarPostBody = Configuration.ApiClient.Serialize(request); // http body (model) parameter
            else
                localVarPostBody = request; // byte array

            // authentication (oauth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken))
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;

            // make the HTTP request
            var localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(varPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
                localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int) localVarResponse.StatusCode;

            var exception = ExceptionFactory?.Invoke("QueuesAddItemToQueueV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<AddItemToQueueResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (AddItemToQueueResponse) Configuration.ApiClient.Deserialize(localVarResponse,
                    typeof(AddItemToQueueResponse)));
        }

        #endregion

        #region QueuesCheckInQueueItemV1

        /// <summary>
        ///     Check a Business Object in to a queue Operation to check in a queue item
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">
        ///     The request object for checking in an item to a queue. All properties are required except for
        ///     historyNotes
        /// </param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>CheckInQueueItemResponse</returns>
        public CheckInQueueItemResponse QueuesCheckInQueueItemV1(CheckInQueueItemRequest request, string lang = null,
            string locale = null)
        {
            return QueuesCheckInQueueItemV1WithHttpInfo(request, lang, locale).Data;
        }

        /// <summary>
        ///     Check a Business Object in to a queue Operation to check in a queue item
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">
        ///     The request object for checking in an item to a queue. All properties are required except for
        ///     historyNotes
        /// </param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>ApiResponse of CheckInQueueItemResponse</returns>
        private ApiResponse<CheckInQueueItemResponse> QueuesCheckInQueueItemV1WithHttpInfo(
            CheckInQueueItemRequest request, string lang = null, string locale = null)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling QueuesApi->QueuesCheckInQueueItemV1");

            const string varPath = "/api/V1/checkinqueueitem";
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

            if (lang != null)
                localVarQueryParams.AddRange(
                    Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null)
                localVarQueryParams.AddRange(
                    Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter
            if (request.GetType() != typeof(byte[]))
                localVarPostBody = Configuration.ApiClient.Serialize(request); // http body (model) parameter
            else
                localVarPostBody = request; // byte array

            // authentication (oauth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken))
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;

            // make the HTTP request
            var localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(varPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
                localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int) localVarResponse.StatusCode;

            var exception = ExceptionFactory?.Invoke("QueuesCheckInQueueItemV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<CheckInQueueItemResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (CheckInQueueItemResponse) Configuration.ApiClient.Deserialize(localVarResponse,
                    typeof(CheckInQueueItemResponse)));
        }

        #endregion

        #region QueuesCheckOutQueueItemV1

        /// <summary>
        ///     Check a Business Object out of a queue Operation to check out a queue item
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">
        ///     The request object for checking out an item from a queue. All properties are required except for
        ///     historyNotes
        /// </param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>CheckOutQueueItemResponse</returns>
        public CheckOutQueueItemResponse QueuesCheckOutQueueItemV1(CheckOutQueueItemRequest request, string lang = null,
            string locale = null)
        {
            return QueuesCheckOutQueueItemV1WithHttpInfo(request, lang, locale).Data;
        }

        /// <summary>
        ///     Check a Business Object out of a queue Operation to check out a queue item
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">
        ///     The request object for checking out an item from a queue. All properties are required except for
        ///     historyNotes
        /// </param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>ApiResponse of CheckOutQueueItemResponse</returns>
        private ApiResponse<CheckOutQueueItemResponse> QueuesCheckOutQueueItemV1WithHttpInfo(
            CheckOutQueueItemRequest request, string lang = null, string locale = null)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling QueuesApi->QueuesCheckOutQueueItemV1");

            const string varPath = "/api/V1/checkoutqueueitem";
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

            if (lang != null)
                localVarQueryParams.AddRange(
                    Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null)
                localVarQueryParams.AddRange(
                    Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter
            if (request.GetType() != typeof(byte[]))
                localVarPostBody = Configuration.ApiClient.Serialize(request); // http body (model) parameter
            else
                localVarPostBody = request; // byte array

            // authentication (oauth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken))
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;

            // make the HTTP request
            var localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(varPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
                localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int) localVarResponse.StatusCode;

            var exception = ExceptionFactory?.Invoke("QueuesCheckOutQueueItemV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<CheckOutQueueItemResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (CheckOutQueueItemResponse) Configuration.ApiClient.Deserialize(localVarResponse,
                    typeof(CheckOutQueueItemResponse)));
        }

        #endregion

        #region QueuesGetQueuesFolderV1

        /// <summary>
        ///     Get available queues. Get available queues for a specific Business Object type based on scope, scope owner, and
        ///     folder.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope to get available queues for.</param>
        /// <param name="scopeowner">The scope owner to get available queues for.</param>
        /// <param name="folder">
        ///     The folder to get available queues for.  This has to be the folder ID which can be retrieved by
        ///     doing a getqueues operation without the folder including links option then the links will have the folder IDs.
        /// </param>
        /// <param name="links">Whether or not to include links. (optional)</param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>ManagerData</returns>
        public ManagerData QueuesGetQueuesFolderV1(string scope, string scopeowner, string folder, bool? links = null,
            string lang = null, string locale = null)
        {
            return QueuesGetQueuesFolderV1WithHttpInfo(scope, scopeowner, folder, links, lang, locale).Data;
        }

        /// <summary>
        ///     Get available queues. Get available queues for a specific Business Object type based on scope, scope owner, and
        ///     folder.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope to get available queues for.</param>
        /// <param name="scopeowner">The scope owner to get available queues for.</param>
        /// <param name="folder">
        ///     The folder to get available queues for.  This has to be the folder ID which can be retrieved by
        ///     doing a getqueues operation without the folder including links option then the links will have the folder IDs.
        /// </param>
        /// <param name="links">Whether or not to include links. (optional)</param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>ApiResponse of ManagerData</returns>
        private ApiResponse<ManagerData> QueuesGetQueuesFolderV1WithHttpInfo(string scope, string scopeowner,
            string folder, bool? links = null, string lang = null, string locale = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400,
                    "Missing required parameter 'scope' when calling QueuesApi->QueuesGetQueuesFolderV1");
            // verify the required parameter 'scopeowner' is set
            if (scopeowner == null)
                throw new ApiException(400,
                    "Missing required parameter 'scopeowner' when calling QueuesApi->QueuesGetQueuesFolderV1");
            // verify the required parameter 'folder' is set
            if (folder == null)
                throw new ApiException(400,
                    "Missing required parameter 'folder' when calling QueuesApi->QueuesGetQueuesFolderV1");

            var localVarPath = $"/api/V1/getqueues/scope/{scope}/scopeowner/{scopeowner}/folder/{folder}";
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

            localVarPathParams.Add("scope", Configuration.ApiClient.ParameterToString(scope)); // path parameter
            localVarPathParams.Add("scopeowner",
                Configuration.ApiClient.ParameterToString(scopeowner)); // path parameter
            localVarPathParams.Add("folder", Configuration.ApiClient.ParameterToString(folder)); // path parameter
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
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;

            // make the HTTP request
            var localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int) localVarResponse.StatusCode;

            var exception = ExceptionFactory?.Invoke("QueuesGetQueuesFolderV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<ManagerData>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (ManagerData) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManagerData)));
        }

        #endregion

        #region QueuesGetQueuesScopeOwnerV1

        /// <summary>
        ///     Get available queues. Get available queues for a specific Business Object type based on scope, and scope owner.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope to get available queues for.</param>
        /// <param name="scopeowner">The scope owner to get available queues for.</param>
        /// <param name="links">Whether or not to include links. (optional)</param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>ManagerData</returns>
        public ManagerData QueuesGetQueuesScopeOwnerV1(string scope, string scopeowner, bool? links = null,
            string lang = null, string locale = null)
        {
            return QueuesGetQueuesScopeOwnerV1WithHttpInfo(scope, scopeowner, links, lang, locale).Data;
        }

        /// <summary>
        ///     Get available queues. Get available queues for a specific Business Object type based on scope, and scope owner.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope to get available queues for.</param>
        /// <param name="scopeowner">The scope owner to get available queues for.</param>
        /// <param name="links">Whether or not to include links. (optional)</param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>ApiResponse of ManagerData</returns>
        private ApiResponse<ManagerData> QueuesGetQueuesScopeOwnerV1WithHttpInfo(string scope, string scopeowner,
            bool? links = null, string lang = null, string locale = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400,
                    "Missing required parameter 'scope' when calling QueuesApi->QueuesGetQueuesScopeOwnerV1");
            // verify the required parameter 'scopeowner' is set
            if (scopeowner == null)
                throw new ApiException(400,
                    "Missing required parameter 'scopeowner' when calling QueuesApi->QueuesGetQueuesScopeOwnerV1");

            var localVarPath = $"/api/V1/getqueues/scope/{scope}/scopeowner/{scopeowner}";
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
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;

            // make the HTTP request
            var localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int) localVarResponse.StatusCode;

            var exception = ExceptionFactory?.Invoke("QueuesGetQueuesScopeOwnerV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<ManagerData>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (ManagerData) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManagerData)));
        }

        #endregion

        #region QueuesGetQueuesScopeV1

        /// <summary>
        ///     Get available queues. Get available queues for a specific Business Object type based on scope.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope to get available queues for.</param>
        /// <param name="links">Whether or not to include links. (optional)</param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>ManagerData</returns>
        public ManagerData QueuesGetQueuesScopeV1(string scope, bool? links = null, string lang = null,
            string locale = null)
        {
            return QueuesGetQueuesScopeV1WithHttpInfo(scope, links, lang, locale).Data;
        }

        /// <summary>
        ///     Get available queues. Get available queues for a specific Business Object type based on scope.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope to get available queues for.</param>
        /// <param name="links">Whether or not to include links. (optional)</param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>ApiResponse of ManagerData</returns>
        private ApiResponse<ManagerData> QueuesGetQueuesScopeV1WithHttpInfo(string scope, bool? links = null,
            string lang = null, string locale = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400,
                    "Missing required parameter 'scope' when calling QueuesApi->QueuesGetQueuesScopeV1");

            var localVarPath = $"/api/V1/getqueues/scope/{scope}";
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

            localVarPathParams.Add("scope", Configuration.ApiClient.ParameterToString(scope)); // path parameter
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
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;

            // make the HTTP request
            var localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int) localVarResponse.StatusCode;

            var exception = ExceptionFactory?.Invoke("QueuesGetQueuesScopeV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<ManagerData>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (ManagerData) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManagerData)));
        }

        #endregion

        #region QueuesGetQueuesV1

        /// <summary>
        ///     Get available queues. Get available queues for a specific Business Object.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="links">Whether or not to include links. (optional)</param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>ManagerData</returns>
        public ManagerData QueuesGetQueuesV1(bool? links = null, string lang = null, string locale = null)
        {
            return QueuesGetQueuesV1WithHttpInfo(links, lang, locale).Data;
        }

        /// <summary>
        ///     Get available queues. Get available queues for a specific Business Object.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="links">Whether or not to include links. (optional)</param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>ApiResponse of ManagerData</returns>
        private ApiResponse<ManagerData> QueuesGetQueuesV1WithHttpInfo(bool? links = null, string lang = null,
            string locale = null)
        {
            const string varPath = "/api/V1/getqueues";
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
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;

            // make the HTTP request
            var localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(varPath,
                Method.GET, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int) localVarResponse.StatusCode;

            var exception = ExceptionFactory?.Invoke("QueuesGetQueuesV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<ManagerData>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (ManagerData) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManagerData)));
        }

        #endregion

        #region QueuesRemoveItemFromQueueV1

        /// <summary>
        ///     Remove an item from a queue Operation to remove an item from a queue
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">
        ///     The request object to remove an item from a queue. All properties are required except for
        ///     historyNotes
        /// </param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>RemoveItemFromQueueResponse</returns>
        public RemoveItemFromQueueResponse QueuesRemoveItemFromQueueV1(RemoveItemFromQueueRequest request,
            string lang = null, string locale = null)
        {
            return QueuesRemoveItemFromQueueV1WithHttpInfo(request, lang, locale).Data;
        }

        /// <summary>
        ///     Remove an item from a queue Operation to remove an item from a queue
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">
        ///     The request object to remove an item from a queue. All properties are required except for
        ///     historyNotes
        /// </param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>ApiResponse of RemoveItemFromQueueResponse</returns>
        private ApiResponse<RemoveItemFromQueueResponse> QueuesRemoveItemFromQueueV1WithHttpInfo(
            RemoveItemFromQueueRequest request, string lang = null, string locale = null)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling QueuesApi->QueuesRemoveItemFromQueueV1");

            const string varPath = "/api/V1/removeitemfromqueue";
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

            if (lang != null)
                localVarQueryParams.AddRange(
                    Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null)
                localVarQueryParams.AddRange(
                    Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter
            if (request.GetType() != typeof(byte[]))
                localVarPostBody = Configuration.ApiClient.Serialize(request); // http body (model) parameter
            else
                localVarPostBody = request; // byte array

            // authentication (oauth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken))
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;

            // make the HTTP request
            var localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(varPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
                localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int) localVarResponse.StatusCode;

            var exception = ExceptionFactory?.Invoke("QueuesRemoveItemFromQueueV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<RemoveItemFromQueueResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (RemoveItemFromQueueResponse) Configuration.ApiClient.Deserialize(localVarResponse,
                    typeof(RemoveItemFromQueueResponse)));
        }

        #endregion
    }
}