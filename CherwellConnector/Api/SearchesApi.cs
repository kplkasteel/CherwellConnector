
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
    public partial class SearchesApi : ISearchesApi
    {
        private ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SearchesApi(string basePath)
        {
            Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SearchesApi(Configuration configuration = null)
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
        /// Get a Quick Search from a list of Business Object IDs Operation to build a Quick Search configuration that you can use to execute a Quick Search for multiple Business Objects. The configuration  includes supplied Business Object IDs and specific search items with the following options. Use the Option Key to determine if you can change the options. &lt;/br&gt;&lt;/br&gt;&lt;/br&gt;ChangedOption&lt;/br&gt;&lt;/br&gt;NonFinalStateOption&lt;/br&gt;&lt;/br&gt;SearchAnyWordsOption&lt;/br&gt;&lt;/br&gt;SearchAttachmentsOption&lt;/br&gt;&lt;/br&gt;SearchRelatedOption&lt;/br&gt;&lt;/br&gt;SortByOption&lt;/br&gt;&lt;/br&gt;&lt;/br&gt;Option Key:&lt;/br&gt;&lt;/br&gt;0 &#x3D; None (Not selected and cannot select.)&lt;/br&gt;&lt;/br&gt;1 &#x3D; Use (Selected and cannot clear.)&lt;/br&gt;&lt;/br&gt;2 &#x3D; Display (Not selected and can select.)&lt;/br&gt;&lt;/br&gt;3 &#x3D; UseAndDisplay (Selected and can clear.)&lt;/br&gt;&lt;/br&gt;&lt;/br&gt;SearchTargetType:&lt;/br&gt;&lt;/br&gt;0 &#x3D; BusOb (Business Object)&lt;/br&gt;&lt;/br&gt;1 &#x3D; DocRepository (Document Repository)
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataRequest">Request containing the Business Object IDs list.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsSearchesQuickSearchConfigurationResponse</returns>
        public QuickSearchConfigurationResponse SearchesGetQuickSearchConfigurationForBusObsV1 (QuickSearchConfigurationRequest dataRequest, string lang = null, string locale = null)
        {
             ApiResponse<QuickSearchConfigurationResponse> localVarResponse = SearchesGetQuickSearchConfigurationForBusObsV1WithHttpInfo(dataRequest, lang, locale);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Quick Search from a list of Business Object IDs Operation to build a Quick Search configuration that you can use to execute a Quick Search for multiple Business Objects. The configuration  includes supplied Business Object IDs and specific search items with the following options. Use the Option Key to determine if you can change the options. &lt;/br&gt;&lt;/br&gt;&lt;/br&gt;ChangedOption&lt;/br&gt;&lt;/br&gt;NonFinalStateOption&lt;/br&gt;&lt;/br&gt;SearchAnyWordsOption&lt;/br&gt;&lt;/br&gt;SearchAttachmentsOption&lt;/br&gt;&lt;/br&gt;SearchRelatedOption&lt;/br&gt;&lt;/br&gt;SortByOption&lt;/br&gt;&lt;/br&gt;&lt;/br&gt;Option Key:&lt;/br&gt;&lt;/br&gt;0 &#x3D; None (Not selected and cannot select.)&lt;/br&gt;&lt;/br&gt;1 &#x3D; Use (Selected and cannot clear.)&lt;/br&gt;&lt;/br&gt;2 &#x3D; Display (Not selected and can select.)&lt;/br&gt;&lt;/br&gt;3 &#x3D; UseAndDisplay (Selected and can clear.)&lt;/br&gt;&lt;/br&gt;&lt;/br&gt;SearchTargetType:&lt;/br&gt;&lt;/br&gt;0 &#x3D; BusOb (Business Object)&lt;/br&gt;&lt;/br&gt;1 &#x3D; DocRepository (Document Repository)
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataRequest">Request containing the Business Object IDs list.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsSearchesQuickSearchConfigurationResponse</returns>
        public ApiResponse< QuickSearchConfigurationResponse > SearchesGetQuickSearchConfigurationForBusObsV1WithHttpInfo (QuickSearchConfigurationRequest dataRequest, string lang = null, string locale = null)
        {
            // verify the required parameter 'dataRequest' is set
            if (dataRequest == null)
                throw new ApiException(400, "Missing required parameter 'dataRequest' when calling SearchesApi->SearchesGetQuickSearchConfigurationForBusObsV1");

            var localVarPath = "/api/V1/getquicksearchconfigurationforbusobs";
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

            if (lang != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter
            if (dataRequest != null && dataRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(dataRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = dataRequest; // byte array
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
                Exception exception = ExceptionFactory("SearchesGetQuickSearchConfigurationForBusObsV1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<QuickSearchConfigurationResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QuickSearchConfigurationResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QuickSearchConfigurationResponse)));
        }

        /// <summary>
        /// Get a Quick Search from a list of Business Object IDs Operation to build a Quick Search configuration that you can use to execute a Quick Search for multiple Business Objects. The configuration  includes supplied Business Object IDs and specific search items with the following options. Use the Option Key to determine if you can change the options. &lt;/br&gt;&lt;/br&gt;&lt;/br&gt;ChangedOption&lt;/br&gt;&lt;/br&gt;NonFinalStateOption&lt;/br&gt;&lt;/br&gt;SearchAnyWordsOption&lt;/br&gt;&lt;/br&gt;SearchAttachmentsOption&lt;/br&gt;&lt;/br&gt;SearchRelatedOption&lt;/br&gt;&lt;/br&gt;SortByOption&lt;/br&gt;&lt;/br&gt;&lt;/br&gt;Option Key:&lt;/br&gt;&lt;/br&gt;0 &#x3D; None (Not selected and cannot select.)&lt;/br&gt;&lt;/br&gt;1 &#x3D; Use (Selected and cannot clear.)&lt;/br&gt;&lt;/br&gt;2 &#x3D; Display (Not selected and can select.)&lt;/br&gt;&lt;/br&gt;3 &#x3D; UseAndDisplay (Selected and can clear.)&lt;/br&gt;&lt;/br&gt;&lt;/br&gt;SearchTargetType:&lt;/br&gt;&lt;/br&gt;0 &#x3D; BusOb (Business Object)&lt;/br&gt;&lt;/br&gt;1 &#x3D; DocRepository (Document Repository)
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataRequest">Request containing the Business Object IDs list.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsSearchesQuickSearchConfigurationResponse</returns>
        public async System.Threading.Tasks.Task<QuickSearchConfigurationResponse> SearchesGetQuickSearchConfigurationForBusObsV1Async (QuickSearchConfigurationRequest dataRequest, string lang = null, string locale = null)
        {
             ApiResponse<QuickSearchConfigurationResponse> localVarResponse = await SearchesGetQuickSearchConfigurationForBusObsV1AsyncWithHttpInfo(dataRequest, lang, locale);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Quick Search from a list of Business Object IDs Operation to build a Quick Search configuration that you can use to execute a Quick Search for multiple Business Objects. The configuration  includes supplied Business Object IDs and specific search items with the following options. Use the Option Key to determine if you can change the options. &lt;/br&gt;&lt;/br&gt;&lt;/br&gt;ChangedOption&lt;/br&gt;&lt;/br&gt;NonFinalStateOption&lt;/br&gt;&lt;/br&gt;SearchAnyWordsOption&lt;/br&gt;&lt;/br&gt;SearchAttachmentsOption&lt;/br&gt;&lt;/br&gt;SearchRelatedOption&lt;/br&gt;&lt;/br&gt;SortByOption&lt;/br&gt;&lt;/br&gt;&lt;/br&gt;Option Key:&lt;/br&gt;&lt;/br&gt;0 &#x3D; None (Not selected and cannot select.)&lt;/br&gt;&lt;/br&gt;1 &#x3D; Use (Selected and cannot clear.)&lt;/br&gt;&lt;/br&gt;2 &#x3D; Display (Not selected and can select.)&lt;/br&gt;&lt;/br&gt;3 &#x3D; UseAndDisplay (Selected and can clear.)&lt;/br&gt;&lt;/br&gt;&lt;/br&gt;SearchTargetType:&lt;/br&gt;&lt;/br&gt;0 &#x3D; BusOb (Business Object)&lt;/br&gt;&lt;/br&gt;1 &#x3D; DocRepository (Document Repository)
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataRequest">Request containing the Business Object IDs list.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsSearchesQuickSearchConfigurationResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<QuickSearchConfigurationResponse>> SearchesGetQuickSearchConfigurationForBusObsV1AsyncWithHttpInfo (QuickSearchConfigurationRequest dataRequest, string lang = null, string locale = null)
        {
            // verify the required parameter 'dataRequest' is set
            if (dataRequest == null)
                throw new ApiException(400, "Missing required parameter 'dataRequest' when calling SearchesApi->SearchesGetQuickSearchConfigurationForBusObsV1");

            var localVarPath = "/api/V1/getquicksearchconfigurationforbusobs";
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

            if (lang != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter
            if (dataRequest != null && dataRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(dataRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = dataRequest; // byte array
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
                Exception exception = ExceptionFactory("SearchesGetQuickSearchConfigurationForBusObsV1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<QuickSearchConfigurationResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QuickSearchConfigurationResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QuickSearchConfigurationResponse)));
        }

        /// <summary>
        /// Get a Quick Search by Business Objects with view rights Operation to get a Quick Search configuration that you can use to execute a Quick Search based the current user&#39;s Business Object view rights. The configuration  includes supplied Business Object IDs and specific search items with the following options. Use the Option Key to determine if you can change the options.&lt;/br&gt;&lt;/br&gt;ChangedOption&lt;/br&gt;&lt;/br&gt;NonFinalStateOption&lt;/br&gt;&lt;/br&gt;SearchAnyWordsOption&lt;/br&gt;&lt;/br&gt;SearchAttachmentsOption&lt;/br&gt;&lt;/br&gt;SearchRelatedOption&lt;/br&gt;&lt;/br&gt;SortByOption&lt;/br&gt;&lt;/br&gt;&lt;/br&gt;Option Key:&lt;/br&gt;&lt;/br&gt;0 &#x3D; None (Not selected and cannot select.)&lt;/br&gt;&lt;/br&gt;1 &#x3D; Use (Selected and cannot clear.)&lt;/br&gt;&lt;/br&gt;2 &#x3D; Display (Not selected and can select.)&lt;/br&gt;&lt;/br&gt;3 &#x3D; UseAndDisplay (Selected and can clear.)&lt;/br&gt;&lt;/br&gt;&lt;/br&gt;SearchTargetType:&lt;/br&gt;&lt;/br&gt;0 &#x3D; BusOb (Business Object)&lt;/br&gt;&lt;/br&gt;1 &#x3D; DocRepository (Document Repository)
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsSearchesQuickSearchConfigurationResponse</returns>
        public QuickSearchConfigurationResponse SearchesGetQuickSearchConfigurationForBusObsWithViewRightsV1 (string lang = null, string locale = null)
        {
             ApiResponse<QuickSearchConfigurationResponse> localVarResponse = SearchesGetQuickSearchConfigurationForBusObsWithViewRightsV1WithHttpInfo(lang, locale);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Quick Search by Business Objects with view rights Operation to get a Quick Search configuration that you can use to execute a Quick Search based the current user&#39;s Business Object view rights. The configuration  includes supplied Business Object IDs and specific search items with the following options. Use the Option Key to determine if you can change the options.&lt;/br&gt;&lt;/br&gt;ChangedOption&lt;/br&gt;&lt;/br&gt;NonFinalStateOption&lt;/br&gt;&lt;/br&gt;SearchAnyWordsOption&lt;/br&gt;&lt;/br&gt;SearchAttachmentsOption&lt;/br&gt;&lt;/br&gt;SearchRelatedOption&lt;/br&gt;&lt;/br&gt;SortByOption&lt;/br&gt;&lt;/br&gt;&lt;/br&gt;Option Key:&lt;/br&gt;&lt;/br&gt;0 &#x3D; None (Not selected and cannot select.)&lt;/br&gt;&lt;/br&gt;1 &#x3D; Use (Selected and cannot clear.)&lt;/br&gt;&lt;/br&gt;2 &#x3D; Display (Not selected and can select.)&lt;/br&gt;&lt;/br&gt;3 &#x3D; UseAndDisplay (Selected and can clear.)&lt;/br&gt;&lt;/br&gt;&lt;/br&gt;SearchTargetType:&lt;/br&gt;&lt;/br&gt;0 &#x3D; BusOb (Business Object)&lt;/br&gt;&lt;/br&gt;1 &#x3D; DocRepository (Document Repository)
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsSearchesQuickSearchConfigurationResponse</returns>
        public ApiResponse< QuickSearchConfigurationResponse > SearchesGetQuickSearchConfigurationForBusObsWithViewRightsV1WithHttpInfo (string lang = null, string locale = null)
        {

            var localVarPath = "/api/V1/getquicksearchconfigurationforbusobswithviewrights";
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
                Exception exception = ExceptionFactory("SearchesGetQuickSearchConfigurationForBusObsWithViewRightsV1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<QuickSearchConfigurationResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QuickSearchConfigurationResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QuickSearchConfigurationResponse)));
        }

        /// <summary>
        /// Get a Quick Search by Business Objects with view rights Operation to get a Quick Search configuration that you can use to execute a Quick Search based the current user&#39;s Business Object view rights. The configuration  includes supplied Business Object IDs and specific search items with the following options. Use the Option Key to determine if you can change the options.&lt;/br&gt;&lt;/br&gt;ChangedOption&lt;/br&gt;&lt;/br&gt;NonFinalStateOption&lt;/br&gt;&lt;/br&gt;SearchAnyWordsOption&lt;/br&gt;&lt;/br&gt;SearchAttachmentsOption&lt;/br&gt;&lt;/br&gt;SearchRelatedOption&lt;/br&gt;&lt;/br&gt;SortByOption&lt;/br&gt;&lt;/br&gt;&lt;/br&gt;Option Key:&lt;/br&gt;&lt;/br&gt;0 &#x3D; None (Not selected and cannot select.)&lt;/br&gt;&lt;/br&gt;1 &#x3D; Use (Selected and cannot clear.)&lt;/br&gt;&lt;/br&gt;2 &#x3D; Display (Not selected and can select.)&lt;/br&gt;&lt;/br&gt;3 &#x3D; UseAndDisplay (Selected and can clear.)&lt;/br&gt;&lt;/br&gt;&lt;/br&gt;SearchTargetType:&lt;/br&gt;&lt;/br&gt;0 &#x3D; BusOb (Business Object)&lt;/br&gt;&lt;/br&gt;1 &#x3D; DocRepository (Document Repository)
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsSearchesQuickSearchConfigurationResponse</returns>
        public async System.Threading.Tasks.Task<QuickSearchConfigurationResponse> SearchesGetQuickSearchConfigurationForBusObsWithViewRightsV1Async (string lang = null, string locale = null)
        {
             ApiResponse<QuickSearchConfigurationResponse> localVarResponse = await SearchesGetQuickSearchConfigurationForBusObsWithViewRightsV1AsyncWithHttpInfo(lang, locale);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Quick Search by Business Objects with view rights Operation to get a Quick Search configuration that you can use to execute a Quick Search based the current user&#39;s Business Object view rights. The configuration  includes supplied Business Object IDs and specific search items with the following options. Use the Option Key to determine if you can change the options.&lt;/br&gt;&lt;/br&gt;ChangedOption&lt;/br&gt;&lt;/br&gt;NonFinalStateOption&lt;/br&gt;&lt;/br&gt;SearchAnyWordsOption&lt;/br&gt;&lt;/br&gt;SearchAttachmentsOption&lt;/br&gt;&lt;/br&gt;SearchRelatedOption&lt;/br&gt;&lt;/br&gt;SortByOption&lt;/br&gt;&lt;/br&gt;&lt;/br&gt;Option Key:&lt;/br&gt;&lt;/br&gt;0 &#x3D; None (Not selected and cannot select.)&lt;/br&gt;&lt;/br&gt;1 &#x3D; Use (Selected and cannot clear.)&lt;/br&gt;&lt;/br&gt;2 &#x3D; Display (Not selected and can select.)&lt;/br&gt;&lt;/br&gt;3 &#x3D; UseAndDisplay (Selected and can clear.)&lt;/br&gt;&lt;/br&gt;&lt;/br&gt;SearchTargetType:&lt;/br&gt;&lt;/br&gt;0 &#x3D; BusOb (Business Object)&lt;/br&gt;&lt;/br&gt;1 &#x3D; DocRepository (Document Repository)
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsSearchesQuickSearchConfigurationResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<QuickSearchConfigurationResponse>> SearchesGetQuickSearchConfigurationForBusObsWithViewRightsV1AsyncWithHttpInfo (string lang = null, string locale = null)
        {

            var localVarPath = "/api/V1/getquicksearchconfigurationforbusobswithviewrights";
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
                Exception exception = ExceptionFactory("SearchesGetQuickSearchConfigurationForBusObsWithViewRightsV1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<QuickSearchConfigurationResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QuickSearchConfigurationResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QuickSearchConfigurationResponse)));
        }

        /// <summary>
        /// Execute a Quick Search from a list of Business Object IDs and search text Operation to execute a Quick Search using a list of Business Object IDs and search text.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataRequest">Request object listing Business Object IDs and search text. Leave out the entire Business Object IDs parameter and all configured quick search Business Objects will be searched.</param>
        /// <param name="includeLinks">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsSearchesSimpleResultsList</returns>
        public SimpleResultsList SearchesGetQuickSearchResultsV1 (QuickSearchRequest dataRequest, bool? includeLinks = null, string lang = null, string locale = null)
        {
             ApiResponse<SimpleResultsList> localVarResponse = SearchesGetQuickSearchResultsV1WithHttpInfo(dataRequest, includeLinks, lang, locale);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Execute a Quick Search from a list of Business Object IDs and search text Operation to execute a Quick Search using a list of Business Object IDs and search text.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataRequest">Request object listing Business Object IDs and search text. Leave out the entire Business Object IDs parameter and all configured quick search Business Objects will be searched.</param>
        /// <param name="includeLinks">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsSearchesSimpleResultsList</returns>
        public ApiResponse< SimpleResultsList > SearchesGetQuickSearchResultsV1WithHttpInfo (QuickSearchRequest dataRequest, bool? includeLinks = null, string lang = null, string locale = null)
        {
            // verify the required parameter 'dataRequest' is set
            if (dataRequest == null)
                throw new ApiException(400, "Missing required parameter 'dataRequest' when calling SearchesApi->SearchesGetQuickSearchResultsV1");

            var localVarPath = "/api/V1/getquicksearchresults";
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

            if (includeLinks != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "includeLinks", includeLinks)); // query parameter
            if (lang != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter
            if (dataRequest != null && dataRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(dataRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = dataRequest; // byte array
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
                Exception exception = ExceptionFactory("SearchesGetQuickSearchResultsV1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SimpleResultsList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SimpleResultsList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SimpleResultsList)));
        }

        /// <summary>
        /// Execute a Quick Search from a list of Business Object IDs and search text Operation to execute a Quick Search using a list of Business Object IDs and search text.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataRequest">Request object listing Business Object IDs and search text. Leave out the entire Business Object IDs parameter and all configured quick search Business Objects will be searched.</param>
        /// <param name="includeLinks">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsSearchesSimpleResultsList</returns>
        public async System.Threading.Tasks.Task<SimpleResultsList> SearchesGetQuickSearchResultsV1Async (QuickSearchRequest dataRequest, bool? includeLinks = null, string lang = null, string locale = null)
        {
             ApiResponse<SimpleResultsList> localVarResponse = await SearchesGetQuickSearchResultsV1AsyncWithHttpInfo(dataRequest, includeLinks, lang, locale);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Execute a Quick Search from a list of Business Object IDs and search text Operation to execute a Quick Search using a list of Business Object IDs and search text.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataRequest">Request object listing Business Object IDs and search text. Leave out the entire Business Object IDs parameter and all configured quick search Business Objects will be searched.</param>
        /// <param name="includeLinks">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsSearchesSimpleResultsList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SimpleResultsList>> SearchesGetQuickSearchResultsV1AsyncWithHttpInfo (QuickSearchRequest dataRequest, bool? includeLinks = null, string lang = null, string locale = null)
        {
            // verify the required parameter 'dataRequest' is set
            if (dataRequest == null)
                throw new ApiException(400, "Missing required parameter 'dataRequest' when calling SearchesApi->SearchesGetQuickSearchResultsV1");

            var localVarPath = "/api/V1/getquicksearchresults";
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

            if (includeLinks != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "includeLinks", includeLinks)); // query parameter
            if (lang != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter
            if (dataRequest != null && dataRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(dataRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = dataRequest; // byte array
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
                Exception exception = ExceptionFactory("SearchesGetQuickSearchResultsV1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SimpleResultsList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SimpleResultsList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SimpleResultsList)));
        }

        /// <summary>
        /// Execute a Quick Search on a specific Business Object Operation to execute a Quick Search for a specific Business Object ID. Use \&quot;Get a Quick Search from a list of Business Object IDs\&quot; to find values for specific search item options, such as NonFinalStateOption.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataRequest">Request object containing the parameters for specific Business Object Quick Search execution.</param>
        /// <param name="includeSchema">Flag to include the schema for the results. (optional)</param>
        /// <param name="includeLocationFields">Flag to include location fields in the results. (optional)</param>
        /// <param name="includeLinks">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsSearchesSearchResultsTableResponse</returns>
        public SearchResultsTableResponse SearchesGetQuickSearchSpecificResultsV1 (QuickSearchSpecificRequest dataRequest, bool? includeSchema = null, bool? includeLocationFields = null, bool? includeLinks = null, string lang = null, string locale = null)
        {
             ApiResponse<SearchResultsTableResponse> localVarResponse = SearchesGetQuickSearchSpecificResultsV1WithHttpInfo(dataRequest, includeSchema, includeLocationFields, includeLinks, lang, locale);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Execute a Quick Search on a specific Business Object Operation to execute a Quick Search for a specific Business Object ID. Use \&quot;Get a Quick Search from a list of Business Object IDs\&quot; to find values for specific search item options, such as NonFinalStateOption.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataRequest">Request object containing the parameters for specific Business Object Quick Search execution.</param>
        /// <param name="includeSchema">Flag to include the schema for the results. (optional)</param>
        /// <param name="includeLocationFields">Flag to include location fields in the results. (optional)</param>
        /// <param name="includeLinks">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsSearchesSearchResultsTableResponse</returns>
        public ApiResponse< SearchResultsTableResponse > SearchesGetQuickSearchSpecificResultsV1WithHttpInfo (QuickSearchSpecificRequest dataRequest, bool? includeSchema = null, bool? includeLocationFields = null, bool? includeLinks = null, string lang = null, string locale = null)
        {
            // verify the required parameter 'dataRequest' is set
            if (dataRequest == null)
                throw new ApiException(400, "Missing required parameter 'dataRequest' when calling SearchesApi->SearchesGetQuickSearchSpecificResultsV1");

            var localVarPath = "/api/V1/getquicksearchspecificresults";
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

            if (includeSchema != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "includeSchema", includeSchema)); // query parameter
            if (includeLocationFields != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "includeLocationFields", includeLocationFields)); // query parameter
            if (includeLinks != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "includeLinks", includeLinks)); // query parameter
            if (lang != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter
            if (dataRequest != null && dataRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(dataRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = dataRequest; // byte array
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
                Exception exception = ExceptionFactory("SearchesGetQuickSearchSpecificResultsV1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SearchResultsTableResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SearchResultsTableResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SearchResultsTableResponse)));
        }

        /// <summary>
        /// Execute a Quick Search on a specific Business Object Operation to execute a Quick Search for a specific Business Object ID. Use \&quot;Get a Quick Search from a list of Business Object IDs\&quot; to find values for specific search item options, such as NonFinalStateOption.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataRequest">Request object containing the parameters for specific Business Object Quick Search execution.</param>
        /// <param name="includeSchema">Flag to include the schema for the results. (optional)</param>
        /// <param name="includeLocationFields">Flag to include location fields in the results. (optional)</param>
        /// <param name="includeLinks">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsSearchesSearchResultsTableResponse</returns>
        public async System.Threading.Tasks.Task<SearchResultsTableResponse> SearchesGetQuickSearchSpecificResultsV1Async (QuickSearchSpecificRequest dataRequest, bool? includeSchema = null, bool? includeLocationFields = null, bool? includeLinks = null, string lang = null, string locale = null)
        {
             ApiResponse<SearchResultsTableResponse> localVarResponse = await SearchesGetQuickSearchSpecificResultsV1AsyncWithHttpInfo(dataRequest, includeSchema, includeLocationFields, includeLinks, lang, locale);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Execute a Quick Search on a specific Business Object Operation to execute a Quick Search for a specific Business Object ID. Use \&quot;Get a Quick Search from a list of Business Object IDs\&quot; to find values for specific search item options, such as NonFinalStateOption.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataRequest">Request object containing the parameters for specific Business Object Quick Search execution.</param>
        /// <param name="includeSchema">Flag to include the schema for the results. (optional)</param>
        /// <param name="includeLocationFields">Flag to include location fields in the results. (optional)</param>
        /// <param name="includeLinks">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsSearchesSearchResultsTableResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SearchResultsTableResponse>> SearchesGetQuickSearchSpecificResultsV1AsyncWithHttpInfo (QuickSearchSpecificRequest dataRequest, bool? includeSchema = null, bool? includeLocationFields = null, bool? includeLinks = null, string lang = null, string locale = null)
        {
            // verify the required parameter 'dataRequest' is set
            if (dataRequest == null)
                throw new ApiException(400, "Missing required parameter 'dataRequest' when calling SearchesApi->SearchesGetQuickSearchSpecificResultsV1");

            var localVarPath = "/api/V1/getquicksearchspecificresults";
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

            if (includeSchema != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "includeSchema", includeSchema)); // query parameter
            if (includeLocationFields != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "includeLocationFields", includeLocationFields)); // query parameter
            if (includeLinks != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "includeLinks", includeLinks)); // query parameter
            if (lang != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter
            if (dataRequest != null && dataRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(dataRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = dataRequest; // byte array
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
                Exception exception = ExceptionFactory("SearchesGetQuickSearchSpecificResultsV1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SearchResultsTableResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SearchResultsTableResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SearchResultsTableResponse)));
        }

        /// <summary>
        /// Execute a Quick Search on a specific Business Object Operation to execute a Quick Search for a specific Business Object ID. Use \&quot;Get a Quick Search from a list of Business Object IDs\&quot; to find values for specific search item options, such as NonFinalStateOption.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataRequest">Request object containing the parameters for specific Business Object Quick Search execution.</param>
        /// <param name="includeSchema">Flag to include the schema for the results. (optional)</param>
        /// <param name="includeLocationFields">Flag to include location fields in the results. (optional)</param>
        /// <param name="includeLinks">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsSearchesQuickSearchResponse</returns>
        public QuickSearchResponse SearchesGetQuickSearchSpecificResultsV2 (QuickSearchSpecificRequest dataRequest, bool? includeSchema = null, bool? includeLocationFields = null, bool? includeLinks = null, string lang = null, string locale = null)
        {
             ApiResponse<QuickSearchResponse> localVarResponse = SearchesGetQuickSearchSpecificResultsV2WithHttpInfo(dataRequest, includeSchema, includeLocationFields, includeLinks, lang, locale);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Execute a Quick Search on a specific Business Object Operation to execute a Quick Search for a specific Business Object ID. Use \&quot;Get a Quick Search from a list of Business Object IDs\&quot; to find values for specific search item options, such as NonFinalStateOption.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataRequest">Request object containing the parameters for specific Business Object Quick Search execution.</param>
        /// <param name="includeSchema">Flag to include the schema for the results. (optional)</param>
        /// <param name="includeLocationFields">Flag to include location fields in the results. (optional)</param>
        /// <param name="includeLinks">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsSearchesQuickSearchResponse</returns>
        public ApiResponse< QuickSearchResponse > SearchesGetQuickSearchSpecificResultsV2WithHttpInfo (QuickSearchSpecificRequest dataRequest, bool? includeSchema = null, bool? includeLocationFields = null, bool? includeLinks = null, string lang = null, string locale = null)
        {
            // verify the required parameter 'dataRequest' is set
            if (dataRequest == null)
                throw new ApiException(400, "Missing required parameter 'dataRequest' when calling SearchesApi->SearchesGetQuickSearchSpecificResultsV2");

            var localVarPath = "/api/V2/getquicksearchspecificresults";
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

            if (includeSchema != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "includeSchema", includeSchema)); // query parameter
            if (includeLocationFields != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "includeLocationFields", includeLocationFields)); // query parameter
            if (includeLinks != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "includeLinks", includeLinks)); // query parameter
            if (lang != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter
            if (dataRequest != null && dataRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(dataRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = dataRequest; // byte array
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
                Exception exception = ExceptionFactory("SearchesGetQuickSearchSpecificResultsV2", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<QuickSearchResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QuickSearchResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QuickSearchResponse)));
        }

        /// <summary>
        /// Execute a Quick Search on a specific Business Object Operation to execute a Quick Search for a specific Business Object ID. Use \&quot;Get a Quick Search from a list of Business Object IDs\&quot; to find values for specific search item options, such as NonFinalStateOption.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataRequest">Request object containing the parameters for specific Business Object Quick Search execution.</param>
        /// <param name="includeSchema">Flag to include the schema for the results. (optional)</param>
        /// <param name="includeLocationFields">Flag to include location fields in the results. (optional)</param>
        /// <param name="includeLinks">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsSearchesQuickSearchResponse</returns>
        public async System.Threading.Tasks.Task<QuickSearchResponse> SearchesGetQuickSearchSpecificResultsV2Async (QuickSearchSpecificRequest dataRequest, bool? includeSchema = null, bool? includeLocationFields = null, bool? includeLinks = null, string lang = null, string locale = null)
        {
             ApiResponse<QuickSearchResponse> localVarResponse = await SearchesGetQuickSearchSpecificResultsV2AsyncWithHttpInfo(dataRequest, includeSchema, includeLocationFields, includeLinks, lang, locale);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Execute a Quick Search on a specific Business Object Operation to execute a Quick Search for a specific Business Object ID. Use \&quot;Get a Quick Search from a list of Business Object IDs\&quot; to find values for specific search item options, such as NonFinalStateOption.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataRequest">Request object containing the parameters for specific Business Object Quick Search execution.</param>
        /// <param name="includeSchema">Flag to include the schema for the results. (optional)</param>
        /// <param name="includeLocationFields">Flag to include location fields in the results. (optional)</param>
        /// <param name="includeLinks">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsSearchesQuickSearchResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<QuickSearchResponse>> SearchesGetQuickSearchSpecificResultsV2AsyncWithHttpInfo (QuickSearchSpecificRequest dataRequest, bool? includeSchema = null, bool? includeLocationFields = null, bool? includeLinks = null, string lang = null, string locale = null)
        {
            // verify the required parameter 'dataRequest' is set
            if (dataRequest == null)
                throw new ApiException(400, "Missing required parameter 'dataRequest' when calling SearchesApi->SearchesGetQuickSearchSpecificResultsV2");

            var localVarPath = "/api/V2/getquicksearchspecificresults";
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

            if (includeSchema != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "includeSchema", includeSchema)); // query parameter
            if (includeLocationFields != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "includeLocationFields", includeLocationFields)); // query parameter
            if (includeLinks != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "includeLinks", includeLinks)); // query parameter
            if (lang != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter
            if (dataRequest != null && dataRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(dataRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = dataRequest; // byte array
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
                Exception exception = ExceptionFactory("SearchesGetQuickSearchSpecificResultsV2", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<QuickSearchResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QuickSearchResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QuickSearchResponse)));
        }

        /// <summary>
        /// Get all saved searches by Folder ID Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Use to filter results by Business Object association ID.</param>
        /// <param name="scope">Use to filter results by scope name or ID.</param>
        /// <param name="scopeowner">Use to filter results by scope owner ID.</param>
        /// <param name="folder">Use to filter results by Search Group folder ID.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsSearchesSearchItemResponse</returns>
        public SearchItemResponse SearchesGetSearchItemsByAssociationScopeScopeOwnerFolderV1 (string association, string scope, string scopeowner, string folder, bool? links = null, string lang = null, string locale = null)
        {
             ApiResponse<SearchItemResponse> localVarResponse = SearchesGetSearchItemsByAssociationScopeScopeOwnerFolderV1WithHttpInfo(association, scope, scopeowner, folder, links, lang, locale);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all saved searches by Folder ID Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Use to filter results by Business Object association ID.</param>
        /// <param name="scope">Use to filter results by scope name or ID.</param>
        /// <param name="scopeowner">Use to filter results by scope owner ID.</param>
        /// <param name="folder">Use to filter results by Search Group folder ID.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsSearchesSearchItemResponse</returns>
        public ApiResponse< SearchItemResponse > SearchesGetSearchItemsByAssociationScopeScopeOwnerFolderV1WithHttpInfo (string association, string scope, string scopeowner, string folder, bool? links = null, string lang = null, string locale = null)
        {
            // verify the required parameter 'association' is set
            if (association == null)
                throw new ApiException(400, "Missing required parameter 'association' when calling SearchesApi->SearchesGetSearchItemsByAssociationScopeScopeOwnerFolderV1");
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling SearchesApi->SearchesGetSearchItemsByAssociationScopeScopeOwnerFolderV1");
            // verify the required parameter 'scopeowner' is set
            if (scopeowner == null)
                throw new ApiException(400, "Missing required parameter 'scopeowner' when calling SearchesApi->SearchesGetSearchItemsByAssociationScopeScopeOwnerFolderV1");
            // verify the required parameter 'folder' is set
            if (folder == null)
                throw new ApiException(400, "Missing required parameter 'folder' when calling SearchesApi->SearchesGetSearchItemsByAssociationScopeScopeOwnerFolderV1");

            var localVarPath = "/api/V1/getsearchitems/association/{association}/scope/{scope}/scopeowner/{scopeowner}/folder/{folder}";
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

            if (association != null) localVarPathParams.Add("association", Configuration.ApiClient.ParameterToString(association)); // path parameter
            if (scope != null) localVarPathParams.Add("scope", Configuration.ApiClient.ParameterToString(scope)); // path parameter
            if (scopeowner != null) localVarPathParams.Add("scopeowner", Configuration.ApiClient.ParameterToString(scopeowner)); // path parameter
            if (folder != null) localVarPathParams.Add("folder", Configuration.ApiClient.ParameterToString(folder)); // path parameter
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
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SearchesGetSearchItemsByAssociationScopeScopeOwnerFolderV1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SearchItemResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SearchItemResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SearchItemResponse)));
        }

        /// <summary>
        /// Get all saved searches by Folder ID Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Use to filter results by Business Object association ID.</param>
        /// <param name="scope">Use to filter results by scope name or ID.</param>
        /// <param name="scopeowner">Use to filter results by scope owner ID.</param>
        /// <param name="folder">Use to filter results by Search Group folder ID.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsSearchesSearchItemResponse</returns>
        public async System.Threading.Tasks.Task<SearchItemResponse> SearchesGetSearchItemsByAssociationScopeScopeOwnerFolderV1Async (string association, string scope, string scopeowner, string folder, bool? links = null, string lang = null, string locale = null)
        {
             ApiResponse<SearchItemResponse> localVarResponse = await SearchesGetSearchItemsByAssociationScopeScopeOwnerFolderV1AsyncWithHttpInfo(association, scope, scopeowner, folder, links, lang, locale);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all saved searches by Folder ID Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Use to filter results by Business Object association ID.</param>
        /// <param name="scope">Use to filter results by scope name or ID.</param>
        /// <param name="scopeowner">Use to filter results by scope owner ID.</param>
        /// <param name="folder">Use to filter results by Search Group folder ID.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsSearchesSearchItemResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SearchItemResponse>> SearchesGetSearchItemsByAssociationScopeScopeOwnerFolderV1AsyncWithHttpInfo (string association, string scope, string scopeowner, string folder, bool? links = null, string lang = null, string locale = null)
        {
            // verify the required parameter 'association' is set
            if (association == null)
                throw new ApiException(400, "Missing required parameter 'association' when calling SearchesApi->SearchesGetSearchItemsByAssociationScopeScopeOwnerFolderV1");
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling SearchesApi->SearchesGetSearchItemsByAssociationScopeScopeOwnerFolderV1");
            // verify the required parameter 'scopeowner' is set
            if (scopeowner == null)
                throw new ApiException(400, "Missing required parameter 'scopeowner' when calling SearchesApi->SearchesGetSearchItemsByAssociationScopeScopeOwnerFolderV1");
            // verify the required parameter 'folder' is set
            if (folder == null)
                throw new ApiException(400, "Missing required parameter 'folder' when calling SearchesApi->SearchesGetSearchItemsByAssociationScopeScopeOwnerFolderV1");

            var localVarPath = "/api/V1/getsearchitems/association/{association}/scope/{scope}/scopeowner/{scopeowner}/folder/{folder}";
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

            if (association != null) localVarPathParams.Add("association", Configuration.ApiClient.ParameterToString(association)); // path parameter
            if (scope != null) localVarPathParams.Add("scope", Configuration.ApiClient.ParameterToString(scope)); // path parameter
            if (scopeowner != null) localVarPathParams.Add("scopeowner", Configuration.ApiClient.ParameterToString(scopeowner)); // path parameter
            if (folder != null) localVarPathParams.Add("folder", Configuration.ApiClient.ParameterToString(folder)); // path parameter
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
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SearchesGetSearchItemsByAssociationScopeScopeOwnerFolderV1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SearchItemResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SearchItemResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SearchItemResponse)));
        }

        /// <summary>
        /// Get all saved searches by Folder ID Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Use to filter results by Business Object association ID.</param>
        /// <param name="scope">Use to filter results by scope name or ID.</param>
        /// <param name="scopeowner">Use to filter results by scope owner ID.</param>
        /// <param name="folder">Use to filter results by Search Group folder ID.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsCoreManagerData</returns>
        public ManagerData SearchesGetSearchItemsByAssociationScopeScopeOwnerFolderV2 (string association, string scope, string scopeowner, string folder, bool? links = null, string lang = null, string locale = null)
        {
             ApiResponse<ManagerData> localVarResponse = SearchesGetSearchItemsByAssociationScopeScopeOwnerFolderV2WithHttpInfo(association, scope, scopeowner, folder, links, lang, locale);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all saved searches by Folder ID Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Use to filter results by Business Object association ID.</param>
        /// <param name="scope">Use to filter results by scope name or ID.</param>
        /// <param name="scopeowner">Use to filter results by scope owner ID.</param>
        /// <param name="folder">Use to filter results by Search Group folder ID.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsCoreManagerData</returns>
        public ApiResponse< ManagerData > SearchesGetSearchItemsByAssociationScopeScopeOwnerFolderV2WithHttpInfo (string association, string scope, string scopeowner, string folder, bool? links = null, string lang = null, string locale = null)
        {
            // verify the required parameter 'association' is set
            if (association == null)
                throw new ApiException(400, "Missing required parameter 'association' when calling SearchesApi->SearchesGetSearchItemsByAssociationScopeScopeOwnerFolderV2");
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling SearchesApi->SearchesGetSearchItemsByAssociationScopeScopeOwnerFolderV2");
            // verify the required parameter 'scopeowner' is set
            if (scopeowner == null)
                throw new ApiException(400, "Missing required parameter 'scopeowner' when calling SearchesApi->SearchesGetSearchItemsByAssociationScopeScopeOwnerFolderV2");
            // verify the required parameter 'folder' is set
            if (folder == null)
                throw new ApiException(400, "Missing required parameter 'folder' when calling SearchesApi->SearchesGetSearchItemsByAssociationScopeScopeOwnerFolderV2");

            var localVarPath = "/api/V2/getsearchitems/association/{association}/scope/{scope}/scopeowner/{scopeowner}/folder/{folder}";
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

            if (association != null) localVarPathParams.Add("association", Configuration.ApiClient.ParameterToString(association)); // path parameter
            if (scope != null) localVarPathParams.Add("scope", Configuration.ApiClient.ParameterToString(scope)); // path parameter
            if (scopeowner != null) localVarPathParams.Add("scopeowner", Configuration.ApiClient.ParameterToString(scopeowner)); // path parameter
            if (folder != null) localVarPathParams.Add("folder", Configuration.ApiClient.ParameterToString(folder)); // path parameter
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
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SearchesGetSearchItemsByAssociationScopeScopeOwnerFolderV2", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ManagerData>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ManagerData) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManagerData)));
        }

        /// <summary>
        /// Get all saved searches by Folder ID Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Use to filter results by Business Object association ID.</param>
        /// <param name="scope">Use to filter results by scope name or ID.</param>
        /// <param name="scopeowner">Use to filter results by scope owner ID.</param>
        /// <param name="folder">Use to filter results by Search Group folder ID.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsCoreManagerData</returns>
        public async System.Threading.Tasks.Task<ManagerData> SearchesGetSearchItemsByAssociationScopeScopeOwnerFolderV2Async (string association, string scope, string scopeowner, string folder, bool? links = null, string lang = null, string locale = null)
        {
             ApiResponse<ManagerData> localVarResponse = await SearchesGetSearchItemsByAssociationScopeScopeOwnerFolderV2AsyncWithHttpInfo(association, scope, scopeowner, folder, links, lang, locale);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all saved searches by Folder ID Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Use to filter results by Business Object association ID.</param>
        /// <param name="scope">Use to filter results by scope name or ID.</param>
        /// <param name="scopeowner">Use to filter results by scope owner ID.</param>
        /// <param name="folder">Use to filter results by Search Group folder ID.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsCoreManagerData)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ManagerData>> SearchesGetSearchItemsByAssociationScopeScopeOwnerFolderV2AsyncWithHttpInfo (string association, string scope, string scopeowner, string folder, bool? links = null, string lang = null, string locale = null)
        {
            // verify the required parameter 'association' is set
            if (association == null)
                throw new ApiException(400, "Missing required parameter 'association' when calling SearchesApi->SearchesGetSearchItemsByAssociationScopeScopeOwnerFolderV2");
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling SearchesApi->SearchesGetSearchItemsByAssociationScopeScopeOwnerFolderV2");
            // verify the required parameter 'scopeowner' is set
            if (scopeowner == null)
                throw new ApiException(400, "Missing required parameter 'scopeowner' when calling SearchesApi->SearchesGetSearchItemsByAssociationScopeScopeOwnerFolderV2");
            // verify the required parameter 'folder' is set
            if (folder == null)
                throw new ApiException(400, "Missing required parameter 'folder' when calling SearchesApi->SearchesGetSearchItemsByAssociationScopeScopeOwnerFolderV2");

            var localVarPath = "/api/V2/getsearchitems/association/{association}/scope/{scope}/scopeowner/{scopeowner}/folder/{folder}";
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

            if (association != null) localVarPathParams.Add("association", Configuration.ApiClient.ParameterToString(association)); // path parameter
            if (scope != null) localVarPathParams.Add("scope", Configuration.ApiClient.ParameterToString(scope)); // path parameter
            if (scopeowner != null) localVarPathParams.Add("scopeowner", Configuration.ApiClient.ParameterToString(scopeowner)); // path parameter
            if (folder != null) localVarPathParams.Add("folder", Configuration.ApiClient.ParameterToString(folder)); // path parameter
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
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SearchesGetSearchItemsByAssociationScopeScopeOwnerFolderV2", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ManagerData>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ManagerData) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManagerData)));
        }

        /// <summary>
        /// Get all saved searches by scope owner (sub scope) Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Use to filter results by Business Object association ID.</param>
        /// <param name="scope">Use to filter results by scope name or ID.</param>
        /// <param name="scopeowner">Use to filter results by scope owner ID.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsSearchesSearchItemResponse</returns>
        public SearchItemResponse SearchesGetSearchItemsByAssociationScopeScopeOwnerV1 (string association, string scope, string scopeowner, bool? links = null, string lang = null, string locale = null)
        {
             ApiResponse<SearchItemResponse> localVarResponse = SearchesGetSearchItemsByAssociationScopeScopeOwnerV1WithHttpInfo(association, scope, scopeowner, links, lang, locale);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all saved searches by scope owner (sub scope) Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Use to filter results by Business Object association ID.</param>
        /// <param name="scope">Use to filter results by scope name or ID.</param>
        /// <param name="scopeowner">Use to filter results by scope owner ID.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsSearchesSearchItemResponse</returns>
        public ApiResponse< SearchItemResponse > SearchesGetSearchItemsByAssociationScopeScopeOwnerV1WithHttpInfo (string association, string scope, string scopeowner, bool? links = null, string lang = null, string locale = null)
        {
            // verify the required parameter 'association' is set
            if (association == null)
                throw new ApiException(400, "Missing required parameter 'association' when calling SearchesApi->SearchesGetSearchItemsByAssociationScopeScopeOwnerV1");
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling SearchesApi->SearchesGetSearchItemsByAssociationScopeScopeOwnerV1");
            // verify the required parameter 'scopeowner' is set
            if (scopeowner == null)
                throw new ApiException(400, "Missing required parameter 'scopeowner' when calling SearchesApi->SearchesGetSearchItemsByAssociationScopeScopeOwnerV1");

            var localVarPath = "/api/V1/getsearchitems/association/{association}/scope/{scope}/scopeowner/{scopeowner}";
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

            if (association != null) localVarPathParams.Add("association", Configuration.ApiClient.ParameterToString(association)); // path parameter
            if (scope != null) localVarPathParams.Add("scope", Configuration.ApiClient.ParameterToString(scope)); // path parameter
            if (scopeowner != null) localVarPathParams.Add("scopeowner", Configuration.ApiClient.ParameterToString(scopeowner)); // path parameter
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
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SearchesGetSearchItemsByAssociationScopeScopeOwnerV1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SearchItemResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SearchItemResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SearchItemResponse)));
        }

        /// <summary>
        /// Get all saved searches by scope owner (sub scope) Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Use to filter results by Business Object association ID.</param>
        /// <param name="scope">Use to filter results by scope name or ID.</param>
        /// <param name="scopeowner">Use to filter results by scope owner ID.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsSearchesSearchItemResponse</returns>
        public async System.Threading.Tasks.Task<SearchItemResponse> SearchesGetSearchItemsByAssociationScopeScopeOwnerV1Async (string association, string scope, string scopeowner, bool? links = null, string lang = null, string locale = null)
        {
             ApiResponse<SearchItemResponse> localVarResponse = await SearchesGetSearchItemsByAssociationScopeScopeOwnerV1AsyncWithHttpInfo(association, scope, scopeowner, links, lang, locale);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all saved searches by scope owner (sub scope) Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Use to filter results by Business Object association ID.</param>
        /// <param name="scope">Use to filter results by scope name or ID.</param>
        /// <param name="scopeowner">Use to filter results by scope owner ID.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsSearchesSearchItemResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SearchItemResponse>> SearchesGetSearchItemsByAssociationScopeScopeOwnerV1AsyncWithHttpInfo (string association, string scope, string scopeowner, bool? links = null, string lang = null, string locale = null)
        {
            // verify the required parameter 'association' is set
            if (association == null)
                throw new ApiException(400, "Missing required parameter 'association' when calling SearchesApi->SearchesGetSearchItemsByAssociationScopeScopeOwnerV1");
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling SearchesApi->SearchesGetSearchItemsByAssociationScopeScopeOwnerV1");
            // verify the required parameter 'scopeowner' is set
            if (scopeowner == null)
                throw new ApiException(400, "Missing required parameter 'scopeowner' when calling SearchesApi->SearchesGetSearchItemsByAssociationScopeScopeOwnerV1");

            var localVarPath = "/api/V1/getsearchitems/association/{association}/scope/{scope}/scopeowner/{scopeowner}";
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

            if (association != null) localVarPathParams.Add("association", Configuration.ApiClient.ParameterToString(association)); // path parameter
            if (scope != null) localVarPathParams.Add("scope", Configuration.ApiClient.ParameterToString(scope)); // path parameter
            if (scopeowner != null) localVarPathParams.Add("scopeowner", Configuration.ApiClient.ParameterToString(scopeowner)); // path parameter
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
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SearchesGetSearchItemsByAssociationScopeScopeOwnerV1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SearchItemResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SearchItemResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SearchItemResponse)));
        }

        /// <summary>
        /// Get all saved searches by scope owner (sub scope) Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Use to filter results by Business Object association ID.</param>
        /// <param name="scope">Use to filter results by scope name or ID.</param>
        /// <param name="scopeowner">Use to filter results by scope owner ID.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsCoreManagerData</returns>
        public ManagerData SearchesGetSearchItemsByAssociationScopeScopeOwnerV2 (string association, string scope, string scopeowner, bool? links = null, string lang = null, string locale = null)
        {
             ApiResponse<ManagerData> localVarResponse = SearchesGetSearchItemsByAssociationScopeScopeOwnerV2WithHttpInfo(association, scope, scopeowner, links, lang, locale);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all saved searches by scope owner (sub scope) Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Use to filter results by Business Object association ID.</param>
        /// <param name="scope">Use to filter results by scope name or ID.</param>
        /// <param name="scopeowner">Use to filter results by scope owner ID.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsCoreManagerData</returns>
        public ApiResponse< ManagerData > SearchesGetSearchItemsByAssociationScopeScopeOwnerV2WithHttpInfo (string association, string scope, string scopeowner, bool? links = null, string lang = null, string locale = null)
        {
            // verify the required parameter 'association' is set
            if (association == null)
                throw new ApiException(400, "Missing required parameter 'association' when calling SearchesApi->SearchesGetSearchItemsByAssociationScopeScopeOwnerV2");
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling SearchesApi->SearchesGetSearchItemsByAssociationScopeScopeOwnerV2");
            // verify the required parameter 'scopeowner' is set
            if (scopeowner == null)
                throw new ApiException(400, "Missing required parameter 'scopeowner' when calling SearchesApi->SearchesGetSearchItemsByAssociationScopeScopeOwnerV2");

            var localVarPath = "/api/V2/getsearchitems/association/{association}/scope/{scope}/scopeowner/{scopeowner}";
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

            if (association != null) localVarPathParams.Add("association", Configuration.ApiClient.ParameterToString(association)); // path parameter
            if (scope != null) localVarPathParams.Add("scope", Configuration.ApiClient.ParameterToString(scope)); // path parameter
            if (scopeowner != null) localVarPathParams.Add("scopeowner", Configuration.ApiClient.ParameterToString(scopeowner)); // path parameter
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
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SearchesGetSearchItemsByAssociationScopeScopeOwnerV2", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ManagerData>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ManagerData) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManagerData)));
        }

        /// <summary>
        /// Get all saved searches by scope owner (sub scope) Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Use to filter results by Business Object association ID.</param>
        /// <param name="scope">Use to filter results by scope name or ID.</param>
        /// <param name="scopeowner">Use to filter results by scope owner ID.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsCoreManagerData</returns>
        public async System.Threading.Tasks.Task<ManagerData> SearchesGetSearchItemsByAssociationScopeScopeOwnerV2Async (string association, string scope, string scopeowner, bool? links = null, string lang = null, string locale = null)
        {
             ApiResponse<ManagerData> localVarResponse = await SearchesGetSearchItemsByAssociationScopeScopeOwnerV2AsyncWithHttpInfo(association, scope, scopeowner, links, lang, locale);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all saved searches by scope owner (sub scope) Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Use to filter results by Business Object association ID.</param>
        /// <param name="scope">Use to filter results by scope name or ID.</param>
        /// <param name="scopeowner">Use to filter results by scope owner ID.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsCoreManagerData)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ManagerData>> SearchesGetSearchItemsByAssociationScopeScopeOwnerV2AsyncWithHttpInfo (string association, string scope, string scopeowner, bool? links = null, string lang = null, string locale = null)
        {
            // verify the required parameter 'association' is set
            if (association == null)
                throw new ApiException(400, "Missing required parameter 'association' when calling SearchesApi->SearchesGetSearchItemsByAssociationScopeScopeOwnerV2");
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling SearchesApi->SearchesGetSearchItemsByAssociationScopeScopeOwnerV2");
            // verify the required parameter 'scopeowner' is set
            if (scopeowner == null)
                throw new ApiException(400, "Missing required parameter 'scopeowner' when calling SearchesApi->SearchesGetSearchItemsByAssociationScopeScopeOwnerV2");

            var localVarPath = "/api/V2/getsearchitems/association/{association}/scope/{scope}/scopeowner/{scopeowner}";
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

            if (association != null) localVarPathParams.Add("association", Configuration.ApiClient.ParameterToString(association)); // path parameter
            if (scope != null) localVarPathParams.Add("scope", Configuration.ApiClient.ParameterToString(scope)); // path parameter
            if (scopeowner != null) localVarPathParams.Add("scopeowner", Configuration.ApiClient.ParameterToString(scopeowner)); // path parameter
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
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SearchesGetSearchItemsByAssociationScopeScopeOwnerV2", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ManagerData>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ManagerData) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManagerData)));
        }

        /// <summary>
        /// Get all saved searches by scope Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Use to filter results by Business Object association ID.</param>
        /// <param name="scope">Use to filter results by scope name or ID.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsSearchesSearchItemResponse</returns>
        public SearchItemResponse SearchesGetSearchItemsByAssociationScopeV1 (string association, string scope, bool? links = null, string lang = null, string locale = null)
        {
             ApiResponse<SearchItemResponse> localVarResponse = SearchesGetSearchItemsByAssociationScopeV1WithHttpInfo(association, scope, links, lang, locale);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all saved searches by scope Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Use to filter results by Business Object association ID.</param>
        /// <param name="scope">Use to filter results by scope name or ID.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsSearchesSearchItemResponse</returns>
        public ApiResponse< SearchItemResponse > SearchesGetSearchItemsByAssociationScopeV1WithHttpInfo (string association, string scope, bool? links = null, string lang = null, string locale = null)
        {
            // verify the required parameter 'association' is set
            if (association == null)
                throw new ApiException(400, "Missing required parameter 'association' when calling SearchesApi->SearchesGetSearchItemsByAssociationScopeV1");
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling SearchesApi->SearchesGetSearchItemsByAssociationScopeV1");

            var localVarPath = "/api/V1/getsearchitems/association/{association}/scope/{scope}";
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

            if (association != null) localVarPathParams.Add("association", Configuration.ApiClient.ParameterToString(association)); // path parameter
            if (scope != null) localVarPathParams.Add("scope", Configuration.ApiClient.ParameterToString(scope)); // path parameter
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
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SearchesGetSearchItemsByAssociationScopeV1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SearchItemResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SearchItemResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SearchItemResponse)));
        }

        /// <summary>
        /// Get all saved searches by scope Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Use to filter results by Business Object association ID.</param>
        /// <param name="scope">Use to filter results by scope name or ID.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsSearchesSearchItemResponse</returns>
        public async System.Threading.Tasks.Task<SearchItemResponse> SearchesGetSearchItemsByAssociationScopeV1Async (string association, string scope, bool? links = null, string lang = null, string locale = null)
        {
             ApiResponse<SearchItemResponse> localVarResponse = await SearchesGetSearchItemsByAssociationScopeV1AsyncWithHttpInfo(association, scope, links, lang, locale);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all saved searches by scope Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Use to filter results by Business Object association ID.</param>
        /// <param name="scope">Use to filter results by scope name or ID.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsSearchesSearchItemResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SearchItemResponse>> SearchesGetSearchItemsByAssociationScopeV1AsyncWithHttpInfo (string association, string scope, bool? links = null, string lang = null, string locale = null)
        {
            // verify the required parameter 'association' is set
            if (association == null)
                throw new ApiException(400, "Missing required parameter 'association' when calling SearchesApi->SearchesGetSearchItemsByAssociationScopeV1");
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling SearchesApi->SearchesGetSearchItemsByAssociationScopeV1");

            var localVarPath = "/api/V1/getsearchitems/association/{association}/scope/{scope}";
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

            if (association != null) localVarPathParams.Add("association", Configuration.ApiClient.ParameterToString(association)); // path parameter
            if (scope != null) localVarPathParams.Add("scope", Configuration.ApiClient.ParameterToString(scope)); // path parameter
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
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SearchesGetSearchItemsByAssociationScopeV1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SearchItemResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SearchItemResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SearchItemResponse)));
        }

        /// <summary>
        /// Get all saved searches by scope Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Use to filter results by Business Object association ID.</param>
        /// <param name="scope">Use to filter results by scope name or ID.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsCoreManagerData</returns>
        public ManagerData SearchesGetSearchItemsByAssociationScopeV2 (string association, string scope, bool? links = null, string lang = null, string locale = null)
        {
             ApiResponse<ManagerData> localVarResponse = SearchesGetSearchItemsByAssociationScopeV2WithHttpInfo(association, scope, links, lang, locale);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all saved searches by scope Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Use to filter results by Business Object association ID.</param>
        /// <param name="scope">Use to filter results by scope name or ID.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsCoreManagerData</returns>
        public ApiResponse< ManagerData > SearchesGetSearchItemsByAssociationScopeV2WithHttpInfo (string association, string scope, bool? links = null, string lang = null, string locale = null)
        {
            // verify the required parameter 'association' is set
            if (association == null)
                throw new ApiException(400, "Missing required parameter 'association' when calling SearchesApi->SearchesGetSearchItemsByAssociationScopeV2");
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling SearchesApi->SearchesGetSearchItemsByAssociationScopeV2");

            var localVarPath = "/api/V2/getsearchitems/association/{association}/scope/{scope}";
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

            if (association != null) localVarPathParams.Add("association", Configuration.ApiClient.ParameterToString(association)); // path parameter
            if (scope != null) localVarPathParams.Add("scope", Configuration.ApiClient.ParameterToString(scope)); // path parameter
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
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SearchesGetSearchItemsByAssociationScopeV2", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ManagerData>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ManagerData) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManagerData)));
        }

        /// <summary>
        /// Get all saved searches by scope Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Use to filter results by Business Object association ID.</param>
        /// <param name="scope">Use to filter results by scope name or ID.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsCoreManagerData</returns>
        public async System.Threading.Tasks.Task<ManagerData> SearchesGetSearchItemsByAssociationScopeV2Async (string association, string scope, bool? links = null, string lang = null, string locale = null)
        {
             ApiResponse<ManagerData> localVarResponse = await SearchesGetSearchItemsByAssociationScopeV2AsyncWithHttpInfo(association, scope, links, lang, locale);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all saved searches by scope Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Use to filter results by Business Object association ID.</param>
        /// <param name="scope">Use to filter results by scope name or ID.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsCoreManagerData)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ManagerData>> SearchesGetSearchItemsByAssociationScopeV2AsyncWithHttpInfo (string association, string scope, bool? links = null, string lang = null, string locale = null)
        {
            // verify the required parameter 'association' is set
            if (association == null)
                throw new ApiException(400, "Missing required parameter 'association' when calling SearchesApi->SearchesGetSearchItemsByAssociationScopeV2");
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling SearchesApi->SearchesGetSearchItemsByAssociationScopeV2");

            var localVarPath = "/api/V2/getsearchitems/association/{association}/scope/{scope}";
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

            if (association != null) localVarPathParams.Add("association", Configuration.ApiClient.ParameterToString(association)); // path parameter
            if (scope != null) localVarPathParams.Add("scope", Configuration.ApiClient.ParameterToString(scope)); // path parameter
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
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SearchesGetSearchItemsByAssociationScopeV2", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ManagerData>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ManagerData) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManagerData)));
        }

        /// <summary>
        /// Get all saved searches by Business Object association Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Use to filter results by Business Object association ID.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsSearchesSearchItemResponse</returns>
        public SearchItemResponse SearchesGetSearchItemsByAssociationV1 (string association, bool? links = null, string lang = null, string locale = null)
        {
             ApiResponse<SearchItemResponse> localVarResponse = SearchesGetSearchItemsByAssociationV1WithHttpInfo(association, links, lang, locale);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all saved searches by Business Object association Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Use to filter results by Business Object association ID.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsSearchesSearchItemResponse</returns>
        public ApiResponse< SearchItemResponse > SearchesGetSearchItemsByAssociationV1WithHttpInfo (string association, bool? links = null, string lang = null, string locale = null)
        {
            // verify the required parameter 'association' is set
            if (association == null)
                throw new ApiException(400, "Missing required parameter 'association' when calling SearchesApi->SearchesGetSearchItemsByAssociationV1");

            var localVarPath = "/api/V1/getsearchitems/association/{association}";
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

            if (association != null) localVarPathParams.Add("association", Configuration.ApiClient.ParameterToString(association)); // path parameter
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
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SearchesGetSearchItemsByAssociationV1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SearchItemResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SearchItemResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SearchItemResponse)));
        }

        /// <summary>
        /// Get all saved searches by Business Object association Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Use to filter results by Business Object association ID.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsSearchesSearchItemResponse</returns>
        public async System.Threading.Tasks.Task<SearchItemResponse> SearchesGetSearchItemsByAssociationV1Async (string association, bool? links = null, string lang = null, string locale = null)
        {
             ApiResponse<SearchItemResponse> localVarResponse = await SearchesGetSearchItemsByAssociationV1AsyncWithHttpInfo(association, links, lang, locale);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all saved searches by Business Object association Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Use to filter results by Business Object association ID.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsSearchesSearchItemResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SearchItemResponse>> SearchesGetSearchItemsByAssociationV1AsyncWithHttpInfo (string association, bool? links = null, string lang = null, string locale = null)
        {
            // verify the required parameter 'association' is set
            if (association == null)
                throw new ApiException(400, "Missing required parameter 'association' when calling SearchesApi->SearchesGetSearchItemsByAssociationV1");

            var localVarPath = "/api/V1/getsearchitems/association/{association}";
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

            if (association != null) localVarPathParams.Add("association", Configuration.ApiClient.ParameterToString(association)); // path parameter
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
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SearchesGetSearchItemsByAssociationV1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SearchItemResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SearchItemResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SearchItemResponse)));
        }

        /// <summary>
        /// Get all saved searches by Business Object association Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Use to filter results by Business Object association ID.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsCoreManagerData</returns>
        public ManagerData SearchesGetSearchItemsByAssociationV2 (string association, bool? links = null, string lang = null, string locale = null)
        {
             ApiResponse<ManagerData> localVarResponse = SearchesGetSearchItemsByAssociationV2WithHttpInfo(association, links, lang, locale);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all saved searches by Business Object association Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Use to filter results by Business Object association ID.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsCoreManagerData</returns>
        public ApiResponse< ManagerData > SearchesGetSearchItemsByAssociationV2WithHttpInfo (string association, bool? links = null, string lang = null, string locale = null)
        {
            // verify the required parameter 'association' is set
            if (association == null)
                throw new ApiException(400, "Missing required parameter 'association' when calling SearchesApi->SearchesGetSearchItemsByAssociationV2");

            var localVarPath = "/api/V2/getsearchitems/association/{association}";
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

            if (association != null) localVarPathParams.Add("association", Configuration.ApiClient.ParameterToString(association)); // path parameter
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
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SearchesGetSearchItemsByAssociationV2", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ManagerData>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ManagerData) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManagerData)));
        }

        /// <summary>
        /// Get all saved searches by Business Object association Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Use to filter results by Business Object association ID.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsCoreManagerData</returns>
        public async System.Threading.Tasks.Task<ManagerData> SearchesGetSearchItemsByAssociationV2Async (string association, bool? links = null, string lang = null, string locale = null)
        {
             ApiResponse<ManagerData> localVarResponse = await SearchesGetSearchItemsByAssociationV2AsyncWithHttpInfo(association, links, lang, locale);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all saved searches by Business Object association Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Use to filter results by Business Object association ID.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsCoreManagerData)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ManagerData>> SearchesGetSearchItemsByAssociationV2AsyncWithHttpInfo (string association, bool? links = null, string lang = null, string locale = null)
        {
            // verify the required parameter 'association' is set
            if (association == null)
                throw new ApiException(400, "Missing required parameter 'association' when calling SearchesApi->SearchesGetSearchItemsByAssociationV2");

            var localVarPath = "/api/V2/getsearchitems/association/{association}";
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

            if (association != null) localVarPathParams.Add("association", Configuration.ApiClient.ParameterToString(association)); // path parameter
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
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SearchesGetSearchItemsByAssociationV2", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ManagerData>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ManagerData) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManagerData)));
        }

        /// <summary>
        /// Get all saved searches by default Business Object association Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsSearchesSearchItemResponse</returns>
        public SearchItemResponse SearchesGetSearchItemsV1 (bool? links = null, string lang = null, string locale = null)
        {
             ApiResponse<SearchItemResponse> localVarResponse = SearchesGetSearchItemsV1WithHttpInfo(links, lang, locale);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all saved searches by default Business Object association Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsSearchesSearchItemResponse</returns>
        public ApiResponse< SearchItemResponse > SearchesGetSearchItemsV1WithHttpInfo (bool? links = null, string lang = null, string locale = null)
        {

            var localVarPath = "/api/V1/getsearchitems";
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
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SearchesGetSearchItemsV1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SearchItemResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SearchItemResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SearchItemResponse)));
        }

        /// <summary>
        /// Get all saved searches by default Business Object association Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsSearchesSearchItemResponse</returns>
        public async System.Threading.Tasks.Task<SearchItemResponse> SearchesGetSearchItemsV1Async (bool? links = null, string lang = null, string locale = null)
        {
             ApiResponse<SearchItemResponse> localVarResponse = await SearchesGetSearchItemsV1AsyncWithHttpInfo(links, lang, locale);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all saved searches by default Business Object association Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsSearchesSearchItemResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SearchItemResponse>> SearchesGetSearchItemsV1AsyncWithHttpInfo (bool? links = null, string lang = null, string locale = null)
        {

            var localVarPath = "/api/V1/getsearchitems";
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
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SearchesGetSearchItemsV1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SearchItemResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SearchItemResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SearchItemResponse)));
        }

        /// <summary>
        /// Get all saved searches by default Business Object association Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsCoreManagerData</returns>
        public ManagerData SearchesGetSearchItemsV2 (bool? links = null, string lang = null, string locale = null)
        {
             ApiResponse<ManagerData> localVarResponse = SearchesGetSearchItemsV2WithHttpInfo(links, lang, locale);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all saved searches by default Business Object association Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsCoreManagerData</returns>
        public ApiResponse< ManagerData > SearchesGetSearchItemsV2WithHttpInfo (bool? links = null, string lang = null, string locale = null)
        {

            var localVarPath = "/api/V2/getsearchitems";
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
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SearchesGetSearchItemsV2", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ManagerData>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ManagerData) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManagerData)));
        }

        /// <summary>
        /// Get all saved searches by default Business Object association Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsCoreManagerData</returns>
        public async System.Threading.Tasks.Task<ManagerData> SearchesGetSearchItemsV2Async (bool? links = null, string lang = null, string locale = null)
        {
             ApiResponse<ManagerData> localVarResponse = await SearchesGetSearchItemsV2AsyncWithHttpInfo(links, lang, locale);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all saved searches by default Business Object association Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsCoreManagerData)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ManagerData>> SearchesGetSearchItemsV2AsyncWithHttpInfo (bool? links = null, string lang = null, string locale = null)
        {

            var localVarPath = "/api/V2/getsearchitems";
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
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SearchesGetSearchItemsV2", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ManagerData>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ManagerData) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManagerData)));
        }

        /// <summary>
        /// Run an ad-hoc search Operation that runs an ad-hoc Business Object search. To execute a search with Prompts, the PromptId and Value are required in the Prompt request object.&lt;/br&gt;&lt;/br&gt;PromptType is a FieldSubType enum as described below:&lt;/br&gt;FieldSubType&lt;/br&gt;None &#x3D; 0&lt;/br&gt;Text &#x3D; 1&lt;/br&gt;Number &#x3D; 2&lt;/br&gt;DateTime &#x3D; 3&lt;/br&gt;Logical &#x3D; 4&lt;/br&gt;Binary &#x3D; 5&lt;/br&gt;DateOnly &#x3D; 6&lt;/br&gt;TimeOnly &#x3D; 7&lt;/br&gt;Json &#x3D; 8&lt;/br&gt;JsonArray &#x3D; 9&lt;/br&gt;Xml &#x3D; 10&lt;/br&gt;XmlCollection &#x3D; 11&lt;/br&gt;TimeValue &#x3D; 12&lt;/br&gt;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataRequest">Request object to specify search parameters.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsSearchesSearchResultsResponse</returns>
        public SearchResultsResponse SearchesGetSearchResultsAdHocV1 (SearchResultsRequest dataRequest, string lang = null, string locale = null)
        {
             ApiResponse<SearchResultsResponse> localVarResponse = SearchesGetSearchResultsAdHocV1WithHttpInfo(dataRequest, lang, locale);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Run an ad-hoc search Operation that runs an ad-hoc Business Object search. To execute a search with Prompts, the PromptId and Value are required in the Prompt request object.&lt;/br&gt;&lt;/br&gt;PromptType is a FieldSubType enum as described below:&lt;/br&gt;FieldSubType&lt;/br&gt;None &#x3D; 0&lt;/br&gt;Text &#x3D; 1&lt;/br&gt;Number &#x3D; 2&lt;/br&gt;DateTime &#x3D; 3&lt;/br&gt;Logical &#x3D; 4&lt;/br&gt;Binary &#x3D; 5&lt;/br&gt;DateOnly &#x3D; 6&lt;/br&gt;TimeOnly &#x3D; 7&lt;/br&gt;Json &#x3D; 8&lt;/br&gt;JsonArray &#x3D; 9&lt;/br&gt;Xml &#x3D; 10&lt;/br&gt;XmlCollection &#x3D; 11&lt;/br&gt;TimeValue &#x3D; 12&lt;/br&gt;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataRequest">Request object to specify search parameters.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsSearchesSearchResultsResponse</returns>
        public ApiResponse< SearchResultsResponse > SearchesGetSearchResultsAdHocV1WithHttpInfo (SearchResultsRequest dataRequest, string lang = null, string locale = null)
        {
            // verify the required parameter 'dataRequest' is set
            if (dataRequest == null)
                throw new ApiException(400, "Missing required parameter 'dataRequest' when calling SearchesApi->SearchesGetSearchResultsAdHocV1");

            var localVarPath = "/api/V1/getsearchresults";
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

            if (lang != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter
            if (dataRequest != null && dataRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(dataRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = dataRequest; // byte array
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
                Exception exception = ExceptionFactory("SearchesGetSearchResultsAdHocV1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SearchResultsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SearchResultsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SearchResultsResponse)));
        }

        /// <summary>
        /// Run an ad-hoc search Operation that runs an ad-hoc Business Object search. To execute a search with Prompts, the PromptId and Value are required in the Prompt request object.&lt;/br&gt;&lt;/br&gt;PromptType is a FieldSubType enum as described below:&lt;/br&gt;FieldSubType&lt;/br&gt;None &#x3D; 0&lt;/br&gt;Text &#x3D; 1&lt;/br&gt;Number &#x3D; 2&lt;/br&gt;DateTime &#x3D; 3&lt;/br&gt;Logical &#x3D; 4&lt;/br&gt;Binary &#x3D; 5&lt;/br&gt;DateOnly &#x3D; 6&lt;/br&gt;TimeOnly &#x3D; 7&lt;/br&gt;Json &#x3D; 8&lt;/br&gt;JsonArray &#x3D; 9&lt;/br&gt;Xml &#x3D; 10&lt;/br&gt;XmlCollection &#x3D; 11&lt;/br&gt;TimeValue &#x3D; 12&lt;/br&gt;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataRequest">Request object to specify search parameters.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsSearchesSearchResultsResponse</returns>
        public async System.Threading.Tasks.Task<SearchResultsResponse> SearchesGetSearchResultsAdHocV1Async (SearchResultsRequest dataRequest, string lang = null, string locale = null)
        {
             ApiResponse<SearchResultsResponse> localVarResponse = await SearchesGetSearchResultsAdHocV1AsyncWithHttpInfo(dataRequest, lang, locale);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Run an ad-hoc search Operation that runs an ad-hoc Business Object search. To execute a search with Prompts, the PromptId and Value are required in the Prompt request object.&lt;/br&gt;&lt;/br&gt;PromptType is a FieldSubType enum as described below:&lt;/br&gt;FieldSubType&lt;/br&gt;None &#x3D; 0&lt;/br&gt;Text &#x3D; 1&lt;/br&gt;Number &#x3D; 2&lt;/br&gt;DateTime &#x3D; 3&lt;/br&gt;Logical &#x3D; 4&lt;/br&gt;Binary &#x3D; 5&lt;/br&gt;DateOnly &#x3D; 6&lt;/br&gt;TimeOnly &#x3D; 7&lt;/br&gt;Json &#x3D; 8&lt;/br&gt;JsonArray &#x3D; 9&lt;/br&gt;Xml &#x3D; 10&lt;/br&gt;XmlCollection &#x3D; 11&lt;/br&gt;TimeValue &#x3D; 12&lt;/br&gt;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataRequest">Request object to specify search parameters.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsSearchesSearchResultsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SearchResultsResponse>> SearchesGetSearchResultsAdHocV1AsyncWithHttpInfo (SearchResultsRequest dataRequest, string lang = null, string locale = null)
        {
            // verify the required parameter 'dataRequest' is set
            if (dataRequest == null)
                throw new ApiException(400, "Missing required parameter 'dataRequest' when calling SearchesApi->SearchesGetSearchResultsAdHocV1");

            var localVarPath = "/api/V1/getsearchresults";
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

            if (lang != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter
            if (dataRequest != null && dataRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(dataRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = dataRequest; // byte array
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
                Exception exception = ExceptionFactory("SearchesGetSearchResultsAdHocV1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SearchResultsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SearchResultsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SearchResultsResponse)));
        }

        /// <summary>
        /// Get results of a saved search Operation that returns the results of a saved search in JSON format.&lt;/br&gt;&lt;/br&gt;This API is protected by a rate limiter and will reject any requests sent from an IP Address when a certain threshold of active concurrent requests has been hit.&lt;/br&gt;&lt;/br&gt;This value can be configured by the Max Concurrent Requests configuration value in the Web API config.&lt;/br&gt;&lt;/br&gt;Once this limit has been reached, all subsequent requests will receive a status code of 429 (Too Many Requests).&lt;/br&gt;&lt;/br&gt;This version is not subject to row limits and will return the entire result set of the stored search.&lt;/br&gt;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchRequest">Request object to specify search parameters.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsSearchesStoredSearchResults</returns>
        public StoredSearchResults SearchesGetSearchResultsAsStringByIdV2 (StoredSearchRequest searchRequest, string lang = null, string locale = null)
        {
             ApiResponse<StoredSearchResults> localVarResponse = SearchesGetSearchResultsAsStringByIdV2WithHttpInfo(searchRequest, lang, locale);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get results of a saved search Operation that returns the results of a saved search in JSON format.&lt;/br&gt;&lt;/br&gt;This API is protected by a rate limiter and will reject any requests sent from an IP Address when a certain threshold of active concurrent requests has been hit.&lt;/br&gt;&lt;/br&gt;This value can be configured by the Max Concurrent Requests configuration value in the Web API config.&lt;/br&gt;&lt;/br&gt;Once this limit has been reached, all subsequent requests will receive a status code of 429 (Too Many Requests).&lt;/br&gt;&lt;/br&gt;This version is not subject to row limits and will return the entire result set of the stored search.&lt;/br&gt;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchRequest">Request object to specify search parameters.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsSearchesStoredSearchResults</returns>
        public ApiResponse< StoredSearchResults > SearchesGetSearchResultsAsStringByIdV2WithHttpInfo (StoredSearchRequest searchRequest, string lang = null, string locale = null)
        {
            // verify the required parameter 'searchRequest' is set
            if (searchRequest == null)
                throw new ApiException(400, "Missing required parameter 'searchRequest' when calling SearchesApi->SearchesGetSearchResultsAsStringByIdV2");

            var localVarPath = "/api/V2/storedsearches";
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

            if (lang != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter
            if (searchRequest != null && searchRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(searchRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = searchRequest; // byte array
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
                Exception exception = ExceptionFactory("SearchesGetSearchResultsAsStringByIdV2", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<StoredSearchResults>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StoredSearchResults) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StoredSearchResults)));
        }

        /// <summary>
        /// Get results of a saved search Operation that returns the results of a saved search in JSON format.&lt;/br&gt;&lt;/br&gt;This API is protected by a rate limiter and will reject any requests sent from an IP Address when a certain threshold of active concurrent requests has been hit.&lt;/br&gt;&lt;/br&gt;This value can be configured by the Max Concurrent Requests configuration value in the Web API config.&lt;/br&gt;&lt;/br&gt;Once this limit has been reached, all subsequent requests will receive a status code of 429 (Too Many Requests).&lt;/br&gt;&lt;/br&gt;This version is not subject to row limits and will return the entire result set of the stored search.&lt;/br&gt;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchRequest">Request object to specify search parameters.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsSearchesStoredSearchResults</returns>
        public async System.Threading.Tasks.Task<StoredSearchResults> SearchesGetSearchResultsAsStringByIdV2Async (StoredSearchRequest searchRequest, string lang = null, string locale = null)
        {
             ApiResponse<StoredSearchResults> localVarResponse = await SearchesGetSearchResultsAsStringByIdV2AsyncWithHttpInfo(searchRequest, lang, locale);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get results of a saved search Operation that returns the results of a saved search in JSON format.&lt;/br&gt;&lt;/br&gt;This API is protected by a rate limiter and will reject any requests sent from an IP Address when a certain threshold of active concurrent requests has been hit.&lt;/br&gt;&lt;/br&gt;This value can be configured by the Max Concurrent Requests configuration value in the Web API config.&lt;/br&gt;&lt;/br&gt;Once this limit has been reached, all subsequent requests will receive a status code of 429 (Too Many Requests).&lt;/br&gt;&lt;/br&gt;This version is not subject to row limits and will return the entire result set of the stored search.&lt;/br&gt;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchRequest">Request object to specify search parameters.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsSearchesStoredSearchResults)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<StoredSearchResults>> SearchesGetSearchResultsAsStringByIdV2AsyncWithHttpInfo (StoredSearchRequest searchRequest, string lang = null, string locale = null)
        {
            // verify the required parameter 'searchRequest' is set
            if (searchRequest == null)
                throw new ApiException(400, "Missing required parameter 'searchRequest' when calling SearchesApi->SearchesGetSearchResultsAsStringByIdV2");

            var localVarPath = "/api/V2/storedsearches";
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

            if (lang != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter
            if (searchRequest != null && searchRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(searchRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = searchRequest; // byte array
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
                Exception exception = ExceptionFactory("SearchesGetSearchResultsAsStringByIdV2", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<StoredSearchResults>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StoredSearchResults) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StoredSearchResults)));
        }

        /// <summary>
        /// Get results of a saved search Operation that returns the results of a saved search in JSON format.&lt;/br&gt; &lt;/br&gt;  This API is protected by a rate limiter and will reject any requests sent from an IP Address when a certain threshold of active concurrent requests has been hit.&lt;/br&gt; &lt;/br&gt;  This value can be configured by the Max Concurrent Requests configuration value in the Web API config.&lt;/br&gt; &lt;/br&gt;  Once this limit has been reached, all subsequent requests will receive a status code of 429 (Too Many Requests).&lt;/br&gt; 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Specify the scope name for the saved search.</param>
        /// <param name="associationName">Specify the Business Object association Name for the saved search.</param>
        /// <param name="searchName">Specify the name of the saved search.</param>
        /// <param name="scopeOwner">Specify the scope owner ID for the saved search. Use (None) when no scope owner exists. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>List&lt;Dictionary&lt;string, string&gt;&gt;</returns>
        public List<Dictionary<string, string>> SearchesGetSearchResultsAsStringByNameV1 (string scope, string associationName, string searchName, string scopeOwner = null, string lang = null, string locale = null)
        {
             ApiResponse<List<Dictionary<string, string>>> localVarResponse = SearchesGetSearchResultsAsStringByNameV1WithHttpInfo(scope, associationName, searchName, scopeOwner, lang, locale);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get results of a saved search Operation that returns the results of a saved search in JSON format.&lt;/br&gt; &lt;/br&gt;  This API is protected by a rate limiter and will reject any requests sent from an IP Address when a certain threshold of active concurrent requests has been hit.&lt;/br&gt; &lt;/br&gt;  This value can be configured by the Max Concurrent Requests configuration value in the Web API config.&lt;/br&gt; &lt;/br&gt;  Once this limit has been reached, all subsequent requests will receive a status code of 429 (Too Many Requests).&lt;/br&gt; 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Specify the scope name for the saved search.</param>
        /// <param name="associationName">Specify the Business Object association Name for the saved search.</param>
        /// <param name="searchName">Specify the name of the saved search.</param>
        /// <param name="scopeOwner">Specify the scope owner ID for the saved search. Use (None) when no scope owner exists. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of List&lt;Dictionary&lt;string, string&gt;&gt;</returns>
        public ApiResponse< List<Dictionary<string, string>> > SearchesGetSearchResultsAsStringByNameV1WithHttpInfo (string scope, string associationName, string searchName, string scopeOwner = null, string lang = null, string locale = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling SearchesApi->SearchesGetSearchResultsAsStringByNameV1");
            // verify the required parameter 'associationName' is set
            if (associationName == null)
                throw new ApiException(400, "Missing required parameter 'associationName' when calling SearchesApi->SearchesGetSearchResultsAsStringByNameV1");
            // verify the required parameter 'searchName' is set
            if (searchName == null)
                throw new ApiException(400, "Missing required parameter 'searchName' when calling SearchesApi->SearchesGetSearchResultsAsStringByNameV1");

            var localVarPath = "/api/V1/storedsearches/{scope}/{associationName}/{searchName}";
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

            if (scope != null) localVarPathParams.Add("scope", Configuration.ApiClient.ParameterToString(scope)); // path parameter
            if (associationName != null) localVarPathParams.Add("associationName", Configuration.ApiClient.ParameterToString(associationName)); // path parameter
            if (searchName != null) localVarPathParams.Add("searchName", Configuration.ApiClient.ParameterToString(searchName)); // path parameter
            if (scopeOwner != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "scopeOwner", scopeOwner)); // query parameter
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
                Exception exception = ExceptionFactory("SearchesGetSearchResultsAsStringByNameV1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Dictionary<string, string>>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Dictionary<string, string>>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Dictionary<string, string>>)));
        }

        /// <summary>
        /// Get results of a saved search Operation that returns the results of a saved search in JSON format.&lt;/br&gt; &lt;/br&gt;  This API is protected by a rate limiter and will reject any requests sent from an IP Address when a certain threshold of active concurrent requests has been hit.&lt;/br&gt; &lt;/br&gt;  This value can be configured by the Max Concurrent Requests configuration value in the Web API config.&lt;/br&gt; &lt;/br&gt;  Once this limit has been reached, all subsequent requests will receive a status code of 429 (Too Many Requests).&lt;/br&gt; 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Specify the scope name for the saved search.</param>
        /// <param name="associationName">Specify the Business Object association Name for the saved search.</param>
        /// <param name="searchName">Specify the name of the saved search.</param>
        /// <param name="scopeOwner">Specify the scope owner ID for the saved search. Use (None) when no scope owner exists. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of List&lt;Dictionary&lt;string, string&gt;&gt;</returns>
        public async System.Threading.Tasks.Task<List<Dictionary<string, string>>> SearchesGetSearchResultsAsStringByNameV1Async (string scope, string associationName, string searchName, string scopeOwner = null, string lang = null, string locale = null)
        {
             ApiResponse<List<Dictionary<string, string>>> localVarResponse = await SearchesGetSearchResultsAsStringByNameV1AsyncWithHttpInfo(scope, associationName, searchName, scopeOwner, lang, locale);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get results of a saved search Operation that returns the results of a saved search in JSON format.&lt;/br&gt; &lt;/br&gt;  This API is protected by a rate limiter and will reject any requests sent from an IP Address when a certain threshold of active concurrent requests has been hit.&lt;/br&gt; &lt;/br&gt;  This value can be configured by the Max Concurrent Requests configuration value in the Web API config.&lt;/br&gt; &lt;/br&gt;  Once this limit has been reached, all subsequent requests will receive a status code of 429 (Too Many Requests).&lt;/br&gt; 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Specify the scope name for the saved search.</param>
        /// <param name="associationName">Specify the Business Object association Name for the saved search.</param>
        /// <param name="searchName">Specify the name of the saved search.</param>
        /// <param name="scopeOwner">Specify the scope owner ID for the saved search. Use (None) when no scope owner exists. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;Dictionary&lt;string, string&gt;&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Dictionary<string, string>>>> SearchesGetSearchResultsAsStringByNameV1AsyncWithHttpInfo (string scope, string associationName, string searchName, string scopeOwner = null, string lang = null, string locale = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling SearchesApi->SearchesGetSearchResultsAsStringByNameV1");
            // verify the required parameter 'associationName' is set
            if (associationName == null)
                throw new ApiException(400, "Missing required parameter 'associationName' when calling SearchesApi->SearchesGetSearchResultsAsStringByNameV1");
            // verify the required parameter 'searchName' is set
            if (searchName == null)
                throw new ApiException(400, "Missing required parameter 'searchName' when calling SearchesApi->SearchesGetSearchResultsAsStringByNameV1");

            var localVarPath = "/api/V1/storedsearches/{scope}/{associationName}/{searchName}";
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

            if (scope != null) localVarPathParams.Add("scope", Configuration.ApiClient.ParameterToString(scope)); // path parameter
            if (associationName != null) localVarPathParams.Add("associationName", Configuration.ApiClient.ParameterToString(associationName)); // path parameter
            if (searchName != null) localVarPathParams.Add("searchName", Configuration.ApiClient.ParameterToString(searchName)); // path parameter
            if (scopeOwner != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "scopeOwner", scopeOwner)); // query parameter
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
                Exception exception = ExceptionFactory("SearchesGetSearchResultsAsStringByNameV1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Dictionary<string, string>>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Dictionary<string, string>>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Dictionary<string, string>>)));
        }

        /// <summary>
        /// Get results of a saved search Operation that returns the results of a saved search in JSON format.&lt;/br&gt;&lt;/br&gt;This API is protected by a rate limiter and will reject any requests sent from an IP Address when a certain threshold of active concurrent requests has been hit.&lt;/br&gt;&lt;/br&gt;This value can be configured by the Max Concurrent Requests configuration value in the Web API config.&lt;/br&gt;&lt;/br&gt;Once this limit has been reached, all subsequent requests will receive a status code of 429 (Too Many Requests).&lt;/br&gt;&lt;/br&gt;This version is not subject to row limits and will return the entire result set of the stored search.&lt;/br&gt;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Specify the scope name for the saved search.</param>
        /// <param name="associationName">Specify the Business Object association Name for the saved search.</param>
        /// <param name="searchName">Specify the name of the saved search.</param>
        /// <param name="scopeOwner">Specify the scope owner ID for the saved search. Use (None) when no scope owner exists. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>List&lt;Dictionary&lt;string, string&gt;&gt;</returns>
        public List<Dictionary<string, string>> SearchesGetSearchResultsAsStringByNameV2 (string scope, string associationName, string searchName, string scopeOwner = null, string lang = null, string locale = null)
        {
             ApiResponse<List<Dictionary<string, string>>> localVarResponse = SearchesGetSearchResultsAsStringByNameV2WithHttpInfo(scope, associationName, searchName, scopeOwner, lang, locale);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get results of a saved search Operation that returns the results of a saved search in JSON format.&lt;/br&gt;&lt;/br&gt;This API is protected by a rate limiter and will reject any requests sent from an IP Address when a certain threshold of active concurrent requests has been hit.&lt;/br&gt;&lt;/br&gt;This value can be configured by the Max Concurrent Requests configuration value in the Web API config.&lt;/br&gt;&lt;/br&gt;Once this limit has been reached, all subsequent requests will receive a status code of 429 (Too Many Requests).&lt;/br&gt;&lt;/br&gt;This version is not subject to row limits and will return the entire result set of the stored search.&lt;/br&gt;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Specify the scope name for the saved search.</param>
        /// <param name="associationName">Specify the Business Object association Name for the saved search.</param>
        /// <param name="searchName">Specify the name of the saved search.</param>
        /// <param name="scopeOwner">Specify the scope owner ID for the saved search. Use (None) when no scope owner exists. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of List&lt;Dictionary&lt;string, string&gt;&gt;</returns>
        public ApiResponse< List<Dictionary<string, string>> > SearchesGetSearchResultsAsStringByNameV2WithHttpInfo (string scope, string associationName, string searchName, string scopeOwner = null, string lang = null, string locale = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling SearchesApi->SearchesGetSearchResultsAsStringByNameV2");
            // verify the required parameter 'associationName' is set
            if (associationName == null)
                throw new ApiException(400, "Missing required parameter 'associationName' when calling SearchesApi->SearchesGetSearchResultsAsStringByNameV2");
            // verify the required parameter 'searchName' is set
            if (searchName == null)
                throw new ApiException(400, "Missing required parameter 'searchName' when calling SearchesApi->SearchesGetSearchResultsAsStringByNameV2");

            var localVarPath = "/api/V2/storedsearches/{scope}/{associationName}/{searchName}";
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

            if (scope != null) localVarPathParams.Add("scope", Configuration.ApiClient.ParameterToString(scope)); // path parameter
            if (associationName != null) localVarPathParams.Add("associationName", Configuration.ApiClient.ParameterToString(associationName)); // path parameter
            if (searchName != null) localVarPathParams.Add("searchName", Configuration.ApiClient.ParameterToString(searchName)); // path parameter
            if (scopeOwner != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "scopeOwner", scopeOwner)); // query parameter
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
                Exception exception = ExceptionFactory("SearchesGetSearchResultsAsStringByNameV2", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Dictionary<string, string>>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Dictionary<string, string>>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Dictionary<string, string>>)));
        }

        /// <summary>
        /// Get results of a saved search Operation that returns the results of a saved search in JSON format.&lt;/br&gt;&lt;/br&gt;This API is protected by a rate limiter and will reject any requests sent from an IP Address when a certain threshold of active concurrent requests has been hit.&lt;/br&gt;&lt;/br&gt;This value can be configured by the Max Concurrent Requests configuration value in the Web API config.&lt;/br&gt;&lt;/br&gt;Once this limit has been reached, all subsequent requests will receive a status code of 429 (Too Many Requests).&lt;/br&gt;&lt;/br&gt;This version is not subject to row limits and will return the entire result set of the stored search.&lt;/br&gt;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Specify the scope name for the saved search.</param>
        /// <param name="associationName">Specify the Business Object association Name for the saved search.</param>
        /// <param name="searchName">Specify the name of the saved search.</param>
        /// <param name="scopeOwner">Specify the scope owner ID for the saved search. Use (None) when no scope owner exists. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of List&lt;Dictionary&lt;string, string&gt;&gt;</returns>
        public async System.Threading.Tasks.Task<List<Dictionary<string, string>>> SearchesGetSearchResultsAsStringByNameV2Async (string scope, string associationName, string searchName, string scopeOwner = null, string lang = null, string locale = null)
        {
             ApiResponse<List<Dictionary<string, string>>> localVarResponse = await SearchesGetSearchResultsAsStringByNameV2AsyncWithHttpInfo(scope, associationName, searchName, scopeOwner, lang, locale);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get results of a saved search Operation that returns the results of a saved search in JSON format.&lt;/br&gt;&lt;/br&gt;This API is protected by a rate limiter and will reject any requests sent from an IP Address when a certain threshold of active concurrent requests has been hit.&lt;/br&gt;&lt;/br&gt;This value can be configured by the Max Concurrent Requests configuration value in the Web API config.&lt;/br&gt;&lt;/br&gt;Once this limit has been reached, all subsequent requests will receive a status code of 429 (Too Many Requests).&lt;/br&gt;&lt;/br&gt;This version is not subject to row limits and will return the entire result set of the stored search.&lt;/br&gt;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Specify the scope name for the saved search.</param>
        /// <param name="associationName">Specify the Business Object association Name for the saved search.</param>
        /// <param name="searchName">Specify the name of the saved search.</param>
        /// <param name="scopeOwner">Specify the scope owner ID for the saved search. Use (None) when no scope owner exists. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;Dictionary&lt;string, string&gt;&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Dictionary<string, string>>>> SearchesGetSearchResultsAsStringByNameV2AsyncWithHttpInfo (string scope, string associationName, string searchName, string scopeOwner = null, string lang = null, string locale = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling SearchesApi->SearchesGetSearchResultsAsStringByNameV2");
            // verify the required parameter 'associationName' is set
            if (associationName == null)
                throw new ApiException(400, "Missing required parameter 'associationName' when calling SearchesApi->SearchesGetSearchResultsAsStringByNameV2");
            // verify the required parameter 'searchName' is set
            if (searchName == null)
                throw new ApiException(400, "Missing required parameter 'searchName' when calling SearchesApi->SearchesGetSearchResultsAsStringByNameV2");

            var localVarPath = "/api/V2/storedsearches/{scope}/{associationName}/{searchName}";
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

            if (scope != null) localVarPathParams.Add("scope", Configuration.ApiClient.ParameterToString(scope)); // path parameter
            if (associationName != null) localVarPathParams.Add("associationName", Configuration.ApiClient.ParameterToString(associationName)); // path parameter
            if (searchName != null) localVarPathParams.Add("searchName", Configuration.ApiClient.ParameterToString(searchName)); // path parameter
            if (scopeOwner != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "scopeOwner", scopeOwner)); // query parameter
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
                Exception exception = ExceptionFactory("SearchesGetSearchResultsAsStringByNameV2", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Dictionary<string, string>>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Dictionary<string, string>>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Dictionary<string, string>>)));
        }

        /// <summary>
        /// Run a saved search by internal ID Operation that returns the paged results of a saved search. When the search contains Prompts, the response contains the Prompt. Send the Prompt and the original operation parameters to  SearchResultsRequest to the getsearchresults ad-hoc http post operation.&lt;/br&gt;&lt;/br&gt;PromptType is a FieldSubType enum as described below:&lt;/br&gt;FieldSubType&lt;/br&gt;None &#x3D; 0&lt;/br&gt;Text &#x3D; 1&lt;/br&gt;Number &#x3D; 2&lt;/br&gt;DateTime &#x3D; 3&lt;/br&gt;Logical &#x3D; 4&lt;/br&gt;Binary &#x3D; 5&lt;/br&gt;DateOnly &#x3D; 6&lt;/br&gt;TimeOnly &#x3D; 7&lt;/br&gt;Json &#x3D; 8&lt;/br&gt;JsonArray &#x3D; 9&lt;/br&gt;Xml &#x3D; 10&lt;/br&gt;XmlCollection &#x3D; 11&lt;/br&gt;TimeValue &#x3D; 12&lt;/br&gt;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Specify the Business Object association ID for the saved search.</param>
        /// <param name="scope">Specify the scope name or ID for the saved search.</param>
        /// <param name="scopeowner">Specify the scope owner ID for the saved search. Use (None) when no scope owner exists.</param>
        /// <param name="searchid">Specify the internal ID for the saved search. Use \&quot;Run a saved search by name\&quot; if you do not have the internal ID.</param>
        /// <param name="searchTerm">Specify search text filter the results. Example: Use \&quot;Service Request\&quot; to filter Incident results to include only service requests. (optional)</param>
        /// <param name="pagenumber">Specify the page number of the result set to return. (optional)</param>
        /// <param name="pagesize">Specify the number of rows to return per page. (optional)</param>
        /// <param name="includeschema">Use to include the table schema of the saved search. If false, results contain the fieldid and field value without field information. Default is false. (optional)</param>
        /// <param name="resultsAsSimpleResultsList">Indicates if the results should be returned in a simple results list format or a table format. Default is a table format. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsSearchesSearchResultsResponse</returns>
        public SearchResultsResponse SearchesGetSearchResultsByIdV1 (string association, string scope, string scopeowner, string searchid, string searchTerm = null, int? pagenumber = null, int? pagesize = null, bool? includeschema = null, bool? resultsAsSimpleResultsList = null, string lang = null, string locale = null)
        {
             ApiResponse<SearchResultsResponse> localVarResponse = SearchesGetSearchResultsByIdV1WithHttpInfo(association, scope, scopeowner, searchid, searchTerm, pagenumber, pagesize, includeschema, resultsAsSimpleResultsList, lang, locale);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Run a saved search by internal ID Operation that returns the paged results of a saved search. When the search contains Prompts, the response contains the Prompt. Send the Prompt and the original operation parameters to  SearchResultsRequest to the getsearchresults ad-hoc http post operation.&lt;/br&gt;&lt;/br&gt;PromptType is a FieldSubType enum as described below:&lt;/br&gt;FieldSubType&lt;/br&gt;None &#x3D; 0&lt;/br&gt;Text &#x3D; 1&lt;/br&gt;Number &#x3D; 2&lt;/br&gt;DateTime &#x3D; 3&lt;/br&gt;Logical &#x3D; 4&lt;/br&gt;Binary &#x3D; 5&lt;/br&gt;DateOnly &#x3D; 6&lt;/br&gt;TimeOnly &#x3D; 7&lt;/br&gt;Json &#x3D; 8&lt;/br&gt;JsonArray &#x3D; 9&lt;/br&gt;Xml &#x3D; 10&lt;/br&gt;XmlCollection &#x3D; 11&lt;/br&gt;TimeValue &#x3D; 12&lt;/br&gt;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Specify the Business Object association ID for the saved search.</param>
        /// <param name="scope">Specify the scope name or ID for the saved search.</param>
        /// <param name="scopeowner">Specify the scope owner ID for the saved search. Use (None) when no scope owner exists.</param>
        /// <param name="searchid">Specify the internal ID for the saved search. Use \&quot;Run a saved search by name\&quot; if you do not have the internal ID.</param>
        /// <param name="searchTerm">Specify search text filter the results. Example: Use \&quot;Service Request\&quot; to filter Incident results to include only service requests. (optional)</param>
        /// <param name="pagenumber">Specify the page number of the result set to return. (optional)</param>
        /// <param name="pagesize">Specify the number of rows to return per page. (optional)</param>
        /// <param name="includeschema">Use to include the table schema of the saved search. If false, results contain the fieldid and field value without field information. Default is false. (optional)</param>
        /// <param name="resultsAsSimpleResultsList">Indicates if the results should be returned in a simple results list format or a table format. Default is a table format. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsSearchesSearchResultsResponse</returns>
        public ApiResponse< SearchResultsResponse > SearchesGetSearchResultsByIdV1WithHttpInfo (string association, string scope, string scopeowner, string searchid, string searchTerm = null, int? pagenumber = null, int? pagesize = null, bool? includeschema = null, bool? resultsAsSimpleResultsList = null, string lang = null, string locale = null)
        {
            // verify the required parameter 'association' is set
            if (association == null)
                throw new ApiException(400, "Missing required parameter 'association' when calling SearchesApi->SearchesGetSearchResultsByIdV1");
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling SearchesApi->SearchesGetSearchResultsByIdV1");
            // verify the required parameter 'scopeowner' is set
            if (scopeowner == null)
                throw new ApiException(400, "Missing required parameter 'scopeowner' when calling SearchesApi->SearchesGetSearchResultsByIdV1");
            // verify the required parameter 'searchid' is set
            if (searchid == null)
                throw new ApiException(400, "Missing required parameter 'searchid' when calling SearchesApi->SearchesGetSearchResultsByIdV1");

            var localVarPath = "/api/V1/getsearchresults/association/{association}/scope/{scope}/scopeowner/{scopeowner}/searchid/{searchid}";
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

            if (association != null) localVarPathParams.Add("association", Configuration.ApiClient.ParameterToString(association)); // path parameter
            if (scope != null) localVarPathParams.Add("scope", Configuration.ApiClient.ParameterToString(scope)); // path parameter
            if (scopeowner != null) localVarPathParams.Add("scopeowner", Configuration.ApiClient.ParameterToString(scopeowner)); // path parameter
            if (searchid != null) localVarPathParams.Add("searchid", Configuration.ApiClient.ParameterToString(searchid)); // path parameter
            if (searchTerm != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "searchTerm", searchTerm)); // query parameter
            if (pagenumber != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "pagenumber", pagenumber)); // query parameter
            if (pagesize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "pagesize", pagesize)); // query parameter
            if (includeschema != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "includeschema", includeschema)); // query parameter
            if (resultsAsSimpleResultsList != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "resultsAsSimpleResultsList", resultsAsSimpleResultsList)); // query parameter
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
                Exception exception = ExceptionFactory("SearchesGetSearchResultsByIdV1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SearchResultsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SearchResultsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SearchResultsResponse)));
        }

        /// <summary>
        /// Run a saved search by internal ID Operation that returns the paged results of a saved search. When the search contains Prompts, the response contains the Prompt. Send the Prompt and the original operation parameters to  SearchResultsRequest to the getsearchresults ad-hoc http post operation.&lt;/br&gt;&lt;/br&gt;PromptType is a FieldSubType enum as described below:&lt;/br&gt;FieldSubType&lt;/br&gt;None &#x3D; 0&lt;/br&gt;Text &#x3D; 1&lt;/br&gt;Number &#x3D; 2&lt;/br&gt;DateTime &#x3D; 3&lt;/br&gt;Logical &#x3D; 4&lt;/br&gt;Binary &#x3D; 5&lt;/br&gt;DateOnly &#x3D; 6&lt;/br&gt;TimeOnly &#x3D; 7&lt;/br&gt;Json &#x3D; 8&lt;/br&gt;JsonArray &#x3D; 9&lt;/br&gt;Xml &#x3D; 10&lt;/br&gt;XmlCollection &#x3D; 11&lt;/br&gt;TimeValue &#x3D; 12&lt;/br&gt;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Specify the Business Object association ID for the saved search.</param>
        /// <param name="scope">Specify the scope name or ID for the saved search.</param>
        /// <param name="scopeowner">Specify the scope owner ID for the saved search. Use (None) when no scope owner exists.</param>
        /// <param name="searchid">Specify the internal ID for the saved search. Use \&quot;Run a saved search by name\&quot; if you do not have the internal ID.</param>
        /// <param name="searchTerm">Specify search text filter the results. Example: Use \&quot;Service Request\&quot; to filter Incident results to include only service requests. (optional)</param>
        /// <param name="pagenumber">Specify the page number of the result set to return. (optional)</param>
        /// <param name="pagesize">Specify the number of rows to return per page. (optional)</param>
        /// <param name="includeschema">Use to include the table schema of the saved search. If false, results contain the fieldid and field value without field information. Default is false. (optional)</param>
        /// <param name="resultsAsSimpleResultsList">Indicates if the results should be returned in a simple results list format or a table format. Default is a table format. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsSearchesSearchResultsResponse</returns>
        public async System.Threading.Tasks.Task<SearchResultsResponse> SearchesGetSearchResultsByIdV1Async (string association, string scope, string scopeowner, string searchid, string searchTerm = null, int? pagenumber = null, int? pagesize = null, bool? includeschema = null, bool? resultsAsSimpleResultsList = null, string lang = null, string locale = null)
        {
             ApiResponse<SearchResultsResponse> localVarResponse = await SearchesGetSearchResultsByIdV1AsyncWithHttpInfo(association, scope, scopeowner, searchid, searchTerm, pagenumber, pagesize, includeschema, resultsAsSimpleResultsList, lang, locale);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Run a saved search by internal ID Operation that returns the paged results of a saved search. When the search contains Prompts, the response contains the Prompt. Send the Prompt and the original operation parameters to  SearchResultsRequest to the getsearchresults ad-hoc http post operation.&lt;/br&gt;&lt;/br&gt;PromptType is a FieldSubType enum as described below:&lt;/br&gt;FieldSubType&lt;/br&gt;None &#x3D; 0&lt;/br&gt;Text &#x3D; 1&lt;/br&gt;Number &#x3D; 2&lt;/br&gt;DateTime &#x3D; 3&lt;/br&gt;Logical &#x3D; 4&lt;/br&gt;Binary &#x3D; 5&lt;/br&gt;DateOnly &#x3D; 6&lt;/br&gt;TimeOnly &#x3D; 7&lt;/br&gt;Json &#x3D; 8&lt;/br&gt;JsonArray &#x3D; 9&lt;/br&gt;Xml &#x3D; 10&lt;/br&gt;XmlCollection &#x3D; 11&lt;/br&gt;TimeValue &#x3D; 12&lt;/br&gt;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Specify the Business Object association ID for the saved search.</param>
        /// <param name="scope">Specify the scope name or ID for the saved search.</param>
        /// <param name="scopeowner">Specify the scope owner ID for the saved search. Use (None) when no scope owner exists.</param>
        /// <param name="searchid">Specify the internal ID for the saved search. Use \&quot;Run a saved search by name\&quot; if you do not have the internal ID.</param>
        /// <param name="searchTerm">Specify search text filter the results. Example: Use \&quot;Service Request\&quot; to filter Incident results to include only service requests. (optional)</param>
        /// <param name="pagenumber">Specify the page number of the result set to return. (optional)</param>
        /// <param name="pagesize">Specify the number of rows to return per page. (optional)</param>
        /// <param name="includeschema">Use to include the table schema of the saved search. If false, results contain the fieldid and field value without field information. Default is false. (optional)</param>
        /// <param name="resultsAsSimpleResultsList">Indicates if the results should be returned in a simple results list format or a table format. Default is a table format. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsSearchesSearchResultsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SearchResultsResponse>> SearchesGetSearchResultsByIdV1AsyncWithHttpInfo (string association, string scope, string scopeowner, string searchid, string searchTerm = null, int? pagenumber = null, int? pagesize = null, bool? includeschema = null, bool? resultsAsSimpleResultsList = null, string lang = null, string locale = null)
        {
            // verify the required parameter 'association' is set
            if (association == null)
                throw new ApiException(400, "Missing required parameter 'association' when calling SearchesApi->SearchesGetSearchResultsByIdV1");
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling SearchesApi->SearchesGetSearchResultsByIdV1");
            // verify the required parameter 'scopeowner' is set
            if (scopeowner == null)
                throw new ApiException(400, "Missing required parameter 'scopeowner' when calling SearchesApi->SearchesGetSearchResultsByIdV1");
            // verify the required parameter 'searchid' is set
            if (searchid == null)
                throw new ApiException(400, "Missing required parameter 'searchid' when calling SearchesApi->SearchesGetSearchResultsByIdV1");

            var localVarPath = "/api/V1/getsearchresults/association/{association}/scope/{scope}/scopeowner/{scopeowner}/searchid/{searchid}";
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

            if (association != null) localVarPathParams.Add("association", Configuration.ApiClient.ParameterToString(association)); // path parameter
            if (scope != null) localVarPathParams.Add("scope", Configuration.ApiClient.ParameterToString(scope)); // path parameter
            if (scopeowner != null) localVarPathParams.Add("scopeowner", Configuration.ApiClient.ParameterToString(scopeowner)); // path parameter
            if (searchid != null) localVarPathParams.Add("searchid", Configuration.ApiClient.ParameterToString(searchid)); // path parameter
            if (searchTerm != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "searchTerm", searchTerm)); // query parameter
            if (pagenumber != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "pagenumber", pagenumber)); // query parameter
            if (pagesize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "pagesize", pagesize)); // query parameter
            if (includeschema != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "includeschema", includeschema)); // query parameter
            if (resultsAsSimpleResultsList != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "resultsAsSimpleResultsList", resultsAsSimpleResultsList)); // query parameter
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
                Exception exception = ExceptionFactory("SearchesGetSearchResultsByIdV1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SearchResultsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SearchResultsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SearchResultsResponse)));
        }

        /// <summary>
        /// Run a saved search by name Operation that returns the paged results of a saved search. When the search contains Prompts, the response contains the Prompt. Send the Prompt and the original operation parameters to  SearchResultsRequest to the getsearchresults ad-hoc http post operation.&lt;/br&gt;&lt;/br&gt;PromptType is a FieldSubType enum as described below:&lt;/br&gt;FieldSubType&lt;/br&gt;None &#x3D; 0&lt;/br&gt;Text &#x3D; 1&lt;/br&gt;Number &#x3D; 2&lt;/br&gt;DateTime &#x3D; 3&lt;/br&gt;Logical &#x3D; 4&lt;/br&gt;Binary &#x3D; 5&lt;/br&gt;DateOnly &#x3D; 6&lt;/br&gt;TimeOnly &#x3D; 7&lt;/br&gt;Json &#x3D; 8&lt;/br&gt;JsonArray &#x3D; 9&lt;/br&gt;Xml &#x3D; 10&lt;/br&gt;XmlCollection &#x3D; 11&lt;/br&gt;TimeValue &#x3D; 12&lt;/br&gt;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Specify the Business Object association ID for the saved search.</param>
        /// <param name="scope">Specify the scope name or ID for the saved search.</param>
        /// <param name="scopeowner">Specify the scope owner ID for the saved search. Use (None) when no scope owner exists.</param>
        /// <param name="searchname">Specify the name of the saved search.</param>
        /// <param name="searchTerm">Specify search text filter the results. Example: Use \&quot;Service Request\&quot; to filter Incident results to include only service requests. (optional)</param>
        /// <param name="pagenumber">Specify the page number of the result set to return. (optional)</param>
        /// <param name="pagesize">Specify the number of rows to return per page. (optional)</param>
        /// <param name="includeschema">Use to include the table schema of the saved search. If false, results contain the fieldid and field value without field information. Default is false. (optional)</param>
        /// <param name="resultsAsSimpleResultsList">Indicates if the results should be returned in a simple results list format or a table format. Default is a table format. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsSearchesSearchResultsResponse</returns>
        public SearchResultsResponse SearchesGetSearchResultsByNameV1 (string association, string scope, string scopeowner, string searchname, string searchTerm = null, int? pagenumber = null, int? pagesize = null, bool? includeschema = null, bool? resultsAsSimpleResultsList = null, string lang = null, string locale = null)
        {
             ApiResponse<SearchResultsResponse> localVarResponse = SearchesGetSearchResultsByNameV1WithHttpInfo(association, scope, scopeowner, searchname, searchTerm, pagenumber, pagesize, includeschema, resultsAsSimpleResultsList, lang, locale);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Run a saved search by name Operation that returns the paged results of a saved search. When the search contains Prompts, the response contains the Prompt. Send the Prompt and the original operation parameters to  SearchResultsRequest to the getsearchresults ad-hoc http post operation.&lt;/br&gt;&lt;/br&gt;PromptType is a FieldSubType enum as described below:&lt;/br&gt;FieldSubType&lt;/br&gt;None &#x3D; 0&lt;/br&gt;Text &#x3D; 1&lt;/br&gt;Number &#x3D; 2&lt;/br&gt;DateTime &#x3D; 3&lt;/br&gt;Logical &#x3D; 4&lt;/br&gt;Binary &#x3D; 5&lt;/br&gt;DateOnly &#x3D; 6&lt;/br&gt;TimeOnly &#x3D; 7&lt;/br&gt;Json &#x3D; 8&lt;/br&gt;JsonArray &#x3D; 9&lt;/br&gt;Xml &#x3D; 10&lt;/br&gt;XmlCollection &#x3D; 11&lt;/br&gt;TimeValue &#x3D; 12&lt;/br&gt;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Specify the Business Object association ID for the saved search.</param>
        /// <param name="scope">Specify the scope name or ID for the saved search.</param>
        /// <param name="scopeowner">Specify the scope owner ID for the saved search. Use (None) when no scope owner exists.</param>
        /// <param name="searchname">Specify the name of the saved search.</param>
        /// <param name="searchTerm">Specify search text filter the results. Example: Use \&quot;Service Request\&quot; to filter Incident results to include only service requests. (optional)</param>
        /// <param name="pagenumber">Specify the page number of the result set to return. (optional)</param>
        /// <param name="pagesize">Specify the number of rows to return per page. (optional)</param>
        /// <param name="includeschema">Use to include the table schema of the saved search. If false, results contain the fieldid and field value without field information. Default is false. (optional)</param>
        /// <param name="resultsAsSimpleResultsList">Indicates if the results should be returned in a simple results list format or a table format. Default is a table format. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsSearchesSearchResultsResponse</returns>
        public ApiResponse< SearchResultsResponse > SearchesGetSearchResultsByNameV1WithHttpInfo (string association, string scope, string scopeowner, string searchname, string searchTerm = null, int? pagenumber = null, int? pagesize = null, bool? includeschema = null, bool? resultsAsSimpleResultsList = null, string lang = null, string locale = null)
        {
            // verify the required parameter 'association' is set
            if (association == null)
                throw new ApiException(400, "Missing required parameter 'association' when calling SearchesApi->SearchesGetSearchResultsByNameV1");
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling SearchesApi->SearchesGetSearchResultsByNameV1");
            // verify the required parameter 'scopeowner' is set
            if (scopeowner == null)
                throw new ApiException(400, "Missing required parameter 'scopeowner' when calling SearchesApi->SearchesGetSearchResultsByNameV1");
            // verify the required parameter 'searchname' is set
            if (searchname == null)
                throw new ApiException(400, "Missing required parameter 'searchname' when calling SearchesApi->SearchesGetSearchResultsByNameV1");

            var localVarPath = "/api/V1/getsearchresults/association/{association}/scope/{scope}/scopeowner/{scopeowner}/searchname/{searchname}";
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

            if (association != null) localVarPathParams.Add("association", Configuration.ApiClient.ParameterToString(association)); // path parameter
            if (scope != null) localVarPathParams.Add("scope", Configuration.ApiClient.ParameterToString(scope)); // path parameter
            if (scopeowner != null) localVarPathParams.Add("scopeowner", Configuration.ApiClient.ParameterToString(scopeowner)); // path parameter
            if (searchname != null) localVarPathParams.Add("searchname", Configuration.ApiClient.ParameterToString(searchname)); // path parameter
            if (searchTerm != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "searchTerm", searchTerm)); // query parameter
            if (pagenumber != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "pagenumber", pagenumber)); // query parameter
            if (pagesize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "pagesize", pagesize)); // query parameter
            if (includeschema != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "includeschema", includeschema)); // query parameter
            if (resultsAsSimpleResultsList != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "resultsAsSimpleResultsList", resultsAsSimpleResultsList)); // query parameter
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
                Exception exception = ExceptionFactory("SearchesGetSearchResultsByNameV1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SearchResultsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SearchResultsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SearchResultsResponse)));
        }

        /// <summary>
        /// Run a saved search by name Operation that returns the paged results of a saved search. When the search contains Prompts, the response contains the Prompt. Send the Prompt and the original operation parameters to  SearchResultsRequest to the getsearchresults ad-hoc http post operation.&lt;/br&gt;&lt;/br&gt;PromptType is a FieldSubType enum as described below:&lt;/br&gt;FieldSubType&lt;/br&gt;None &#x3D; 0&lt;/br&gt;Text &#x3D; 1&lt;/br&gt;Number &#x3D; 2&lt;/br&gt;DateTime &#x3D; 3&lt;/br&gt;Logical &#x3D; 4&lt;/br&gt;Binary &#x3D; 5&lt;/br&gt;DateOnly &#x3D; 6&lt;/br&gt;TimeOnly &#x3D; 7&lt;/br&gt;Json &#x3D; 8&lt;/br&gt;JsonArray &#x3D; 9&lt;/br&gt;Xml &#x3D; 10&lt;/br&gt;XmlCollection &#x3D; 11&lt;/br&gt;TimeValue &#x3D; 12&lt;/br&gt;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Specify the Business Object association ID for the saved search.</param>
        /// <param name="scope">Specify the scope name or ID for the saved search.</param>
        /// <param name="scopeowner">Specify the scope owner ID for the saved search. Use (None) when no scope owner exists.</param>
        /// <param name="searchname">Specify the name of the saved search.</param>
        /// <param name="searchTerm">Specify search text filter the results. Example: Use \&quot;Service Request\&quot; to filter Incident results to include only service requests. (optional)</param>
        /// <param name="pagenumber">Specify the page number of the result set to return. (optional)</param>
        /// <param name="pagesize">Specify the number of rows to return per page. (optional)</param>
        /// <param name="includeschema">Use to include the table schema of the saved search. If false, results contain the fieldid and field value without field information. Default is false. (optional)</param>
        /// <param name="resultsAsSimpleResultsList">Indicates if the results should be returned in a simple results list format or a table format. Default is a table format. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsSearchesSearchResultsResponse</returns>
        public async System.Threading.Tasks.Task<SearchResultsResponse> SearchesGetSearchResultsByNameV1Async (string association, string scope, string scopeowner, string searchname, string searchTerm = null, int? pagenumber = null, int? pagesize = null, bool? includeschema = null, bool? resultsAsSimpleResultsList = null, string lang = null, string locale = null)
        {
             ApiResponse<SearchResultsResponse> localVarResponse = await SearchesGetSearchResultsByNameV1AsyncWithHttpInfo(association, scope, scopeowner, searchname, searchTerm, pagenumber, pagesize, includeschema, resultsAsSimpleResultsList, lang, locale);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Run a saved search by name Operation that returns the paged results of a saved search. When the search contains Prompts, the response contains the Prompt. Send the Prompt and the original operation parameters to  SearchResultsRequest to the getsearchresults ad-hoc http post operation.&lt;/br&gt;&lt;/br&gt;PromptType is a FieldSubType enum as described below:&lt;/br&gt;FieldSubType&lt;/br&gt;None &#x3D; 0&lt;/br&gt;Text &#x3D; 1&lt;/br&gt;Number &#x3D; 2&lt;/br&gt;DateTime &#x3D; 3&lt;/br&gt;Logical &#x3D; 4&lt;/br&gt;Binary &#x3D; 5&lt;/br&gt;DateOnly &#x3D; 6&lt;/br&gt;TimeOnly &#x3D; 7&lt;/br&gt;Json &#x3D; 8&lt;/br&gt;JsonArray &#x3D; 9&lt;/br&gt;Xml &#x3D; 10&lt;/br&gt;XmlCollection &#x3D; 11&lt;/br&gt;TimeValue &#x3D; 12&lt;/br&gt;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Specify the Business Object association ID for the saved search.</param>
        /// <param name="scope">Specify the scope name or ID for the saved search.</param>
        /// <param name="scopeowner">Specify the scope owner ID for the saved search. Use (None) when no scope owner exists.</param>
        /// <param name="searchname">Specify the name of the saved search.</param>
        /// <param name="searchTerm">Specify search text filter the results. Example: Use \&quot;Service Request\&quot; to filter Incident results to include only service requests. (optional)</param>
        /// <param name="pagenumber">Specify the page number of the result set to return. (optional)</param>
        /// <param name="pagesize">Specify the number of rows to return per page. (optional)</param>
        /// <param name="includeschema">Use to include the table schema of the saved search. If false, results contain the fieldid and field value without field information. Default is false. (optional)</param>
        /// <param name="resultsAsSimpleResultsList">Indicates if the results should be returned in a simple results list format or a table format. Default is a table format. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsSearchesSearchResultsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SearchResultsResponse>> SearchesGetSearchResultsByNameV1AsyncWithHttpInfo (string association, string scope, string scopeowner, string searchname, string searchTerm = null, int? pagenumber = null, int? pagesize = null, bool? includeschema = null, bool? resultsAsSimpleResultsList = null, string lang = null, string locale = null)
        {
            // verify the required parameter 'association' is set
            if (association == null)
                throw new ApiException(400, "Missing required parameter 'association' when calling SearchesApi->SearchesGetSearchResultsByNameV1");
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling SearchesApi->SearchesGetSearchResultsByNameV1");
            // verify the required parameter 'scopeowner' is set
            if (scopeowner == null)
                throw new ApiException(400, "Missing required parameter 'scopeowner' when calling SearchesApi->SearchesGetSearchResultsByNameV1");
            // verify the required parameter 'searchname' is set
            if (searchname == null)
                throw new ApiException(400, "Missing required parameter 'searchname' when calling SearchesApi->SearchesGetSearchResultsByNameV1");

            var localVarPath = "/api/V1/getsearchresults/association/{association}/scope/{scope}/scopeowner/{scopeowner}/searchname/{searchname}";
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

            if (association != null) localVarPathParams.Add("association", Configuration.ApiClient.ParameterToString(association)); // path parameter
            if (scope != null) localVarPathParams.Add("scope", Configuration.ApiClient.ParameterToString(scope)); // path parameter
            if (scopeowner != null) localVarPathParams.Add("scopeowner", Configuration.ApiClient.ParameterToString(scopeowner)); // path parameter
            if (searchname != null) localVarPathParams.Add("searchname", Configuration.ApiClient.ParameterToString(searchname)); // path parameter
            if (searchTerm != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "searchTerm", searchTerm)); // query parameter
            if (pagenumber != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "pagenumber", pagenumber)); // query parameter
            if (pagesize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "pagesize", pagesize)); // query parameter
            if (includeschema != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "includeschema", includeschema)); // query parameter
            if (resultsAsSimpleResultsList != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "resultsAsSimpleResultsList", resultsAsSimpleResultsList)); // query parameter
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
                Exception exception = ExceptionFactory("SearchesGetSearchResultsByNameV1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SearchResultsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SearchResultsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SearchResultsResponse)));
        }

        /// <summary>
        /// Export an ad-hoc search Operation that returns an ad-hoc search in a specified export format: 0&#x3D;CSV, 1&#x3D;Excel, 2&#x3D;Tab, 3&#x3D;Word, 4&#x3D;Custom Separator, 5&#x3D;Simple JSON. To execute a search with Prompts, the PromptId and Value are required in the Prompt request object.&lt;/br&gt;&lt;/br&gt;PromptType is a FieldSubType enum as described below:&lt;/br&gt;FieldSubType&lt;/br&gt;None &#x3D; 0&lt;/br&gt;Text &#x3D; 1&lt;/br&gt;Number &#x3D; 2&lt;/br&gt;DateTime &#x3D; 3&lt;/br&gt;Logical &#x3D; 4&lt;/br&gt;Binary &#x3D; 5&lt;/br&gt;DateOnly &#x3D; 6&lt;/br&gt;TimeOnly &#x3D; 7&lt;/br&gt;Json &#x3D; 8&lt;/br&gt;JsonArray &#x3D; 9&lt;/br&gt;Xml &#x3D; 10&lt;/br&gt;XmlCollection &#x3D; 11&lt;/br&gt;TimeValue &#x3D; 12&lt;/br&gt;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataRequest">Request object to specify search parameters and export format.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>string</returns>
        public string SearchesGetSearchResultsExportAdHocV1 (ExportSearchResultsRequest dataRequest, string lang = null, string locale = null)
        {
             ApiResponse<string> localVarResponse = SearchesGetSearchResultsExportAdHocV1WithHttpInfo(dataRequest, lang, locale);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Export an ad-hoc search Operation that returns an ad-hoc search in a specified export format: 0&#x3D;CSV, 1&#x3D;Excel, 2&#x3D;Tab, 3&#x3D;Word, 4&#x3D;Custom Separator, 5&#x3D;Simple JSON. To execute a search with Prompts, the PromptId and Value are required in the Prompt request object.&lt;/br&gt;&lt;/br&gt;PromptType is a FieldSubType enum as described below:&lt;/br&gt;FieldSubType&lt;/br&gt;None &#x3D; 0&lt;/br&gt;Text &#x3D; 1&lt;/br&gt;Number &#x3D; 2&lt;/br&gt;DateTime &#x3D; 3&lt;/br&gt;Logical &#x3D; 4&lt;/br&gt;Binary &#x3D; 5&lt;/br&gt;DateOnly &#x3D; 6&lt;/br&gt;TimeOnly &#x3D; 7&lt;/br&gt;Json &#x3D; 8&lt;/br&gt;JsonArray &#x3D; 9&lt;/br&gt;Xml &#x3D; 10&lt;/br&gt;XmlCollection &#x3D; 11&lt;/br&gt;TimeValue &#x3D; 12&lt;/br&gt;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataRequest">Request object to specify search parameters and export format.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > SearchesGetSearchResultsExportAdHocV1WithHttpInfo (ExportSearchResultsRequest dataRequest, string lang = null, string locale = null)
        {
            // verify the required parameter 'dataRequest' is set
            if (dataRequest == null)
                throw new ApiException(400, "Missing required parameter 'dataRequest' when calling SearchesApi->SearchesGetSearchResultsExportAdHocV1");

            var localVarPath = "/api/V1/getsearchresultsexport";
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

            if (lang != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter
            if (dataRequest != null && dataRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(dataRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = dataRequest; // byte array
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
                Exception exception = ExceptionFactory("SearchesGetSearchResultsExportAdHocV1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

        /// <summary>
        /// Export an ad-hoc search Operation that returns an ad-hoc search in a specified export format: 0&#x3D;CSV, 1&#x3D;Excel, 2&#x3D;Tab, 3&#x3D;Word, 4&#x3D;Custom Separator, 5&#x3D;Simple JSON. To execute a search with Prompts, the PromptId and Value are required in the Prompt request object.&lt;/br&gt;&lt;/br&gt;PromptType is a FieldSubType enum as described below:&lt;/br&gt;FieldSubType&lt;/br&gt;None &#x3D; 0&lt;/br&gt;Text &#x3D; 1&lt;/br&gt;Number &#x3D; 2&lt;/br&gt;DateTime &#x3D; 3&lt;/br&gt;Logical &#x3D; 4&lt;/br&gt;Binary &#x3D; 5&lt;/br&gt;DateOnly &#x3D; 6&lt;/br&gt;TimeOnly &#x3D; 7&lt;/br&gt;Json &#x3D; 8&lt;/br&gt;JsonArray &#x3D; 9&lt;/br&gt;Xml &#x3D; 10&lt;/br&gt;XmlCollection &#x3D; 11&lt;/br&gt;TimeValue &#x3D; 12&lt;/br&gt;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataRequest">Request object to specify search parameters and export format.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> SearchesGetSearchResultsExportAdHocV1Async (ExportSearchResultsRequest dataRequest, string lang = null, string locale = null)
        {
             ApiResponse<string> localVarResponse = await SearchesGetSearchResultsExportAdHocV1AsyncWithHttpInfo(dataRequest, lang, locale);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Export an ad-hoc search Operation that returns an ad-hoc search in a specified export format: 0&#x3D;CSV, 1&#x3D;Excel, 2&#x3D;Tab, 3&#x3D;Word, 4&#x3D;Custom Separator, 5&#x3D;Simple JSON. To execute a search with Prompts, the PromptId and Value are required in the Prompt request object.&lt;/br&gt;&lt;/br&gt;PromptType is a FieldSubType enum as described below:&lt;/br&gt;FieldSubType&lt;/br&gt;None &#x3D; 0&lt;/br&gt;Text &#x3D; 1&lt;/br&gt;Number &#x3D; 2&lt;/br&gt;DateTime &#x3D; 3&lt;/br&gt;Logical &#x3D; 4&lt;/br&gt;Binary &#x3D; 5&lt;/br&gt;DateOnly &#x3D; 6&lt;/br&gt;TimeOnly &#x3D; 7&lt;/br&gt;Json &#x3D; 8&lt;/br&gt;JsonArray &#x3D; 9&lt;/br&gt;Xml &#x3D; 10&lt;/br&gt;XmlCollection &#x3D; 11&lt;/br&gt;TimeValue &#x3D; 12&lt;/br&gt;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataRequest">Request object to specify search parameters and export format.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> SearchesGetSearchResultsExportAdHocV1AsyncWithHttpInfo (ExportSearchResultsRequest dataRequest, string lang = null, string locale = null)
        {
            // verify the required parameter 'dataRequest' is set
            if (dataRequest == null)
                throw new ApiException(400, "Missing required parameter 'dataRequest' when calling SearchesApi->SearchesGetSearchResultsExportAdHocV1");

            var localVarPath = "/api/V1/getsearchresultsexport";
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

            if (lang != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter
            if (dataRequest != null && dataRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(dataRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = dataRequest; // byte array
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
                Exception exception = ExceptionFactory("SearchesGetSearchResultsExportAdHocV1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

        /// <summary>
        /// Export a saved search by ID Operation that returns the paged results of a saved search in a specified format. When the search contains Prompts, the response contains the Prompt. Send the Prompt and the original operation parameters to  SearchResultsRequest to the getsearchresultsexport ad-hoc http post operation.&lt;/br&gt;&lt;/br&gt;PromptType is a FieldSubType enum as described below:&lt;/br&gt;FieldSubType&lt;/br&gt;None &#x3D; 0&lt;/br&gt;Text &#x3D; 1&lt;/br&gt;Number &#x3D; 2&lt;/br&gt;DateTime &#x3D; 3&lt;/br&gt;Logical &#x3D; 4&lt;/br&gt;Binary &#x3D; 5&lt;/br&gt;DateOnly &#x3D; 6&lt;/br&gt;TimeOnly &#x3D; 7&lt;/br&gt;Json &#x3D; 8&lt;/br&gt;JsonArray &#x3D; 9&lt;/br&gt;Xml &#x3D; 10&lt;/br&gt;XmlCollection &#x3D; 11&lt;/br&gt;TimeValue &#x3D; 12&lt;/br&gt;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Specify the Business Object association ID for the saved search.</param>
        /// <param name="scope">Specify the scope name or ID for the saved search.</param>
        /// <param name="scopeowner">Specify the scope owner ID for the saved search. Use (None) when no scope owner exists.</param>
        /// <param name="searchid">Specify the internal ID for the saved search. Use \&quot;Run a saved search by name\&quot; if you do not have the internal ID.</param>
        /// <param name="exportformat">Specify the format of the export</param>
        /// <param name="searchTerm">Specify search text filter the results. Example: Use \&quot;Service Request\&quot; to filter Incident results to include only service requests. (optional)</param>
        /// <param name="pagenumber">Specify the page number of the result set to return. (optional)</param>
        /// <param name="pagesize">Specify the number of rows to return per page. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>string</returns>
        public string SearchesGetSearchResultsExportByIdV1 (string association, string scope, string scopeowner, string searchid, string exportformat, string searchTerm = null, int? pagenumber = null, int? pagesize = null, string lang = null, string locale = null)
        {
             ApiResponse<string> localVarResponse = SearchesGetSearchResultsExportByIdV1WithHttpInfo(association, scope, scopeowner, searchid, exportformat, searchTerm, pagenumber, pagesize, lang, locale);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Export a saved search by ID Operation that returns the paged results of a saved search in a specified format. When the search contains Prompts, the response contains the Prompt. Send the Prompt and the original operation parameters to  SearchResultsRequest to the getsearchresultsexport ad-hoc http post operation.&lt;/br&gt;&lt;/br&gt;PromptType is a FieldSubType enum as described below:&lt;/br&gt;FieldSubType&lt;/br&gt;None &#x3D; 0&lt;/br&gt;Text &#x3D; 1&lt;/br&gt;Number &#x3D; 2&lt;/br&gt;DateTime &#x3D; 3&lt;/br&gt;Logical &#x3D; 4&lt;/br&gt;Binary &#x3D; 5&lt;/br&gt;DateOnly &#x3D; 6&lt;/br&gt;TimeOnly &#x3D; 7&lt;/br&gt;Json &#x3D; 8&lt;/br&gt;JsonArray &#x3D; 9&lt;/br&gt;Xml &#x3D; 10&lt;/br&gt;XmlCollection &#x3D; 11&lt;/br&gt;TimeValue &#x3D; 12&lt;/br&gt;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Specify the Business Object association ID for the saved search.</param>
        /// <param name="scope">Specify the scope name or ID for the saved search.</param>
        /// <param name="scopeowner">Specify the scope owner ID for the saved search. Use (None) when no scope owner exists.</param>
        /// <param name="searchid">Specify the internal ID for the saved search. Use \&quot;Run a saved search by name\&quot; if you do not have the internal ID.</param>
        /// <param name="exportformat">Specify the format of the export</param>
        /// <param name="searchTerm">Specify search text filter the results. Example: Use \&quot;Service Request\&quot; to filter Incident results to include only service requests. (optional)</param>
        /// <param name="pagenumber">Specify the page number of the result set to return. (optional)</param>
        /// <param name="pagesize">Specify the number of rows to return per page. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > SearchesGetSearchResultsExportByIdV1WithHttpInfo (string association, string scope, string scopeowner, string searchid, string exportformat, string searchTerm = null, int? pagenumber = null, int? pagesize = null, string lang = null, string locale = null)
        {
            // verify the required parameter 'association' is set
            if (association == null)
                throw new ApiException(400, "Missing required parameter 'association' when calling SearchesApi->SearchesGetSearchResultsExportByIdV1");
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling SearchesApi->SearchesGetSearchResultsExportByIdV1");
            // verify the required parameter 'scopeowner' is set
            if (scopeowner == null)
                throw new ApiException(400, "Missing required parameter 'scopeowner' when calling SearchesApi->SearchesGetSearchResultsExportByIdV1");
            // verify the required parameter 'searchid' is set
            if (searchid == null)
                throw new ApiException(400, "Missing required parameter 'searchid' when calling SearchesApi->SearchesGetSearchResultsExportByIdV1");
            // verify the required parameter 'exportformat' is set
            if (exportformat == null)
                throw new ApiException(400, "Missing required parameter 'exportformat' when calling SearchesApi->SearchesGetSearchResultsExportByIdV1");

            var localVarPath = "/api/V1/getsearchresultsexport/association/{association}/scope/{scope}/scopeowner/{scopeowner}/searchid/{searchid}/exportformat/{exportformat}";
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

            if (association != null) localVarPathParams.Add("association", Configuration.ApiClient.ParameterToString(association)); // path parameter
            if (scope != null) localVarPathParams.Add("scope", Configuration.ApiClient.ParameterToString(scope)); // path parameter
            if (scopeowner != null) localVarPathParams.Add("scopeowner", Configuration.ApiClient.ParameterToString(scopeowner)); // path parameter
            if (searchid != null) localVarPathParams.Add("searchid", Configuration.ApiClient.ParameterToString(searchid)); // path parameter
            if (exportformat != null) localVarPathParams.Add("exportformat", Configuration.ApiClient.ParameterToString(exportformat)); // path parameter
            if (searchTerm != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "searchTerm", searchTerm)); // query parameter
            if (pagenumber != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "pagenumber", pagenumber)); // query parameter
            if (pagesize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "pagesize", pagesize)); // query parameter
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
                Exception exception = ExceptionFactory("SearchesGetSearchResultsExportByIdV1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

        /// <summary>
        /// Export a saved search by ID Operation that returns the paged results of a saved search in a specified format. When the search contains Prompts, the response contains the Prompt. Send the Prompt and the original operation parameters to  SearchResultsRequest to the getsearchresultsexport ad-hoc http post operation.&lt;/br&gt;&lt;/br&gt;PromptType is a FieldSubType enum as described below:&lt;/br&gt;FieldSubType&lt;/br&gt;None &#x3D; 0&lt;/br&gt;Text &#x3D; 1&lt;/br&gt;Number &#x3D; 2&lt;/br&gt;DateTime &#x3D; 3&lt;/br&gt;Logical &#x3D; 4&lt;/br&gt;Binary &#x3D; 5&lt;/br&gt;DateOnly &#x3D; 6&lt;/br&gt;TimeOnly &#x3D; 7&lt;/br&gt;Json &#x3D; 8&lt;/br&gt;JsonArray &#x3D; 9&lt;/br&gt;Xml &#x3D; 10&lt;/br&gt;XmlCollection &#x3D; 11&lt;/br&gt;TimeValue &#x3D; 12&lt;/br&gt;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Specify the Business Object association ID for the saved search.</param>
        /// <param name="scope">Specify the scope name or ID for the saved search.</param>
        /// <param name="scopeowner">Specify the scope owner ID for the saved search. Use (None) when no scope owner exists.</param>
        /// <param name="searchid">Specify the internal ID for the saved search. Use \&quot;Run a saved search by name\&quot; if you do not have the internal ID.</param>
        /// <param name="exportformat">Specify the format of the export</param>
        /// <param name="searchTerm">Specify search text filter the results. Example: Use \&quot;Service Request\&quot; to filter Incident results to include only service requests. (optional)</param>
        /// <param name="pagenumber">Specify the page number of the result set to return. (optional)</param>
        /// <param name="pagesize">Specify the number of rows to return per page. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> SearchesGetSearchResultsExportByIdV1Async (string association, string scope, string scopeowner, string searchid, string exportformat, string searchTerm = null, int? pagenumber = null, int? pagesize = null, string lang = null, string locale = null)
        {
             ApiResponse<string> localVarResponse = await SearchesGetSearchResultsExportByIdV1AsyncWithHttpInfo(association, scope, scopeowner, searchid, exportformat, searchTerm, pagenumber, pagesize, lang, locale);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Export a saved search by ID Operation that returns the paged results of a saved search in a specified format. When the search contains Prompts, the response contains the Prompt. Send the Prompt and the original operation parameters to  SearchResultsRequest to the getsearchresultsexport ad-hoc http post operation.&lt;/br&gt;&lt;/br&gt;PromptType is a FieldSubType enum as described below:&lt;/br&gt;FieldSubType&lt;/br&gt;None &#x3D; 0&lt;/br&gt;Text &#x3D; 1&lt;/br&gt;Number &#x3D; 2&lt;/br&gt;DateTime &#x3D; 3&lt;/br&gt;Logical &#x3D; 4&lt;/br&gt;Binary &#x3D; 5&lt;/br&gt;DateOnly &#x3D; 6&lt;/br&gt;TimeOnly &#x3D; 7&lt;/br&gt;Json &#x3D; 8&lt;/br&gt;JsonArray &#x3D; 9&lt;/br&gt;Xml &#x3D; 10&lt;/br&gt;XmlCollection &#x3D; 11&lt;/br&gt;TimeValue &#x3D; 12&lt;/br&gt;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Specify the Business Object association ID for the saved search.</param>
        /// <param name="scope">Specify the scope name or ID for the saved search.</param>
        /// <param name="scopeowner">Specify the scope owner ID for the saved search. Use (None) when no scope owner exists.</param>
        /// <param name="searchid">Specify the internal ID for the saved search. Use \&quot;Run a saved search by name\&quot; if you do not have the internal ID.</param>
        /// <param name="exportformat">Specify the format of the export</param>
        /// <param name="searchTerm">Specify search text filter the results. Example: Use \&quot;Service Request\&quot; to filter Incident results to include only service requests. (optional)</param>
        /// <param name="pagenumber">Specify the page number of the result set to return. (optional)</param>
        /// <param name="pagesize">Specify the number of rows to return per page. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> SearchesGetSearchResultsExportByIdV1AsyncWithHttpInfo (string association, string scope, string scopeowner, string searchid, string exportformat, string searchTerm = null, int? pagenumber = null, int? pagesize = null, string lang = null, string locale = null)
        {
            // verify the required parameter 'association' is set
            if (association == null)
                throw new ApiException(400, "Missing required parameter 'association' when calling SearchesApi->SearchesGetSearchResultsExportByIdV1");
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling SearchesApi->SearchesGetSearchResultsExportByIdV1");
            // verify the required parameter 'scopeowner' is set
            if (scopeowner == null)
                throw new ApiException(400, "Missing required parameter 'scopeowner' when calling SearchesApi->SearchesGetSearchResultsExportByIdV1");
            // verify the required parameter 'searchid' is set
            if (searchid == null)
                throw new ApiException(400, "Missing required parameter 'searchid' when calling SearchesApi->SearchesGetSearchResultsExportByIdV1");
            // verify the required parameter 'exportformat' is set
            if (exportformat == null)
                throw new ApiException(400, "Missing required parameter 'exportformat' when calling SearchesApi->SearchesGetSearchResultsExportByIdV1");

            var localVarPath = "/api/V1/getsearchresultsexport/association/{association}/scope/{scope}/scopeowner/{scopeowner}/searchid/{searchid}/exportformat/{exportformat}";
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

            if (association != null) localVarPathParams.Add("association", Configuration.ApiClient.ParameterToString(association)); // path parameter
            if (scope != null) localVarPathParams.Add("scope", Configuration.ApiClient.ParameterToString(scope)); // path parameter
            if (scopeowner != null) localVarPathParams.Add("scopeowner", Configuration.ApiClient.ParameterToString(scopeowner)); // path parameter
            if (searchid != null) localVarPathParams.Add("searchid", Configuration.ApiClient.ParameterToString(searchid)); // path parameter
            if (exportformat != null) localVarPathParams.Add("exportformat", Configuration.ApiClient.ParameterToString(exportformat)); // path parameter
            if (searchTerm != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "searchTerm", searchTerm)); // query parameter
            if (pagenumber != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "pagenumber", pagenumber)); // query parameter
            if (pagesize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "pagesize", pagesize)); // query parameter
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
                Exception exception = ExceptionFactory("SearchesGetSearchResultsExportByIdV1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

        /// <summary>
        /// Export a saved search by name Operation that returns the paged results of a saved search in a specified format. When the search contains Prompts, the response contains the Prompt. Send the Prompt and the original operation parameters to  SearchResultsRequest to the getsearchresultsexport ad-hoc http post operation.&lt;/br&gt;&lt;/br&gt;PromptType is a FieldSubType enum as described below:&lt;/br&gt;FieldSubType&lt;/br&gt;None &#x3D; 0&lt;/br&gt;Text &#x3D; 1&lt;/br&gt;Number &#x3D; 2&lt;/br&gt;DateTime &#x3D; 3&lt;/br&gt;Logical &#x3D; 4&lt;/br&gt;Binary &#x3D; 5&lt;/br&gt;DateOnly &#x3D; 6&lt;/br&gt;TimeOnly &#x3D; 7&lt;/br&gt;Json &#x3D; 8&lt;/br&gt;JsonArray &#x3D; 9&lt;/br&gt;Xml &#x3D; 10&lt;/br&gt;XmlCollection &#x3D; 11&lt;/br&gt;TimeValue &#x3D; 12&lt;/br&gt;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Specify the Business Object association ID for the saved search.</param>
        /// <param name="scope">Specify the scope name or ID for the saved search.</param>
        /// <param name="scopeowner">Specify the scope owner ID for the saved search. Use (None) when no scope owner exists.</param>
        /// <param name="searchname">Specify the name of the saved search.</param>
        /// <param name="exportformat">Specify the format of the export</param>
        /// <param name="searchTerm">Specify search text filter the results. Example: Use \&quot;Service Request\&quot; to filter Incident results to include only service requests. (optional)</param>
        /// <param name="pagenumber">Specify the page number of the result set to return. (optional)</param>
        /// <param name="pagesize">Specify the number of rows to return per page. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>string</returns>
        public string SearchesGetSearchResultsExportByNameV1 (string association, string scope, string scopeowner, string searchname, string exportformat, string searchTerm = null, int? pagenumber = null, int? pagesize = null, string lang = null, string locale = null)
        {
             ApiResponse<string> localVarResponse = SearchesGetSearchResultsExportByNameV1WithHttpInfo(association, scope, scopeowner, searchname, exportformat, searchTerm, pagenumber, pagesize, lang, locale);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Export a saved search by name Operation that returns the paged results of a saved search in a specified format. When the search contains Prompts, the response contains the Prompt. Send the Prompt and the original operation parameters to  SearchResultsRequest to the getsearchresultsexport ad-hoc http post operation.&lt;/br&gt;&lt;/br&gt;PromptType is a FieldSubType enum as described below:&lt;/br&gt;FieldSubType&lt;/br&gt;None &#x3D; 0&lt;/br&gt;Text &#x3D; 1&lt;/br&gt;Number &#x3D; 2&lt;/br&gt;DateTime &#x3D; 3&lt;/br&gt;Logical &#x3D; 4&lt;/br&gt;Binary &#x3D; 5&lt;/br&gt;DateOnly &#x3D; 6&lt;/br&gt;TimeOnly &#x3D; 7&lt;/br&gt;Json &#x3D; 8&lt;/br&gt;JsonArray &#x3D; 9&lt;/br&gt;Xml &#x3D; 10&lt;/br&gt;XmlCollection &#x3D; 11&lt;/br&gt;TimeValue &#x3D; 12&lt;/br&gt;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Specify the Business Object association ID for the saved search.</param>
        /// <param name="scope">Specify the scope name or ID for the saved search.</param>
        /// <param name="scopeowner">Specify the scope owner ID for the saved search. Use (None) when no scope owner exists.</param>
        /// <param name="searchname">Specify the name of the saved search.</param>
        /// <param name="exportformat">Specify the format of the export</param>
        /// <param name="searchTerm">Specify search text filter the results. Example: Use \&quot;Service Request\&quot; to filter Incident results to include only service requests. (optional)</param>
        /// <param name="pagenumber">Specify the page number of the result set to return. (optional)</param>
        /// <param name="pagesize">Specify the number of rows to return per page. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > SearchesGetSearchResultsExportByNameV1WithHttpInfo (string association, string scope, string scopeowner, string searchname, string exportformat, string searchTerm = null, int? pagenumber = null, int? pagesize = null, string lang = null, string locale = null)
        {
            // verify the required parameter 'association' is set
            if (association == null)
                throw new ApiException(400, "Missing required parameter 'association' when calling SearchesApi->SearchesGetSearchResultsExportByNameV1");
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling SearchesApi->SearchesGetSearchResultsExportByNameV1");
            // verify the required parameter 'scopeowner' is set
            if (scopeowner == null)
                throw new ApiException(400, "Missing required parameter 'scopeowner' when calling SearchesApi->SearchesGetSearchResultsExportByNameV1");
            // verify the required parameter 'searchname' is set
            if (searchname == null)
                throw new ApiException(400, "Missing required parameter 'searchname' when calling SearchesApi->SearchesGetSearchResultsExportByNameV1");
            // verify the required parameter 'exportformat' is set
            if (exportformat == null)
                throw new ApiException(400, "Missing required parameter 'exportformat' when calling SearchesApi->SearchesGetSearchResultsExportByNameV1");

            var localVarPath = "/api/V1/getsearchresultsexport/association/{association}/scope/{scope}/scopeowner/{scopeowner}/searchname/{searchname}/exportformat/{exportformat}";
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

            if (association != null) localVarPathParams.Add("association", Configuration.ApiClient.ParameterToString(association)); // path parameter
            if (scope != null) localVarPathParams.Add("scope", Configuration.ApiClient.ParameterToString(scope)); // path parameter
            if (scopeowner != null) localVarPathParams.Add("scopeowner", Configuration.ApiClient.ParameterToString(scopeowner)); // path parameter
            if (searchname != null) localVarPathParams.Add("searchname", Configuration.ApiClient.ParameterToString(searchname)); // path parameter
            if (exportformat != null) localVarPathParams.Add("exportformat", Configuration.ApiClient.ParameterToString(exportformat)); // path parameter
            if (searchTerm != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "searchTerm", searchTerm)); // query parameter
            if (pagenumber != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "pagenumber", pagenumber)); // query parameter
            if (pagesize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "pagesize", pagesize)); // query parameter
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
                Exception exception = ExceptionFactory("SearchesGetSearchResultsExportByNameV1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

        /// <summary>
        /// Export a saved search by name Operation that returns the paged results of a saved search in a specified format. When the search contains Prompts, the response contains the Prompt. Send the Prompt and the original operation parameters to  SearchResultsRequest to the getsearchresultsexport ad-hoc http post operation.&lt;/br&gt;&lt;/br&gt;PromptType is a FieldSubType enum as described below:&lt;/br&gt;FieldSubType&lt;/br&gt;None &#x3D; 0&lt;/br&gt;Text &#x3D; 1&lt;/br&gt;Number &#x3D; 2&lt;/br&gt;DateTime &#x3D; 3&lt;/br&gt;Logical &#x3D; 4&lt;/br&gt;Binary &#x3D; 5&lt;/br&gt;DateOnly &#x3D; 6&lt;/br&gt;TimeOnly &#x3D; 7&lt;/br&gt;Json &#x3D; 8&lt;/br&gt;JsonArray &#x3D; 9&lt;/br&gt;Xml &#x3D; 10&lt;/br&gt;XmlCollection &#x3D; 11&lt;/br&gt;TimeValue &#x3D; 12&lt;/br&gt;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Specify the Business Object association ID for the saved search.</param>
        /// <param name="scope">Specify the scope name or ID for the saved search.</param>
        /// <param name="scopeowner">Specify the scope owner ID for the saved search. Use (None) when no scope owner exists.</param>
        /// <param name="searchname">Specify the name of the saved search.</param>
        /// <param name="exportformat">Specify the format of the export</param>
        /// <param name="searchTerm">Specify search text filter the results. Example: Use \&quot;Service Request\&quot; to filter Incident results to include only service requests. (optional)</param>
        /// <param name="pagenumber">Specify the page number of the result set to return. (optional)</param>
        /// <param name="pagesize">Specify the number of rows to return per page. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> SearchesGetSearchResultsExportByNameV1Async (string association, string scope, string scopeowner, string searchname, string exportformat, string searchTerm = null, int? pagenumber = null, int? pagesize = null, string lang = null, string locale = null)
        {
             ApiResponse<string> localVarResponse = await SearchesGetSearchResultsExportByNameV1AsyncWithHttpInfo(association, scope, scopeowner, searchname, exportformat, searchTerm, pagenumber, pagesize, lang, locale);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Export a saved search by name Operation that returns the paged results of a saved search in a specified format. When the search contains Prompts, the response contains the Prompt. Send the Prompt and the original operation parameters to  SearchResultsRequest to the getsearchresultsexport ad-hoc http post operation.&lt;/br&gt;&lt;/br&gt;PromptType is a FieldSubType enum as described below:&lt;/br&gt;FieldSubType&lt;/br&gt;None &#x3D; 0&lt;/br&gt;Text &#x3D; 1&lt;/br&gt;Number &#x3D; 2&lt;/br&gt;DateTime &#x3D; 3&lt;/br&gt;Logical &#x3D; 4&lt;/br&gt;Binary &#x3D; 5&lt;/br&gt;DateOnly &#x3D; 6&lt;/br&gt;TimeOnly &#x3D; 7&lt;/br&gt;Json &#x3D; 8&lt;/br&gt;JsonArray &#x3D; 9&lt;/br&gt;Xml &#x3D; 10&lt;/br&gt;XmlCollection &#x3D; 11&lt;/br&gt;TimeValue &#x3D; 12&lt;/br&gt;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Specify the Business Object association ID for the saved search.</param>
        /// <param name="scope">Specify the scope name or ID for the saved search.</param>
        /// <param name="scopeowner">Specify the scope owner ID for the saved search. Use (None) when no scope owner exists.</param>
        /// <param name="searchname">Specify the name of the saved search.</param>
        /// <param name="exportformat">Specify the format of the export</param>
        /// <param name="searchTerm">Specify search text filter the results. Example: Use \&quot;Service Request\&quot; to filter Incident results to include only service requests. (optional)</param>
        /// <param name="pagenumber">Specify the page number of the result set to return. (optional)</param>
        /// <param name="pagesize">Specify the number of rows to return per page. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> SearchesGetSearchResultsExportByNameV1AsyncWithHttpInfo (string association, string scope, string scopeowner, string searchname, string exportformat, string searchTerm = null, int? pagenumber = null, int? pagesize = null, string lang = null, string locale = null)
        {
            // verify the required parameter 'association' is set
            if (association == null)
                throw new ApiException(400, "Missing required parameter 'association' when calling SearchesApi->SearchesGetSearchResultsExportByNameV1");
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling SearchesApi->SearchesGetSearchResultsExportByNameV1");
            // verify the required parameter 'scopeowner' is set
            if (scopeowner == null)
                throw new ApiException(400, "Missing required parameter 'scopeowner' when calling SearchesApi->SearchesGetSearchResultsExportByNameV1");
            // verify the required parameter 'searchname' is set
            if (searchname == null)
                throw new ApiException(400, "Missing required parameter 'searchname' when calling SearchesApi->SearchesGetSearchResultsExportByNameV1");
            // verify the required parameter 'exportformat' is set
            if (exportformat == null)
                throw new ApiException(400, "Missing required parameter 'exportformat' when calling SearchesApi->SearchesGetSearchResultsExportByNameV1");

            var localVarPath = "/api/V1/getsearchresultsexport/association/{association}/scope/{scope}/scopeowner/{scopeowner}/searchname/{searchname}/exportformat/{exportformat}";
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

            if (association != null) localVarPathParams.Add("association", Configuration.ApiClient.ParameterToString(association)); // path parameter
            if (scope != null) localVarPathParams.Add("scope", Configuration.ApiClient.ParameterToString(scope)); // path parameter
            if (scopeowner != null) localVarPathParams.Add("scopeowner", Configuration.ApiClient.ParameterToString(scopeowner)); // path parameter
            if (searchname != null) localVarPathParams.Add("searchname", Configuration.ApiClient.ParameterToString(searchname)); // path parameter
            if (exportformat != null) localVarPathParams.Add("exportformat", Configuration.ApiClient.ParameterToString(exportformat)); // path parameter
            if (searchTerm != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "searchTerm", searchTerm)); // query parameter
            if (pagenumber != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "pagenumber", pagenumber)); // query parameter
            if (pagesize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "pagesize", pagesize)); // query parameter
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
                Exception exception = ExceptionFactory("SearchesGetSearchResultsExportByNameV1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

    }
}
