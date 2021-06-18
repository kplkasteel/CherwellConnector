using CherwellConnector.Client;
using CherwellConnector.Model;

namespace CherwellConnector.Interface
{
    /// <summary>
    ///     Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITeamsApi : IApiAccessor
    {
        /// <summary>
        ///     Add users to a team by batch
        /// </summary>
        /// <remarks>
        ///     Operation to add users to a Team by batch. To get internal IDs for users, use “Get User Information in a Batch.” To
        ///     get a Team&#39;s internal ID, use \&quot;Get all available Teams.\&quot;
        /// </remarks>
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
        AddUserToTeamByBatchResponse TeamsAddUserToTeamByBatchV1(AddUserToTeamByBatchRequest request,
            string lang = null, string locale = null);

        /// <summary>
        ///     Add a user to a team
        /// </summary>
        /// <remarks>
        ///     Operation to add a user to a Team. To get the user&#39;s internal ID, use \&quot;Get a user by login ID\&quot; or \
        ///     &quot;Get a user by public ID.\&quot; To get a Team&#39;s internal ID, use \&quot;Get all available Teams.\&quot;
        /// </remarks>
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
        object TeamsAddUserToTeamV1(AddUserToTeamRequest dataRequest, string lang = null, string locale = null);


        /// <summary>
        ///     Add a user to a team
        /// </summary>
        /// <remarks>
        ///     Operation to add a user to a Team. To get the user&#39;s internal ID, use \&quot;Get a user by login ID\&quot; or \
        ///     &quot;Get a user by public ID.\&quot; To get a Team&#39;s internal ID, use \&quot;Get all available Teams.\&quot;
        /// </remarks>
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
        AddUserToTeamResponse TeamsAddUserToTeamV2(AddUserToTeamRequest dataRequest, string lang = null,
            string locale = null);

        /// <summary>
        ///     Delete a Team
        /// </summary>
        /// <remarks>
        ///     Operation to delete a Team by Team ID.
        /// </remarks>
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
        object TeamsDeleteTeamV1(string teamid, string lang = null, string locale = null);

        /// <summary>
        ///     Get a team by its TeamId
        /// </summary>
        /// <remarks>
        ///     Operation to get Team Info for a  single Team using its Team ID. To get a Team&#39;s internal ID, use \&quot;Get
        ///     all available Teams.\&quot; Note that TeamType has two possible values, where TeamType &#x3D; 0 for User (CSM
        ///     Users), or TeamType &#x3D; 1 for Workgroup (CSM Customers).
        /// </remarks>
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
        TeamResponse TeamsGetTeamV1(string teamid, string lang = null, string locale = null);

        /// <summary>
        ///     Get all available Teams
        /// </summary>
        /// <remarks>
        ///     Operation to get IDs and names for all available Teams.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>TeamResponse</returns>
        TeamsResponse TeamsGetTeamsV1(string lang = null, string locale = null);

        /// <summary>
        ///     Get all available Teams
        /// </summary>
        /// <remarks>
        ///     Operation to get IDs and names for all available Teams.
        /// </remarks>
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
        TeamsV2Response TeamsGetTeamsV2(string lang = null, string locale = null);

        /// <summary>
        ///     Get Team assignments for a user
        /// </summary>
        /// <remarks>
        ///     Operation to get Team assignments for a user. To get record IDs, use \&quot;Get a user by login ID\&quot; or \
        ///     &quot;Get a user by public id.\&quot;
        /// </remarks>
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
        TeamsResponse TeamsGetUsersTeamsV1(string userRecordId, string lang = null, string locale = null);

        /// <summary>
        ///     Get Team assignments for a user
        /// </summary>
        /// <remarks>
        ///     Operation to get Team assignments for a user. To get record IDs, use \&quot;Get a user by login ID\&quot; or \
        ///     &quot;Get a user by public id.\&quot;
        /// </remarks>
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
        TeamsV2Response TeamsGetUsersTeamsV2(string userRecordId, string lang = null, string locale = null);

        /// <summary>
        ///     Get all available Workgroups
        /// </summary>
        /// <remarks>
        ///     Operation to get IDs and names for all available Workgroups.
        /// </remarks>
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
        TeamsResponse TeamsGetWorkgroupsV1(string lang = null, string locale = null);

        /// <summary>
        ///     Get all available Workgroups
        /// </summary>
        /// <remarks>
        ///     Operation to get IDs and names for all available Workgroups.
        /// </remarks>
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
        TeamsV2Response TeamsGetWorkgroupsV2(string lang = null, string locale = null);

        /// <summary>
        ///     Remove a customer from a Workgroup
        /// </summary>
        /// <remarks>
        ///     Operation to remove a Customer from a Workgroup.  To remove, specify the Workgroup ID and the Customer Record ID.
        /// </remarks>
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
        RemoveCustomerFromWorkgroupResponse TeamsRemoveCustomerFromWorkgroupV1(string workgroupid,
            string customerrecordid, string lang = null, string locale = null);

        /// <summary>
        ///     Operation to remove a User from a Team.
        /// </summary>
        /// <remarks>
        ///     Operation to remove a User from a Team. To get the User&#39;s record ID, use \&quot;Get a User by login ID\&quot;
        ///     or \&quot;Get a User by public ID.\&quot; To get a Team&#39;s internal ID, use \&quot;Get all available Teams.\
        ///     &quot;
        /// </remarks>
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
        object TeamsRemoveUserFromTeamV1(string teamId, string userrecordid, string lang = null, string locale = null);

        /// <summary>
        ///     Operation to remove a User from a Team.
        /// </summary>
        /// <remarks>
        ///     Operation to remove a User from a Team. To get the User&#39;s record ID, use \&quot;Get a User by login ID\&quot;
        ///     or \&quot;Get a User by public ID.\&quot; To get a Team&#39;s internal ID, use \&quot;Get all available Teams.\
        ///     &quot;
        /// </remarks>
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
        RemoveUserFromTeamResponse TeamsRemoveUserFromTeamV2(string teamId, string userrecordid, string lang = null,
            string locale = null);

        /// <summary>
        ///     Add or Update a team member
        /// </summary>
        /// <remarks>
        ///     Operation to add or update a Team Member. To add or update, specify User ID, Team ID, and if Team Manager.
        ///     Optionally, set the Team as the User&#39;s default Team.
        /// </remarks>
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
        SaveTeamMemberResponse TeamsSaveTeamMemberV1(SaveTeamMemberRequest request, string lang = null,
            string locale = null);

        /// <summary>
        ///     Create or update a team
        /// </summary>
        /// <remarks>
        ///     Operation to create or update a Team or Workgroup.
        /// </remarks>
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
        TeamSaveResponse TeamsSaveTeamV1(TeamSaveRequest request, string lang = null, string locale = null);

        /// <summary>
        ///     Save the membership status of a Workgroup member.
        /// </summary>
        /// <remarks>
        ///     Operation to add or update a Workgroup Member.  To add or update, specify Customer Record ID, Workgroup ID, and if
        ///     Workgroup Manager.
        /// </remarks>
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
        SaveWorkgroupMemberResponse TeamsSaveWorkgroupMemberV1(SaveWorkgroupMemberRequest request, string lang = null,
            string locale = null);
    }
}