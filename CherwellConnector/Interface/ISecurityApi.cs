using System.Collections.Generic;
using CherwellConnector.Client;
using CherwellConnector.Model;

namespace CherwellConnector.Interface
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISecurityApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get client security settings
        /// </summary>
        /// <remarks>
        /// Operation to get the configured client security settings. Returns true if internal, Windows, LDAP, or SAML are enabled as authentication methods.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationtype">The type of CSM application to return security settings for.  Application type is Desktop Client, Browser Client, Browser Portal or Cherwell Mobile.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsSecurityClientSecuritySettingsResponse</returns>
        TrebuchetWebApiDataContractsSecurityClientSecuritySettingsResponse SecurityGetClientSecuritySettingsV1 (string applicationtype, string lang = null, string locale = null);

        /// <summary>
        /// Get client security settings
        /// </summary>
        /// <remarks>
        /// Operation to get the configured client security settings. Returns true if internal, Windows, LDAP, or SAML are enabled as authentication methods.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationtype">The type of CSM application to return security settings for.  Application type is Desktop Client, Browser Client, Browser Portal or Cherwell Mobile.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsSecurityClientSecuritySettingsResponse</returns>
        ApiResponse<TrebuchetWebApiDataContractsSecurityClientSecuritySettingsResponse> SecurityGetClientSecuritySettingsV1WithHttpInfo (string applicationtype, string lang = null, string locale = null);
        /// <summary>
        /// Get all available Roles
        /// </summary>
        /// <remarks>
        /// Operation to get all available Roles.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsSecurityRoleReadResponse</returns>
        TrebuchetWebApiDataContractsSecurityRoleReadResponse SecurityGetRolesV1 (string lang = null, string locale = null);

        /// <summary>
        /// Get all available Roles
        /// </summary>
        /// <remarks>
        /// Operation to get all available Roles.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsSecurityRoleReadResponse</returns>
        ApiResponse<TrebuchetWebApiDataContractsSecurityRoleReadResponse> SecurityGetRolesV1WithHttpInfo (string lang = null, string locale = null);
        /// <summary>
        /// Get all available Roles
        /// </summary>
        /// <remarks>
        /// Operation to get all available Roles.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsSecurityRoleReadV2Response</returns>
        TrebuchetWebApiDataContractsSecurityRoleReadV2Response SecurityGetRolesV2 (string lang = null, string locale = null);

        /// <summary>
        /// Get all available Roles
        /// </summary>
        /// <remarks>
        /// Operation to get all available Roles.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsSecurityRoleReadV2Response</returns>
        ApiResponse<TrebuchetWebApiDataContractsSecurityRoleReadV2Response> SecurityGetRolesV2WithHttpInfo (string lang = null, string locale = null);
        /// <summary>
        /// Get Business Object permissions by Security Group
        /// </summary>
        /// <remarks>
        /// Operation to get specific Business Object permissions for a Security Group. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupid">Specify the Security Group ID. </param>
        /// <param name="busObId">Specify the Business Object ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>List&lt;TrebuchetWebApiDataContractsSecurityBusinessObjectPermission&gt;</returns>
        List<TrebuchetWebApiDataContractsSecurityBusinessObjectPermission> SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV1 (string groupid, string busObId, string lang = null, string locale = null);

        /// <summary>
        /// Get Business Object permissions by Security Group
        /// </summary>
        /// <remarks>
        /// Operation to get specific Business Object permissions for a Security Group. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupid">Specify the Security Group ID. </param>
        /// <param name="busObId">Specify the Business Object ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of List&lt;TrebuchetWebApiDataContractsSecurityBusinessObjectPermission&gt;</returns>
        ApiResponse<List<TrebuchetWebApiDataContractsSecurityBusinessObjectPermission>> SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV1WithHttpInfo (string groupid, string busObId, string lang = null, string locale = null);
        /// <summary>
        /// Get Business Object permissions by Security Group
        /// </summary>
        /// <remarks>
        /// Operation to get specific Business Object permissions for a Security Group. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupid">Specify the Security Group ID. </param>
        /// <param name="busObId">Specify the Business Object ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsSecurityGetSecurityGroupBusinessObjectPermissionsResponse</returns>
        TrebuchetWebApiDataContractsSecurityGetSecurityGroupBusinessObjectPermissionsResponse SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV2 (string groupid, string busObId, string lang = null, string locale = null);

        /// <summary>
        /// Get Business Object permissions by Security Group
        /// </summary>
        /// <remarks>
        /// Operation to get specific Business Object permissions for a Security Group. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupid">Specify the Security Group ID. </param>
        /// <param name="busObId">Specify the Business Object ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsSecurityGetSecurityGroupBusinessObjectPermissionsResponse</returns>
        ApiResponse<TrebuchetWebApiDataContractsSecurityGetSecurityGroupBusinessObjectPermissionsResponse> SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV2WithHttpInfo (string groupid, string busObId, string lang = null, string locale = null);
        /// <summary>
        /// Get Business Object permissions by Security Group
        /// </summary>
        /// <remarks>
        /// Operation to get specific Business Object permissions for a Security Group. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupname">Specify the Security Group name. </param>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>List&lt;TrebuchetWebApiDataContractsSecurityBusinessObjectPermission&gt;</returns>
        List<TrebuchetWebApiDataContractsSecurityBusinessObjectPermission> SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV1 (string groupname, string busobname, string lang = null, string locale = null);

        /// <summary>
        /// Get Business Object permissions by Security Group
        /// </summary>
        /// <remarks>
        /// Operation to get specific Business Object permissions for a Security Group. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupname">Specify the Security Group name. </param>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of List&lt;TrebuchetWebApiDataContractsSecurityBusinessObjectPermission&gt;</returns>
        ApiResponse<List<TrebuchetWebApiDataContractsSecurityBusinessObjectPermission>> SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV1WithHttpInfo (string groupname, string busobname, string lang = null, string locale = null);
        /// <summary>
        /// Get Business Object permissions by Security Group
        /// </summary>
        /// <remarks>
        /// Operation to get specific Business Object permissions for a Security Group. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupname">Specify the Security Group name. </param>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsSecurityGetSecurityGroupBusinessObjectPermissionsResponse</returns>
        TrebuchetWebApiDataContractsSecurityGetSecurityGroupBusinessObjectPermissionsResponse SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV2 (string groupname, string busobname, string lang = null, string locale = null);

        /// <summary>
        /// Get Business Object permissions by Security Group
        /// </summary>
        /// <remarks>
        /// Operation to get specific Business Object permissions for a Security Group. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupname">Specify the Security Group name. </param>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsSecurityGetSecurityGroupBusinessObjectPermissionsResponse</returns>
        ApiResponse<TrebuchetWebApiDataContractsSecurityGetSecurityGroupBusinessObjectPermissionsResponse> SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV2WithHttpInfo (string groupname, string busobname, string lang = null, string locale = null);
        /// <summary>
        /// Get Business Object permission for current user
        /// </summary>
        /// <remarks>
        /// Operation to get Business Object permissions for the currently logged-in user&#39;s Security Group.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busObId">Specify the Business Object ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>List&lt;TrebuchetWebApiDataContractsSecurityBusinessObjectPermission&gt;</returns>
        List<TrebuchetWebApiDataContractsSecurityBusinessObjectPermission> SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV1 (string busObId, string lang = null, string locale = null);

        /// <summary>
        /// Get Business Object permission for current user
        /// </summary>
        /// <remarks>
        /// Operation to get Business Object permissions for the currently logged-in user&#39;s Security Group.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busObId">Specify the Business Object ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of List&lt;TrebuchetWebApiDataContractsSecurityBusinessObjectPermission&gt;</returns>
        ApiResponse<List<TrebuchetWebApiDataContractsSecurityBusinessObjectPermission>> SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV1WithHttpInfo (string busObId, string lang = null, string locale = null);
        /// <summary>
        /// Get Business Object permission for current user
        /// </summary>
        /// <remarks>
        /// Operation to get Business Object permissions for the currently logged-in user&#39;s Security Group.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busObId">Specify the Business Object ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsSecurityGetSecurityGroupBusinessObjectPermissionsResponse</returns>
        TrebuchetWebApiDataContractsSecurityGetSecurityGroupBusinessObjectPermissionsResponse SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV2 (string busObId, string lang = null, string locale = null);

        /// <summary>
        /// Get Business Object permission for current user
        /// </summary>
        /// <remarks>
        /// Operation to get Business Object permissions for the currently logged-in user&#39;s Security Group.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busObId">Specify the Business Object ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsSecurityGetSecurityGroupBusinessObjectPermissionsResponse</returns>
        ApiResponse<TrebuchetWebApiDataContractsSecurityGetSecurityGroupBusinessObjectPermissionsResponse> SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV2WithHttpInfo (string busObId, string lang = null, string locale = null);
        /// <summary>
        /// Get Business Object permissions for current user
        /// </summary>
        /// <remarks>
        /// Operation to get Business Object permissions for currently logged in user&#39;s Security Group.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>List&lt;TrebuchetWebApiDataContractsSecurityBusinessObjectPermission&gt;</returns>
        List<TrebuchetWebApiDataContractsSecurityBusinessObjectPermission> SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV1 (string busobname, string lang = null, string locale = null);

        /// <summary>
        /// Get Business Object permissions for current user
        /// </summary>
        /// <remarks>
        /// Operation to get Business Object permissions for currently logged in user&#39;s Security Group.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of List&lt;TrebuchetWebApiDataContractsSecurityBusinessObjectPermission&gt;</returns>
        ApiResponse<List<TrebuchetWebApiDataContractsSecurityBusinessObjectPermission>> SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV1WithHttpInfo (string busobname, string lang = null, string locale = null);
        /// <summary>
        /// Get Business Object permissions for current user
        /// </summary>
        /// <remarks>
        /// Operation to get Business Object permissions for currently logged in user&#39;s Security Group.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsSecurityGetSecurityGroupBusinessObjectPermissionsResponse</returns>
        TrebuchetWebApiDataContractsSecurityGetSecurityGroupBusinessObjectPermissionsResponse SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV2 (string busobname, string lang = null, string locale = null);

        /// <summary>
        /// Get Business Object permissions for current user
        /// </summary>
        /// <remarks>
        /// Operation to get Business Object permissions for currently logged in user&#39;s Security Group.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsSecurityGetSecurityGroupBusinessObjectPermissionsResponse</returns>
        ApiResponse<TrebuchetWebApiDataContractsSecurityGetSecurityGroupBusinessObjectPermissionsResponse> SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV2WithHttpInfo (string busobname, string lang = null, string locale = null);
        /// <summary>
        /// Get all Security Group categories
        /// </summary>
        /// <remarks>
        /// Operation to get IDs and names for all available Security Group categories. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>List&lt;TrebuchetWebApiDataContractsSecurityRightCategory&gt;</returns>
        List<TrebuchetWebApiDataContractsSecurityRightCategory> SecurityGetSecurityGroupCategoriesV1 (string lang = null, string locale = null);

        /// <summary>
        /// Get all Security Group categories
        /// </summary>
        /// <remarks>
        /// Operation to get IDs and names for all available Security Group categories. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of List&lt;TrebuchetWebApiDataContractsSecurityRightCategory&gt;</returns>
        ApiResponse<List<TrebuchetWebApiDataContractsSecurityRightCategory>> SecurityGetSecurityGroupCategoriesV1WithHttpInfo (string lang = null, string locale = null);
        /// <summary>
        /// Get all Security Group categories
        /// </summary>
        /// <remarks>
        /// Operation to get IDs and names for all available Security Group categories. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsSecuritySecurityRightCategoriesResponse</returns>
        TrebuchetWebApiDataContractsSecuritySecurityRightCategoriesResponse SecurityGetSecurityGroupCategoriesV2 (string lang = null, string locale = null);

        /// <summary>
        /// Get all Security Group categories
        /// </summary>
        /// <remarks>
        /// Operation to get IDs and names for all available Security Group categories. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsSecuritySecurityRightCategoriesResponse</returns>
        ApiResponse<TrebuchetWebApiDataContractsSecuritySecurityRightCategoriesResponse> SecurityGetSecurityGroupCategoriesV2WithHttpInfo (string lang = null, string locale = null);
        /// <summary>
        /// Get permissions for a Security Group by category
        /// </summary>
        /// <remarks>
        /// Operation to get permissions for a Security Group by category. To get Security Group IDs, use \&quot;Get all available Security Groups.\&quot; To get Security Group category IDs, use \&quot;Get all Security Group categories.\&quot;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupid">Specify the Security Group ID</param>
        /// <param name="categoryid">Specify the Security Group category ID</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>List&lt;TrebuchetWebApiDataContractsSecurityRight&gt;</returns>
        List<TrebuchetWebApiDataContractsSecurityRight> SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV1 (string groupid, string categoryid, string lang = null, string locale = null);

        /// <summary>
        /// Get permissions for a Security Group by category
        /// </summary>
        /// <remarks>
        /// Operation to get permissions for a Security Group by category. To get Security Group IDs, use \&quot;Get all available Security Groups.\&quot; To get Security Group category IDs, use \&quot;Get all Security Group categories.\&quot;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupid">Specify the Security Group ID</param>
        /// <param name="categoryid">Specify the Security Group category ID</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of List&lt;TrebuchetWebApiDataContractsSecurityRight&gt;</returns>
        ApiResponse<List<TrebuchetWebApiDataContractsSecurityRight>> SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV1WithHttpInfo (string groupid, string categoryid, string lang = null, string locale = null);
        /// <summary>
        /// Get permissions for a Security Group by category
        /// </summary>
        /// <remarks>
        /// Operation to get permissions for a Security Group by category. To get Security Group IDs, use \&quot;Get all available Security Groups.\&quot; To get Security Group category IDs, use \&quot;Get all Security Group categories.\&quot;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupid">Specify the Security Group ID</param>
        /// <param name="categoryid">Specify the Security Group category ID</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsSecuritySecurityRightsResponse</returns>
        TrebuchetWebApiDataContractsSecuritySecurityRightsResponse SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV2 (string groupid, string categoryid, string lang = null, string locale = null);

        /// <summary>
        /// Get permissions for a Security Group by category
        /// </summary>
        /// <remarks>
        /// Operation to get permissions for a Security Group by category. To get Security Group IDs, use \&quot;Get all available Security Groups.\&quot; To get Security Group category IDs, use \&quot;Get all Security Group categories.\&quot;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupid">Specify the Security Group ID</param>
        /// <param name="categoryid">Specify the Security Group category ID</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsSecuritySecurityRightsResponse</returns>
        ApiResponse<TrebuchetWebApiDataContractsSecuritySecurityRightsResponse> SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV2WithHttpInfo (string groupid, string categoryid, string lang = null, string locale = null);
        /// <summary>
        /// Get permissions for a Security Group by category
        /// </summary>
        /// <remarks>
        /// Operation to get permissions for a Security Group by category.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupname">Specify the Security Group name.</param>
        /// <param name="categoryname">Specify the Security Group category name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>List&lt;TrebuchetWebApiDataContractsSecurityRight&gt;</returns>
        List<TrebuchetWebApiDataContractsSecurityRight> SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV1 (string groupname, string categoryname, string lang = null, string locale = null);

        /// <summary>
        /// Get permissions for a Security Group by category
        /// </summary>
        /// <remarks>
        /// Operation to get permissions for a Security Group by category.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupname">Specify the Security Group name.</param>
        /// <param name="categoryname">Specify the Security Group category name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of List&lt;TrebuchetWebApiDataContractsSecurityRight&gt;</returns>
        ApiResponse<List<TrebuchetWebApiDataContractsSecurityRight>> SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV1WithHttpInfo (string groupname, string categoryname, string lang = null, string locale = null);
        /// <summary>
        /// Get permissions for a Security Group by category
        /// </summary>
        /// <remarks>
        /// Operation to get permissions for a Security Group by category.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupname">Specify the Security Group name.</param>
        /// <param name="categoryname">Specify the Security Group category name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsSecuritySecurityRightsResponse</returns>
        TrebuchetWebApiDataContractsSecuritySecurityRightsResponse SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV2 (string groupname, string categoryname, string lang = null, string locale = null);

        /// <summary>
        /// Get permissions for a Security Group by category
        /// </summary>
        /// <remarks>
        /// Operation to get permissions for a Security Group by category.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupname">Specify the Security Group name.</param>
        /// <param name="categoryname">Specify the Security Group category name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsSecuritySecurityRightsResponse</returns>
        ApiResponse<TrebuchetWebApiDataContractsSecuritySecurityRightsResponse> SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV2WithHttpInfo (string groupname, string categoryname, string lang = null, string locale = null);
        /// <summary>
        /// Get current user&#39;s permissions by Security Group category by ID
        /// </summary>
        /// <remarks>
        /// Operation to get permissions for the current user&#39;s Security Group by category. To get Security Group category IDs, use \&quot;Get all Security Group categories.\&quot;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryid">Specify the Security Group category ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>List&lt;TrebuchetWebApiDataContractsSecurityRight&gt;</returns>
        List<TrebuchetWebApiDataContractsSecurityRight> SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV1 (string categoryid, string lang = null, string locale = null);

        /// <summary>
        /// Get current user&#39;s permissions by Security Group category by ID
        /// </summary>
        /// <remarks>
        /// Operation to get permissions for the current user&#39;s Security Group by category. To get Security Group category IDs, use \&quot;Get all Security Group categories.\&quot;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryid">Specify the Security Group category ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of List&lt;TrebuchetWebApiDataContractsSecurityRight&gt;</returns>
        ApiResponse<List<TrebuchetWebApiDataContractsSecurityRight>> SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV1WithHttpInfo (string categoryid, string lang = null, string locale = null);
        /// <summary>
        /// Get current user&#39;s permissions by Security Group category by ID
        /// </summary>
        /// <remarks>
        /// Operation to get permissions for the current user&#39;s Security Group by category. To get Security Group category IDs, use \&quot;Get all Security Group categories.\&quot;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryid">Specify the Security Group category ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsSecuritySecurityRightsResponse</returns>
        TrebuchetWebApiDataContractsSecuritySecurityRightsResponse SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV2 (string categoryid, string lang = null, string locale = null);

        /// <summary>
        /// Get current user&#39;s permissions by Security Group category by ID
        /// </summary>
        /// <remarks>
        /// Operation to get permissions for the current user&#39;s Security Group by category. To get Security Group category IDs, use \&quot;Get all Security Group categories.\&quot;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryid">Specify the Security Group category ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsSecuritySecurityRightsResponse</returns>
        ApiResponse<TrebuchetWebApiDataContractsSecuritySecurityRightsResponse> SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV2WithHttpInfo (string categoryid, string lang = null, string locale = null);
        /// <summary>
        /// Get current user&#39;s permissions by Security Group category by name
        /// </summary>
        /// <remarks>
        /// Operation to get permissions for the current user&#39;s Security Group by category.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryname">Specify the Security Group category name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>List&lt;TrebuchetWebApiDataContractsSecurityRight&gt;</returns>
        List<TrebuchetWebApiDataContractsSecurityRight> SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV1 (string categoryname, string lang = null, string locale = null);

        /// <summary>
        /// Get current user&#39;s permissions by Security Group category by name
        /// </summary>
        /// <remarks>
        /// Operation to get permissions for the current user&#39;s Security Group by category.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryname">Specify the Security Group category name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of List&lt;TrebuchetWebApiDataContractsSecurityRight&gt;</returns>
        ApiResponse<List<TrebuchetWebApiDataContractsSecurityRight>> SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV1WithHttpInfo (string categoryname, string lang = null, string locale = null);
        /// <summary>
        /// Get current user&#39;s permissions by Security Group category by name
        /// </summary>
        /// <remarks>
        /// Operation to get permissions for the current user&#39;s Security Group by category.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryname">Specify the Security Group category name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsSecuritySecurityRightsResponse</returns>
        TrebuchetWebApiDataContractsSecuritySecurityRightsResponse SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV2 (string categoryname, string lang = null, string locale = null);

        /// <summary>
        /// Get current user&#39;s permissions by Security Group category by name
        /// </summary>
        /// <remarks>
        /// Operation to get permissions for the current user&#39;s Security Group by category.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryname">Specify the Security Group category name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsSecuritySecurityRightsResponse</returns>
        ApiResponse<TrebuchetWebApiDataContractsSecuritySecurityRightsResponse> SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV2WithHttpInfo (string categoryname, string lang = null, string locale = null);
        /// <summary>
        /// Get all available Security Groups
        /// </summary>
        /// <remarks>
        /// Operation to get IDs, names, and descriptions for all available Security Groups.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsSecuritySecurityGroupResponse</returns>
        TrebuchetWebApiDataContractsSecuritySecurityGroupResponse SecurityGetSecurityGroupsV1 (string lang = null, string locale = null);

        /// <summary>
        /// Get all available Security Groups
        /// </summary>
        /// <remarks>
        /// Operation to get IDs, names, and descriptions for all available Security Groups.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsSecuritySecurityGroupResponse</returns>
        ApiResponse<TrebuchetWebApiDataContractsSecuritySecurityGroupResponse> SecurityGetSecurityGroupsV1WithHttpInfo (string lang = null, string locale = null);
        /// <summary>
        /// Get all available Security Groups
        /// </summary>
        /// <remarks>
        /// Operation to get IDs, names, and descriptions for all available Security Groups.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsSecuritySecurityGroupV2Response</returns>
        TrebuchetWebApiDataContractsSecuritySecurityGroupV2Response SecurityGetSecurityGroupsV2 (string lang = null, string locale = null);

        /// <summary>
        /// Get all available Security Groups
        /// </summary>
        /// <remarks>
        /// Operation to get IDs, names, and descriptions for all available Security Groups.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsSecuritySecurityGroupV2Response</returns>
        ApiResponse<TrebuchetWebApiDataContractsSecuritySecurityGroupV2Response> SecurityGetSecurityGroupsV2WithHttpInfo (string lang = null, string locale = null);
        /// <summary>
        /// Get users in a Security Group
        /// </summary>
        /// <remarks>
        /// Operation to get the users in a specified Security Group. Use \&quot;Get all available Security Groups\&quot; to get Security Group record IDs. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupid">Specify the Security Group ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>List&lt;TrebuchetWebApiDataContractsUsersUser&gt;</returns>
        List<TrebuchetWebApiDataContractsUsersUser> SecurityGetUsersInSecurityGroupV1 (string groupid, string lang = null, string locale = null);

        /// <summary>
        /// Get users in a Security Group
        /// </summary>
        /// <remarks>
        /// Operation to get the users in a specified Security Group. Use \&quot;Get all available Security Groups\&quot; to get Security Group record IDs. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupid">Specify the Security Group ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of List&lt;TrebuchetWebApiDataContractsUsersUser&gt;</returns>
        ApiResponse<List<TrebuchetWebApiDataContractsUsersUser>> SecurityGetUsersInSecurityGroupV1WithHttpInfo (string groupid, string lang = null, string locale = null);
        /// <summary>
        /// Get users in a Security Group
        /// </summary>
        /// <remarks>
        /// Operation to get the users in a specified Security Group. Use \&quot;Get all available Security Groups\&quot; to get Security Group record IDs. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupid">Specify the Security Group ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsUsersUserReadV2Response</returns>
        UserReadV2Response SecurityGetUsersInSecurityGroupV2 (string groupid, string lang = null, string locale = null);

        /// <summary>
        /// Get users in a Security Group
        /// </summary>
        /// <remarks>
        /// Operation to get the users in a specified Security Group. Use \&quot;Get all available Security Groups\&quot; to get Security Group record IDs. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupid">Specify the Security Group ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsUsersUserReadV2Response</returns>
        ApiResponse<UserReadV2Response> SecurityGetUsersInSecurityGroupV2WithHttpInfo (string groupid, string lang = null, string locale = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get client security settings
        /// </summary>
        /// <remarks>
        /// Operation to get the configured client security settings. Returns true if internal, Windows, LDAP, or SAML are enabled as authentication methods.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationtype">The type of CSM application to return security settings for.  Application type is Desktop Client, Browser Client, Browser Portal or Cherwell Mobile.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsSecurityClientSecuritySettingsResponse</returns>
        System.Threading.Tasks.Task<TrebuchetWebApiDataContractsSecurityClientSecuritySettingsResponse> SecurityGetClientSecuritySettingsV1Async (string applicationtype, string lang = null, string locale = null);

        /// <summary>
        /// Get client security settings
        /// </summary>
        /// <remarks>
        /// Operation to get the configured client security settings. Returns true if internal, Windows, LDAP, or SAML are enabled as authentication methods.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationtype">The type of CSM application to return security settings for.  Application type is Desktop Client, Browser Client, Browser Portal or Cherwell Mobile.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsSecurityClientSecuritySettingsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrebuchetWebApiDataContractsSecurityClientSecuritySettingsResponse>> SecurityGetClientSecuritySettingsV1AsyncWithHttpInfo (string applicationtype, string lang = null, string locale = null);
        /// <summary>
        /// Get all available Roles
        /// </summary>
        /// <remarks>
        /// Operation to get all available Roles.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsSecurityRoleReadResponse</returns>
        System.Threading.Tasks.Task<TrebuchetWebApiDataContractsSecurityRoleReadResponse> SecurityGetRolesV1Async (string lang = null, string locale = null);

        /// <summary>
        /// Get all available Roles
        /// </summary>
        /// <remarks>
        /// Operation to get all available Roles.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsSecurityRoleReadResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrebuchetWebApiDataContractsSecurityRoleReadResponse>> SecurityGetRolesV1AsyncWithHttpInfo (string lang = null, string locale = null);
        /// <summary>
        /// Get all available Roles
        /// </summary>
        /// <remarks>
        /// Operation to get all available Roles.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsSecurityRoleReadV2Response</returns>
        System.Threading.Tasks.Task<TrebuchetWebApiDataContractsSecurityRoleReadV2Response> SecurityGetRolesV2Async (string lang = null, string locale = null);

        /// <summary>
        /// Get all available Roles
        /// </summary>
        /// <remarks>
        /// Operation to get all available Roles.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsSecurityRoleReadV2Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrebuchetWebApiDataContractsSecurityRoleReadV2Response>> SecurityGetRolesV2AsyncWithHttpInfo (string lang = null, string locale = null);
        /// <summary>
        /// Get Business Object permissions by Security Group
        /// </summary>
        /// <remarks>
        /// Operation to get specific Business Object permissions for a Security Group. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupid">Specify the Security Group ID. </param>
        /// <param name="busObId">Specify the Business Object ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of List&lt;TrebuchetWebApiDataContractsSecurityBusinessObjectPermission&gt;</returns>
        System.Threading.Tasks.Task<List<TrebuchetWebApiDataContractsSecurityBusinessObjectPermission>> SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV1Async (string groupid, string busObId, string lang = null, string locale = null);

        /// <summary>
        /// Get Business Object permissions by Security Group
        /// </summary>
        /// <remarks>
        /// Operation to get specific Business Object permissions for a Security Group. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupid">Specify the Security Group ID. </param>
        /// <param name="busObId">Specify the Business Object ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;TrebuchetWebApiDataContractsSecurityBusinessObjectPermission&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<TrebuchetWebApiDataContractsSecurityBusinessObjectPermission>>> SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV1AsyncWithHttpInfo (string groupid, string busObId, string lang = null, string locale = null);
        /// <summary>
        /// Get Business Object permissions by Security Group
        /// </summary>
        /// <remarks>
        /// Operation to get specific Business Object permissions for a Security Group. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupid">Specify the Security Group ID. </param>
        /// <param name="busObId">Specify the Business Object ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsSecurityGetSecurityGroupBusinessObjectPermissionsResponse</returns>
        System.Threading.Tasks.Task<TrebuchetWebApiDataContractsSecurityGetSecurityGroupBusinessObjectPermissionsResponse> SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV2Async (string groupid, string busObId, string lang = null, string locale = null);

        /// <summary>
        /// Get Business Object permissions by Security Group
        /// </summary>
        /// <remarks>
        /// Operation to get specific Business Object permissions for a Security Group. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupid">Specify the Security Group ID. </param>
        /// <param name="busObId">Specify the Business Object ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsSecurityGetSecurityGroupBusinessObjectPermissionsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrebuchetWebApiDataContractsSecurityGetSecurityGroupBusinessObjectPermissionsResponse>> SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV2AsyncWithHttpInfo (string groupid, string busObId, string lang = null, string locale = null);
        /// <summary>
        /// Get Business Object permissions by Security Group
        /// </summary>
        /// <remarks>
        /// Operation to get specific Business Object permissions for a Security Group. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupname">Specify the Security Group name. </param>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of List&lt;TrebuchetWebApiDataContractsSecurityBusinessObjectPermission&gt;</returns>
        System.Threading.Tasks.Task<List<TrebuchetWebApiDataContractsSecurityBusinessObjectPermission>> SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV1Async (string groupname, string busobname, string lang = null, string locale = null);

        /// <summary>
        /// Get Business Object permissions by Security Group
        /// </summary>
        /// <remarks>
        /// Operation to get specific Business Object permissions for a Security Group. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupname">Specify the Security Group name. </param>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;TrebuchetWebApiDataContractsSecurityBusinessObjectPermission&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<TrebuchetWebApiDataContractsSecurityBusinessObjectPermission>>> SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV1AsyncWithHttpInfo (string groupname, string busobname, string lang = null, string locale = null);
        /// <summary>
        /// Get Business Object permissions by Security Group
        /// </summary>
        /// <remarks>
        /// Operation to get specific Business Object permissions for a Security Group. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupname">Specify the Security Group name. </param>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsSecurityGetSecurityGroupBusinessObjectPermissionsResponse</returns>
        System.Threading.Tasks.Task<TrebuchetWebApiDataContractsSecurityGetSecurityGroupBusinessObjectPermissionsResponse> SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV2Async (string groupname, string busobname, string lang = null, string locale = null);

        /// <summary>
        /// Get Business Object permissions by Security Group
        /// </summary>
        /// <remarks>
        /// Operation to get specific Business Object permissions for a Security Group. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupname">Specify the Security Group name. </param>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsSecurityGetSecurityGroupBusinessObjectPermissionsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrebuchetWebApiDataContractsSecurityGetSecurityGroupBusinessObjectPermissionsResponse>> SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV2AsyncWithHttpInfo (string groupname, string busobname, string lang = null, string locale = null);
        /// <summary>
        /// Get Business Object permission for current user
        /// </summary>
        /// <remarks>
        /// Operation to get Business Object permissions for the currently logged-in user&#39;s Security Group.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busObId">Specify the Business Object ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of List&lt;TrebuchetWebApiDataContractsSecurityBusinessObjectPermission&gt;</returns>
        System.Threading.Tasks.Task<List<TrebuchetWebApiDataContractsSecurityBusinessObjectPermission>> SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV1Async (string busObId, string lang = null, string locale = null);

        /// <summary>
        /// Get Business Object permission for current user
        /// </summary>
        /// <remarks>
        /// Operation to get Business Object permissions for the currently logged-in user&#39;s Security Group.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busObId">Specify the Business Object ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;TrebuchetWebApiDataContractsSecurityBusinessObjectPermission&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<TrebuchetWebApiDataContractsSecurityBusinessObjectPermission>>> SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV1AsyncWithHttpInfo (string busObId, string lang = null, string locale = null);
        /// <summary>
        /// Get Business Object permission for current user
        /// </summary>
        /// <remarks>
        /// Operation to get Business Object permissions for the currently logged-in user&#39;s Security Group.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busObId">Specify the Business Object ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsSecurityGetSecurityGroupBusinessObjectPermissionsResponse</returns>
        System.Threading.Tasks.Task<TrebuchetWebApiDataContractsSecurityGetSecurityGroupBusinessObjectPermissionsResponse> SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV2Async (string busObId, string lang = null, string locale = null);

        /// <summary>
        /// Get Business Object permission for current user
        /// </summary>
        /// <remarks>
        /// Operation to get Business Object permissions for the currently logged-in user&#39;s Security Group.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busObId">Specify the Business Object ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsSecurityGetSecurityGroupBusinessObjectPermissionsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrebuchetWebApiDataContractsSecurityGetSecurityGroupBusinessObjectPermissionsResponse>> SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV2AsyncWithHttpInfo (string busObId, string lang = null, string locale = null);
        /// <summary>
        /// Get Business Object permissions for current user
        /// </summary>
        /// <remarks>
        /// Operation to get Business Object permissions for currently logged in user&#39;s Security Group.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of List&lt;TrebuchetWebApiDataContractsSecurityBusinessObjectPermission&gt;</returns>
        System.Threading.Tasks.Task<List<TrebuchetWebApiDataContractsSecurityBusinessObjectPermission>> SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV1Async (string busobname, string lang = null, string locale = null);

        /// <summary>
        /// Get Business Object permissions for current user
        /// </summary>
        /// <remarks>
        /// Operation to get Business Object permissions for currently logged in user&#39;s Security Group.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;TrebuchetWebApiDataContractsSecurityBusinessObjectPermission&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<TrebuchetWebApiDataContractsSecurityBusinessObjectPermission>>> SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV1AsyncWithHttpInfo (string busobname, string lang = null, string locale = null);
        /// <summary>
        /// Get Business Object permissions for current user
        /// </summary>
        /// <remarks>
        /// Operation to get Business Object permissions for currently logged in user&#39;s Security Group.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsSecurityGetSecurityGroupBusinessObjectPermissionsResponse</returns>
        System.Threading.Tasks.Task<TrebuchetWebApiDataContractsSecurityGetSecurityGroupBusinessObjectPermissionsResponse> SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV2Async (string busobname, string lang = null, string locale = null);

        /// <summary>
        /// Get Business Object permissions for current user
        /// </summary>
        /// <remarks>
        /// Operation to get Business Object permissions for currently logged in user&#39;s Security Group.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsSecurityGetSecurityGroupBusinessObjectPermissionsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrebuchetWebApiDataContractsSecurityGetSecurityGroupBusinessObjectPermissionsResponse>> SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV2AsyncWithHttpInfo (string busobname, string lang = null, string locale = null);
        /// <summary>
        /// Get all Security Group categories
        /// </summary>
        /// <remarks>
        /// Operation to get IDs and names for all available Security Group categories. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of List&lt;TrebuchetWebApiDataContractsSecurityRightCategory&gt;</returns>
        System.Threading.Tasks.Task<List<TrebuchetWebApiDataContractsSecurityRightCategory>> SecurityGetSecurityGroupCategoriesV1Async (string lang = null, string locale = null);

        /// <summary>
        /// Get all Security Group categories
        /// </summary>
        /// <remarks>
        /// Operation to get IDs and names for all available Security Group categories. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;TrebuchetWebApiDataContractsSecurityRightCategory&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<TrebuchetWebApiDataContractsSecurityRightCategory>>> SecurityGetSecurityGroupCategoriesV1AsyncWithHttpInfo (string lang = null, string locale = null);
        /// <summary>
        /// Get all Security Group categories
        /// </summary>
        /// <remarks>
        /// Operation to get IDs and names for all available Security Group categories. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsSecuritySecurityRightCategoriesResponse</returns>
        System.Threading.Tasks.Task<TrebuchetWebApiDataContractsSecuritySecurityRightCategoriesResponse> SecurityGetSecurityGroupCategoriesV2Async (string lang = null, string locale = null);

        /// <summary>
        /// Get all Security Group categories
        /// </summary>
        /// <remarks>
        /// Operation to get IDs and names for all available Security Group categories. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsSecuritySecurityRightCategoriesResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrebuchetWebApiDataContractsSecuritySecurityRightCategoriesResponse>> SecurityGetSecurityGroupCategoriesV2AsyncWithHttpInfo (string lang = null, string locale = null);
        /// <summary>
        /// Get permissions for a Security Group by category
        /// </summary>
        /// <remarks>
        /// Operation to get permissions for a Security Group by category. To get Security Group IDs, use \&quot;Get all available Security Groups.\&quot; To get Security Group category IDs, use \&quot;Get all Security Group categories.\&quot;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupid">Specify the Security Group ID</param>
        /// <param name="categoryid">Specify the Security Group category ID</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of List&lt;TrebuchetWebApiDataContractsSecurityRight&gt;</returns>
        System.Threading.Tasks.Task<List<TrebuchetWebApiDataContractsSecurityRight>> SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV1Async (string groupid, string categoryid, string lang = null, string locale = null);

        /// <summary>
        /// Get permissions for a Security Group by category
        /// </summary>
        /// <remarks>
        /// Operation to get permissions for a Security Group by category. To get Security Group IDs, use \&quot;Get all available Security Groups.\&quot; To get Security Group category IDs, use \&quot;Get all Security Group categories.\&quot;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupid">Specify the Security Group ID</param>
        /// <param name="categoryid">Specify the Security Group category ID</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;TrebuchetWebApiDataContractsSecurityRight&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<TrebuchetWebApiDataContractsSecurityRight>>> SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV1AsyncWithHttpInfo (string groupid, string categoryid, string lang = null, string locale = null);
        /// <summary>
        /// Get permissions for a Security Group by category
        /// </summary>
        /// <remarks>
        /// Operation to get permissions for a Security Group by category. To get Security Group IDs, use \&quot;Get all available Security Groups.\&quot; To get Security Group category IDs, use \&quot;Get all Security Group categories.\&quot;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupid">Specify the Security Group ID</param>
        /// <param name="categoryid">Specify the Security Group category ID</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsSecuritySecurityRightsResponse</returns>
        System.Threading.Tasks.Task<TrebuchetWebApiDataContractsSecuritySecurityRightsResponse> SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV2Async (string groupid, string categoryid, string lang = null, string locale = null);

        /// <summary>
        /// Get permissions for a Security Group by category
        /// </summary>
        /// <remarks>
        /// Operation to get permissions for a Security Group by category. To get Security Group IDs, use \&quot;Get all available Security Groups.\&quot; To get Security Group category IDs, use \&quot;Get all Security Group categories.\&quot;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupid">Specify the Security Group ID</param>
        /// <param name="categoryid">Specify the Security Group category ID</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsSecuritySecurityRightsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrebuchetWebApiDataContractsSecuritySecurityRightsResponse>> SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV2AsyncWithHttpInfo (string groupid, string categoryid, string lang = null, string locale = null);
        /// <summary>
        /// Get permissions for a Security Group by category
        /// </summary>
        /// <remarks>
        /// Operation to get permissions for a Security Group by category.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupname">Specify the Security Group name.</param>
        /// <param name="categoryname">Specify the Security Group category name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of List&lt;TrebuchetWebApiDataContractsSecurityRight&gt;</returns>
        System.Threading.Tasks.Task<List<TrebuchetWebApiDataContractsSecurityRight>> SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV1Async (string groupname, string categoryname, string lang = null, string locale = null);

        /// <summary>
        /// Get permissions for a Security Group by category
        /// </summary>
        /// <remarks>
        /// Operation to get permissions for a Security Group by category.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupname">Specify the Security Group name.</param>
        /// <param name="categoryname">Specify the Security Group category name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;TrebuchetWebApiDataContractsSecurityRight&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<TrebuchetWebApiDataContractsSecurityRight>>> SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV1AsyncWithHttpInfo (string groupname, string categoryname, string lang = null, string locale = null);
        /// <summary>
        /// Get permissions for a Security Group by category
        /// </summary>
        /// <remarks>
        /// Operation to get permissions for a Security Group by category.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupname">Specify the Security Group name.</param>
        /// <param name="categoryname">Specify the Security Group category name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsSecuritySecurityRightsResponse</returns>
        System.Threading.Tasks.Task<TrebuchetWebApiDataContractsSecuritySecurityRightsResponse> SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV2Async (string groupname, string categoryname, string lang = null, string locale = null);

        /// <summary>
        /// Get permissions for a Security Group by category
        /// </summary>
        /// <remarks>
        /// Operation to get permissions for a Security Group by category.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupname">Specify the Security Group name.</param>
        /// <param name="categoryname">Specify the Security Group category name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsSecuritySecurityRightsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrebuchetWebApiDataContractsSecuritySecurityRightsResponse>> SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV2AsyncWithHttpInfo (string groupname, string categoryname, string lang = null, string locale = null);
        /// <summary>
        /// Get current user&#39;s permissions by Security Group category by ID
        /// </summary>
        /// <remarks>
        /// Operation to get permissions for the current user&#39;s Security Group by category. To get Security Group category IDs, use \&quot;Get all Security Group categories.\&quot;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryid">Specify the Security Group category ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of List&lt;TrebuchetWebApiDataContractsSecurityRight&gt;</returns>
        System.Threading.Tasks.Task<List<TrebuchetWebApiDataContractsSecurityRight>> SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV1Async (string categoryid, string lang = null, string locale = null);

        /// <summary>
        /// Get current user&#39;s permissions by Security Group category by ID
        /// </summary>
        /// <remarks>
        /// Operation to get permissions for the current user&#39;s Security Group by category. To get Security Group category IDs, use \&quot;Get all Security Group categories.\&quot;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryid">Specify the Security Group category ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;TrebuchetWebApiDataContractsSecurityRight&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<TrebuchetWebApiDataContractsSecurityRight>>> SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV1AsyncWithHttpInfo (string categoryid, string lang = null, string locale = null);
        /// <summary>
        /// Get current user&#39;s permissions by Security Group category by ID
        /// </summary>
        /// <remarks>
        /// Operation to get permissions for the current user&#39;s Security Group by category. To get Security Group category IDs, use \&quot;Get all Security Group categories.\&quot;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryid">Specify the Security Group category ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsSecuritySecurityRightsResponse</returns>
        System.Threading.Tasks.Task<TrebuchetWebApiDataContractsSecuritySecurityRightsResponse> SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV2Async (string categoryid, string lang = null, string locale = null);

        /// <summary>
        /// Get current user&#39;s permissions by Security Group category by ID
        /// </summary>
        /// <remarks>
        /// Operation to get permissions for the current user&#39;s Security Group by category. To get Security Group category IDs, use \&quot;Get all Security Group categories.\&quot;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryid">Specify the Security Group category ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsSecuritySecurityRightsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrebuchetWebApiDataContractsSecuritySecurityRightsResponse>> SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV2AsyncWithHttpInfo (string categoryid, string lang = null, string locale = null);
        /// <summary>
        /// Get current user&#39;s permissions by Security Group category by name
        /// </summary>
        /// <remarks>
        /// Operation to get permissions for the current user&#39;s Security Group by category.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryname">Specify the Security Group category name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of List&lt;TrebuchetWebApiDataContractsSecurityRight&gt;</returns>
        System.Threading.Tasks.Task<List<TrebuchetWebApiDataContractsSecurityRight>> SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV1Async (string categoryname, string lang = null, string locale = null);

        /// <summary>
        /// Get current user&#39;s permissions by Security Group category by name
        /// </summary>
        /// <remarks>
        /// Operation to get permissions for the current user&#39;s Security Group by category.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryname">Specify the Security Group category name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;TrebuchetWebApiDataContractsSecurityRight&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<TrebuchetWebApiDataContractsSecurityRight>>> SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV1AsyncWithHttpInfo (string categoryname, string lang = null, string locale = null);
        /// <summary>
        /// Get current user&#39;s permissions by Security Group category by name
        /// </summary>
        /// <remarks>
        /// Operation to get permissions for the current user&#39;s Security Group by category.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryname">Specify the Security Group category name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsSecuritySecurityRightsResponse</returns>
        System.Threading.Tasks.Task<TrebuchetWebApiDataContractsSecuritySecurityRightsResponse> SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV2Async (string categoryname, string lang = null, string locale = null);

        /// <summary>
        /// Get current user&#39;s permissions by Security Group category by name
        /// </summary>
        /// <remarks>
        /// Operation to get permissions for the current user&#39;s Security Group by category.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryname">Specify the Security Group category name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsSecuritySecurityRightsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrebuchetWebApiDataContractsSecuritySecurityRightsResponse>> SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV2AsyncWithHttpInfo (string categoryname, string lang = null, string locale = null);
        /// <summary>
        /// Get all available Security Groups
        /// </summary>
        /// <remarks>
        /// Operation to get IDs, names, and descriptions for all available Security Groups.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsSecuritySecurityGroupResponse</returns>
        System.Threading.Tasks.Task<TrebuchetWebApiDataContractsSecuritySecurityGroupResponse> SecurityGetSecurityGroupsV1Async (string lang = null, string locale = null);

        /// <summary>
        /// Get all available Security Groups
        /// </summary>
        /// <remarks>
        /// Operation to get IDs, names, and descriptions for all available Security Groups.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsSecuritySecurityGroupResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrebuchetWebApiDataContractsSecuritySecurityGroupResponse>> SecurityGetSecurityGroupsV1AsyncWithHttpInfo (string lang = null, string locale = null);
        /// <summary>
        /// Get all available Security Groups
        /// </summary>
        /// <remarks>
        /// Operation to get IDs, names, and descriptions for all available Security Groups.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsSecuritySecurityGroupV2Response</returns>
        System.Threading.Tasks.Task<TrebuchetWebApiDataContractsSecuritySecurityGroupV2Response> SecurityGetSecurityGroupsV2Async (string lang = null, string locale = null);

        /// <summary>
        /// Get all available Security Groups
        /// </summary>
        /// <remarks>
        /// Operation to get IDs, names, and descriptions for all available Security Groups.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsSecuritySecurityGroupV2Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrebuchetWebApiDataContractsSecuritySecurityGroupV2Response>> SecurityGetSecurityGroupsV2AsyncWithHttpInfo (string lang = null, string locale = null);
        /// <summary>
        /// Get users in a Security Group
        /// </summary>
        /// <remarks>
        /// Operation to get the users in a specified Security Group. Use \&quot;Get all available Security Groups\&quot; to get Security Group record IDs. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupid">Specify the Security Group ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of List&lt;TrebuchetWebApiDataContractsUsersUser&gt;</returns>
        System.Threading.Tasks.Task<List<TrebuchetWebApiDataContractsUsersUser>> SecurityGetUsersInSecurityGroupV1Async (string groupid, string lang = null, string locale = null);

        /// <summary>
        /// Get users in a Security Group
        /// </summary>
        /// <remarks>
        /// Operation to get the users in a specified Security Group. Use \&quot;Get all available Security Groups\&quot; to get Security Group record IDs. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupid">Specify the Security Group ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;TrebuchetWebApiDataContractsUsersUser&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<TrebuchetWebApiDataContractsUsersUser>>> SecurityGetUsersInSecurityGroupV1AsyncWithHttpInfo (string groupid, string lang = null, string locale = null);
        /// <summary>
        /// Get users in a Security Group
        /// </summary>
        /// <remarks>
        /// Operation to get the users in a specified Security Group. Use \&quot;Get all available Security Groups\&quot; to get Security Group record IDs. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupid">Specify the Security Group ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsUsersUserReadV2Response</returns>
        System.Threading.Tasks.Task<UserReadV2Response> SecurityGetUsersInSecurityGroupV2Async (string groupid, string lang = null, string locale = null);

        /// <summary>
        /// Get users in a Security Group
        /// </summary>
        /// <remarks>
        /// Operation to get the users in a specified Security Group. Use \&quot;Get all available Security Groups\&quot; to get Security Group record IDs. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupid">Specify the Security Group ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsUsersUserReadV2Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserReadV2Response>> SecurityGetUsersInSecurityGroupV2AsyncWithHttpInfo (string groupid, string lang = null, string locale = null);
        #endregion Asynchronous Operations
    }
}