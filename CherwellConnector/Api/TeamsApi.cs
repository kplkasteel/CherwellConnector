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
    public class TeamsApi : BaseApi, ITeamsApi
    {
        #region Variables & Properties

        private static TeamsApi _instance;

        private static readonly object Padlock = new();

        public static TeamsApi Instance
        {
            get
            {
                _instance ??= new TeamsApi(ServiceApi.Instance.Configuration);

                _instance = (TeamsApi) ServiceApi.Instance.CheckApiHeader(_instance);
                return _instance;
            }
            set => _instance = value;
        }

        #endregion

        #region Constructor

        /// <summary>
        ///     Initializes a new instance of the <see cref="TeamsApi" /> class.
        /// </summary>
        /// <returns></returns>
        public TeamsApi(string basePath)
        {
            Configuration = new Configuration {BasePath = basePath};

            ExceptionFactory = Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="TeamsApi" /> class
        ///     using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TeamsApi(Configuration configuration = null)
        {
            Configuration = configuration ?? Configuration.Default;

            ExceptionFactory = Configuration.DefaultExceptionFactory;
        }

        #endregion

        #region TeamsAddUserToTeamByBatchV1

        /// <summary>
        ///     Add users to a team by batch Operation to add users to a Team by batch. To get internal IDs for users, use “Get
        ///     User Information in a Batch.” To get a Team&#39;s internal ID, use \&quot;Get all available Teams.\&quot;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object to specify a list of add user to team request objects.</param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>AddUserToTeamByBatchResponse</returns>
        public AddUserToTeamByBatchResponse TeamsAddUserToTeamByBatchV1(AddUserToTeamByBatchRequest request,
            string lang = null, string locale = null)
        {
            return TeamsAddUserToTeamByBatchV1WithHttpInfo(request, lang, locale).Data;
        }

        /// <summary>
        ///     Add users to a team by batch Operation to add users to a Team by batch. To get internal IDs for users, use “Get
        ///     User Information in a Batch.” To get a Team&#39;s internal ID, use \&quot;Get all available Teams.\&quot;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object to specify a list of add user to team request objects.</param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>ApiResponse of AddUserToTeamByBatchResponse</returns>
        private ApiResponse<AddUserToTeamByBatchResponse> TeamsAddUserToTeamByBatchV1WithHttpInfo(
            AddUserToTeamByBatchRequest request, string lang = null, string locale = null)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling TeamsApi->TeamsAddUserToTeamByBatchV1");

            const string varPath = "/api/V1/addusertoteambybatch";
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

            var exception = ExceptionFactory?.Invoke("TeamsAddUserToTeamByBatchV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<AddUserToTeamByBatchResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (AddUserToTeamByBatchResponse) Configuration.ApiClient.Deserialize(localVarResponse,
                    typeof(AddUserToTeamByBatchResponse)));
        }

        #endregion

        #region TeamsAddUserToTeamV1

        /// <summary>
        ///     Add a user to a team Operation to add a user to a Team. To get the user&#39;s internal ID, use \&quot;Get a user by
        ///     login ID\&quot; or \&quot;Get a user by public ID.\&quot; To get a Team&#39;s internal ID, use \&quot;Get all
        ///     available Teams.\&quot;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataRequest">Request object to specify user and team values.</param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>Object</returns>
        public object TeamsAddUserToTeamV1(AddUserToTeamRequest dataRequest, string lang = null, string locale = null)
        {
            return TeamsAddUserToTeamV1WithHttpInfo(dataRequest, lang, locale).Data;
        }

        /// <summary>
        ///     Add a user to a team Operation to add a user to a Team. To get the user&#39;s internal ID, use \&quot;Get a user by
        ///     login ID\&quot; or \&quot;Get a user by public ID.\&quot; To get a Team&#39;s internal ID, use \&quot;Get all
        ///     available Teams.\&quot;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataRequest">Request object to specify user and team values.</param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>ApiResponse of Object</returns>
        private ApiResponse<object> TeamsAddUserToTeamV1WithHttpInfo(AddUserToTeamRequest dataRequest,
            string lang = null, string locale = null)
        {
            // verify the required parameter 'dataRequest' is set
            if (dataRequest == null)
                throw new ApiException(400,
                    "Missing required parameter 'dataRequest' when calling TeamsApi->TeamsAddUserToTeamV1");

            const string varPath = "/api/V1/addusertoteam";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody;


            var localVarHttpContentType = ApiClient.SelectHeaderContentType(LocalVarHttpContentTypes);

            // to determine the Accept header
            var localVarHttpHeaderAccepts = Array.Empty<string>();
            var localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (lang != null)
                localVarQueryParams.AddRange(
                    Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang)); // query parameter
            if (locale != null)
                localVarQueryParams.AddRange(
                    Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale)); // query parameter
            if (dataRequest.GetType() != typeof(byte[]))
                localVarPostBody = Configuration.ApiClient.Serialize(dataRequest); // http body (model) parameter
            else
                localVarPostBody = dataRequest; // byte array

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

            var exception = ExceptionFactory?.Invoke("TeamsAddUserToTeamV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                null);
        }

        #endregion

        #region TeamsAddUserToTeamV2

        /// <summary>
        ///     Add a user to a team Operation to add a user to a Team. To get the user&#39;s internal ID, use \&quot;Get a user by
        ///     login ID\&quot; or \&quot;Get a user by public ID.\&quot; To get a Team&#39;s internal ID, use \&quot;Get all
        ///     available Teams.\&quot;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataRequest">Request object to specify user and team values.</param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>AddUserToTeamResponse</returns>
        public AddUserToTeamResponse TeamsAddUserToTeamV2(AddUserToTeamRequest dataRequest, string lang = null,
            string locale = null)
        {
            return TeamsAddUserToTeamV2WithHttpInfo(dataRequest, lang, locale).Data;
        }

        /// <summary>
        ///     Add a user to a team Operation to add a user to a Team. To get the user&#39;s internal ID, use \&quot;Get a user by
        ///     login ID\&quot; or \&quot;Get a user by public ID.\&quot; To get a Team&#39;s internal ID, use \&quot;Get all
        ///     available Teams.\&quot;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataRequest">Request object to specify user and team values.</param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>ApiResponse of AddUserToTeamResponse</returns>
        private ApiResponse<AddUserToTeamResponse> TeamsAddUserToTeamV2WithHttpInfo(AddUserToTeamRequest dataRequest,
            string lang = null, string locale = null)
        {
            // verify the required parameter 'dataRequest' is set
            if (dataRequest == null)
                throw new ApiException(400,
                    "Missing required parameter 'dataRequest' when calling TeamsApi->TeamsAddUserToTeamV2");

            const string varPath = "/api/V2/addusertoteam";
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
            if (dataRequest.GetType() != typeof(byte[]))
                localVarPostBody = Configuration.ApiClient.Serialize(dataRequest); // http body (model) parameter
            else
                localVarPostBody = dataRequest; // byte array

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

            var exception = ExceptionFactory?.Invoke("TeamsAddUserToTeamV2", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<AddUserToTeamResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (AddUserToTeamResponse) Configuration.ApiClient.Deserialize(localVarResponse,
                    typeof(AddUserToTeamResponse)));
        }

        #endregion

        #region TeamsDeleteTeamV1

        /// <summary>
        ///     Delete a Team Operation to delete a Team by Team ID.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamid">Specify the Team ID.</param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>Object</returns>
        public object TeamsDeleteTeamV1(string teamid, string lang = null, string locale = null)
        {
            return TeamsDeleteTeamV1WithHttpInfo(teamid, lang, locale).Data;
        }

        /// <summary>
        ///     Delete a Team Operation to delete a Team by Team ID.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamid">Specify the Team ID.</param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>ApiResponse of Object</returns>
        private ApiResponse<object> TeamsDeleteTeamV1WithHttpInfo(string teamid, string lang = null,
            string locale = null)
        {
            // verify the required parameter 'teamid' is set
            if (teamid == null)
                throw new ApiException(400,
                    "Missing required parameter 'teamid' when calling TeamsApi->TeamsDeleteTeamV1");

            var localVarPath = $"/api/V1/deleteteam/{teamid}";
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

            localVarPathParams.Add("teamid", Configuration.ApiClient.ParameterToString(teamid)); // path parameter
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

            var exception = ExceptionFactory?.Invoke("TeamsDeleteTeamV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                null);
        }

        #endregion

        #region TeamsGetTeamV1

        /// <summary>
        ///     Get a team by its TeamId Operation to get Team Info for a  single Team using its Team ID. To get a Team&#39;s
        ///     internal ID, use \&quot;Get all available Teams.\&quot; Note that TeamType has two possible values, where TeamType
        ///     &#x3D; 0 for User (CSM Users), or TeamType &#x3D; 1 for Workgroup (CSM Customers).
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamid">The Team ID of the Team to get.</param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>TeamResponse</returns>
        public TeamResponse TeamsGetTeamV1(string teamid, string lang = null, string locale = null)
        {
            return TeamsGetTeamV1WithHttpInfo(teamid, lang, locale).Data;
        }

        /// <summary>
        ///     Get a team by its TeamId Operation to get Team Info for a  single Team using its Team ID. To get a Team&#39;s
        ///     internal ID, use \&quot;Get all available Teams.\&quot; Note that TeamType has two possible values, where TeamType
        ///     &#x3D; 0 for User (CSM Users), or TeamType &#x3D; 1 for Workgroup (CSM Customers).
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamid">The Team ID of the Team to get.</param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>ApiResponse of TeamResponse</returns>
        private ApiResponse<TeamResponse> TeamsGetTeamV1WithHttpInfo(string teamid, string lang = null,
            string locale = null)
        {
            // verify the required parameter 'teamid' is set
            if (teamid == null)
                throw new ApiException(400,
                    "Missing required parameter 'teamid' when calling TeamsApi->TeamsGetTeamV1");

            var localVarPath = $"/api/V1/getteam/{teamid}";
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

            localVarPathParams.Add("teamid", Configuration.ApiClient.ParameterToString(teamid)); // path parameter
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

            var exception = ExceptionFactory?.Invoke("TeamsGetTeamV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<TeamResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (TeamResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TeamResponse)));
        }

        #endregion

        #region TeamsGetTeamsV1

        /// <summary>
        ///     Get all available Teams Operation to get IDs and names for all available Teams.
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
        /// <returns>TeamsResponse</returns>
        public TeamsResponse TeamsGetTeamsV1(string lang = null, string locale = null)
        {
            return TeamsGetTeamsV1WithHttpInfo(lang, locale).Data;
        }

        /// <summary>
        ///     Get all available Teams Operation to get IDs and names for all available Teams.
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
        /// <returns>ApiResponse of TeamsResponse</returns>
        private ApiResponse<TeamsResponse> TeamsGetTeamsV1WithHttpInfo(string lang = null, string locale = null)
        {
            const string varPath = "/api/V1/getteams";
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

            var exception = ExceptionFactory?.Invoke("TeamsGetTeamsV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<TeamsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (TeamsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TeamsResponse)));
        }

        #endregion

        #region TeamsGetTeamsV2

        /// <summary>
        ///     Get all available Teams Operation to get IDs and names for all available Teams.
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
        /// <returns>TeamsV2Response</returns>
        public TeamsV2Response TeamsGetTeamsV2(string lang = null, string locale = null)
        {
            return TeamsGetTeamsV2WithHttpInfo(lang, locale).Data;
        }

        /// <summary>
        ///     Get all available Teams Operation to get IDs and names for all available Teams.
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
        /// <returns>ApiResponse of TeamsV2Response</returns>
        private ApiResponse<TeamsV2Response> TeamsGetTeamsV2WithHttpInfo(string lang = null, string locale = null)
        {
            const string varPath = "/api/V2/getteams";
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

            var exception = ExceptionFactory?.Invoke("TeamsGetTeamsV2", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<TeamsV2Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (TeamsV2Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TeamsV2Response)));
        }

        #endregion

        #region TeamsGetUsersTeamsV1

        /// <summary>
        ///     Get Team assignments for a user Operation to get Team assignments for a user. To get record IDs, use \&quot;Get a
        ///     user by login ID\&quot; or \&quot;Get a user by public id.\&quot;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="userRecordId">Specify the user record ID.</param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>TeamsResponse</returns>
        public TeamsResponse TeamsGetUsersTeamsV1(string userRecordId, string lang = null, string locale = null)
        {
            return TeamsGetUsersTeamsV1WithHttpInfo(userRecordId, lang, locale).Data;
        }

        /// <summary>
        ///     Get Team assignments for a user Operation to get Team assignments for a user. To get record IDs, use \&quot;Get a
        ///     user by login ID\&quot; or \&quot;Get a user by public id.\&quot;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="userRecordId">Specify the user record ID.</param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>ApiResponse of TeamsResponse</returns>
        private ApiResponse<TeamsResponse> TeamsGetUsersTeamsV1WithHttpInfo(string userRecordId, string lang = null,
            string locale = null)
        {
            // verify the required parameter 'userRecordId' is set
            if (userRecordId == null)
                throw new ApiException(400,
                    "Missing required parameter 'userRecordId' when calling TeamsApi->TeamsGetUsersTeamsV1");

            var localVarPath = $"/api/V1/getusersteams/userrecordid/{userRecordId}";
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

            localVarPathParams.Add("userRecordId",
                Configuration.ApiClient.ParameterToString(userRecordId)); // path parameter
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

            var exception = ExceptionFactory?.Invoke("TeamsGetUsersTeamsV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<TeamsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (TeamsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TeamsResponse)));
        }

        #endregion

        #region TeamsGetUsersTeamsV2

        /// <summary>
        ///     Get Team assignments for a user Operation to get Team assignments for a user. To get record IDs, use \&quot;Get a
        ///     user by login ID\&quot; or \&quot;Get a user by public id.\&quot;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="userRecordId">Specify the user record ID.</param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>TeamsV2Response</returns>
        public TeamsV2Response TeamsGetUsersTeamsV2(string userRecordId, string lang = null, string locale = null)
        {
            return TeamsGetUsersTeamsV2WithHttpInfo(userRecordId, lang, locale).Data;
        }

        /// <summary>
        ///     Get Team assignments for a user Operation to get Team assignments for a user. To get record IDs, use \&quot;Get a
        ///     user by login ID\&quot; or \&quot;Get a user by public id.\&quot;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="userRecordId">Specify the user record ID.</param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>ApiResponse of TeamsV2Response</returns>
        private ApiResponse<TeamsV2Response> TeamsGetUsersTeamsV2WithHttpInfo(string userRecordId, string lang = null,
            string locale = null)
        {
            // verify the required parameter 'userRecordId' is set
            if (userRecordId == null)
                throw new ApiException(400,
                    "Missing required parameter 'userRecordId' when calling TeamsApi->TeamsGetUsersTeamsV2");

            var localVarPath = $"/api/V2/getusersteams/userrecordid/{userRecordId}";
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

            localVarPathParams.Add("userRecordId",
                Configuration.ApiClient.ParameterToString(userRecordId)); // path parameter
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

            var exception = ExceptionFactory?.Invoke("TeamsGetUsersTeamsV2", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<TeamsV2Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (TeamsV2Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TeamsV2Response)));
        }

        #endregion

        #region TeamsGetWorkgroupsV1

        /// <summary>
        ///     Get all available Workgroups Operation to get IDs and names for all available Workgroups.
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
        /// <returns>TeamsResponse</returns>
        public TeamsResponse TeamsGetWorkgroupsV1(string lang = null, string locale = null)
        {
            return TeamsGetWorkgroupsV1WithHttpInfo(lang, locale).Data;
        }

        /// <summary>
        ///     Get all available Workgroups Operation to get IDs and names for all available Workgroups.
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
        /// <returns>ApiResponse of TeamsResponse</returns>
        private ApiResponse<TeamsResponse> TeamsGetWorkgroupsV1WithHttpInfo(string lang = null, string locale = null)
        {
            const string varPath = "/api/V1/getworkgroups";
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

            var exception = ExceptionFactory?.Invoke("TeamsGetWorkgroupsV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<TeamsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (TeamsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TeamsResponse)));
        }

        #endregion

        #region TeamsGetWorkgroupsV2

        /// <summary>
        ///     Get all available Workgroups Operation to get IDs and names for all available Workgroups.
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
        /// <returns>TeamsV2Response</returns>
        public TeamsV2Response TeamsGetWorkgroupsV2(string lang = null, string locale = null)
        {
            return TeamsGetWorkgroupsV2WithHttpInfo(lang, locale).Data;
        }

        /// <summary>
        ///     Get all available Workgroups Operation to get IDs and names for all available Workgroups.
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
        /// <returns>ApiResponse of TeamsV2Response</returns>
        private ApiResponse<TeamsV2Response> TeamsGetWorkgroupsV2WithHttpInfo(string lang = null, string locale = null)
        {
            const string varPath = "/api/V2/getworkgroups";
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

            var exception = ExceptionFactory?.Invoke("TeamsGetWorkgroupsV2", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<TeamsV2Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (TeamsV2Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TeamsV2Response)));
        }

        #endregion

        #region TeamsRemoveCustomerFromWorkgroupV1

        /// <summary>
        ///     Remove a customer from a Workgroup Operation to remove a Customer from a Workgroup.  To remove, specify the
        ///     Workgroup ID and the Customer Record ID.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="workgroupid">Specify the Workgroup ID.</param>
        /// <param name="customerrecordid">Specify the Customer record ID.</param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>RemoveCustomerFromWorkgroupResponse</returns>
        public RemoveCustomerFromWorkgroupResponse TeamsRemoveCustomerFromWorkgroupV1(string workgroupid,
            string customerrecordid, string lang = null, string locale = null)
        {
            return TeamsRemoveCustomerFromWorkgroupV1WithHttpInfo(workgroupid, customerrecordid, lang, locale).Data;
        }

        /// <summary>
        ///     Remove a customer from a Workgroup Operation to remove a Customer from a Workgroup.  To remove, specify the
        ///     Workgroup ID and the Customer Record ID.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="workgroupid">Specify the Workgroup ID.</param>
        /// <param name="customerrecordid">Specify the Customer record ID.</param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>ApiResponse of RemoveCustomerFromWorkgroupResponse</returns>
        private ApiResponse<RemoveCustomerFromWorkgroupResponse> TeamsRemoveCustomerFromWorkgroupV1WithHttpInfo(
            string workgroupid, string customerrecordid, string lang = null, string locale = null)
        {
            // verify the required parameter 'workgroupid' is set
            if (workgroupid == null)
                throw new ApiException(400,
                    "Missing required parameter 'workgroupid' when calling TeamsApi->TeamsRemoveCustomerFromWorkgroupV1");
            // verify the required parameter 'customerrecordid' is set
            if (customerrecordid == null)
                throw new ApiException(400,
                    "Missing required parameter 'customerrecordid' when calling TeamsApi->TeamsRemoveCustomerFromWorkgroupV1");

            var localVarPath =
                $"/api/V1/removecustomerfromworkgroup/workgroupid/{workgroupid}/customerrecordid/{customerrecordid}";
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

            localVarPathParams.Add("workgroupid",
                Configuration.ApiClient.ParameterToString(workgroupid)); // path parameter
            localVarPathParams.Add("customerrecordid",
                Configuration.ApiClient.ParameterToString(customerrecordid)); // path parameter
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

            var exception = ExceptionFactory?.Invoke("TeamsRemoveCustomerFromWorkgroupV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<RemoveCustomerFromWorkgroupResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (RemoveCustomerFromWorkgroupResponse) Configuration.ApiClient.Deserialize(localVarResponse,
                    typeof(RemoveCustomerFromWorkgroupResponse)));
        }

        #endregion

        #region TeamsRemoveUserFromTeamV1

        /// <summary>
        ///     Operation to remove a User from a Team. Operation to remove a User from a Team. To get the User&#39;s record ID,
        ///     use \&quot;Get a User by login ID\&quot; or \&quot;Get a User by public ID.\&quot; To get a Team&#39;s internal ID,
        ///     use \&quot;Get all available Teams.\&quot;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamId">Specify the internal ID of the Team.</param>
        /// <param name="userrecordid">Specify the record ID of the User to remove.</param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>Object</returns>
        public object TeamsRemoveUserFromTeamV1(string teamId, string userrecordid, string lang = null,
            string locale = null)
        {
            return TeamsRemoveUserFromTeamV1WithHttpInfo(teamId, userrecordid, lang, locale).Data;
        }

        /// <summary>
        ///     Operation to remove a User from a Team. Operation to remove a User from a Team. To get the User&#39;s record ID,
        ///     use \&quot;Get a User by login ID\&quot; or \&quot;Get a User by public ID.\&quot; To get a Team&#39;s internal ID,
        ///     use \&quot;Get all available Teams.\&quot;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamId">Specify the internal ID of the Team.</param>
        /// <param name="userrecordid">Specify the record ID of the User to remove.</param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>ApiResponse of Object</returns>
        private ApiResponse<object> TeamsRemoveUserFromTeamV1WithHttpInfo(string teamId, string userrecordid,
            string lang = null, string locale = null)
        {
            // verify the required parameter 'teamId' is set
            if (teamId == null)
                throw new ApiException(400,
                    "Missing required parameter 'teamId' when calling TeamsApi->TeamsRemoveUserFromTeamV1");
            // verify the required parameter 'userrecordid' is set
            if (userrecordid == null)
                throw new ApiException(400,
                    "Missing required parameter 'userrecordid' when calling TeamsApi->TeamsRemoveUserFromTeamV1");

            var localVarPath = $"/api/V1/removeuserfromteam/teamid/{teamId}/userrecordid/{userrecordid}";
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

            localVarPathParams.Add("teamId", Configuration.ApiClient.ParameterToString(teamId)); // path parameter
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

            var exception = ExceptionFactory?.Invoke("TeamsRemoveUserFromTeamV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                null);
        }

        #endregion

        #region TeamsRemoveUserFromTeamV2

        /// <summary>
        ///     Operation to remove a User from a Team. Operation to remove a User from a Team. To get the User&#39;s record ID,
        ///     use \&quot;Get a User by login ID\&quot; or \&quot;Get a User by public ID.\&quot; To get a Team&#39;s internal ID,
        ///     use \&quot;Get all available Teams.\&quot;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamId">Specify the internal ID of the Team.</param>
        /// <param name="userrecordid">Specify the record ID of the User to remove.</param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>RemoveUserFromTeamResponse</returns>
        public RemoveUserFromTeamResponse TeamsRemoveUserFromTeamV2(string teamId, string userrecordid,
            string lang = null, string locale = null)
        {
            return TeamsRemoveUserFromTeamV2WithHttpInfo(teamId, userrecordid, lang, locale).Data;
        }

        /// <summary>
        ///     Operation to remove a User from a Team. Operation to remove a User from a Team. To get the User&#39;s record ID,
        ///     use \&quot;Get a User by login ID\&quot; or \&quot;Get a User by public ID.\&quot; To get a Team&#39;s internal ID,
        ///     use \&quot;Get all available Teams.\&quot;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamId">Specify the internal ID of the Team.</param>
        /// <param name="userrecordid">Specify the record ID of the User to remove.</param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>ApiResponse of RemoveUserFromTeamResponse</returns>
        private ApiResponse<RemoveUserFromTeamResponse> TeamsRemoveUserFromTeamV2WithHttpInfo(string teamId,
            string userrecordid, string lang = null, string locale = null)
        {
            // verify the required parameter 'teamId' is set
            if (teamId == null)
                throw new ApiException(400,
                    "Missing required parameter 'teamId' when calling TeamsApi->TeamsRemoveUserFromTeamV2");
            // verify the required parameter 'userrecordid' is set
            if (userrecordid == null)
                throw new ApiException(400,
                    "Missing required parameter 'userrecordid' when calling TeamsApi->TeamsRemoveUserFromTeamV2");

            var varPath = $"/api/V2/removeuserfromteam/teamid/{teamId}/userrecordid/{userrecordid}";
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

            localVarPathParams.Add("teamId", Configuration.ApiClient.ParameterToString(teamId)); // path parameter
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
            var localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(varPath,
                Method.DELETE, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int) localVarResponse.StatusCode;

            var exception = ExceptionFactory?.Invoke("TeamsRemoveUserFromTeamV2", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<RemoveUserFromTeamResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (RemoveUserFromTeamResponse) Configuration.ApiClient.Deserialize(localVarResponse,
                    typeof(RemoveUserFromTeamResponse)));
        }

        #endregion

        #region TeamsSaveTeamMemberV1

        /// <summary>
        ///     Add or Update a team member Operation to add or update a Team Member. To add or update, specify User ID, Team ID,
        ///     and if Team Manager.   Optionally, set the Team as the User&#39;s default Team.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">
        ///     The request object to add or update a Team Member. User recID specifies the User to add or
        ///     update. TeamId specifies the Team to update. IsTeamManager specifies whether the User is a Team Manager, and
        ///     SetAsDefaultTeam specifies whether to set this Team as the User&#39;s default team. UserRecId, TeamId, and
        ///     IsTeamManager are required.
        /// </param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>SaveTeamMemberResponse</returns>
        public SaveTeamMemberResponse TeamsSaveTeamMemberV1(SaveTeamMemberRequest request, string lang = null,
            string locale = null)
        {
            return TeamsSaveTeamMemberV1WithHttpInfo(request, lang, locale).Data;
        }

        /// <summary>
        ///     Add or Update a team member Operation to add or update a Team Member. To add or update, specify User ID, Team ID,
        ///     and if Team Manager.   Optionally, set the Team as the User&#39;s default Team.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">
        ///     The request object to add or update a Team Member. User recID specifies the User to add or
        ///     update. TeamId specifies the Team to update. IsTeamManager specifies whether the User is a Team Manager, and
        ///     SetAsDefaultTeam specifies whether to set this Team as the User&#39;s default team. UserRecId, TeamId, and
        ///     IsTeamManager are required.
        /// </param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>ApiResponse of SaveTeamMemberResponse</returns>
        private ApiResponse<SaveTeamMemberResponse> TeamsSaveTeamMemberV1WithHttpInfo(SaveTeamMemberRequest request,
            string lang = null, string locale = null)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling TeamsApi->TeamsSaveTeamMemberV1");

            const string varPath = "/api/V1/saveteammember";
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

            var exception = ExceptionFactory?.Invoke("TeamsSaveTeamMemberV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<SaveTeamMemberResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (SaveTeamMemberResponse) Configuration.ApiClient.Deserialize(localVarResponse,
                    typeof(SaveTeamMemberResponse)));
        }

        #endregion

        #region TeamsSaveTeamV1

        /// <summary>
        ///     Create or update a team Operation to create or update a Team or Workgroup.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">
        ///     Request object to create Teams or Workgroups. To create a Team, use teamType and teamName. To
        ///     update a team, use teamID. Team type values must be User or CustomerWorkgroup. The teamType cannot be changed for
        ///     existing Teams or Workgroups.
        /// </param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>TeamSaveResponse</returns>
        public TeamSaveResponse TeamsSaveTeamV1(TeamSaveRequest request, string lang = null, string locale = null)
        {
            return TeamsSaveTeamV1WithHttpInfo(request, lang, locale).Data;
        }

        /// <summary>
        ///     Create or update a team Operation to create or update a Team or Workgroup.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">
        ///     Request object to create Teams or Workgroups. To create a Team, use teamType and teamName. To
        ///     update a team, use teamID. Team type values must be User or CustomerWorkgroup. The teamType cannot be changed for
        ///     existing Teams or Workgroups.
        /// </param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>ApiResponse of TeamSaveResponse</returns>
        private ApiResponse<TeamSaveResponse> TeamsSaveTeamV1WithHttpInfo(TeamSaveRequest request, string lang = null,
            string locale = null)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling TeamsApi->TeamsSaveTeamV1");

            const string varPath = "/api/V1/saveteam";
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

            var exception = ExceptionFactory?.Invoke("TeamsSaveTeamV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<TeamSaveResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (TeamSaveResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TeamSaveResponse)));
        }

        #endregion

        #region TeamsSaveWorkgroupMemberV1

        /// <summary>
        ///     Save the membership status of a Workgroup member. Operation to add or update a Workgroup Member.  To add or update,
        ///     specify Customer Record ID, Workgroup ID, and if Workgroup Manager.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">
        ///     The request object to add or update a Workgroup Member. CustomerRecordId specifies the Customer
        ///     to add or update. WorkgroupId specifies the Workgroup to update. CustomerIsWorkgroupManager specifies whether the
        ///     Customer is a Workgroup Manager.
        /// </param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>SaveWorkgroupMemberResponse</returns>
        public SaveWorkgroupMemberResponse TeamsSaveWorkgroupMemberV1(SaveWorkgroupMemberRequest request,
            string lang = null, string locale = null)
        {
            return TeamsSaveWorkgroupMemberV1WithHttpInfo(request, lang, locale).Data;
        }

        /// <summary>
        ///     Save the membership status of a Workgroup member. Operation to add or update a Workgroup Member.  To add or update,
        ///     specify Customer Record ID, Workgroup ID, and if Workgroup Manager.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">
        ///     The request object to add or update a Workgroup Member. CustomerRecordId specifies the Customer
        ///     to add or update. WorkgroupId specifies the Workgroup to update. CustomerIsWorkgroupManager specifies whether the
        ///     Customer is a Workgroup Manager.
        /// </param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>ApiResponse of SaveWorkgroupMemberResponse</returns>
        private ApiResponse<SaveWorkgroupMemberResponse> TeamsSaveWorkgroupMemberV1WithHttpInfo(
            SaveWorkgroupMemberRequest request, string lang = null, string locale = null)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400,
                    "Missing required parameter 'request' when calling TeamsApi->TeamsSaveWorkgroupMemberV1");

            const string varPath = "/api/V1/saveworkgroupmember";
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

            var exception = ExceptionFactory?.Invoke("TeamsSaveWorkgroupMemberV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<SaveWorkgroupMemberResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value?.ToString()),
                (SaveWorkgroupMemberResponse) Configuration.ApiClient.Deserialize(localVarResponse,
                    typeof(SaveWorkgroupMemberResponse)));
        }

        #endregion
    }
}