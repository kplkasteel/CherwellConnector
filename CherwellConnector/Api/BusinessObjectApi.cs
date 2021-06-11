using System.Diagnostics;
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
    public class TrebuchetBusinessObjectApi : TrebuchetBaseApi, ITrebuchetBusinessObjectApi
    {
        #region Variables & Properties
        
        private static TrebuchetBusinessObjectApi _instance;

        private static readonly object Padlock = new();
        
        public static TrebuchetBusinessObjectApi Instance
        {
            get
            {
                lock (Padlock)
                {
                    return _instance ??= new TrebuchetBusinessObjectApi();
                }
            }
            set => _instance = value;
        }
        
        #endregion

        #region Constructors
        
        /// <summary>
        /// Initializes a new instance of the <see cref="TrebuchetBusinessObjectApi"/> class.
        /// </summary>
        /// <returns></returns>
        private TrebuchetBusinessObjectApi()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="TrebuchetBusinessObjectApi"/> class.
        /// </summary>
        /// <param name="basePath">An endpoint for Configuration </param>
        /// <returns></returns>
        public TrebuchetBusinessObjectApi(string basePath)
        {
            Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = Configuration.DefaultExceptionFactory;
        }   

        /// <summary>
        /// Initializes a new instance of the <see cref="TrebuchetBusinessObjectApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TrebuchetBusinessObjectApi(Configuration configuration = null)
        {
            Configuration = configuration ?? Configuration.Default;

            ExceptionFactory = Configuration.DefaultExceptionFactory;
        }
        

        #endregion

        #region BusinessObjectDeleteBusinessObjectBatchV1

         /// <summary>
        /// Delete Business Objects in a batch Operation to delete a batch of Business Objects.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Specify an array of Business Object IDs and record IDs or public IDs. Use a flag to stop on error or continue on error.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsBusinessObjectBatchDeleteResponse</returns>
        public BatchDeleteResponse BusinessObjectDeleteBusinessObjectBatchV1 (BatchDeleteRequest request, string lang = null, string locale = null)
        {
             return BusinessObjectDeleteBusinessObjectBatchV1WithHttpInfo(request, lang, locale).Data;
        }

        /// <summary>
        /// Delete Business Objects in a batch Operation to delete a batch of Business Objects.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Specify an array of Business Object IDs and record IDs or public IDs. Use a flag to stop on error or continue on error.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsBusinessObjectBatchDeleteResponse</returns>
        private ApiResponse< BatchDeleteResponse > BusinessObjectDeleteBusinessObjectBatchV1WithHttpInfo (BatchDeleteRequest request, string lang = null, string locale = null)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling BusinessObjectApi->BusinessObjectDeleteBusinessObjectBatchV1");

            const string varPath = "/api/V1/deletebusinessobjectbatch";
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

            var exception = ExceptionFactory?.Invoke("BusinessObjectDeleteBusinessObjectBatchV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<BatchDeleteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (BatchDeleteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BatchDeleteResponse)));
        }

        #endregion

        #region BusinessObjectDeleteBusinessObjectByPublicIdV1
        
        /// <summary>
        /// Delete a Business Object by public ID Operation to delete a Business Object by Business Object ID.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobid">Specify the Business Object ID.</param>
        /// <param name="publicid">Specify the Business Object public ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsBusinessObjectDeleteResponse</returns>
        public DeleteResponse BusinessObjectDeleteBusinessObjectByPublicIdV1 (string busobid, string publicid, string lang = null, string locale = null)
        {
             return BusinessObjectDeleteBusinessObjectByPublicIdV1WithHttpInfo(busobid, publicid, lang, locale).Data;
        }

        /// <summary>
        /// Delete a Business Object by public ID Operation to delete a Business Object by Business Object ID.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobid">Specify the Business Object ID.</param>
        /// <param name="publicid">Specify the Business Object public ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsBusinessObjectDeleteResponse</returns>
        private ApiResponse< DeleteResponse > BusinessObjectDeleteBusinessObjectByPublicIdV1WithHttpInfo (string busobid, string publicid, string lang = null, string locale = null)
        {
            // verify the required parameter 'busobid' is set
            if (busobid == null)
                throw new ApiException(400, "Missing required parameter 'busobid' when calling BusinessObjectApi->BusinessObjectDeleteBusinessObjectByPublicIdV1");
            // verify the required parameter 'publicid' is set
            if (publicid == null)
                throw new ApiException(400, "Missing required parameter 'publicid' when calling BusinessObjectApi->BusinessObjectDeleteBusinessObjectByPublicIdV1");

            var varPath = $"/api/V1/deletebusinessobject/busobid/{busobid}/publicid/{publicid}";
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
                Method.DELETE, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int) localVarResponse.StatusCode;

            var exception = ExceptionFactory?.Invoke("BusinessObjectDeleteBusinessObjectByPublicIdV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<DeleteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (DeleteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeleteResponse)));
        }
        
        #endregion

        #region BusinessObjectDeleteBusinessObjectByRecIdV1

         /// <summary>
        /// Delete a Business Object by record ID Operation to delete a single Business Object.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobid">Specify the Business Object ID.</param>
        /// <param name="busobrecid"> Specify the Business Object record ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsBusinessObjectDeleteResponse</returns>
        public DeleteResponse BusinessObjectDeleteBusinessObjectByRecIdV1 (string busobid, string busobrecid, string lang = null, string locale = null)
        {
             return BusinessObjectDeleteBusinessObjectByRecIdV1WithHttpInfo(busobid, busobrecid, lang, locale).Data;
        }

        /// <summary>
        /// Delete a Business Object by record ID Operation to delete a single Business Object.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobid">Specify the Business Object ID.</param>
        /// <param name="busobrecid"> Specify the Business Object record ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsBusinessObjectDeleteResponse</returns>
        private ApiResponse< DeleteResponse > BusinessObjectDeleteBusinessObjectByRecIdV1WithHttpInfo (string busobid, string busobrecid, string lang = null, string locale = null)
        {
            // verify the required parameter 'busobid' is set
            if (busobid == null)
                throw new ApiException(400, "Missing required parameter 'busobid' when calling BusinessObjectApi->BusinessObjectDeleteBusinessObjectByRecIdV1");
            // verify the required parameter 'busobrecid' is set
            if (busobrecid == null)
                throw new ApiException(400, "Missing required parameter 'busobrecid' when calling BusinessObjectApi->BusinessObjectDeleteBusinessObjectByRecIdV1");

            var varPath = $"/api/V1/deletebusinessobject/busobid/{busobid}/busobrecid/{busobrecid}";
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
            var localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(varPath,
                Method.DELETE, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int) localVarResponse.StatusCode;

            var exception = ExceptionFactory?.Invoke("BusinessObjectDeleteBusinessObjectByRecIdV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<DeleteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x =>
                {
                    Debug.Assert(x.Value != null, "x.Value != null");
                    return x.Value.ToString();
                }),
                (DeleteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeleteResponse)));
        }

        #endregion

        #region BusinessObjectDeleteRelatedBusinessObjectByPublicIdV1
        
        /// <summary>
        /// Delete a related Business Object by public ID Operation to delete a related Business Object. (Use \&quot;Unlink Related Business Object\&quot; to unlink two Business Objects rather that deleting the related Business Object.)
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="parentbusobid">Specify the Business Object ID for the parent Business Object.</param>
        /// <param name="parentbusobrecid">Specify the record ID for the parent Business Object</param>
        /// <param name="relationshipid">Specify the Relationship ID for the related Business Object you want to delete.</param>
        /// <param name="publicid">Specify the public ID for the related Business Object you want to delete. Use only for Business Objects with unique public IDs. Use \&quot;Delete a related Business Object by record ID\&quot; when public IDs are not unique.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsSearchesRelatedBusinessObjectResponse</returns>
        public TrebuchetWebApiDataContractsSearchesRelatedBusinessObjectResponse BusinessObjectDeleteRelatedBusinessObjectByPublicIdV1 (string parentbusobid, string parentbusobrecid, string relationshipid, string publicid, string lang = null, string locale = null)
        {
             return BusinessObjectDeleteRelatedBusinessObjectByPublicIdV1WithHttpInfo(parentbusobid, parentbusobrecid, relationshipid, publicid, lang, locale).Data;
        }

        /// <summary>
        /// Delete a related Business Object by public ID Operation to delete a related Business Object. (Use \&quot;Unlink Related Business Object\&quot; to unlink two Business Objects rather that deleting the related Business Object.)
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="parentbusobid">Specify the Business Object ID for the parent Business Object.</param>
        /// <param name="parentbusobrecid">Specify the record ID for the parent Business Object</param>
        /// <param name="relationshipid">Specify the Relationship ID for the related Business Object you want to delete.</param>
        /// <param name="publicid">Specify the public ID for the related Business Object you want to delete. Use only for Business Objects with unique public IDs. Use \&quot;Delete a related Business Object by record ID\&quot; when public IDs are not unique.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsSearchesRelatedBusinessObjectResponse</returns>
        private ApiResponse< TrebuchetWebApiDataContractsSearchesRelatedBusinessObjectResponse > BusinessObjectDeleteRelatedBusinessObjectByPublicIdV1WithHttpInfo (string parentbusobid, string parentbusobrecid, string relationshipid, string publicid, string lang = null, string locale = null)
        {
            // verify the required parameter 'parentbusobid' is set
            if (parentbusobid == null)
                throw new ApiException(400, "Missing required parameter 'parentbusobid' when calling BusinessObjectApi->BusinessObjectDeleteRelatedBusinessObjectByPublicIdV1");
            // verify the required parameter 'parentbusobrecid' is set
            if (parentbusobrecid == null)
                throw new ApiException(400, "Missing required parameter 'parentbusobrecid' when calling BusinessObjectApi->BusinessObjectDeleteRelatedBusinessObjectByPublicIdV1");
            // verify the required parameter 'relationshipid' is set
            if (relationshipid == null)
                throw new ApiException(400, "Missing required parameter 'relationshipid' when calling BusinessObjectApi->BusinessObjectDeleteRelatedBusinessObjectByPublicIdV1");
            // verify the required parameter 'publicid' is set
            if (publicid == null)
                throw new ApiException(400, "Missing required parameter 'publicid' when calling BusinessObjectApi->BusinessObjectDeleteRelatedBusinessObjectByPublicIdV1");

            var localVarPath = $"/api/V1/deleterelatedbusinessobject/parentbusobid/{parentbusobid}/parentbusobrecid/{parentbusobrecid}/relationshipid/{relationshipid}/publicid/{publicid}";
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

            localVarPathParams.Add("parentbusobid", Configuration.ApiClient.ParameterToString(parentbusobid)); // path parameter
            localVarPathParams.Add("parentbusobrecid", Configuration.ApiClient.ParameterToString(parentbusobrecid)); // path parameter
            localVarPathParams.Add("relationshipid", Configuration.ApiClient.ParameterToString(relationshipid)); // path parameter
            localVarPathParams.Add("publicid", Configuration.ApiClient.ParameterToString(publicid)); // path parameter
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

            var exception = ExceptionFactory?.Invoke("BusinessObjectDeleteRelatedBusinessObjectByPublicIdV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<TrebuchetWebApiDataContractsSearchesRelatedBusinessObjectResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (TrebuchetWebApiDataContractsSearchesRelatedBusinessObjectResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TrebuchetWebApiDataContractsSearchesRelatedBusinessObjectResponse)));
        }
        
        #endregion

        #region BusinessObjectDeleteRelatedBusinessObjectByRecIdV1

         /// <summary>
        /// Delete a related Business Object by record ID Operation to delete a related Business Object. (Use \&quot;Unlink Related Business Object\&quot; to unlink two Business Objects rather that deleting the related Business Object.)
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="parentbusobid">Specify the Business Object ID for the parent Business Object.</param>
        /// <param name="parentbusobrecid">Specify the record ID for the parent Business Object</param>
        /// <param name="relationshipid">Specify the Relationship ID for the related Business Object you want to delete.</param>
        /// <param name="busobrecid">Specify the record ID for the related Business Object you want to delete.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsSearchesRelatedBusinessObjectResponse</returns>
        public TrebuchetWebApiDataContractsSearchesRelatedBusinessObjectResponse BusinessObjectDeleteRelatedBusinessObjectByRecIdV1 (string parentbusobid, string parentbusobrecid, string relationshipid, string busobrecid, string lang = null, string locale = null)
        {
             return BusinessObjectDeleteRelatedBusinessObjectByRecIdV1WithHttpInfo(parentbusobid, parentbusobrecid, relationshipid, busobrecid, lang, locale).Data;
        }

        /// <summary>
        /// Delete a related Business Object by record ID Operation to delete a related Business Object. (Use \&quot;Unlink Related Business Object\&quot; to unlink two Business Objects rather that deleting the related Business Object.)
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="parentbusobid">Specify the Business Object ID for the parent Business Object.</param>
        /// <param name="parentbusobrecid">Specify the record ID for the parent Business Object</param>
        /// <param name="relationshipid">Specify the Relationship ID for the related Business Object you want to delete.</param>
        /// <param name="busobrecid">Specify the record ID for the related Business Object you want to delete.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsSearchesRelatedBusinessObjectResponse</returns>
        private ApiResponse< TrebuchetWebApiDataContractsSearchesRelatedBusinessObjectResponse > BusinessObjectDeleteRelatedBusinessObjectByRecIdV1WithHttpInfo (string parentbusobid, string parentbusobrecid, string relationshipid, string busobrecid, string lang = null, string locale = null)
        {
            // verify the required parameter 'parentbusobid' is set
            if (parentbusobid == null)
                throw new ApiException(400, "Missing required parameter 'parentbusobid' when calling BusinessObjectApi->BusinessObjectDeleteRelatedBusinessObjectByRecIdV1");
            // verify the required parameter 'parentbusobrecid' is set
            if (parentbusobrecid == null)
                throw new ApiException(400, "Missing required parameter 'parentbusobrecid' when calling BusinessObjectApi->BusinessObjectDeleteRelatedBusinessObjectByRecIdV1");
            // verify the required parameter 'relationshipid' is set
            if (relationshipid == null)
                throw new ApiException(400, "Missing required parameter 'relationshipid' when calling BusinessObjectApi->BusinessObjectDeleteRelatedBusinessObjectByRecIdV1");
            // verify the required parameter 'busobrecid' is set
            if (busobrecid == null)
                throw new ApiException(400, "Missing required parameter 'busobrecid' when calling BusinessObjectApi->BusinessObjectDeleteRelatedBusinessObjectByRecIdV1");

            var varPath = $"/api/V1/deleterelatedbusinessobject/parentbusobid/{parentbusobid}/parentbusobrecid/{parentbusobrecid}/relationshipid/{relationshipid}/busobrecid/{busobrecid}";
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

            localVarPathParams.Add("parentbusobid", Configuration.ApiClient.ParameterToString(parentbusobid)); // path parameter
            localVarPathParams.Add("parentbusobrecid", Configuration.ApiClient.ParameterToString(parentbusobrecid)); // path parameter
            localVarPathParams.Add("relationshipid", Configuration.ApiClient.ParameterToString(relationshipid)); // path parameter
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
            var localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(varPath,
                Method.DELETE, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int) localVarResponse.StatusCode;

            var exception = ExceptionFactory?.Invoke("BusinessObjectDeleteRelatedBusinessObjectByRecIdV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<TrebuchetWebApiDataContractsSearchesRelatedBusinessObjectResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (TrebuchetWebApiDataContractsSearchesRelatedBusinessObjectResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TrebuchetWebApiDataContractsSearchesRelatedBusinessObjectResponse)));
        }

        #endregion

        #region BusinessObjectFieldValuesLookupV1
            
        /// <summary>
        /// Get lookup values for fields Operation to get potentially valid values for Business Object fields.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object that specifies the Business Object and fields for which values are to be returned.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsBusinessObjectFieldValuesLookupResponse</returns>
        public FieldValuesLookupResponse BusinessObjectFieldValuesLookupV1 (FieldValuesLookupRequest request, string lang = null, string locale = null)
        {
             return BusinessObjectFieldValuesLookupV1WithHttpInfo(request, lang, locale).Data;
        }

        /// <summary>
        /// Get lookup values for fields Operation to get potentially valid values for Business Object fields.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object that specifies the Business Object and fields for which values are to be returned.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsBusinessObjectFieldValuesLookupResponse</returns>
        private ApiResponse< FieldValuesLookupResponse > BusinessObjectFieldValuesLookupV1WithHttpInfo (FieldValuesLookupRequest request, string lang = null, string locale = null)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling BusinessObjectApi->BusinessObjectFieldValuesLookupV1");

            const string varPath = "/api/V1/fieldvalueslookup";
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

            var exception = ExceptionFactory?.Invoke("BusinessObjectFieldValuesLookupV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<FieldValuesLookupResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (FieldValuesLookupResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FieldValuesLookupResponse)));
        }
        

        #endregion

        #region BusinessObjectGetActivitiesV1

         /// <summary>
        /// Retrieve all activities for a business object Operation to retrieve all activities for a business object. Activities are mapped to history tracking business objects.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobid">Specify the Business Object ID.</param>
        /// <param name="busobrecid">Specify the Business Object record ID.</param>
        /// <param name="pageSize">Specify the number of rows to return per page. Maximum value is 2000 per page.</param>
        /// <param name="pageNumber">Specify the page number of the result set to return. (optional)</param>
        /// <param name="activityType">The category of activities to retrieve. Will default to All if not specified. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>List&lt;TrebuchetWebApiDataContractsBusinessObjectBusObActivity&gt;</returns>
        public List<BusObActivity> BusinessObjectGetActivitiesV1 (string busobid, string busobrecid, int? pageSize, int? pageNumber = null, string activityType = null, string lang = null, string locale = null)
        {
             return BusinessObjectGetActivitiesV1WithHttpInfo(busobid, busobrecid, pageSize, pageNumber, activityType, lang, locale).Data;
        }

        /// <summary>
        /// Retrieve all activities for a business object Operation to retrieve all activities for a business object. Activities are mapped to history tracking business objects.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobid">Specify the Business Object ID.</param>
        /// <param name="busobrecid">Specify the Business Object record ID.</param>
        /// <param name="pageSize">Specify the number of rows to return per page. Maximum value is 2000 per page.</param>
        /// <param name="pageNumber">Specify the page number of the result set to return. (optional)</param>
        /// <param name="activityType">The category of activities to retrieve. Will default to All if not specified. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of List&lt;TrebuchetWebApiDataContractsBusinessObjectBusObActivity&gt;</returns>
        private ApiResponse< List<BusObActivity> > BusinessObjectGetActivitiesV1WithHttpInfo (string busobid, string busobrecid, int? pageSize, int? pageNumber = null, string activityType = null, string lang = null, string locale = null)
        {
            // verify the required parameter 'busobid' is set
            if (busobid == null)
                throw new ApiException(400, "Missing required parameter 'busobid' when calling BusinessObjectApi->BusinessObjectGetActivitiesV1");
            // verify the required parameter 'busobrecid' is set
            if (busobrecid == null)
                throw new ApiException(400, "Missing required parameter 'busobrecid' when calling BusinessObjectApi->BusinessObjectGetActivitiesV1");
            // verify the required parameter 'pageSize' is set
            if (pageSize == null)
                throw new ApiException(400, "Missing required parameter 'pageSize' when calling BusinessObjectApi->BusinessObjectGetActivitiesV1");

            var varPath = $"/api/V1/getactivities/busobid/{busobid}/busobrecid/{busobrecid}/pagesize/{pageSize}";
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
            localVarPathParams.Add("busobrecid", Configuration.ApiClient.ParameterToString(busobrecid)); // path parameter
            localVarPathParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // path parameter
            if (pageNumber != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "pageNumber", pageNumber)); // query parameter
            if (activityType != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "activityType", activityType)); // query parameter
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

            var exception = ExceptionFactory?.Invoke("BusinessObjectGetActivitiesV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<List<BusObActivity>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (List<BusObActivity>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<BusObActivity>)));
        }

        #endregion

        #region BusinessObjectGetBusinessObjectAttachmentByAttachmentIdV1

         /// <summary>
        /// Get an imported Business Object attachment Operation to get a Business Object attachment that has been imported into the system.  HTTP Range Header can be used but is optional.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="attachmentid">Specify the internal ID of the attachment record that contains information about the imported file.</param>
        /// <param name="busobid">Specify the Business Object ID.</param>
        /// <param name="busobrecid">Specify the Business Object record ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>byte[]</returns>
        public byte[] BusinessObjectGetBusinessObjectAttachmentByAttachmentIdV1 (string attachmentid, string busobid, string busobrecid, string lang = null, string locale = null)
        {
             return BusinessObjectGetBusinessObjectAttachmentByAttachmentIdV1WithHttpInfo(attachmentid, busobid, busobrecid, lang, locale).Data;
            
        }

        /// <summary>
        /// Get an imported Business Object attachment Operation to get a Business Object attachment that has been imported into the system.  HTTP Range Header can be used but is optional.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="attachmentid">Specify the internal ID of the attachment record that contains information about the imported file.</param>
        /// <param name="busobid">Specify the Business Object ID.</param>
        /// <param name="busobrecid">Specify the Business Object record ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of byte[]</returns>
        private ApiResponse< byte[] > BusinessObjectGetBusinessObjectAttachmentByAttachmentIdV1WithHttpInfo (string attachmentid, string busobid, string busobrecid, string lang = null, string locale = null)
        {
            // verify the required parameter 'attachmentid' is set
            if (attachmentid == null)
                throw new ApiException(400, "Missing required parameter 'attachmentid' when calling BusinessObjectApi->BusinessObjectGetBusinessObjectAttachmentByAttachmentIdV1");
            // verify the required parameter 'busobid' is set
            if (busobid == null)
                throw new ApiException(400, "Missing required parameter 'busobid' when calling BusinessObjectApi->BusinessObjectGetBusinessObjectAttachmentByAttachmentIdV1");
            // verify the required parameter 'busobrecid' is set
            if (busobrecid == null)
                throw new ApiException(400, "Missing required parameter 'busobrecid' when calling BusinessObjectApi->BusinessObjectGetBusinessObjectAttachmentByAttachmentIdV1");

            var varPath = $"/api/V1/getbusinessobjectattachment/attachmentid/{attachmentid}/busobid/{busobid}/busobrecid/{busobrecid}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();

            // to determine the Content-Type header
            var localVarHttpContentTypes = Array.Empty<string>();
            var localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            var localVarHttpHeaderAccepts = new[] {
                "application/octet-stream"
            };
            var localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            localVarPathParams.Add("attachmentid", Configuration.ApiClient.ParameterToString(attachmentid)); // path parameter
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
            var localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(varPath,
                Method.GET, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int) localVarResponse.StatusCode;

            var exception = ExceptionFactory?.Invoke("BusinessObjectGetBusinessObjectAttachmentByAttachmentIdV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<byte[]>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (byte[]) Configuration.ApiClient.Deserialize(localVarResponse, typeof(byte[])));
        }
    
        #endregion

        #region BusinessObjectGetBusinessObjectAttachmentsByIdAndPublicIdV1

         /// <summary>
        /// Get attachments by Business Object public ID Operation to get attachments for a Business Object by Business Object ID and public ID.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobid">Specify the Business Object ID.</param>
        /// <param name="publicid">Specify the Business Object public ID for the record that contains the attachments.</param>
        /// <param name="type">Record attachment type: &lt;/br&gt;&lt;/br&gt;None - Not applicable to the REST API. &lt;/br&gt;&lt;/br&gt;File - Linked files. &lt;/br&gt;&lt;/br&gt;FileManagerFile - Imported files.&lt;/br&gt;&lt;/br&gt;BusOb - Attached Business Objects. &lt;/br&gt;&lt;/br&gt;History - Information about the attachment, if any is available. For example, an e-mail message may store the name of an attachment sent.&lt;/br&gt;&lt;/br&gt;Other - Not applicable to the REST API. &lt;/br&gt;</param>
        /// <param name="attachmenttype">For file types, select the type of attachment: &lt;/br&gt;&lt;/br&gt;Imported - Attachment was imported into database. &lt;/br&gt;&lt;/br&gt;Linked - Attachment is linked to an external file. &lt;/br&gt;&lt;/br&gt;URL - Attachment is a URL.</param>
        /// <param name="includelinks">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsBusinessObjectAttachmentsResponse</returns>
        public AttachmentsResponse BusinessObjectGetBusinessObjectAttachmentsByIdAndPublicIdV1 (string busobid, string publicid, string type, string attachmenttype, bool? includelinks = null, string lang = null, string locale = null)
        {
             return BusinessObjectGetBusinessObjectAttachmentsByIdAndPublicIdV1WithHttpInfo(busobid, publicid, type, attachmenttype, includelinks, lang, locale).Data;
        }

        /// <summary>
        /// Get attachments by Business Object public ID Operation to get attachments for a Business Object by Business Object ID and public ID.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobid">Specify the Business Object ID.</param>
        /// <param name="publicid">Specify the Business Object public ID for the record that contains the attachments.</param>
        /// <param name="type">Record attachment type: &lt;/br&gt;&lt;/br&gt;None - Not applicable to the REST API. &lt;/br&gt;&lt;/br&gt;File - Linked files. &lt;/br&gt;&lt;/br&gt;FileManagerFile - Imported files.&lt;/br&gt;&lt;/br&gt;BusOb - Attached Business Objects. &lt;/br&gt;&lt;/br&gt;History - Information about the attachment, if any is available. For example, an e-mail message may store the name of an attachment sent.&lt;/br&gt;&lt;/br&gt;Other - Not applicable to the REST API. &lt;/br&gt;</param>
        /// <param name="attachmenttype">For file types, select the type of attachment: &lt;/br&gt;&lt;/br&gt;Imported - Attachment was imported into database. &lt;/br&gt;&lt;/br&gt;Linked - Attachment is linked to an external file. &lt;/br&gt;&lt;/br&gt;URL - Attachment is a URL.</param>
        /// <param name="includelinks">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsBusinessObjectAttachmentsResponse</returns>
        private ApiResponse< AttachmentsResponse > BusinessObjectGetBusinessObjectAttachmentsByIdAndPublicIdV1WithHttpInfo (string busobid, string publicid, string type, string attachmenttype, bool? includelinks = null, string lang = null, string locale = null)
        {
            // verify the required parameter 'busobid' is set
            if (busobid == null)
                throw new ApiException(400, "Missing required parameter 'busobid' when calling BusinessObjectApi->BusinessObjectGetBusinessObjectAttachmentsByIdAndPublicIdV1");
            // verify the required parameter 'publicid' is set
            if (publicid == null)
                throw new ApiException(400, "Missing required parameter 'publicid' when calling BusinessObjectApi->BusinessObjectGetBusinessObjectAttachmentsByIdAndPublicIdV1");
            // verify the required parameter 'type' is set
            if (type == null)
                throw new ApiException(400, "Missing required parameter 'type' when calling BusinessObjectApi->BusinessObjectGetBusinessObjectAttachmentsByIdAndPublicIdV1");
            // verify the required parameter 'attachmenttype' is set
            if (attachmenttype == null)
                throw new ApiException(400, "Missing required parameter 'attachmenttype' when calling BusinessObjectApi->BusinessObjectGetBusinessObjectAttachmentsByIdAndPublicIdV1");

            var varPath = $"/api/V1/getbusinessobjectattachments/busobid/{busobid}/publicid/{publicid}/type/{type}/attachmenttype/{attachmenttype}";
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
            localVarPathParams.Add("type", Configuration.ApiClient.ParameterToString(type)); // path parameter
            localVarPathParams.Add("attachmenttype", Configuration.ApiClient.ParameterToString(attachmenttype)); // path parameter
            if (includelinks != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "includelinks", includelinks)); // query parameter
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

            var exception = ExceptionFactory?.Invoke("BusinessObjectGetBusinessObjectAttachmentsByIdAndPublicIdV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<AttachmentsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (AttachmentsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AttachmentsResponse)));
        }

        #endregion

        #region BusinessObjectGetBusinessObjectAttachmentsByIdAndRecIdV1

          /// <summary>
        /// Get attachments by Business Object record ID Operation to get attachments for a Business Object by Business Object ID and record ID.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobid">Specify the Business Object ID.</param>
        /// <param name="busobrecid">Specify the Business Object record ID.</param>
        /// <param name="type">Record attachment type: &lt;/br&gt;&lt;/br&gt;None - Not applicable to the REST API. &lt;/br&gt;&lt;/br&gt;File - Linked files. &lt;/br&gt;&lt;/br&gt;FileManagerFile - Imported files.&lt;/br&gt;&lt;/br&gt;BusOb - Attached Business Objects. &lt;/br&gt;&lt;/br&gt;History - Information about the attachment, if any is available. For example, an e-mail message may store the name of an attachment sent.&lt;/br&gt;&lt;/br&gt;Other - Not applicable to the REST API. &lt;/br&gt;</param>
        /// <param name="attachmenttype">For file types, select the type of attachment: &lt;/br&gt;&lt;/br&gt;Imported - Attachment was imported into database. &lt;/br&gt;&lt;/br&gt;Linked - Attachment is linked to an external file. &lt;/br&gt;&lt;/br&gt;URL - Attachment is a URL.</param>
        /// <param name="includelinks">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsBusinessObjectAttachmentsResponse</returns>
        public AttachmentsResponse BusinessObjectGetBusinessObjectAttachmentsByIdAndRecIdV1 (string busobid, string busobrecid, string type, string attachmenttype, bool? includelinks = null, string lang = null, string locale = null)
        {
             return BusinessObjectGetBusinessObjectAttachmentsByIdAndRecIdV1WithHttpInfo(busobid, busobrecid, type, attachmenttype, includelinks, lang, locale).Data;
        }

        /// <summary>
        /// Get attachments by Business Object record ID Operation to get attachments for a Business Object by Business Object ID and record ID.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobid">Specify the Business Object ID.</param>
        /// <param name="busobrecid">Specify the Business Object record ID.</param>
        /// <param name="type">Record attachment type: &lt;/br&gt;&lt;/br&gt;None - Not applicable to the REST API. &lt;/br&gt;&lt;/br&gt;File - Linked files. &lt;/br&gt;&lt;/br&gt;FileManagerFile - Imported files.&lt;/br&gt;&lt;/br&gt;BusOb - Attached Business Objects. &lt;/br&gt;&lt;/br&gt;History - Information about the attachment, if any is available. For example, an e-mail message may store the name of an attachment sent.&lt;/br&gt;&lt;/br&gt;Other - Not applicable to the REST API. &lt;/br&gt;</param>
        /// <param name="attachmenttype">For file types, select the type of attachment: &lt;/br&gt;&lt;/br&gt;Imported - Attachment was imported into database. &lt;/br&gt;&lt;/br&gt;Linked - Attachment is linked to an external file. &lt;/br&gt;&lt;/br&gt;URL - Attachment is a URL.</param>
        /// <param name="includelinks">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsBusinessObjectAttachmentsResponse</returns>
        private ApiResponse< AttachmentsResponse > BusinessObjectGetBusinessObjectAttachmentsByIdAndRecIdV1WithHttpInfo (string busobid, string busobrecid, string type, string attachmenttype, bool? includelinks = null, string lang = null, string locale = null)
        {
            // verify the required parameter 'busobid' is set
            if (busobid == null)
                throw new ApiException(400, "Missing required parameter 'busobid' when calling BusinessObjectApi->BusinessObjectGetBusinessObjectAttachmentsByIdAndRecIdV1");
            // verify the required parameter 'busobrecid' is set
            if (busobrecid == null)
                throw new ApiException(400, "Missing required parameter 'busobrecid' when calling BusinessObjectApi->BusinessObjectGetBusinessObjectAttachmentsByIdAndRecIdV1");
            // verify the required parameter 'type' is set
            if (type == null)
                throw new ApiException(400, "Missing required parameter 'type' when calling BusinessObjectApi->BusinessObjectGetBusinessObjectAttachmentsByIdAndRecIdV1");
            // verify the required parameter 'attachmenttype' is set
            if (attachmenttype == null)
                throw new ApiException(400, "Missing required parameter 'attachmenttype' when calling BusinessObjectApi->BusinessObjectGetBusinessObjectAttachmentsByIdAndRecIdV1");

            var localVarPath = $"/api/V1/getbusinessobjectattachments/busobid/{busobid}/busobrecid/{busobrecid}/type/{type}/attachmenttype/{attachmenttype}";
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

            localVarPathParams.Add("busobid", Configuration.ApiClient.ParameterToString(busobid)); // path parameter
            localVarPathParams.Add("busobrecid", Configuration.ApiClient.ParameterToString(busobrecid)); // path parameter
            localVarPathParams.Add("type", Configuration.ApiClient.ParameterToString(type)); // path parameter
            localVarPathParams.Add("attachmenttype", Configuration.ApiClient.ParameterToString(attachmenttype)); // path parameter
            if (includelinks != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "includelinks", includelinks)); // query parameter
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

            var exception = ExceptionFactory?.Invoke("BusinessObjectGetBusinessObjectAttachmentsByIdAndRecIdV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<AttachmentsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (AttachmentsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AttachmentsResponse)));
        }

        #endregion

        #region BusinessObjectGetBusinessObjectAttachmentsByNameAndPublicIdV1

        /// <summary>
        /// Get attachments by Business Object name and public ID Operation to get attachments for a Business Object by Business Object Name and public ID.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="publicid">Specify the Business Object public ID for the record that contains the attachments.</param>
        /// <param name="type">Record attachment type: &lt;/br&gt;&lt;/br&gt;None - Not applicable to the REST API. &lt;/br&gt;&lt;/br&gt;File - Linked files. &lt;/br&gt;&lt;/br&gt;FileManagerFile - Imported files.&lt;/br&gt;&lt;/br&gt;BusOb - Attached Business Objects. &lt;/br&gt;&lt;/br&gt;History - Information about the attachment, if any is available. For example, an e-mail message may store the name of an attachment sent.&lt;/br&gt;&lt;/br&gt;Other - Not applicable to the REST API. &lt;/br&gt;</param>
        /// <param name="attachmenttype">For file types, select the type of attachment: &lt;/br&gt;&lt;/br&gt;Imported - Attachment was imported into database. &lt;/br&gt;&lt;/br&gt;Linked - Attachment is linked to an external file. &lt;/br&gt;&lt;/br&gt;URL - Attachment is a URL.</param>
        /// <param name="includelinks">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsBusinessObjectAttachmentsResponse</returns>
        public AttachmentsResponse BusinessObjectGetBusinessObjectAttachmentsByNameAndPublicIdV1 (string busobname, string publicid, string type, string attachmenttype, bool? includelinks = null, string lang = null, string locale = null)
        {
             return BusinessObjectGetBusinessObjectAttachmentsByNameAndPublicIdV1WithHttpInfo(busobname, publicid, type, attachmenttype, includelinks, lang, locale).Data;
        }

        /// <summary>
        /// Get attachments by Business Object name and public ID Operation to get attachments for a Business Object by Business Object Name and public ID.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="publicid">Specify the Business Object public ID for the record that contains the attachments.</param>
        /// <param name="type">Record attachment type: &lt;/br&gt;&lt;/br&gt;None - Not applicable to the REST API. &lt;/br&gt;&lt;/br&gt;File - Linked files. &lt;/br&gt;&lt;/br&gt;FileManagerFile - Imported files.&lt;/br&gt;&lt;/br&gt;BusOb - Attached Business Objects. &lt;/br&gt;&lt;/br&gt;History - Information about the attachment, if any is available. For example, an e-mail message may store the name of an attachment sent.&lt;/br&gt;&lt;/br&gt;Other - Not applicable to the REST API. &lt;/br&gt;</param>
        /// <param name="attachmenttype">For file types, select the type of attachment: &lt;/br&gt;&lt;/br&gt;Imported - Attachment was imported into database. &lt;/br&gt;&lt;/br&gt;Linked - Attachment is linked to an external file. &lt;/br&gt;&lt;/br&gt;URL - Attachment is a URL.</param>
        /// <param name="includelinks">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsBusinessObjectAttachmentsResponse</returns>
        private ApiResponse< AttachmentsResponse > BusinessObjectGetBusinessObjectAttachmentsByNameAndPublicIdV1WithHttpInfo (string busobname, string publicid, string type, string attachmenttype, bool? includelinks = null, string lang = null, string locale = null)
        {
            // verify the required parameter 'busobname' is set
            if (busobname == null)
                throw new ApiException(400, "Missing required parameter 'busobname' when calling BusinessObjectApi->BusinessObjectGetBusinessObjectAttachmentsByNameAndPublicIdV1");
            // verify the required parameter 'publicid' is set
            if (publicid == null)
                throw new ApiException(400, "Missing required parameter 'publicid' when calling BusinessObjectApi->BusinessObjectGetBusinessObjectAttachmentsByNameAndPublicIdV1");
            // verify the required parameter 'type' is set
            if (type == null)
                throw new ApiException(400, "Missing required parameter 'type' when calling BusinessObjectApi->BusinessObjectGetBusinessObjectAttachmentsByNameAndPublicIdV1");
            // verify the required parameter 'attachmenttype' is set
            if (attachmenttype == null)
                throw new ApiException(400, "Missing required parameter 'attachmenttype' when calling BusinessObjectApi->BusinessObjectGetBusinessObjectAttachmentsByNameAndPublicIdV1");

            var localVarPath = $"/api/V1/getbusinessobjectattachments/busobname/{busobname}/publicid/{publicid}/type/{type}/attachmenttype/{attachmenttype}";
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
            localVarPathParams.Add("type", Configuration.ApiClient.ParameterToString(type)); // path parameter
            localVarPathParams.Add("attachmenttype", Configuration.ApiClient.ParameterToString(attachmenttype)); // path parameter
            if (includelinks != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "includelinks", includelinks)); // query parameter
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

            var exception = ExceptionFactory?.Invoke("BusinessObjectGetBusinessObjectAttachmentsByNameAndPublicIdV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<AttachmentsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (AttachmentsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AttachmentsResponse)));
        }

        #endregion

        #region BusinessObjectGetBusinessObjectAttachmentsByNameAndRecIdV1

        /// <summary>
        /// Get attachments by Business Object name and record ID Operation to get attachments for a Business Object by name and record ID.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="busobrecid">Specify the Business Object record ID.</param>
        /// <param name="type">Record attachment type: &lt;/br&gt;&lt;/br&gt;None - Not applicable to the REST API. &lt;/br&gt;&lt;/br&gt;File - Linked files. &lt;/br&gt;&lt;/br&gt;FileManagerFile - Imported files.&lt;/br&gt;&lt;/br&gt;BusOb - Attached Business Objects. &lt;/br&gt;&lt;/br&gt;History - Information about the attachment, if any is available. For example, an e-mail message may store the name of an attachment sent.&lt;/br&gt;&lt;/br&gt;Other - Not applicable to the REST API. &lt;/br&gt;</param>
        /// <param name="attachmenttype">For file types, select the type of attachment: &lt;/br&gt;&lt;/br&gt;Imported - Attachment was imported into database. &lt;/br&gt;&lt;/br&gt;Linked - Attachment is linked to an external file. &lt;/br&gt;&lt;/br&gt;URL - Attachment is a URL.</param>
        /// <param name="includelinks">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsBusinessObjectAttachmentsResponse</returns>
        public AttachmentsResponse BusinessObjectGetBusinessObjectAttachmentsByNameAndRecIdV1 (string busobname, string busobrecid, string type, string attachmenttype, bool? includelinks = null, string lang = null, string locale = null)
        {
             return BusinessObjectGetBusinessObjectAttachmentsByNameAndRecIdV1WithHttpInfo(busobname, busobrecid, type, attachmenttype, includelinks, lang, locale).Data;
        }

        /// <summary>
        /// Get attachments by Business Object name and record ID Operation to get attachments for a Business Object by name and record ID.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="busobrecid">Specify the Business Object record ID.</param>
        /// <param name="type">Record attachment type: &lt;/br&gt;&lt;/br&gt;None - Not applicable to the REST API. &lt;/br&gt;&lt;/br&gt;File - Linked files. &lt;/br&gt;&lt;/br&gt;FileManagerFile - Imported files.&lt;/br&gt;&lt;/br&gt;BusOb - Attached Business Objects. &lt;/br&gt;&lt;/br&gt;History - Information about the attachment, if any is available. For example, an e-mail message may store the name of an attachment sent.&lt;/br&gt;&lt;/br&gt;Other - Not applicable to the REST API. &lt;/br&gt;</param>
        /// <param name="attachmenttype">For file types, select the type of attachment: &lt;/br&gt;&lt;/br&gt;Imported - Attachment was imported into database. &lt;/br&gt;&lt;/br&gt;Linked - Attachment is linked to an external file. &lt;/br&gt;&lt;/br&gt;URL - Attachment is a URL.</param>
        /// <param name="includelinks">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsBusinessObjectAttachmentsResponse</returns>
        private ApiResponse< AttachmentsResponse > BusinessObjectGetBusinessObjectAttachmentsByNameAndRecIdV1WithHttpInfo (string busobname, string busobrecid, string type, string attachmenttype, bool? includelinks = null, string lang = null, string locale = null)
        {
            // verify the required parameter 'busobname' is set
            if (busobname == null)
                throw new ApiException(400, "Missing required parameter 'busobname' when calling BusinessObjectApi->BusinessObjectGetBusinessObjectAttachmentsByNameAndRecIdV1");
            // verify the required parameter 'busobrecid' is set
            if (busobrecid == null)
                throw new ApiException(400, "Missing required parameter 'busobrecid' when calling BusinessObjectApi->BusinessObjectGetBusinessObjectAttachmentsByNameAndRecIdV1");
            // verify the required parameter 'type' is set
            if (type == null)
                throw new ApiException(400, "Missing required parameter 'type' when calling BusinessObjectApi->BusinessObjectGetBusinessObjectAttachmentsByNameAndRecIdV1");
            // verify the required parameter 'attachmenttype' is set
            if (attachmenttype == null)
                throw new ApiException(400, "Missing required parameter 'attachmenttype' when calling BusinessObjectApi->BusinessObjectGetBusinessObjectAttachmentsByNameAndRecIdV1");

            var localVarPath = $"/api/V1/getbusinessobjectattachments/busobname/{busobname}/busobrecid/{busobrecid}/type/{type}/attachmenttype/{attachmenttype}";
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
            localVarPathParams.Add("busobrecid", Configuration.ApiClient.ParameterToString(busobrecid)); // path parameter
            localVarPathParams.Add("type", Configuration.ApiClient.ParameterToString(type)); // path parameter
            localVarPathParams.Add("attachmenttype", Configuration.ApiClient.ParameterToString(attachmenttype)); // path parameter
            if (includelinks != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "includelinks", includelinks)); // query parameter
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

            var exception = ExceptionFactory?.Invoke("BusinessObjectGetBusinessObjectAttachmentsByNameAndRecIdV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<AttachmentsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (AttachmentsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AttachmentsResponse)));
        }

        #endregion

        #region BusinessObjectGetBusinessObjectAttachmentsV1

        /// <summary>
        /// Get Business Object attachments by request object Operation to get attachments for a Business Object by attachments request object.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="attachmentsRequest">Object with all the parameters to request an attachments list. You can also request a list of types to get more than just one type at a time.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsBusinessObjectAttachmentsResponse</returns>
        public AttachmentsResponse BusinessObjectGetBusinessObjectAttachmentsV1 (AttachmentsRequest attachmentsRequest, string lang = null, string locale = null)
        {
             return BusinessObjectGetBusinessObjectAttachmentsV1WithHttpInfo(attachmentsRequest, lang, locale).Data;
        }

        /// <summary>
        /// Get Business Object attachments by request object Operation to get attachments for a Business Object by attachments request object.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="attachmentsRequest">Object with all the parameters to request an attachments list. You can also request a list of types to get more than just one type at a time.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsBusinessObjectAttachmentsResponse</returns>
        private ApiResponse< AttachmentsResponse > BusinessObjectGetBusinessObjectAttachmentsV1WithHttpInfo (AttachmentsRequest attachmentsRequest, string lang = null, string locale = null)
        {
            // verify the required parameter 'attachmentsRequest' is set
            if (attachmentsRequest == null)
                throw new ApiException(400, "Missing required parameter 'attachmentsRequest' when calling BusinessObjectApi->BusinessObjectGetBusinessObjectAttachmentsV1");

            const string varPath = "/api/V1/getbusinessobjectattachments";
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
            if (attachmentsRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(attachmentsRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = attachmentsRequest; // byte array
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

            var exception = ExceptionFactory?.Invoke("BusinessObjectGetBusinessObjectAttachmentsV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<AttachmentsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (AttachmentsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AttachmentsResponse)));
        }

        #endregion
        
        #region BusinessObjectGetBusinessObjectBatchV1

         /// <summary>
        /// Get a batch of Business Object records Operation that returns a batch of Business Object records that includes a list of field record IDs, display names, and values for each record.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Specify an array of Business Object IDs, record IDs, or public IDs. Use a flag to stop on error or continue on error.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsBusinessObjectBatchReadResponse</returns>
        public BatchReadResponse BusinessObjectGetBusinessObjectBatchV1 (BatchReadRequest request, string lang = null, string locale = null)
        {
             return BusinessObjectGetBusinessObjectBatchV1WithHttpInfo(request, lang, locale).Data;
        }

        /// <summary>
        /// Get a batch of Business Object records Operation that returns a batch of Business Object records that includes a list of field record IDs, display names, and values for each record.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Specify an array of Business Object IDs, record IDs, or public IDs. Use a flag to stop on error or continue on error.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsBusinessObjectBatchReadResponse</returns>
        private ApiResponse< BatchReadResponse > BusinessObjectGetBusinessObjectBatchV1WithHttpInfo (BatchReadRequest request, string lang = null, string locale = null)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling BusinessObjectApi->BusinessObjectGetBusinessObjectBatchV1");

            const string varPath = "/api/V1/getbusinessobjectbatch";
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

            var exception = ExceptionFactory?.Invoke("BusinessObjectGetBusinessObjectBatchV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<BatchReadResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (BatchReadResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BatchReadResponse)));
        }
        
        #endregion

        #region BusinessObjectGetBusinessObjectByPublicIdV1

        /// <summary>
        /// Get a Business Object record Operation that returns a Business Object record that includes a list of fields and their record IDs, names, and set values.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobid">Specify the Business Object ID.</param>
        /// <param name="publicid">Specify the Business Object public ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsBusinessObjectReadResponse</returns>
        public ReadResponse BusinessObjectGetBusinessObjectByPublicIdV1 (string busobid, string publicid, string lang = null, string locale = null)
        {
             return BusinessObjectGetBusinessObjectByPublicIdV1WithHttpInfo(busobid, publicid, lang, locale).Data;
        }
        
        /// <summary>
        /// Get a Business Object record Operation that returns a Business Object record that includes a list of fields and their record IDs, names, and set values.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobid">Specify the Business Object ID.</param>
        /// <param name="publicid">Specify the Business Object public ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsBusinessObjectReadResponse</returns>
        private ApiResponse< ReadResponse > BusinessObjectGetBusinessObjectByPublicIdV1WithHttpInfo (string busobid, string publicid, string lang = null, string locale = null)
        {
            // verify the required parameter 'busobid' is set
            if (busobid == null)
                throw new ApiException(400, "Missing required parameter 'busobid' when calling BusinessObjectApi->BusinessObjectGetBusinessObjectByPublicIdV1");
            // verify the required parameter 'publicid' is set
            if (publicid == null)
                throw new ApiException(400, "Missing required parameter 'publicid' when calling BusinessObjectApi->BusinessObjectGetBusinessObjectByPublicIdV1");

            var localVarPath = $"/api/V1/getbusinessobject/busobid/{busobid}/publicid/{publicid}";
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

            var exception = ExceptionFactory?.Invoke("BusinessObjectGetBusinessObjectByPublicIdV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<ReadResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (ReadResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReadResponse)));
        }

        #endregion
        
        #region BusinessObjectGetBusinessObjectByRecIdV1

         public ReadResponse BusinessObjectGetBusinessObjectByRecIdV1(string busobid,
            string busobrecid, string lang = null, string locale = null)
        {
            return BusinessObjectGetBusinessObjectByRecIdV1WithHttpInfo(busobid, busobrecid, lang, locale).Data;
        }
        
        
        /// <summary>
        /// Get a Business Object record Operation that returns a Business Object record that includes a list of fields and their record IDs, names, and set values.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobid">Specify the Business Object ID.</param>
        /// <param name="busobrecid">Specify the Business Object record ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsBusinessObjectReadResponse</returns>
        private ApiResponse< ReadResponse > BusinessObjectGetBusinessObjectByRecIdV1WithHttpInfo (string busobid, string busobrecid, string lang = null, string locale = null)
        {
            // verify the required parameter 'busobid' is set
            if (busobid == null)
                throw new ApiException(400, "Missing required parameter 'busobid' when calling BusinessObjectApi->BusinessObjectGetBusinessObjectByRecIdV1");
            // verify the required parameter 'busobrecid' is set
            if (busobrecid == null)
                throw new ApiException(400, "Missing required parameter 'busobrecid' when calling BusinessObjectApi->BusinessObjectGetBusinessObjectByRecIdV1");

            var localVarPath = $"/api/V1/getbusinessobject/busobid/{busobid}/busobrecid/{busobrecid}";
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

            var exception = ExceptionFactory?.Invoke("BusinessObjectGetBusinessObjectByRecIdV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<ReadResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (ReadResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReadResponse)));
        }
        
        #endregion

        #region BusinessObjectGetBusinessObjectByScanCodeBusObIdV1

         /// <summary>
        /// Get a Business Object by its scan code and Business Object ID Operation to get a Business Object based on its associated scan code and Business Object ID.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="scanCode">The scan code for a Business Object record.</param>
        /// <param name="busobid">The Business Object ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsBusinessObjectBarcodeLookupResponse</returns>
        public BarcodeLookupResponse BusinessObjectGetBusinessObjectByScanCodeBusObIdV1 (string scanCode, string busobid, string lang = null, string locale = null)
        {
             return BusinessObjectGetBusinessObjectByScanCodeBusObIdV1WithHttpInfo(scanCode, busobid, lang, locale).Data;
        }

        /// <summary>
        /// Get a Business Object by its scan code and Business Object ID Operation to get a Business Object based on its associated scan code and Business Object ID.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="scanCode">The scan code for a Business Object record.</param>
        /// <param name="busobid">The Business Object ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsBusinessObjectBarcodeLookupResponse</returns>
        private ApiResponse< BarcodeLookupResponse > BusinessObjectGetBusinessObjectByScanCodeBusObIdV1WithHttpInfo (string scanCode, string busobid, string lang = null, string locale = null)
        {
            // verify the required parameter 'scanCode' is set
            if (scanCode == null)
                throw new ApiException(400, "Missing required parameter 'scanCode' when calling BusinessObjectApi->BusinessObjectGetBusinessObjectByScanCodeBusObIdV1");
            // verify the required parameter 'busobid' is set
            if (busobid == null)
                throw new ApiException(400, "Missing required parameter 'busobid' when calling BusinessObjectApi->BusinessObjectGetBusinessObjectByScanCodeBusObIdV1");

            var localVarPath = $"/api/V1/getbusinessobject/scancode/{scanCode}/busobid/{busobid}";
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

            localVarPathParams.Add("scanCode", Configuration.ApiClient.ParameterToString(scanCode)); // path parameter
            localVarPathParams.Add("busobid", Configuration.ApiClient.ParameterToString(busobid)); // path parameter
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

            var exception = ExceptionFactory?.Invoke("BusinessObjectGetBusinessObjectByScanCodeBusObIdV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<BarcodeLookupResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (BarcodeLookupResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BarcodeLookupResponse)));
        }

        #endregion

        #region BusinessObjectGetBusinessObjectByScanCodeBusObNameV1

        /// <summary>
        /// Get a Business Object by its scan code and Business Object name Operation to get a Business Object based on its associated scan code and Business Object name.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="scanCode">The scan code for a Business Object record.</param>
        /// <param name="busobname">The Business Bbject name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsBusinessObjectBarcodeLookupResponse</returns>
        public BarcodeLookupResponse BusinessObjectGetBusinessObjectByScanCodeBusObNameV1 (string scanCode, string busobname, string lang = null, string locale = null)
        {
             return BusinessObjectGetBusinessObjectByScanCodeBusObNameV1WithHttpInfo(scanCode, busobname, lang, locale).Data;
        }

        /// <summary>
        /// Get a Business Object by its scan code and Business Object name Operation to get a Business Object based on its associated scan code and Business Object name.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="scanCode">The scan code for a Business Object record.</param>
        /// <param name="busobname">The Business Bbject name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsBusinessObjectBarcodeLookupResponse</returns>
        private ApiResponse< BarcodeLookupResponse > BusinessObjectGetBusinessObjectByScanCodeBusObNameV1WithHttpInfo (string scanCode, string busobname, string lang = null, string locale = null)
        {
            // verify the required parameter 'scanCode' is set
            if (scanCode == null)
                throw new ApiException(400, "Missing required parameter 'scanCode' when calling BusinessObjectApi->BusinessObjectGetBusinessObjectByScanCodeBusObNameV1");
            // verify the required parameter 'busobname' is set
            if (busobname == null)
                throw new ApiException(400, "Missing required parameter 'busobname' when calling BusinessObjectApi->BusinessObjectGetBusinessObjectByScanCodeBusObNameV1");

            var localVarPath = $"/api/V1/getbusinessobject/scancode/{scanCode}/busobname/{busobname}";
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

            localVarPathParams.Add("scanCode", Configuration.ApiClient.ParameterToString(scanCode)); // path parameter
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
                method: Method.GET, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int) localVarResponse.StatusCode;

            var exception = ExceptionFactory?.Invoke("BusinessObjectGetBusinessObjectByScanCodeBusObNameV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<BarcodeLookupResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (BarcodeLookupResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BarcodeLookupResponse)));
        }

        #endregion

        #region BusinessObjectGetBusinessObjectSchemaV1

         /// <summary>
        /// Get a Business Object schema Operation that returns the schema for a Business Object and, optionally, its related Business Objects.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobId">Specify the Business Object ID.</param>
        /// <param name="includerelationships">Flag to include schemas for related Business Object. Default is false. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsBusinessObjectSchemaResponse</returns>
        public SchemaResponse BusinessObjectGetBusinessObjectSchemaV1 (string busobId, bool? includerelationships = null, string lang = null, string locale = null)
        {
             return BusinessObjectGetBusinessObjectSchemaV1WithHttpInfo(busobId, includerelationships, lang, locale).Data;
        }

        /// <summary>
        /// Get a Business Object schema Operation that returns the schema for a Business Object and, optionally, its related Business Objects.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobId">Specify the Business Object ID.</param>
        /// <param name="includerelationships">Flag to include schemas for related Business Object. Default is false. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsBusinessObjectSchemaResponse</returns>
        private ApiResponse< SchemaResponse > BusinessObjectGetBusinessObjectSchemaV1WithHttpInfo (string busobId, bool? includerelationships = null, string lang = null, string locale = null)
        {
            // verify the required parameter 'busobId' is set
            if (busobId == null)
                throw new ApiException(400, "Missing required parameter 'busobId' when calling BusinessObjectApi->BusinessObjectGetBusinessObjectSchemaV1");

            var localVarPath = $"/api/V1/getbusinessobjectschema/busobid/{busobId}";
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

            localVarPathParams.Add("busobId", Configuration.ApiClient.ParameterToString(busobId)); // path parameter
            if (includerelationships != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "includerelationships", includerelationships)); // query parameter
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

            var exception = ExceptionFactory?.Invoke("BusinessObjectGetBusinessObjectSchemaV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<SchemaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (SchemaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SchemaResponse)));
        }

        #endregion

        #region BusinessObjectGetBusinessObjectSummariesV1

         /// <summary>
        /// Get Business Object summaries by type Operation that returns a list of Business Object summaries by type (Major, Supporting, Lookup, Groups, and All). 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Use to show:&lt;br /&gt;All - All objects&lt;br /&gt;Major - Major objects only&lt;br /&gt;Supporting - Supporting objects only&lt;br /&gt;Lookup - Lookup objects only&lt;br /&gt;Groups - Groups only</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>List&lt;TrebuchetWebApiDataContractsBusinessObjectSummary&gt;</returns>
        public List<Summary> BusinessObjectGetBusinessObjectSummariesV1 (string type, string lang = null, string locale = null)
        {
             return BusinessObjectGetBusinessObjectSummariesV1WithHttpInfo(type, lang, locale).Data;
        }

        /// <summary>
        /// Get Business Object summaries by type Operation that returns a list of Business Object summaries by type (Major, Supporting, Lookup, Groups, and All). 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Use to show:&lt;br /&gt;All - All objects&lt;br /&gt;Major - Major objects only&lt;br /&gt;Supporting - Supporting objects only&lt;br /&gt;Lookup - Lookup objects only&lt;br /&gt;Groups - Groups only</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of List&lt;TrebuchetWebApiDataContractsBusinessObjectSummary&gt;</returns>
        private ApiResponse< List<Summary> > BusinessObjectGetBusinessObjectSummariesV1WithHttpInfo (string type, string lang = null, string locale = null)
        {
            // verify the required parameter 'type' is set
            if (type == null)
                throw new ApiException(400, "Missing required parameter 'type' when calling BusinessObjectApi->BusinessObjectGetBusinessObjectSummariesV1");

            var localVarPath = $"/api/V1/getbusinessobjectsummaries/type/{type}";
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

            localVarPathParams.Add("type", Configuration.ApiClient.ParameterToString(type)); // path parameter
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

            var exception = ExceptionFactory?.Invoke("BusinessObjectGetBusinessObjectSummariesV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<List<Summary>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (List<Summary>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Summary>)));
        }

        #endregion

        #region BusinessObjectGetBusinessObjectSummaryByIdV1
        
         /// <summary>
        /// Get a Business Object summary by ID Operation that returns a single Business Object summary by ID.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobid">Specify a Business Object ID to get its summary.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>List&lt;TrebuchetWebApiDataContractsBusinessObjectSummary&gt;</returns>
        public List<Summary> BusinessObjectGetBusinessObjectSummaryByIdV1 (string busobid, string lang = null, string locale = null)
        {
             return BusinessObjectGetBusinessObjectSummaryByIdV1WithHttpInfo(busobid, lang, locale).Data;
        }

        /// <summary>
        /// Get a Business Object summary by ID Operation that returns a single Business Object summary by ID.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobid">Specify a Business Object ID to get its summary.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of List&lt;TrebuchetWebApiDataContractsBusinessObjectSummary&gt;</returns>
        private ApiResponse< List<Summary> > BusinessObjectGetBusinessObjectSummaryByIdV1WithHttpInfo (string busobid, string lang = null, string locale = null)
        {
            // verify the required parameter 'busobid' is set
            if (busobid == null)
                throw new ApiException(400, "Missing required parameter 'busobid' when calling BusinessObjectApi->BusinessObjectGetBusinessObjectSummaryByIdV1");

            var localVarPath = $"/api/V1/getbusinessobjectsummary/busobid/{busobid}";
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

            var exception = ExceptionFactory?.Invoke("BusinessObjectGetBusinessObjectSummaryByIdV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<List<Summary>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (List<Summary>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Summary>)));
        }
        
        #endregion

        #region BusinessObjectGetBusinessObjectSummaryByNameV1

        /// <summary>
        /// Get a Business Object summary by name Operation that returns a single Business Object summary by name.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobname">Specify a Business Object name to get its summary.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>List&lt;TrebuchetWebApiDataContractsBusinessObjectSummary&gt;</returns>
        public List<Summary> BusinessObjectGetBusinessObjectSummaryByNameV1 (string busobname, string lang = null, string locale = null)
        {
             return  BusinessObjectGetBusinessObjectSummaryByNameV1WithHttpInfo(busobname, lang, locale).Data;
        }

        /// <summary>
        /// Get a Business Object summary by name Operation that returns a single Business Object summary by name.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobname">Specify a Business Object name to get its summary.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of List&lt;TrebuchetWebApiDataContractsBusinessObjectSummary&gt;</returns>
        private ApiResponse< List<Summary> > BusinessObjectGetBusinessObjectSummaryByNameV1WithHttpInfo (string busobname, string lang = null, string locale = null)
        {
            // verify the required parameter 'busobname' is set
            if (busobname == null)
                throw new ApiException(400, "Missing required parameter 'busobname' when calling BusinessObjectApi->BusinessObjectGetBusinessObjectSummaryByNameV1");

            var localVarPath = $"/api/V1/getbusinessobjectsummary/busobname/{busobname}";
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

            var exception = ExceptionFactory?.Invoke("BusinessObjectGetBusinessObjectSummaryByNameV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<List<Summary>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (List<Summary>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Summary>)));
        }

        #endregion

        #region BusinessObjectGetBusinessObjectTemplateV1

         /// <summary>
        /// Get Business Object templates for create Operation that returns a template to create Business Objects.  The template includes placeholders for field values. You can then send the template with these values to the Business Object Save operation.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Specify the Business Object ID. Use true to include all required fields or all fields. Specify an optional fields list by adding field names in a comma-delimited list [\&quot;field1\&quot;, \&quot;field2\&quot;]. </param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsBusinessObjectTemplateResponse</returns>
        public TemplateResponse BusinessObjectGetBusinessObjectTemplateV1 (TemplateRequest request, string lang = null, string locale = null)
        {
             return BusinessObjectGetBusinessObjectTemplateV1WithHttpInfo(request, lang, locale).Data;
        }

        /// <summary>
        /// Get Business Object templates for create Operation that returns a template to create Business Objects.  The template includes placeholders for field values. You can then send the template with these values to the Business Object Save operation.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Specify the Business Object ID. Use true to include all required fields or all fields. Specify an optional fields list by adding field names in a comma-delimited list [\&quot;field1\&quot;, \&quot;field2\&quot;]. </param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsBusinessObjectTemplateResponse</returns>
        private ApiResponse< TemplateResponse > BusinessObjectGetBusinessObjectTemplateV1WithHttpInfo (TemplateRequest request, string lang = null, string locale = null)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling BusinessObjectApi->BusinessObjectGetBusinessObjectTemplateV1");

            var localVarPath = $"/api/V1/getbusinessobjecttemplate";
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
            var localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int) localVarResponse.StatusCode;

            var exception = ExceptionFactory?.Invoke("BusinessObjectGetBusinessObjectTemplateV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<TemplateResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (TemplateResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TemplateResponse)));
        }

        #endregion

        #region BusinessObjectGetRelatedBusinessObjectByRequestV1

        /// <summary>
        /// Get related Business Objects using a request object Operation to get related Business Objects for a specific relationship. Specify a list of fields to include in the response. The order of parameter usage and overrides is: all fields set to true overrides default overrides;  custom grid overrides field list settings.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="relatedBusinessObjectRequest">Request object containing all the possible parameters to get related Business Objects.</param>
        /// <param name="includelinks">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsSearchesRelatedBusinessObjectResponse</returns>
        public TrebuchetWebApiDataContractsSearchesRelatedBusinessObjectResponse BusinessObjectGetRelatedBusinessObjectByRequestV1 (TrebuchetWebApiDataContractsSearchesRelatedBusinessObjectRequest relatedBusinessObjectRequest, bool? includelinks = null, string lang = null, string locale = null)
        {
             return BusinessObjectGetRelatedBusinessObjectByRequestV1WithHttpInfo(relatedBusinessObjectRequest, includelinks, lang, locale).Data;
        }

        /// <summary>
        /// Get related Business Objects using a request object Operation to get related Business Objects for a specific relationship. Specify a list of fields to include in the response. The order of parameter usage and overrides is: all fields set to true overrides default overrides;  custom grid overrides field list settings.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="relatedBusinessObjectRequest">Request object containing all the possible parameters to get related Business Objects.</param>
        /// <param name="includelinks">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsSearchesRelatedBusinessObjectResponse</returns>
        private ApiResponse< TrebuchetWebApiDataContractsSearchesRelatedBusinessObjectResponse > BusinessObjectGetRelatedBusinessObjectByRequestV1WithHttpInfo (TrebuchetWebApiDataContractsSearchesRelatedBusinessObjectRequest relatedBusinessObjectRequest, bool? includelinks = null, string lang = null, string locale = null)
        {
            // verify the required parameter 'relatedBusinessObjectRequest' is set
            if (relatedBusinessObjectRequest == null)
                throw new ApiException(400, "Missing required parameter 'relatedBusinessObjectRequest' when calling BusinessObjectApi->BusinessObjectGetRelatedBusinessObjectByRequestV1");

            const string varPath = "/api/V1/getrelatedbusinessobject";
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

            if (includelinks != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "includelinks", includelinks)); // query parameter
            if (lang != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter
            if (relatedBusinessObjectRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(relatedBusinessObjectRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = relatedBusinessObjectRequest; // byte array
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

            var exception = ExceptionFactory?.Invoke("BusinessObjectGetRelatedBusinessObjectByRequestV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<TrebuchetWebApiDataContractsSearchesRelatedBusinessObjectResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (TrebuchetWebApiDataContractsSearchesRelatedBusinessObjectResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TrebuchetWebApiDataContractsSearchesRelatedBusinessObjectResponse)));
        }
        
        #endregion

        #region BusinessObjectGetRelatedBusinessObjectV1

         /// <summary>
        /// Get related Business Objects by ID Operation to get the related objects for a Business Object relationship specifying all fields or default grid as the field to return.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="parentbusobid">Specify the Business Object ID for the parent Business Object.</param>
        /// <param name="parentbusobrecid">Specify the record ID for the parent Business Object.</param>
        /// <param name="relationshipid">Specify the Relationship ID for the related Business Object you want to return.</param>
        /// <param name="pageNumber">Specify the page number of the result set to return. (optional)</param>
        /// <param name="pageSize">Specify the number of rows to return per page. (optional)</param>
        /// <param name="allfields">Flag to include all related Business Object fields.  Default is true if not supplied.  If true, then UseDefaultGrid is not used. (optional)</param>
        /// <param name="usedefaultgrid">Flag to trigger the use of the related Business Objects default grid for the list of fields to return. (optional)</param>
        /// <param name="includelinks">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsSearchesRelatedBusinessObjectResponse</returns>
        public TrebuchetWebApiDataContractsSearchesRelatedBusinessObjectResponse BusinessObjectGetRelatedBusinessObjectV1 (string parentbusobid, string parentbusobrecid, string relationshipid, int? pageNumber = null, int? pageSize = null, bool? allfields = null, bool? usedefaultgrid = null, bool? includelinks = null, string lang = null, string locale = null)
        {
             return BusinessObjectGetRelatedBusinessObjectV1WithHttpInfo(parentbusobid, parentbusobrecid, relationshipid, pageNumber, pageSize, allfields, usedefaultgrid, includelinks, lang, locale).Data;
        }

        /// <summary>
        /// Get related Business Objects by ID Operation to get the related objects for a Business Object relationship specifying all fields or default grid as the field to return.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="parentbusobid">Specify the Business Object ID for the parent Business Object.</param>
        /// <param name="parentbusobrecid">Specify the record ID for the parent Business Object.</param>
        /// <param name="relationshipid">Specify the Relationship ID for the related Business Object you want to return.</param>
        /// <param name="pageNumber">Specify the page number of the result set to return. (optional)</param>
        /// <param name="pageSize">Specify the number of rows to return per page. (optional)</param>
        /// <param name="allfields">Flag to include all related Business Object fields.  Default is true if not supplied.  If true, then UseDefaultGrid is not used. (optional)</param>
        /// <param name="usedefaultgrid">Flag to trigger the use of the related Business Objects default grid for the list of fields to return. (optional)</param>
        /// <param name="includelinks">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsSearchesRelatedBusinessObjectResponse</returns>
        private ApiResponse< TrebuchetWebApiDataContractsSearchesRelatedBusinessObjectResponse > BusinessObjectGetRelatedBusinessObjectV1WithHttpInfo (string parentbusobid, string parentbusobrecid, string relationshipid, int? pageNumber = null, int? pageSize = null, bool? allfields = null, bool? usedefaultgrid = null, bool? includelinks = null, string lang = null, string locale = null)
        {
            // verify the required parameter 'parentbusobid' is set
            if (parentbusobid == null)
                throw new ApiException(400, "Missing required parameter 'parentbusobid' when calling BusinessObjectApi->BusinessObjectGetRelatedBusinessObjectV1");
            // verify the required parameter 'parentbusobrecid' is set
            if (parentbusobrecid == null)
                throw new ApiException(400, "Missing required parameter 'parentbusobrecid' when calling BusinessObjectApi->BusinessObjectGetRelatedBusinessObjectV1");
            // verify the required parameter 'relationshipid' is set
            if (relationshipid == null)
                throw new ApiException(400, "Missing required parameter 'relationshipid' when calling BusinessObjectApi->BusinessObjectGetRelatedBusinessObjectV1");

            var localVarPath = $"/api/V1/getrelatedbusinessobject/parentbusobid/{parentbusobid}/parentbusobrecid/{parentbusobrecid}/relationshipid/{relationshipid}";
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

            localVarPathParams.Add("parentbusobid", Configuration.ApiClient.ParameterToString(parentbusobid)); // path parameter
            localVarPathParams.Add("parentbusobrecid", Configuration.ApiClient.ParameterToString(parentbusobrecid)); // path parameter
            localVarPathParams.Add("relationshipid", Configuration.ApiClient.ParameterToString(relationshipid)); // path parameter
            if (pageNumber != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "pageNumber", pageNumber)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "pageSize", pageSize)); // query parameter
            if (allfields != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "allfields", allfields)); // query parameter
            if (usedefaultgrid != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "usedefaultgrid", usedefaultgrid)); // query parameter
            if (includelinks != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "includelinks", includelinks)); // query parameter
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

            var exception = ExceptionFactory?.Invoke("BusinessObjectGetRelatedBusinessObjectV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<TrebuchetWebApiDataContractsSearchesRelatedBusinessObjectResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (TrebuchetWebApiDataContractsSearchesRelatedBusinessObjectResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TrebuchetWebApiDataContractsSearchesRelatedBusinessObjectResponse)));
        }

        #endregion

        #region BusinessObjectGetRelatedBusinessObjectWithCustomGridV1
        
        /// <summary>
        /// Get related Business Objects custom grid Operation to get related Business Objects for a specific relationship. Specify a custom grid ID as the fields to return.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="parentbusobid">Specify the Business Object ID for the parent Business Object.</param>
        /// <param name="parentbusobrecid">Specify the record ID for the parent Business Object.</param>
        /// <param name="relationshipid">Specify the Relationship ID for the related Business Object you want to return.</param>
        /// <param name="gridid">Specify the ID for the custom grid that contains the field list.</param>
        /// <param name="pageNumber">Specify the page number of the result set to return. (optional)</param>
        /// <param name="pageSize">Specify the number of rows to return per page. (optional)</param>
        /// <param name="includelinks">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsSearchesRelatedBusinessObjectResponse</returns>
        public TrebuchetWebApiDataContractsSearchesRelatedBusinessObjectResponse BusinessObjectGetRelatedBusinessObjectWithCustomGridV1 (string parentbusobid, string parentbusobrecid, string relationshipid, string gridid, int? pageNumber = null, int? pageSize = null, bool? includelinks = null, string lang = null, string locale = null)
        {
             return BusinessObjectGetRelatedBusinessObjectWithCustomGridV1WithHttpInfo(parentbusobid, parentbusobrecid, relationshipid, gridid, pageNumber, pageSize, includelinks, lang, locale).Data;
        }

        /// <summary>
        /// Get related Business Objects custom grid Operation to get related Business Objects for a specific relationship. Specify a custom grid ID as the fields to return.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="parentbusobid">Specify the Business Object ID for the parent Business Object.</param>
        /// <param name="parentbusobrecid">Specify the record ID for the parent Business Object.</param>
        /// <param name="relationshipid">Specify the Relationship ID for the related Business Object you want to return.</param>
        /// <param name="gridid">Specify the ID for the custom grid that contains the field list.</param>
        /// <param name="pageNumber">Specify the page number of the result set to return. (optional)</param>
        /// <param name="pageSize">Specify the number of rows to return per page. (optional)</param>
        /// <param name="includelinks">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsSearchesRelatedBusinessObjectResponse</returns>
        private ApiResponse< TrebuchetWebApiDataContractsSearchesRelatedBusinessObjectResponse > BusinessObjectGetRelatedBusinessObjectWithCustomGridV1WithHttpInfo (string parentbusobid, string parentbusobrecid, string relationshipid, string gridid, int? pageNumber = null, int? pageSize = null, bool? includelinks = null, string lang = null, string locale = null)
        {
            // verify the required parameter 'parentbusobid' is set
            if (parentbusobid == null)
                throw new ApiException(400, "Missing required parameter 'parentbusobid' when calling BusinessObjectApi->BusinessObjectGetRelatedBusinessObjectWithCustomGridV1");
            // verify the required parameter 'parentbusobrecid' is set
            if (parentbusobrecid == null)
                throw new ApiException(400, "Missing required parameter 'parentbusobrecid' when calling BusinessObjectApi->BusinessObjectGetRelatedBusinessObjectWithCustomGridV1");
            // verify the required parameter 'relationshipid' is set
            if (relationshipid == null)
                throw new ApiException(400, "Missing required parameter 'relationshipid' when calling BusinessObjectApi->BusinessObjectGetRelatedBusinessObjectWithCustomGridV1");
            // verify the required parameter 'gridid' is set
            if (gridid == null)
                throw new ApiException(400, "Missing required parameter 'gridid' when calling BusinessObjectApi->BusinessObjectGetRelatedBusinessObjectWithCustomGridV1");

            var localVarPath = $"/api/V1/getrelatedbusinessobject/parentbusobid/{parentbusobid}/parentbusobrecid/{parentbusobrecid}/relationshipid/{relationshipid}/gridid/{gridid}";
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

            localVarPathParams.Add("parentbusobid", Configuration.ApiClient.ParameterToString(parentbusobid)); // path parameter
            localVarPathParams.Add("parentbusobrecid", Configuration.ApiClient.ParameterToString(parentbusobrecid)); // path parameter
            localVarPathParams.Add("relationshipid", Configuration.ApiClient.ParameterToString(relationshipid)); // path parameter
            localVarPathParams.Add("gridid", Configuration.ApiClient.ParameterToString(gridid)); // path parameter
            if (pageNumber != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "pageNumber", pageNumber)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "pageSize", pageSize)); // query parameter
            if (includelinks != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "includelinks", includelinks)); // query parameter
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

            var exception = ExceptionFactory?.Invoke("BusinessObjectGetRelatedBusinessObjectWithCustomGridV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<TrebuchetWebApiDataContractsSearchesRelatedBusinessObjectResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (TrebuchetWebApiDataContractsSearchesRelatedBusinessObjectResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TrebuchetWebApiDataContractsSearchesRelatedBusinessObjectResponse)));
        }

        #endregion

        #region BusinessObjectLinkRelatedBusinessObjectByRecIdV1

         /// <summary>
        /// Link related Business Objects Operation to link related Business Objects. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="parentbusobid">Specify the Business Object ID for the parent Business Object.</param>
        /// <param name="parentbusobrecid">Specify the record ID for the parent Business Object.</param>
        /// <param name="relationshipid">Specify the Relationship ID for the related Business Object you want to link.</param>
        /// <param name="busobid">Specify the Business Object ID of the Business Object to be linked.</param>
        /// <param name="busobrecid">Specify the Business Object record ID of the Business Object to be linked.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsSearchesRelatedBusinessObjectResponse</returns>
        public TrebuchetWebApiDataContractsSearchesRelatedBusinessObjectResponse BusinessObjectLinkRelatedBusinessObjectByRecIdV1 (string parentbusobid, string parentbusobrecid, string relationshipid, string busobid, string busobrecid, string lang = null, string locale = null)
        {
             return BusinessObjectLinkRelatedBusinessObjectByRecIdV1WithHttpInfo(parentbusobid, parentbusobrecid, relationshipid, busobid, busobrecid, lang, locale).Data;
        }

        /// <summary>
        /// Link related Business Objects Operation to link related Business Objects. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="parentbusobid">Specify the Business Object ID for the parent Business Object.</param>
        /// <param name="parentbusobrecid">Specify the record ID for the parent Business Object.</param>
        /// <param name="relationshipid">Specify the Relationship ID for the related Business Object you want to link.</param>
        /// <param name="busobid">Specify the Business Object ID of the Business Object to be linked.</param>
        /// <param name="busobrecid">Specify the Business Object record ID of the Business Object to be linked.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsSearchesRelatedBusinessObjectResponse</returns>
        private ApiResponse< TrebuchetWebApiDataContractsSearchesRelatedBusinessObjectResponse > BusinessObjectLinkRelatedBusinessObjectByRecIdV1WithHttpInfo (string parentbusobid, string parentbusobrecid, string relationshipid, string busobid, string busobrecid, string lang = null, string locale = null)
        {
            // verify the required parameter 'parentbusobid' is set
            if (parentbusobid == null)
                throw new ApiException(400, "Missing required parameter 'parentbusobid' when calling BusinessObjectApi->BusinessObjectLinkRelatedBusinessObjectByRecIdV1");
            // verify the required parameter 'parentbusobrecid' is set
            if (parentbusobrecid == null)
                throw new ApiException(400, "Missing required parameter 'parentbusobrecid' when calling BusinessObjectApi->BusinessObjectLinkRelatedBusinessObjectByRecIdV1");
            // verify the required parameter 'relationshipid' is set
            if (relationshipid == null)
                throw new ApiException(400, "Missing required parameter 'relationshipid' when calling BusinessObjectApi->BusinessObjectLinkRelatedBusinessObjectByRecIdV1");
            // verify the required parameter 'busobid' is set
            if (busobid == null)
                throw new ApiException(400, "Missing required parameter 'busobid' when calling BusinessObjectApi->BusinessObjectLinkRelatedBusinessObjectByRecIdV1");
            // verify the required parameter 'busobrecid' is set
            if (busobrecid == null)
                throw new ApiException(400, "Missing required parameter 'busobrecid' when calling BusinessObjectApi->BusinessObjectLinkRelatedBusinessObjectByRecIdV1");

            var localVarPath = $"/api/V1/linkrelatedbusinessobject/parentbusobid/{parentbusobid}/parentbusobrecid/{parentbusobrecid}/relationshipid/{relationshipid}/busobid/{busobid}/busobrecid/{busobrecid}";
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

            localVarPathParams.Add("parentbusobid", Configuration.ApiClient.ParameterToString(parentbusobid)); // path parameter
            localVarPathParams.Add("parentbusobrecid", Configuration.ApiClient.ParameterToString(parentbusobrecid)); // path parameter
            localVarPathParams.Add("relationshipid", Configuration.ApiClient.ParameterToString(relationshipid)); // path parameter
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

            var exception = ExceptionFactory?.Invoke("BusinessObjectLinkRelatedBusinessObjectByRecIdV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<TrebuchetWebApiDataContractsSearchesRelatedBusinessObjectResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (TrebuchetWebApiDataContractsSearchesRelatedBusinessObjectResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TrebuchetWebApiDataContractsSearchesRelatedBusinessObjectResponse)));
        }    

        #endregion

        #region BusinessObjectLinkRelatedBusinessObjectByRecIdV2

        /// <summary>
        /// Link related Business Objects Operation to link related Business Objects. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="parentbusobid">Specify the Business Object ID for the parent Business Object.</param>
        /// <param name="parentbusobrecid">Specify the record ID for the parent Business Object.</param>
        /// <param name="relationshipid">Specify the Relationship ID for the related Business Object you want to link.</param>
        /// <param name="busobid">Specify the Business Object ID of the Business Object to be linked.</param>
        /// <param name="busobrecid">Specify the Business Object record ID of the Business Object to be linked.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsResponseBase</returns>
        public ResponseBase BusinessObjectLinkRelatedBusinessObjectByRecIdV2 (string parentbusobid, string parentbusobrecid, string relationshipid, string busobid, string busobrecid, string lang = null, string locale = null)
        {
            return BusinessObjectLinkRelatedBusinessObjectByRecIdV2WithHttpInfo(parentbusobid, parentbusobrecid,
                relationshipid, busobid, busobrecid, lang, locale).Data;
        }

        /// <summary>
        /// Link related Business Objects Operation to link related Business Objects. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="parentbusobid">Specify the Business Object ID for the parent Business Object.</param>
        /// <param name="parentbusobrecid">Specify the record ID for the parent Business Object.</param>
        /// <param name="relationshipid">Specify the Relationship ID for the related Business Object you want to link.</param>
        /// <param name="busobid">Specify the Business Object ID of the Business Object to be linked.</param>
        /// <param name="busobrecid">Specify the Business Object record ID of the Business Object to be linked.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsResponseBase</returns>
        private ApiResponse< ResponseBase > BusinessObjectLinkRelatedBusinessObjectByRecIdV2WithHttpInfo (string parentbusobid, string parentbusobrecid, string relationshipid, string busobid, string busobrecid, string lang = null, string locale = null)
        {
            // verify the required parameter 'parentbusobid' is set
            if (parentbusobid == null)
                throw new ApiException(400, "Missing required parameter 'parentbusobid' when calling BusinessObjectApi->BusinessObjectLinkRelatedBusinessObjectByRecIdV2");
            // verify the required parameter 'parentbusobrecid' is set
            if (parentbusobrecid == null)
                throw new ApiException(400, "Missing required parameter 'parentbusobrecid' when calling BusinessObjectApi->BusinessObjectLinkRelatedBusinessObjectByRecIdV2");
            // verify the required parameter 'relationshipid' is set
            if (relationshipid == null)
                throw new ApiException(400, "Missing required parameter 'relationshipid' when calling BusinessObjectApi->BusinessObjectLinkRelatedBusinessObjectByRecIdV2");
            // verify the required parameter 'busobid' is set
            if (busobid == null)
                throw new ApiException(400, "Missing required parameter 'busobid' when calling BusinessObjectApi->BusinessObjectLinkRelatedBusinessObjectByRecIdV2");
            // verify the required parameter 'busobrecid' is set
            if (busobrecid == null)
                throw new ApiException(400, "Missing required parameter 'busobrecid' when calling BusinessObjectApi->BusinessObjectLinkRelatedBusinessObjectByRecIdV2");

            var localVarPath = $"/api/V2/linkrelatedbusinessobject/parentbusobid/{parentbusobid}/parentbusobrecid/{parentbusobrecid}/relationshipid/{relationshipid}/busobid/{busobid}/busobrecid/{busobrecid}";
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

            localVarPathParams.Add("parentbusobid", Configuration.ApiClient.ParameterToString(parentbusobid)); // path parameter
            localVarPathParams.Add("parentbusobrecid", Configuration.ApiClient.ParameterToString(parentbusobrecid)); // path parameter
            localVarPathParams.Add("relationshipid", Configuration.ApiClient.ParameterToString(relationshipid)); // path parameter
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

            var exception = ExceptionFactory?.Invoke("BusinessObjectLinkRelatedBusinessObjectByRecIdV2", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<ResponseBase>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (ResponseBase) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ResponseBase)));
        }

        #endregion

        #region BusinessObjectRemoveBusinessObjectAttachmentByIdAndPublicIdV1

         /// <summary>
        /// Remove an attachment by Business Object ID and public ID Operation to remove an attachment from a Business Object using the attachment record ID, Business Object ID, and Business Object public ID.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="attachmentid">Specify the internal ID of the attachment record.</param>
        /// <param name="busobid">Specify the Business Object ID.</param>
        /// <param name="publicid">Specify the Business Object public ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns></returns>
        public object BusinessObjectRemoveBusinessObjectAttachmentByIdAndPublicIdV1 (string attachmentid, string busobid, string publicid, string lang = null, string locale = null)
        {
             return BusinessObjectRemoveBusinessObjectAttachmentByIdAndPublicIdV1WithHttpInfo(attachmentid, busobid, publicid, lang, locale);
        }

        /// <summary>
        /// Remove an attachment by Business Object ID and public ID Operation to remove an attachment from a Business Object using the attachment record ID, Business Object ID, and Business Object public ID.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="attachmentid">Specify the internal ID of the attachment record.</param>
        /// <param name="busobid">Specify the Business Object ID.</param>
        /// <param name="publicid">Specify the Business Object public ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        private ApiResponse<object> BusinessObjectRemoveBusinessObjectAttachmentByIdAndPublicIdV1WithHttpInfo (string attachmentid, string busobid, string publicid, string lang = null, string locale = null)
        {
            // verify the required parameter 'attachmentid' is set
            if (attachmentid == null)
                throw new ApiException(400, "Missing required parameter 'attachmentid' when calling BusinessObjectApi->BusinessObjectRemoveBusinessObjectAttachmentByIdAndPublicIdV1");
            // verify the required parameter 'busobid' is set
            if (busobid == null)
                throw new ApiException(400, "Missing required parameter 'busobid' when calling BusinessObjectApi->BusinessObjectRemoveBusinessObjectAttachmentByIdAndPublicIdV1");
            // verify the required parameter 'publicid' is set
            if (publicid == null)
                throw new ApiException(400, "Missing required parameter 'publicid' when calling BusinessObjectApi->BusinessObjectRemoveBusinessObjectAttachmentByIdAndPublicIdV1");

            var localVarPath = $"/api/V1/removebusinessobjectattachment/attachmentid/{attachmentid}/busobid/{busobid}/publicid/{publicid}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();

            // to determine the Content-Type header
            var localVarHttpContentTypes = Array.Empty<string>();
            var localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            var localVarHttpHeaderAccepts = Array.Empty<string>();
            var localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            localVarPathParams.Add("attachmentid", Configuration.ApiClient.ParameterToString(attachmentid)); // path parameter
            localVarPathParams.Add("busobid", Configuration.ApiClient.ParameterToString(busobid)); // path parameter
            localVarPathParams.Add("publicid", Configuration.ApiClient.ParameterToString(publicid)); // path parameter
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

            var exception = ExceptionFactory?.Invoke("BusinessObjectRemoveBusinessObjectAttachmentByIdAndPublicIdV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                null);
        }

        #endregion

        #region BusinessObjectRemoveBusinessObjectAttachmentByIdAndRecIdV1

        /// <summary>
        /// Remove an attachment by Business Object ID and record ID Operation to remove an attachment from a Business Object using the attachment record ID, Business Object ID, and Business Object record ID.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="attachmentid">Specify the internal ID of the attachment record.</param>
        /// <param name="busobid">Specify the Business Object ID.</param>
        /// <param name="busobrecid">Specify the Business Object record ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns></returns>
        public object BusinessObjectRemoveBusinessObjectAttachmentByIdAndRecIdV1 (string attachmentid, string busobid, string busobrecid, string lang = null, string locale = null)
        {
             return BusinessObjectRemoveBusinessObjectAttachmentByIdAndRecIdV1WithHttpInfo(attachmentid, busobid, busobrecid, lang, locale);
        }

        /// <summary>
        /// Remove an attachment by Business Object ID and record ID Operation to remove an attachment from a Business Object using the attachment record ID, Business Object ID, and Business Object record ID.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="attachmentid">Specify the internal ID of the attachment record.</param>
        /// <param name="busobid">Specify the Business Object ID.</param>
        /// <param name="busobrecid">Specify the Business Object record ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        private ApiResponse<object> BusinessObjectRemoveBusinessObjectAttachmentByIdAndRecIdV1WithHttpInfo (string attachmentid, string busobid, string busobrecid, string lang = null, string locale = null)
        {
            // verify the required parameter 'attachmentid' is set
            if (attachmentid == null)
                throw new ApiException(400, "Missing required parameter 'attachmentid' when calling BusinessObjectApi->BusinessObjectRemoveBusinessObjectAttachmentByIdAndRecIdV1");
            // verify the required parameter 'busobid' is set
            if (busobid == null)
                throw new ApiException(400, "Missing required parameter 'busobid' when calling BusinessObjectApi->BusinessObjectRemoveBusinessObjectAttachmentByIdAndRecIdV1");
            // verify the required parameter 'busobrecid' is set
            if (busobrecid == null)
                throw new ApiException(400, "Missing required parameter 'busobrecid' when calling BusinessObjectApi->BusinessObjectRemoveBusinessObjectAttachmentByIdAndRecIdV1");

            var localVarPath = $"/api/V1/removebusinessobjectattachment/attachmentid/{attachmentid}/busobid/{busobid}/busobrecid/{busobrecid}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();

            // to determine the Content-Type header
            var localVarHttpContentTypes = Array.Empty<string>();
            var localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            var localVarHttpHeaderAccepts = Array.Empty<string>();
            var localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            localVarPathParams.Add("attachmentid", Configuration.ApiClient.ParameterToString(attachmentid)); // path parameter
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
                Method.DELETE, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int) localVarResponse.StatusCode;

            var exception = ExceptionFactory?.Invoke("BusinessObjectRemoveBusinessObjectAttachmentByIdAndRecIdV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                null);
        }

        #endregion

        #region BusinessObjectRemoveBusinessObjectAttachmentByNameAndPublicIdV1
        
        /// <summary>
        /// Remove an attachment by Business Object name and public ID Operation to remove an attachment from a Business Object using the attachment record ID, Business Object name, and Business Object record ID.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="attachmentid">Specify the internal ID of the attachment record.</param>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="publicid">Specify the Business Object public ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns></returns>
        public object BusinessObjectRemoveBusinessObjectAttachmentByNameAndPublicIdV1 (string attachmentid, string busobname, string publicid, string lang = null, string locale = null)
        {
             return BusinessObjectRemoveBusinessObjectAttachmentByNameAndPublicIdV1WithHttpInfo(attachmentid, busobname, publicid, lang, locale);
        }

        /// <summary>
        /// Remove an attachment by Business Object name and public ID Operation to remove an attachment from a Business Object using the attachment record ID, Business Object name, and Business Object record ID.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="attachmentid">Specify the internal ID of the attachment record.</param>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="publicid">Specify the Business Object public ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        private ApiResponse<object> BusinessObjectRemoveBusinessObjectAttachmentByNameAndPublicIdV1WithHttpInfo(string attachmentid,
            string busobname, string publicid, string lang = null, string locale = null)
        {
            // verify the required parameter 'attachmentid' is set
            if (attachmentid == null)
                throw new ApiException(400, "Missing required parameter 'attachmentid' when calling BusinessObjectApi->BusinessObjectRemoveBusinessObjectAttachmentByNameAndPublicIdV1");
            // verify the required parameter 'busobname' is set
            if (busobname == null)
                throw new ApiException(400, "Missing required parameter 'busobname' when calling BusinessObjectApi->BusinessObjectRemoveBusinessObjectAttachmentByNameAndPublicIdV1");
            // verify the required parameter 'publicid' is set
            if (publicid == null)
                throw new ApiException(400, "Missing required parameter 'publicid' when calling BusinessObjectApi->BusinessObjectRemoveBusinessObjectAttachmentByNameAndPublicIdV1");

            var localVarPath = $"/api/V1/removebusinessobjectattachment/attachmentid/{attachmentid}/busobname/{busobname}/publicid/{publicid}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();

            // to determine the Content-Type header
            var localVarHttpContentTypes = Array.Empty<string>();
            var localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            var localVarHttpHeaderAccepts = Array.Empty<string>();
            var localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (true) localVarPathParams.Add("attachmentid", Configuration.ApiClient.ParameterToString(attachmentid)); // path parameter
            localVarPathParams.Add("busobname", Configuration.ApiClient.ParameterToString(busobname)); // path parameter
            localVarPathParams.Add("publicid", Configuration.ApiClient.ParameterToString(publicid)); // path parameter
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

            var exception = ExceptionFactory?.Invoke("BusinessObjectRemoveBusinessObjectAttachmentByNameAndPublicIdV1", localVarResponse);
            if (exception != null) throw exception;

           return new ApiResponse<object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                null);
        }
        
        #endregion

        #region BusinessObjectRemoveBusinessObjectAttachmentByNameAndRecIdV1

         /// <summary>
        /// Remove an attachment by Business Object name and record ID Operation to remove an attachment from a Business Object using the attachment record ID, Business Object name, and Business Object public ID.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="attachmentid">Specify the internal ID of the attachment record.</param>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="busobrecid">Specify the Business Object record ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns></returns>
        public object BusinessObjectRemoveBusinessObjectAttachmentByNameAndRecIdV1 (string attachmentid, string busobname, string busobrecid, string lang = null, string locale = null)
        {
             return BusinessObjectRemoveBusinessObjectAttachmentByNameAndRecIdV1WithHttpInfo(attachmentid, busobname, busobrecid, lang, locale);
        }

        /// <summary>
        /// Remove an attachment by Business Object name and record ID Operation to remove an attachment from a Business Object using the attachment record ID, Business Object name, and Business Object public ID.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="attachmentid">Specify the internal ID of the attachment record.</param>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="busobrecid">Specify the Business Object record ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        private ApiResponse<object> BusinessObjectRemoveBusinessObjectAttachmentByNameAndRecIdV1WithHttpInfo (string attachmentid, string busobname, string busobrecid, string lang = null, string locale = null)
        {
            // verify the required parameter 'attachmentid' is set
            if (attachmentid == null)
                throw new ApiException(400, "Missing required parameter 'attachmentid' when calling BusinessObjectApi->BusinessObjectRemoveBusinessObjectAttachmentByNameAndRecIdV1");
            // verify the required parameter 'busobname' is set
            if (busobname == null)
                throw new ApiException(400, "Missing required parameter 'busobname' when calling BusinessObjectApi->BusinessObjectRemoveBusinessObjectAttachmentByNameAndRecIdV1");
            // verify the required parameter 'busobrecid' is set
            if (busobrecid == null)
                throw new ApiException(400, "Missing required parameter 'busobrecid' when calling BusinessObjectApi->BusinessObjectRemoveBusinessObjectAttachmentByNameAndRecIdV1");

            var localVarPath = $"/api/V1/removebusinessobjectattachment/attachmentid/{attachmentid}/busobname/{busobname}/busobrecid/{busobrecid}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();

            // to determine the Content-Type header
            var localVarHttpContentTypes = Array.Empty<string>();
            var localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            var localVarHttpHeaderAccepts = Array.Empty<string>();
            var localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            localVarPathParams.Add("attachmentid", Configuration.ApiClient.ParameterToString(attachmentid)); // path parameter
            localVarPathParams.Add("busobname", Configuration.ApiClient.ParameterToString(busobname)); // path parameter
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
                Method.DELETE, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int) localVarResponse.StatusCode;

            var exception = ExceptionFactory?.Invoke("BusinessObjectRemoveBusinessObjectAttachmentByNameAndRecIdV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                null);
        }

        #endregion

        #region BusinessObjectSaveBusinessObjectAttachmentBusObV1
        
        /// <summary>
        /// Attach a Business Object to a Business Object Operation to attach a Business Object to a Business Object. This links the Business Object but does not create a relationship between the two. (Use \&quot;Link Related Business Objects\&quot; to create a relationship.)
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object used to specify the Business Objects to attach. You can use Business Object name or ID and Business Object record ID or public ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsBusinessObjectAttachmentsResponse</returns>
        public AttachmentsResponse BusinessObjectSaveBusinessObjectAttachmentBusObV1 (SaveBusObAttachmentRequest request, string lang = null, string locale = null)
        {
             return BusinessObjectSaveBusinessObjectAttachmentBusObV1WithHttpInfo(request, lang, locale).Data;
        }

        /// <summary>
        /// Attach a Business Object to a Business Object Operation to attach a Business Object to a Business Object. This links the Business Object but does not create a relationship between the two. (Use \&quot;Link Related Business Objects\&quot; to create a relationship.)
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object used to specify the Business Objects to attach. You can use Business Object name or ID and Business Object record ID or public ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsBusinessObjectAttachmentsResponse</returns>
        private ApiResponse< AttachmentsResponse > BusinessObjectSaveBusinessObjectAttachmentBusObV1WithHttpInfo (SaveBusObAttachmentRequest request, string lang = null, string locale = null)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling BusinessObjectApi->BusinessObjectSaveBusinessObjectAttachmentBusObV1");

            var localVarPath = $"/api/V1/savebusinessobjectattachmentbusob";
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
            var localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int) localVarResponse.StatusCode;

            var exception = ExceptionFactory?.Invoke("BusinessObjectSaveBusinessObjectAttachmentBusObV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<AttachmentsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (AttachmentsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AttachmentsResponse)));
        }
        

        #endregion

        #region BusinessObjectSaveBusinessObjectAttachmentLinkV1

         /// <summary>
        /// Attach a file via UNC Operation to attach a file to a Business Object via a path (UNC recommended).
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object used to specify the file path (UNC recommended) and the Business Object. You can use Business Object name or ID and Business Object record ID or public ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsBusinessObjectAttachmentsResponse</returns>
        public AttachmentsResponse BusinessObjectSaveBusinessObjectAttachmentLinkV1 (SaveLinkAttachmentRequest request, string lang = null, string locale = null)
        {
             return  BusinessObjectSaveBusinessObjectAttachmentLinkV1WithHttpInfo(request, lang, locale).Data;
        }

        /// <summary>
        /// Attach a file via UNC Operation to attach a file to a Business Object via a path (UNC recommended).
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object used to specify the file path (UNC recommended) and the Business Object. You can use Business Object name or ID and Business Object record ID or public ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsBusinessObjectAttachmentsResponse</returns>
        private ApiResponse< AttachmentsResponse > BusinessObjectSaveBusinessObjectAttachmentLinkV1WithHttpInfo (SaveLinkAttachmentRequest request, string lang = null, string locale = null)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling BusinessObjectApi->BusinessObjectSaveBusinessObjectAttachmentLinkV1");

            const string varPath = "/api/V1/savebusinessobjectattachmentlink";
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int) localVarResponse.StatusCode;

            var exception = ExceptionFactory?.Invoke("BusinessObjectSaveBusinessObjectAttachmentLinkV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<AttachmentsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (AttachmentsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AttachmentsResponse)));
        }

        #endregion
        
        #region BusinessObjectSaveBusinessObjectAttachmentUrlV1

           /// <summary>
        /// Attach a URL path Operation to attach a URL path to a Business Object.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object used to specify the URL path and Business Object. You can use Business Object name or ID and Business Object record ID or public ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsBusinessObjectAttachmentsResponse</returns>
        public AttachmentsResponse BusinessObjectSaveBusinessObjectAttachmentUrlV1 (SaveUrlAttachmentRequest request, string lang = null, string locale = null)
        {
             return BusinessObjectSaveBusinessObjectAttachmentUrlV1WithHttpInfo(request, lang, locale).Data;
        }
           
        /// <summary>
        /// Attach a URL path Operation to attach a URL path to a Business Object.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object used to specify the URL path and Business Object. You can use Business Object name or ID and Business Object record ID or public ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsBusinessObjectAttachmentsResponse</returns>
        private ApiResponse< AttachmentsResponse > BusinessObjectSaveBusinessObjectAttachmentUrlV1WithHttpInfo (SaveUrlAttachmentRequest request, string lang = null, string locale = null)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling BusinessObjectApi->BusinessObjectSaveBusinessObjectAttachmentUrlV1");

            const string varPath = "/api/V1/savebusinessobjectattachmenturl";
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int) localVarResponse.StatusCode;

            var exception = ExceptionFactory?.Invoke("BusinessObjectSaveBusinessObjectAttachmentUrlV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<AttachmentsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (AttachmentsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AttachmentsResponse)));
        }

        #endregion

        #region BusinessObjectSaveBusinessObjectV1

         /// <summary>
        /// Create or Update a Business Object Operation that creates a new Business Object or updates an existing Business Object. To create, leave record ID and public ID empty. Upon creating or saving, a cache key is returned to use for subsequent requests. If the object is not found in the cache with said cache key, specify record ID or public ID to save and return a new cache key. Set persist &#x3D; true, to actually save the Business Object to disk, persist &#x3D; false will just cache it.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Specify a list of fields from a Business Object template. </param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsBusinessObjectSaveResponse</returns>
        public SaveResponse BusinessObjectSaveBusinessObjectV1 (SaveRequest request, string lang = null, string locale = null)
        {
             var localVarResponse = BusinessObjectSaveBusinessObjectV1WithHttpInfo(request, lang, locale);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create or Update a Business Object Operation that creates a new Business Object or updates an existing Business Object. To create, leave record ID and public ID empty. Upon creating or saving, a cache key is returned to use for subsequent requests. If the object is not found in the cache with said cache key, specify record ID or public ID to save and return a new cache key. Set persist &#x3D; true, to actually save the Business Object to disk, persist &#x3D; false will just cache it.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Specify a list of fields from a Business Object template. </param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsBusinessObjectSaveResponse</returns>
        private ApiResponse< SaveResponse > BusinessObjectSaveBusinessObjectV1WithHttpInfo (SaveRequest request, string lang = null, string locale = null)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling BusinessObjectApi->BusinessObjectSaveBusinessObjectV1");

            const string varPath = "/api/V1/savebusinessobject";
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

            var exception = ExceptionFactory?.Invoke("BusinessObjectSaveBusinessObjectV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<SaveResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (SaveResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SaveResponse)));
        }

        #endregion

        #region BusinessObjectSaveRelatedBusinessObjectV1

        /// <summary>
        /// Create or update a related Business Object Operation that creates or updates a related Business Object. To update, specify record ID or public ID. To create, leave record ID and public ID empty.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object specifying the parent the Business Object, the Relationship, and field values for the Business Object to create or update. </param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsBusinessObjectRelatedSaveResponse</returns>
        public RelatedSaveResponse BusinessObjectSaveRelatedBusinessObjectV1 (RelatedSaveRequest request, string lang = null, string locale = null)
        {
             return BusinessObjectSaveRelatedBusinessObjectV1WithHttpInfo(request, lang, locale).Data;
        }

        /// <summary>
        /// Create or update a related Business Object Operation that creates or updates a related Business Object. To update, specify record ID or public ID. To create, leave record ID and public ID empty.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object specifying the parent the Business Object, the Relationship, and field values for the Business Object to create or update. </param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsBusinessObjectRelatedSaveResponse</returns>
        private ApiResponse< RelatedSaveResponse > BusinessObjectSaveRelatedBusinessObjectV1WithHttpInfo (RelatedSaveRequest request, string lang = null, string locale = null)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling BusinessObjectApi->BusinessObjectSaveRelatedBusinessObjectV1");

            var localVarPath = $"/api/V1/saverelatedbusinessobject";
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
            var localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int) localVarResponse.StatusCode;

            var exception = ExceptionFactory?.Invoke("BusinessObjectSaveRelatedBusinessObjectV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<RelatedSaveResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (RelatedSaveResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RelatedSaveResponse)));
        }
        
        #endregion

        #region BusinessObjectUnLinkRelatedBusinessObjectByRecIdV1

         /// <summary>
        /// UnLink related Business Objects Operation to unlink related Business Objects.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="parentbusobid">Specify the Business Object ID for the parent Business Object.</param>
        /// <param name="parentbusobrecid">Specify the record ID for the parent Business Object.</param>
        /// <param name="relationshipid">Specify the Relationship ID for the related Business Object you want to unlink.</param>
        /// <param name="busobid">Specify the Business Object ID of the Business Object to be unlinked.</param>
        /// <param name="busobrecid">Specify the Business Object record ID of the Business Object to be unlinked.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsSearchesRelatedBusinessObjectResponse</returns>
        public TrebuchetWebApiDataContractsSearchesRelatedBusinessObjectResponse BusinessObjectUnLinkRelatedBusinessObjectByRecIdV1 (string parentbusobid, string parentbusobrecid, string relationshipid, string busobid, string busobrecid, string lang = null, string locale = null)
        {
             return BusinessObjectUnLinkRelatedBusinessObjectByRecIdV1WithHttpInfo(parentbusobid, parentbusobrecid, relationshipid, busobid, busobrecid, lang, locale).Data;
        }

        /// <summary>
        /// UnLink related Business Objects Operation to unlink related Business Objects.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="parentbusobid">Specify the Business Object ID for the parent Business Object.</param>
        /// <param name="parentbusobrecid">Specify the record ID for the parent Business Object.</param>
        /// <param name="relationshipid">Specify the Relationship ID for the related Business Object you want to unlink.</param>
        /// <param name="busobid">Specify the Business Object ID of the Business Object to be unlinked.</param>
        /// <param name="busobrecid">Specify the Business Object record ID of the Business Object to be unlinked.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsSearchesRelatedBusinessObjectResponse</returns>
        private ApiResponse< TrebuchetWebApiDataContractsSearchesRelatedBusinessObjectResponse > BusinessObjectUnLinkRelatedBusinessObjectByRecIdV1WithHttpInfo (string parentbusobid, string parentbusobrecid, string relationshipid, string busobid, string busobrecid, string lang = null, string locale = null)
        {
            // verify the required parameter 'parentbusobid' is set
            if (parentbusobid == null)
                throw new ApiException(400, "Missing required parameter 'parentbusobid' when calling BusinessObjectApi->BusinessObjectUnLinkRelatedBusinessObjectByRecIdV1");
            // verify the required parameter 'parentbusobrecid' is set
            if (parentbusobrecid == null)
                throw new ApiException(400, "Missing required parameter 'parentbusobrecid' when calling BusinessObjectApi->BusinessObjectUnLinkRelatedBusinessObjectByRecIdV1");
            // verify the required parameter 'relationshipid' is set
            if (relationshipid == null)
                throw new ApiException(400, "Missing required parameter 'relationshipid' when calling BusinessObjectApi->BusinessObjectUnLinkRelatedBusinessObjectByRecIdV1");
            // verify the required parameter 'busobid' is set
            if (busobid == null)
                throw new ApiException(400, "Missing required parameter 'busobid' when calling BusinessObjectApi->BusinessObjectUnLinkRelatedBusinessObjectByRecIdV1");
            // verify the required parameter 'busobrecid' is set
            if (busobrecid == null)
                throw new ApiException(400, "Missing required parameter 'busobrecid' when calling BusinessObjectApi->BusinessObjectUnLinkRelatedBusinessObjectByRecIdV1");

            var localVarPath = $"/api/V1/unlinkrelatedbusinessobject/parentbusobid/{parentbusobid}/parentbusobrecid/{parentbusobrecid}/relationshipid/{relationshipid}/busobid/{busobid}/busobrecid/{busobrecid}";
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

            localVarPathParams.Add("parentbusobid", Configuration.ApiClient.ParameterToString(parentbusobid)); // path parameter
            localVarPathParams.Add("parentbusobrecid", Configuration.ApiClient.ParameterToString(parentbusobrecid)); // path parameter
            localVarPathParams.Add("relationshipid", Configuration.ApiClient.ParameterToString(relationshipid)); // path parameter
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
                Method.DELETE, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int) localVarResponse.StatusCode;

            var exception = ExceptionFactory?.Invoke("BusinessObjectUnLinkRelatedBusinessObjectByRecIdV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<TrebuchetWebApiDataContractsSearchesRelatedBusinessObjectResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (TrebuchetWebApiDataContractsSearchesRelatedBusinessObjectResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TrebuchetWebApiDataContractsSearchesRelatedBusinessObjectResponse)));
        }

        #endregion

        #region BusinessObjectUploadBusinessObjectAttachmentByIdAndPublicIdV1

        /// <summary>
        /// Upload an attachment by Business Object ID and public ID Operation to upload an attachment to a Business Object record using a Business Object ID and public ID. The body of the request is the byte array of the file part being uploaded.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="filename">Specify the name of the file being uploaded. If no attachment name is provided, the file name is used.</param>
        /// <param name="busobid">Specify the Business Object ID.</param>
        /// <param name="publicid">Specify the Business Object public ID  to attach the file to.</param>
        /// <param name="offset">The offset is the starting index of the file part being uploaded.  If this is the first part then the offset will be zero.</param>
        /// <param name="totalsize">The entire file size in bytes.</param>
        /// <param name="attachmentid">Specify the attachment ID of an uploaded file to upload subsequent parts and ensure each part gets appended to the parts that have already been uploaded. (optional)</param>
        /// <param name="displaytext">Specify the attachment name, which is the display text for the attachment record. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>string</returns>
        public string BusinessObjectUploadBusinessObjectAttachmentByIdAndPublicIdV1 (byte[] body, string filename, string busobid, string publicid, int? offset, int? totalsize, string attachmentid = null, string displaytext = null, string lang = null, string locale = null)
        {
             var localVarResponse = BusinessObjectUploadBusinessObjectAttachmentByIdAndPublicIdV1WithHttpInfo(body, filename, busobid, publicid, offset, totalsize, attachmentid, displaytext, lang, locale);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Upload an attachment by Business Object ID and public ID Operation to upload an attachment to a Business Object record using a Business Object ID and public ID. The body of the request is the byte array of the file part being uploaded.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="filename">Specify the name of the file being uploaded. If no attachment name is provided, the file name is used.</param>
        /// <param name="busobid">Specify the Business Object ID.</param>
        /// <param name="publicid">Specify the Business Object public ID  to attach the file to.</param>
        /// <param name="offset">The offset is the starting index of the file part being uploaded.  If this is the first part then the offset will be zero.</param>
        /// <param name="totalsize">The entire file size in bytes.</param>
        /// <param name="attachmentid">Specify the attachment ID of an uploaded file to upload subsequent parts and ensure each part gets appended to the parts that have already been uploaded. (optional)</param>
        /// <param name="displaytext">Specify the attachment name, which is the display text for the attachment record. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of string</returns>
        private ApiResponse< string > BusinessObjectUploadBusinessObjectAttachmentByIdAndPublicIdV1WithHttpInfo (byte[] body, string filename, string busobid, string publicid, int? offset, int? totalsize, string attachmentid = null, string displaytext = null, string lang = null, string locale = null)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling BusinessObjectApi->BusinessObjectUploadBusinessObjectAttachmentByIdAndPublicIdV1");
            // verify the required parameter 'filename' is set
            if (filename == null)
                throw new ApiException(400, "Missing required parameter 'filename' when calling BusinessObjectApi->BusinessObjectUploadBusinessObjectAttachmentByIdAndPublicIdV1");
            // verify the required parameter 'busobid' is set
            if (busobid == null)
                throw new ApiException(400, "Missing required parameter 'busobid' when calling BusinessObjectApi->BusinessObjectUploadBusinessObjectAttachmentByIdAndPublicIdV1");
            // verify the required parameter 'publicid' is set
            if (publicid == null)
                throw new ApiException(400, "Missing required parameter 'publicid' when calling BusinessObjectApi->BusinessObjectUploadBusinessObjectAttachmentByIdAndPublicIdV1");
            // verify the required parameter 'offset' is set
            if (offset == null)
                throw new ApiException(400, "Missing required parameter 'offset' when calling BusinessObjectApi->BusinessObjectUploadBusinessObjectAttachmentByIdAndPublicIdV1");
            // verify the required parameter 'totalsize' is set
            if (totalsize == null)
                throw new ApiException(400, "Missing required parameter 'totalsize' when calling BusinessObjectApi->BusinessObjectUploadBusinessObjectAttachmentByIdAndPublicIdV1");

            var localVarPath = $"/api/V1/uploadbusinessobjectattachment/filename/{filename}/busobid/{busobid}/publicid/{publicid}/offset/{offset}/totalsize/{totalsize}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody;

            // to determine the Content-Type header
            var localVarHttpContentTypes = new[] {
                "application/octet-stream"
            };
            var localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
            
            var localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(LocalVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            localVarPathParams.Add("filename", Configuration.ApiClient.ParameterToString(filename)); // path parameter
            localVarPathParams.Add("busobid", Configuration.ApiClient.ParameterToString(busobid)); // path parameter
            localVarPathParams.Add("publicid", Configuration.ApiClient.ParameterToString(publicid)); // path parameter
            localVarPathParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // path parameter
            localVarPathParams.Add("totalsize", Configuration.ApiClient.ParameterToString(totalsize)); // path parameter
            if (attachmentid != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "attachmentid", attachmentid)); // query parameter
            if (displaytext != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "displaytext", displaytext)); // query parameter
            if (lang != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
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

            var exception = ExceptionFactory?.Invoke("BusinessObjectUploadBusinessObjectAttachmentByIdAndPublicIdV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

        #endregion

        #region BusinessObjectUploadBusinessObjectAttachmentByIdAndRecIdV1

        /// <summary>
        /// Upload an attachment by Business Object ID and record ID Operation to upload an attachment to a Business Object record using a Business Object ID and record ID. The body of the request is the byte array of the file part being uploaded.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="filename">Specify the name of the file being uploaded. If no attachment name is provided, the file name is used.</param>
        /// <param name="busobid">Specify the Business Object ID.</param>
        /// <param name="busobrecid">Specify the Business Object record ID to attach the file to.</param>
        /// <param name="offset">The offset is the starting index of the file part being uploaded.  If this is the first part then the offset will be zero.</param>
        /// <param name="totalsize">The entire file size in bytes.</param>
        /// <param name="attachmentid">Specify the attachment ID of an uploaded file to upload subsequent parts and ensure each part gets appended to the parts that have already been uploaded. (optional)</param>
        /// <param name="displaytext">Specify the attachment name, which is the display text for the attachment record. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>string</returns>
        public string BusinessObjectUploadBusinessObjectAttachmentByIdAndRecIdV1 (byte[] body, string filename, string busobid, string busobrecid, int? offset, int? totalsize, string attachmentid = null, string displaytext = null, string lang = null, string locale = null)
        {
             return BusinessObjectUploadBusinessObjectAttachmentByIdAndRecIdV1WithHttpInfo(body, filename, busobid, busobrecid, offset, totalsize, attachmentid, displaytext, lang, locale).Data;
        }

        /// <summary>
        /// Upload an attachment by Business Object ID and record ID Operation to upload an attachment to a Business Object record using a Business Object ID and record ID. The body of the request is the byte array of the file part being uploaded.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="filename">Specify the name of the file being uploaded. If no attachment name is provided, the file name is used.</param>
        /// <param name="busobid">Specify the Business Object ID.</param>
        /// <param name="busobrecid">Specify the Business Object record ID to attach the file to.</param>
        /// <param name="offset">The offset is the starting index of the file part being uploaded.  If this is the first part then the offset will be zero.</param>
        /// <param name="totalsize">The entire file size in bytes.</param>
        /// <param name="attachmentid">Specify the attachment ID of an uploaded file to upload subsequent parts and ensure each part gets appended to the parts that have already been uploaded. (optional)</param>
        /// <param name="displaytext">Specify the attachment name, which is the display text for the attachment record. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of string</returns>
        private ApiResponse< string > BusinessObjectUploadBusinessObjectAttachmentByIdAndRecIdV1WithHttpInfo (byte[] body, string filename, string busobid, string busobrecid, int? offset, int? totalsize, string attachmentid = null, string displaytext = null, string lang = null, string locale = null)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling BusinessObjectApi->BusinessObjectUploadBusinessObjectAttachmentByIdAndRecIdV1");
            // verify the required parameter 'filename' is set
            if (filename == null)
                throw new ApiException(400, "Missing required parameter 'filename' when calling BusinessObjectApi->BusinessObjectUploadBusinessObjectAttachmentByIdAndRecIdV1");
            // verify the required parameter 'busobid' is set
            if (busobid == null)
                throw new ApiException(400, "Missing required parameter 'busobid' when calling BusinessObjectApi->BusinessObjectUploadBusinessObjectAttachmentByIdAndRecIdV1");
            // verify the required parameter 'busobrecid' is set
            if (busobrecid == null)
                throw new ApiException(400, "Missing required parameter 'busobrecid' when calling BusinessObjectApi->BusinessObjectUploadBusinessObjectAttachmentByIdAndRecIdV1");
            // verify the required parameter 'offset' is set
            if (offset == null)
                throw new ApiException(400, "Missing required parameter 'offset' when calling BusinessObjectApi->BusinessObjectUploadBusinessObjectAttachmentByIdAndRecIdV1");
            // verify the required parameter 'totalsize' is set
            if (totalsize == null)
                throw new ApiException(400, "Missing required parameter 'totalsize' when calling BusinessObjectApi->BusinessObjectUploadBusinessObjectAttachmentByIdAndRecIdV1");

            var localVarPath = $"/api/V1/uploadbusinessobjectattachment/filename/{filename}/busobid/{busobid}/busobrecid/{busobrecid}/offset/{offset}/totalsize/{totalsize}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody;

            // to determine the Content-Type header
            var localVarHttpContentTypes = new[] {
                "application/octet-stream"
            };
            var localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
            
            var localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(LocalVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            localVarPathParams.Add("filename", Configuration.ApiClient.ParameterToString(filename)); // path parameter
            localVarPathParams.Add("busobid", Configuration.ApiClient.ParameterToString(busobid)); // path parameter
            localVarPathParams.Add("busobrecid", Configuration.ApiClient.ParameterToString(busobrecid)); // path parameter
            localVarPathParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // path parameter
            localVarPathParams.Add("totalsize", Configuration.ApiClient.ParameterToString(totalsize)); // path parameter
            if (attachmentid != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "attachmentid", attachmentid)); // query parameter
            if (displaytext != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "displaytext", displaytext)); // query parameter
            if (lang != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
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

            var exception = ExceptionFactory?.Invoke("BusinessObjectUploadBusinessObjectAttachmentByIdAndRecIdV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

        #endregion

        #region BusinessObjectUploadBusinessObjectAttachmentByNameAndPublicIdV1
        
        /// <summary>
        /// Upload an attachment by Business Object name and public ID Operation to upload an attachment to a Business Object record using a Business Object name and public ID. The body of the request is the byte array of the file part being uploaded.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="filename">Specify the name of the file being uploaded. If no attachment name is provided, the file name is used.</param>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="publicid">Specify the Business Object public ID  to attach the file to.</param>
        /// <param name="offset">The offset is the starting index of the file part being uploaded.  If this is the first part then the offset will be zero.</param>
        /// <param name="totalsize">The entire file size in bytes.</param>
        /// <param name="attachmentid">Specify the attachment ID of an uploaded file to upload subsequent parts and ensure each part gets appended to the parts that have already been uploaded. (optional)</param>
        /// <param name="displaytext">Specify the attachment name, which is the display text for the attachment record. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>string</returns>
        public string BusinessObjectUploadBusinessObjectAttachmentByNameAndPublicIdV1 (byte[] body, string filename, string busobname, string publicid, int? offset, int? totalsize, string attachmentid = null, string displaytext = null, string lang = null, string locale = null)
        {
             return BusinessObjectUploadBusinessObjectAttachmentByNameAndPublicIdV1WithHttpInfo(body, filename, busobname, publicid, offset, totalsize, attachmentid, displaytext, lang, locale).Data;
            
        }

        /// <summary>
        /// Upload an attachment by Business Object name and public ID Operation to upload an attachment to a Business Object record using a Business Object name and public ID. The body of the request is the byte array of the file part being uploaded.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="filename">Specify the name of the file being uploaded. If no attachment name is provided, the file name is used.</param>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="publicid">Specify the Business Object public ID  to attach the file to.</param>
        /// <param name="offset">The offset is the starting index of the file part being uploaded.  If this is the first part then the offset will be zero.</param>
        /// <param name="totalsize">The entire file size in bytes.</param>
        /// <param name="attachmentid">Specify the attachment ID of an uploaded file to upload subsequent parts and ensure each part gets appended to the parts that have already been uploaded. (optional)</param>
        /// <param name="displaytext">Specify the attachment name, which is the display text for the attachment record. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of string</returns>
        private ApiResponse< string > BusinessObjectUploadBusinessObjectAttachmentByNameAndPublicIdV1WithHttpInfo (byte[] body, string filename, string busobname, string publicid, int? offset, int? totalsize, string attachmentid = null, string displaytext = null, string lang = null, string locale = null)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling BusinessObjectApi->BusinessObjectUploadBusinessObjectAttachmentByNameAndPublicIdV1");
            // verify the required parameter 'filename' is set
            if (filename == null)
                throw new ApiException(400, "Missing required parameter 'filename' when calling BusinessObjectApi->BusinessObjectUploadBusinessObjectAttachmentByNameAndPublicIdV1");
            // verify the required parameter 'busobname' is set
            if (busobname == null)
                throw new ApiException(400, "Missing required parameter 'busobname' when calling BusinessObjectApi->BusinessObjectUploadBusinessObjectAttachmentByNameAndPublicIdV1");
            // verify the required parameter 'publicid' is set
            if (publicid == null)
                throw new ApiException(400, "Missing required parameter 'publicid' when calling BusinessObjectApi->BusinessObjectUploadBusinessObjectAttachmentByNameAndPublicIdV1");
            // verify the required parameter 'offset' is set
            if (offset == null)
                throw new ApiException(400, "Missing required parameter 'offset' when calling BusinessObjectApi->BusinessObjectUploadBusinessObjectAttachmentByNameAndPublicIdV1");
            // verify the required parameter 'totalsize' is set
            if (totalsize == null)
                throw new ApiException(400, "Missing required parameter 'totalsize' when calling BusinessObjectApi->BusinessObjectUploadBusinessObjectAttachmentByNameAndPublicIdV1");

            var localVarPath = "/api/V1/uploadbusinessobjectattachment/filename/{filename}/busobname/{busobname}/publicid/{publicid}/offset/{offset}/totalsize/{totalsize}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody;

            // to determine the Content-Type header
            var localVarHttpContentTypes = new[] {
                "application/octet-stream"
            };
            var localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            
            var localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(LocalVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            localVarPathParams.Add("filename", Configuration.ApiClient.ParameterToString(filename)); // path parameter
            localVarPathParams.Add("busobname", Configuration.ApiClient.ParameterToString(busobname)); // path parameter
            localVarPathParams.Add("publicid", Configuration.ApiClient.ParameterToString(publicid)); // path parameter
            localVarPathParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // path parameter
            localVarPathParams.Add("totalsize", Configuration.ApiClient.ParameterToString(totalsize)); // path parameter
            if (attachmentid != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "attachmentid", attachmentid)); // query parameter
            if (displaytext != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "displaytext", displaytext)); // query parameter
            if (lang != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
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

            var exception = ExceptionFactory?.Invoke("BusinessObjectUploadBusinessObjectAttachmentByNameAndPublicIdV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }
        

        #endregion

        #region BusinessObjectUploadBusinessObjectAttachmentByNameAndRecIdV1

                /// <summary>
        /// Upload an attachment by Business Object name and record ID Operation to upload an attachment to a Business Object record using a Business Object name and record ID. The body of the request is the byte array of the file part being uploaded.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="filename">Specify the name of the file being uploaded. If no attachment name is provided, the file name is used.</param>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="busobrecid">Specify the Business Object record ID to attach the file to.</param>
        /// <param name="offset">The offset is the starting index of the file part being uploaded.  If this is the first part then the offset will be zero.</param>
        /// <param name="totalsize">The entire file size in bytes.</param>
        /// <param name="attachmentid">Specify the attachment ID of an uploaded file to upload subsequent parts and ensure each part gets appended to the parts that have already been uploaded. (optional)</param>
        /// <param name="displaytext">Specify the attachment name, which is the display text for the attachment record. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>string</returns>
        public string BusinessObjectUploadBusinessObjectAttachmentByNameAndRecIdV1 (byte[] body, string filename, string busobname, string busobrecid, int? offset, int? totalsize, string attachmentid = null, string displaytext = null, string lang = null, string locale = null)
        {
             return BusinessObjectUploadBusinessObjectAttachmentByNameAndRecIdV1WithHttpInfo(body, filename, busobname, busobrecid, offset, totalsize, attachmentid, displaytext, lang, locale).Data;
        }

        /// <summary>
        /// Upload an attachment by Business Object name and record ID Operation to upload an attachment to a Business Object record using a Business Object name and record ID. The body of the request is the byte array of the file part being uploaded.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="filename">Specify the name of the file being uploaded. If no attachment name is provided, the file name is used.</param>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="busobrecid">Specify the Business Object record ID to attach the file to.</param>
        /// <param name="offset">The offset is the starting index of the file part being uploaded.  If this is the first part then the offset will be zero.</param>
        /// <param name="totalsize">The entire file size in bytes.</param>
        /// <param name="attachmentid">Specify the attachment ID of an uploaded file to upload subsequent parts and ensure each part gets appended to the parts that have already been uploaded. (optional)</param>
        /// <param name="displaytext">Specify the attachment name, which is the display text for the attachment record. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of string</returns>
        private ApiResponse< string > BusinessObjectUploadBusinessObjectAttachmentByNameAndRecIdV1WithHttpInfo (byte[] body, string filename, string busobname, string busobrecid, int? offset, int? totalsize, string attachmentid = null, string displaytext = null, string lang = null, string locale = null)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling BusinessObjectApi->BusinessObjectUploadBusinessObjectAttachmentByNameAndRecIdV1");
            // verify the required parameter 'filename' is set
            if (filename == null)
                throw new ApiException(400, "Missing required parameter 'filename' when calling BusinessObjectApi->BusinessObjectUploadBusinessObjectAttachmentByNameAndRecIdV1");
            // verify the required parameter 'busobname' is set
            if (busobname == null)
                throw new ApiException(400, "Missing required parameter 'busobname' when calling BusinessObjectApi->BusinessObjectUploadBusinessObjectAttachmentByNameAndRecIdV1");
            // verify the required parameter 'busobrecid' is set
            if (busobrecid == null)
                throw new ApiException(400, "Missing required parameter 'busobrecid' when calling BusinessObjectApi->BusinessObjectUploadBusinessObjectAttachmentByNameAndRecIdV1");
            // verify the required parameter 'offset' is set
            if (offset == null)
                throw new ApiException(400, "Missing required parameter 'offset' when calling BusinessObjectApi->BusinessObjectUploadBusinessObjectAttachmentByNameAndRecIdV1");
            // verify the required parameter 'totalsize' is set
            if (totalsize == null)
                throw new ApiException(400, "Missing required parameter 'totalsize' when calling BusinessObjectApi->BusinessObjectUploadBusinessObjectAttachmentByNameAndRecIdV1");

            var localVarPath = "/api/V1/uploadbusinessobjectattachment/filename/{filename}/busobname/{busobname}/busobrecid/{busobrecid}/offset/{offset}/totalsize/{totalsize}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody;

            // to determine the Content-Type header
            var localVarHttpContentTypes = new[] {
                "application/octet-stream"
            };
            var localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            
            var localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(LocalVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            localVarPathParams.Add("filename", Configuration.ApiClient.ParameterToString(filename)); // path parameter
            localVarPathParams.Add("busobname", Configuration.ApiClient.ParameterToString(busobname)); // path parameter
            localVarPathParams.Add("busobrecid", Configuration.ApiClient.ParameterToString(busobrecid)); // path parameter
            localVarPathParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // path parameter
            localVarPathParams.Add("totalsize", Configuration.ApiClient.ParameterToString(totalsize)); // path parameter
            if (attachmentid != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "attachmentid", attachmentid)); // query parameter
            if (displaytext != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "displaytext", displaytext)); // query parameter
            if (lang != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
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

            var exception = ExceptionFactory?.Invoke("BusinessObjectUploadBusinessObjectAttachmentByNameAndRecIdV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

        #endregion
        
        public BatchSaveResponse BusinessObjectSaveBusinessObjectBatchV1(
            BatchSaveRequest request, string lang = null, string locale = null)
        {
            return  BusinessObjectSaveBusinessObjectBatchV1WithHttpInfo(request, lang, locale).Data;
        }
        
        /// <summary>
        /// Create or update a batch of Business Objects Operation that creates or updates an array of Business Objects in a batch. To update, specify record ID or public ID. To create, leave record ID and public ID empty.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Specify the array of Business Object templates. </param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsBusinessObjectBatchSaveResponse</returns>
        private ApiResponse< BatchSaveResponse > BusinessObjectSaveBusinessObjectBatchV1WithHttpInfo (BatchSaveRequest request, string lang = null, string locale = null)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling BusinessObjectApi->BusinessObjectSaveBusinessObjectBatchV1");

            const string varPath = "/api/V1/savebusinessobjectbatch";
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

            var exception = ExceptionFactory?.Invoke("BusinessObjectSaveBusinessObjectBatchV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<BatchSaveResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (BatchSaveResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BatchSaveResponse)));
        }
        
    }
}
