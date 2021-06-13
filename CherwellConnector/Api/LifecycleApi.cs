
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
    public class LifecycleApi :BaseApi, ILifecycleApi
    {
        #region Variables & Properties
        
        private static LifecycleApi _instance;

        private static readonly object Padlock = new();
        
        public static LifecycleApi Instance
        {
            get
            {
                lock (Padlock)
                {
                    return _instance ??= new LifecycleApi();
                }
            }
            set => _instance = value;
        }
        
        #endregion

        #region Contructors

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
            Configuration = configuration ?? Configuration.Default;

            ExceptionFactory = Configuration.DefaultExceptionFactory;
        }

        #endregion

        #region LifecycleGetRecordStage

        /// <summary>
        /// Get current lifecycle stage for record Gets the current lifecycle stage of a business object record
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="recordId"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>RecordStatusResponse</returns>
        public RecordStatusResponse LifecycleGetRecordStage (string businessObjectDefinitionId, string recordId, string lang = null, string locale = null)
        {
             return LifecycleGetRecordStageWithHttpInfo(businessObjectDefinitionId, recordId, lang, locale).Data;
             
        }

        /// <summary>
        /// Get current lifecycle stage for record Gets the current lifecycle stage of a business object record
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="recordId"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of RecordStatusResponse</returns>
        private ApiResponse< RecordStatusResponse > LifecycleGetRecordStageWithHttpInfo (string businessObjectDefinitionId, string recordId, string lang = null, string locale = null)
        {
            // verify the required parameter 'businessObjectDefinitionId' is set
            if (businessObjectDefinitionId == null)
                throw new ApiException(400, "Missing required parameter 'businessObjectDefinitionId' when calling LifecycleApi->LifecycleGetRecordStage");
            // verify the required parameter 'recordId' is set
            if (recordId == null)
                throw new ApiException(400, "Missing required parameter 'recordId' when calling LifecycleApi->LifecycleGetRecordStage");

            var localVarPath = $"/api/V1/{businessObjectDefinitionId}/records/{recordId}/stage";
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

            localVarPathParams.Add("businessObjectDefinitionId", Configuration.ApiClient.ParameterToString(businessObjectDefinitionId)); // path parameter
            localVarPathParams.Add("recordId", Configuration.ApiClient.ParameterToString(recordId)); // path parameter
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

            var exception = ExceptionFactory?.Invoke("LifecycleGetRecordStage", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<RecordStatusResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (RecordStatusResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RecordStatusResponse)));
        }

        #endregion

        #region LifecycleGetRecordStatus

        /// <summary>
        /// Get current lifecycle status for record Gets the current lifecycle status of a business object record
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="recordId"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>RecordStatusResponse</returns>
        public RecordStatusResponse LifecycleGetRecordStatus (string businessObjectDefinitionId, string recordId, string lang = null, string locale = null)
        {
             return LifecycleGetRecordStatusWithHttpInfo(businessObjectDefinitionId, recordId, lang, locale).Data;
        }

        /// <summary>
        /// Get current lifecycle status for record Gets the current lifecycle status of a business object record
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="recordId"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of RecordStatusResponse</returns>
        private ApiResponse< RecordStatusResponse > LifecycleGetRecordStatusWithHttpInfo (string businessObjectDefinitionId, string recordId, string lang = null, string locale = null)
        {
            // verify the required parameter 'businessObjectDefinitionId' is set
            if (businessObjectDefinitionId == null)
                throw new ApiException(400, "Missing required parameter 'businessObjectDefinitionId' when calling LifecycleApi->LifecycleGetRecordStatus");
            // verify the required parameter 'recordId' is set
            if (recordId == null)
                throw new ApiException(400, "Missing required parameter 'recordId' when calling LifecycleApi->LifecycleGetRecordStatus");

            var localVarPath = $"/api/V1/{businessObjectDefinitionId}/records/{recordId}/status";
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

            localVarPathParams.Add("businessObjectDefinitionId", Configuration.ApiClient.ParameterToString(businessObjectDefinitionId)); // path parameter
            localVarPathParams.Add("recordId", Configuration.ApiClient.ParameterToString(recordId)); // path parameter
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

            var exception = ExceptionFactory?.Invoke("LifecycleGetRecordStatus", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<RecordStatusResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (RecordStatusResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RecordStatusResponse)));
        }

        #endregion

        #region LifecycleGetStages

         /// <summary>
        /// Get lifecycle stages Gets all of the stages on the lifecycle for a Business Object
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>LifecycleGetStages</returns>
        public StagesResponse LifecycleGetStages (string businessObjectDefinitionId, string lang = null, string locale = null)
        {
             return LifecycleGetStagesWithHttpInfo(businessObjectDefinitionId, lang, locale).Data;
        }

        /// <summary>
        /// Get lifecycle stages Gets all of the stages on the lifecycle for a Business Object
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of LifecycleGetStages</returns>
        private ApiResponse< StagesResponse > LifecycleGetStagesWithHttpInfo (string businessObjectDefinitionId, string lang = null, string locale = null)
        {
            // verify the required parameter 'businessObjectDefinitionId' is set
            if (businessObjectDefinitionId == null)
                throw new ApiException(400, "Missing required parameter 'businessObjectDefinitionId' when calling LifecycleApi->LifecycleGetStages");

            var localVarPath = $"/api/V1/{businessObjectDefinitionId}/lifecycle/stages";
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

            localVarPathParams.Add("businessObjectDefinitionId", Configuration.ApiClient.ParameterToString(businessObjectDefinitionId)); // path parameter
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

            var exception = ExceptionFactory?.Invoke("LifecycleGetStages", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<StagesResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (StagesResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StagesResponse)));
        }


        #endregion

        #region LifecycleGetStatuses

        /// <summary>
        /// Get lifecycle statuses Gets all of the statuses on the lifecycle for a Business Object
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>StatusesResponse</returns>
        public StatusesResponse LifecycleGetStatuses (string businessObjectDefinitionId, string lang = null, string locale = null)
        {
             return LifecycleGetStatusesWithHttpInfo(businessObjectDefinitionId, lang, locale).Data;
        }

        /// <summary>
        /// Get lifecycle statuses Gets all of the statuses on the lifecycle for a Business Object
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of StatusesResponse</returns>
        private ApiResponse< StatusesResponse > LifecycleGetStatusesWithHttpInfo (string businessObjectDefinitionId, string lang = null, string locale = null)
        {
            // verify the required parameter 'businessObjectDefinitionId' is set
            if (businessObjectDefinitionId == null)
                throw new ApiException(400, "Missing required parameter 'businessObjectDefinitionId' when calling LifecycleApi->LifecycleGetStatuses");

            var localVarPath = $"/api/V1/{businessObjectDefinitionId}/lifecycle/statuses";
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

            localVarPathParams.Add("businessObjectDefinitionId", Configuration.ApiClient.ParameterToString(businessObjectDefinitionId)); // path parameter
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

            var exception = ExceptionFactory?.Invoke("LifecycleGetStatuses", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<StatusesResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (StatusesResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StatusesResponse)));
        }


        #endregion

        #region LifecycleGetTransitionOptions

        /// <summary>
        /// Get lifecycle transition options for record Gets the lifecycle transition options currently available to a business object record
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="recordId"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TransitionOptionsResponse</returns>
        public TransitionOptionsResponse LifecycleGetTransitionOptions (string businessObjectDefinitionId, string recordId, string lang = null, string locale = null)
        {
             return LifecycleGetTransitionOptionsWithHttpInfo(businessObjectDefinitionId, recordId, lang, locale).Data;
        }

        /// <summary>
        /// Get lifecycle transition options for record Gets the lifecycle transition options currently available to a business object record
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="recordId"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TransitionOptionsResponse</returns>
        private ApiResponse< TransitionOptionsResponse > LifecycleGetTransitionOptionsWithHttpInfo (string businessObjectDefinitionId, string recordId, string lang = null, string locale = null)
        {
            // verify the required parameter 'businessObjectDefinitionId' is set
            if (businessObjectDefinitionId == null)
                throw new ApiException(400, "Missing required parameter 'businessObjectDefinitionId' when calling LifecycleApi->LifecycleGetTransitionOptions");
            // verify the required parameter 'recordId' is set
            if (recordId == null)
                throw new ApiException(400, "Missing required parameter 'recordId' when calling LifecycleApi->LifecycleGetTransitionOptions");

            var localVarPath = $"/api/V1/{businessObjectDefinitionId}/records/{recordId}/transitionOptions";
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

            localVarPathParams.Add("businessObjectDefinitionId", Configuration.ApiClient.ParameterToString(businessObjectDefinitionId)); // path parameter
            localVarPathParams.Add("recordId", Configuration.ApiClient.ParameterToString(recordId)); // path parameter
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

            var exception = ExceptionFactory?.Invoke("LifecycleGetTransitionOptions", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<TransitionOptionsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (TransitionOptionsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransitionOptionsResponse)));
        }

        #endregion

        #region LifecycleGetTransitions

         /// <summary>
        /// Get lifecycle transitions Gets all of the transitions on the lifecycle for a Business Object
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TransitionsResponse</returns>
        public TransitionsResponse LifecycleGetTransitions (string businessObjectDefinitionId, string lang = null, string locale = null)
        {
             return LifecycleGetTransitionsWithHttpInfo(businessObjectDefinitionId, lang, locale).Data;
        }

        /// <summary>
        /// Get lifecycle transitions Gets all of the transitions on the lifecycle for a Business Object
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TransitionsResponse</returns>
        private ApiResponse< TransitionsResponse > LifecycleGetTransitionsWithHttpInfo (string businessObjectDefinitionId, string lang = null, string locale = null)
        {
            // verify the required parameter 'businessObjectDefinitionId' is set
            if (businessObjectDefinitionId == null)
                throw new ApiException(400, "Missing required parameter 'businessObjectDefinitionId' when calling LifecycleApi->LifecycleGetTransitions");

            var localVarPath = $"/api/V1/{businessObjectDefinitionId}/lifecycle/transitions";
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

            localVarPathParams.Add("businessObjectDefinitionId", Configuration.ApiClient.ParameterToString(businessObjectDefinitionId)); // path parameter
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

            var exception = ExceptionFactory?.Invoke("LifecycleGetTransitions", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<TransitionsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (TransitionsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransitionsResponse)));
        }
        
        #endregion

        #region LifecycleTransitionRecord

        /// <summary>
        /// Transition a business object record Transitions a business object record in to the specified lifecycle status
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="recordId"></param>
        /// <param name="transitionRecordRequest"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ResponseBase</returns>
        public ResponseBase LifecycleTransitionRecord (string businessObjectDefinitionId, string recordId, TransitionRecordRequest transitionRecordRequest, string lang = null, string locale = null)
        {
             return LifecycleTransitionRecordWithHttpInfo(businessObjectDefinitionId, recordId, transitionRecordRequest, lang, locale).Data;
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
        /// <returns>ApiResponse of ResponseBase</returns>
        private ApiResponse< ResponseBase > LifecycleTransitionRecordWithHttpInfo (string businessObjectDefinitionId, string recordId, TransitionRecordRequest transitionRecordRequest, string lang = null, string locale = null)
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

            var localVarPath = $"/api/V1/{businessObjectDefinitionId}/records/{recordId}/transitions";
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

            localVarPathParams.Add("businessObjectDefinitionId", Configuration.ApiClient.ParameterToString(businessObjectDefinitionId)); // path parameter
            localVarPathParams.Add("recordId", Configuration.ApiClient.ParameterToString(recordId)); // path parameter
            if (lang != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter
            if (transitionRecordRequest.GetType() != typeof(byte[]))
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
            var localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int) localVarResponse.StatusCode;

            var exception = ExceptionFactory?.Invoke("LifecycleTransitionRecord", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<ResponseBase>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (ResponseBase) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ResponseBase)));
        }

        #endregion
    }
}
