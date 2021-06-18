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
    public class ApprovalApi : BaseApi, IApprovalApi
    {
        #region Variables & Properties

        private static ApprovalApi _instance;

        private static readonly object Padlock = new();

        public static ApprovalApi Instance
        {
            get
            {
                lock (Padlock)
                {
                    return _instance ??= new ApprovalApi();
                }
            }
            set => _instance = value;
        }

        #endregion

        #region Constructors

        private ApprovalApi()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="ApprovalApi" /> class.
        /// </summary>
        /// <param name="basePath">An endpoint for Configuration </param>
        /// <returns></returns>
        public ApprovalApi(string basePath)
        {
            Configuration = new Configuration {BasePath = basePath};

            ExceptionFactory = Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="ApprovalApi" /> class
        ///     using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ApprovalApi(Configuration configuration = null)
        {
            Configuration = configuration ?? Configuration.Default;

            ExceptionFactory = Configuration.DefaultExceptionFactory;
        }

        #endregion

        #region ApprovalActionApprovalV1

        /// <summary>
        ///     Action an Approval Operation that actions an Approval Business Object. Use this method, passing either approve,
        ///     abstain or deny to update the Business Object&#39;s state
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="approvalRecId"></param>
        /// <param name="approvalAction"></param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>SaveResponse</returns>
        public SaveResponse ApprovalActionApprovalV1(string approvalRecId, string approvalAction, string lang = null,
            string locale = null)
        {
            return ApprovalActionApprovalV1WithHttpInfo(approvalRecId, approvalAction, lang, locale).Data;
        }

        /// <summary>
        ///     Action an Approval Operation that actions an Approval Business Object. Use this method, passing either approve,
        ///     abstain or deny to update the Business Object&#39;s state
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="approvalRecId"></param>
        /// <param name="approvalAction"></param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>ApiResponse of SaveResponse</returns>
        private ApiResponse<SaveResponse> ApprovalActionApprovalV1WithHttpInfo(string approvalRecId,
            string approvalAction, string lang = null, string locale = null)
        {
            // verify the required parameter 'approvalRecId' is set
            if (approvalRecId == null)
                throw new ApiException(400,
                    "Missing required parameter 'approvalRecId' when calling ApprovalApi->ApprovalActionApprovalV1");
            // verify the required parameter 'approvalAction' is set
            if (approvalAction == null)
                throw new ApiException(400,
                    "Missing required parameter 'approvalAction' when calling ApprovalApi->ApprovalActionApprovalV1");

            var varPath = $"/api/V1/approval/{approvalRecId}/{approvalAction}";
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

            localVarPathParams.Add("approvalRecId",
                Configuration.ApiClient.ParameterToString(approvalRecId)); // path parameter
            localVarPathParams.Add("approvalAction",
                Configuration.ApiClient.ParameterToString(approvalAction)); // path parameter
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
                Method.POST, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int) localVarResponse.StatusCode;

            var exception = ExceptionFactory?.Invoke("ApprovalActionApprovalV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<SaveResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (SaveResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SaveResponse)));
        }

        #endregion

        #region ApprovalGetApprovalByRecIdV1

        /// <summary>
        ///     Get Approval Operation that returns an Approval Business Object.  Use the provided links to action the Approval
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="approvalRecId"></param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>ApprovalReadResponse</returns>
        public ApprovalReadResponse ApprovalGetApprovalByRecIdV1(string approvalRecId, string lang = null,
            string locale = null)
        {
            return ApprovalGetApprovalByRecIdV1WithHttpInfo(approvalRecId, lang, locale).Data;
        }

        /// <summary>
        ///     Get Approval Operation that returns an Approval Business Object.  Use the provided links to action the Approval
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="approvalRecId"></param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>ApiResponse of ApprovalReadResponse</returns>
        private ApiResponse<ApprovalReadResponse> ApprovalGetApprovalByRecIdV1WithHttpInfo(string approvalRecId,
            string lang = null, string locale = null)
        {
            // verify the required parameter 'approvalRecId' is set
            if (approvalRecId == null)
                throw new ApiException(400,
                    "Missing required parameter 'approvalRecId' when calling ApprovalApi->ApprovalGetApprovalByRecIdV1");

            var varPath = $"/api/V1/approval/{approvalRecId}";
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

            localVarPathParams.Add("approvalRecId",
                Configuration.ApiClient.ParameterToString(approvalRecId)); // path parameter
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

            var exception = ExceptionFactory?.Invoke("ApprovalGetApprovalByRecIdV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<ApprovalReadResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (ApprovalReadResponse) Configuration.ApiClient.Deserialize(localVarResponse,
                    typeof(ApprovalReadResponse)));
        }

        #endregion

        #region ApprovalGetMyApprovalsV1

        /// <summary>
        ///     Get all waiting Approvals for the current user Operation that returns a list of Approval Business Objects that are
        ///     in a state of &#39;Waiting&#39; for the current user.  Use the provided links to action the Approval
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>ApprovalsResponse</returns>
        public ApprovalsResponse ApprovalGetMyApprovalsV1(string lang = null, string locale = null)
        {
            return ApprovalGetMyApprovalsV1WithHttpInfo(lang, locale).Data;
        }

        /// <summary>
        ///     Get all waiting Approvals for the current user Operation that returns a list of Approval Business Objects that are
        ///     in a state of &#39;Waiting&#39; for the current user.  Use the provided links to action the Approval
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>ApiResponse of ApprovalsResponse</returns>
        private ApiResponse<ApprovalsResponse> ApprovalGetMyApprovalsV1WithHttpInfo(string lang = null,
            string locale = null)
        {
            const string varPath = "/api/V1/getmyapprovals";
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

            var exception = ExceptionFactory?.Invoke("ApprovalGetMyApprovalsV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<ApprovalsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (ApprovalsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApprovalsResponse)));
        }

        #endregion ApprovalGetMyApprovalsV1

        #region ApprovalGetMyPendingApprovalsV1

        /// <summary>
        ///     Get all waiting approvals that were created by the current user Operation that returns a list of Approval Business
        ///     Objects that are in a state of &#39;Waiting&#39; that were created by the current user.  Use the provided links to
        ///     action the Approval
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>ApprovalsResponse</returns>
        public ApprovalsResponse ApprovalGetMyPendingApprovalsV1(string lang = null, string locale = null)
        {
            return ApprovalGetMyPendingApprovalsV1WithHttpInfo(lang, locale).Data;
        }

        /// <summary>
        ///     Get all waiting approvals that were created by the current user Operation that returns a list of Approval Business
        ///     Objects that are in a state of &#39;Waiting&#39; that were created by the current user.  Use the provided links to
        ///     action the Approval
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>ApiResponse of ApprovalsResponse</returns>
        private ApiResponse<ApprovalsResponse> ApprovalGetMyPendingApprovalsV1WithHttpInfo(string lang = null,
            string locale = null)
        {
            const string varPath = "/api/V1/getmypendingapprovals";
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

            var exception = ExceptionFactory?.Invoke("ApprovalGetMyPendingApprovalsV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<ApprovalsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (ApprovalsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApprovalsResponse)));
        }

        #endregion ApprovalGetMyPendingApprovalsV1
    }
}