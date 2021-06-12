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
        ClientSecuritySettingsResponse SecurityGetClientSecuritySettingsV1 (string applicationtype, string lang = null, string locale = null);

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
        ApiResponse<ClientSecuritySettingsResponse> SecurityGetClientSecuritySettingsV1WithHttpInfo (string applicationtype, string lang = null, string locale = null);
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
        SecurityRoleReadResponse SecurityGetRolesV1 (string lang = null, string locale = null);

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
        ApiResponse<SecurityRoleReadResponse> SecurityGetRolesV1WithHttpInfo (string lang = null, string locale = null);
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
        RoleReadV2Response SecurityGetRolesV2 (string lang = null, string locale = null);

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
        ApiResponse<RoleReadV2Response> SecurityGetRolesV2WithHttpInfo (string lang = null, string locale = null);
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
        List<BusinessObjectPermission> SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV1 (string groupid, string busObId, string lang = null, string locale = null);

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
        ApiResponse<List<BusinessObjectPermission>> SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV1WithHttpInfo (string groupid, string busObId, string lang = null, string locale = null);
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
        SecurityGroupBusinessObjectPermissionsResponse SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV2 (string groupid, string busObId, string lang = null, string locale = null);

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
        ApiResponse<SecurityGroupBusinessObjectPermissionsResponse> SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV2WithHttpInfo (string groupid, string busObId, string lang = null, string locale = null);
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
        List<BusinessObjectPermission> SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV1 (string groupname, string busobname, string lang = null, string locale = null);

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
        ApiResponse<List<BusinessObjectPermission>> SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV1WithHttpInfo (string groupname, string busobname, string lang = null, string locale = null);
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
        SecurityGroupBusinessObjectPermissionsResponse SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV2 (string groupname, string busobname, string lang = null, string locale = null);

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
        ApiResponse<SecurityGroupBusinessObjectPermissionsResponse> SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV2WithHttpInfo (string groupname, string busobname, string lang = null, string locale = null);
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
        List<BusinessObjectPermission> SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV1 (string busObId, string lang = null, string locale = null);

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
        ApiResponse<List<BusinessObjectPermission>> SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV1WithHttpInfo (string busObId, string lang = null, string locale = null);
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
        SecurityGroupBusinessObjectPermissionsResponse SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV2 (string busObId, string lang = null, string locale = null);

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
        ApiResponse<SecurityGroupBusinessObjectPermissionsResponse> SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV2WithHttpInfo (string busObId, string lang = null, string locale = null);
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
        List<BusinessObjectPermission> SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV1 (string busobname, string lang = null, string locale = null);

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
        ApiResponse<List<BusinessObjectPermission>> SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV1WithHttpInfo (string busobname, string lang = null, string locale = null);
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
        SecurityGroupBusinessObjectPermissionsResponse SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV2 (string busobname, string lang = null, string locale = null);

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
        ApiResponse<SecurityGroupBusinessObjectPermissionsResponse> SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV2WithHttpInfo (string busobname, string lang = null, string locale = null);
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
        List<RightCategory> SecurityGetSecurityGroupCategoriesV1 (string lang = null, string locale = null);

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
        ApiResponse<List<RightCategory>> SecurityGetSecurityGroupCategoriesV1WithHttpInfo (string lang = null, string locale = null);
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
        SecurityRightCategoriesResponse SecurityGetSecurityGroupCategoriesV2 (string lang = null, string locale = null);

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
        ApiResponse<SecurityRightCategoriesResponse> SecurityGetSecurityGroupCategoriesV2WithHttpInfo (string lang = null, string locale = null);
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
        List<SecurityRight> SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV1 (string groupid, string categoryid, string lang = null, string locale = null);

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
        ApiResponse<List<SecurityRight>> SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV1WithHttpInfo (string groupid, string categoryid, string lang = null, string locale = null);
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
        SecurityRightsResponse SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV2 (string groupid, string categoryid, string lang = null, string locale = null);

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
        ApiResponse<SecurityRightsResponse> SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV2WithHttpInfo (string groupid, string categoryid, string lang = null, string locale = null);
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
        List<SecurityRight> SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV1 (string groupname, string categoryname, string lang = null, string locale = null);

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
        ApiResponse<List<SecurityRight>> SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV1WithHttpInfo (string groupname, string categoryname, string lang = null, string locale = null);
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
        SecurityRightsResponse SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV2 (string groupname, string categoryname, string lang = null, string locale = null);

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
        ApiResponse<SecurityRightsResponse> SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV2WithHttpInfo (string groupname, string categoryname, string lang = null, string locale = null);
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
        List<SecurityRight> SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV1 (string categoryid, string lang = null, string locale = null);

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
        ApiResponse<List<SecurityRight>> SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV1WithHttpInfo (string categoryid, string lang = null, string locale = null);
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
        SecurityRightsResponse SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV2 (string categoryid, string lang = null, string locale = null);

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
        ApiResponse<SecurityRightsResponse> SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV2WithHttpInfo (string categoryid, string lang = null, string locale = null);
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
        List<SecurityRight> SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV1 (string categoryname, string lang = null, string locale = null);

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
        ApiResponse<List<SecurityRight>> SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV1WithHttpInfo (string categoryname, string lang = null, string locale = null);
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
        SecurityRightsResponse SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV2 (string categoryname, string lang = null, string locale = null);

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
        ApiResponse<SecurityRightsResponse> SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV2WithHttpInfo (string categoryname, string lang = null, string locale = null);
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
        SecurityGroupResponse SecurityGetSecurityGroupsV1 (string lang = null, string locale = null);

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
        ApiResponse<SecurityGroupResponse> SecurityGetSecurityGroupsV1WithHttpInfo (string lang = null, string locale = null);
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
        SecurityGroupV2Response SecurityGetSecurityGroupsV2 (string lang = null, string locale = null);

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
        ApiResponse<SecurityGroupV2Response> SecurityGetSecurityGroupsV2WithHttpInfo (string lang = null, string locale = null);
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
        List<User> SecurityGetUsersInSecurityGroupV1 (string groupid, string lang = null, string locale = null);

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
        ApiResponse<List<User>> SecurityGetUsersInSecurityGroupV1WithHttpInfo (string groupid, string lang = null, string locale = null);
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
        System.Threading.Tasks.Task<ClientSecuritySettingsResponse> SecurityGetClientSecuritySettingsV1Async (string applicationtype, string lang = null, string locale = null);

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
        System.Threading.Tasks.Task<ApiResponse<ClientSecuritySettingsResponse>> SecurityGetClientSecuritySettingsV1AsyncWithHttpInfo (string applicationtype, string lang = null, string locale = null);
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
        System.Threading.Tasks.Task<SecurityRoleReadResponse> SecurityGetRolesV1Async (string lang = null, string locale = null);

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
        System.Threading.Tasks.Task<ApiResponse<SecurityRoleReadResponse>> SecurityGetRolesV1AsyncWithHttpInfo (string lang = null, string locale = null);
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
        System.Threading.Tasks.Task<RoleReadV2Response> SecurityGetRolesV2Async (string lang = null, string locale = null);

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
        System.Threading.Tasks.Task<ApiResponse<RoleReadV2Response>> SecurityGetRolesV2AsyncWithHttpInfo (string lang = null, string locale = null);
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
        System.Threading.Tasks.Task<List<BusinessObjectPermission>> SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV1Async (string groupid, string busObId, string lang = null, string locale = null);

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
        System.Threading.Tasks.Task<ApiResponse<List<BusinessObjectPermission>>> SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV1AsyncWithHttpInfo (string groupid, string busObId, string lang = null, string locale = null);
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
        System.Threading.Tasks.Task<SecurityGroupBusinessObjectPermissionsResponse> SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV2Async (string groupid, string busObId, string lang = null, string locale = null);

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
        System.Threading.Tasks.Task<ApiResponse<SecurityGroupBusinessObjectPermissionsResponse>> SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV2AsyncWithHttpInfo (string groupid, string busObId, string lang = null, string locale = null);
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
        System.Threading.Tasks.Task<List<BusinessObjectPermission>> SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV1Async (string groupname, string busobname, string lang = null, string locale = null);

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
        System.Threading.Tasks.Task<ApiResponse<List<BusinessObjectPermission>>> SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV1AsyncWithHttpInfo (string groupname, string busobname, string lang = null, string locale = null);
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
        System.Threading.Tasks.Task<SecurityGroupBusinessObjectPermissionsResponse> SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV2Async (string groupname, string busobname, string lang = null, string locale = null);

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
        System.Threading.Tasks.Task<ApiResponse<SecurityGroupBusinessObjectPermissionsResponse>> SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV2AsyncWithHttpInfo (string groupname, string busobname, string lang = null, string locale = null);
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
        System.Threading.Tasks.Task<List<BusinessObjectPermission>> SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV1Async (string busObId, string lang = null, string locale = null);

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
        System.Threading.Tasks.Task<ApiResponse<List<BusinessObjectPermission>>> SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV1AsyncWithHttpInfo (string busObId, string lang = null, string locale = null);
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
        System.Threading.Tasks.Task<SecurityGroupBusinessObjectPermissionsResponse> SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV2Async (string busObId, string lang = null, string locale = null);

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
        System.Threading.Tasks.Task<ApiResponse<SecurityGroupBusinessObjectPermissionsResponse>> SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV2AsyncWithHttpInfo (string busObId, string lang = null, string locale = null);
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
        System.Threading.Tasks.Task<List<BusinessObjectPermission>> SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV1Async (string busobname, string lang = null, string locale = null);

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
        System.Threading.Tasks.Task<ApiResponse<List<BusinessObjectPermission>>> SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV1AsyncWithHttpInfo (string busobname, string lang = null, string locale = null);
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
        System.Threading.Tasks.Task<SecurityGroupBusinessObjectPermissionsResponse> SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV2Async (string busobname, string lang = null, string locale = null);

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
        System.Threading.Tasks.Task<ApiResponse<SecurityGroupBusinessObjectPermissionsResponse>> SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV2AsyncWithHttpInfo (string busobname, string lang = null, string locale = null);
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
        System.Threading.Tasks.Task<List<RightCategory>> SecurityGetSecurityGroupCategoriesV1Async (string lang = null, string locale = null);

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
        System.Threading.Tasks.Task<ApiResponse<List<RightCategory>>> SecurityGetSecurityGroupCategoriesV1AsyncWithHttpInfo (string lang = null, string locale = null);
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
        System.Threading.Tasks.Task<SecurityRightCategoriesResponse> SecurityGetSecurityGroupCategoriesV2Async (string lang = null, string locale = null);

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
        System.Threading.Tasks.Task<ApiResponse<SecurityRightCategoriesResponse>> SecurityGetSecurityGroupCategoriesV2AsyncWithHttpInfo (string lang = null, string locale = null);
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
        System.Threading.Tasks.Task<List<SecurityRight>> SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV1Async (string groupid, string categoryid, string lang = null, string locale = null);

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
        System.Threading.Tasks.Task<ApiResponse<List<SecurityRight>>> SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV1AsyncWithHttpInfo (string groupid, string categoryid, string lang = null, string locale = null);
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
        System.Threading.Tasks.Task<SecurityRightsResponse> SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV2Async (string groupid, string categoryid, string lang = null, string locale = null);

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
        System.Threading.Tasks.Task<ApiResponse<SecurityRightsResponse>> SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV2AsyncWithHttpInfo (string groupid, string categoryid, string lang = null, string locale = null);
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
        System.Threading.Tasks.Task<List<SecurityRight>> SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV1Async (string groupname, string categoryname, string lang = null, string locale = null);

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
        System.Threading.Tasks.Task<ApiResponse<List<SecurityRight>>> SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV1AsyncWithHttpInfo (string groupname, string categoryname, string lang = null, string locale = null);
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
        System.Threading.Tasks.Task<SecurityRightsResponse> SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV2Async (string groupname, string categoryname, string lang = null, string locale = null);

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
        System.Threading.Tasks.Task<ApiResponse<SecurityRightsResponse>> SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV2AsyncWithHttpInfo (string groupname, string categoryname, string lang = null, string locale = null);
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
        System.Threading.Tasks.Task<List<SecurityRight>> SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV1Async (string categoryid, string lang = null, string locale = null);

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
        System.Threading.Tasks.Task<ApiResponse<List<SecurityRight>>> SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV1AsyncWithHttpInfo (string categoryid, string lang = null, string locale = null);
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
        System.Threading.Tasks.Task<SecurityRightsResponse> SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV2Async (string categoryid, string lang = null, string locale = null);

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
        System.Threading.Tasks.Task<ApiResponse<SecurityRightsResponse>> SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV2AsyncWithHttpInfo (string categoryid, string lang = null, string locale = null);
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
        System.Threading.Tasks.Task<List<SecurityRight>> SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV1Async (string categoryname, string lang = null, string locale = null);

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
        System.Threading.Tasks.Task<ApiResponse<List<SecurityRight>>> SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV1AsyncWithHttpInfo (string categoryname, string lang = null, string locale = null);
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
        System.Threading.Tasks.Task<SecurityRightsResponse> SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV2Async (string categoryname, string lang = null, string locale = null);

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
        System.Threading.Tasks.Task<ApiResponse<SecurityRightsResponse>> SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV2AsyncWithHttpInfo (string categoryname, string lang = null, string locale = null);
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
        System.Threading.Tasks.Task<SecurityGroupResponse> SecurityGetSecurityGroupsV1Async (string lang = null, string locale = null);

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
        System.Threading.Tasks.Task<ApiResponse<SecurityGroupResponse>> SecurityGetSecurityGroupsV1AsyncWithHttpInfo (string lang = null, string locale = null);
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
        System.Threading.Tasks.Task<SecurityGroupV2Response> SecurityGetSecurityGroupsV2Async (string lang = null, string locale = null);

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
        System.Threading.Tasks.Task<ApiResponse<SecurityGroupV2Response>> SecurityGetSecurityGroupsV2AsyncWithHttpInfo (string lang = null, string locale = null);
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
        System.Threading.Tasks.Task<List<User>> SecurityGetUsersInSecurityGroupV1Async (string groupid, string lang = null, string locale = null);

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
        System.Threading.Tasks.Task<ApiResponse<List<User>>> SecurityGetUsersInSecurityGroupV1AsyncWithHttpInfo (string groupid, string lang = null, string locale = null);
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