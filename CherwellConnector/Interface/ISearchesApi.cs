using System.Collections.Generic;
using CherwellConnector.Client;
using CherwellConnector.Model;

namespace CherwellConnector.Interface
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISearchesApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get a Quick Search from a list of Business Object IDs
        /// </summary>
        /// <remarks>
        /// Operation to build a Quick Search configuration that you can use to execute a Quick Search for multiple Business Objects. The configuration  includes supplied Business Object IDs and specific search items with the following options. Use the Option Key to determine if you can change the options. &lt;/br&gt;&lt;/br&gt;&lt;/br&gt;ChangedOption&lt;/br&gt;&lt;/br&gt;NonFinalStateOption&lt;/br&gt;&lt;/br&gt;SearchAnyWordsOption&lt;/br&gt;&lt;/br&gt;SearchAttachmentsOption&lt;/br&gt;&lt;/br&gt;SearchRelatedOption&lt;/br&gt;&lt;/br&gt;SortByOption&lt;/br&gt;&lt;/br&gt;&lt;/br&gt;Option Key:&lt;/br&gt;&lt;/br&gt;0 &#x3D; None (Not selected and cannot select.)&lt;/br&gt;&lt;/br&gt;1 &#x3D; Use (Selected and cannot clear.)&lt;/br&gt;&lt;/br&gt;2 &#x3D; Display (Not selected and can select.)&lt;/br&gt;&lt;/br&gt;3 &#x3D; UseAndDisplay (Selected and can clear.)&lt;/br&gt;&lt;/br&gt;&lt;/br&gt;SearchTargetType:&lt;/br&gt;&lt;/br&gt;0 &#x3D; BusOb (Business Object)&lt;/br&gt;&lt;/br&gt;1 &#x3D; DocRepository (Document Repository)
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataRequest">Request containing the Business Object IDs list.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsSearchesQuickSearchConfigurationResponse</returns>
        TrebuchetWebApiDataContractsSearchesQuickSearchConfigurationResponse SearchesGetQuickSearchConfigurationForBusObsV1 (TrebuchetWebApiDataContractsSearchesQuickSearchConfigurationRequest dataRequest, string lang = null, string locale = null);

        /// <summary>
        /// Get a Quick Search from a list of Business Object IDs
        /// </summary>
        /// <remarks>
        /// Operation to build a Quick Search configuration that you can use to execute a Quick Search for multiple Business Objects. The configuration  includes supplied Business Object IDs and specific search items with the following options. Use the Option Key to determine if you can change the options. &lt;/br&gt;&lt;/br&gt;&lt;/br&gt;ChangedOption&lt;/br&gt;&lt;/br&gt;NonFinalStateOption&lt;/br&gt;&lt;/br&gt;SearchAnyWordsOption&lt;/br&gt;&lt;/br&gt;SearchAttachmentsOption&lt;/br&gt;&lt;/br&gt;SearchRelatedOption&lt;/br&gt;&lt;/br&gt;SortByOption&lt;/br&gt;&lt;/br&gt;&lt;/br&gt;Option Key:&lt;/br&gt;&lt;/br&gt;0 &#x3D; None (Not selected and cannot select.)&lt;/br&gt;&lt;/br&gt;1 &#x3D; Use (Selected and cannot clear.)&lt;/br&gt;&lt;/br&gt;2 &#x3D; Display (Not selected and can select.)&lt;/br&gt;&lt;/br&gt;3 &#x3D; UseAndDisplay (Selected and can clear.)&lt;/br&gt;&lt;/br&gt;&lt;/br&gt;SearchTargetType:&lt;/br&gt;&lt;/br&gt;0 &#x3D; BusOb (Business Object)&lt;/br&gt;&lt;/br&gt;1 &#x3D; DocRepository (Document Repository)
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataRequest">Request containing the Business Object IDs list.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsSearchesQuickSearchConfigurationResponse</returns>
        ApiResponse<TrebuchetWebApiDataContractsSearchesQuickSearchConfigurationResponse> SearchesGetQuickSearchConfigurationForBusObsV1WithHttpInfo (TrebuchetWebApiDataContractsSearchesQuickSearchConfigurationRequest dataRequest, string lang = null, string locale = null);
        /// <summary>
        /// Get a Quick Search by Business Objects with view rights
        /// </summary>
        /// <remarks>
        /// Operation to get a Quick Search configuration that you can use to execute a Quick Search based the current user&#39;s Business Object view rights. The configuration  includes supplied Business Object IDs and specific search items with the following options. Use the Option Key to determine if you can change the options.&lt;/br&gt;&lt;/br&gt;ChangedOption&lt;/br&gt;&lt;/br&gt;NonFinalStateOption&lt;/br&gt;&lt;/br&gt;SearchAnyWordsOption&lt;/br&gt;&lt;/br&gt;SearchAttachmentsOption&lt;/br&gt;&lt;/br&gt;SearchRelatedOption&lt;/br&gt;&lt;/br&gt;SortByOption&lt;/br&gt;&lt;/br&gt;&lt;/br&gt;Option Key:&lt;/br&gt;&lt;/br&gt;0 &#x3D; None (Not selected and cannot select.)&lt;/br&gt;&lt;/br&gt;1 &#x3D; Use (Selected and cannot clear.)&lt;/br&gt;&lt;/br&gt;2 &#x3D; Display (Not selected and can select.)&lt;/br&gt;&lt;/br&gt;3 &#x3D; UseAndDisplay (Selected and can clear.)&lt;/br&gt;&lt;/br&gt;&lt;/br&gt;SearchTargetType:&lt;/br&gt;&lt;/br&gt;0 &#x3D; BusOb (Business Object)&lt;/br&gt;&lt;/br&gt;1 &#x3D; DocRepository (Document Repository)
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsSearchesQuickSearchConfigurationResponse</returns>
        TrebuchetWebApiDataContractsSearchesQuickSearchConfigurationResponse SearchesGetQuickSearchConfigurationForBusObsWithViewRightsV1 (string lang = null, string locale = null);

        /// <summary>
        /// Get a Quick Search by Business Objects with view rights
        /// </summary>
        /// <remarks>
        /// Operation to get a Quick Search configuration that you can use to execute a Quick Search based the current user&#39;s Business Object view rights. The configuration  includes supplied Business Object IDs and specific search items with the following options. Use the Option Key to determine if you can change the options.&lt;/br&gt;&lt;/br&gt;ChangedOption&lt;/br&gt;&lt;/br&gt;NonFinalStateOption&lt;/br&gt;&lt;/br&gt;SearchAnyWordsOption&lt;/br&gt;&lt;/br&gt;SearchAttachmentsOption&lt;/br&gt;&lt;/br&gt;SearchRelatedOption&lt;/br&gt;&lt;/br&gt;SortByOption&lt;/br&gt;&lt;/br&gt;&lt;/br&gt;Option Key:&lt;/br&gt;&lt;/br&gt;0 &#x3D; None (Not selected and cannot select.)&lt;/br&gt;&lt;/br&gt;1 &#x3D; Use (Selected and cannot clear.)&lt;/br&gt;&lt;/br&gt;2 &#x3D; Display (Not selected and can select.)&lt;/br&gt;&lt;/br&gt;3 &#x3D; UseAndDisplay (Selected and can clear.)&lt;/br&gt;&lt;/br&gt;&lt;/br&gt;SearchTargetType:&lt;/br&gt;&lt;/br&gt;0 &#x3D; BusOb (Business Object)&lt;/br&gt;&lt;/br&gt;1 &#x3D; DocRepository (Document Repository)
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsSearchesQuickSearchConfigurationResponse</returns>
        ApiResponse<TrebuchetWebApiDataContractsSearchesQuickSearchConfigurationResponse> SearchesGetQuickSearchConfigurationForBusObsWithViewRightsV1WithHttpInfo (string lang = null, string locale = null);
        /// <summary>
        /// Execute a Quick Search from a list of Business Object IDs and search text
        /// </summary>
        /// <remarks>
        /// Operation to execute a Quick Search using a list of Business Object IDs and search text.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataRequest">Request object listing Business Object IDs and search text. Leave out the entire Business Object IDs parameter and all configured quick search Business Objects will be searched.</param>
        /// <param name="includeLinks">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsSearchesSimpleResultsList</returns>
        TrebuchetWebApiDataContractsSearchesSimpleResultsList SearchesGetQuickSearchResultsV1 (TrebuchetWebApiDataContractsSearchesQuickSearchRequest dataRequest, bool? includeLinks = null, string lang = null, string locale = null);

        /// <summary>
        /// Execute a Quick Search from a list of Business Object IDs and search text
        /// </summary>
        /// <remarks>
        /// Operation to execute a Quick Search using a list of Business Object IDs and search text.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataRequest">Request object listing Business Object IDs and search text. Leave out the entire Business Object IDs parameter and all configured quick search Business Objects will be searched.</param>
        /// <param name="includeLinks">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsSearchesSimpleResultsList</returns>
        ApiResponse<TrebuchetWebApiDataContractsSearchesSimpleResultsList> SearchesGetQuickSearchResultsV1WithHttpInfo (TrebuchetWebApiDataContractsSearchesQuickSearchRequest dataRequest, bool? includeLinks = null, string lang = null, string locale = null);
        /// <summary>
        /// Execute a Quick Search on a specific Business Object
        /// </summary>
        /// <remarks>
        /// Operation to execute a Quick Search for a specific Business Object ID. Use \&quot;Get a Quick Search from a list of Business Object IDs\&quot; to find values for specific search item options, such as NonFinalStateOption.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataRequest">Request object containing the parameters for specific Business Object Quick Search execution.</param>
        /// <param name="includeSchema">Flag to include the schema for the results. (optional)</param>
        /// <param name="includeLocationFields">Flag to include location fields in the results. (optional)</param>
        /// <param name="includeLinks">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsSearchesSearchResultsTableResponse</returns>
        TrebuchetWebApiDataContractsSearchesSearchResultsTableResponse SearchesGetQuickSearchSpecificResultsV1 (TrebuchetWebApiDataContractsSearchesQuickSearchSpecificRequest dataRequest, bool? includeSchema = null, bool? includeLocationFields = null, bool? includeLinks = null, string lang = null, string locale = null);

        /// <summary>
        /// Execute a Quick Search on a specific Business Object
        /// </summary>
        /// <remarks>
        /// Operation to execute a Quick Search for a specific Business Object ID. Use \&quot;Get a Quick Search from a list of Business Object IDs\&quot; to find values for specific search item options, such as NonFinalStateOption.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataRequest">Request object containing the parameters for specific Business Object Quick Search execution.</param>
        /// <param name="includeSchema">Flag to include the schema for the results. (optional)</param>
        /// <param name="includeLocationFields">Flag to include location fields in the results. (optional)</param>
        /// <param name="includeLinks">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsSearchesSearchResultsTableResponse</returns>
        ApiResponse<TrebuchetWebApiDataContractsSearchesSearchResultsTableResponse> SearchesGetQuickSearchSpecificResultsV1WithHttpInfo (TrebuchetWebApiDataContractsSearchesQuickSearchSpecificRequest dataRequest, bool? includeSchema = null, bool? includeLocationFields = null, bool? includeLinks = null, string lang = null, string locale = null);
        /// <summary>
        /// Execute a Quick Search on a specific Business Object
        /// </summary>
        /// <remarks>
        /// Operation to execute a Quick Search for a specific Business Object ID. Use \&quot;Get a Quick Search from a list of Business Object IDs\&quot; to find values for specific search item options, such as NonFinalStateOption.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataRequest">Request object containing the parameters for specific Business Object Quick Search execution.</param>
        /// <param name="includeSchema">Flag to include the schema for the results. (optional)</param>
        /// <param name="includeLocationFields">Flag to include location fields in the results. (optional)</param>
        /// <param name="includeLinks">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsSearchesQuickSearchResponse</returns>
        TrebuchetWebApiDataContractsSearchesQuickSearchResponse SearchesGetQuickSearchSpecificResultsV2 (TrebuchetWebApiDataContractsSearchesQuickSearchSpecificRequest dataRequest, bool? includeSchema = null, bool? includeLocationFields = null, bool? includeLinks = null, string lang = null, string locale = null);

        /// <summary>
        /// Execute a Quick Search on a specific Business Object
        /// </summary>
        /// <remarks>
        /// Operation to execute a Quick Search for a specific Business Object ID. Use \&quot;Get a Quick Search from a list of Business Object IDs\&quot; to find values for specific search item options, such as NonFinalStateOption.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataRequest">Request object containing the parameters for specific Business Object Quick Search execution.</param>
        /// <param name="includeSchema">Flag to include the schema for the results. (optional)</param>
        /// <param name="includeLocationFields">Flag to include location fields in the results. (optional)</param>
        /// <param name="includeLinks">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsSearchesQuickSearchResponse</returns>
        ApiResponse<TrebuchetWebApiDataContractsSearchesQuickSearchResponse> SearchesGetQuickSearchSpecificResultsV2WithHttpInfo (TrebuchetWebApiDataContractsSearchesQuickSearchSpecificRequest dataRequest, bool? includeSchema = null, bool? includeLocationFields = null, bool? includeLinks = null, string lang = null, string locale = null);
        /// <summary>
        /// Get all saved searches by Folder ID
        /// </summary>
        /// <remarks>
        /// Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Use to filter results by Business Object association ID.</param>
        /// <param name="scope">Use to filter results by scope name or ID.</param>
        /// <param name="scopeowner">Use to filter results by scope owner ID.</param>
        /// <param name="folder">Use to filter results by Search Group folder ID.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsSearchesSearchItemResponse</returns>
        TrebuchetWebApiDataContractsSearchesSearchItemResponse SearchesGetSearchItemsByAssociationScopeScopeOwnerFolderV1 (string association, string scope, string scopeowner, string folder, bool? links = null, string lang = null, string locale = null);

        /// <summary>
        /// Get all saved searches by Folder ID
        /// </summary>
        /// <remarks>
        /// Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Use to filter results by Business Object association ID.</param>
        /// <param name="scope">Use to filter results by scope name or ID.</param>
        /// <param name="scopeowner">Use to filter results by scope owner ID.</param>
        /// <param name="folder">Use to filter results by Search Group folder ID.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsSearchesSearchItemResponse</returns>
        ApiResponse<TrebuchetWebApiDataContractsSearchesSearchItemResponse> SearchesGetSearchItemsByAssociationScopeScopeOwnerFolderV1WithHttpInfo (string association, string scope, string scopeowner, string folder, bool? links = null, string lang = null, string locale = null);
        /// <summary>
        /// Get all saved searches by Folder ID
        /// </summary>
        /// <remarks>
        /// Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Use to filter results by Business Object association ID.</param>
        /// <param name="scope">Use to filter results by scope name or ID.</param>
        /// <param name="scopeowner">Use to filter results by scope owner ID.</param>
        /// <param name="folder">Use to filter results by Search Group folder ID.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsCoreManagerData</returns>
        TrebuchetWebApiDataContractsCoreManagerData SearchesGetSearchItemsByAssociationScopeScopeOwnerFolderV2 (string association, string scope, string scopeowner, string folder, bool? links = null, string lang = null, string locale = null);

        /// <summary>
        /// Get all saved searches by Folder ID
        /// </summary>
        /// <remarks>
        /// Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Use to filter results by Business Object association ID.</param>
        /// <param name="scope">Use to filter results by scope name or ID.</param>
        /// <param name="scopeowner">Use to filter results by scope owner ID.</param>
        /// <param name="folder">Use to filter results by Search Group folder ID.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsCoreManagerData</returns>
        ApiResponse<TrebuchetWebApiDataContractsCoreManagerData> SearchesGetSearchItemsByAssociationScopeScopeOwnerFolderV2WithHttpInfo (string association, string scope, string scopeowner, string folder, bool? links = null, string lang = null, string locale = null);
        /// <summary>
        /// Get all saved searches by scope owner (sub scope)
        /// </summary>
        /// <remarks>
        /// Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Use to filter results by Business Object association ID.</param>
        /// <param name="scope">Use to filter results by scope name or ID.</param>
        /// <param name="scopeowner">Use to filter results by scope owner ID.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsSearchesSearchItemResponse</returns>
        TrebuchetWebApiDataContractsSearchesSearchItemResponse SearchesGetSearchItemsByAssociationScopeScopeOwnerV1 (string association, string scope, string scopeowner, bool? links = null, string lang = null, string locale = null);

        /// <summary>
        /// Get all saved searches by scope owner (sub scope)
        /// </summary>
        /// <remarks>
        /// Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Use to filter results by Business Object association ID.</param>
        /// <param name="scope">Use to filter results by scope name or ID.</param>
        /// <param name="scopeowner">Use to filter results by scope owner ID.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsSearchesSearchItemResponse</returns>
        ApiResponse<TrebuchetWebApiDataContractsSearchesSearchItemResponse> SearchesGetSearchItemsByAssociationScopeScopeOwnerV1WithHttpInfo (string association, string scope, string scopeowner, bool? links = null, string lang = null, string locale = null);
        /// <summary>
        /// Get all saved searches by scope owner (sub scope)
        /// </summary>
        /// <remarks>
        /// Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Use to filter results by Business Object association ID.</param>
        /// <param name="scope">Use to filter results by scope name or ID.</param>
        /// <param name="scopeowner">Use to filter results by scope owner ID.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsCoreManagerData</returns>
        TrebuchetWebApiDataContractsCoreManagerData SearchesGetSearchItemsByAssociationScopeScopeOwnerV2 (string association, string scope, string scopeowner, bool? links = null, string lang = null, string locale = null);

        /// <summary>
        /// Get all saved searches by scope owner (sub scope)
        /// </summary>
        /// <remarks>
        /// Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Use to filter results by Business Object association ID.</param>
        /// <param name="scope">Use to filter results by scope name or ID.</param>
        /// <param name="scopeowner">Use to filter results by scope owner ID.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsCoreManagerData</returns>
        ApiResponse<TrebuchetWebApiDataContractsCoreManagerData> SearchesGetSearchItemsByAssociationScopeScopeOwnerV2WithHttpInfo (string association, string scope, string scopeowner, bool? links = null, string lang = null, string locale = null);
        /// <summary>
        /// Get all saved searches by scope
        /// </summary>
        /// <remarks>
        /// Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Use to filter results by Business Object association ID.</param>
        /// <param name="scope">Use to filter results by scope name or ID.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsSearchesSearchItemResponse</returns>
        TrebuchetWebApiDataContractsSearchesSearchItemResponse SearchesGetSearchItemsByAssociationScopeV1 (string association, string scope, bool? links = null, string lang = null, string locale = null);

        /// <summary>
        /// Get all saved searches by scope
        /// </summary>
        /// <remarks>
        /// Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Use to filter results by Business Object association ID.</param>
        /// <param name="scope">Use to filter results by scope name or ID.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsSearchesSearchItemResponse</returns>
        ApiResponse<TrebuchetWebApiDataContractsSearchesSearchItemResponse> SearchesGetSearchItemsByAssociationScopeV1WithHttpInfo (string association, string scope, bool? links = null, string lang = null, string locale = null);
        /// <summary>
        /// Get all saved searches by scope
        /// </summary>
        /// <remarks>
        /// Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Use to filter results by Business Object association ID.</param>
        /// <param name="scope">Use to filter results by scope name or ID.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsCoreManagerData</returns>
        TrebuchetWebApiDataContractsCoreManagerData SearchesGetSearchItemsByAssociationScopeV2 (string association, string scope, bool? links = null, string lang = null, string locale = null);

        /// <summary>
        /// Get all saved searches by scope
        /// </summary>
        /// <remarks>
        /// Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Use to filter results by Business Object association ID.</param>
        /// <param name="scope">Use to filter results by scope name or ID.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsCoreManagerData</returns>
        ApiResponse<TrebuchetWebApiDataContractsCoreManagerData> SearchesGetSearchItemsByAssociationScopeV2WithHttpInfo (string association, string scope, bool? links = null, string lang = null, string locale = null);
        /// <summary>
        /// Get all saved searches by Business Object association
        /// </summary>
        /// <remarks>
        /// Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Use to filter results by Business Object association ID.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsSearchesSearchItemResponse</returns>
        TrebuchetWebApiDataContractsSearchesSearchItemResponse SearchesGetSearchItemsByAssociationV1 (string association, bool? links = null, string lang = null, string locale = null);

        /// <summary>
        /// Get all saved searches by Business Object association
        /// </summary>
        /// <remarks>
        /// Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Use to filter results by Business Object association ID.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsSearchesSearchItemResponse</returns>
        ApiResponse<TrebuchetWebApiDataContractsSearchesSearchItemResponse> SearchesGetSearchItemsByAssociationV1WithHttpInfo (string association, bool? links = null, string lang = null, string locale = null);
        /// <summary>
        /// Get all saved searches by Business Object association
        /// </summary>
        /// <remarks>
        /// Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Use to filter results by Business Object association ID.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsCoreManagerData</returns>
        TrebuchetWebApiDataContractsCoreManagerData SearchesGetSearchItemsByAssociationV2 (string association, bool? links = null, string lang = null, string locale = null);

        /// <summary>
        /// Get all saved searches by Business Object association
        /// </summary>
        /// <remarks>
        /// Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Use to filter results by Business Object association ID.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsCoreManagerData</returns>
        ApiResponse<TrebuchetWebApiDataContractsCoreManagerData> SearchesGetSearchItemsByAssociationV2WithHttpInfo (string association, bool? links = null, string lang = null, string locale = null);
        /// <summary>
        /// Get all saved searches by default Business Object association
        /// </summary>
        /// <remarks>
        /// Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsSearchesSearchItemResponse</returns>
        TrebuchetWebApiDataContractsSearchesSearchItemResponse SearchesGetSearchItemsV1 (bool? links = null, string lang = null, string locale = null);

        /// <summary>
        /// Get all saved searches by default Business Object association
        /// </summary>
        /// <remarks>
        /// Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsSearchesSearchItemResponse</returns>
        ApiResponse<TrebuchetWebApiDataContractsSearchesSearchItemResponse> SearchesGetSearchItemsV1WithHttpInfo (bool? links = null, string lang = null, string locale = null);
        /// <summary>
        /// Get all saved searches by default Business Object association
        /// </summary>
        /// <remarks>
        /// Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsCoreManagerData</returns>
        TrebuchetWebApiDataContractsCoreManagerData SearchesGetSearchItemsV2 (bool? links = null, string lang = null, string locale = null);

        /// <summary>
        /// Get all saved searches by default Business Object association
        /// </summary>
        /// <remarks>
        /// Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsCoreManagerData</returns>
        ApiResponse<TrebuchetWebApiDataContractsCoreManagerData> SearchesGetSearchItemsV2WithHttpInfo (bool? links = null, string lang = null, string locale = null);
        /// <summary>
        /// Run an ad-hoc search
        /// </summary>
        /// <remarks>
        /// Operation that runs an ad-hoc Business Object search. To execute a search with Prompts, the PromptId and Value are required in the Prompt request object.&lt;/br&gt;&lt;/br&gt;PromptType is a FieldSubType enum as described below:&lt;/br&gt;FieldSubType&lt;/br&gt;None &#x3D; 0&lt;/br&gt;Text &#x3D; 1&lt;/br&gt;Number &#x3D; 2&lt;/br&gt;DateTime &#x3D; 3&lt;/br&gt;Logical &#x3D; 4&lt;/br&gt;Binary &#x3D; 5&lt;/br&gt;DateOnly &#x3D; 6&lt;/br&gt;TimeOnly &#x3D; 7&lt;/br&gt;Json &#x3D; 8&lt;/br&gt;JsonArray &#x3D; 9&lt;/br&gt;Xml &#x3D; 10&lt;/br&gt;XmlCollection &#x3D; 11&lt;/br&gt;TimeValue &#x3D; 12&lt;/br&gt;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataRequest">Request object to specify search parameters.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsSearchesSearchResultsResponse</returns>
        TrebuchetWebApiDataContractsSearchesSearchResultsResponse SearchesGetSearchResultsAdHocV1 (TrebuchetWebApiDataContractsSearchesSearchResultsRequest dataRequest, string lang = null, string locale = null);

        /// <summary>
        /// Run an ad-hoc search
        /// </summary>
        /// <remarks>
        /// Operation that runs an ad-hoc Business Object search. To execute a search with Prompts, the PromptId and Value are required in the Prompt request object.&lt;/br&gt;&lt;/br&gt;PromptType is a FieldSubType enum as described below:&lt;/br&gt;FieldSubType&lt;/br&gt;None &#x3D; 0&lt;/br&gt;Text &#x3D; 1&lt;/br&gt;Number &#x3D; 2&lt;/br&gt;DateTime &#x3D; 3&lt;/br&gt;Logical &#x3D; 4&lt;/br&gt;Binary &#x3D; 5&lt;/br&gt;DateOnly &#x3D; 6&lt;/br&gt;TimeOnly &#x3D; 7&lt;/br&gt;Json &#x3D; 8&lt;/br&gt;JsonArray &#x3D; 9&lt;/br&gt;Xml &#x3D; 10&lt;/br&gt;XmlCollection &#x3D; 11&lt;/br&gt;TimeValue &#x3D; 12&lt;/br&gt;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataRequest">Request object to specify search parameters.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsSearchesSearchResultsResponse</returns>
        ApiResponse<TrebuchetWebApiDataContractsSearchesSearchResultsResponse> SearchesGetSearchResultsAdHocV1WithHttpInfo (TrebuchetWebApiDataContractsSearchesSearchResultsRequest dataRequest, string lang = null, string locale = null);
        /// <summary>
        /// Get results of a saved search
        /// </summary>
        /// <remarks>
        /// Operation that returns the results of a saved search in JSON format.&lt;/br&gt;&lt;/br&gt;This API is protected by a rate limiter and will reject any requests sent from an IP Address when a certain threshold of active concurrent requests has been hit.&lt;/br&gt;&lt;/br&gt;This value can be configured by the Max Concurrent Requests configuration value in the Web API config.&lt;/br&gt;&lt;/br&gt;Once this limit has been reached, all subsequent requests will receive a status code of 429 (Too Many Requests).&lt;/br&gt;&lt;/br&gt;This version is not subject to row limits and will return the entire result set of the stored search.&lt;/br&gt;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchRequest">Request object to specify search parameters.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsSearchesStoredSearchResults</returns>
        TrebuchetWebApiDataContractsSearchesStoredSearchResults SearchesGetSearchResultsAsStringByIdV2 (TrebuchetWebApiDataContractsSearchesStoredSearchRequest searchRequest, string lang = null, string locale = null);

        /// <summary>
        /// Get results of a saved search
        /// </summary>
        /// <remarks>
        /// Operation that returns the results of a saved search in JSON format.&lt;/br&gt;&lt;/br&gt;This API is protected by a rate limiter and will reject any requests sent from an IP Address when a certain threshold of active concurrent requests has been hit.&lt;/br&gt;&lt;/br&gt;This value can be configured by the Max Concurrent Requests configuration value in the Web API config.&lt;/br&gt;&lt;/br&gt;Once this limit has been reached, all subsequent requests will receive a status code of 429 (Too Many Requests).&lt;/br&gt;&lt;/br&gt;This version is not subject to row limits and will return the entire result set of the stored search.&lt;/br&gt;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchRequest">Request object to specify search parameters.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsSearchesStoredSearchResults</returns>
        ApiResponse<TrebuchetWebApiDataContractsSearchesStoredSearchResults> SearchesGetSearchResultsAsStringByIdV2WithHttpInfo (TrebuchetWebApiDataContractsSearchesStoredSearchRequest searchRequest, string lang = null, string locale = null);
        /// <summary>
        /// Get results of a saved search
        /// </summary>
        /// <remarks>
        /// Operation that returns the results of a saved search in JSON format.&lt;/br&gt; &lt;/br&gt;  This API is protected by a rate limiter and will reject any requests sent from an IP Address when a certain threshold of active concurrent requests has been hit.&lt;/br&gt; &lt;/br&gt;  This value can be configured by the Max Concurrent Requests configuration value in the Web API config.&lt;/br&gt; &lt;/br&gt;  Once this limit has been reached, all subsequent requests will receive a status code of 429 (Too Many Requests).&lt;/br&gt; 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Specify the scope name for the saved search.</param>
        /// <param name="associationName">Specify the Business Object association Name for the saved search.</param>
        /// <param name="searchName">Specify the name of the saved search.</param>
        /// <param name="scopeOwner">Specify the scope owner ID for the saved search. Use (None) when no scope owner exists. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>List&lt;Dictionary&lt;string, string&gt;&gt;</returns>
        List<Dictionary<string, string>> SearchesGetSearchResultsAsStringByNameV1 (string scope, string associationName, string searchName, string scopeOwner = null, string lang = null, string locale = null);

        /// <summary>
        /// Get results of a saved search
        /// </summary>
        /// <remarks>
        /// Operation that returns the results of a saved search in JSON format.&lt;/br&gt; &lt;/br&gt;  This API is protected by a rate limiter and will reject any requests sent from an IP Address when a certain threshold of active concurrent requests has been hit.&lt;/br&gt; &lt;/br&gt;  This value can be configured by the Max Concurrent Requests configuration value in the Web API config.&lt;/br&gt; &lt;/br&gt;  Once this limit has been reached, all subsequent requests will receive a status code of 429 (Too Many Requests).&lt;/br&gt; 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Specify the scope name for the saved search.</param>
        /// <param name="associationName">Specify the Business Object association Name for the saved search.</param>
        /// <param name="searchName">Specify the name of the saved search.</param>
        /// <param name="scopeOwner">Specify the scope owner ID for the saved search. Use (None) when no scope owner exists. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of List&lt;Dictionary&lt;string, string&gt;&gt;</returns>
        ApiResponse<List<Dictionary<string, string>>> SearchesGetSearchResultsAsStringByNameV1WithHttpInfo (string scope, string associationName, string searchName, string scopeOwner = null, string lang = null, string locale = null);
        /// <summary>
        /// Get results of a saved search
        /// </summary>
        /// <remarks>
        /// Operation that returns the results of a saved search in JSON format.&lt;/br&gt;&lt;/br&gt;This API is protected by a rate limiter and will reject any requests sent from an IP Address when a certain threshold of active concurrent requests has been hit.&lt;/br&gt;&lt;/br&gt;This value can be configured by the Max Concurrent Requests configuration value in the Web API config.&lt;/br&gt;&lt;/br&gt;Once this limit has been reached, all subsequent requests will receive a status code of 429 (Too Many Requests).&lt;/br&gt;&lt;/br&gt;This version is not subject to row limits and will return the entire result set of the stored search.&lt;/br&gt;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Specify the scope name for the saved search.</param>
        /// <param name="associationName">Specify the Business Object association Name for the saved search.</param>
        /// <param name="searchName">Specify the name of the saved search.</param>
        /// <param name="scopeOwner">Specify the scope owner ID for the saved search. Use (None) when no scope owner exists. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>List&lt;Dictionary&lt;string, string&gt;&gt;</returns>
        List<Dictionary<string, string>> SearchesGetSearchResultsAsStringByNameV2 (string scope, string associationName, string searchName, string scopeOwner = null, string lang = null, string locale = null);

        /// <summary>
        /// Get results of a saved search
        /// </summary>
        /// <remarks>
        /// Operation that returns the results of a saved search in JSON format.&lt;/br&gt;&lt;/br&gt;This API is protected by a rate limiter and will reject any requests sent from an IP Address when a certain threshold of active concurrent requests has been hit.&lt;/br&gt;&lt;/br&gt;This value can be configured by the Max Concurrent Requests configuration value in the Web API config.&lt;/br&gt;&lt;/br&gt;Once this limit has been reached, all subsequent requests will receive a status code of 429 (Too Many Requests).&lt;/br&gt;&lt;/br&gt;This version is not subject to row limits and will return the entire result set of the stored search.&lt;/br&gt;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Specify the scope name for the saved search.</param>
        /// <param name="associationName">Specify the Business Object association Name for the saved search.</param>
        /// <param name="searchName">Specify the name of the saved search.</param>
        /// <param name="scopeOwner">Specify the scope owner ID for the saved search. Use (None) when no scope owner exists. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of List&lt;Dictionary&lt;string, string&gt;&gt;</returns>
        ApiResponse<List<Dictionary<string, string>>> SearchesGetSearchResultsAsStringByNameV2WithHttpInfo (string scope, string associationName, string searchName, string scopeOwner = null, string lang = null, string locale = null);
        /// <summary>
        /// Run a saved search by internal ID
        /// </summary>
        /// <remarks>
        /// Operation that returns the paged results of a saved search. When the search contains Prompts, the response contains the Prompt. Send the Prompt and the original operation parameters to  SearchResultsRequest to the getsearchresults ad-hoc http post operation.&lt;/br&gt;&lt;/br&gt;PromptType is a FieldSubType enum as described below:&lt;/br&gt;FieldSubType&lt;/br&gt;None &#x3D; 0&lt;/br&gt;Text &#x3D; 1&lt;/br&gt;Number &#x3D; 2&lt;/br&gt;DateTime &#x3D; 3&lt;/br&gt;Logical &#x3D; 4&lt;/br&gt;Binary &#x3D; 5&lt;/br&gt;DateOnly &#x3D; 6&lt;/br&gt;TimeOnly &#x3D; 7&lt;/br&gt;Json &#x3D; 8&lt;/br&gt;JsonArray &#x3D; 9&lt;/br&gt;Xml &#x3D; 10&lt;/br&gt;XmlCollection &#x3D; 11&lt;/br&gt;TimeValue &#x3D; 12&lt;/br&gt;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Specify the Business Object association ID for the saved search.</param>
        /// <param name="scope">Specify the scope name or ID for the saved search.</param>
        /// <param name="scopeowner">Specify the scope owner ID for the saved search. Use (None) when no scope owner exists.</param>
        /// <param name="searchid">Specify the internal ID for the saved search. Use \&quot;Run a saved search by name\&quot; if you do not have the internal ID.</param>
        /// <param name="searchTerm">Specify search text filter the results. Example: Use \&quot;Service Request\&quot; to filter Incident results to include only service requests. (optional)</param>
        /// <param name="pagenumber">Specify the page number of the result set to return. (optional)</param>
        /// <param name="pagesize">Specify the number of rows to return per page. (optional)</param>
        /// <param name="includeschema">Use to include the table schema of the saved search. If false, results contain the fieldid and field value without field information. Default is false. (optional)</param>
        /// <param name="resultsAsSimpleResultsList">Indicates if the results should be returned in a simple results list format or a table format. Default is a table format. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsSearchesSearchResultsResponse</returns>
        TrebuchetWebApiDataContractsSearchesSearchResultsResponse SearchesGetSearchResultsByIdV1 (string association, string scope, string scopeowner, string searchid, string searchTerm = null, int? pagenumber = null, int? pagesize = null, bool? includeschema = null, bool? resultsAsSimpleResultsList = null, string lang = null, string locale = null);

        /// <summary>
        /// Run a saved search by internal ID
        /// </summary>
        /// <remarks>
        /// Operation that returns the paged results of a saved search. When the search contains Prompts, the response contains the Prompt. Send the Prompt and the original operation parameters to  SearchResultsRequest to the getsearchresults ad-hoc http post operation.&lt;/br&gt;&lt;/br&gt;PromptType is a FieldSubType enum as described below:&lt;/br&gt;FieldSubType&lt;/br&gt;None &#x3D; 0&lt;/br&gt;Text &#x3D; 1&lt;/br&gt;Number &#x3D; 2&lt;/br&gt;DateTime &#x3D; 3&lt;/br&gt;Logical &#x3D; 4&lt;/br&gt;Binary &#x3D; 5&lt;/br&gt;DateOnly &#x3D; 6&lt;/br&gt;TimeOnly &#x3D; 7&lt;/br&gt;Json &#x3D; 8&lt;/br&gt;JsonArray &#x3D; 9&lt;/br&gt;Xml &#x3D; 10&lt;/br&gt;XmlCollection &#x3D; 11&lt;/br&gt;TimeValue &#x3D; 12&lt;/br&gt;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Specify the Business Object association ID for the saved search.</param>
        /// <param name="scope">Specify the scope name or ID for the saved search.</param>
        /// <param name="scopeowner">Specify the scope owner ID for the saved search. Use (None) when no scope owner exists.</param>
        /// <param name="searchid">Specify the internal ID for the saved search. Use \&quot;Run a saved search by name\&quot; if you do not have the internal ID.</param>
        /// <param name="searchTerm">Specify search text filter the results. Example: Use \&quot;Service Request\&quot; to filter Incident results to include only service requests. (optional)</param>
        /// <param name="pagenumber">Specify the page number of the result set to return. (optional)</param>
        /// <param name="pagesize">Specify the number of rows to return per page. (optional)</param>
        /// <param name="includeschema">Use to include the table schema of the saved search. If false, results contain the fieldid and field value without field information. Default is false. (optional)</param>
        /// <param name="resultsAsSimpleResultsList">Indicates if the results should be returned in a simple results list format or a table format. Default is a table format. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsSearchesSearchResultsResponse</returns>
        ApiResponse<TrebuchetWebApiDataContractsSearchesSearchResultsResponse> SearchesGetSearchResultsByIdV1WithHttpInfo (string association, string scope, string scopeowner, string searchid, string searchTerm = null, int? pagenumber = null, int? pagesize = null, bool? includeschema = null, bool? resultsAsSimpleResultsList = null, string lang = null, string locale = null);
        /// <summary>
        /// Run a saved search by name
        /// </summary>
        /// <remarks>
        /// Operation that returns the paged results of a saved search. When the search contains Prompts, the response contains the Prompt. Send the Prompt and the original operation parameters to  SearchResultsRequest to the getsearchresults ad-hoc http post operation.&lt;/br&gt;&lt;/br&gt;PromptType is a FieldSubType enum as described below:&lt;/br&gt;FieldSubType&lt;/br&gt;None &#x3D; 0&lt;/br&gt;Text &#x3D; 1&lt;/br&gt;Number &#x3D; 2&lt;/br&gt;DateTime &#x3D; 3&lt;/br&gt;Logical &#x3D; 4&lt;/br&gt;Binary &#x3D; 5&lt;/br&gt;DateOnly &#x3D; 6&lt;/br&gt;TimeOnly &#x3D; 7&lt;/br&gt;Json &#x3D; 8&lt;/br&gt;JsonArray &#x3D; 9&lt;/br&gt;Xml &#x3D; 10&lt;/br&gt;XmlCollection &#x3D; 11&lt;/br&gt;TimeValue &#x3D; 12&lt;/br&gt;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Specify the Business Object association ID for the saved search.</param>
        /// <param name="scope">Specify the scope name or ID for the saved search.</param>
        /// <param name="scopeowner">Specify the scope owner ID for the saved search. Use (None) when no scope owner exists.</param>
        /// <param name="searchname">Specify the name of the saved search.</param>
        /// <param name="searchTerm">Specify search text filter the results. Example: Use \&quot;Service Request\&quot; to filter Incident results to include only service requests. (optional)</param>
        /// <param name="pagenumber">Specify the page number of the result set to return. (optional)</param>
        /// <param name="pagesize">Specify the number of rows to return per page. (optional)</param>
        /// <param name="includeschema">Use to include the table schema of the saved search. If false, results contain the fieldid and field value without field information. Default is false. (optional)</param>
        /// <param name="resultsAsSimpleResultsList">Indicates if the results should be returned in a simple results list format or a table format. Default is a table format. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsSearchesSearchResultsResponse</returns>
        TrebuchetWebApiDataContractsSearchesSearchResultsResponse SearchesGetSearchResultsByNameV1 (string association, string scope, string scopeowner, string searchname, string searchTerm = null, int? pagenumber = null, int? pagesize = null, bool? includeschema = null, bool? resultsAsSimpleResultsList = null, string lang = null, string locale = null);

        /// <summary>
        /// Run a saved search by name
        /// </summary>
        /// <remarks>
        /// Operation that returns the paged results of a saved search. When the search contains Prompts, the response contains the Prompt. Send the Prompt and the original operation parameters to  SearchResultsRequest to the getsearchresults ad-hoc http post operation.&lt;/br&gt;&lt;/br&gt;PromptType is a FieldSubType enum as described below:&lt;/br&gt;FieldSubType&lt;/br&gt;None &#x3D; 0&lt;/br&gt;Text &#x3D; 1&lt;/br&gt;Number &#x3D; 2&lt;/br&gt;DateTime &#x3D; 3&lt;/br&gt;Logical &#x3D; 4&lt;/br&gt;Binary &#x3D; 5&lt;/br&gt;DateOnly &#x3D; 6&lt;/br&gt;TimeOnly &#x3D; 7&lt;/br&gt;Json &#x3D; 8&lt;/br&gt;JsonArray &#x3D; 9&lt;/br&gt;Xml &#x3D; 10&lt;/br&gt;XmlCollection &#x3D; 11&lt;/br&gt;TimeValue &#x3D; 12&lt;/br&gt;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Specify the Business Object association ID for the saved search.</param>
        /// <param name="scope">Specify the scope name or ID for the saved search.</param>
        /// <param name="scopeowner">Specify the scope owner ID for the saved search. Use (None) when no scope owner exists.</param>
        /// <param name="searchname">Specify the name of the saved search.</param>
        /// <param name="searchTerm">Specify search text filter the results. Example: Use \&quot;Service Request\&quot; to filter Incident results to include only service requests. (optional)</param>
        /// <param name="pagenumber">Specify the page number of the result set to return. (optional)</param>
        /// <param name="pagesize">Specify the number of rows to return per page. (optional)</param>
        /// <param name="includeschema">Use to include the table schema of the saved search. If false, results contain the fieldid and field value without field information. Default is false. (optional)</param>
        /// <param name="resultsAsSimpleResultsList">Indicates if the results should be returned in a simple results list format or a table format. Default is a table format. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsSearchesSearchResultsResponse</returns>
        ApiResponse<TrebuchetWebApiDataContractsSearchesSearchResultsResponse> SearchesGetSearchResultsByNameV1WithHttpInfo (string association, string scope, string scopeowner, string searchname, string searchTerm = null, int? pagenumber = null, int? pagesize = null, bool? includeschema = null, bool? resultsAsSimpleResultsList = null, string lang = null, string locale = null);
        /// <summary>
        /// Export an ad-hoc search
        /// </summary>
        /// <remarks>
        /// Operation that returns an ad-hoc search in a specified export format: 0&#x3D;CSV, 1&#x3D;Excel, 2&#x3D;Tab, 3&#x3D;Word, 4&#x3D;Custom Separator, 5&#x3D;Simple JSON. To execute a search with Prompts, the PromptId and Value are required in the Prompt request object.&lt;/br&gt;&lt;/br&gt;PromptType is a FieldSubType enum as described below:&lt;/br&gt;FieldSubType&lt;/br&gt;None &#x3D; 0&lt;/br&gt;Text &#x3D; 1&lt;/br&gt;Number &#x3D; 2&lt;/br&gt;DateTime &#x3D; 3&lt;/br&gt;Logical &#x3D; 4&lt;/br&gt;Binary &#x3D; 5&lt;/br&gt;DateOnly &#x3D; 6&lt;/br&gt;TimeOnly &#x3D; 7&lt;/br&gt;Json &#x3D; 8&lt;/br&gt;JsonArray &#x3D; 9&lt;/br&gt;Xml &#x3D; 10&lt;/br&gt;XmlCollection &#x3D; 11&lt;/br&gt;TimeValue &#x3D; 12&lt;/br&gt;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataRequest">Request object to specify search parameters and export format.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>string</returns>
        string SearchesGetSearchResultsExportAdHocV1 (TrebuchetWebApiDataContractsSearchesExportSearchResultsRequest dataRequest, string lang = null, string locale = null);

        /// <summary>
        /// Export an ad-hoc search
        /// </summary>
        /// <remarks>
        /// Operation that returns an ad-hoc search in a specified export format: 0&#x3D;CSV, 1&#x3D;Excel, 2&#x3D;Tab, 3&#x3D;Word, 4&#x3D;Custom Separator, 5&#x3D;Simple JSON. To execute a search with Prompts, the PromptId and Value are required in the Prompt request object.&lt;/br&gt;&lt;/br&gt;PromptType is a FieldSubType enum as described below:&lt;/br&gt;FieldSubType&lt;/br&gt;None &#x3D; 0&lt;/br&gt;Text &#x3D; 1&lt;/br&gt;Number &#x3D; 2&lt;/br&gt;DateTime &#x3D; 3&lt;/br&gt;Logical &#x3D; 4&lt;/br&gt;Binary &#x3D; 5&lt;/br&gt;DateOnly &#x3D; 6&lt;/br&gt;TimeOnly &#x3D; 7&lt;/br&gt;Json &#x3D; 8&lt;/br&gt;JsonArray &#x3D; 9&lt;/br&gt;Xml &#x3D; 10&lt;/br&gt;XmlCollection &#x3D; 11&lt;/br&gt;TimeValue &#x3D; 12&lt;/br&gt;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataRequest">Request object to specify search parameters and export format.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> SearchesGetSearchResultsExportAdHocV1WithHttpInfo (TrebuchetWebApiDataContractsSearchesExportSearchResultsRequest dataRequest, string lang = null, string locale = null);
        /// <summary>
        /// Export a saved search by ID
        /// </summary>
        /// <remarks>
        /// Operation that returns the paged results of a saved search in a specified format. When the search contains Prompts, the response contains the Prompt. Send the Prompt and the original operation parameters to  SearchResultsRequest to the getsearchresultsexport ad-hoc http post operation.&lt;/br&gt;&lt;/br&gt;PromptType is a FieldSubType enum as described below:&lt;/br&gt;FieldSubType&lt;/br&gt;None &#x3D; 0&lt;/br&gt;Text &#x3D; 1&lt;/br&gt;Number &#x3D; 2&lt;/br&gt;DateTime &#x3D; 3&lt;/br&gt;Logical &#x3D; 4&lt;/br&gt;Binary &#x3D; 5&lt;/br&gt;DateOnly &#x3D; 6&lt;/br&gt;TimeOnly &#x3D; 7&lt;/br&gt;Json &#x3D; 8&lt;/br&gt;JsonArray &#x3D; 9&lt;/br&gt;Xml &#x3D; 10&lt;/br&gt;XmlCollection &#x3D; 11&lt;/br&gt;TimeValue &#x3D; 12&lt;/br&gt;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Specify the Business Object association ID for the saved search.</param>
        /// <param name="scope">Specify the scope name or ID for the saved search.</param>
        /// <param name="scopeowner">Specify the scope owner ID for the saved search. Use (None) when no scope owner exists.</param>
        /// <param name="searchid">Specify the internal ID for the saved search. Use \&quot;Run a saved search by name\&quot; if you do not have the internal ID.</param>
        /// <param name="exportformat">Specify the format of the export</param>
        /// <param name="searchTerm">Specify search text filter the results. Example: Use \&quot;Service Request\&quot; to filter Incident results to include only service requests. (optional)</param>
        /// <param name="pagenumber">Specify the page number of the result set to return. (optional)</param>
        /// <param name="pagesize">Specify the number of rows to return per page. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>string</returns>
        string SearchesGetSearchResultsExportByIdV1 (string association, string scope, string scopeowner, string searchid, string exportformat, string searchTerm = null, int? pagenumber = null, int? pagesize = null, string lang = null, string locale = null);

        /// <summary>
        /// Export a saved search by ID
        /// </summary>
        /// <remarks>
        /// Operation that returns the paged results of a saved search in a specified format. When the search contains Prompts, the response contains the Prompt. Send the Prompt and the original operation parameters to  SearchResultsRequest to the getsearchresultsexport ad-hoc http post operation.&lt;/br&gt;&lt;/br&gt;PromptType is a FieldSubType enum as described below:&lt;/br&gt;FieldSubType&lt;/br&gt;None &#x3D; 0&lt;/br&gt;Text &#x3D; 1&lt;/br&gt;Number &#x3D; 2&lt;/br&gt;DateTime &#x3D; 3&lt;/br&gt;Logical &#x3D; 4&lt;/br&gt;Binary &#x3D; 5&lt;/br&gt;DateOnly &#x3D; 6&lt;/br&gt;TimeOnly &#x3D; 7&lt;/br&gt;Json &#x3D; 8&lt;/br&gt;JsonArray &#x3D; 9&lt;/br&gt;Xml &#x3D; 10&lt;/br&gt;XmlCollection &#x3D; 11&lt;/br&gt;TimeValue &#x3D; 12&lt;/br&gt;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Specify the Business Object association ID for the saved search.</param>
        /// <param name="scope">Specify the scope name or ID for the saved search.</param>
        /// <param name="scopeowner">Specify the scope owner ID for the saved search. Use (None) when no scope owner exists.</param>
        /// <param name="searchid">Specify the internal ID for the saved search. Use \&quot;Run a saved search by name\&quot; if you do not have the internal ID.</param>
        /// <param name="exportformat">Specify the format of the export</param>
        /// <param name="searchTerm">Specify search text filter the results. Example: Use \&quot;Service Request\&quot; to filter Incident results to include only service requests. (optional)</param>
        /// <param name="pagenumber">Specify the page number of the result set to return. (optional)</param>
        /// <param name="pagesize">Specify the number of rows to return per page. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> SearchesGetSearchResultsExportByIdV1WithHttpInfo (string association, string scope, string scopeowner, string searchid, string exportformat, string searchTerm = null, int? pagenumber = null, int? pagesize = null, string lang = null, string locale = null);
        /// <summary>
        /// Export a saved search by name
        /// </summary>
        /// <remarks>
        /// Operation that returns the paged results of a saved search in a specified format. When the search contains Prompts, the response contains the Prompt. Send the Prompt and the original operation parameters to  SearchResultsRequest to the getsearchresultsexport ad-hoc http post operation.&lt;/br&gt;&lt;/br&gt;PromptType is a FieldSubType enum as described below:&lt;/br&gt;FieldSubType&lt;/br&gt;None &#x3D; 0&lt;/br&gt;Text &#x3D; 1&lt;/br&gt;Number &#x3D; 2&lt;/br&gt;DateTime &#x3D; 3&lt;/br&gt;Logical &#x3D; 4&lt;/br&gt;Binary &#x3D; 5&lt;/br&gt;DateOnly &#x3D; 6&lt;/br&gt;TimeOnly &#x3D; 7&lt;/br&gt;Json &#x3D; 8&lt;/br&gt;JsonArray &#x3D; 9&lt;/br&gt;Xml &#x3D; 10&lt;/br&gt;XmlCollection &#x3D; 11&lt;/br&gt;TimeValue &#x3D; 12&lt;/br&gt;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Specify the Business Object association ID for the saved search.</param>
        /// <param name="scope">Specify the scope name or ID for the saved search.</param>
        /// <param name="scopeowner">Specify the scope owner ID for the saved search. Use (None) when no scope owner exists.</param>
        /// <param name="searchname">Specify the name of the saved search.</param>
        /// <param name="exportformat">Specify the format of the export</param>
        /// <param name="searchTerm">Specify search text filter the results. Example: Use \&quot;Service Request\&quot; to filter Incident results to include only service requests. (optional)</param>
        /// <param name="pagenumber">Specify the page number of the result set to return. (optional)</param>
        /// <param name="pagesize">Specify the number of rows to return per page. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>string</returns>
        string SearchesGetSearchResultsExportByNameV1 (string association, string scope, string scopeowner, string searchname, string exportformat, string searchTerm = null, int? pagenumber = null, int? pagesize = null, string lang = null, string locale = null);

        /// <summary>
        /// Export a saved search by name
        /// </summary>
        /// <remarks>
        /// Operation that returns the paged results of a saved search in a specified format. When the search contains Prompts, the response contains the Prompt. Send the Prompt and the original operation parameters to  SearchResultsRequest to the getsearchresultsexport ad-hoc http post operation.&lt;/br&gt;&lt;/br&gt;PromptType is a FieldSubType enum as described below:&lt;/br&gt;FieldSubType&lt;/br&gt;None &#x3D; 0&lt;/br&gt;Text &#x3D; 1&lt;/br&gt;Number &#x3D; 2&lt;/br&gt;DateTime &#x3D; 3&lt;/br&gt;Logical &#x3D; 4&lt;/br&gt;Binary &#x3D; 5&lt;/br&gt;DateOnly &#x3D; 6&lt;/br&gt;TimeOnly &#x3D; 7&lt;/br&gt;Json &#x3D; 8&lt;/br&gt;JsonArray &#x3D; 9&lt;/br&gt;Xml &#x3D; 10&lt;/br&gt;XmlCollection &#x3D; 11&lt;/br&gt;TimeValue &#x3D; 12&lt;/br&gt;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Specify the Business Object association ID for the saved search.</param>
        /// <param name="scope">Specify the scope name or ID for the saved search.</param>
        /// <param name="scopeowner">Specify the scope owner ID for the saved search. Use (None) when no scope owner exists.</param>
        /// <param name="searchname">Specify the name of the saved search.</param>
        /// <param name="exportformat">Specify the format of the export</param>
        /// <param name="searchTerm">Specify search text filter the results. Example: Use \&quot;Service Request\&quot; to filter Incident results to include only service requests. (optional)</param>
        /// <param name="pagenumber">Specify the page number of the result set to return. (optional)</param>
        /// <param name="pagesize">Specify the number of rows to return per page. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> SearchesGetSearchResultsExportByNameV1WithHttpInfo (string association, string scope, string scopeowner, string searchname, string exportformat, string searchTerm = null, int? pagenumber = null, int? pagesize = null, string lang = null, string locale = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get a Quick Search from a list of Business Object IDs
        /// </summary>
        /// <remarks>
        /// Operation to build a Quick Search configuration that you can use to execute a Quick Search for multiple Business Objects. The configuration  includes supplied Business Object IDs and specific search items with the following options. Use the Option Key to determine if you can change the options. &lt;/br&gt;&lt;/br&gt;&lt;/br&gt;ChangedOption&lt;/br&gt;&lt;/br&gt;NonFinalStateOption&lt;/br&gt;&lt;/br&gt;SearchAnyWordsOption&lt;/br&gt;&lt;/br&gt;SearchAttachmentsOption&lt;/br&gt;&lt;/br&gt;SearchRelatedOption&lt;/br&gt;&lt;/br&gt;SortByOption&lt;/br&gt;&lt;/br&gt;&lt;/br&gt;Option Key:&lt;/br&gt;&lt;/br&gt;0 &#x3D; None (Not selected and cannot select.)&lt;/br&gt;&lt;/br&gt;1 &#x3D; Use (Selected and cannot clear.)&lt;/br&gt;&lt;/br&gt;2 &#x3D; Display (Not selected and can select.)&lt;/br&gt;&lt;/br&gt;3 &#x3D; UseAndDisplay (Selected and can clear.)&lt;/br&gt;&lt;/br&gt;&lt;/br&gt;SearchTargetType:&lt;/br&gt;&lt;/br&gt;0 &#x3D; BusOb (Business Object)&lt;/br&gt;&lt;/br&gt;1 &#x3D; DocRepository (Document Repository)
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataRequest">Request containing the Business Object IDs list.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsSearchesQuickSearchConfigurationResponse</returns>
        System.Threading.Tasks.Task<TrebuchetWebApiDataContractsSearchesQuickSearchConfigurationResponse> SearchesGetQuickSearchConfigurationForBusObsV1Async (TrebuchetWebApiDataContractsSearchesQuickSearchConfigurationRequest dataRequest, string lang = null, string locale = null);

        /// <summary>
        /// Get a Quick Search from a list of Business Object IDs
        /// </summary>
        /// <remarks>
        /// Operation to build a Quick Search configuration that you can use to execute a Quick Search for multiple Business Objects. The configuration  includes supplied Business Object IDs and specific search items with the following options. Use the Option Key to determine if you can change the options. &lt;/br&gt;&lt;/br&gt;&lt;/br&gt;ChangedOption&lt;/br&gt;&lt;/br&gt;NonFinalStateOption&lt;/br&gt;&lt;/br&gt;SearchAnyWordsOption&lt;/br&gt;&lt;/br&gt;SearchAttachmentsOption&lt;/br&gt;&lt;/br&gt;SearchRelatedOption&lt;/br&gt;&lt;/br&gt;SortByOption&lt;/br&gt;&lt;/br&gt;&lt;/br&gt;Option Key:&lt;/br&gt;&lt;/br&gt;0 &#x3D; None (Not selected and cannot select.)&lt;/br&gt;&lt;/br&gt;1 &#x3D; Use (Selected and cannot clear.)&lt;/br&gt;&lt;/br&gt;2 &#x3D; Display (Not selected and can select.)&lt;/br&gt;&lt;/br&gt;3 &#x3D; UseAndDisplay (Selected and can clear.)&lt;/br&gt;&lt;/br&gt;&lt;/br&gt;SearchTargetType:&lt;/br&gt;&lt;/br&gt;0 &#x3D; BusOb (Business Object)&lt;/br&gt;&lt;/br&gt;1 &#x3D; DocRepository (Document Repository)
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataRequest">Request containing the Business Object IDs list.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsSearchesQuickSearchConfigurationResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrebuchetWebApiDataContractsSearchesQuickSearchConfigurationResponse>> SearchesGetQuickSearchConfigurationForBusObsV1AsyncWithHttpInfo (TrebuchetWebApiDataContractsSearchesQuickSearchConfigurationRequest dataRequest, string lang = null, string locale = null);
        /// <summary>
        /// Get a Quick Search by Business Objects with view rights
        /// </summary>
        /// <remarks>
        /// Operation to get a Quick Search configuration that you can use to execute a Quick Search based the current user&#39;s Business Object view rights. The configuration  includes supplied Business Object IDs and specific search items with the following options. Use the Option Key to determine if you can change the options.&lt;/br&gt;&lt;/br&gt;ChangedOption&lt;/br&gt;&lt;/br&gt;NonFinalStateOption&lt;/br&gt;&lt;/br&gt;SearchAnyWordsOption&lt;/br&gt;&lt;/br&gt;SearchAttachmentsOption&lt;/br&gt;&lt;/br&gt;SearchRelatedOption&lt;/br&gt;&lt;/br&gt;SortByOption&lt;/br&gt;&lt;/br&gt;&lt;/br&gt;Option Key:&lt;/br&gt;&lt;/br&gt;0 &#x3D; None (Not selected and cannot select.)&lt;/br&gt;&lt;/br&gt;1 &#x3D; Use (Selected and cannot clear.)&lt;/br&gt;&lt;/br&gt;2 &#x3D; Display (Not selected and can select.)&lt;/br&gt;&lt;/br&gt;3 &#x3D; UseAndDisplay (Selected and can clear.)&lt;/br&gt;&lt;/br&gt;&lt;/br&gt;SearchTargetType:&lt;/br&gt;&lt;/br&gt;0 &#x3D; BusOb (Business Object)&lt;/br&gt;&lt;/br&gt;1 &#x3D; DocRepository (Document Repository)
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsSearchesQuickSearchConfigurationResponse</returns>
        System.Threading.Tasks.Task<TrebuchetWebApiDataContractsSearchesQuickSearchConfigurationResponse> SearchesGetQuickSearchConfigurationForBusObsWithViewRightsV1Async (string lang = null, string locale = null);

        /// <summary>
        /// Get a Quick Search by Business Objects with view rights
        /// </summary>
        /// <remarks>
        /// Operation to get a Quick Search configuration that you can use to execute a Quick Search based the current user&#39;s Business Object view rights. The configuration  includes supplied Business Object IDs and specific search items with the following options. Use the Option Key to determine if you can change the options.&lt;/br&gt;&lt;/br&gt;ChangedOption&lt;/br&gt;&lt;/br&gt;NonFinalStateOption&lt;/br&gt;&lt;/br&gt;SearchAnyWordsOption&lt;/br&gt;&lt;/br&gt;SearchAttachmentsOption&lt;/br&gt;&lt;/br&gt;SearchRelatedOption&lt;/br&gt;&lt;/br&gt;SortByOption&lt;/br&gt;&lt;/br&gt;&lt;/br&gt;Option Key:&lt;/br&gt;&lt;/br&gt;0 &#x3D; None (Not selected and cannot select.)&lt;/br&gt;&lt;/br&gt;1 &#x3D; Use (Selected and cannot clear.)&lt;/br&gt;&lt;/br&gt;2 &#x3D; Display (Not selected and can select.)&lt;/br&gt;&lt;/br&gt;3 &#x3D; UseAndDisplay (Selected and can clear.)&lt;/br&gt;&lt;/br&gt;&lt;/br&gt;SearchTargetType:&lt;/br&gt;&lt;/br&gt;0 &#x3D; BusOb (Business Object)&lt;/br&gt;&lt;/br&gt;1 &#x3D; DocRepository (Document Repository)
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsSearchesQuickSearchConfigurationResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrebuchetWebApiDataContractsSearchesQuickSearchConfigurationResponse>> SearchesGetQuickSearchConfigurationForBusObsWithViewRightsV1AsyncWithHttpInfo (string lang = null, string locale = null);
        /// <summary>
        /// Execute a Quick Search from a list of Business Object IDs and search text
        /// </summary>
        /// <remarks>
        /// Operation to execute a Quick Search using a list of Business Object IDs and search text.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataRequest">Request object listing Business Object IDs and search text. Leave out the entire Business Object IDs parameter and all configured quick search Business Objects will be searched.</param>
        /// <param name="includeLinks">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsSearchesSimpleResultsList</returns>
        System.Threading.Tasks.Task<TrebuchetWebApiDataContractsSearchesSimpleResultsList> SearchesGetQuickSearchResultsV1Async (TrebuchetWebApiDataContractsSearchesQuickSearchRequest dataRequest, bool? includeLinks = null, string lang = null, string locale = null);

        /// <summary>
        /// Execute a Quick Search from a list of Business Object IDs and search text
        /// </summary>
        /// <remarks>
        /// Operation to execute a Quick Search using a list of Business Object IDs and search text.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataRequest">Request object listing Business Object IDs and search text. Leave out the entire Business Object IDs parameter and all configured quick search Business Objects will be searched.</param>
        /// <param name="includeLinks">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsSearchesSimpleResultsList)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrebuchetWebApiDataContractsSearchesSimpleResultsList>> SearchesGetQuickSearchResultsV1AsyncWithHttpInfo (TrebuchetWebApiDataContractsSearchesQuickSearchRequest dataRequest, bool? includeLinks = null, string lang = null, string locale = null);
        /// <summary>
        /// Execute a Quick Search on a specific Business Object
        /// </summary>
        /// <remarks>
        /// Operation to execute a Quick Search for a specific Business Object ID. Use \&quot;Get a Quick Search from a list of Business Object IDs\&quot; to find values for specific search item options, such as NonFinalStateOption.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataRequest">Request object containing the parameters for specific Business Object Quick Search execution.</param>
        /// <param name="includeSchema">Flag to include the schema for the results. (optional)</param>
        /// <param name="includeLocationFields">Flag to include location fields in the results. (optional)</param>
        /// <param name="includeLinks">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsSearchesSearchResultsTableResponse</returns>
        System.Threading.Tasks.Task<TrebuchetWebApiDataContractsSearchesSearchResultsTableResponse> SearchesGetQuickSearchSpecificResultsV1Async (TrebuchetWebApiDataContractsSearchesQuickSearchSpecificRequest dataRequest, bool? includeSchema = null, bool? includeLocationFields = null, bool? includeLinks = null, string lang = null, string locale = null);

        /// <summary>
        /// Execute a Quick Search on a specific Business Object
        /// </summary>
        /// <remarks>
        /// Operation to execute a Quick Search for a specific Business Object ID. Use \&quot;Get a Quick Search from a list of Business Object IDs\&quot; to find values for specific search item options, such as NonFinalStateOption.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataRequest">Request object containing the parameters for specific Business Object Quick Search execution.</param>
        /// <param name="includeSchema">Flag to include the schema for the results. (optional)</param>
        /// <param name="includeLocationFields">Flag to include location fields in the results. (optional)</param>
        /// <param name="includeLinks">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsSearchesSearchResultsTableResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrebuchetWebApiDataContractsSearchesSearchResultsTableResponse>> SearchesGetQuickSearchSpecificResultsV1AsyncWithHttpInfo (TrebuchetWebApiDataContractsSearchesQuickSearchSpecificRequest dataRequest, bool? includeSchema = null, bool? includeLocationFields = null, bool? includeLinks = null, string lang = null, string locale = null);
        /// <summary>
        /// Execute a Quick Search on a specific Business Object
        /// </summary>
        /// <remarks>
        /// Operation to execute a Quick Search for a specific Business Object ID. Use \&quot;Get a Quick Search from a list of Business Object IDs\&quot; to find values for specific search item options, such as NonFinalStateOption.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataRequest">Request object containing the parameters for specific Business Object Quick Search execution.</param>
        /// <param name="includeSchema">Flag to include the schema for the results. (optional)</param>
        /// <param name="includeLocationFields">Flag to include location fields in the results. (optional)</param>
        /// <param name="includeLinks">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsSearchesQuickSearchResponse</returns>
        System.Threading.Tasks.Task<TrebuchetWebApiDataContractsSearchesQuickSearchResponse> SearchesGetQuickSearchSpecificResultsV2Async (TrebuchetWebApiDataContractsSearchesQuickSearchSpecificRequest dataRequest, bool? includeSchema = null, bool? includeLocationFields = null, bool? includeLinks = null, string lang = null, string locale = null);

        /// <summary>
        /// Execute a Quick Search on a specific Business Object
        /// </summary>
        /// <remarks>
        /// Operation to execute a Quick Search for a specific Business Object ID. Use \&quot;Get a Quick Search from a list of Business Object IDs\&quot; to find values for specific search item options, such as NonFinalStateOption.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataRequest">Request object containing the parameters for specific Business Object Quick Search execution.</param>
        /// <param name="includeSchema">Flag to include the schema for the results. (optional)</param>
        /// <param name="includeLocationFields">Flag to include location fields in the results. (optional)</param>
        /// <param name="includeLinks">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsSearchesQuickSearchResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrebuchetWebApiDataContractsSearchesQuickSearchResponse>> SearchesGetQuickSearchSpecificResultsV2AsyncWithHttpInfo (TrebuchetWebApiDataContractsSearchesQuickSearchSpecificRequest dataRequest, bool? includeSchema = null, bool? includeLocationFields = null, bool? includeLinks = null, string lang = null, string locale = null);
        /// <summary>
        /// Get all saved searches by Folder ID
        /// </summary>
        /// <remarks>
        /// Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Use to filter results by Business Object association ID.</param>
        /// <param name="scope">Use to filter results by scope name or ID.</param>
        /// <param name="scopeowner">Use to filter results by scope owner ID.</param>
        /// <param name="folder">Use to filter results by Search Group folder ID.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsSearchesSearchItemResponse</returns>
        System.Threading.Tasks.Task<TrebuchetWebApiDataContractsSearchesSearchItemResponse> SearchesGetSearchItemsByAssociationScopeScopeOwnerFolderV1Async (string association, string scope, string scopeowner, string folder, bool? links = null, string lang = null, string locale = null);

        /// <summary>
        /// Get all saved searches by Folder ID
        /// </summary>
        /// <remarks>
        /// Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Use to filter results by Business Object association ID.</param>
        /// <param name="scope">Use to filter results by scope name or ID.</param>
        /// <param name="scopeowner">Use to filter results by scope owner ID.</param>
        /// <param name="folder">Use to filter results by Search Group folder ID.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsSearchesSearchItemResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrebuchetWebApiDataContractsSearchesSearchItemResponse>> SearchesGetSearchItemsByAssociationScopeScopeOwnerFolderV1AsyncWithHttpInfo (string association, string scope, string scopeowner, string folder, bool? links = null, string lang = null, string locale = null);
        /// <summary>
        /// Get all saved searches by Folder ID
        /// </summary>
        /// <remarks>
        /// Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Use to filter results by Business Object association ID.</param>
        /// <param name="scope">Use to filter results by scope name or ID.</param>
        /// <param name="scopeowner">Use to filter results by scope owner ID.</param>
        /// <param name="folder">Use to filter results by Search Group folder ID.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsCoreManagerData</returns>
        System.Threading.Tasks.Task<TrebuchetWebApiDataContractsCoreManagerData> SearchesGetSearchItemsByAssociationScopeScopeOwnerFolderV2Async (string association, string scope, string scopeowner, string folder, bool? links = null, string lang = null, string locale = null);

        /// <summary>
        /// Get all saved searches by Folder ID
        /// </summary>
        /// <remarks>
        /// Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Use to filter results by Business Object association ID.</param>
        /// <param name="scope">Use to filter results by scope name or ID.</param>
        /// <param name="scopeowner">Use to filter results by scope owner ID.</param>
        /// <param name="folder">Use to filter results by Search Group folder ID.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsCoreManagerData)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrebuchetWebApiDataContractsCoreManagerData>> SearchesGetSearchItemsByAssociationScopeScopeOwnerFolderV2AsyncWithHttpInfo (string association, string scope, string scopeowner, string folder, bool? links = null, string lang = null, string locale = null);
        /// <summary>
        /// Get all saved searches by scope owner (sub scope)
        /// </summary>
        /// <remarks>
        /// Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Use to filter results by Business Object association ID.</param>
        /// <param name="scope">Use to filter results by scope name or ID.</param>
        /// <param name="scopeowner">Use to filter results by scope owner ID.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsSearchesSearchItemResponse</returns>
        System.Threading.Tasks.Task<TrebuchetWebApiDataContractsSearchesSearchItemResponse> SearchesGetSearchItemsByAssociationScopeScopeOwnerV1Async (string association, string scope, string scopeowner, bool? links = null, string lang = null, string locale = null);

        /// <summary>
        /// Get all saved searches by scope owner (sub scope)
        /// </summary>
        /// <remarks>
        /// Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Use to filter results by Business Object association ID.</param>
        /// <param name="scope">Use to filter results by scope name or ID.</param>
        /// <param name="scopeowner">Use to filter results by scope owner ID.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsSearchesSearchItemResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrebuchetWebApiDataContractsSearchesSearchItemResponse>> SearchesGetSearchItemsByAssociationScopeScopeOwnerV1AsyncWithHttpInfo (string association, string scope, string scopeowner, bool? links = null, string lang = null, string locale = null);
        /// <summary>
        /// Get all saved searches by scope owner (sub scope)
        /// </summary>
        /// <remarks>
        /// Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Use to filter results by Business Object association ID.</param>
        /// <param name="scope">Use to filter results by scope name or ID.</param>
        /// <param name="scopeowner">Use to filter results by scope owner ID.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsCoreManagerData</returns>
        System.Threading.Tasks.Task<TrebuchetWebApiDataContractsCoreManagerData> SearchesGetSearchItemsByAssociationScopeScopeOwnerV2Async (string association, string scope, string scopeowner, bool? links = null, string lang = null, string locale = null);

        /// <summary>
        /// Get all saved searches by scope owner (sub scope)
        /// </summary>
        /// <remarks>
        /// Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Use to filter results by Business Object association ID.</param>
        /// <param name="scope">Use to filter results by scope name or ID.</param>
        /// <param name="scopeowner">Use to filter results by scope owner ID.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsCoreManagerData)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrebuchetWebApiDataContractsCoreManagerData>> SearchesGetSearchItemsByAssociationScopeScopeOwnerV2AsyncWithHttpInfo (string association, string scope, string scopeowner, bool? links = null, string lang = null, string locale = null);
        /// <summary>
        /// Get all saved searches by scope
        /// </summary>
        /// <remarks>
        /// Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Use to filter results by Business Object association ID.</param>
        /// <param name="scope">Use to filter results by scope name or ID.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsSearchesSearchItemResponse</returns>
        System.Threading.Tasks.Task<TrebuchetWebApiDataContractsSearchesSearchItemResponse> SearchesGetSearchItemsByAssociationScopeV1Async (string association, string scope, bool? links = null, string lang = null, string locale = null);

        /// <summary>
        /// Get all saved searches by scope
        /// </summary>
        /// <remarks>
        /// Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Use to filter results by Business Object association ID.</param>
        /// <param name="scope">Use to filter results by scope name or ID.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsSearchesSearchItemResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrebuchetWebApiDataContractsSearchesSearchItemResponse>> SearchesGetSearchItemsByAssociationScopeV1AsyncWithHttpInfo (string association, string scope, bool? links = null, string lang = null, string locale = null);
        /// <summary>
        /// Get all saved searches by scope
        /// </summary>
        /// <remarks>
        /// Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Use to filter results by Business Object association ID.</param>
        /// <param name="scope">Use to filter results by scope name or ID.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsCoreManagerData</returns>
        System.Threading.Tasks.Task<TrebuchetWebApiDataContractsCoreManagerData> SearchesGetSearchItemsByAssociationScopeV2Async (string association, string scope, bool? links = null, string lang = null, string locale = null);

        /// <summary>
        /// Get all saved searches by scope
        /// </summary>
        /// <remarks>
        /// Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Use to filter results by Business Object association ID.</param>
        /// <param name="scope">Use to filter results by scope name or ID.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsCoreManagerData)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrebuchetWebApiDataContractsCoreManagerData>> SearchesGetSearchItemsByAssociationScopeV2AsyncWithHttpInfo (string association, string scope, bool? links = null, string lang = null, string locale = null);
        /// <summary>
        /// Get all saved searches by Business Object association
        /// </summary>
        /// <remarks>
        /// Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Use to filter results by Business Object association ID.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsSearchesSearchItemResponse</returns>
        System.Threading.Tasks.Task<TrebuchetWebApiDataContractsSearchesSearchItemResponse> SearchesGetSearchItemsByAssociationV1Async (string association, bool? links = null, string lang = null, string locale = null);

        /// <summary>
        /// Get all saved searches by Business Object association
        /// </summary>
        /// <remarks>
        /// Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Use to filter results by Business Object association ID.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsSearchesSearchItemResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrebuchetWebApiDataContractsSearchesSearchItemResponse>> SearchesGetSearchItemsByAssociationV1AsyncWithHttpInfo (string association, bool? links = null, string lang = null, string locale = null);
        /// <summary>
        /// Get all saved searches by Business Object association
        /// </summary>
        /// <remarks>
        /// Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Use to filter results by Business Object association ID.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsCoreManagerData</returns>
        System.Threading.Tasks.Task<TrebuchetWebApiDataContractsCoreManagerData> SearchesGetSearchItemsByAssociationV2Async (string association, bool? links = null, string lang = null, string locale = null);

        /// <summary>
        /// Get all saved searches by Business Object association
        /// </summary>
        /// <remarks>
        /// Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Use to filter results by Business Object association ID.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsCoreManagerData)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrebuchetWebApiDataContractsCoreManagerData>> SearchesGetSearchItemsByAssociationV2AsyncWithHttpInfo (string association, bool? links = null, string lang = null, string locale = null);
        /// <summary>
        /// Get all saved searches by default Business Object association
        /// </summary>
        /// <remarks>
        /// Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsSearchesSearchItemResponse</returns>
        System.Threading.Tasks.Task<TrebuchetWebApiDataContractsSearchesSearchItemResponse> SearchesGetSearchItemsV1Async (bool? links = null, string lang = null, string locale = null);

        /// <summary>
        /// Get all saved searches by default Business Object association
        /// </summary>
        /// <remarks>
        /// Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsSearchesSearchItemResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrebuchetWebApiDataContractsSearchesSearchItemResponse>> SearchesGetSearchItemsV1AsyncWithHttpInfo (bool? links = null, string lang = null, string locale = null);
        /// <summary>
        /// Get all saved searches by default Business Object association
        /// </summary>
        /// <remarks>
        /// Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsCoreManagerData</returns>
        System.Threading.Tasks.Task<TrebuchetWebApiDataContractsCoreManagerData> SearchesGetSearchItemsV2Async (bool? links = null, string lang = null, string locale = null);

        /// <summary>
        /// Get all saved searches by default Business Object association
        /// </summary>
        /// <remarks>
        /// Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsCoreManagerData)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrebuchetWebApiDataContractsCoreManagerData>> SearchesGetSearchItemsV2AsyncWithHttpInfo (bool? links = null, string lang = null, string locale = null);
        /// <summary>
        /// Run an ad-hoc search
        /// </summary>
        /// <remarks>
        /// Operation that runs an ad-hoc Business Object search. To execute a search with Prompts, the PromptId and Value are required in the Prompt request object.&lt;/br&gt;&lt;/br&gt;PromptType is a FieldSubType enum as described below:&lt;/br&gt;FieldSubType&lt;/br&gt;None &#x3D; 0&lt;/br&gt;Text &#x3D; 1&lt;/br&gt;Number &#x3D; 2&lt;/br&gt;DateTime &#x3D; 3&lt;/br&gt;Logical &#x3D; 4&lt;/br&gt;Binary &#x3D; 5&lt;/br&gt;DateOnly &#x3D; 6&lt;/br&gt;TimeOnly &#x3D; 7&lt;/br&gt;Json &#x3D; 8&lt;/br&gt;JsonArray &#x3D; 9&lt;/br&gt;Xml &#x3D; 10&lt;/br&gt;XmlCollection &#x3D; 11&lt;/br&gt;TimeValue &#x3D; 12&lt;/br&gt;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataRequest">Request object to specify search parameters.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsSearchesSearchResultsResponse</returns>
        System.Threading.Tasks.Task<TrebuchetWebApiDataContractsSearchesSearchResultsResponse> SearchesGetSearchResultsAdHocV1Async (TrebuchetWebApiDataContractsSearchesSearchResultsRequest dataRequest, string lang = null, string locale = null);

        /// <summary>
        /// Run an ad-hoc search
        /// </summary>
        /// <remarks>
        /// Operation that runs an ad-hoc Business Object search. To execute a search with Prompts, the PromptId and Value are required in the Prompt request object.&lt;/br&gt;&lt;/br&gt;PromptType is a FieldSubType enum as described below:&lt;/br&gt;FieldSubType&lt;/br&gt;None &#x3D; 0&lt;/br&gt;Text &#x3D; 1&lt;/br&gt;Number &#x3D; 2&lt;/br&gt;DateTime &#x3D; 3&lt;/br&gt;Logical &#x3D; 4&lt;/br&gt;Binary &#x3D; 5&lt;/br&gt;DateOnly &#x3D; 6&lt;/br&gt;TimeOnly &#x3D; 7&lt;/br&gt;Json &#x3D; 8&lt;/br&gt;JsonArray &#x3D; 9&lt;/br&gt;Xml &#x3D; 10&lt;/br&gt;XmlCollection &#x3D; 11&lt;/br&gt;TimeValue &#x3D; 12&lt;/br&gt;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataRequest">Request object to specify search parameters.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsSearchesSearchResultsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrebuchetWebApiDataContractsSearchesSearchResultsResponse>> SearchesGetSearchResultsAdHocV1AsyncWithHttpInfo (TrebuchetWebApiDataContractsSearchesSearchResultsRequest dataRequest, string lang = null, string locale = null);
        /// <summary>
        /// Get results of a saved search
        /// </summary>
        /// <remarks>
        /// Operation that returns the results of a saved search in JSON format.&lt;/br&gt;&lt;/br&gt;This API is protected by a rate limiter and will reject any requests sent from an IP Address when a certain threshold of active concurrent requests has been hit.&lt;/br&gt;&lt;/br&gt;This value can be configured by the Max Concurrent Requests configuration value in the Web API config.&lt;/br&gt;&lt;/br&gt;Once this limit has been reached, all subsequent requests will receive a status code of 429 (Too Many Requests).&lt;/br&gt;&lt;/br&gt;This version is not subject to row limits and will return the entire result set of the stored search.&lt;/br&gt;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchRequest">Request object to specify search parameters.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsSearchesStoredSearchResults</returns>
        System.Threading.Tasks.Task<TrebuchetWebApiDataContractsSearchesStoredSearchResults> SearchesGetSearchResultsAsStringByIdV2Async (TrebuchetWebApiDataContractsSearchesStoredSearchRequest searchRequest, string lang = null, string locale = null);

        /// <summary>
        /// Get results of a saved search
        /// </summary>
        /// <remarks>
        /// Operation that returns the results of a saved search in JSON format.&lt;/br&gt;&lt;/br&gt;This API is protected by a rate limiter and will reject any requests sent from an IP Address when a certain threshold of active concurrent requests has been hit.&lt;/br&gt;&lt;/br&gt;This value can be configured by the Max Concurrent Requests configuration value in the Web API config.&lt;/br&gt;&lt;/br&gt;Once this limit has been reached, all subsequent requests will receive a status code of 429 (Too Many Requests).&lt;/br&gt;&lt;/br&gt;This version is not subject to row limits and will return the entire result set of the stored search.&lt;/br&gt;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchRequest">Request object to specify search parameters.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsSearchesStoredSearchResults)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrebuchetWebApiDataContractsSearchesStoredSearchResults>> SearchesGetSearchResultsAsStringByIdV2AsyncWithHttpInfo (TrebuchetWebApiDataContractsSearchesStoredSearchRequest searchRequest, string lang = null, string locale = null);
        /// <summary>
        /// Get results of a saved search
        /// </summary>
        /// <remarks>
        /// Operation that returns the results of a saved search in JSON format.&lt;/br&gt; &lt;/br&gt;  This API is protected by a rate limiter and will reject any requests sent from an IP Address when a certain threshold of active concurrent requests has been hit.&lt;/br&gt; &lt;/br&gt;  This value can be configured by the Max Concurrent Requests configuration value in the Web API config.&lt;/br&gt; &lt;/br&gt;  Once this limit has been reached, all subsequent requests will receive a status code of 429 (Too Many Requests).&lt;/br&gt; 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Specify the scope name for the saved search.</param>
        /// <param name="associationName">Specify the Business Object association Name for the saved search.</param>
        /// <param name="searchName">Specify the name of the saved search.</param>
        /// <param name="scopeOwner">Specify the scope owner ID for the saved search. Use (None) when no scope owner exists. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of List&lt;Dictionary&lt;string, string&gt;&gt;</returns>
        System.Threading.Tasks.Task<List<Dictionary<string, string>>> SearchesGetSearchResultsAsStringByNameV1Async (string scope, string associationName, string searchName, string scopeOwner = null, string lang = null, string locale = null);

        /// <summary>
        /// Get results of a saved search
        /// </summary>
        /// <remarks>
        /// Operation that returns the results of a saved search in JSON format.&lt;/br&gt; &lt;/br&gt;  This API is protected by a rate limiter and will reject any requests sent from an IP Address when a certain threshold of active concurrent requests has been hit.&lt;/br&gt; &lt;/br&gt;  This value can be configured by the Max Concurrent Requests configuration value in the Web API config.&lt;/br&gt; &lt;/br&gt;  Once this limit has been reached, all subsequent requests will receive a status code of 429 (Too Many Requests).&lt;/br&gt; 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Specify the scope name for the saved search.</param>
        /// <param name="associationName">Specify the Business Object association Name for the saved search.</param>
        /// <param name="searchName">Specify the name of the saved search.</param>
        /// <param name="scopeOwner">Specify the scope owner ID for the saved search. Use (None) when no scope owner exists. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;Dictionary&lt;string, string&gt;&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Dictionary<string, string>>>> SearchesGetSearchResultsAsStringByNameV1AsyncWithHttpInfo (string scope, string associationName, string searchName, string scopeOwner = null, string lang = null, string locale = null);
        /// <summary>
        /// Get results of a saved search
        /// </summary>
        /// <remarks>
        /// Operation that returns the results of a saved search in JSON format.&lt;/br&gt;&lt;/br&gt;This API is protected by a rate limiter and will reject any requests sent from an IP Address when a certain threshold of active concurrent requests has been hit.&lt;/br&gt;&lt;/br&gt;This value can be configured by the Max Concurrent Requests configuration value in the Web API config.&lt;/br&gt;&lt;/br&gt;Once this limit has been reached, all subsequent requests will receive a status code of 429 (Too Many Requests).&lt;/br&gt;&lt;/br&gt;This version is not subject to row limits and will return the entire result set of the stored search.&lt;/br&gt;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Specify the scope name for the saved search.</param>
        /// <param name="associationName">Specify the Business Object association Name for the saved search.</param>
        /// <param name="searchName">Specify the name of the saved search.</param>
        /// <param name="scopeOwner">Specify the scope owner ID for the saved search. Use (None) when no scope owner exists. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of List&lt;Dictionary&lt;string, string&gt;&gt;</returns>
        System.Threading.Tasks.Task<List<Dictionary<string, string>>> SearchesGetSearchResultsAsStringByNameV2Async (string scope, string associationName, string searchName, string scopeOwner = null, string lang = null, string locale = null);

        /// <summary>
        /// Get results of a saved search
        /// </summary>
        /// <remarks>
        /// Operation that returns the results of a saved search in JSON format.&lt;/br&gt;&lt;/br&gt;This API is protected by a rate limiter and will reject any requests sent from an IP Address when a certain threshold of active concurrent requests has been hit.&lt;/br&gt;&lt;/br&gt;This value can be configured by the Max Concurrent Requests configuration value in the Web API config.&lt;/br&gt;&lt;/br&gt;Once this limit has been reached, all subsequent requests will receive a status code of 429 (Too Many Requests).&lt;/br&gt;&lt;/br&gt;This version is not subject to row limits and will return the entire result set of the stored search.&lt;/br&gt;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Specify the scope name for the saved search.</param>
        /// <param name="associationName">Specify the Business Object association Name for the saved search.</param>
        /// <param name="searchName">Specify the name of the saved search.</param>
        /// <param name="scopeOwner">Specify the scope owner ID for the saved search. Use (None) when no scope owner exists. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;Dictionary&lt;string, string&gt;&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Dictionary<string, string>>>> SearchesGetSearchResultsAsStringByNameV2AsyncWithHttpInfo (string scope, string associationName, string searchName, string scopeOwner = null, string lang = null, string locale = null);
        /// <summary>
        /// Run a saved search by internal ID
        /// </summary>
        /// <remarks>
        /// Operation that returns the paged results of a saved search. When the search contains Prompts, the response contains the Prompt. Send the Prompt and the original operation parameters to  SearchResultsRequest to the getsearchresults ad-hoc http post operation.&lt;/br&gt;&lt;/br&gt;PromptType is a FieldSubType enum as described below:&lt;/br&gt;FieldSubType&lt;/br&gt;None &#x3D; 0&lt;/br&gt;Text &#x3D; 1&lt;/br&gt;Number &#x3D; 2&lt;/br&gt;DateTime &#x3D; 3&lt;/br&gt;Logical &#x3D; 4&lt;/br&gt;Binary &#x3D; 5&lt;/br&gt;DateOnly &#x3D; 6&lt;/br&gt;TimeOnly &#x3D; 7&lt;/br&gt;Json &#x3D; 8&lt;/br&gt;JsonArray &#x3D; 9&lt;/br&gt;Xml &#x3D; 10&lt;/br&gt;XmlCollection &#x3D; 11&lt;/br&gt;TimeValue &#x3D; 12&lt;/br&gt;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Specify the Business Object association ID for the saved search.</param>
        /// <param name="scope">Specify the scope name or ID for the saved search.</param>
        /// <param name="scopeowner">Specify the scope owner ID for the saved search. Use (None) when no scope owner exists.</param>
        /// <param name="searchid">Specify the internal ID for the saved search. Use \&quot;Run a saved search by name\&quot; if you do not have the internal ID.</param>
        /// <param name="searchTerm">Specify search text filter the results. Example: Use \&quot;Service Request\&quot; to filter Incident results to include only service requests. (optional)</param>
        /// <param name="pagenumber">Specify the page number of the result set to return. (optional)</param>
        /// <param name="pagesize">Specify the number of rows to return per page. (optional)</param>
        /// <param name="includeschema">Use to include the table schema of the saved search. If false, results contain the fieldid and field value without field information. Default is false. (optional)</param>
        /// <param name="resultsAsSimpleResultsList">Indicates if the results should be returned in a simple results list format or a table format. Default is a table format. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsSearchesSearchResultsResponse</returns>
        System.Threading.Tasks.Task<TrebuchetWebApiDataContractsSearchesSearchResultsResponse> SearchesGetSearchResultsByIdV1Async (string association, string scope, string scopeowner, string searchid, string searchTerm = null, int? pagenumber = null, int? pagesize = null, bool? includeschema = null, bool? resultsAsSimpleResultsList = null, string lang = null, string locale = null);

        /// <summary>
        /// Run a saved search by internal ID
        /// </summary>
        /// <remarks>
        /// Operation that returns the paged results of a saved search. When the search contains Prompts, the response contains the Prompt. Send the Prompt and the original operation parameters to  SearchResultsRequest to the getsearchresults ad-hoc http post operation.&lt;/br&gt;&lt;/br&gt;PromptType is a FieldSubType enum as described below:&lt;/br&gt;FieldSubType&lt;/br&gt;None &#x3D; 0&lt;/br&gt;Text &#x3D; 1&lt;/br&gt;Number &#x3D; 2&lt;/br&gt;DateTime &#x3D; 3&lt;/br&gt;Logical &#x3D; 4&lt;/br&gt;Binary &#x3D; 5&lt;/br&gt;DateOnly &#x3D; 6&lt;/br&gt;TimeOnly &#x3D; 7&lt;/br&gt;Json &#x3D; 8&lt;/br&gt;JsonArray &#x3D; 9&lt;/br&gt;Xml &#x3D; 10&lt;/br&gt;XmlCollection &#x3D; 11&lt;/br&gt;TimeValue &#x3D; 12&lt;/br&gt;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Specify the Business Object association ID for the saved search.</param>
        /// <param name="scope">Specify the scope name or ID for the saved search.</param>
        /// <param name="scopeowner">Specify the scope owner ID for the saved search. Use (None) when no scope owner exists.</param>
        /// <param name="searchid">Specify the internal ID for the saved search. Use \&quot;Run a saved search by name\&quot; if you do not have the internal ID.</param>
        /// <param name="searchTerm">Specify search text filter the results. Example: Use \&quot;Service Request\&quot; to filter Incident results to include only service requests. (optional)</param>
        /// <param name="pagenumber">Specify the page number of the result set to return. (optional)</param>
        /// <param name="pagesize">Specify the number of rows to return per page. (optional)</param>
        /// <param name="includeschema">Use to include the table schema of the saved search. If false, results contain the fieldid and field value without field information. Default is false. (optional)</param>
        /// <param name="resultsAsSimpleResultsList">Indicates if the results should be returned in a simple results list format or a table format. Default is a table format. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsSearchesSearchResultsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrebuchetWebApiDataContractsSearchesSearchResultsResponse>> SearchesGetSearchResultsByIdV1AsyncWithHttpInfo (string association, string scope, string scopeowner, string searchid, string searchTerm = null, int? pagenumber = null, int? pagesize = null, bool? includeschema = null, bool? resultsAsSimpleResultsList = null, string lang = null, string locale = null);
        /// <summary>
        /// Run a saved search by name
        /// </summary>
        /// <remarks>
        /// Operation that returns the paged results of a saved search. When the search contains Prompts, the response contains the Prompt. Send the Prompt and the original operation parameters to  SearchResultsRequest to the getsearchresults ad-hoc http post operation.&lt;/br&gt;&lt;/br&gt;PromptType is a FieldSubType enum as described below:&lt;/br&gt;FieldSubType&lt;/br&gt;None &#x3D; 0&lt;/br&gt;Text &#x3D; 1&lt;/br&gt;Number &#x3D; 2&lt;/br&gt;DateTime &#x3D; 3&lt;/br&gt;Logical &#x3D; 4&lt;/br&gt;Binary &#x3D; 5&lt;/br&gt;DateOnly &#x3D; 6&lt;/br&gt;TimeOnly &#x3D; 7&lt;/br&gt;Json &#x3D; 8&lt;/br&gt;JsonArray &#x3D; 9&lt;/br&gt;Xml &#x3D; 10&lt;/br&gt;XmlCollection &#x3D; 11&lt;/br&gt;TimeValue &#x3D; 12&lt;/br&gt;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Specify the Business Object association ID for the saved search.</param>
        /// <param name="scope">Specify the scope name or ID for the saved search.</param>
        /// <param name="scopeowner">Specify the scope owner ID for the saved search. Use (None) when no scope owner exists.</param>
        /// <param name="searchname">Specify the name of the saved search.</param>
        /// <param name="searchTerm">Specify search text filter the results. Example: Use \&quot;Service Request\&quot; to filter Incident results to include only service requests. (optional)</param>
        /// <param name="pagenumber">Specify the page number of the result set to return. (optional)</param>
        /// <param name="pagesize">Specify the number of rows to return per page. (optional)</param>
        /// <param name="includeschema">Use to include the table schema of the saved search. If false, results contain the fieldid and field value without field information. Default is false. (optional)</param>
        /// <param name="resultsAsSimpleResultsList">Indicates if the results should be returned in a simple results list format or a table format. Default is a table format. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsSearchesSearchResultsResponse</returns>
        System.Threading.Tasks.Task<TrebuchetWebApiDataContractsSearchesSearchResultsResponse> SearchesGetSearchResultsByNameV1Async (string association, string scope, string scopeowner, string searchname, string searchTerm = null, int? pagenumber = null, int? pagesize = null, bool? includeschema = null, bool? resultsAsSimpleResultsList = null, string lang = null, string locale = null);

        /// <summary>
        /// Run a saved search by name
        /// </summary>
        /// <remarks>
        /// Operation that returns the paged results of a saved search. When the search contains Prompts, the response contains the Prompt. Send the Prompt and the original operation parameters to  SearchResultsRequest to the getsearchresults ad-hoc http post operation.&lt;/br&gt;&lt;/br&gt;PromptType is a FieldSubType enum as described below:&lt;/br&gt;FieldSubType&lt;/br&gt;None &#x3D; 0&lt;/br&gt;Text &#x3D; 1&lt;/br&gt;Number &#x3D; 2&lt;/br&gt;DateTime &#x3D; 3&lt;/br&gt;Logical &#x3D; 4&lt;/br&gt;Binary &#x3D; 5&lt;/br&gt;DateOnly &#x3D; 6&lt;/br&gt;TimeOnly &#x3D; 7&lt;/br&gt;Json &#x3D; 8&lt;/br&gt;JsonArray &#x3D; 9&lt;/br&gt;Xml &#x3D; 10&lt;/br&gt;XmlCollection &#x3D; 11&lt;/br&gt;TimeValue &#x3D; 12&lt;/br&gt;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Specify the Business Object association ID for the saved search.</param>
        /// <param name="scope">Specify the scope name or ID for the saved search.</param>
        /// <param name="scopeowner">Specify the scope owner ID for the saved search. Use (None) when no scope owner exists.</param>
        /// <param name="searchname">Specify the name of the saved search.</param>
        /// <param name="searchTerm">Specify search text filter the results. Example: Use \&quot;Service Request\&quot; to filter Incident results to include only service requests. (optional)</param>
        /// <param name="pagenumber">Specify the page number of the result set to return. (optional)</param>
        /// <param name="pagesize">Specify the number of rows to return per page. (optional)</param>
        /// <param name="includeschema">Use to include the table schema of the saved search. If false, results contain the fieldid and field value without field information. Default is false. (optional)</param>
        /// <param name="resultsAsSimpleResultsList">Indicates if the results should be returned in a simple results list format or a table format. Default is a table format. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsSearchesSearchResultsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrebuchetWebApiDataContractsSearchesSearchResultsResponse>> SearchesGetSearchResultsByNameV1AsyncWithHttpInfo (string association, string scope, string scopeowner, string searchname, string searchTerm = null, int? pagenumber = null, int? pagesize = null, bool? includeschema = null, bool? resultsAsSimpleResultsList = null, string lang = null, string locale = null);
        /// <summary>
        /// Export an ad-hoc search
        /// </summary>
        /// <remarks>
        /// Operation that returns an ad-hoc search in a specified export format: 0&#x3D;CSV, 1&#x3D;Excel, 2&#x3D;Tab, 3&#x3D;Word, 4&#x3D;Custom Separator, 5&#x3D;Simple JSON. To execute a search with Prompts, the PromptId and Value are required in the Prompt request object.&lt;/br&gt;&lt;/br&gt;PromptType is a FieldSubType enum as described below:&lt;/br&gt;FieldSubType&lt;/br&gt;None &#x3D; 0&lt;/br&gt;Text &#x3D; 1&lt;/br&gt;Number &#x3D; 2&lt;/br&gt;DateTime &#x3D; 3&lt;/br&gt;Logical &#x3D; 4&lt;/br&gt;Binary &#x3D; 5&lt;/br&gt;DateOnly &#x3D; 6&lt;/br&gt;TimeOnly &#x3D; 7&lt;/br&gt;Json &#x3D; 8&lt;/br&gt;JsonArray &#x3D; 9&lt;/br&gt;Xml &#x3D; 10&lt;/br&gt;XmlCollection &#x3D; 11&lt;/br&gt;TimeValue &#x3D; 12&lt;/br&gt;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataRequest">Request object to specify search parameters and export format.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> SearchesGetSearchResultsExportAdHocV1Async (TrebuchetWebApiDataContractsSearchesExportSearchResultsRequest dataRequest, string lang = null, string locale = null);

        /// <summary>
        /// Export an ad-hoc search
        /// </summary>
        /// <remarks>
        /// Operation that returns an ad-hoc search in a specified export format: 0&#x3D;CSV, 1&#x3D;Excel, 2&#x3D;Tab, 3&#x3D;Word, 4&#x3D;Custom Separator, 5&#x3D;Simple JSON. To execute a search with Prompts, the PromptId and Value are required in the Prompt request object.&lt;/br&gt;&lt;/br&gt;PromptType is a FieldSubType enum as described below:&lt;/br&gt;FieldSubType&lt;/br&gt;None &#x3D; 0&lt;/br&gt;Text &#x3D; 1&lt;/br&gt;Number &#x3D; 2&lt;/br&gt;DateTime &#x3D; 3&lt;/br&gt;Logical &#x3D; 4&lt;/br&gt;Binary &#x3D; 5&lt;/br&gt;DateOnly &#x3D; 6&lt;/br&gt;TimeOnly &#x3D; 7&lt;/br&gt;Json &#x3D; 8&lt;/br&gt;JsonArray &#x3D; 9&lt;/br&gt;Xml &#x3D; 10&lt;/br&gt;XmlCollection &#x3D; 11&lt;/br&gt;TimeValue &#x3D; 12&lt;/br&gt;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataRequest">Request object to specify search parameters and export format.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> SearchesGetSearchResultsExportAdHocV1AsyncWithHttpInfo (TrebuchetWebApiDataContractsSearchesExportSearchResultsRequest dataRequest, string lang = null, string locale = null);
        /// <summary>
        /// Export a saved search by ID
        /// </summary>
        /// <remarks>
        /// Operation that returns the paged results of a saved search in a specified format. When the search contains Prompts, the response contains the Prompt. Send the Prompt and the original operation parameters to  SearchResultsRequest to the getsearchresultsexport ad-hoc http post operation.&lt;/br&gt;&lt;/br&gt;PromptType is a FieldSubType enum as described below:&lt;/br&gt;FieldSubType&lt;/br&gt;None &#x3D; 0&lt;/br&gt;Text &#x3D; 1&lt;/br&gt;Number &#x3D; 2&lt;/br&gt;DateTime &#x3D; 3&lt;/br&gt;Logical &#x3D; 4&lt;/br&gt;Binary &#x3D; 5&lt;/br&gt;DateOnly &#x3D; 6&lt;/br&gt;TimeOnly &#x3D; 7&lt;/br&gt;Json &#x3D; 8&lt;/br&gt;JsonArray &#x3D; 9&lt;/br&gt;Xml &#x3D; 10&lt;/br&gt;XmlCollection &#x3D; 11&lt;/br&gt;TimeValue &#x3D; 12&lt;/br&gt;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Specify the Business Object association ID for the saved search.</param>
        /// <param name="scope">Specify the scope name or ID for the saved search.</param>
        /// <param name="scopeowner">Specify the scope owner ID for the saved search. Use (None) when no scope owner exists.</param>
        /// <param name="searchid">Specify the internal ID for the saved search. Use \&quot;Run a saved search by name\&quot; if you do not have the internal ID.</param>
        /// <param name="exportformat">Specify the format of the export</param>
        /// <param name="searchTerm">Specify search text filter the results. Example: Use \&quot;Service Request\&quot; to filter Incident results to include only service requests. (optional)</param>
        /// <param name="pagenumber">Specify the page number of the result set to return. (optional)</param>
        /// <param name="pagesize">Specify the number of rows to return per page. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> SearchesGetSearchResultsExportByIdV1Async (string association, string scope, string scopeowner, string searchid, string exportformat, string searchTerm = null, int? pagenumber = null, int? pagesize = null, string lang = null, string locale = null);

        /// <summary>
        /// Export a saved search by ID
        /// </summary>
        /// <remarks>
        /// Operation that returns the paged results of a saved search in a specified format. When the search contains Prompts, the response contains the Prompt. Send the Prompt and the original operation parameters to  SearchResultsRequest to the getsearchresultsexport ad-hoc http post operation.&lt;/br&gt;&lt;/br&gt;PromptType is a FieldSubType enum as described below:&lt;/br&gt;FieldSubType&lt;/br&gt;None &#x3D; 0&lt;/br&gt;Text &#x3D; 1&lt;/br&gt;Number &#x3D; 2&lt;/br&gt;DateTime &#x3D; 3&lt;/br&gt;Logical &#x3D; 4&lt;/br&gt;Binary &#x3D; 5&lt;/br&gt;DateOnly &#x3D; 6&lt;/br&gt;TimeOnly &#x3D; 7&lt;/br&gt;Json &#x3D; 8&lt;/br&gt;JsonArray &#x3D; 9&lt;/br&gt;Xml &#x3D; 10&lt;/br&gt;XmlCollection &#x3D; 11&lt;/br&gt;TimeValue &#x3D; 12&lt;/br&gt;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Specify the Business Object association ID for the saved search.</param>
        /// <param name="scope">Specify the scope name or ID for the saved search.</param>
        /// <param name="scopeowner">Specify the scope owner ID for the saved search. Use (None) when no scope owner exists.</param>
        /// <param name="searchid">Specify the internal ID for the saved search. Use \&quot;Run a saved search by name\&quot; if you do not have the internal ID.</param>
        /// <param name="exportformat">Specify the format of the export</param>
        /// <param name="searchTerm">Specify search text filter the results. Example: Use \&quot;Service Request\&quot; to filter Incident results to include only service requests. (optional)</param>
        /// <param name="pagenumber">Specify the page number of the result set to return. (optional)</param>
        /// <param name="pagesize">Specify the number of rows to return per page. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> SearchesGetSearchResultsExportByIdV1AsyncWithHttpInfo (string association, string scope, string scopeowner, string searchid, string exportformat, string searchTerm = null, int? pagenumber = null, int? pagesize = null, string lang = null, string locale = null);
        /// <summary>
        /// Export a saved search by name
        /// </summary>
        /// <remarks>
        /// Operation that returns the paged results of a saved search in a specified format. When the search contains Prompts, the response contains the Prompt. Send the Prompt and the original operation parameters to  SearchResultsRequest to the getsearchresultsexport ad-hoc http post operation.&lt;/br&gt;&lt;/br&gt;PromptType is a FieldSubType enum as described below:&lt;/br&gt;FieldSubType&lt;/br&gt;None &#x3D; 0&lt;/br&gt;Text &#x3D; 1&lt;/br&gt;Number &#x3D; 2&lt;/br&gt;DateTime &#x3D; 3&lt;/br&gt;Logical &#x3D; 4&lt;/br&gt;Binary &#x3D; 5&lt;/br&gt;DateOnly &#x3D; 6&lt;/br&gt;TimeOnly &#x3D; 7&lt;/br&gt;Json &#x3D; 8&lt;/br&gt;JsonArray &#x3D; 9&lt;/br&gt;Xml &#x3D; 10&lt;/br&gt;XmlCollection &#x3D; 11&lt;/br&gt;TimeValue &#x3D; 12&lt;/br&gt;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Specify the Business Object association ID for the saved search.</param>
        /// <param name="scope">Specify the scope name or ID for the saved search.</param>
        /// <param name="scopeowner">Specify the scope owner ID for the saved search. Use (None) when no scope owner exists.</param>
        /// <param name="searchname">Specify the name of the saved search.</param>
        /// <param name="exportformat">Specify the format of the export</param>
        /// <param name="searchTerm">Specify search text filter the results. Example: Use \&quot;Service Request\&quot; to filter Incident results to include only service requests. (optional)</param>
        /// <param name="pagenumber">Specify the page number of the result set to return. (optional)</param>
        /// <param name="pagesize">Specify the number of rows to return per page. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> SearchesGetSearchResultsExportByNameV1Async (string association, string scope, string scopeowner, string searchname, string exportformat, string searchTerm = null, int? pagenumber = null, int? pagesize = null, string lang = null, string locale = null);

        /// <summary>
        /// Export a saved search by name
        /// </summary>
        /// <remarks>
        /// Operation that returns the paged results of a saved search in a specified format. When the search contains Prompts, the response contains the Prompt. Send the Prompt and the original operation parameters to  SearchResultsRequest to the getsearchresultsexport ad-hoc http post operation.&lt;/br&gt;&lt;/br&gt;PromptType is a FieldSubType enum as described below:&lt;/br&gt;FieldSubType&lt;/br&gt;None &#x3D; 0&lt;/br&gt;Text &#x3D; 1&lt;/br&gt;Number &#x3D; 2&lt;/br&gt;DateTime &#x3D; 3&lt;/br&gt;Logical &#x3D; 4&lt;/br&gt;Binary &#x3D; 5&lt;/br&gt;DateOnly &#x3D; 6&lt;/br&gt;TimeOnly &#x3D; 7&lt;/br&gt;Json &#x3D; 8&lt;/br&gt;JsonArray &#x3D; 9&lt;/br&gt;Xml &#x3D; 10&lt;/br&gt;XmlCollection &#x3D; 11&lt;/br&gt;TimeValue &#x3D; 12&lt;/br&gt;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Specify the Business Object association ID for the saved search.</param>
        /// <param name="scope">Specify the scope name or ID for the saved search.</param>
        /// <param name="scopeowner">Specify the scope owner ID for the saved search. Use (None) when no scope owner exists.</param>
        /// <param name="searchname">Specify the name of the saved search.</param>
        /// <param name="exportformat">Specify the format of the export</param>
        /// <param name="searchTerm">Specify search text filter the results. Example: Use \&quot;Service Request\&quot; to filter Incident results to include only service requests. (optional)</param>
        /// <param name="pagenumber">Specify the page number of the result set to return. (optional)</param>
        /// <param name="pagesize">Specify the number of rows to return per page. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> SearchesGetSearchResultsExportByNameV1AsyncWithHttpInfo (string association, string scope, string scopeowner, string searchname, string exportformat, string searchTerm = null, int? pagenumber = null, int? pagesize = null, string lang = null, string locale = null);
        #endregion Asynchronous Operations
    }
}