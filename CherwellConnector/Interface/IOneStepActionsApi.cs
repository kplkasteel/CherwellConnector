using CherwellConnector.Client;
using CherwellConnector.Model;

namespace CherwellConnector.Interface
{
    /// <summary>
    ///     Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IOneStepActionsApi : IApiAccessor
    {
        /// <summary>
        ///     Get One-Step Actions by Folder
        /// </summary>
        /// <remarks>
        ///     Operation to get One-Step Actions by Association, Scope, Scope Owner in a specific folder.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Business Object association to get One-Step Actions for</param>
        /// <param name="scope">Scope to get One-Step Actions for</param>
        /// <param name="scopeowner">Scope owner to get One-Step Actions for</param>
        /// <param name="folder">Folder to get One-Step Actions from</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>ManagerData</returns>
        ManagerData OneStepActionsGetOneStepActionsByAssociationScopeScopeOwnerFolderV1(string association,
            string scope, string scopeowner, string folder, bool? links = null, string lang = null,
            string locale = null);

        /// <summary>
        ///     Get One-Step Actions by Scope Owner
        /// </summary>
        /// <remarks>
        ///     Operation to get One-Step Actions by Association, Scope, Scope Owner
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Business Object association to get One-Step Actions for</param>
        /// <param name="scope">Scope to get One-Step Actions for</param>
        /// <param name="scopeowner">Scope owner to get One-Step Actions for</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>ManagerData</returns>
        ManagerData OneStepActionsGetOneStepActionsByAssociationScopeScopeOwnerV1(string association, string scope,
            string scopeowner, bool? links = null, string lang = null, string locale = null);

        /// <summary>
        ///     Get One-Step Actions by Scope
        /// </summary>
        /// <remarks>
        ///     Operation to get One-Step Actions by Association, Scope
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Business Object association to get One-Step Actions for</param>
        /// <param name="scope">Scope to get One-Step Actions for</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>ManagerData</returns>
        ManagerData OneStepActionsGetOneStepActionsByAssociationScopeV1(string association, string scope,
            bool? links = null, string lang = null, string locale = null);

        /// <summary>
        ///     Get One-Step Actions by Association
        /// </summary>
        /// <remarks>
        ///     Operation to get One-Step Actions by Association
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Business Object association to get One-Step Actions for</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>ManagerData</returns>
        ManagerData OneStepActionsGetOneStepActionsByAssociationV1(string association, bool? links = null,
            string lang = null, string locale = null);

        /// <summary>
        ///     Get One-Step Actions by default Association
        /// </summary>
        /// <remarks>
        ///     Operation to get One-Step Actions by default Association
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>ManagerData</returns>
        ManagerData OneStepActionsGetOneStepActionsV1(bool? links = null, string lang = null, string locale = null);

        /// <summary>
        ///     Run a One-Step Action for a Business Object record
        /// </summary>
        /// <remarks>
        ///     Operation to run a One-Step Action for a Business Object record by Business Object ID and Business Object Record
        ///     ID.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="standinkey">The key to find the One-Step Action to run</param>
        /// <param name="busobid">Specify the Business Object ID.</param>
        /// <param name="busobrecid">Specify the Business Object record ID.</param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>OneStepActionResponse</returns>
        OneStepActionResponse OneStepActionsRunOneStepActionByKeyForRecordByRecIdV1(string standinkey, string busobid,
            string busobrecid, string lang = null, string locale = null);

        /// <summary>
        ///     Run a stand alone One-Step Action
        /// </summary>
        /// <remarks>
        ///     Operation to run a One-Step Action that doesn&#39;t run against a Business Object Record.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="standinkey">The key to find the One-Step Action to run</param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>OneStepActionResponse</returns>
        OneStepActionResponse OneStepActionsRunOneStepActionByStandInKeyV1(string standinkey, string lang = null,
            string locale = null);

        /// <summary>
        ///     Run a One-Step Action using a OneStepActionRequest
        /// </summary>
        /// <remarks>
        ///     Operation to run a One-Step Action using a OneStepActionRequest. This request is used to start a One-Step Action
        ///     run with additional information such as prompt values.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object containing all the properties need to start a One-Step Action.</param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>OneStepActionResponse</returns>
        OneStepActionResponse OneStepActionsRunOneStepActionV1(OneStepActionRequest request, string lang = null,
            string locale = null);
    }
}