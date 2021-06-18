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
    public class UsersApi : BaseApi, IUsersApi
    {
        #region Variables & Properties

        private static UsersApi _instance;

        private static readonly object Padlock = new();

        public static UsersApi Instance
        {
            get
            {
                lock (Padlock)
                {
                    return _instance ??= new UsersApi();
                }
            }
            set => _instance = value;
        }

        #endregion

        #region Contructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="UsersApi" /> class.
        /// </summary>
        /// <returns></returns>
        public UsersApi(string basePath)
        {
            Configuration = new Configuration {BasePath = basePath};

            ExceptionFactory = Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="UsersApi" /> class
        ///     using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public UsersApi(Configuration configuration = null)
        {
            Configuration = configuration ?? Configuration.Default;

            ExceptionFactory = Configuration.DefaultExceptionFactory;
        }

        #endregion

        #region UsersDeleteUserBatchV1

        /// <summary>
        ///     Delete a batch of users Operation to delete a batch of users. To get record IDs, use \&quot;Get a user by login ID\
        ///     &quot; or \&quot;Get a user by public id.\&quot;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object listing record IDs for users to be deleted and an error flag.</param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>UserBatchDeleteResponse</returns>
        public UserBatchDeleteResponse UsersDeleteUserBatchV1(UserBatchDeleteRequest request, string lang = null,
            string locale = null)
        {
            return UsersDeleteUserBatchV1WithHttpInfo(request, lang, locale).Data;
        }

        /// <summary>
        ///     Delete a batch of users Operation to delete a batch of users. To get record IDs, use \&quot;Get a user by login ID\
        ///     &quot; or \&quot;Get a user by public id.\&quot;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object listing record IDs for users to be deleted and an error flag.</param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>ApiResponse of UserBatchDeleteResponse</returns>
        private ApiResponse<UserBatchDeleteResponse> UsersDeleteUserBatchV1WithHttpInfo(UserBatchDeleteRequest request,
            string lang = null, string locale = null)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling UsersApi->UsersDeleteUserBatchV1");

            const string varPath = "/api/V1/deleteuserbatch";
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

            var exception = ExceptionFactory?.Invoke("UsersDeleteUserBatchV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<UserBatchDeleteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (UserBatchDeleteResponse) Configuration.ApiClient.Deserialize(localVarResponse,
                    typeof(UserBatchDeleteResponse)));
        }

        #endregion

        #region UsersDeleteUserBatchV2

        /// <summary>
        ///     Delete a batch of users Operation to delete a batch of users. To get record IDs, use \&quot;Get a user by login ID\
        ///     &quot; or \&quot;Get a user by public id.\&quot;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object listing record IDs for users to be deleted and an error flag.</param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>UserBatchDeleteV2Response</returns>
        public UserBatchDeleteV2Response UsersDeleteUserBatchV2(UserBatchDeleteRequest request, string lang = null,
            string locale = null)
        {
            return UsersDeleteUserBatchV2WithHttpInfo(request, lang, locale).Data;
        }

        /// <summary>
        ///     Delete a batch of users Operation to delete a batch of users. To get record IDs, use \&quot;Get a user by login ID\
        ///     &quot; or \&quot;Get a user by public id.\&quot;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object listing record IDs for users to be deleted and an error flag.</param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>ApiResponse of UserBatchDeleteV2Response</returns>
        private ApiResponse<UserBatchDeleteV2Response> UsersDeleteUserBatchV2WithHttpInfo(
            UserBatchDeleteRequest request, string lang = null, string locale = null)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling UsersApi->UsersDeleteUserBatchV2");

            const string varPath = "/api/V2/deleteuserbatch";
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

            var exception = ExceptionFactory?.Invoke("UsersDeleteUserBatchV2", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<UserBatchDeleteV2Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (UserBatchDeleteV2Response) Configuration.ApiClient.Deserialize(localVarResponse,
                    typeof(UserBatchDeleteV2Response)));
        }

        #endregion

        #region UsersDeleteUserV1

        /// <summary>
        ///     Delete a user by record ID Operation to delete a user by record ID. To get record IDs, use \&quot;Get a user by
        ///     login ID\&quot; or \&quot;Get a user by public id.\&quot;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="userrecordid">Specify the record ID of the user you want to delete</param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>UserDeleteResponse</returns>
        public UserDeleteResponse UsersDeleteUserV1(string userrecordid, string lang = null, string locale = null)
        {
            return UsersDeleteUserV1WithHttpInfo(userrecordid, lang, locale).Data;
        }

        /// <summary>
        ///     Delete a user by record ID Operation to delete a user by record ID. To get record IDs, use \&quot;Get a user by
        ///     login ID\&quot; or \&quot;Get a user by public id.\&quot;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="userrecordid">Specify the record ID of the user you want to delete</param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>ApiResponse of UserDeleteResponse</returns>
        private ApiResponse<UserDeleteResponse> UsersDeleteUserV1WithHttpInfo(string userrecordid, string lang = null,
            string locale = null)
        {
            // verify the required parameter 'userrecordid' is set
            if (userrecordid == null)
                throw new ApiException(400,
                    "Missing required parameter 'userrecordid' when calling UsersApi->UsersDeleteUserV1");

            var localVarPath = $"/api/V1/deleteuser/userrecordid/{userrecordid}";
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

            localVarPathParams.Add("userrecordid",
                Configuration.ApiClient.ParameterToString(userrecordid)); // path parameter
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
                Method.DELETE, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int) localVarResponse.StatusCode;

            var exception = ExceptionFactory?.Invoke("UsersDeleteUserV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<UserDeleteResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (UserDeleteResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserDeleteResponse)));
        }

        #endregion

        #region UsersDeleteUserV2

        /// <summary>
        ///     Delete a user by record ID Operation to delete a user by record ID. To get record IDs, use \&quot;Get a user by
        ///     login ID\&quot; or \&quot;Get a user by public id.\&quot;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="userrecordid">Specify the record ID of the user you want to delete</param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>UserDeleteV2Response</returns>
        public UserDeleteV2Response UsersDeleteUserV2(string userrecordid, string lang = null, string locale = null)
        {
            return UsersDeleteUserV2WithHttpInfo(userrecordid, lang, locale).Data;
        }

        /// <summary>
        ///     Delete a user by record ID Operation to delete a user by record ID. To get record IDs, use \&quot;Get a user by
        ///     login ID\&quot; or \&quot;Get a user by public id.\&quot;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="userrecordid">Specify the record ID of the user you want to delete</param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>ApiResponse of UserDeleteV2Response</returns>
        private ApiResponse<UserDeleteV2Response> UsersDeleteUserV2WithHttpInfo(string userrecordid, string lang = null,
            string locale = null)
        {
            // verify the required parameter 'userrecordid' is set
            if (userrecordid == null)
                throw new ApiException(400,
                    "Missing required parameter 'userrecordid' when calling UsersApi->UsersDeleteUserV2");

            var localVarPath = $"/api/V2/deleteuser/userrecordid/{userrecordid}";
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

            localVarPathParams.Add("userrecordid",
                Configuration.ApiClient.ParameterToString(userrecordid)); // path parameter
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
                Method.DELETE, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int) localVarResponse.StatusCode;

            var exception = ExceptionFactory?.Invoke("UsersDeleteUserV2", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<UserDeleteV2Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (UserDeleteV2Response) Configuration.ApiClient.Deserialize(localVarResponse,
                    typeof(UserDeleteV2Response)));
        }

        #endregion

        #region UsersGetListOfUsers

        /// <summary>
        ///     Get a list of all system users. Operation to get a list of all system users.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="loginidfilter">Specify the login ID filter to apply to the users list.</param>
        /// <param name="stoponerror">
        ///     Specify whether the operation is interrupted if retrieving any user causes an error.
        ///     (optional)
        /// </param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>UserListResponse</returns>
        public UserListResponse UsersGetListOfUsers(string loginidfilter, bool? stoponerror = null, string lang = null,
            string locale = null)
        {
            return UsersGetListOfUsersWithHttpInfo(loginidfilter, stoponerror, lang, locale).Data;
        }

        /// <summary>
        ///     Get a list of all system users. Operation to get a list of all system users.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="loginidfilter">Specify the login ID filter to apply to the users list.</param>
        /// <param name="stoponerror">
        ///     Specify whether the operation is interrupted if retrieving any user causes an error.
        ///     (optional)
        /// </param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>ApiResponse of UserListResponse</returns>
        private ApiResponse<UserListResponse> UsersGetListOfUsersWithHttpInfo(string loginidfilter,
            bool? stoponerror = null, string lang = null, string locale = null)
        {
            // verify the required parameter 'loginidfilter' is set
            if (loginidfilter == null)
                throw new ApiException(400,
                    "Missing required parameter 'loginidfilter' when calling UsersApi->UsersGetListOfUsers");

            const string varPath = "/api/V1/getlistofusers";
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

            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "loginidfilter",
                    loginidfilter)); // query parameter
            if (stoponerror != null)
                localVarQueryParams.AddRange(
                    Configuration.ApiClient.ParameterToKeyValuePairs("", "stoponerror",
                        stoponerror)); // query parameter
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

            var exception = ExceptionFactory?.Invoke("UsersGetListOfUsers", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<UserListResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (UserListResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserListResponse)));
        }

        #endregion

        #region UsersGetUserBatchV1

        /// <summary>
        ///     Get user information in a batch Operation to get user information in a batch. To get record IDs, use \&quot;Get a
        ///     user by login ID\&quot; or \&quot;Get a user by public id.\&quot;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object that lists user record IDs or public IDs of users and an error flag.</param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>UserBatchReadResponse</returns>
        public UserBatchReadResponse UsersGetUserBatchV1(UserBatchReadRequest request, string lang = null,
            string locale = null)
        {
            return UsersGetUserBatchV1WithHttpInfo(request, lang, locale).Data;
        }

        /// <summary>
        ///     Get user information in a batch Operation to get user information in a batch. To get record IDs, use \&quot;Get a
        ///     user by login ID\&quot; or \&quot;Get a user by public id.\&quot;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object that lists user record IDs or public IDs of users and an error flag.</param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>ApiResponse of UserBatchReadResponse</returns>
        private ApiResponse<UserBatchReadResponse> UsersGetUserBatchV1WithHttpInfo(UserBatchReadRequest request,
            string lang = null, string locale = null)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling UsersApi->UsersGetUserBatchV1");

            const string varPath = "/api/V1/getuserbatch";
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

            var exception = ExceptionFactory?.Invoke("UsersGetUserBatchV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<UserBatchReadResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (UserBatchReadResponse) Configuration.ApiClient.Deserialize(localVarResponse,
                    typeof(UserBatchReadResponse)));
        }

        #endregion

        #region UsersGetUserByLoginIdV1

        /// <summary>
        ///     Get a user by login ID Operation to get detailed user information by login ID. Use to get user record IDs and
        ///     account settings, for example. This operation has been deprecated by a V2 operation of the same name, but with
        ///     query string parameters.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="loginid">Specify the user&#39;s login ID.</param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>User</returns>
        public User UsersGetUserByLoginIdV1(string loginid, string lang = null, string locale = null)
        {
            return UsersGetUserByLoginIdV1WithHttpInfo(loginid, lang, locale).Data;
        }

        /// <summary>
        ///     Get a user by login ID Operation to get detailed user information by login ID. Use to get user record IDs and
        ///     account settings, for example. This operation has been deprecated by a V2 operation of the same name, but with
        ///     query string parameters.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="loginid">Specify the user&#39;s login ID.</param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>ApiResponse of User</returns>
        private ApiResponse<User> UsersGetUserByLoginIdV1WithHttpInfo(string loginid, string lang = null,
            string locale = null)
        {
            // verify the required parameter 'loginid' is set
            if (loginid == null)
                throw new ApiException(400,
                    "Missing required parameter 'loginid' when calling UsersApi->UsersGetUserByLoginIdV1");

            var localVarPath = $"/api/V1/getuserbyloginid/loginid/{loginid}";
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

            localVarPathParams.Add("loginid", Configuration.ApiClient.ParameterToString(loginid)); // path parameter
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

            var exception = ExceptionFactory?.Invoke("UsersGetUserByLoginIdV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<User>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (User) Configuration.ApiClient.Deserialize(localVarResponse, typeof(User)));
        }

        #endregion

        #region UsersGetUserByLoginIdV2

        /// <summary>
        ///     Get a user by login ID and login ID type Operation to get detailed user information by login ID. Use to get user
        ///     record IDs and account settings, for example.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="loginid">Specify the user&#39;s login ID.</param>
        /// <param name="loginidtype">Specify the login ID type.</param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>User</returns>
        public User UsersGetUserByLoginIdV2(string loginid, string loginidtype, string lang = null,
            string locale = null)
        {
            return UsersGetUserByLoginIdV2WithHttpInfo(loginid, loginidtype, lang, locale).Data;
        }

        /// <summary>
        ///     Get a user by login ID and login ID type Operation to get detailed user information by login ID. Use to get user
        ///     record IDs and account settings, for example.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="loginid">Specify the user&#39;s login ID.</param>
        /// <param name="loginidtype">Specify the login ID type.</param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>ApiResponse of User</returns>
        private ApiResponse<User> UsersGetUserByLoginIdV2WithHttpInfo(string loginid, string loginidtype,
            string lang = null, string locale = null)
        {
            // verify the required parameter 'loginid' is set
            if (loginid == null)
                throw new ApiException(400,
                    "Missing required parameter 'loginid' when calling UsersApi->UsersGetUserByLoginIdV2");
            // verify the required parameter 'loginidtype' is set
            if (loginidtype == null)
                throw new ApiException(400,
                    "Missing required parameter 'loginidtype' when calling UsersApi->UsersGetUserByLoginIdV2");

            const string varPath = "/api/V2/getuserbyloginid";
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

            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "loginid", loginid)); // query parameter
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "loginidtype", loginidtype)); // query parameter
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

            var exception = ExceptionFactory?.Invoke("UsersGetUserByLoginIdV2", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<User>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (User) Configuration.ApiClient.Deserialize(localVarResponse, typeof(User)));
        }

        #endregion

        #region UsersGetUserByLoginIdV3

        /// <summary>
        ///     Get a user by login ID and login ID type Operation to get detailed user information by login ID. Use to get user
        ///     record IDs and account settings, for example.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="loginid">Specify the user&#39;s login ID.</param>
        /// <param name="loginidtype">Specify the login ID type.</param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>UserV2</returns>
        public UserV2 UsersGetUserByLoginIdV3(string loginid, string loginidtype, string lang = null,
            string locale = null)
        {
            return UsersGetUserByLoginIdV3WithHttpInfo(loginid, loginidtype, lang, locale).Data;
        }

        /// <summary>
        ///     Get a user by login ID and login ID type Operation to get detailed user information by login ID. Use to get user
        ///     record IDs and account settings, for example.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="loginid">Specify the user&#39;s login ID.</param>
        /// <param name="loginidtype">Specify the login ID type.</param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>ApiResponse of UserV2</returns>
        private ApiResponse<UserV2> UsersGetUserByLoginIdV3WithHttpInfo(string loginid, string loginidtype,
            string lang = null, string locale = null)
        {
            // verify the required parameter 'loginid' is set
            if (loginid == null)
                throw new ApiException(400,
                    "Missing required parameter 'loginid' when calling UsersApi->UsersGetUserByLoginIdV3");
            // verify the required parameter 'loginidtype' is set
            if (loginidtype == null)
                throw new ApiException(400,
                    "Missing required parameter 'loginidtype' when calling UsersApi->UsersGetUserByLoginIdV3");

            const string varPath = "/api/V3/getuserbyloginid";
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

            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "loginid", loginid)); // query parameter
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "loginidtype", loginidtype)); // query parameter
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

            var exception = ExceptionFactory?.Invoke("UsersGetUserByLoginIdV3", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<UserV2>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (UserV2) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserV2)));
        }

        #endregion

        #region UsersGetUserByPublicIdV1

        /// <summary>
        ///     Get a user by public ID Operation to get detailed user information by public ID. Use to get user record IDs and
        ///     account settings, for example.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicid">Specify the user&#39;s public ID.</param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>UserReadResponse</returns>
        public UserReadResponse UsersGetUserByPublicIdV1(string publicid, string lang = null, string locale = null)
        {
            return UsersGetUserByPublicIdV1WithHttpInfo(publicid, lang, locale).Data;
        }

        /// <summary>
        ///     Get a user by public ID Operation to get detailed user information by public ID. Use to get user record IDs and
        ///     account settings, for example.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicid">Specify the user&#39;s public ID.</param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>ApiResponse of UserReadResponse</returns>
        private ApiResponse<UserReadResponse> UsersGetUserByPublicIdV1WithHttpInfo(string publicid, string lang = null,
            string locale = null)
        {
            // verify the required parameter 'publicid' is set
            if (publicid == null)
                throw new ApiException(400,
                    "Missing required parameter 'publicid' when calling UsersApi->UsersGetUserByPublicIdV1");

            var varPath = $"/api/V1/getuserbypublicid/publicid/{publicid}";
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

            localVarPathParams.Add("publicid", Configuration.ApiClient.ParameterToString(publicid)); // path parameter
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

            var exception = ExceptionFactory?.Invoke("UsersGetUserByPublicIdV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<UserReadResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (UserReadResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserReadResponse)));
        }

        #endregion

        #region UsersGetUserByPublicIdV2

        /// <summary>
        ///     Get a user by public ID Operation to get detailed user information by public ID. Use to get user record IDs and
        ///     account settings, for example.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicid">Specify the user&#39;s public ID.</param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>UserReadV2Response</returns>
        public UserReadV2Response UsersGetUserByPublicIdV2(string publicid, string lang = null, string locale = null)
        {
            return UsersGetUserByPublicIdV2WithHttpInfo(publicid, lang, locale).Data;
        }

        /// <summary>
        ///     Get a user by public ID Operation to get detailed user information by public ID. Use to get user record IDs and
        ///     account settings, for example.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicid">Specify the user&#39;s public ID.</param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>ApiResponse of UserReadV2Response</returns>
        private ApiResponse<UserReadV2Response> UsersGetUserByPublicIdV2WithHttpInfo(string publicid,
            string lang = null, string locale = null)
        {
            // verify the required parameter 'publicid' is set
            if (publicid == null)
                throw new ApiException(400,
                    "Missing required parameter 'publicid' when calling UsersApi->UsersGetUserByPublicIdV2");

            var localVarPath = $"/api/V2/getuserbypublicid/publicid/{publicid}";
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

            localVarPathParams.Add("publicid", Configuration.ApiClient.ParameterToString(publicid)); // path parameter
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

            var exception = ExceptionFactory?.Invoke("UsersGetUserByPublicIdV2", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<UserReadV2Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (UserReadV2Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserReadV2Response)));
        }

        #endregion

        #region UsersGetUserByRecId

        /// <summary>
        ///     Get a user by record ID Operation to get detailed user information by record ID.  Use to get user public IDs and
        ///     account settings, for example.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="recid">Specify the user&#39;s record ID</param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>UserV2</returns>
        public UserV2 UsersGetUserByRecId(string recid, string lang = null, string locale = null)
        {
            return UsersGetUserByRecIdWithHttpInfo(recid, lang, locale).Data;
        }

        /// <summary>
        ///     Get a user by record ID Operation to get detailed user information by record ID.  Use to get user public IDs and
        ///     account settings, for example.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="recid">Specify the user&#39;s record ID</param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>ApiResponse of UserV2</returns>
        private ApiResponse<UserV2> UsersGetUserByRecIdWithHttpInfo(string recid, string lang = null,
            string locale = null)
        {
            // verify the required parameter 'recid' is set
            if (recid == null)
                throw new ApiException(400,
                    "Missing required parameter 'recid' when calling UsersApi->UsersGetUserByRecId");

            var localVarPath = $"/api/V1/getuserbyrecid/recid/{recid}";
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

            localVarPathParams.Add("recid", Configuration.ApiClient.ParameterToString(recid)); // path parameter
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

            var exception = ExceptionFactory?.Invoke("UsersGetUserByRecId", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<UserV2>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (UserV2) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserV2)));
        }

        #endregion

        #region UsersSaveUserBatchV1

        /// <summary>
        ///     Create or update users in a batch Operation to create or update users in a batch. To update, specify record ID. To
        ///     create, leave record ID empty.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object listing user record IDs and an error flag.</param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>UserBatchSaveResponse</returns>
        public UserBatchSaveResponse UsersSaveUserBatchV1(UserBatchSaveRequest request, string lang = null,
            string locale = null)
        {
            return UsersSaveUserBatchV1WithHttpInfo(request, lang, locale).Data;
        }

        /// <summary>
        ///     Create or update users in a batch Operation to create or update users in a batch. To update, specify record ID. To
        ///     create, leave record ID empty.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object listing user record IDs and an error flag.</param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>ApiResponse of UserBatchSaveResponse</returns>
        private ApiResponse<UserBatchSaveResponse> UsersSaveUserBatchV1WithHttpInfo(UserBatchSaveRequest request,
            string lang = null, string locale = null)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling UsersApi->UsersSaveUserBatchV1");

            const string varPath = "/api/V1/saveuserbatch";
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

            var exception = ExceptionFactory?.Invoke("UsersSaveUserBatchV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<UserBatchSaveResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (UserBatchSaveResponse) Configuration.ApiClient.Deserialize(localVarResponse,
                    typeof(UserBatchSaveResponse)));
        }

        #endregion

        #region UsersSaveUserBatchV2

        /// <summary>
        ///     Create or update users in a batch Operation to create or update users in a batch. To update, specify record ID. To
        ///     create, leave record ID empty.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object listing user record IDs and an error flag.</param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>UserBatchSaveV2Response</returns>
        public UserBatchSaveV2Response UsersSaveUserBatchV2(UserBatchSaveV2Request request, string lang = null,
            string locale = null)
        {
            return UsersSaveUserBatchV2WithHttpInfo(request, lang, locale).Data;
        }

        /// <summary>
        ///     Create or update users in a batch Operation to create or update users in a batch. To update, specify record ID. To
        ///     create, leave record ID empty.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object listing user record IDs and an error flag.</param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>ApiResponse of UserBatchSaveV2Response</returns>
        private ApiResponse<UserBatchSaveV2Response> UsersSaveUserBatchV2WithHttpInfo(UserBatchSaveV2Request request,
            string lang = null, string locale = null)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling UsersApi->UsersSaveUserBatchV2");

            const string varPath = "/api/V2/saveuserbatch";
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

            var exception = ExceptionFactory?.Invoke("UsersSaveUserBatchV2", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<UserBatchSaveV2Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (UserBatchSaveV2Response) Configuration.ApiClient.Deserialize(localVarResponse,
                    typeof(UserBatchSaveV2Response)));
        }

        #endregion

        #region UsersSaveUserV1

        /// <summary>
        ///     Create or update a user Operation to create or update a user.  The response is a collection because if you use a
        ///     public ID, more than one user could be updated since public IDs may not be unique.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">
        ///     Request object to specify user parameters and fields with values to be created or updated. The
        ///     loginId and either the Business Object record ID or Public ID are required.
        /// </param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>UserSaveResponse</returns>
        public UserSaveResponse UsersSaveUserV1(UserSaveRequest request, string lang = null, string locale = null)
        {
            return UsersSaveUserV1WithHttpInfo(request, lang, locale).Data;
        }

        /// <summary>
        ///     Create or update a user Operation to create or update a user.  The response is a collection because if you use a
        ///     public ID, more than one user could be updated since public IDs may not be unique.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">
        ///     Request object to specify user parameters and fields with values to be created or updated. The
        ///     loginId and either the Business Object record ID or Public ID are required.
        /// </param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>ApiResponse of UserSaveResponse</returns>
        private ApiResponse<UserSaveResponse> UsersSaveUserV1WithHttpInfo(UserSaveRequest request, string lang = null,
            string locale = null)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling UsersApi->UsersSaveUserV1");

            const string varPath = "/api/V1/saveuser";
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

            var exception = ExceptionFactory?.Invoke("UsersSaveUserV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<UserSaveResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (UserSaveResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserSaveResponse)));
        }

        #endregion

        #region UsersSaveUserV2

        /// <summary>
        ///     Create or update a user Operation to create or update a user.  The response is a collection because if you use a
        ///     public ID, more than one user could be updated since public IDs may not be unique.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">
        ///     Request object to specify user parameters and fields with values to be created or updated. The
        ///     loginId and either the Business Object record ID or Public ID are required.
        /// </param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>UserSaveV2Response</returns>
        public UserSaveV2Response UsersSaveUserV2(UserSaveV2Request request, string lang = null, string locale = null)
        {
            return UsersSaveUserV2WithHttpInfo(request, lang, locale).Data;
        }

        /// <summary>
        ///     Create or update a user Operation to create or update a user.  The response is a collection because if you use a
        ///     public ID, more than one user could be updated since public IDs may not be unique.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">
        ///     Request object to specify user parameters and fields with values to be created or updated. The
        ///     loginId and either the Business Object record ID or Public ID are required.
        /// </param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>ApiResponse of UserSaveV2Response</returns>
        private ApiResponse<UserSaveV2Response> UsersSaveUserV2WithHttpInfo(UserSaveV2Request request,
            string lang = null, string locale = null)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling UsersApi->UsersSaveUserV2");

            const string varPath = "/api/V2/saveuser";
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

            var exception = ExceptionFactory?.Invoke("UsersSaveUserV2", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<UserSaveV2Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (UserSaveV2Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserSaveV2Response)));
        }

        #endregion
    }
}