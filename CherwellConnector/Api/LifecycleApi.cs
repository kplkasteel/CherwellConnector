
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
    public partial class LifecycleApi : ILifecycleApi
    {
        private ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="LifecycleApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LifecycleApi(string basePath)
        {
            Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LifecycleApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public LifecycleApi(Configuration configuration = null)
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
        /// Get current lifecycle stage for record Gets the current lifecycle stage of a business object record
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="recordId"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsLifecycleGetRecordStatusResponse</returns>
        public RecordStatusResponse LifecycleGetRecordStage (string businessObjectDefinitionId, string recordId, string lang = null, string locale = null)
        {
             ApiResponse<RecordStatusResponse> localVarResponse = LifecycleGetRecordStageWithHttpInfo(businessObjectDefinitionId, recordId, lang, locale);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get current lifecycle stage for record Gets the current lifecycle stage of a business object record
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="recordId"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsLifecycleGetRecordStatusResponse</returns>
        public ApiResponse< RecordStatusResponse > LifecycleGetRecordStageWithHttpInfo (string businessObjectDefinitionId, string recordId, string lang = null, string locale = null)
        {
            // verify the required parameter 'businessObjectDefinitionId' is set
            if (businessObjectDefinitionId == null)
                throw new ApiException(400, "Missing required parameter 'businessObjectDefinitionId' when calling LifecycleApi->LifecycleGetRecordStage");
            // verify the required parameter 'recordId' is set
            if (recordId == null)
                throw new ApiException(400, "Missing required parameter 'recordId' when calling LifecycleApi->LifecycleGetRecordStage");

            var localVarPath = "/api/V1/{businessObjectDefinitionId}/records/{recordId}/stage";
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

            if (businessObjectDefinitionId != null) localVarPathParams.Add("businessObjectDefinitionId", Configuration.ApiClient.ParameterToString(businessObjectDefinitionId)); // path parameter
            if (recordId != null) localVarPathParams.Add("recordId", Configuration.ApiClient.ParameterToString(recordId)); // path parameter
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
                Exception exception = ExceptionFactory("LifecycleGetRecordStage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RecordStatusResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RecordStatusResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RecordStatusResponse)));
        }

        /// <summary>
        /// Get current lifecycle stage for record Gets the current lifecycle stage of a business object record
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="recordId"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsLifecycleGetRecordStatusResponse</returns>
        public async System.Threading.Tasks.Task<RecordStatusResponse> LifecycleGetRecordStageAsync (string businessObjectDefinitionId, string recordId, string lang = null, string locale = null)
        {
             ApiResponse<RecordStatusResponse> localVarResponse = await LifecycleGetRecordStageAsyncWithHttpInfo(businessObjectDefinitionId, recordId, lang, locale);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get current lifecycle stage for record Gets the current lifecycle stage of a business object record
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="recordId"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsLifecycleGetRecordStatusResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RecordStatusResponse>> LifecycleGetRecordStageAsyncWithHttpInfo (string businessObjectDefinitionId, string recordId, string lang = null, string locale = null)
        {
            // verify the required parameter 'businessObjectDefinitionId' is set
            if (businessObjectDefinitionId == null)
                throw new ApiException(400, "Missing required parameter 'businessObjectDefinitionId' when calling LifecycleApi->LifecycleGetRecordStage");
            // verify the required parameter 'recordId' is set
            if (recordId == null)
                throw new ApiException(400, "Missing required parameter 'recordId' when calling LifecycleApi->LifecycleGetRecordStage");

            var localVarPath = "/api/V1/{businessObjectDefinitionId}/records/{recordId}/stage";
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

            if (businessObjectDefinitionId != null) localVarPathParams.Add("businessObjectDefinitionId", Configuration.ApiClient.ParameterToString(businessObjectDefinitionId)); // path parameter
            if (recordId != null) localVarPathParams.Add("recordId", Configuration.ApiClient.ParameterToString(recordId)); // path parameter
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
                Exception exception = ExceptionFactory("LifecycleGetRecordStage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RecordStatusResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RecordStatusResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RecordStatusResponse)));
        }

        /// <summary>
        /// Get current lifecycle status for record Gets the current lifecycle status of a business object record
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="recordId"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsLifecycleGetRecordStatusResponse</returns>
        public RecordStatusResponse LifecycleGetRecordStatus (string businessObjectDefinitionId, string recordId, string lang = null, string locale = null)
        {
             ApiResponse<RecordStatusResponse> localVarResponse = LifecycleGetRecordStatusWithHttpInfo(businessObjectDefinitionId, recordId, lang, locale);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get current lifecycle status for record Gets the current lifecycle status of a business object record
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="recordId"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsLifecycleGetRecordStatusResponse</returns>
        public ApiResponse< RecordStatusResponse > LifecycleGetRecordStatusWithHttpInfo (string businessObjectDefinitionId, string recordId, string lang = null, string locale = null)
        {
            // verify the required parameter 'businessObjectDefinitionId' is set
            if (businessObjectDefinitionId == null)
                throw new ApiException(400, "Missing required parameter 'businessObjectDefinitionId' when calling LifecycleApi->LifecycleGetRecordStatus");
            // verify the required parameter 'recordId' is set
            if (recordId == null)
                throw new ApiException(400, "Missing required parameter 'recordId' when calling LifecycleApi->LifecycleGetRecordStatus");

            var localVarPath = "/api/V1/{businessObjectDefinitionId}/records/{recordId}/status";
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

            if (businessObjectDefinitionId != null) localVarPathParams.Add("businessObjectDefinitionId", Configuration.ApiClient.ParameterToString(businessObjectDefinitionId)); // path parameter
            if (recordId != null) localVarPathParams.Add("recordId", Configuration.ApiClient.ParameterToString(recordId)); // path parameter
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
                Exception exception = ExceptionFactory("LifecycleGetRecordStatus", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RecordStatusResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RecordStatusResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RecordStatusResponse)));
        }

        /// <summary>
        /// Get current lifecycle status for record Gets the current lifecycle status of a business object record
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="recordId"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsLifecycleGetRecordStatusResponse</returns>
        public async System.Threading.Tasks.Task<RecordStatusResponse> LifecycleGetRecordStatusAsync (string businessObjectDefinitionId, string recordId, string lang = null, string locale = null)
        {
             ApiResponse<RecordStatusResponse> localVarResponse = await LifecycleGetRecordStatusAsyncWithHttpInfo(businessObjectDefinitionId, recordId, lang, locale);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get current lifecycle status for record Gets the current lifecycle status of a business object record
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="recordId"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsLifecycleGetRecordStatusResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RecordStatusResponse>> LifecycleGetRecordStatusAsyncWithHttpInfo (string businessObjectDefinitionId, string recordId, string lang = null, string locale = null)
        {
            // verify the required parameter 'businessObjectDefinitionId' is set
            if (businessObjectDefinitionId == null)
                throw new ApiException(400, "Missing required parameter 'businessObjectDefinitionId' when calling LifecycleApi->LifecycleGetRecordStatus");
            // verify the required parameter 'recordId' is set
            if (recordId == null)
                throw new ApiException(400, "Missing required parameter 'recordId' when calling LifecycleApi->LifecycleGetRecordStatus");

            var localVarPath = "/api/V1/{businessObjectDefinitionId}/records/{recordId}/status";
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

            if (businessObjectDefinitionId != null) localVarPathParams.Add("businessObjectDefinitionId", Configuration.ApiClient.ParameterToString(businessObjectDefinitionId)); // path parameter
            if (recordId != null) localVarPathParams.Add("recordId", Configuration.ApiClient.ParameterToString(recordId)); // path parameter
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
                Exception exception = ExceptionFactory("LifecycleGetRecordStatus", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RecordStatusResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RecordStatusResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RecordStatusResponse)));
        }

        /// <summary>
        /// Get lifecycle stages Gets all of the stages on the lifecycle for a Business Object
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsLifecycleGetStagesResponse</returns>
        public StagesResponse LifecycleGetStages (string businessObjectDefinitionId, string lang = null, string locale = null)
        {
             ApiResponse<StagesResponse> localVarResponse = LifecycleGetStagesWithHttpInfo(businessObjectDefinitionId, lang, locale);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get lifecycle stages Gets all of the stages on the lifecycle for a Business Object
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsLifecycleGetStagesResponse</returns>
        public ApiResponse< StagesResponse > LifecycleGetStagesWithHttpInfo (string businessObjectDefinitionId, string lang = null, string locale = null)
        {
            // verify the required parameter 'businessObjectDefinitionId' is set
            if (businessObjectDefinitionId == null)
                throw new ApiException(400, "Missing required parameter 'businessObjectDefinitionId' when calling LifecycleApi->LifecycleGetStages");

            var localVarPath = "/api/V1/{businessObjectDefinitionId}/lifecycle/stages";
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

            if (businessObjectDefinitionId != null) localVarPathParams.Add("businessObjectDefinitionId", Configuration.ApiClient.ParameterToString(businessObjectDefinitionId)); // path parameter
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
                Exception exception = ExceptionFactory("LifecycleGetStages", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<StagesResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StagesResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StagesResponse)));
        }

        /// <summary>
        /// Get lifecycle stages Gets all of the stages on the lifecycle for a Business Object
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsLifecycleGetStagesResponse</returns>
        public async System.Threading.Tasks.Task<StagesResponse> LifecycleGetStagesAsync (string businessObjectDefinitionId, string lang = null, string locale = null)
        {
             ApiResponse<StagesResponse> localVarResponse = await LifecycleGetStagesAsyncWithHttpInfo(businessObjectDefinitionId, lang, locale);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get lifecycle stages Gets all of the stages on the lifecycle for a Business Object
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsLifecycleGetStagesResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<StagesResponse>> LifecycleGetStagesAsyncWithHttpInfo (string businessObjectDefinitionId, string lang = null, string locale = null)
        {
            // verify the required parameter 'businessObjectDefinitionId' is set
            if (businessObjectDefinitionId == null)
                throw new ApiException(400, "Missing required parameter 'businessObjectDefinitionId' when calling LifecycleApi->LifecycleGetStages");

            var localVarPath = "/api/V1/{businessObjectDefinitionId}/lifecycle/stages";
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

            if (businessObjectDefinitionId != null) localVarPathParams.Add("businessObjectDefinitionId", Configuration.ApiClient.ParameterToString(businessObjectDefinitionId)); // path parameter
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
                Exception exception = ExceptionFactory("LifecycleGetStages", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<StagesResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StagesResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StagesResponse)));
        }

        /// <summary>
        /// Get lifecycle statuses Gets all of the statuses on the lifecycle for a Business Object
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsLifecycleGetStatusesResponse</returns>
        public StatusesResponse LifecycleGetStatuses (string businessObjectDefinitionId, string lang = null, string locale = null)
        {
             ApiResponse<StatusesResponse> localVarResponse = LifecycleGetStatusesWithHttpInfo(businessObjectDefinitionId, lang, locale);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get lifecycle statuses Gets all of the statuses on the lifecycle for a Business Object
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsLifecycleGetStatusesResponse</returns>
        public ApiResponse< StatusesResponse > LifecycleGetStatusesWithHttpInfo (string businessObjectDefinitionId, string lang = null, string locale = null)
        {
            // verify the required parameter 'businessObjectDefinitionId' is set
            if (businessObjectDefinitionId == null)
                throw new ApiException(400, "Missing required parameter 'businessObjectDefinitionId' when calling LifecycleApi->LifecycleGetStatuses");

            var localVarPath = "/api/V1/{businessObjectDefinitionId}/lifecycle/statuses";
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

            if (businessObjectDefinitionId != null) localVarPathParams.Add("businessObjectDefinitionId", Configuration.ApiClient.ParameterToString(businessObjectDefinitionId)); // path parameter
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
                Exception exception = ExceptionFactory("LifecycleGetStatuses", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<StatusesResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StatusesResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StatusesResponse)));
        }

        /// <summary>
        /// Get lifecycle statuses Gets all of the statuses on the lifecycle for a Business Object
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsLifecycleGetStatusesResponse</returns>
        public async System.Threading.Tasks.Task<StatusesResponse> LifecycleGetStatusesAsync (string businessObjectDefinitionId, string lang = null, string locale = null)
        {
             ApiResponse<StatusesResponse> localVarResponse = await LifecycleGetStatusesAsyncWithHttpInfo(businessObjectDefinitionId, lang, locale);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get lifecycle statuses Gets all of the statuses on the lifecycle for a Business Object
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsLifecycleGetStatusesResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<StatusesResponse>> LifecycleGetStatusesAsyncWithHttpInfo (string businessObjectDefinitionId, string lang = null, string locale = null)
        {
            // verify the required parameter 'businessObjectDefinitionId' is set
            if (businessObjectDefinitionId == null)
                throw new ApiException(400, "Missing required parameter 'businessObjectDefinitionId' when calling LifecycleApi->LifecycleGetStatuses");

            var localVarPath = "/api/V1/{businessObjectDefinitionId}/lifecycle/statuses";
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

            if (businessObjectDefinitionId != null) localVarPathParams.Add("businessObjectDefinitionId", Configuration.ApiClient.ParameterToString(businessObjectDefinitionId)); // path parameter
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
                Exception exception = ExceptionFactory("LifecycleGetStatuses", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<StatusesResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StatusesResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StatusesResponse)));
        }

        /// <summary>
        /// Get lifecycle transition options for record Gets the lifecycle transition options currently available to a business object record
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="recordId"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsLifecycleGetTransitionOptionsResponse</returns>
        public TransitionOptionsResponse LifecycleGetTransitionOptions (string businessObjectDefinitionId, string recordId, string lang = null, string locale = null)
        {
             ApiResponse<TransitionOptionsResponse> localVarResponse = LifecycleGetTransitionOptionsWithHttpInfo(businessObjectDefinitionId, recordId, lang, locale);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get lifecycle transition options for record Gets the lifecycle transition options currently available to a business object record
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="recordId"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsLifecycleGetTransitionOptionsResponse</returns>
        public ApiResponse< TransitionOptionsResponse > LifecycleGetTransitionOptionsWithHttpInfo (string businessObjectDefinitionId, string recordId, string lang = null, string locale = null)
        {
            // verify the required parameter 'businessObjectDefinitionId' is set
            if (businessObjectDefinitionId == null)
                throw new ApiException(400, "Missing required parameter 'businessObjectDefinitionId' when calling LifecycleApi->LifecycleGetTransitionOptions");
            // verify the required parameter 'recordId' is set
            if (recordId == null)
                throw new ApiException(400, "Missing required parameter 'recordId' when calling LifecycleApi->LifecycleGetTransitionOptions");

            var localVarPath = "/api/V1/{businessObjectDefinitionId}/records/{recordId}/transitionOptions";
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

            if (businessObjectDefinitionId != null) localVarPathParams.Add("businessObjectDefinitionId", Configuration.ApiClient.ParameterToString(businessObjectDefinitionId)); // path parameter
            if (recordId != null) localVarPathParams.Add("recordId", Configuration.ApiClient.ParameterToString(recordId)); // path parameter
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
                Exception exception = ExceptionFactory("LifecycleGetTransitionOptions", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TransitionOptionsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransitionOptionsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransitionOptionsResponse)));
        }

        /// <summary>
        /// Get lifecycle transition options for record Gets the lifecycle transition options currently available to a business object record
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="recordId"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsLifecycleGetTransitionOptionsResponse</returns>
        public async System.Threading.Tasks.Task<TransitionOptionsResponse> LifecycleGetTransitionOptionsAsync (string businessObjectDefinitionId, string recordId, string lang = null, string locale = null)
        {
             ApiResponse<TransitionOptionsResponse> localVarResponse = await LifecycleGetTransitionOptionsAsyncWithHttpInfo(businessObjectDefinitionId, recordId, lang, locale);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get lifecycle transition options for record Gets the lifecycle transition options currently available to a business object record
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="recordId"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsLifecycleGetTransitionOptionsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TransitionOptionsResponse>> LifecycleGetTransitionOptionsAsyncWithHttpInfo (string businessObjectDefinitionId, string recordId, string lang = null, string locale = null)
        {
            // verify the required parameter 'businessObjectDefinitionId' is set
            if (businessObjectDefinitionId == null)
                throw new ApiException(400, "Missing required parameter 'businessObjectDefinitionId' when calling LifecycleApi->LifecycleGetTransitionOptions");
            // verify the required parameter 'recordId' is set
            if (recordId == null)
                throw new ApiException(400, "Missing required parameter 'recordId' when calling LifecycleApi->LifecycleGetTransitionOptions");

            var localVarPath = "/api/V1/{businessObjectDefinitionId}/records/{recordId}/transitionOptions";
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

            if (businessObjectDefinitionId != null) localVarPathParams.Add("businessObjectDefinitionId", Configuration.ApiClient.ParameterToString(businessObjectDefinitionId)); // path parameter
            if (recordId != null) localVarPathParams.Add("recordId", Configuration.ApiClient.ParameterToString(recordId)); // path parameter
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
                Exception exception = ExceptionFactory("LifecycleGetTransitionOptions", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TransitionOptionsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransitionOptionsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransitionOptionsResponse)));
        }

        /// <summary>
        /// Get lifecycle transitions Gets all of the transitions on the lifecycle for a Business Object
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsLifecycleGetTransitionsResponse</returns>
        public TransitionsResponse LifecycleGetTransitions (string businessObjectDefinitionId, string lang = null, string locale = null)
        {
             ApiResponse<TransitionsResponse> localVarResponse = LifecycleGetTransitionsWithHttpInfo(businessObjectDefinitionId, lang, locale);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get lifecycle transitions Gets all of the transitions on the lifecycle for a Business Object
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsLifecycleGetTransitionsResponse</returns>
        public ApiResponse< TransitionsResponse > LifecycleGetTransitionsWithHttpInfo (string businessObjectDefinitionId, string lang = null, string locale = null)
        {
            // verify the required parameter 'businessObjectDefinitionId' is set
            if (businessObjectDefinitionId == null)
                throw new ApiException(400, "Missing required parameter 'businessObjectDefinitionId' when calling LifecycleApi->LifecycleGetTransitions");

            var localVarPath = "/api/V1/{businessObjectDefinitionId}/lifecycle/transitions";
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

            if (businessObjectDefinitionId != null) localVarPathParams.Add("businessObjectDefinitionId", Configuration.ApiClient.ParameterToString(businessObjectDefinitionId)); // path parameter
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
                Exception exception = ExceptionFactory("LifecycleGetTransitions", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TransitionsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransitionsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransitionsResponse)));
        }

        /// <summary>
        /// Get lifecycle transitions Gets all of the transitions on the lifecycle for a Business Object
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsLifecycleGetTransitionsResponse</returns>
        public async System.Threading.Tasks.Task<TransitionsResponse> LifecycleGetTransitionsAsync (string businessObjectDefinitionId, string lang = null, string locale = null)
        {
             ApiResponse<TransitionsResponse> localVarResponse = await LifecycleGetTransitionsAsyncWithHttpInfo(businessObjectDefinitionId, lang, locale);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get lifecycle transitions Gets all of the transitions on the lifecycle for a Business Object
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsLifecycleGetTransitionsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TransitionsResponse>> LifecycleGetTransitionsAsyncWithHttpInfo (string businessObjectDefinitionId, string lang = null, string locale = null)
        {
            // verify the required parameter 'businessObjectDefinitionId' is set
            if (businessObjectDefinitionId == null)
                throw new ApiException(400, "Missing required parameter 'businessObjectDefinitionId' when calling LifecycleApi->LifecycleGetTransitions");

            var localVarPath = "/api/V1/{businessObjectDefinitionId}/lifecycle/transitions";
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

            if (businessObjectDefinitionId != null) localVarPathParams.Add("businessObjectDefinitionId", Configuration.ApiClient.ParameterToString(businessObjectDefinitionId)); // path parameter
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
                Exception exception = ExceptionFactory("LifecycleGetTransitions", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TransitionsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransitionsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransitionsResponse)));
        }

        /// <summary>
        /// Transition a business object record Transitions a business object record in to the specified lifecycle status
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="recordId"></param>
        /// <param name="transitionRecordRequest"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsResponseBase</returns>
        public ResponseBase LifecycleTransitionRecord (string businessObjectDefinitionId, string recordId, TransitionRecordRequest transitionRecordRequest, string lang = null, string locale = null)
        {
             ApiResponse<ResponseBase> localVarResponse = LifecycleTransitionRecordWithHttpInfo(businessObjectDefinitionId, recordId, transitionRecordRequest, lang, locale);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Transition a business object record Transitions a business object record in to the specified lifecycle status
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="recordId"></param>
        /// <param name="transitionRecordRequest"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsResponseBase</returns>
        public ApiResponse< ResponseBase > LifecycleTransitionRecordWithHttpInfo (string businessObjectDefinitionId, string recordId, TransitionRecordRequest transitionRecordRequest, string lang = null, string locale = null)
        {
            // verify the required parameter 'businessObjectDefinitionId' is set
            if (businessObjectDefinitionId == null)
                throw new ApiException(400, "Missing required parameter 'businessObjectDefinitionId' when calling LifecycleApi->LifecycleTransitionRecord");
            // verify the required parameter 'recordId' is set
            if (recordId == null)
                throw new ApiException(400, "Missing required parameter 'recordId' when calling LifecycleApi->LifecycleTransitionRecord");
            // verify the required parameter 'transitionRecordRequest' is set
            if (transitionRecordRequest == null)
                throw new ApiException(400, "Missing required parameter 'transitionRecordRequest' when calling LifecycleApi->LifecycleTransitionRecord");

            var localVarPath = "/api/V1/{businessObjectDefinitionId}/records/{recordId}/transitions";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
                "application/json", 
                "text/json", 
                "application/xml", 
                "text/xml", 
                "application/x-www-form-urlencoded"
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

            if (businessObjectDefinitionId != null) localVarPathParams.Add("businessObjectDefinitionId", Configuration.ApiClient.ParameterToString(businessObjectDefinitionId)); // path parameter
            if (recordId != null) localVarPathParams.Add("recordId", Configuration.ApiClient.ParameterToString(recordId)); // path parameter
            if (lang != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter
            if (transitionRecordRequest != null && transitionRecordRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(transitionRecordRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = transitionRecordRequest; // byte array
            }

            // authentication (oauth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("LifecycleTransitionRecord", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ResponseBase>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ResponseBase) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ResponseBase)));
        }

        /// <summary>
        /// Transition a business object record Transitions a business object record in to the specified lifecycle status
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="recordId"></param>
        /// <param name="transitionRecordRequest"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsResponseBase</returns>
        public async System.Threading.Tasks.Task<ResponseBase> LifecycleTransitionRecordAsync (string businessObjectDefinitionId, string recordId, TransitionRecordRequest transitionRecordRequest, string lang = null, string locale = null)
        {
             ApiResponse<ResponseBase> localVarResponse = await LifecycleTransitionRecordAsyncWithHttpInfo(businessObjectDefinitionId, recordId, transitionRecordRequest, lang, locale);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Transition a business object record Transitions a business object record in to the specified lifecycle status
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="recordId"></param>
        /// <param name="transitionRecordRequest"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsResponseBase)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ResponseBase>> LifecycleTransitionRecordAsyncWithHttpInfo (string businessObjectDefinitionId, string recordId, TransitionRecordRequest transitionRecordRequest, string lang = null, string locale = null)
        {
            // verify the required parameter 'businessObjectDefinitionId' is set
            if (businessObjectDefinitionId == null)
                throw new ApiException(400, "Missing required parameter 'businessObjectDefinitionId' when calling LifecycleApi->LifecycleTransitionRecord");
            // verify the required parameter 'recordId' is set
            if (recordId == null)
                throw new ApiException(400, "Missing required parameter 'recordId' when calling LifecycleApi->LifecycleTransitionRecord");
            // verify the required parameter 'transitionRecordRequest' is set
            if (transitionRecordRequest == null)
                throw new ApiException(400, "Missing required parameter 'transitionRecordRequest' when calling LifecycleApi->LifecycleTransitionRecord");

            var localVarPath = "/api/V1/{businessObjectDefinitionId}/records/{recordId}/transitions";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
                "application/json", 
                "text/json", 
                "application/xml", 
                "text/xml", 
                "application/x-www-form-urlencoded"
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

            if (businessObjectDefinitionId != null) localVarPathParams.Add("businessObjectDefinitionId", Configuration.ApiClient.ParameterToString(businessObjectDefinitionId)); // path parameter
            if (recordId != null) localVarPathParams.Add("recordId", Configuration.ApiClient.ParameterToString(recordId)); // path parameter
            if (lang != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter
            if (transitionRecordRequest != null && transitionRecordRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(transitionRecordRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = transitionRecordRequest; // byte array
            }

            // authentication (oauth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("LifecycleTransitionRecord", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ResponseBase>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ResponseBase) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ResponseBase)));
        }

    }
}
