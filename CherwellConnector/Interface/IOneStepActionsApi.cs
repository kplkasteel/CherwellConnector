using CherwellConnector.Client;
using CherwellConnector.Model;

namespace CherwellConnector.Interface
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IOneStepActionsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get One-Step Actions by Folder
        /// </summary>
        /// <remarks>
        /// Operation to get One-Step Actions by Association, Scope, Scope Owner in a specific folder.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Business Object association to get One-Step Actions for</param>
        /// <param name="scope">Scope to get One-Step Actions for</param>
        /// <param name="scopeowner">Scope owner to get One-Step Actions for</param>
        /// <param name="folder">Folder to get One-Step Actions from</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsCoreManagerData</returns>
        TrebuchetWebApiDataContractsCoreManagerData OneStepActionsGetOneStepActionsByAssociationScopeScopeOwnerFolderV1 (string association, string scope, string scopeowner, string folder, bool? links = null, string lang = null, string locale = null);

        /// <summary>
        /// Get One-Step Actions by Folder
        /// </summary>
        /// <remarks>
        /// Operation to get One-Step Actions by Association, Scope, Scope Owner in a specific folder.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Business Object association to get One-Step Actions for</param>
        /// <param name="scope">Scope to get One-Step Actions for</param>
        /// <param name="scopeowner">Scope owner to get One-Step Actions for</param>
        /// <param name="folder">Folder to get One-Step Actions from</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsCoreManagerData</returns>
        ApiResponse<TrebuchetWebApiDataContractsCoreManagerData> OneStepActionsGetOneStepActionsByAssociationScopeScopeOwnerFolderV1WithHttpInfo (string association, string scope, string scopeowner, string folder, bool? links = null, string lang = null, string locale = null);
        /// <summary>
        /// Get One-Step Actions by Scope Owner
        /// </summary>
        /// <remarks>
        /// Operation to get One-Step Actions by Association, Scope, Scope Owner
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Business Object association to get One-Step Actions for</param>
        /// <param name="scope">Scope to get One-Step Actions for</param>
        /// <param name="scopeowner">Scope owner to get One-Step Actions for</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsCoreManagerData</returns>
        TrebuchetWebApiDataContractsCoreManagerData OneStepActionsGetOneStepActionsByAssociationScopeScopeOwnerV1 (string association, string scope, string scopeowner, bool? links = null, string lang = null, string locale = null);

        /// <summary>
        /// Get One-Step Actions by Scope Owner
        /// </summary>
        /// <remarks>
        /// Operation to get One-Step Actions by Association, Scope, Scope Owner
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Business Object association to get One-Step Actions for</param>
        /// <param name="scope">Scope to get One-Step Actions for</param>
        /// <param name="scopeowner">Scope owner to get One-Step Actions for</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsCoreManagerData</returns>
        ApiResponse<TrebuchetWebApiDataContractsCoreManagerData> OneStepActionsGetOneStepActionsByAssociationScopeScopeOwnerV1WithHttpInfo (string association, string scope, string scopeowner, bool? links = null, string lang = null, string locale = null);
        /// <summary>
        /// Get One-Step Actions by Scope
        /// </summary>
        /// <remarks>
        /// Operation to get One-Step Actions by Association, Scope
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Business Object association to get One-Step Actions for</param>
        /// <param name="scope">Scope to get One-Step Actions for</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsCoreManagerData</returns>
        TrebuchetWebApiDataContractsCoreManagerData OneStepActionsGetOneStepActionsByAssociationScopeV1 (string association, string scope, bool? links = null, string lang = null, string locale = null);

        /// <summary>
        /// Get One-Step Actions by Scope
        /// </summary>
        /// <remarks>
        /// Operation to get One-Step Actions by Association, Scope
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Business Object association to get One-Step Actions for</param>
        /// <param name="scope">Scope to get One-Step Actions for</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsCoreManagerData</returns>
        ApiResponse<TrebuchetWebApiDataContractsCoreManagerData> OneStepActionsGetOneStepActionsByAssociationScopeV1WithHttpInfo (string association, string scope, bool? links = null, string lang = null, string locale = null);
        /// <summary>
        /// Get One-Step Actions by Association
        /// </summary>
        /// <remarks>
        /// Operation to get One-Step Actions by Association
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Business Object association to get One-Step Actions for</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsCoreManagerData</returns>
        TrebuchetWebApiDataContractsCoreManagerData OneStepActionsGetOneStepActionsByAssociationV1 (string association, bool? links = null, string lang = null, string locale = null);

        /// <summary>
        /// Get One-Step Actions by Association
        /// </summary>
        /// <remarks>
        /// Operation to get One-Step Actions by Association
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Business Object association to get One-Step Actions for</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsCoreManagerData</returns>
        ApiResponse<TrebuchetWebApiDataContractsCoreManagerData> OneStepActionsGetOneStepActionsByAssociationV1WithHttpInfo (string association, bool? links = null, string lang = null, string locale = null);
        /// <summary>
        /// Get One-Step Actions by default Association
        /// </summary>
        /// <remarks>
        /// Operation to get One-Step Actions by default Association
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsCoreManagerData</returns>
        TrebuchetWebApiDataContractsCoreManagerData OneStepActionsGetOneStepActionsV1 (bool? links = null, string lang = null, string locale = null);

        /// <summary>
        /// Get One-Step Actions by default Association
        /// </summary>
        /// <remarks>
        /// Operation to get One-Step Actions by default Association
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsCoreManagerData</returns>
        ApiResponse<TrebuchetWebApiDataContractsCoreManagerData> OneStepActionsGetOneStepActionsV1WithHttpInfo (bool? links = null, string lang = null, string locale = null);
        /// <summary>
        /// Run a One-Step Action for a Business Object record
        /// </summary>
        /// <remarks>
        /// Operation to run a One-Step Action for a Business Object record by Business Object ID and Business Object Record ID.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="standinkey">The key to find the One-Step Action to run</param>
        /// <param name="busobid">Specify the Business Object ID.</param>
        /// <param name="busobrecid">Specify the Business Object record ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsOneStepActionsOneStepActionResponse</returns>
        TrebuchetWebApiDataContractsOneStepActionsOneStepActionResponse OneStepActionsRunOneStepActionByKeyForRecordByRecIdV1 (string standinkey, string busobid, string busobrecid, string lang = null, string locale = null);

        /// <summary>
        /// Run a One-Step Action for a Business Object record
        /// </summary>
        /// <remarks>
        /// Operation to run a One-Step Action for a Business Object record by Business Object ID and Business Object Record ID.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="standinkey">The key to find the One-Step Action to run</param>
        /// <param name="busobid">Specify the Business Object ID.</param>
        /// <param name="busobrecid">Specify the Business Object record ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsOneStepActionsOneStepActionResponse</returns>
        ApiResponse<TrebuchetWebApiDataContractsOneStepActionsOneStepActionResponse> OneStepActionsRunOneStepActionByKeyForRecordByRecIdV1WithHttpInfo (string standinkey, string busobid, string busobrecid, string lang = null, string locale = null);
        /// <summary>
        /// Run a stand alone One-Step Action
        /// </summary>
        /// <remarks>
        /// Operation to run a One-Step Action that doesn&#39;t run against a Business Object Record.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="standinkey">The key to find the One-Step Action to run</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsOneStepActionsOneStepActionResponse</returns>
        TrebuchetWebApiDataContractsOneStepActionsOneStepActionResponse OneStepActionsRunOneStepActionByStandInKeyV1 (string standinkey, string lang = null, string locale = null);

        /// <summary>
        /// Run a stand alone One-Step Action
        /// </summary>
        /// <remarks>
        /// Operation to run a One-Step Action that doesn&#39;t run against a Business Object Record.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="standinkey">The key to find the One-Step Action to run</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsOneStepActionsOneStepActionResponse</returns>
        ApiResponse<TrebuchetWebApiDataContractsOneStepActionsOneStepActionResponse> OneStepActionsRunOneStepActionByStandInKeyV1WithHttpInfo (string standinkey, string lang = null, string locale = null);
        /// <summary>
        /// Run a One-Step Action using a OneStepActionRequest
        /// </summary>
        /// <remarks>
        /// Operation to run a One-Step Action using a OneStepActionRequest. This request is used to start a One-Step Action run with additional information such as prompt values.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object containing all the properties need to start a One-Step Action.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsOneStepActionsOneStepActionResponse</returns>
        TrebuchetWebApiDataContractsOneStepActionsOneStepActionResponse OneStepActionsRunOneStepActionV1 (TrebuchetWebApiDataContractsOneStepActionsOneStepActionRequest request, string lang = null, string locale = null);

        /// <summary>
        /// Run a One-Step Action using a OneStepActionRequest
        /// </summary>
        /// <remarks>
        /// Operation to run a One-Step Action using a OneStepActionRequest. This request is used to start a One-Step Action run with additional information such as prompt values.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object containing all the properties need to start a One-Step Action.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsOneStepActionsOneStepActionResponse</returns>
        ApiResponse<TrebuchetWebApiDataContractsOneStepActionsOneStepActionResponse> OneStepActionsRunOneStepActionV1WithHttpInfo (TrebuchetWebApiDataContractsOneStepActionsOneStepActionRequest request, string lang = null, string locale = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get One-Step Actions by Folder
        /// </summary>
        /// <remarks>
        /// Operation to get One-Step Actions by Association, Scope, Scope Owner in a specific folder.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Business Object association to get One-Step Actions for</param>
        /// <param name="scope">Scope to get One-Step Actions for</param>
        /// <param name="scopeowner">Scope owner to get One-Step Actions for</param>
        /// <param name="folder">Folder to get One-Step Actions from</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsCoreManagerData</returns>
        System.Threading.Tasks.Task<TrebuchetWebApiDataContractsCoreManagerData> OneStepActionsGetOneStepActionsByAssociationScopeScopeOwnerFolderV1Async (string association, string scope, string scopeowner, string folder, bool? links = null, string lang = null, string locale = null);

        /// <summary>
        /// Get One-Step Actions by Folder
        /// </summary>
        /// <remarks>
        /// Operation to get One-Step Actions by Association, Scope, Scope Owner in a specific folder.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Business Object association to get One-Step Actions for</param>
        /// <param name="scope">Scope to get One-Step Actions for</param>
        /// <param name="scopeowner">Scope owner to get One-Step Actions for</param>
        /// <param name="folder">Folder to get One-Step Actions from</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsCoreManagerData)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrebuchetWebApiDataContractsCoreManagerData>> OneStepActionsGetOneStepActionsByAssociationScopeScopeOwnerFolderV1AsyncWithHttpInfo (string association, string scope, string scopeowner, string folder, bool? links = null, string lang = null, string locale = null);
        /// <summary>
        /// Get One-Step Actions by Scope Owner
        /// </summary>
        /// <remarks>
        /// Operation to get One-Step Actions by Association, Scope, Scope Owner
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Business Object association to get One-Step Actions for</param>
        /// <param name="scope">Scope to get One-Step Actions for</param>
        /// <param name="scopeowner">Scope owner to get One-Step Actions for</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsCoreManagerData</returns>
        System.Threading.Tasks.Task<TrebuchetWebApiDataContractsCoreManagerData> OneStepActionsGetOneStepActionsByAssociationScopeScopeOwnerV1Async (string association, string scope, string scopeowner, bool? links = null, string lang = null, string locale = null);

        /// <summary>
        /// Get One-Step Actions by Scope Owner
        /// </summary>
        /// <remarks>
        /// Operation to get One-Step Actions by Association, Scope, Scope Owner
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Business Object association to get One-Step Actions for</param>
        /// <param name="scope">Scope to get One-Step Actions for</param>
        /// <param name="scopeowner">Scope owner to get One-Step Actions for</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsCoreManagerData)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrebuchetWebApiDataContractsCoreManagerData>> OneStepActionsGetOneStepActionsByAssociationScopeScopeOwnerV1AsyncWithHttpInfo (string association, string scope, string scopeowner, bool? links = null, string lang = null, string locale = null);
        /// <summary>
        /// Get One-Step Actions by Scope
        /// </summary>
        /// <remarks>
        /// Operation to get One-Step Actions by Association, Scope
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Business Object association to get One-Step Actions for</param>
        /// <param name="scope">Scope to get One-Step Actions for</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsCoreManagerData</returns>
        System.Threading.Tasks.Task<TrebuchetWebApiDataContractsCoreManagerData> OneStepActionsGetOneStepActionsByAssociationScopeV1Async (string association, string scope, bool? links = null, string lang = null, string locale = null);

        /// <summary>
        /// Get One-Step Actions by Scope
        /// </summary>
        /// <remarks>
        /// Operation to get One-Step Actions by Association, Scope
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Business Object association to get One-Step Actions for</param>
        /// <param name="scope">Scope to get One-Step Actions for</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsCoreManagerData)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrebuchetWebApiDataContractsCoreManagerData>> OneStepActionsGetOneStepActionsByAssociationScopeV1AsyncWithHttpInfo (string association, string scope, bool? links = null, string lang = null, string locale = null);
        /// <summary>
        /// Get One-Step Actions by Association
        /// </summary>
        /// <remarks>
        /// Operation to get One-Step Actions by Association
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Business Object association to get One-Step Actions for</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsCoreManagerData</returns>
        System.Threading.Tasks.Task<TrebuchetWebApiDataContractsCoreManagerData> OneStepActionsGetOneStepActionsByAssociationV1Async (string association, bool? links = null, string lang = null, string locale = null);

        /// <summary>
        /// Get One-Step Actions by Association
        /// </summary>
        /// <remarks>
        /// Operation to get One-Step Actions by Association
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Business Object association to get One-Step Actions for</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsCoreManagerData)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrebuchetWebApiDataContractsCoreManagerData>> OneStepActionsGetOneStepActionsByAssociationV1AsyncWithHttpInfo (string association, bool? links = null, string lang = null, string locale = null);
        /// <summary>
        /// Get One-Step Actions by default Association
        /// </summary>
        /// <remarks>
        /// Operation to get One-Step Actions by default Association
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsCoreManagerData</returns>
        System.Threading.Tasks.Task<TrebuchetWebApiDataContractsCoreManagerData> OneStepActionsGetOneStepActionsV1Async (bool? links = null, string lang = null, string locale = null);

        /// <summary>
        /// Get One-Step Actions by default Association
        /// </summary>
        /// <remarks>
        /// Operation to get One-Step Actions by default Association
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsCoreManagerData)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrebuchetWebApiDataContractsCoreManagerData>> OneStepActionsGetOneStepActionsV1AsyncWithHttpInfo (bool? links = null, string lang = null, string locale = null);
        /// <summary>
        /// Run a One-Step Action for a Business Object record
        /// </summary>
        /// <remarks>
        /// Operation to run a One-Step Action for a Business Object record by Business Object ID and Business Object Record ID.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="standinkey">The key to find the One-Step Action to run</param>
        /// <param name="busobid">Specify the Business Object ID.</param>
        /// <param name="busobrecid">Specify the Business Object record ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsOneStepActionsOneStepActionResponse</returns>
        System.Threading.Tasks.Task<TrebuchetWebApiDataContractsOneStepActionsOneStepActionResponse> OneStepActionsRunOneStepActionByKeyForRecordByRecIdV1Async (string standinkey, string busobid, string busobrecid, string lang = null, string locale = null);

        /// <summary>
        /// Run a One-Step Action for a Business Object record
        /// </summary>
        /// <remarks>
        /// Operation to run a One-Step Action for a Business Object record by Business Object ID and Business Object Record ID.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="standinkey">The key to find the One-Step Action to run</param>
        /// <param name="busobid">Specify the Business Object ID.</param>
        /// <param name="busobrecid">Specify the Business Object record ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsOneStepActionsOneStepActionResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrebuchetWebApiDataContractsOneStepActionsOneStepActionResponse>> OneStepActionsRunOneStepActionByKeyForRecordByRecIdV1AsyncWithHttpInfo (string standinkey, string busobid, string busobrecid, string lang = null, string locale = null);
        /// <summary>
        /// Run a stand alone One-Step Action
        /// </summary>
        /// <remarks>
        /// Operation to run a One-Step Action that doesn&#39;t run against a Business Object Record.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="standinkey">The key to find the One-Step Action to run</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsOneStepActionsOneStepActionResponse</returns>
        System.Threading.Tasks.Task<TrebuchetWebApiDataContractsOneStepActionsOneStepActionResponse> OneStepActionsRunOneStepActionByStandInKeyV1Async (string standinkey, string lang = null, string locale = null);

        /// <summary>
        /// Run a stand alone One-Step Action
        /// </summary>
        /// <remarks>
        /// Operation to run a One-Step Action that doesn&#39;t run against a Business Object Record.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="standinkey">The key to find the One-Step Action to run</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsOneStepActionsOneStepActionResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrebuchetWebApiDataContractsOneStepActionsOneStepActionResponse>> OneStepActionsRunOneStepActionByStandInKeyV1AsyncWithHttpInfo (string standinkey, string lang = null, string locale = null);
        /// <summary>
        /// Run a One-Step Action using a OneStepActionRequest
        /// </summary>
        /// <remarks>
        /// Operation to run a One-Step Action using a OneStepActionRequest. This request is used to start a One-Step Action run with additional information such as prompt values.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object containing all the properties need to start a One-Step Action.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsOneStepActionsOneStepActionResponse</returns>
        System.Threading.Tasks.Task<TrebuchetWebApiDataContractsOneStepActionsOneStepActionResponse> OneStepActionsRunOneStepActionV1Async (TrebuchetWebApiDataContractsOneStepActionsOneStepActionRequest request, string lang = null, string locale = null);

        /// <summary>
        /// Run a One-Step Action using a OneStepActionRequest
        /// </summary>
        /// <remarks>
        /// Operation to run a One-Step Action using a OneStepActionRequest. This request is used to start a One-Step Action run with additional information such as prompt values.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object containing all the properties need to start a One-Step Action.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsOneStepActionsOneStepActionResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrebuchetWebApiDataContractsOneStepActionsOneStepActionResponse>> OneStepActionsRunOneStepActionV1AsyncWithHttpInfo (TrebuchetWebApiDataContractsOneStepActionsOneStepActionRequest request, string lang = null, string locale = null);
        #endregion Asynchronous Operations
    }
}