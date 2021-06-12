using CherwellConnector.Client;
using CherwellConnector.Model;
using Object = System.Object;

namespace CherwellConnector.Interface
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITeamsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Add users to a team by batch
        /// </summary>
        /// <remarks>
        /// Operation to add users to a Team by batch. To get internal IDs for users, use “Get User Information in a Batch.” To get a Team&#39;s internal ID, use \&quot;Get all available Teams.\&quot;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object to specify a list of add user to team request objects.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsTeamsAddUserToTeamByBatchResponse</returns>
        AddUserToTeamByBatchResponse TeamsAddUserToTeamByBatchV1 (AddUserToTeamByBatchRequest request, string lang = null, string locale = null);

        /// <summary>
        /// Add users to a team by batch
        /// </summary>
        /// <remarks>
        /// Operation to add users to a Team by batch. To get internal IDs for users, use “Get User Information in a Batch.” To get a Team&#39;s internal ID, use \&quot;Get all available Teams.\&quot;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object to specify a list of add user to team request objects.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsTeamsAddUserToTeamByBatchResponse</returns>
        ApiResponse<AddUserToTeamByBatchResponse> TeamsAddUserToTeamByBatchV1WithHttpInfo (AddUserToTeamByBatchRequest request, string lang = null, string locale = null);
        /// <summary>
        /// Add a user to a team
        /// </summary>
        /// <remarks>
        /// Operation to add a user to a Team. To get the user&#39;s internal ID, use \&quot;Get a user by login ID\&quot; or \&quot;Get a user by public ID.\&quot; To get a Team&#39;s internal ID, use \&quot;Get all available Teams.\&quot;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataRequest">Request object to specify user and team values.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns></returns>
        void TeamsAddUserToTeamV1 (AddUserToTeamRequest dataRequest, string lang = null, string locale = null);

        /// <summary>
        /// Add a user to a team
        /// </summary>
        /// <remarks>
        /// Operation to add a user to a Team. To get the user&#39;s internal ID, use \&quot;Get a user by login ID\&quot; or \&quot;Get a user by public ID.\&quot; To get a Team&#39;s internal ID, use \&quot;Get all available Teams.\&quot;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataRequest">Request object to specify user and team values.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<object> TeamsAddUserToTeamV1WithHttpInfo (AddUserToTeamRequest dataRequest, string lang = null, string locale = null);
        /// <summary>
        /// Add a user to a team
        /// </summary>
        /// <remarks>
        /// Operation to add a user to a Team. To get the user&#39;s internal ID, use \&quot;Get a user by login ID\&quot; or \&quot;Get a user by public ID.\&quot; To get a Team&#39;s internal ID, use \&quot;Get all available Teams.\&quot;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataRequest">Request object to specify user and team values.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsTeamsAddUserToTeamResponse</returns>
        AddUserToTeamResponse TeamsAddUserToTeamV2 (AddUserToTeamRequest dataRequest, string lang = null, string locale = null);

        /// <summary>
        /// Add a user to a team
        /// </summary>
        /// <remarks>
        /// Operation to add a user to a Team. To get the user&#39;s internal ID, use \&quot;Get a user by login ID\&quot; or \&quot;Get a user by public ID.\&quot; To get a Team&#39;s internal ID, use \&quot;Get all available Teams.\&quot;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataRequest">Request object to specify user and team values.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsTeamsAddUserToTeamResponse</returns>
        ApiResponse<AddUserToTeamResponse> TeamsAddUserToTeamV2WithHttpInfo (AddUserToTeamRequest dataRequest, string lang = null, string locale = null);
        /// <summary>
        /// Delete a Team
        /// </summary>
        /// <remarks>
        /// Operation to delete a Team by Team ID.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamid">Specify the Team ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns></returns>
        void TeamsDeleteTeamV1 (string teamid, string lang = null, string locale = null);

        /// <summary>
        /// Delete a Team
        /// </summary>
        /// <remarks>
        /// Operation to delete a Team by Team ID.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamid">Specify the Team ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<object> TeamsDeleteTeamV1WithHttpInfo (string teamid, string lang = null, string locale = null);
        /// <summary>
        /// Get a team by its TeamId
        /// </summary>
        /// <remarks>
        /// Operation to get Team Info for a  single Team using its Team ID. To get a Team&#39;s internal ID, use \&quot;Get all available Teams.\&quot; Note that TeamType has two possible values, where TeamType &#x3D; 0 for User (CSM Users), or TeamType &#x3D; 1 for Workgroup (CSM Customers).
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamid">The Team ID of the Team to get.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsTeamsTeamResponse</returns>
        TeamResponse TeamsGetTeamV1 (string teamid, string lang = null, string locale = null);

        /// <summary>
        /// Get a team by its TeamId
        /// </summary>
        /// <remarks>
        /// Operation to get Team Info for a  single Team using its Team ID. To get a Team&#39;s internal ID, use \&quot;Get all available Teams.\&quot; Note that TeamType has two possible values, where TeamType &#x3D; 0 for User (CSM Users), or TeamType &#x3D; 1 for Workgroup (CSM Customers).
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamid">The Team ID of the Team to get.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsTeamsTeamResponse</returns>
        ApiResponse<TeamResponse> TeamsGetTeamV1WithHttpInfo (string teamid, string lang = null, string locale = null);
        /// <summary>
        /// Get all available Teams
        /// </summary>
        /// <remarks>
        /// Operation to get IDs and names for all available Teams.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsTeamsTeamsResponse</returns>
        TeamsResponse TeamsGetTeamsV1 (string lang = null, string locale = null);

        /// <summary>
        /// Get all available Teams
        /// </summary>
        /// <remarks>
        /// Operation to get IDs and names for all available Teams.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsTeamsTeamsResponse</returns>
        ApiResponse<TeamsResponse> TeamsGetTeamsV1WithHttpInfo (string lang = null, string locale = null);
        /// <summary>
        /// Get all available Teams
        /// </summary>
        /// <remarks>
        /// Operation to get IDs and names for all available Teams.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsTeamsTeamsV2Response</returns>
        TeamsV2Response TeamsGetTeamsV2 (string lang = null, string locale = null);

        /// <summary>
        /// Get all available Teams
        /// </summary>
        /// <remarks>
        /// Operation to get IDs and names for all available Teams.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsTeamsTeamsV2Response</returns>
        ApiResponse<TeamsV2Response> TeamsGetTeamsV2WithHttpInfo (string lang = null, string locale = null);
        /// <summary>
        /// Get Team assignments for a user
        /// </summary>
        /// <remarks>
        /// Operation to get Team assignments for a user. To get record IDs, use \&quot;Get a user by login ID\&quot; or \&quot;Get a user by public id.\&quot;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="userRecordId">Specify the user record ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsTeamsTeamsResponse</returns>
        TeamsResponse TeamsGetUsersTeamsV1 (string userRecordId, string lang = null, string locale = null);

        /// <summary>
        /// Get Team assignments for a user
        /// </summary>
        /// <remarks>
        /// Operation to get Team assignments for a user. To get record IDs, use \&quot;Get a user by login ID\&quot; or \&quot;Get a user by public id.\&quot;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="userRecordId">Specify the user record ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsTeamsTeamsResponse</returns>
        ApiResponse<TeamsResponse> TeamsGetUsersTeamsV1WithHttpInfo (string userRecordId, string lang = null, string locale = null);
        /// <summary>
        /// Get Team assignments for a user
        /// </summary>
        /// <remarks>
        /// Operation to get Team assignments for a user. To get record IDs, use \&quot;Get a user by login ID\&quot; or \&quot;Get a user by public id.\&quot;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="userRecordId">Specify the user record ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsTeamsTeamsV2Response</returns>
        TeamsV2Response TeamsGetUsersTeamsV2 (string userRecordId, string lang = null, string locale = null);

        /// <summary>
        /// Get Team assignments for a user
        /// </summary>
        /// <remarks>
        /// Operation to get Team assignments for a user. To get record IDs, use \&quot;Get a user by login ID\&quot; or \&quot;Get a user by public id.\&quot;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="userRecordId">Specify the user record ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsTeamsTeamsV2Response</returns>
        ApiResponse<TeamsV2Response> TeamsGetUsersTeamsV2WithHttpInfo (string userRecordId, string lang = null, string locale = null);
        /// <summary>
        /// Get all available Workgroups
        /// </summary>
        /// <remarks>
        /// Operation to get IDs and names for all available Workgroups.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsTeamsTeamsResponse</returns>
        TeamsResponse TeamsGetWorkgroupsV1 (string lang = null, string locale = null);

        /// <summary>
        /// Get all available Workgroups
        /// </summary>
        /// <remarks>
        /// Operation to get IDs and names for all available Workgroups.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsTeamsTeamsResponse</returns>
        ApiResponse<TeamsResponse> TeamsGetWorkgroupsV1WithHttpInfo (string lang = null, string locale = null);
        /// <summary>
        /// Get all available Workgroups
        /// </summary>
        /// <remarks>
        /// Operation to get IDs and names for all available Workgroups.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsTeamsTeamsV2Response</returns>
        TeamsV2Response TeamsGetWorkgroupsV2 (string lang = null, string locale = null);

        /// <summary>
        /// Get all available Workgroups
        /// </summary>
        /// <remarks>
        /// Operation to get IDs and names for all available Workgroups.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsTeamsTeamsV2Response</returns>
        ApiResponse<TeamsV2Response> TeamsGetWorkgroupsV2WithHttpInfo (string lang = null, string locale = null);
        /// <summary>
        /// Remove a customer from a Workgroup
        /// </summary>
        /// <remarks>
        /// Operation to remove a Customer from a Workgroup.  To remove, specify the Workgroup ID and the Customer Record ID.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="workgroupid">Specify the Workgroup ID.</param>
        /// <param name="customerrecordid">Specify the Customer record ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsTeamsRemoveCustomerFromWorkgroupResponse</returns>
        RemoveCustomerFromWorkgroupResponse TeamsRemoveCustomerFromWorkgroupV1 (string workgroupid, string customerrecordid, string lang = null, string locale = null);

        /// <summary>
        /// Remove a customer from a Workgroup
        /// </summary>
        /// <remarks>
        /// Operation to remove a Customer from a Workgroup.  To remove, specify the Workgroup ID and the Customer Record ID.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="workgroupid">Specify the Workgroup ID.</param>
        /// <param name="customerrecordid">Specify the Customer record ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsTeamsRemoveCustomerFromWorkgroupResponse</returns>
        ApiResponse<RemoveCustomerFromWorkgroupResponse> TeamsRemoveCustomerFromWorkgroupV1WithHttpInfo (string workgroupid, string customerrecordid, string lang = null, string locale = null);
        /// <summary>
        /// Operation to remove a User from a Team.
        /// </summary>
        /// <remarks>
        /// Operation to remove a User from a Team. To get the User&#39;s record ID, use \&quot;Get a User by login ID\&quot; or \&quot;Get a User by public ID.\&quot; To get a Team&#39;s internal ID, use \&quot;Get all available Teams.\&quot;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamId">Specify the internal ID of the Team.</param>
        /// <param name="userrecordid">Specify the record ID of the User to remove.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns></returns>
        void TeamsRemoveUserFromTeamV1 (string teamId, string userrecordid, string lang = null, string locale = null);

        /// <summary>
        /// Operation to remove a User from a Team.
        /// </summary>
        /// <remarks>
        /// Operation to remove a User from a Team. To get the User&#39;s record ID, use \&quot;Get a User by login ID\&quot; or \&quot;Get a User by public ID.\&quot; To get a Team&#39;s internal ID, use \&quot;Get all available Teams.\&quot;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamId">Specify the internal ID of the Team.</param>
        /// <param name="userrecordid">Specify the record ID of the User to remove.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<object> TeamsRemoveUserFromTeamV1WithHttpInfo (string teamId, string userrecordid, string lang = null, string locale = null);
        /// <summary>
        /// Operation to remove a User from a Team.
        /// </summary>
        /// <remarks>
        /// Operation to remove a User from a Team. To get the User&#39;s record ID, use \&quot;Get a User by login ID\&quot; or \&quot;Get a User by public ID.\&quot; To get a Team&#39;s internal ID, use \&quot;Get all available Teams.\&quot;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamId">Specify the internal ID of the Team.</param>
        /// <param name="userrecordid">Specify the record ID of the User to remove.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsTeamsRemoveUserFromTeamResponse</returns>
        RemoveUserFromTeamResponse TeamsRemoveUserFromTeamV2 (string teamId, string userrecordid, string lang = null, string locale = null);

        /// <summary>
        /// Operation to remove a User from a Team.
        /// </summary>
        /// <remarks>
        /// Operation to remove a User from a Team. To get the User&#39;s record ID, use \&quot;Get a User by login ID\&quot; or \&quot;Get a User by public ID.\&quot; To get a Team&#39;s internal ID, use \&quot;Get all available Teams.\&quot;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamId">Specify the internal ID of the Team.</param>
        /// <param name="userrecordid">Specify the record ID of the User to remove.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsTeamsRemoveUserFromTeamResponse</returns>
        ApiResponse<RemoveUserFromTeamResponse> TeamsRemoveUserFromTeamV2WithHttpInfo (string teamId, string userrecordid, string lang = null, string locale = null);
        /// <summary>
        /// Add or Update a team member
        /// </summary>
        /// <remarks>
        /// Operation to add or update a Team Member. To add or update, specify User ID, Team ID, and if Team Manager.   Optionally, set the Team as the User&#39;s default Team.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">The request object to add or update a Team Member. User recID specifies the User to add or update. TeamId specifies the Team to update. IsTeamManager specifies whether the User is a Team Manager, and SetAsDefaultTeam specifies whether to set this Team as the User&#39;s default team. UserRecId, TeamId, and IsTeamManager are required.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsTeamsSaveTeamMemberResponse</returns>
        SaveTeamMemberResponse TeamsSaveTeamMemberV1 (SaveTeamMemberRequest request, string lang = null, string locale = null);

        /// <summary>
        /// Add or Update a team member
        /// </summary>
        /// <remarks>
        /// Operation to add or update a Team Member. To add or update, specify User ID, Team ID, and if Team Manager.   Optionally, set the Team as the User&#39;s default Team.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">The request object to add or update a Team Member. User recID specifies the User to add or update. TeamId specifies the Team to update. IsTeamManager specifies whether the User is a Team Manager, and SetAsDefaultTeam specifies whether to set this Team as the User&#39;s default team. UserRecId, TeamId, and IsTeamManager are required.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsTeamsSaveTeamMemberResponse</returns>
        ApiResponse<SaveTeamMemberResponse> TeamsSaveTeamMemberV1WithHttpInfo (SaveTeamMemberRequest request, string lang = null, string locale = null);
        /// <summary>
        /// Create or update a team
        /// </summary>
        /// <remarks>
        /// Operation to create or update a Team or Workgroup. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object to create Teams or Workgroups. To create a Team, use teamType and teamName. To update a team, use teamID. Team type values must be User or CustomerWorkgroup. The teamType cannot be changed for existing Teams or Workgroups.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsTeamsTeamSaveResponse</returns>
        TeamSaveResponse TeamsSaveTeamV1 (TeamSaveRequest request, string lang = null, string locale = null);

        /// <summary>
        /// Create or update a team
        /// </summary>
        /// <remarks>
        /// Operation to create or update a Team or Workgroup. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object to create Teams or Workgroups. To create a Team, use teamType and teamName. To update a team, use teamID. Team type values must be User or CustomerWorkgroup. The teamType cannot be changed for existing Teams or Workgroups.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsTeamsTeamSaveResponse</returns>
        ApiResponse<TeamSaveResponse> TeamsSaveTeamV1WithHttpInfo (TeamSaveRequest request, string lang = null, string locale = null);
        /// <summary>
        /// Save the membership status of a Workgroup member.
        /// </summary>
        /// <remarks>
        /// Operation to add or update a Workgroup Member.  To add or update, specify Customer Record ID, Workgroup ID, and if Workgroup Manager.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">The request object to add or update a Workgroup Member. CustomerRecordId specifies the Customer to add or update. WorkgroupId specifies the Workgroup to update. CustomerIsWorkgroupManager specifies whether the Customer is a Workgroup Manager.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsTeamsSaveWorkgroupMemberResponse</returns>
        SaveWorkgroupMemberResponse TeamsSaveWorkgroupMemberV1 (SaveWorkgroupMemberRequest request, string lang = null, string locale = null);

        /// <summary>
        /// Save the membership status of a Workgroup member.
        /// </summary>
        /// <remarks>
        /// Operation to add or update a Workgroup Member.  To add or update, specify Customer Record ID, Workgroup ID, and if Workgroup Manager.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">The request object to add or update a Workgroup Member. CustomerRecordId specifies the Customer to add or update. WorkgroupId specifies the Workgroup to update. CustomerIsWorkgroupManager specifies whether the Customer is a Workgroup Manager.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsTeamsSaveWorkgroupMemberResponse</returns>
        ApiResponse<SaveWorkgroupMemberResponse> TeamsSaveWorkgroupMemberV1WithHttpInfo (SaveWorkgroupMemberRequest request, string lang = null, string locale = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Add users to a team by batch
        /// </summary>
        /// <remarks>
        /// Operation to add users to a Team by batch. To get internal IDs for users, use “Get User Information in a Batch.” To get a Team&#39;s internal ID, use \&quot;Get all available Teams.\&quot;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object to specify a list of add user to team request objects.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsTeamsAddUserToTeamByBatchResponse</returns>
        System.Threading.Tasks.Task<AddUserToTeamByBatchResponse> TeamsAddUserToTeamByBatchV1Async (AddUserToTeamByBatchRequest request, string lang = null, string locale = null);

        /// <summary>
        /// Add users to a team by batch
        /// </summary>
        /// <remarks>
        /// Operation to add users to a Team by batch. To get internal IDs for users, use “Get User Information in a Batch.” To get a Team&#39;s internal ID, use \&quot;Get all available Teams.\&quot;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object to specify a list of add user to team request objects.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsTeamsAddUserToTeamByBatchResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AddUserToTeamByBatchResponse>> TeamsAddUserToTeamByBatchV1AsyncWithHttpInfo (AddUserToTeamByBatchRequest request, string lang = null, string locale = null);
        /// <summary>
        /// Add a user to a team
        /// </summary>
        /// <remarks>
        /// Operation to add a user to a Team. To get the user&#39;s internal ID, use \&quot;Get a user by login ID\&quot; or \&quot;Get a user by public ID.\&quot; To get a Team&#39;s internal ID, use \&quot;Get all available Teams.\&quot;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataRequest">Request object to specify user and team values.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task TeamsAddUserToTeamV1Async (AddUserToTeamRequest dataRequest, string lang = null, string locale = null);

        /// <summary>
        /// Add a user to a team
        /// </summary>
        /// <remarks>
        /// Operation to add a user to a Team. To get the user&#39;s internal ID, use \&quot;Get a user by login ID\&quot; or \&quot;Get a user by public ID.\&quot; To get a Team&#39;s internal ID, use \&quot;Get all available Teams.\&quot;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataRequest">Request object to specify user and team values.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<object>> TeamsAddUserToTeamV1AsyncWithHttpInfo (AddUserToTeamRequest dataRequest, string lang = null, string locale = null);
        /// <summary>
        /// Add a user to a team
        /// </summary>
        /// <remarks>
        /// Operation to add a user to a Team. To get the user&#39;s internal ID, use \&quot;Get a user by login ID\&quot; or \&quot;Get a user by public ID.\&quot; To get a Team&#39;s internal ID, use \&quot;Get all available Teams.\&quot;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataRequest">Request object to specify user and team values.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsTeamsAddUserToTeamResponse</returns>
        System.Threading.Tasks.Task<AddUserToTeamResponse> TeamsAddUserToTeamV2Async (AddUserToTeamRequest dataRequest, string lang = null, string locale = null);

        /// <summary>
        /// Add a user to a team
        /// </summary>
        /// <remarks>
        /// Operation to add a user to a Team. To get the user&#39;s internal ID, use \&quot;Get a user by login ID\&quot; or \&quot;Get a user by public ID.\&quot; To get a Team&#39;s internal ID, use \&quot;Get all available Teams.\&quot;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataRequest">Request object to specify user and team values.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsTeamsAddUserToTeamResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AddUserToTeamResponse>> TeamsAddUserToTeamV2AsyncWithHttpInfo (AddUserToTeamRequest dataRequest, string lang = null, string locale = null);
        /// <summary>
        /// Delete a Team
        /// </summary>
        /// <remarks>
        /// Operation to delete a Team by Team ID.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamid">Specify the Team ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task TeamsDeleteTeamV1Async (string teamid, string lang = null, string locale = null);

        /// <summary>
        /// Delete a Team
        /// </summary>
        /// <remarks>
        /// Operation to delete a Team by Team ID.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamid">Specify the Team ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<object>> TeamsDeleteTeamV1AsyncWithHttpInfo (string teamid, string lang = null, string locale = null);
        /// <summary>
        /// Get a team by its TeamId
        /// </summary>
        /// <remarks>
        /// Operation to get Team Info for a  single Team using its Team ID. To get a Team&#39;s internal ID, use \&quot;Get all available Teams.\&quot; Note that TeamType has two possible values, where TeamType &#x3D; 0 for User (CSM Users), or TeamType &#x3D; 1 for Workgroup (CSM Customers).
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamid">The Team ID of the Team to get.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsTeamsTeamResponse</returns>
        System.Threading.Tasks.Task<TeamResponse> TeamsGetTeamV1Async (string teamid, string lang = null, string locale = null);

        /// <summary>
        /// Get a team by its TeamId
        /// </summary>
        /// <remarks>
        /// Operation to get Team Info for a  single Team using its Team ID. To get a Team&#39;s internal ID, use \&quot;Get all available Teams.\&quot; Note that TeamType has two possible values, where TeamType &#x3D; 0 for User (CSM Users), or TeamType &#x3D; 1 for Workgroup (CSM Customers).
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamid">The Team ID of the Team to get.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsTeamsTeamResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TeamResponse>> TeamsGetTeamV1AsyncWithHttpInfo (string teamid, string lang = null, string locale = null);
        /// <summary>
        /// Get all available Teams
        /// </summary>
        /// <remarks>
        /// Operation to get IDs and names for all available Teams.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsTeamsTeamsResponse</returns>
        System.Threading.Tasks.Task<TeamsResponse> TeamsGetTeamsV1Async (string lang = null, string locale = null);

        /// <summary>
        /// Get all available Teams
        /// </summary>
        /// <remarks>
        /// Operation to get IDs and names for all available Teams.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsTeamsTeamsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TeamsResponse>> TeamsGetTeamsV1AsyncWithHttpInfo (string lang = null, string locale = null);
        /// <summary>
        /// Get all available Teams
        /// </summary>
        /// <remarks>
        /// Operation to get IDs and names for all available Teams.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsTeamsTeamsV2Response</returns>
        System.Threading.Tasks.Task<TeamsV2Response> TeamsGetTeamsV2Async (string lang = null, string locale = null);

        /// <summary>
        /// Get all available Teams
        /// </summary>
        /// <remarks>
        /// Operation to get IDs and names for all available Teams.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsTeamsTeamsV2Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<TeamsV2Response>> TeamsGetTeamsV2AsyncWithHttpInfo (string lang = null, string locale = null);
        /// <summary>
        /// Get Team assignments for a user
        /// </summary>
        /// <remarks>
        /// Operation to get Team assignments for a user. To get record IDs, use \&quot;Get a user by login ID\&quot; or \&quot;Get a user by public id.\&quot;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="userRecordId">Specify the user record ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsTeamsTeamsResponse</returns>
        System.Threading.Tasks.Task<TeamsResponse> TeamsGetUsersTeamsV1Async (string userRecordId, string lang = null, string locale = null);

        /// <summary>
        /// Get Team assignments for a user
        /// </summary>
        /// <remarks>
        /// Operation to get Team assignments for a user. To get record IDs, use \&quot;Get a user by login ID\&quot; or \&quot;Get a user by public id.\&quot;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="userRecordId">Specify the user record ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsTeamsTeamsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TeamsResponse>> TeamsGetUsersTeamsV1AsyncWithHttpInfo (string userRecordId, string lang = null, string locale = null);
        /// <summary>
        /// Get Team assignments for a user
        /// </summary>
        /// <remarks>
        /// Operation to get Team assignments for a user. To get record IDs, use \&quot;Get a user by login ID\&quot; or \&quot;Get a user by public id.\&quot;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="userRecordId">Specify the user record ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsTeamsTeamsV2Response</returns>
        System.Threading.Tasks.Task<TeamsV2Response> TeamsGetUsersTeamsV2Async (string userRecordId, string lang = null, string locale = null);

        /// <summary>
        /// Get Team assignments for a user
        /// </summary>
        /// <remarks>
        /// Operation to get Team assignments for a user. To get record IDs, use \&quot;Get a user by login ID\&quot; or \&quot;Get a user by public id.\&quot;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="userRecordId">Specify the user record ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsTeamsTeamsV2Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<TeamsV2Response>> TeamsGetUsersTeamsV2AsyncWithHttpInfo (string userRecordId, string lang = null, string locale = null);
        /// <summary>
        /// Get all available Workgroups
        /// </summary>
        /// <remarks>
        /// Operation to get IDs and names for all available Workgroups.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsTeamsTeamsResponse</returns>
        System.Threading.Tasks.Task<TeamsResponse> TeamsGetWorkgroupsV1Async (string lang = null, string locale = null);

        /// <summary>
        /// Get all available Workgroups
        /// </summary>
        /// <remarks>
        /// Operation to get IDs and names for all available Workgroups.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsTeamsTeamsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TeamsResponse>> TeamsGetWorkgroupsV1AsyncWithHttpInfo (string lang = null, string locale = null);
        /// <summary>
        /// Get all available Workgroups
        /// </summary>
        /// <remarks>
        /// Operation to get IDs and names for all available Workgroups.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsTeamsTeamsV2Response</returns>
        System.Threading.Tasks.Task<TeamsV2Response> TeamsGetWorkgroupsV2Async (string lang = null, string locale = null);

        /// <summary>
        /// Get all available Workgroups
        /// </summary>
        /// <remarks>
        /// Operation to get IDs and names for all available Workgroups.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsTeamsTeamsV2Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<TeamsV2Response>> TeamsGetWorkgroupsV2AsyncWithHttpInfo (string lang = null, string locale = null);
        /// <summary>
        /// Remove a customer from a Workgroup
        /// </summary>
        /// <remarks>
        /// Operation to remove a Customer from a Workgroup.  To remove, specify the Workgroup ID and the Customer Record ID.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="workgroupid">Specify the Workgroup ID.</param>
        /// <param name="customerrecordid">Specify the Customer record ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsTeamsRemoveCustomerFromWorkgroupResponse</returns>
        System.Threading.Tasks.Task<RemoveCustomerFromWorkgroupResponse> TeamsRemoveCustomerFromWorkgroupV1Async (string workgroupid, string customerrecordid, string lang = null, string locale = null);

        /// <summary>
        /// Remove a customer from a Workgroup
        /// </summary>
        /// <remarks>
        /// Operation to remove a Customer from a Workgroup.  To remove, specify the Workgroup ID and the Customer Record ID.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="workgroupid">Specify the Workgroup ID.</param>
        /// <param name="customerrecordid">Specify the Customer record ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsTeamsRemoveCustomerFromWorkgroupResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<RemoveCustomerFromWorkgroupResponse>> TeamsRemoveCustomerFromWorkgroupV1AsyncWithHttpInfo (string workgroupid, string customerrecordid, string lang = null, string locale = null);
        /// <summary>
        /// Operation to remove a User from a Team.
        /// </summary>
        /// <remarks>
        /// Operation to remove a User from a Team. To get the User&#39;s record ID, use \&quot;Get a User by login ID\&quot; or \&quot;Get a User by public ID.\&quot; To get a Team&#39;s internal ID, use \&quot;Get all available Teams.\&quot;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamId">Specify the internal ID of the Team.</param>
        /// <param name="userrecordid">Specify the record ID of the User to remove.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task TeamsRemoveUserFromTeamV1Async (string teamId, string userrecordid, string lang = null, string locale = null);

        /// <summary>
        /// Operation to remove a User from a Team.
        /// </summary>
        /// <remarks>
        /// Operation to remove a User from a Team. To get the User&#39;s record ID, use \&quot;Get a User by login ID\&quot; or \&quot;Get a User by public ID.\&quot; To get a Team&#39;s internal ID, use \&quot;Get all available Teams.\&quot;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamId">Specify the internal ID of the Team.</param>
        /// <param name="userrecordid">Specify the record ID of the User to remove.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<object>> TeamsRemoveUserFromTeamV1AsyncWithHttpInfo (string teamId, string userrecordid, string lang = null, string locale = null);
        /// <summary>
        /// Operation to remove a User from a Team.
        /// </summary>
        /// <remarks>
        /// Operation to remove a User from a Team. To get the User&#39;s record ID, use \&quot;Get a User by login ID\&quot; or \&quot;Get a User by public ID.\&quot; To get a Team&#39;s internal ID, use \&quot;Get all available Teams.\&quot;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamId">Specify the internal ID of the Team.</param>
        /// <param name="userrecordid">Specify the record ID of the User to remove.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsTeamsRemoveUserFromTeamResponse</returns>
        System.Threading.Tasks.Task<RemoveUserFromTeamResponse> TeamsRemoveUserFromTeamV2Async (string teamId, string userrecordid, string lang = null, string locale = null);

        /// <summary>
        /// Operation to remove a User from a Team.
        /// </summary>
        /// <remarks>
        /// Operation to remove a User from a Team. To get the User&#39;s record ID, use \&quot;Get a User by login ID\&quot; or \&quot;Get a User by public ID.\&quot; To get a Team&#39;s internal ID, use \&quot;Get all available Teams.\&quot;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamId">Specify the internal ID of the Team.</param>
        /// <param name="userrecordid">Specify the record ID of the User to remove.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsTeamsRemoveUserFromTeamResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<RemoveUserFromTeamResponse>> TeamsRemoveUserFromTeamV2AsyncWithHttpInfo (string teamId, string userrecordid, string lang = null, string locale = null);
        /// <summary>
        /// Add or Update a team member
        /// </summary>
        /// <remarks>
        /// Operation to add or update a Team Member. To add or update, specify User ID, Team ID, and if Team Manager.   Optionally, set the Team as the User&#39;s default Team.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">The request object to add or update a Team Member. User recID specifies the User to add or update. TeamId specifies the Team to update. IsTeamManager specifies whether the User is a Team Manager, and SetAsDefaultTeam specifies whether to set this Team as the User&#39;s default team. UserRecId, TeamId, and IsTeamManager are required.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsTeamsSaveTeamMemberResponse</returns>
        System.Threading.Tasks.Task<SaveTeamMemberResponse> TeamsSaveTeamMemberV1Async (SaveTeamMemberRequest request, string lang = null, string locale = null);

        /// <summary>
        /// Add or Update a team member
        /// </summary>
        /// <remarks>
        /// Operation to add or update a Team Member. To add or update, specify User ID, Team ID, and if Team Manager.   Optionally, set the Team as the User&#39;s default Team.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">The request object to add or update a Team Member. User recID specifies the User to add or update. TeamId specifies the Team to update. IsTeamManager specifies whether the User is a Team Manager, and SetAsDefaultTeam specifies whether to set this Team as the User&#39;s default team. UserRecId, TeamId, and IsTeamManager are required.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsTeamsSaveTeamMemberResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<SaveTeamMemberResponse>> TeamsSaveTeamMemberV1AsyncWithHttpInfo (SaveTeamMemberRequest request, string lang = null, string locale = null);
        /// <summary>
        /// Create or update a team
        /// </summary>
        /// <remarks>
        /// Operation to create or update a Team or Workgroup. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object to create Teams or Workgroups. To create a Team, use teamType and teamName. To update a team, use teamID. Team type values must be User or CustomerWorkgroup. The teamType cannot be changed for existing Teams or Workgroups.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsTeamsTeamSaveResponse</returns>
        System.Threading.Tasks.Task<TeamSaveResponse> TeamsSaveTeamV1Async (TeamSaveRequest request, string lang = null, string locale = null);

        /// <summary>
        /// Create or update a team
        /// </summary>
        /// <remarks>
        /// Operation to create or update a Team or Workgroup. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object to create Teams or Workgroups. To create a Team, use teamType and teamName. To update a team, use teamID. Team type values must be User or CustomerWorkgroup. The teamType cannot be changed for existing Teams or Workgroups.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsTeamsTeamSaveResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TeamSaveResponse>> TeamsSaveTeamV1AsyncWithHttpInfo (TeamSaveRequest request, string lang = null, string locale = null);
        /// <summary>
        /// Save the membership status of a Workgroup member.
        /// </summary>
        /// <remarks>
        /// Operation to add or update a Workgroup Member.  To add or update, specify Customer Record ID, Workgroup ID, and if Workgroup Manager.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">The request object to add or update a Workgroup Member. CustomerRecordId specifies the Customer to add or update. WorkgroupId specifies the Workgroup to update. CustomerIsWorkgroupManager specifies whether the Customer is a Workgroup Manager.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsTeamsSaveWorkgroupMemberResponse</returns>
        System.Threading.Tasks.Task<SaveWorkgroupMemberResponse> TeamsSaveWorkgroupMemberV1Async (SaveWorkgroupMemberRequest request, string lang = null, string locale = null);

        /// <summary>
        /// Save the membership status of a Workgroup member.
        /// </summary>
        /// <remarks>
        /// Operation to add or update a Workgroup Member.  To add or update, specify Customer Record ID, Workgroup ID, and if Workgroup Manager.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">The request object to add or update a Workgroup Member. CustomerRecordId specifies the Customer to add or update. WorkgroupId specifies the Workgroup to update. CustomerIsWorkgroupManager specifies whether the Customer is a Workgroup Manager.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsTeamsSaveWorkgroupMemberResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<SaveWorkgroupMemberResponse>> TeamsSaveWorkgroupMemberV1AsyncWithHttpInfo (SaveWorkgroupMemberRequest request, string lang = null, string locale = null);
        #endregion Asynchronous Operations
    }
}