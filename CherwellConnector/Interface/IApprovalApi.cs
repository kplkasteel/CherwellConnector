using CherwellConnector.Client;
using CherwellConnector.Model;

namespace CherwellConnector.Interface
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IApprovalApi : IApiAccessor
    {
       
        /// <summary>
        /// Action an Approval
        /// </summary>
        /// <remarks>
        /// Operation that actions an Approval Business Object. Use this method, passing either approve, abstain or deny to update the Business Object&#39;s state
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="approvalRecId"></param>
        /// <param name="approvalAction"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsBusinessObjectSaveResponse</returns>
        TrebuchetWebApiDataContractsBusinessObjectSaveResponse ApprovalActionApprovalV1 (string approvalRecId, string approvalAction, string lang = null, string locale = null);

       
        /// <summary>
        /// Get Approval
        /// </summary>
        /// <remarks>
        /// Operation that returns an Approval Business Object.  Use the provided links to action the Approval
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="approvalRecId"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsApprovalApprovalReadResponse</returns>
        ApprovalReadResponse ApprovalGetApprovalByRecIdV1 (string approvalRecId, string lang = null, string locale = null);

       
        /// <summary>
        /// Get all waiting Approvals for the current user
        /// </summary>
        /// <remarks>
        /// Operation that returns a list of Approval Business Objects that are in a state of &#39;Waiting&#39; for the current user.  Use the provided links to action the Approval
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsApprovalGetApprovalsResponse</returns>
        ApprovalsResponse ApprovalGetMyApprovalsV1 (string lang = null, string locale = null);

        
        /// <summary>
        /// Get all waiting approvals that were created by the current user
        /// </summary>
        /// <remarks>
        /// Operation that returns a list of Approval Business Objects that are in a state of &#39;Waiting&#39; that were created by the current user.  Use the provided links to action the Approval
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsApprovalGetApprovalsResponse</returns>
        ApprovalsResponse ApprovalGetMyPendingApprovalsV1 (string lang = null, string locale = null);

    }
}