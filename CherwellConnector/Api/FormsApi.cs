
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
    public partial class FormsApi : IFormsApi
    {
        private ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="FormsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public FormsApi(string basePath)
        {
            Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FormsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public FormsApi(Configuration configuration = null)
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
        /// Get mobile form by BusObId and Public ID Operation that gets a mobile form for a specific Business Object by Business Object ID and Public ID.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobid">Specify the Business Object ID.</param>
        /// <param name="publicid">Specify the Business Object Public ID.</param>
        /// <param name="foredit">Flag to get the edit mode version of a form. (optional)</param>
        /// <param name="formid">Specify the form ID if the default is not desired. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsFormsMobileFormResponse</returns>
        public MobileFormResponse FormsGetMobileFormForBusObByIdAndPublicIdV1 (string busobid, string publicid, bool? foredit = null, string formid = null, string lang = null, string locale = null)
        {
             ApiResponse<MobileFormResponse> localVarResponse = FormsGetMobileFormForBusObByIdAndPublicIdV1WithHttpInfo(busobid, publicid, foredit, formid, lang, locale);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get mobile form by BusObId and Public ID Operation that gets a mobile form for a specific Business Object by Business Object ID and Public ID.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobid">Specify the Business Object ID.</param>
        /// <param name="publicid">Specify the Business Object Public ID.</param>
        /// <param name="foredit">Flag to get the edit mode version of a form. (optional)</param>
        /// <param name="formid">Specify the form ID if the default is not desired. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsFormsMobileFormResponse</returns>
        public ApiResponse< MobileFormResponse > FormsGetMobileFormForBusObByIdAndPublicIdV1WithHttpInfo (string busobid, string publicid, bool? foredit = null, string formid = null, string lang = null, string locale = null)
        {
            // verify the required parameter 'busobid' is set
            if (busobid == null)
                throw new ApiException(400, "Missing required parameter 'busobid' when calling FormsApi->FormsGetMobileFormForBusObByIdAndPublicIdV1");
            // verify the required parameter 'publicid' is set
            if (publicid == null)
                throw new ApiException(400, "Missing required parameter 'publicid' when calling FormsApi->FormsGetMobileFormForBusObByIdAndPublicIdV1");

            var localVarPath = "/api/V1/getmobileformforbusob/busobid/{busobid}/publicid/{publicid}";
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

            if (busobid != null) localVarPathParams.Add("busobid", Configuration.ApiClient.ParameterToString(busobid)); // path parameter
            if (publicid != null) localVarPathParams.Add("publicid", Configuration.ApiClient.ParameterToString(publicid)); // path parameter
            if (foredit != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "foredit", foredit)); // query parameter
            if (formid != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "formid", formid)); // query parameter
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
                Exception exception = ExceptionFactory("FormsGetMobileFormForBusObByIdAndPublicIdV1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MobileFormResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MobileFormResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MobileFormResponse)));
        }

        /// <summary>
        /// Get mobile form by BusObId and Public ID Operation that gets a mobile form for a specific Business Object by Business Object ID and Public ID.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobid">Specify the Business Object ID.</param>
        /// <param name="publicid">Specify the Business Object Public ID.</param>
        /// <param name="foredit">Flag to get the edit mode version of a form. (optional)</param>
        /// <param name="formid">Specify the form ID if the default is not desired. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsFormsMobileFormResponse</returns>
        public async System.Threading.Tasks.Task<MobileFormResponse> FormsGetMobileFormForBusObByIdAndPublicIdV1Async (string busobid, string publicid, bool? foredit = null, string formid = null, string lang = null, string locale = null)
        {
             ApiResponse<MobileFormResponse> localVarResponse = await FormsGetMobileFormForBusObByIdAndPublicIdV1AsyncWithHttpInfo(busobid, publicid, foredit, formid, lang, locale);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get mobile form by BusObId and Public ID Operation that gets a mobile form for a specific Business Object by Business Object ID and Public ID.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobid">Specify the Business Object ID.</param>
        /// <param name="publicid">Specify the Business Object Public ID.</param>
        /// <param name="foredit">Flag to get the edit mode version of a form. (optional)</param>
        /// <param name="formid">Specify the form ID if the default is not desired. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsFormsMobileFormResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MobileFormResponse>> FormsGetMobileFormForBusObByIdAndPublicIdV1AsyncWithHttpInfo (string busobid, string publicid, bool? foredit = null, string formid = null, string lang = null, string locale = null)
        {
            // verify the required parameter 'busobid' is set
            if (busobid == null)
                throw new ApiException(400, "Missing required parameter 'busobid' when calling FormsApi->FormsGetMobileFormForBusObByIdAndPublicIdV1");
            // verify the required parameter 'publicid' is set
            if (publicid == null)
                throw new ApiException(400, "Missing required parameter 'publicid' when calling FormsApi->FormsGetMobileFormForBusObByIdAndPublicIdV1");

            var localVarPath = "/api/V1/getmobileformforbusob/busobid/{busobid}/publicid/{publicid}";
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

            if (busobid != null) localVarPathParams.Add("busobid", Configuration.ApiClient.ParameterToString(busobid)); // path parameter
            if (publicid != null) localVarPathParams.Add("publicid", Configuration.ApiClient.ParameterToString(publicid)); // path parameter
            if (foredit != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "foredit", foredit)); // query parameter
            if (formid != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "formid", formid)); // query parameter
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
                Exception exception = ExceptionFactory("FormsGetMobileFormForBusObByIdAndPublicIdV1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MobileFormResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MobileFormResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MobileFormResponse)));
        }

        /// <summary>
        /// Get mobile form by Business Object ID and Business Object Record ID. Operation that gets a mobile form for a specific Business Object by Business Object ID and record ID.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobid">Specify the Business Object ID.</param>
        /// <param name="busobrecid">Specify the Business Object Record ID.</param>
        /// <param name="foredit">Flag to get the edit mode version of a form. (optional)</param>
        /// <param name="formid">Specify the form ID if the default is not desired. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsFormsMobileFormResponse</returns>
        public MobileFormResponse FormsGetMobileFormForBusObByIdAndRecIdV1 (string busobid, string busobrecid, bool? foredit = null, string formid = null, string lang = null, string locale = null)
        {
             ApiResponse<MobileFormResponse> localVarResponse = FormsGetMobileFormForBusObByIdAndRecIdV1WithHttpInfo(busobid, busobrecid, foredit, formid, lang, locale);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get mobile form by Business Object ID and Business Object Record ID. Operation that gets a mobile form for a specific Business Object by Business Object ID and record ID.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobid">Specify the Business Object ID.</param>
        /// <param name="busobrecid">Specify the Business Object Record ID.</param>
        /// <param name="foredit">Flag to get the edit mode version of a form. (optional)</param>
        /// <param name="formid">Specify the form ID if the default is not desired. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsFormsMobileFormResponse</returns>
        public ApiResponse< MobileFormResponse > FormsGetMobileFormForBusObByIdAndRecIdV1WithHttpInfo (string busobid, string busobrecid, bool? foredit = null, string formid = null, string lang = null, string locale = null)
        {
            // verify the required parameter 'busobid' is set
            if (busobid == null)
                throw new ApiException(400, "Missing required parameter 'busobid' when calling FormsApi->FormsGetMobileFormForBusObByIdAndRecIdV1");
            // verify the required parameter 'busobrecid' is set
            if (busobrecid == null)
                throw new ApiException(400, "Missing required parameter 'busobrecid' when calling FormsApi->FormsGetMobileFormForBusObByIdAndRecIdV1");

            var localVarPath = "/api/V1/getmobileformforbusob/busobid/{busobid}/busobrecid/{busobrecid}";
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

            if (busobid != null) localVarPathParams.Add("busobid", Configuration.ApiClient.ParameterToString(busobid)); // path parameter
            if (busobrecid != null) localVarPathParams.Add("busobrecid", Configuration.ApiClient.ParameterToString(busobrecid)); // path parameter
            if (foredit != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "foredit", foredit)); // query parameter
            if (formid != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "formid", formid)); // query parameter
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
                Exception exception = ExceptionFactory("FormsGetMobileFormForBusObByIdAndRecIdV1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MobileFormResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MobileFormResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MobileFormResponse)));
        }

        /// <summary>
        /// Get mobile form by Business Object ID and Business Object Record ID. Operation that gets a mobile form for a specific Business Object by Business Object ID and record ID.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobid">Specify the Business Object ID.</param>
        /// <param name="busobrecid">Specify the Business Object Record ID.</param>
        /// <param name="foredit">Flag to get the edit mode version of a form. (optional)</param>
        /// <param name="formid">Specify the form ID if the default is not desired. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsFormsMobileFormResponse</returns>
        public async System.Threading.Tasks.Task<MobileFormResponse> FormsGetMobileFormForBusObByIdAndRecIdV1Async (string busobid, string busobrecid, bool? foredit = null, string formid = null, string lang = null, string locale = null)
        {
             ApiResponse<MobileFormResponse> localVarResponse = await FormsGetMobileFormForBusObByIdAndRecIdV1AsyncWithHttpInfo(busobid, busobrecid, foredit, formid, lang, locale);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get mobile form by Business Object ID and Business Object Record ID. Operation that gets a mobile form for a specific Business Object by Business Object ID and record ID.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobid">Specify the Business Object ID.</param>
        /// <param name="busobrecid">Specify the Business Object Record ID.</param>
        /// <param name="foredit">Flag to get the edit mode version of a form. (optional)</param>
        /// <param name="formid">Specify the form ID if the default is not desired. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsFormsMobileFormResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MobileFormResponse>> FormsGetMobileFormForBusObByIdAndRecIdV1AsyncWithHttpInfo (string busobid, string busobrecid, bool? foredit = null, string formid = null, string lang = null, string locale = null)
        {
            // verify the required parameter 'busobid' is set
            if (busobid == null)
                throw new ApiException(400, "Missing required parameter 'busobid' when calling FormsApi->FormsGetMobileFormForBusObByIdAndRecIdV1");
            // verify the required parameter 'busobrecid' is set
            if (busobrecid == null)
                throw new ApiException(400, "Missing required parameter 'busobrecid' when calling FormsApi->FormsGetMobileFormForBusObByIdAndRecIdV1");

            var localVarPath = "/api/V1/getmobileformforbusob/busobid/{busobid}/busobrecid/{busobrecid}";
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

            if (busobid != null) localVarPathParams.Add("busobid", Configuration.ApiClient.ParameterToString(busobid)); // path parameter
            if (busobrecid != null) localVarPathParams.Add("busobrecid", Configuration.ApiClient.ParameterToString(busobrecid)); // path parameter
            if (foredit != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "foredit", foredit)); // query parameter
            if (formid != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "formid", formid)); // query parameter
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
                Exception exception = ExceptionFactory("FormsGetMobileFormForBusObByIdAndRecIdV1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MobileFormResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MobileFormResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MobileFormResponse)));
        }

        /// <summary>
        /// Get mobile form by Business Object name and Public ID Operation that gets a mobile form for a specific Business Object by Business Object name and public ID.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="publicid">Specify the Business Object public ID.</param>
        /// <param name="foredit">Flag to get the edit mode version of a form. (optional)</param>
        /// <param name="formid">Specify the form ID if the default is not desired. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsFormsMobileFormResponse</returns>
        public MobileFormResponse FormsGetMobileFormForBusObByNameAndPublicIdV1 (string busobname, string publicid, bool? foredit = null, string formid = null, string lang = null, string locale = null)
        {
             ApiResponse<MobileFormResponse> localVarResponse = FormsGetMobileFormForBusObByNameAndPublicIdV1WithHttpInfo(busobname, publicid, foredit, formid, lang, locale);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get mobile form by Business Object name and Public ID Operation that gets a mobile form for a specific Business Object by Business Object name and public ID.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="publicid">Specify the Business Object public ID.</param>
        /// <param name="foredit">Flag to get the edit mode version of a form. (optional)</param>
        /// <param name="formid">Specify the form ID if the default is not desired. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsFormsMobileFormResponse</returns>
        public ApiResponse< MobileFormResponse > FormsGetMobileFormForBusObByNameAndPublicIdV1WithHttpInfo (string busobname, string publicid, bool? foredit = null, string formid = null, string lang = null, string locale = null)
        {
            // verify the required parameter 'busobname' is set
            if (busobname == null)
                throw new ApiException(400, "Missing required parameter 'busobname' when calling FormsApi->FormsGetMobileFormForBusObByNameAndPublicIdV1");
            // verify the required parameter 'publicid' is set
            if (publicid == null)
                throw new ApiException(400, "Missing required parameter 'publicid' when calling FormsApi->FormsGetMobileFormForBusObByNameAndPublicIdV1");

            var localVarPath = "/api/V1/getmobileformforbusob/busobname/{busobname}/publicid/{publicid}";
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
            if (publicid != null) localVarPathParams.Add("publicid", Configuration.ApiClient.ParameterToString(publicid)); // path parameter
            if (foredit != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "foredit", foredit)); // query parameter
            if (formid != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "formid", formid)); // query parameter
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
                Exception exception = ExceptionFactory("FormsGetMobileFormForBusObByNameAndPublicIdV1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MobileFormResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MobileFormResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MobileFormResponse)));
        }

        /// <summary>
        /// Get mobile form by Business Object name and Public ID Operation that gets a mobile form for a specific Business Object by Business Object name and public ID.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="publicid">Specify the Business Object public ID.</param>
        /// <param name="foredit">Flag to get the edit mode version of a form. (optional)</param>
        /// <param name="formid">Specify the form ID if the default is not desired. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsFormsMobileFormResponse</returns>
        public async System.Threading.Tasks.Task<MobileFormResponse> FormsGetMobileFormForBusObByNameAndPublicIdV1Async (string busobname, string publicid, bool? foredit = null, string formid = null, string lang = null, string locale = null)
        {
             ApiResponse<MobileFormResponse> localVarResponse = await FormsGetMobileFormForBusObByNameAndPublicIdV1AsyncWithHttpInfo(busobname, publicid, foredit, formid, lang, locale);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get mobile form by Business Object name and Public ID Operation that gets a mobile form for a specific Business Object by Business Object name and public ID.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="publicid">Specify the Business Object public ID.</param>
        /// <param name="foredit">Flag to get the edit mode version of a form. (optional)</param>
        /// <param name="formid">Specify the form ID if the default is not desired. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsFormsMobileFormResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MobileFormResponse>> FormsGetMobileFormForBusObByNameAndPublicIdV1AsyncWithHttpInfo (string busobname, string publicid, bool? foredit = null, string formid = null, string lang = null, string locale = null)
        {
            // verify the required parameter 'busobname' is set
            if (busobname == null)
                throw new ApiException(400, "Missing required parameter 'busobname' when calling FormsApi->FormsGetMobileFormForBusObByNameAndPublicIdV1");
            // verify the required parameter 'publicid' is set
            if (publicid == null)
                throw new ApiException(400, "Missing required parameter 'publicid' when calling FormsApi->FormsGetMobileFormForBusObByNameAndPublicIdV1");

            var localVarPath = "/api/V1/getmobileformforbusob/busobname/{busobname}/publicid/{publicid}";
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
            if (publicid != null) localVarPathParams.Add("publicid", Configuration.ApiClient.ParameterToString(publicid)); // path parameter
            if (foredit != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "foredit", foredit)); // query parameter
            if (formid != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "formid", formid)); // query parameter
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
                Exception exception = ExceptionFactory("FormsGetMobileFormForBusObByNameAndPublicIdV1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MobileFormResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MobileFormResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MobileFormResponse)));
        }

        /// <summary>
        /// Get mobile form by Business Object name and record ID. Operation that gets a mobile form for a specific Business Object by Business Object name and record ID.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="busobrecid">Specify the Business Object record ID.</param>
        /// <param name="foredit">Flag to get the edit mode version of a form. (optional)</param>
        /// <param name="formid">Specify the form ID if the default is not desired. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsFormsMobileFormResponse</returns>
        public MobileFormResponse FormsGetMobileFormForBusObByNameAndRecIdV1 (string busobname, string busobrecid, bool? foredit = null, string formid = null, string lang = null, string locale = null)
        {
             ApiResponse<MobileFormResponse> localVarResponse = FormsGetMobileFormForBusObByNameAndRecIdV1WithHttpInfo(busobname, busobrecid, foredit, formid, lang, locale);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get mobile form by Business Object name and record ID. Operation that gets a mobile form for a specific Business Object by Business Object name and record ID.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="busobrecid">Specify the Business Object record ID.</param>
        /// <param name="foredit">Flag to get the edit mode version of a form. (optional)</param>
        /// <param name="formid">Specify the form ID if the default is not desired. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsFormsMobileFormResponse</returns>
        public ApiResponse< MobileFormResponse > FormsGetMobileFormForBusObByNameAndRecIdV1WithHttpInfo (string busobname, string busobrecid, bool? foredit = null, string formid = null, string lang = null, string locale = null)
        {
            // verify the required parameter 'busobname' is set
            if (busobname == null)
                throw new ApiException(400, "Missing required parameter 'busobname' when calling FormsApi->FormsGetMobileFormForBusObByNameAndRecIdV1");
            // verify the required parameter 'busobrecid' is set
            if (busobrecid == null)
                throw new ApiException(400, "Missing required parameter 'busobrecid' when calling FormsApi->FormsGetMobileFormForBusObByNameAndRecIdV1");

            var localVarPath = "/api/V1/getmobileformforbusob/busobname/{busobname}/busobrecid/{busobrecid}";
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
            if (busobrecid != null) localVarPathParams.Add("busobrecid", Configuration.ApiClient.ParameterToString(busobrecid)); // path parameter
            if (foredit != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "foredit", foredit)); // query parameter
            if (formid != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "formid", formid)); // query parameter
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
                Exception exception = ExceptionFactory("FormsGetMobileFormForBusObByNameAndRecIdV1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MobileFormResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MobileFormResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MobileFormResponse)));
        }

        /// <summary>
        /// Get mobile form by Business Object name and record ID. Operation that gets a mobile form for a specific Business Object by Business Object name and record ID.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="busobrecid">Specify the Business Object record ID.</param>
        /// <param name="foredit">Flag to get the edit mode version of a form. (optional)</param>
        /// <param name="formid">Specify the form ID if the default is not desired. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsFormsMobileFormResponse</returns>
        public async System.Threading.Tasks.Task<MobileFormResponse> FormsGetMobileFormForBusObByNameAndRecIdV1Async (string busobname, string busobrecid, bool? foredit = null, string formid = null, string lang = null, string locale = null)
        {
             ApiResponse<MobileFormResponse> localVarResponse = await FormsGetMobileFormForBusObByNameAndRecIdV1AsyncWithHttpInfo(busobname, busobrecid, foredit, formid, lang, locale);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get mobile form by Business Object name and record ID. Operation that gets a mobile form for a specific Business Object by Business Object name and record ID.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="busobrecid">Specify the Business Object record ID.</param>
        /// <param name="foredit">Flag to get the edit mode version of a form. (optional)</param>
        /// <param name="formid">Specify the form ID if the default is not desired. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsFormsMobileFormResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MobileFormResponse>> FormsGetMobileFormForBusObByNameAndRecIdV1AsyncWithHttpInfo (string busobname, string busobrecid, bool? foredit = null, string formid = null, string lang = null, string locale = null)
        {
            // verify the required parameter 'busobname' is set
            if (busobname == null)
                throw new ApiException(400, "Missing required parameter 'busobname' when calling FormsApi->FormsGetMobileFormForBusObByNameAndRecIdV1");
            // verify the required parameter 'busobrecid' is set
            if (busobrecid == null)
                throw new ApiException(400, "Missing required parameter 'busobrecid' when calling FormsApi->FormsGetMobileFormForBusObByNameAndRecIdV1");

            var localVarPath = "/api/V1/getmobileformforbusob/busobname/{busobname}/busobrecid/{busobrecid}";
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
            if (busobrecid != null) localVarPathParams.Add("busobrecid", Configuration.ApiClient.ParameterToString(busobrecid)); // path parameter
            if (foredit != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "foredit", foredit)); // query parameter
            if (formid != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "formid", formid)); // query parameter
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
                Exception exception = ExceptionFactory("FormsGetMobileFormForBusObByNameAndRecIdV1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MobileFormResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MobileFormResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MobileFormResponse)));
        }

    }
}
