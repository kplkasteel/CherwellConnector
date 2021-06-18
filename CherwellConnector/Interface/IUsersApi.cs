using CherwellConnector.Client;
using CherwellConnector.Model;

namespace CherwellConnector.Interface
{
    /// <summary>
    ///     Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUsersApi : IApiAccessor
    {
        /// <summary>
        ///     Delete a batch of users
        /// </summary>
        /// <remarks>
        ///     Operation to delete a batch of users. To get record IDs, use \&quot;Get a user by login ID\&quot; or \&quot;Get a
        ///     user by public id.\&quot;
        /// </remarks>
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
        UserBatchDeleteResponse UsersDeleteUserBatchV1(UserBatchDeleteRequest request, string lang = null,
            string locale = null);

        /// <summary>
        ///     Delete a batch of users
        /// </summary>
        /// <remarks>
        ///     Operation to delete a batch of users. To get record IDs, use \&quot;Get a user by login ID\&quot; or \&quot;Get a
        ///     user by public id.\&quot;
        /// </remarks>
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
        UserBatchDeleteV2Response UsersDeleteUserBatchV2(UserBatchDeleteRequest request, string lang = null,
            string locale = null);

        /// <summary>
        ///     Delete a user by record ID
        /// </summary>
        /// <remarks>
        ///     Operation to delete a user by record ID. To get record IDs, use \&quot;Get a user by login ID\&quot; or \&quot;Get
        ///     a user by public id.\&quot;
        /// </remarks>
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
        UserDeleteResponse UsersDeleteUserV1(string userrecordid, string lang = null, string locale = null);

        /// <summary>
        ///     Delete a user by record ID
        /// </summary>
        /// <remarks>
        ///     Operation to delete a user by record ID. To get record IDs, use \&quot;Get a user by login ID\&quot; or \&quot;Get
        ///     a user by public id.\&quot;
        /// </remarks>
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
        UserDeleteV2Response UsersDeleteUserV2(string userrecordid, string lang = null, string locale = null);

        /// <summary>
        ///     Get a list of all system users.
        /// </summary>
        /// <remarks>
        ///     Operation to get a list of all system users.
        /// </remarks>
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
        UserListResponse UsersGetListOfUsers(string loginidfilter, bool? stoponerror = null, string lang = null,
            string locale = null);

        /// <summary>
        ///     Get user information in a batch
        /// </summary>
        /// <remarks>
        ///     Operation to get user information in a batch. To get record IDs, use \&quot;Get a user by login ID\&quot; or \
        ///     &quot;Get a user by public id.\&quot;
        /// </remarks>
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
        UserBatchReadResponse UsersGetUserBatchV1(UserBatchReadRequest request, string lang = null,
            string locale = null);

        /// <summary>
        ///     Get a user by login ID
        /// </summary>
        /// <remarks>
        ///     Operation to get detailed user information by login ID. Use to get user record IDs and account settings, for
        ///     example. This operation has been deprecated by a V2 operation of the same name, but with query string parameters.
        /// </remarks>
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
        User UsersGetUserByLoginIdV1(string loginid, string lang = null, string locale = null);

        /// <summary>
        ///     Get a user by login ID and login ID type
        /// </summary>
        /// <remarks>
        ///     Operation to get detailed user information by login ID. Use to get user record IDs and account settings, for
        ///     example.
        /// </remarks>
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
        User UsersGetUserByLoginIdV2(string loginid, string loginidtype, string lang = null, string locale = null);

        /// <summary>
        ///     Get a user by login ID and login ID type
        /// </summary>
        /// <remarks>
        ///     Operation to get detailed user information by login ID. Use to get user record IDs and account settings, for
        ///     example.
        /// </remarks>
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
        UserV2 UsersGetUserByLoginIdV3(string loginid, string loginidtype, string lang = null, string locale = null);

        /// <summary>
        ///     Get a user by public ID
        /// </summary>
        /// <remarks>
        ///     Operation to get detailed user information by public ID. Use to get user record IDs and account settings, for
        ///     example.
        /// </remarks>
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
        UserReadResponse UsersGetUserByPublicIdV1(string publicid, string lang = null, string locale = null);

        /// <summary>
        ///     Get a user by public ID
        /// </summary>
        /// <remarks>
        ///     Operation to get detailed user information by public ID. Use to get user record IDs and account settings, for
        ///     example.
        /// </remarks>
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
        UserReadV2Response UsersGetUserByPublicIdV2(string publicid, string lang = null, string locale = null);

        /// <summary>
        ///     Get a user by record ID
        /// </summary>
        /// <remarks>
        ///     Operation to get detailed user information by record ID.  Use to get user public IDs and account settings, for
        ///     example.
        /// </remarks>
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
        UserV2 UsersGetUserByRecId(string recid, string lang = null, string locale = null);

        /// <summary>
        ///     Create or update users in a batch
        /// </summary>
        /// <remarks>
        ///     Operation to create or update users in a batch. To update, specify record ID. To create, leave record ID empty.
        /// </remarks>
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
        UserBatchSaveResponse UsersSaveUserBatchV1(UserBatchSaveRequest request, string lang = null,
            string locale = null);

        /// <summary>
        ///     Create or update users in a batch
        /// </summary>
        /// <remarks>
        ///     Operation to create or update users in a batch. To update, specify record ID. To create, leave record ID empty.
        /// </remarks>
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
        UserBatchSaveV2Response UsersSaveUserBatchV2(UserBatchSaveV2Request request, string lang = null,
            string locale = null);

        /// <summary>
        ///     Create or update a user
        /// </summary>
        /// <remarks>
        ///     Operation to create or update a user.  The response is a collection because if you use a public ID, more than one
        ///     user could be updated since public IDs may not be unique.
        /// </remarks>
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
        UserSaveResponse UsersSaveUserV1(UserSaveRequest request, string lang = null, string locale = null);

        /// <summary>
        ///     Create or update a user
        /// </summary>
        /// <remarks>
        ///     Operation to create or update a user.  The response is a collection because if you use a public ID, more than one
        ///     user could be updated since public IDs may not be unique.
        /// </remarks>
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
        UserSaveV2Response UsersSaveUserV2(UserSaveV2Request request, string lang = null, string locale = null);
    }
}