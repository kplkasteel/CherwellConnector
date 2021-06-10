using CherwellConnector.Client;
using CherwellConnector.Model;

namespace CherwellConnector.Interface
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUsersApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Delete a batch of users
        /// </summary>
        /// <remarks>
        /// Operation to delete a batch of users. To get record IDs, use \&quot;Get a user by login ID\&quot; or \&quot;Get a user by public id.\&quot;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object listing record IDs for users to be deleted and an error flag.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsUsersUserBatchDeleteResponse</returns>
        TrebuchetWebApiDataContractsUsersUserBatchDeleteResponse UsersDeleteUserBatchV1 (TrebuchetWebApiDataContractsUsersUserBatchDeleteRequest request, string lang = null, string locale = null);

        /// <summary>
        /// Delete a batch of users
        /// </summary>
        /// <remarks>
        /// Operation to delete a batch of users. To get record IDs, use \&quot;Get a user by login ID\&quot; or \&quot;Get a user by public id.\&quot;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object listing record IDs for users to be deleted and an error flag.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsUsersUserBatchDeleteResponse</returns>
        ApiResponse<TrebuchetWebApiDataContractsUsersUserBatchDeleteResponse> UsersDeleteUserBatchV1WithHttpInfo (TrebuchetWebApiDataContractsUsersUserBatchDeleteRequest request, string lang = null, string locale = null);
        /// <summary>
        /// Delete a batch of users
        /// </summary>
        /// <remarks>
        /// Operation to delete a batch of users. To get record IDs, use \&quot;Get a user by login ID\&quot; or \&quot;Get a user by public id.\&quot;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object listing record IDs for users to be deleted and an error flag.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsUsersUserBatchDeleteV2Response</returns>
        TrebuchetWebApiDataContractsUsersUserBatchDeleteV2Response UsersDeleteUserBatchV2 (TrebuchetWebApiDataContractsUsersUserBatchDeleteRequest request, string lang = null, string locale = null);

        /// <summary>
        /// Delete a batch of users
        /// </summary>
        /// <remarks>
        /// Operation to delete a batch of users. To get record IDs, use \&quot;Get a user by login ID\&quot; or \&quot;Get a user by public id.\&quot;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object listing record IDs for users to be deleted and an error flag.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsUsersUserBatchDeleteV2Response</returns>
        ApiResponse<TrebuchetWebApiDataContractsUsersUserBatchDeleteV2Response> UsersDeleteUserBatchV2WithHttpInfo (TrebuchetWebApiDataContractsUsersUserBatchDeleteRequest request, string lang = null, string locale = null);
        /// <summary>
        /// Delete a user by record ID
        /// </summary>
        /// <remarks>
        /// Operation to delete a user by record ID. To get record IDs, use \&quot;Get a user by login ID\&quot; or \&quot;Get a user by public id.\&quot;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="userrecordid">Specify the record ID of the user you want to delete</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsUsersUserDeleteResponse</returns>
        TrebuchetWebApiDataContractsUsersUserDeleteResponse UsersDeleteUserV1 (string userrecordid, string lang = null, string locale = null);

        /// <summary>
        /// Delete a user by record ID
        /// </summary>
        /// <remarks>
        /// Operation to delete a user by record ID. To get record IDs, use \&quot;Get a user by login ID\&quot; or \&quot;Get a user by public id.\&quot;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="userrecordid">Specify the record ID of the user you want to delete</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsUsersUserDeleteResponse</returns>
        ApiResponse<TrebuchetWebApiDataContractsUsersUserDeleteResponse> UsersDeleteUserV1WithHttpInfo (string userrecordid, string lang = null, string locale = null);
        /// <summary>
        /// Delete a user by record ID
        /// </summary>
        /// <remarks>
        /// Operation to delete a user by record ID. To get record IDs, use \&quot;Get a user by login ID\&quot; or \&quot;Get a user by public id.\&quot;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="userrecordid">Specify the record ID of the user you want to delete</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsUsersUserDeleteV2Response</returns>
        UserDeleteV2Response UsersDeleteUserV2 (string userrecordid, string lang = null, string locale = null);

        /// <summary>
        /// Delete a user by record ID
        /// </summary>
        /// <remarks>
        /// Operation to delete a user by record ID. To get record IDs, use \&quot;Get a user by login ID\&quot; or \&quot;Get a user by public id.\&quot;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="userrecordid">Specify the record ID of the user you want to delete</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsUsersUserDeleteV2Response</returns>
        ApiResponse<UserDeleteV2Response> UsersDeleteUserV2WithHttpInfo (string userrecordid, string lang = null, string locale = null);
        /// <summary>
        /// Get a list of all system users.
        /// </summary>
        /// <remarks>
        /// Operation to get a list of all system users.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="loginidfilter">Specify the login ID filter to apply to the users list.</param>
        /// <param name="stoponerror">Specify whether the operation is interrupted if retrieving any user causes an error. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsUsersUserListResponse</returns>
        UserListResponse UsersGetListOfUsers (string loginidfilter, bool? stoponerror = null, string lang = null, string locale = null);

        /// <summary>
        /// Get a list of all system users.
        /// </summary>
        /// <remarks>
        /// Operation to get a list of all system users.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="loginidfilter">Specify the login ID filter to apply to the users list.</param>
        /// <param name="stoponerror">Specify whether the operation is interrupted if retrieving any user causes an error. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsUsersUserListResponse</returns>
        ApiResponse<UserListResponse> UsersGetListOfUsersWithHttpInfo (string loginidfilter, bool? stoponerror = null, string lang = null, string locale = null);
        /// <summary>
        /// Get user information in a batch
        /// </summary>
        /// <remarks>
        /// Operation to get user information in a batch. To get record IDs, use \&quot;Get a user by login ID\&quot; or \&quot;Get a user by public id.\&quot;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object that lists user record IDs or public IDs of users and an error flag.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsUsersUserBatchReadResponse</returns>
        TrebuchetWebApiDataContractsUsersUserBatchReadResponse UsersGetUserBatchV1 (TrebuchetWebApiDataContractsUsersUserBatchReadRequest request, string lang = null, string locale = null);

        /// <summary>
        /// Get user information in a batch
        /// </summary>
        /// <remarks>
        /// Operation to get user information in a batch. To get record IDs, use \&quot;Get a user by login ID\&quot; or \&quot;Get a user by public id.\&quot;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object that lists user record IDs or public IDs of users and an error flag.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsUsersUserBatchReadResponse</returns>
        ApiResponse<TrebuchetWebApiDataContractsUsersUserBatchReadResponse> UsersGetUserBatchV1WithHttpInfo (TrebuchetWebApiDataContractsUsersUserBatchReadRequest request, string lang = null, string locale = null);
        /// <summary>
        /// Get a user by login ID
        /// </summary>
        /// <remarks>
        /// Operation to get detailed user information by login ID. Use to get user record IDs and account settings, for example. This operation has been deprecated by a V2 operation of the same name, but with query string parameters.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="loginid">Specify the user&#39;s login ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsUsersUser</returns>
        TrebuchetWebApiDataContractsUsersUser UsersGetUserByLoginIdV1 (string loginid, string lang = null, string locale = null);

        /// <summary>
        /// Get a user by login ID
        /// </summary>
        /// <remarks>
        /// Operation to get detailed user information by login ID. Use to get user record IDs and account settings, for example. This operation has been deprecated by a V2 operation of the same name, but with query string parameters.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="loginid">Specify the user&#39;s login ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsUsersUser</returns>
        ApiResponse<TrebuchetWebApiDataContractsUsersUser> UsersGetUserByLoginIdV1WithHttpInfo (string loginid, string lang = null, string locale = null);
        /// <summary>
        /// Get a user by login ID and login ID type
        /// </summary>
        /// <remarks>
        /// Operation to get detailed user information by login ID. Use to get user record IDs and account settings, for example.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="loginid">Specify the user&#39;s login ID.</param>
        /// <param name="loginidtype">Specify the login ID type.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsUsersUser</returns>
        TrebuchetWebApiDataContractsUsersUser UsersGetUserByLoginIdV2 (string loginid, string loginidtype, string lang = null, string locale = null);

        /// <summary>
        /// Get a user by login ID and login ID type
        /// </summary>
        /// <remarks>
        /// Operation to get detailed user information by login ID. Use to get user record IDs and account settings, for example.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="loginid">Specify the user&#39;s login ID.</param>
        /// <param name="loginidtype">Specify the login ID type.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsUsersUser</returns>
        ApiResponse<TrebuchetWebApiDataContractsUsersUser> UsersGetUserByLoginIdV2WithHttpInfo (string loginid, string loginidtype, string lang = null, string locale = null);
        /// <summary>
        /// Get a user by login ID and login ID type
        /// </summary>
        /// <remarks>
        /// Operation to get detailed user information by login ID. Use to get user record IDs and account settings, for example.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="loginid">Specify the user&#39;s login ID.</param>
        /// <param name="loginidtype">Specify the login ID type.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsUsersUserV2</returns>
        UserV2 UsersGetUserByLoginIdV3 (string loginid, string loginidtype, string lang = null, string locale = null);

        /// <summary>
        /// Get a user by login ID and login ID type
        /// </summary>
        /// <remarks>
        /// Operation to get detailed user information by login ID. Use to get user record IDs and account settings, for example.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="loginid">Specify the user&#39;s login ID.</param>
        /// <param name="loginidtype">Specify the login ID type.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsUsersUserV2</returns>
        ApiResponse<UserV2> UsersGetUserByLoginIdV3WithHttpInfo (string loginid, string loginidtype, string lang = null, string locale = null);
        /// <summary>
        /// Get a user by public ID
        /// </summary>
        /// <remarks>
        /// Operation to get detailed user information by public ID. Use to get user record IDs and account settings, for example.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicid">Specify the user&#39;s public ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsUsersUserReadResponse</returns>
        UserReadResponse UsersGetUserByPublicIdV1 (string publicid, string lang = null, string locale = null);

        /// <summary>
        /// Get a user by public ID
        /// </summary>
        /// <remarks>
        /// Operation to get detailed user information by public ID. Use to get user record IDs and account settings, for example.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicid">Specify the user&#39;s public ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsUsersUserReadResponse</returns>
        ApiResponse<UserReadResponse> UsersGetUserByPublicIdV1WithHttpInfo (string publicid, string lang = null, string locale = null);
        /// <summary>
        /// Get a user by public ID
        /// </summary>
        /// <remarks>
        /// Operation to get detailed user information by public ID. Use to get user record IDs and account settings, for example.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicid">Specify the user&#39;s public ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsUsersUserReadV2Response</returns>
        UserReadV2Response UsersGetUserByPublicIdV2 (string publicid, string lang = null, string locale = null);

        /// <summary>
        /// Get a user by public ID
        /// </summary>
        /// <remarks>
        /// Operation to get detailed user information by public ID. Use to get user record IDs and account settings, for example.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicid">Specify the user&#39;s public ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsUsersUserReadV2Response</returns>
        ApiResponse<UserReadV2Response> UsersGetUserByPublicIdV2WithHttpInfo (string publicid, string lang = null, string locale = null);
        /// <summary>
        /// Get a user by record ID
        /// </summary>
        /// <remarks>
        /// Operation to get detailed user information by record ID.  Use to get user public IDs and account settings, for example.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="recid">Specify the user&#39;s record ID</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsUsersUserV2</returns>
        UserV2 UsersGetUserByRecId (string recid, string lang = null, string locale = null);

        /// <summary>
        /// Get a user by record ID
        /// </summary>
        /// <remarks>
        /// Operation to get detailed user information by record ID.  Use to get user public IDs and account settings, for example.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="recid">Specify the user&#39;s record ID</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsUsersUserV2</returns>
        ApiResponse<UserV2> UsersGetUserByRecIdWithHttpInfo (string recid, string lang = null, string locale = null);
        /// <summary>
        /// Create or update users in a batch
        /// </summary>
        /// <remarks>
        /// Operation to create or update users in a batch. To update, specify record ID. To create, leave record ID empty.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object listing user record IDs and an error flag.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsUsersUserBatchSaveResponse</returns>
        TrebuchetWebApiDataContractsUsersUserBatchSaveResponse UsersSaveUserBatchV1 (TrebuchetWebApiDataContractsUsersUserBatchSaveRequest request, string lang = null, string locale = null);

        /// <summary>
        /// Create or update users in a batch
        /// </summary>
        /// <remarks>
        /// Operation to create or update users in a batch. To update, specify record ID. To create, leave record ID empty.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object listing user record IDs and an error flag.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsUsersUserBatchSaveResponse</returns>
        ApiResponse<TrebuchetWebApiDataContractsUsersUserBatchSaveResponse> UsersSaveUserBatchV1WithHttpInfo (TrebuchetWebApiDataContractsUsersUserBatchSaveRequest request, string lang = null, string locale = null);
        /// <summary>
        /// Create or update users in a batch
        /// </summary>
        /// <remarks>
        /// Operation to create or update users in a batch. To update, specify record ID. To create, leave record ID empty.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object listing user record IDs and an error flag.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsUsersUserBatchSaveV2Response</returns>
        TrebuchetWebApiDataContractsUsersUserBatchSaveV2Response UsersSaveUserBatchV2 (TrebuchetWebApiDataContractsUsersUserBatchSaveV2Request request, string lang = null, string locale = null);

        /// <summary>
        /// Create or update users in a batch
        /// </summary>
        /// <remarks>
        /// Operation to create or update users in a batch. To update, specify record ID. To create, leave record ID empty.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object listing user record IDs and an error flag.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsUsersUserBatchSaveV2Response</returns>
        ApiResponse<TrebuchetWebApiDataContractsUsersUserBatchSaveV2Response> UsersSaveUserBatchV2WithHttpInfo (TrebuchetWebApiDataContractsUsersUserBatchSaveV2Request request, string lang = null, string locale = null);
        /// <summary>
        /// Create or update a user
        /// </summary>
        /// <remarks>
        /// Operation to create or update a user.  The response is a collection because if you use a public ID, more than one user could be updated since public IDs may not be unique. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object to specify user parameters and fields with values to be created or updated. The loginId and either the Business Object record ID or Public ID are required.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsUsersUserSaveResponse</returns>
        UserSaveResponse UsersSaveUserV1 (UserSaveRequest request, string lang = null, string locale = null);

        /// <summary>
        /// Create or update a user
        /// </summary>
        /// <remarks>
        /// Operation to create or update a user.  The response is a collection because if you use a public ID, more than one user could be updated since public IDs may not be unique. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object to specify user parameters and fields with values to be created or updated. The loginId and either the Business Object record ID or Public ID are required.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsUsersUserSaveResponse</returns>
        ApiResponse<UserSaveResponse> UsersSaveUserV1WithHttpInfo (UserSaveRequest request, string lang = null, string locale = null);
        /// <summary>
        /// Create or update a user
        /// </summary>
        /// <remarks>
        /// Operation to create or update a user.  The response is a collection because if you use a public ID, more than one user could be updated since public IDs may not be unique. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object to specify user parameters and fields with values to be created or updated. The loginId and either the Business Object record ID or Public ID are required.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsUsersUserSaveV2Response</returns>
        UserSaveV2Response UsersSaveUserV2 (UserSaveV2Request request, string lang = null, string locale = null);

        /// <summary>
        /// Create or update a user
        /// </summary>
        /// <remarks>
        /// Operation to create or update a user.  The response is a collection because if you use a public ID, more than one user could be updated since public IDs may not be unique. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object to specify user parameters and fields with values to be created or updated. The loginId and either the Business Object record ID or Public ID are required.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsUsersUserSaveV2Response</returns>
        ApiResponse<UserSaveV2Response> UsersSaveUserV2WithHttpInfo (UserSaveV2Request request, string lang = null, string locale = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Delete a batch of users
        /// </summary>
        /// <remarks>
        /// Operation to delete a batch of users. To get record IDs, use \&quot;Get a user by login ID\&quot; or \&quot;Get a user by public id.\&quot;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object listing record IDs for users to be deleted and an error flag.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsUsersUserBatchDeleteResponse</returns>
        System.Threading.Tasks.Task<TrebuchetWebApiDataContractsUsersUserBatchDeleteResponse> UsersDeleteUserBatchV1Async (TrebuchetWebApiDataContractsUsersUserBatchDeleteRequest request, string lang = null, string locale = null);

        /// <summary>
        /// Delete a batch of users
        /// </summary>
        /// <remarks>
        /// Operation to delete a batch of users. To get record IDs, use \&quot;Get a user by login ID\&quot; or \&quot;Get a user by public id.\&quot;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object listing record IDs for users to be deleted and an error flag.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsUsersUserBatchDeleteResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrebuchetWebApiDataContractsUsersUserBatchDeleteResponse>> UsersDeleteUserBatchV1AsyncWithHttpInfo (TrebuchetWebApiDataContractsUsersUserBatchDeleteRequest request, string lang = null, string locale = null);
        /// <summary>
        /// Delete a batch of users
        /// </summary>
        /// <remarks>
        /// Operation to delete a batch of users. To get record IDs, use \&quot;Get a user by login ID\&quot; or \&quot;Get a user by public id.\&quot;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object listing record IDs for users to be deleted and an error flag.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsUsersUserBatchDeleteV2Response</returns>
        System.Threading.Tasks.Task<TrebuchetWebApiDataContractsUsersUserBatchDeleteV2Response> UsersDeleteUserBatchV2Async (TrebuchetWebApiDataContractsUsersUserBatchDeleteRequest request, string lang = null, string locale = null);

        /// <summary>
        /// Delete a batch of users
        /// </summary>
        /// <remarks>
        /// Operation to delete a batch of users. To get record IDs, use \&quot;Get a user by login ID\&quot; or \&quot;Get a user by public id.\&quot;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object listing record IDs for users to be deleted and an error flag.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsUsersUserBatchDeleteV2Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrebuchetWebApiDataContractsUsersUserBatchDeleteV2Response>> UsersDeleteUserBatchV2AsyncWithHttpInfo (TrebuchetWebApiDataContractsUsersUserBatchDeleteRequest request, string lang = null, string locale = null);
        /// <summary>
        /// Delete a user by record ID
        /// </summary>
        /// <remarks>
        /// Operation to delete a user by record ID. To get record IDs, use \&quot;Get a user by login ID\&quot; or \&quot;Get a user by public id.\&quot;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="userrecordid">Specify the record ID of the user you want to delete</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsUsersUserDeleteResponse</returns>
        System.Threading.Tasks.Task<TrebuchetWebApiDataContractsUsersUserDeleteResponse> UsersDeleteUserV1Async (string userrecordid, string lang = null, string locale = null);

        /// <summary>
        /// Delete a user by record ID
        /// </summary>
        /// <remarks>
        /// Operation to delete a user by record ID. To get record IDs, use \&quot;Get a user by login ID\&quot; or \&quot;Get a user by public id.\&quot;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="userrecordid">Specify the record ID of the user you want to delete</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsUsersUserDeleteResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrebuchetWebApiDataContractsUsersUserDeleteResponse>> UsersDeleteUserV1AsyncWithHttpInfo (string userrecordid, string lang = null, string locale = null);
        /// <summary>
        /// Delete a user by record ID
        /// </summary>
        /// <remarks>
        /// Operation to delete a user by record ID. To get record IDs, use \&quot;Get a user by login ID\&quot; or \&quot;Get a user by public id.\&quot;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="userrecordid">Specify the record ID of the user you want to delete</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsUsersUserDeleteV2Response</returns>
        System.Threading.Tasks.Task<UserDeleteV2Response> UsersDeleteUserV2Async (string userrecordid, string lang = null, string locale = null);

        /// <summary>
        /// Delete a user by record ID
        /// </summary>
        /// <remarks>
        /// Operation to delete a user by record ID. To get record IDs, use \&quot;Get a user by login ID\&quot; or \&quot;Get a user by public id.\&quot;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="userrecordid">Specify the record ID of the user you want to delete</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsUsersUserDeleteV2Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserDeleteV2Response>> UsersDeleteUserV2AsyncWithHttpInfo (string userrecordid, string lang = null, string locale = null);
        /// <summary>
        /// Get a list of all system users.
        /// </summary>
        /// <remarks>
        /// Operation to get a list of all system users.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="loginidfilter">Specify the login ID filter to apply to the users list.</param>
        /// <param name="stoponerror">Specify whether the operation is interrupted if retrieving any user causes an error. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsUsersUserListResponse</returns>
        System.Threading.Tasks.Task<UserListResponse> UsersGetListOfUsersAsync (string loginidfilter, bool? stoponerror = null, string lang = null, string locale = null);

        /// <summary>
        /// Get a list of all system users.
        /// </summary>
        /// <remarks>
        /// Operation to get a list of all system users.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="loginidfilter">Specify the login ID filter to apply to the users list.</param>
        /// <param name="stoponerror">Specify whether the operation is interrupted if retrieving any user causes an error. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsUsersUserListResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserListResponse>> UsersGetListOfUsersAsyncWithHttpInfo (string loginidfilter, bool? stoponerror = null, string lang = null, string locale = null);
        /// <summary>
        /// Get user information in a batch
        /// </summary>
        /// <remarks>
        /// Operation to get user information in a batch. To get record IDs, use \&quot;Get a user by login ID\&quot; or \&quot;Get a user by public id.\&quot;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object that lists user record IDs or public IDs of users and an error flag.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsUsersUserBatchReadResponse</returns>
        System.Threading.Tasks.Task<TrebuchetWebApiDataContractsUsersUserBatchReadResponse> UsersGetUserBatchV1Async (TrebuchetWebApiDataContractsUsersUserBatchReadRequest request, string lang = null, string locale = null);

        /// <summary>
        /// Get user information in a batch
        /// </summary>
        /// <remarks>
        /// Operation to get user information in a batch. To get record IDs, use \&quot;Get a user by login ID\&quot; or \&quot;Get a user by public id.\&quot;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object that lists user record IDs or public IDs of users and an error flag.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsUsersUserBatchReadResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrebuchetWebApiDataContractsUsersUserBatchReadResponse>> UsersGetUserBatchV1AsyncWithHttpInfo (TrebuchetWebApiDataContractsUsersUserBatchReadRequest request, string lang = null, string locale = null);
        /// <summary>
        /// Get a user by login ID
        /// </summary>
        /// <remarks>
        /// Operation to get detailed user information by login ID. Use to get user record IDs and account settings, for example. This operation has been deprecated by a V2 operation of the same name, but with query string parameters.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="loginid">Specify the user&#39;s login ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsUsersUser</returns>
        System.Threading.Tasks.Task<TrebuchetWebApiDataContractsUsersUser> UsersGetUserByLoginIdV1Async (string loginid, string lang = null, string locale = null);

        /// <summary>
        /// Get a user by login ID
        /// </summary>
        /// <remarks>
        /// Operation to get detailed user information by login ID. Use to get user record IDs and account settings, for example. This operation has been deprecated by a V2 operation of the same name, but with query string parameters.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="loginid">Specify the user&#39;s login ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsUsersUser)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrebuchetWebApiDataContractsUsersUser>> UsersGetUserByLoginIdV1AsyncWithHttpInfo (string loginid, string lang = null, string locale = null);
        /// <summary>
        /// Get a user by login ID and login ID type
        /// </summary>
        /// <remarks>
        /// Operation to get detailed user information by login ID. Use to get user record IDs and account settings, for example.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="loginid">Specify the user&#39;s login ID.</param>
        /// <param name="loginidtype">Specify the login ID type.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsUsersUser</returns>
        System.Threading.Tasks.Task<TrebuchetWebApiDataContractsUsersUser> UsersGetUserByLoginIdV2Async (string loginid, string loginidtype, string lang = null, string locale = null);

        /// <summary>
        /// Get a user by login ID and login ID type
        /// </summary>
        /// <remarks>
        /// Operation to get detailed user information by login ID. Use to get user record IDs and account settings, for example.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="loginid">Specify the user&#39;s login ID.</param>
        /// <param name="loginidtype">Specify the login ID type.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsUsersUser)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrebuchetWebApiDataContractsUsersUser>> UsersGetUserByLoginIdV2AsyncWithHttpInfo (string loginid, string loginidtype, string lang = null, string locale = null);
        /// <summary>
        /// Get a user by login ID and login ID type
        /// </summary>
        /// <remarks>
        /// Operation to get detailed user information by login ID. Use to get user record IDs and account settings, for example.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="loginid">Specify the user&#39;s login ID.</param>
        /// <param name="loginidtype">Specify the login ID type.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsUsersUserV2</returns>
        System.Threading.Tasks.Task<UserV2> UsersGetUserByLoginIdV3Async (string loginid, string loginidtype, string lang = null, string locale = null);

        /// <summary>
        /// Get a user by login ID and login ID type
        /// </summary>
        /// <remarks>
        /// Operation to get detailed user information by login ID. Use to get user record IDs and account settings, for example.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="loginid">Specify the user&#39;s login ID.</param>
        /// <param name="loginidtype">Specify the login ID type.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsUsersUserV2)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserV2>> UsersGetUserByLoginIdV3AsyncWithHttpInfo (string loginid, string loginidtype, string lang = null, string locale = null);
        /// <summary>
        /// Get a user by public ID
        /// </summary>
        /// <remarks>
        /// Operation to get detailed user information by public ID. Use to get user record IDs and account settings, for example.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicid">Specify the user&#39;s public ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsUsersUserReadResponse</returns>
        System.Threading.Tasks.Task<UserReadResponse> UsersGetUserByPublicIdV1Async (string publicid, string lang = null, string locale = null);

        /// <summary>
        /// Get a user by public ID
        /// </summary>
        /// <remarks>
        /// Operation to get detailed user information by public ID. Use to get user record IDs and account settings, for example.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicid">Specify the user&#39;s public ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsUsersUserReadResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserReadResponse>> UsersGetUserByPublicIdV1AsyncWithHttpInfo (string publicid, string lang = null, string locale = null);
        /// <summary>
        /// Get a user by public ID
        /// </summary>
        /// <remarks>
        /// Operation to get detailed user information by public ID. Use to get user record IDs and account settings, for example.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicid">Specify the user&#39;s public ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsUsersUserReadV2Response</returns>
        System.Threading.Tasks.Task<UserReadV2Response> UsersGetUserByPublicIdV2Async (string publicid, string lang = null, string locale = null);

        /// <summary>
        /// Get a user by public ID
        /// </summary>
        /// <remarks>
        /// Operation to get detailed user information by public ID. Use to get user record IDs and account settings, for example.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicid">Specify the user&#39;s public ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsUsersUserReadV2Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserReadV2Response>> UsersGetUserByPublicIdV2AsyncWithHttpInfo (string publicid, string lang = null, string locale = null);
        /// <summary>
        /// Get a user by record ID
        /// </summary>
        /// <remarks>
        /// Operation to get detailed user information by record ID.  Use to get user public IDs and account settings, for example.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="recid">Specify the user&#39;s record ID</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsUsersUserV2</returns>
        System.Threading.Tasks.Task<UserV2> UsersGetUserByRecIdAsync (string recid, string lang = null, string locale = null);

        /// <summary>
        /// Get a user by record ID
        /// </summary>
        /// <remarks>
        /// Operation to get detailed user information by record ID.  Use to get user public IDs and account settings, for example.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="recid">Specify the user&#39;s record ID</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsUsersUserV2)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserV2>> UsersGetUserByRecIdAsyncWithHttpInfo (string recid, string lang = null, string locale = null);
        /// <summary>
        /// Create or update users in a batch
        /// </summary>
        /// <remarks>
        /// Operation to create or update users in a batch. To update, specify record ID. To create, leave record ID empty.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object listing user record IDs and an error flag.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsUsersUserBatchSaveResponse</returns>
        System.Threading.Tasks.Task<TrebuchetWebApiDataContractsUsersUserBatchSaveResponse> UsersSaveUserBatchV1Async (TrebuchetWebApiDataContractsUsersUserBatchSaveRequest request, string lang = null, string locale = null);

        /// <summary>
        /// Create or update users in a batch
        /// </summary>
        /// <remarks>
        /// Operation to create or update users in a batch. To update, specify record ID. To create, leave record ID empty.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object listing user record IDs and an error flag.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsUsersUserBatchSaveResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrebuchetWebApiDataContractsUsersUserBatchSaveResponse>> UsersSaveUserBatchV1AsyncWithHttpInfo (TrebuchetWebApiDataContractsUsersUserBatchSaveRequest request, string lang = null, string locale = null);
        /// <summary>
        /// Create or update users in a batch
        /// </summary>
        /// <remarks>
        /// Operation to create or update users in a batch. To update, specify record ID. To create, leave record ID empty.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object listing user record IDs and an error flag.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsUsersUserBatchSaveV2Response</returns>
        System.Threading.Tasks.Task<TrebuchetWebApiDataContractsUsersUserBatchSaveV2Response> UsersSaveUserBatchV2Async (TrebuchetWebApiDataContractsUsersUserBatchSaveV2Request request, string lang = null, string locale = null);

        /// <summary>
        /// Create or update users in a batch
        /// </summary>
        /// <remarks>
        /// Operation to create or update users in a batch. To update, specify record ID. To create, leave record ID empty.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object listing user record IDs and an error flag.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsUsersUserBatchSaveV2Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrebuchetWebApiDataContractsUsersUserBatchSaveV2Response>> UsersSaveUserBatchV2AsyncWithHttpInfo (TrebuchetWebApiDataContractsUsersUserBatchSaveV2Request request, string lang = null, string locale = null);
        /// <summary>
        /// Create or update a user
        /// </summary>
        /// <remarks>
        /// Operation to create or update a user.  The response is a collection because if you use a public ID, more than one user could be updated since public IDs may not be unique. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object to specify user parameters and fields with values to be created or updated. The loginId and either the Business Object record ID or Public ID are required.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsUsersUserSaveResponse</returns>
        System.Threading.Tasks.Task<UserSaveResponse> UsersSaveUserV1Async (UserSaveRequest request, string lang = null, string locale = null);

        /// <summary>
        /// Create or update a user
        /// </summary>
        /// <remarks>
        /// Operation to create or update a user.  The response is a collection because if you use a public ID, more than one user could be updated since public IDs may not be unique. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object to specify user parameters and fields with values to be created or updated. The loginId and either the Business Object record ID or Public ID are required.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsUsersUserSaveResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserSaveResponse>> UsersSaveUserV1AsyncWithHttpInfo (UserSaveRequest request, string lang = null, string locale = null);
        /// <summary>
        /// Create or update a user
        /// </summary>
        /// <remarks>
        /// Operation to create or update a user.  The response is a collection because if you use a public ID, more than one user could be updated since public IDs may not be unique. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object to specify user parameters and fields with values to be created or updated. The loginId and either the Business Object record ID or Public ID are required.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsUsersUserSaveV2Response</returns>
        System.Threading.Tasks.Task<UserSaveV2Response> UsersSaveUserV2Async (UserSaveV2Request request, string lang = null, string locale = null);

        /// <summary>
        /// Create or update a user
        /// </summary>
        /// <remarks>
        /// Operation to create or update a user.  The response is a collection because if you use a public ID, more than one user could be updated since public IDs may not be unique. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object to specify user parameters and fields with values to be created or updated. The loginId and either the Business Object record ID or Public ID are required.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsUsersUserSaveV2Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserSaveV2Response>> UsersSaveUserV2AsyncWithHttpInfo (UserSaveV2Request request, string lang = null, string locale = null);
        #endregion Asynchronous Operations
    }
}