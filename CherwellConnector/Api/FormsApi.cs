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
    public class FormsApi : BaseApi, IFormsApi
    {
        #region Variables & Properties

        private static FormsApi _instance;

        private static readonly object Padlock = new();

        public static FormsApi Instance
        {
            get
            {
                lock (Padlock)
                {
                    _instance ??= new FormsApi(ServiceApi.Instance.Configuration);

                    _instance = (FormsApi) ServiceApi.Instance.CheckApiHeader(_instance);
                    return _instance;
                }
            }
            set => _instance = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="FormsApi" /> class.
        /// </summary>
        /// <returns></returns>
        public FormsApi(string basePath)
        {
            Configuration = new Configuration {BasePath = basePath};

            ExceptionFactory = Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="FormsApi" /> class
        ///     using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public FormsApi(Configuration configuration = null)
        {
            Configuration = configuration ?? Configuration.Default;

            ExceptionFactory = Configuration.DefaultExceptionFactory;
        }

        #endregion

        #region FormsGetMobileFormForBusObByIdAndPublicIdV1

        /// <summary>
        ///     Get mobile form by BusObId and Public ID Operation that gets a mobile form for a specific Business Object by
        ///     Business Object ID and Public ID.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobid">Specify the Business Object ID.</param>
        /// <param name="publicid">Specify the Business Object Public ID.</param>
        /// <param name="foredit">Flag to get the edit mode version of a form. (optional)</param>
        /// <param name="formid">Specify the form ID if the default is not desired. (optional)</param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>MobileFormResponse</returns>
        public MobileFormResponse FormsGetMobileFormForBusObByIdAndPublicIdV1(string busobid, string publicid,
            bool? foredit = null, string formid = null, string lang = null, string locale = null)
        {
            return FormsGetMobileFormForBusObByIdAndPublicIdV1WithHttpInfo(busobid, publicid, foredit, formid, lang,
                locale).Data;
        }

        /// <summary>
        ///     Get mobile form by BusObId and Public ID Operation that gets a mobile form for a specific Business Object by
        ///     Business Object ID and Public ID.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobid">Specify the Business Object ID.</param>
        /// <param name="publicid">Specify the Business Object Public ID.</param>
        /// <param name="foredit">Flag to get the edit mode version of a form. (optional)</param>
        /// <param name="formid">Specify the form ID if the default is not desired. (optional)</param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>ApiResponse of MobileFormResponse</returns>
        private ApiResponse<MobileFormResponse> FormsGetMobileFormForBusObByIdAndPublicIdV1WithHttpInfo(string busobid,
            string publicid, bool? foredit = null, string formid = null, string lang = null, string locale = null)
        {
            // verify the required parameter 'busobid' is set
            if (busobid == null)
                throw new ApiException(400,
                    "Missing required parameter 'busobid' when calling FormsApi->FormsGetMobileFormForBusObByIdAndPublicIdV1");
            // verify the required parameter 'publicid' is set
            if (publicid == null)
                throw new ApiException(400,
                    "Missing required parameter 'publicid' when calling FormsApi->FormsGetMobileFormForBusObByIdAndPublicIdV1");

            var localVarPath = $"/api/V1/getmobileformforbusob/busobid/{busobid}/publicid/{publicid}";
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

            localVarPathParams.Add("busobid", Configuration.ApiClient.ParameterToString(busobid)); // path parameter
            localVarPathParams.Add("publicid", Configuration.ApiClient.ParameterToString(publicid)); // path parameter
            if (foredit != null)
                localVarQueryParams.AddRange(
                    Configuration.ApiClient.ParameterToKeyValuePairs("", "foredit", foredit)); // query parameter
            if (formid != null)
                localVarQueryParams.AddRange(
                    Configuration.ApiClient.ParameterToKeyValuePairs("", "formid", formid)); // query parameter
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

            var exception = ExceptionFactory?.Invoke("FormsGetMobileFormForBusObByIdAndPublicIdV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<MobileFormResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (MobileFormResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MobileFormResponse)));
        }

        #endregion

        #region FormsGetMobileFormForBusObByIdAndRecIdV1

        /// <summary>
        ///     Get mobile form by Business Object ID and Business Object Record ID. Operation that gets a mobile form for a
        ///     specific Business Object by Business Object ID and record ID.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobid">Specify the Business Object ID.</param>
        /// <param name="busobrecid">Specify the Business Object Record ID.</param>
        /// <param name="foredit">Flag to get the edit mode version of a form. (optional)</param>
        /// <param name="formid">Specify the form ID if the default is not desired. (optional)</param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>MobileFormResponse</returns>
        public MobileFormResponse FormsGetMobileFormForBusObByIdAndRecIdV1(string busobid, string busobrecid,
            bool? foredit = null, string formid = null, string lang = null, string locale = null)
        {
            return FormsGetMobileFormForBusObByIdAndRecIdV1WithHttpInfo(busobid, busobrecid, foredit, formid, lang,
                locale).Data;
        }

        /// <summary>
        ///     Get mobile form by Business Object ID and Business Object Record ID. Operation that gets a mobile form for a
        ///     specific Business Object by Business Object ID and record ID.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobid">Specify the Business Object ID.</param>
        /// <param name="busobrecid">Specify the Business Object Record ID.</param>
        /// <param name="foredit">Flag to get the edit mode version of a form. (optional)</param>
        /// <param name="formid">Specify the form ID if the default is not desired. (optional)</param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>ApiResponse of MobileFormResponse</returns>
        private ApiResponse<MobileFormResponse> FormsGetMobileFormForBusObByIdAndRecIdV1WithHttpInfo(string busobid,
            string busobrecid, bool? foredit = null, string formid = null, string lang = null, string locale = null)
        {
            // verify the required parameter 'busobid' is set
            if (busobid == null)
                throw new ApiException(400,
                    "Missing required parameter 'busobid' when calling FormsApi->FormsGetMobileFormForBusObByIdAndRecIdV1");
            // verify the required parameter 'busobrecid' is set
            if (busobrecid == null)
                throw new ApiException(400,
                    "Missing required parameter 'busobrecid' when calling FormsApi->FormsGetMobileFormForBusObByIdAndRecIdV1");

            var localVarPath = $"/api/V1/getmobileformforbusob/busobid/{busobid}/busobrecid/{busobrecid}";
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

            localVarPathParams.Add("busobid", Configuration.ApiClient.ParameterToString(busobid)); // path parameter
            localVarPathParams.Add("busobrecid",
                Configuration.ApiClient.ParameterToString(busobrecid)); // path parameter
            if (foredit != null)
                localVarQueryParams.AddRange(
                    Configuration.ApiClient.ParameterToKeyValuePairs("", "foredit", foredit)); // query parameter
            if (formid != null)
                localVarQueryParams.AddRange(
                    Configuration.ApiClient.ParameterToKeyValuePairs("", "formid", formid)); // query parameter
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

            var exception = ExceptionFactory?.Invoke("FormsGetMobileFormForBusObByIdAndRecIdV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<MobileFormResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (MobileFormResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MobileFormResponse)));
        }

        #endregion

        #region FormsGetMobileFormForBusObByNameAndPublicIdV1

        /// <summary>
        ///     Get mobile form by Business Object name and Public ID Operation that gets a mobile form for a specific Business
        ///     Object by Business Object name and public ID.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="publicid">Specify the Business Object public ID.</param>
        /// <param name="foredit">Flag to get the edit mode version of a form. (optional)</param>
        /// <param name="formid">Specify the form ID if the default is not desired. (optional)</param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>MobileFormResponse</returns>
        public MobileFormResponse FormsGetMobileFormForBusObByNameAndPublicIdV1(string busobname, string publicid,
            bool? foredit = null, string formid = null, string lang = null, string locale = null)
        {
            return FormsGetMobileFormForBusObByNameAndPublicIdV1WithHttpInfo(busobname, publicid, foredit, formid, lang,
                locale).Data;
        }

        /// <summary>
        ///     Get mobile form by Business Object name and Public ID Operation that gets a mobile form for a specific Business
        ///     Object by Business Object name and public ID.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="publicid">Specify the Business Object public ID.</param>
        /// <param name="foredit">Flag to get the edit mode version of a form. (optional)</param>
        /// <param name="formid">Specify the form ID if the default is not desired. (optional)</param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>ApiResponse of MobileFormResponse</returns>
        private ApiResponse<MobileFormResponse> FormsGetMobileFormForBusObByNameAndPublicIdV1WithHttpInfo(
            string busobname, string publicid, bool? foredit = null, string formid = null, string lang = null,
            string locale = null)
        {
            // verify the required parameter 'busobname' is set
            if (busobname == null)
                throw new ApiException(400,
                    "Missing required parameter 'busobname' when calling FormsApi->FormsGetMobileFormForBusObByNameAndPublicIdV1");
            // verify the required parameter 'publicid' is set
            if (publicid == null)
                throw new ApiException(400,
                    "Missing required parameter 'publicid' when calling FormsApi->FormsGetMobileFormForBusObByNameAndPublicIdV1");

            var localVarPath = $"/api/V1/getmobileformforbusob/busobname/{busobname}/publicid/{publicid}";
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
            localVarPathParams.Add("publicid", Configuration.ApiClient.ParameterToString(publicid)); // path parameter
            if (foredit != null)
                localVarQueryParams.AddRange(
                    Configuration.ApiClient.ParameterToKeyValuePairs("", "foredit", foredit)); // query parameter
            if (formid != null)
                localVarQueryParams.AddRange(
                    Configuration.ApiClient.ParameterToKeyValuePairs("", "formid", formid)); // query parameter
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

            var exception = ExceptionFactory?.Invoke("FormsGetMobileFormForBusObByNameAndPublicIdV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<MobileFormResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (MobileFormResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MobileFormResponse)));
        }

        #endregion

        #region FormsGetMobileFormForBusObByNameAndRecIdV1

        /// <summary>
        ///     Get mobile form by Business Object name and record ID. Operation that gets a mobile form for a specific Business
        ///     Object by Business Object name and record ID.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="busobrecid">Specify the Business Object record ID.</param>
        /// <param name="foredit">Flag to get the edit mode version of a form. (optional)</param>
        /// <param name="formid">Specify the form ID if the default is not desired. (optional)</param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>MobileFormResponse</returns>
        public MobileFormResponse FormsGetMobileFormForBusObByNameAndRecIdV1(string busobname, string busobrecid,
            bool? foredit = null, string formid = null, string lang = null, string locale = null)
        {
            return FormsGetMobileFormForBusObByNameAndRecIdV1WithHttpInfo(busobname, busobrecid, foredit, formid, lang,
                locale).Data;
        }

        /// <summary>
        ///     Get mobile form by Business Object name and record ID. Operation that gets a mobile form for a specific Business
        ///     Object by Business Object name and record ID.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="busobrecid">Specify the Business Object record ID.</param>
        /// <param name="foredit">Flag to get the edit mode version of a form. (optional)</param>
        /// <param name="formid">Specify the form ID if the default is not desired. (optional)</param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>ApiResponse of MobileFormResponse</returns>
        private ApiResponse<MobileFormResponse> FormsGetMobileFormForBusObByNameAndRecIdV1WithHttpInfo(string busobname,
            string busobrecid, bool? foredit = null, string formid = null, string lang = null, string locale = null)
        {
            // verify the required parameter 'busobname' is set
            if (busobname == null)
                throw new ApiException(400,
                    "Missing required parameter 'busobname' when calling FormsApi->FormsGetMobileFormForBusObByNameAndRecIdV1");
            // verify the required parameter 'busobrecid' is set
            if (busobrecid == null)
                throw new ApiException(400,
                    "Missing required parameter 'busobrecid' when calling FormsApi->FormsGetMobileFormForBusObByNameAndRecIdV1");

            var localVarPath = $"/api/V1/getmobileformforbusob/busobname/{busobname}/busobrecid/{busobrecid}";
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
            localVarPathParams.Add("busobrecid",
                Configuration.ApiClient.ParameterToString(busobrecid)); // path parameter
            if (foredit != null)
                localVarQueryParams.AddRange(
                    Configuration.ApiClient.ParameterToKeyValuePairs("", "foredit", foredit)); // query parameter
            if (formid != null)
                localVarQueryParams.AddRange(
                    Configuration.ApiClient.ParameterToKeyValuePairs("", "formid", formid)); // query parameter
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

            var exception = ExceptionFactory?.Invoke("FormsGetMobileFormForBusObByNameAndRecIdV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<MobileFormResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (MobileFormResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MobileFormResponse)));
        }

        #endregion
    }
}